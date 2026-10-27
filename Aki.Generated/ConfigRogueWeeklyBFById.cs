using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200086F RID: 2159
	public class ConfigRogueWeeklyBFById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060032AC RID: 12972 RVA: 0x00177F13 File Offset: 0x00176113
		static ConfigRogueWeeklyBFById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueWeeklyBFById.CreateStaticDefaultValue), new Action(ConfigRogueWeeklyBFById.ResetStaticDefaultValue));
		}

		// Token: 0x060032AD RID: 12973 RVA: 0x00177F34 File Offset: 0x00176134
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueWeeklyBFById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueWeeklyBFById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weeklyrogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽周常黑石花奖励.xlsx"),
				new ValueTuple<string, object>("表名", "RogueWeeklyBF"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueWeeklyBF` where Id=?")
			});
		}

		// Token: 0x060032AE RID: 12974 RVA: 0x00177FB3 File Offset: 0x001761B3
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueWeeklyBFById.LogPair = null;
			ConfigRogueWeeklyBFById.HandleId = 0;
		}

		// Token: 0x060032AF RID: 12975 RVA: 0x00177FC1 File Offset: 0x001761C1
		public static void Init()
		{
			ConfigRogueWeeklyBFById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueWeeklyBFById.HandleId, "db_weeklyrogue.db", "select BinData from `RogueWeeklyBF` where Id=?");
		}

		// Token: 0x060032B0 RID: 12976 RVA: 0x00177FDC File Offset: 0x001761DC
		public static RogueWeeklyBF? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueWeeklyBFById.HandleId, ConfigRogueWeeklyBFById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueWeeklyBFById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueWeeklyBF?(RogueWeeklyBF.GetRootAsRogueWeeklyBF(configBuffer));
				}
			}
			ConfigRogueWeeklyBFById.LogPair.Clear();
			ConfigRogueWeeklyBFById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueWeeklyBFById.HandleId, 1, p0Id, ConfigRogueWeeklyBFById.LogPair) || ConfigCommon.Step(ConfigRogueWeeklyBFById.HandleId, true, ConfigRogueWeeklyBFById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueWeeklyBFById.HandleId, ConfigRogueWeeklyBFById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueWeeklyBFById.HandleId, 0, ConfigRogueWeeklyBFById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueWeeklyBFById.HandleId, ConfigRogueWeeklyBFById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueWeeklyBF rootAsRogueWeeklyBF = RogueWeeklyBF.GetRootAsRogueWeeklyBF(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueWeeklyBFById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueWeeklyBFById.HandleId, ConfigRogueWeeklyBFById.LogPair);
			return new RogueWeeklyBF?(rootAsRogueWeeklyBF);
		}

		// Token: 0x04003AEF RID: 15087
		private const string DB = "db_weeklyrogue.db";

		// Token: 0x04003AF0 RID: 15088
		private const string FILE = "r.肉鸽周常黑石花奖励.xlsx";

		// Token: 0x04003AF1 RID: 15089
		private const string TABLE = "RogueWeeklyBF";

		// Token: 0x04003AF2 RID: 15090
		private const string COMMAND = "select BinData from `RogueWeeklyBF` where Id=?";

		// Token: 0x04003AF3 RID: 15091
		private const string KEY_PREFIX = "RogueWeeklyBFById";

		// Token: 0x04003AF4 RID: 15092
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003AF5 RID: 15093
		private static int HandleId;
	}
}
