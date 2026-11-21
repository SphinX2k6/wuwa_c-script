using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200073A RID: 1850
	public class ConfigPinballMonsterBySubTypeId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002B6C RID: 11116 RVA: 0x001524D4 File Offset: 0x001506D4
		static ConfigPinballMonsterBySubTypeId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballMonsterBySubTypeId.CreateStaticDefaultValue), new Action(ConfigPinballMonsterBySubTypeId.ResetStaticDefaultValue));
		}

		// Token: 0x06002B6D RID: 11117 RVA: 0x001524F4 File Offset: 0x001506F4
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

		// Token: 0x06002B6E RID: 11118 RVA: 0x00152573 File Offset: 0x00150773
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballMonsterBySubTypeId.LogPair = null;
			ConfigPinballMonsterBySubTypeId.HandleId = 0;
		}

		// Token: 0x06002B6F RID: 11119 RVA: 0x00152581 File Offset: 0x00150781
		public static void Init()
		{
			ConfigPinballMonsterBySubTypeId.HandleId = ConfigCommon.InitDataStatement(ConfigPinballMonsterBySubTypeId.HandleId, "db_pinballbattle.db", "select BinData from `PinballMonster` where SimpleCombatSubtypeId=?");
		}

		// Token: 0x06002B70 RID: 11120 RVA: 0x0015259C File Offset: 0x0015079C
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

		// Token: 0x0400327C RID: 12924
		private const string DB = "db_pinballbattle.db";

		// Token: 0x0400327D RID: 12925
		private const string FILE = "x.星弹奇游_怪物.xlsx";

		// Token: 0x0400327E RID: 12926
		private const string TABLE = "PinballMonster";

		// Token: 0x0400327F RID: 12927
		private const string COMMAND = "select BinData from `PinballMonster` where SimpleCombatSubtypeId=?";

		// Token: 0x04003280 RID: 12928
		private const string KEY_PREFIX = "PinballMonsterBySubTypeId";

		// Token: 0x04003281 RID: 12929
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003282 RID: 12930
		private static int HandleId;
	}
}
