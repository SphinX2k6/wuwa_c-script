using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000722 RID: 1826
	public class ConfigPinballMonsterBySubTypeId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002ADC RID: 10972 RVA: 0x0014BA58 File Offset: 0x00149C58
		static ConfigPinballMonsterBySubTypeId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballMonsterBySubTypeId.CreateStaticDefaultValue), new Action(ConfigPinballMonsterBySubTypeId.ResetStaticDefaultValue));
		}

		// Token: 0x06002ADD RID: 10973 RVA: 0x0014BA78 File Offset: 0x00149C78
		public static void CreateStaticDefaultValue()
		{
			ConfigPinballMonsterBySubTypeId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPinballMonsterBySubTypeId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_pinballbattle.db"),
				new ValueTuple<string, object>("文件", "x.星弹奇游_怪物.xlsx"),
				new ValueTuple<string, object>("表名", "PinballMonster"),
				new ValueTuple<string, object>("语句", "select BinData from `PinballMonster` where SimpleCombatSubtypeId=?")
			});
		}

		// Token: 0x06002ADE RID: 10974 RVA: 0x0014BAF7 File Offset: 0x00149CF7
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballMonsterBySubTypeId.LogPair = null;
			ConfigPinballMonsterBySubTypeId.HandleId = 0;
		}

		// Token: 0x06002ADF RID: 10975 RVA: 0x0014BB05 File Offset: 0x00149D05
		public static void Init()
		{
			ConfigPinballMonsterBySubTypeId.HandleId = ConfigCommon.InitDataStatement(ConfigPinballMonsterBySubTypeId.HandleId, "db_pinballbattle.db", "select BinData from `PinballMonster` where SimpleCombatSubtypeId=?");
		}

		// Token: 0x06002AE0 RID: 10976 RVA: 0x0014BB20 File Offset: 0x00149D20
		public static PinballMonster? GetConfig(int p0SimpleCombatSubtypeId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPinballMonsterBySubTypeId.HandleId, ConfigPinballMonsterBySubTypeId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballMonsterBySubTypeId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SimpleCombatSubtypeId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PinballMonster?(PinballMonster.GetRootAsPinballMonster(configBuffer));
				}
			}
			ConfigPinballMonsterBySubTypeId.LogPair.Clear();
			ConfigPinballMonsterBySubTypeId.LogPair.Add(new ValueTuple<string, object>("SimpleCombatSubtypeId", p0SimpleCombatSubtypeId));
			if (!ConfigCommon.BindInt(ConfigPinballMonsterBySubTypeId.HandleId, 1, p0SimpleCombatSubtypeId, ConfigPinballMonsterBySubTypeId.LogPair) || ConfigCommon.Step(ConfigPinballMonsterBySubTypeId.HandleId, true, ConfigPinballMonsterBySubTypeId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPinballMonsterBySubTypeId.HandleId, ConfigPinballMonsterBySubTypeId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPinballMonsterBySubTypeId.HandleId, 0, ConfigPinballMonsterBySubTypeId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPinballMonsterBySubTypeId.HandleId, ConfigPinballMonsterBySubTypeId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PinballMonster rootAsPinballMonster = PinballMonster.GetRootAsPinballMonster(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballMonsterBySubTypeId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SimpleCombatSubtypeId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPinballMonsterBySubTypeId.HandleId, ConfigPinballMonsterBySubTypeId.LogPair);
			return new PinballMonster?(rootAsPinballMonster);
		}

		// Token: 0x040031D4 RID: 12756
		private const string DB = "db_pinballbattle.db";

		// Token: 0x040031D5 RID: 12757
		private const string FILE = "x.星弹奇游_怪物.xlsx";

		// Token: 0x040031D6 RID: 12758
		private const string TABLE = "PinballMonster";

		// Token: 0x040031D7 RID: 12759
		private const string COMMAND = "select BinData from `PinballMonster` where SimpleCombatSubtypeId=?";

		// Token: 0x040031D8 RID: 12760
		private const string KEY_PREFIX = "PinballMonsterBySubTypeId";

		// Token: 0x040031D9 RID: 12761
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040031DA RID: 12762
		private static int HandleId;
	}
}
