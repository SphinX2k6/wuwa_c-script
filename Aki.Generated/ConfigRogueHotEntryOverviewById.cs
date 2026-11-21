using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000842 RID: 2114
	public class ConfigRogueHotEntryOverviewById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600319E RID: 12702 RVA: 0x00175568 File Offset: 0x00173768
		static ConfigRogueHotEntryOverviewById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueHotEntryOverviewById.CreateStaticDefaultValue), new Action(ConfigRogueHotEntryOverviewById.ResetStaticDefaultValue));
		}

		// Token: 0x0600319F RID: 12703 RVA: 0x00175588 File Offset: 0x00173788
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

		// Token: 0x060031A0 RID: 12704 RVA: 0x00175607 File Offset: 0x00173807
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueHotEntryOverviewById.LogPair = null;
			ConfigRogueHotEntryOverviewById.HandleId = 0;
		}

		// Token: 0x060031A1 RID: 12705 RVA: 0x00175615 File Offset: 0x00173815
		public static void Init()
		{
			ConfigRogueHotEntryOverviewById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueHotEntryOverviewById.HandleId, "db_rogue.db", "select BinData from `RogueHotEntryOverview` where Id=?");
		}

		// Token: 0x060031A2 RID: 12706 RVA: 0x00175630 File Offset: 0x00173830
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

		// Token: 0x040039B4 RID: 14772
		private const string DB = "db_rogue.db";

		// Token: 0x040039B5 RID: 14773
		private const string FILE = "r.肉鸽经典复开.xlsx";

		// Token: 0x040039B6 RID: 14774
		private const string TABLE = "RogueHotEntryOverview";

		// Token: 0x040039B7 RID: 14775
		private const string COMMAND = "select BinData from `RogueHotEntryOverview` where Id=?";

		// Token: 0x040039B8 RID: 14776
		private const string KEY_PREFIX = "RogueHotEntryOverviewById";

		// Token: 0x040039B9 RID: 14777
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040039BA RID: 14778
		private static int HandleId;
	}
}
