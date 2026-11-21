using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000869 RID: 2153
	public class ConfigRogueResGridExploreByInstId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003288 RID: 12936 RVA: 0x0017AA2C File Offset: 0x00178C2C
		static ConfigRogueResGridExploreByInstId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResGridExploreByInstId.CreateStaticDefaultValue), new Action(ConfigRogueResGridExploreByInstId.ResetStaticDefaultValue));
		}

		// Token: 0x06003289 RID: 12937 RVA: 0x0017AA4C File Offset: 0x00178C4C
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

		// Token: 0x0600328A RID: 12938 RVA: 0x0017AACB File Offset: 0x00178CCB
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResGridExploreByInstId.LogPair = null;
			ConfigRogueResGridExploreByInstId.HandleId = 0;
		}

		// Token: 0x0600328B RID: 12939 RVA: 0x0017AAD9 File Offset: 0x00178CD9
		public static void Init()
		{
			ConfigRogueResGridExploreByInstId.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResGridExploreByInstId.HandleId, "db_permanentrogue.db", "select BinData from `RogueResGridExplore` where InstId=?");
		}

		// Token: 0x0600328C RID: 12940 RVA: 0x0017AAF4 File Offset: 0x00178CF4
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

		// Token: 0x04003AC5 RID: 15045
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003AC6 RID: 15046
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003AC7 RID: 15047
		private const string TABLE = "RogueResGridExplore";

		// Token: 0x04003AC8 RID: 15048
		private const string COMMAND = "select BinData from `RogueResGridExplore` where InstId=?";

		// Token: 0x04003AC9 RID: 15049
		private const string KEY_PREFIX = "RogueResGridExploreByInstId";

		// Token: 0x04003ACA RID: 15050
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003ACB RID: 15051
		private static int HandleId;
	}
}
