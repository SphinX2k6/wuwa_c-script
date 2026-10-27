using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200084D RID: 2125
	public class ConfigRogueResGridExploreByInstId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060031E0 RID: 12768 RVA: 0x00173744 File Offset: 0x00171944
		static ConfigRogueResGridExploreByInstId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResGridExploreByInstId.CreateStaticDefaultValue), new Action(ConfigRogueResGridExploreByInstId.ResetStaticDefaultValue));
		}

		// Token: 0x060031E1 RID: 12769 RVA: 0x00173764 File Offset: 0x00171964
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueResGridExploreByInstId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueResGridExploreByInstId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueResGridExplore"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueResGridExplore` where InstId=?")
			});
		}

		// Token: 0x060031E2 RID: 12770 RVA: 0x001737E3 File Offset: 0x001719E3
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResGridExploreByInstId.LogPair = null;
			ConfigRogueResGridExploreByInstId.HandleId = 0;
		}

		// Token: 0x060031E3 RID: 12771 RVA: 0x001737F1 File Offset: 0x001719F1
		public static void Init()
		{
			ConfigRogueResGridExploreByInstId.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResGridExploreByInstId.HandleId, "db_permanentrogue.db", "select BinData from `RogueResGridExplore` where InstId=?");
		}

		// Token: 0x060031E4 RID: 12772 RVA: 0x0017380C File Offset: 0x00171A0C
		public static RogueResGridExplore? GetConfig(int p0InstId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueResGridExploreByInstId.HandleId, ConfigRogueResGridExploreByInstId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResGridExploreByInstId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0InstId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueResGridExplore?(RogueResGridExplore.GetRootAsRogueResGridExplore(configBuffer));
				}
			}
			ConfigRogueResGridExploreByInstId.LogPair.Clear();
			ConfigRogueResGridExploreByInstId.LogPair.Add(new ValueTuple<string, object>("InstId", p0InstId));
			if (!ConfigCommon.BindInt(ConfigRogueResGridExploreByInstId.HandleId, 1, p0InstId, ConfigRogueResGridExploreByInstId.LogPair) || ConfigCommon.Step(ConfigRogueResGridExploreByInstId.HandleId, true, ConfigRogueResGridExploreByInstId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueResGridExploreByInstId.HandleId, ConfigRogueResGridExploreByInstId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueResGridExploreByInstId.HandleId, 0, ConfigRogueResGridExploreByInstId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueResGridExploreByInstId.HandleId, ConfigRogueResGridExploreByInstId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueResGridExplore rootAsRogueResGridExplore = RogueResGridExplore.GetRootAsRogueResGridExplore(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResGridExploreByInstId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0InstId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueResGridExploreByInstId.HandleId, ConfigRogueResGridExploreByInstId.LogPair);
			return new RogueResGridExplore?(rootAsRogueResGridExplore);
		}

		// Token: 0x04003A01 RID: 14849
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003A02 RID: 14850
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003A03 RID: 14851
		private const string TABLE = "RogueResGridExplore";

		// Token: 0x04003A04 RID: 14852
		private const string COMMAND = "select BinData from `RogueResGridExplore` where InstId=?";

		// Token: 0x04003A05 RID: 14853
		private const string KEY_PREFIX = "RogueResGridExploreByInstId";

		// Token: 0x04003A06 RID: 14854
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003A07 RID: 14855
		private static int HandleId;
	}
}
