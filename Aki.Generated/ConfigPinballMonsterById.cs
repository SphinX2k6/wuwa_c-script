using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000721 RID: 1825
	public class ConfigPinballMonsterById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002AD6 RID: 10966 RVA: 0x0014B810 File Offset: 0x00149A10
		static ConfigPinballMonsterById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballMonsterById.CreateStaticDefaultValue), new Action(ConfigPinballMonsterById.ResetStaticDefaultValue));
		}

		// Token: 0x06002AD7 RID: 10967 RVA: 0x0014B830 File Offset: 0x00149A30
		public static void CreateStaticDefaultValue()
		{
			ConfigPinballMonsterById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPinballMonsterById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_pinballbattle.db"),
				new ValueTuple<string, object>("文件", "x.星弹奇游_怪物.xlsx"),
				new ValueTuple<string, object>("表名", "PinballMonster"),
				new ValueTuple<string, object>("语句", "select BinData from `PinballMonster` where Id=?")
			});
		}

		// Token: 0x06002AD8 RID: 10968 RVA: 0x0014B8AF File Offset: 0x00149AAF
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballMonsterById.LogPair = null;
			ConfigPinballMonsterById.HandleId = 0;
		}

		// Token: 0x06002AD9 RID: 10969 RVA: 0x0014B8BD File Offset: 0x00149ABD
		public static void Init()
		{
			ConfigPinballMonsterById.HandleId = ConfigCommon.InitDataStatement(ConfigPinballMonsterById.HandleId, "db_pinballbattle.db", "select BinData from `PinballMonster` where Id=?");
		}

		// Token: 0x06002ADA RID: 10970 RVA: 0x0014B8D8 File Offset: 0x00149AD8
		public static PinballMonster? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPinballMonsterById.HandleId, ConfigPinballMonsterById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballMonsterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PinballMonster?(PinballMonster.GetRootAsPinballMonster(configBuffer));
				}
			}
			ConfigPinballMonsterById.LogPair.Clear();
			ConfigPinballMonsterById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPinballMonsterById.HandleId, 1, p0Id, ConfigPinballMonsterById.LogPair) || ConfigCommon.Step(ConfigPinballMonsterById.HandleId, true, ConfigPinballMonsterById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPinballMonsterById.HandleId, ConfigPinballMonsterById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPinballMonsterById.HandleId, 0, ConfigPinballMonsterById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPinballMonsterById.HandleId, ConfigPinballMonsterById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PinballMonster rootAsPinballMonster = PinballMonster.GetRootAsPinballMonster(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballMonsterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPinballMonsterById.HandleId, ConfigPinballMonsterById.LogPair);
			return new PinballMonster?(rootAsPinballMonster);
		}

		// Token: 0x040031CD RID: 12749
		private const string DB = "db_pinballbattle.db";

		// Token: 0x040031CE RID: 12750
		private const string FILE = "x.星弹奇游_怪物.xlsx";

		// Token: 0x040031CF RID: 12751
		private const string TABLE = "PinballMonster";

		// Token: 0x040031D0 RID: 12752
		private const string COMMAND = "select BinData from `PinballMonster` where Id=?";

		// Token: 0x040031D1 RID: 12753
		private const string KEY_PREFIX = "PinballMonsterById";

		// Token: 0x040031D2 RID: 12754
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040031D3 RID: 12755
		private static int HandleId;
	}
}
