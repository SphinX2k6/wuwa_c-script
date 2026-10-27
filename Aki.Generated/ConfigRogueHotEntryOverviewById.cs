using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000826 RID: 2086
	public class ConfigRogueHotEntryOverviewById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060030F6 RID: 12534 RVA: 0x0016E280 File Offset: 0x0016C480
		static ConfigRogueHotEntryOverviewById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueHotEntryOverviewById.CreateStaticDefaultValue), new Action(ConfigRogueHotEntryOverviewById.ResetStaticDefaultValue));
		}

		// Token: 0x060030F7 RID: 12535 RVA: 0x0016E2A0 File Offset: 0x0016C4A0
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueHotEntryOverviewById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueHotEntryOverviewById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽经典复开.xlsx"),
				new ValueTuple<string, object>("表名", "RogueHotEntryOverview"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueHotEntryOverview` where Id=?")
			});
		}

		// Token: 0x060030F8 RID: 12536 RVA: 0x0016E31F File Offset: 0x0016C51F
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueHotEntryOverviewById.LogPair = null;
			ConfigRogueHotEntryOverviewById.HandleId = 0;
		}

		// Token: 0x060030F9 RID: 12537 RVA: 0x0016E32D File Offset: 0x0016C52D
		public static void Init()
		{
			ConfigRogueHotEntryOverviewById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueHotEntryOverviewById.HandleId, "db_rogue.db", "select BinData from `RogueHotEntryOverview` where Id=?");
		}

		// Token: 0x060030FA RID: 12538 RVA: 0x0016E348 File Offset: 0x0016C548
		public static RogueHotEntryOverview? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueHotEntryOverviewById.HandleId, ConfigRogueHotEntryOverviewById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueHotEntryOverviewById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueHotEntryOverview?(RogueHotEntryOverview.GetRootAsRogueHotEntryOverview(configBuffer));
				}
			}
			ConfigRogueHotEntryOverviewById.LogPair.Clear();
			ConfigRogueHotEntryOverviewById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueHotEntryOverviewById.HandleId, 1, p0Id, ConfigRogueHotEntryOverviewById.LogPair) || ConfigCommon.Step(ConfigRogueHotEntryOverviewById.HandleId, true, ConfigRogueHotEntryOverviewById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueHotEntryOverviewById.HandleId, ConfigRogueHotEntryOverviewById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueHotEntryOverviewById.HandleId, 0, ConfigRogueHotEntryOverviewById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueHotEntryOverviewById.HandleId, ConfigRogueHotEntryOverviewById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueHotEntryOverview rootAsRogueHotEntryOverview = RogueHotEntryOverview.GetRootAsRogueHotEntryOverview(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueHotEntryOverviewById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueHotEntryOverviewById.HandleId, ConfigRogueHotEntryOverviewById.LogPair);
			return new RogueHotEntryOverview?(rootAsRogueHotEntryOverview);
		}

		// Token: 0x040038F0 RID: 14576
		private const string DB = "db_rogue.db";

		// Token: 0x040038F1 RID: 14577
		private const string FILE = "r.肉鸽经典复开.xlsx";

		// Token: 0x040038F2 RID: 14578
		private const string TABLE = "RogueHotEntryOverview";

		// Token: 0x040038F3 RID: 14579
		private const string COMMAND = "select BinData from `RogueHotEntryOverview` where Id=?";

		// Token: 0x040038F4 RID: 14580
		private const string KEY_PREFIX = "RogueHotEntryOverviewById";

		// Token: 0x040038F5 RID: 14581
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040038F6 RID: 14582
		private static int HandleId;
	}
}
