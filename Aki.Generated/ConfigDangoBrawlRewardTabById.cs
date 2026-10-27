using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001DB RID: 475
	public class ConfigDangoBrawlRewardTabById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000B25 RID: 2853 RVA: 0x000988EF File Offset: 0x00096AEF
		static ConfigDangoBrawlRewardTabById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoBrawlRewardTabById.CreateStaticDefaultValue), new Action(ConfigDangoBrawlRewardTabById.ResetStaticDefaultValue));
		}

		// Token: 0x06000B26 RID: 2854 RVA: 0x00098910 File Offset: 0x00096B10
		public static void CreateStaticDefaultValue()
		{
			ConfigDangoBrawlRewardTabById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDangoBrawlRewardTabById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangobrawl.db"),
				new ValueTuple<string, object>("文件", "t.团子乱斗外围.xlsx"),
				new ValueTuple<string, object>("表名", "DangoBrawlRewardTab"),
				new ValueTuple<string, object>("语句", "select BinData from `DangoBrawlRewardTab` where Id=?")
			});
		}

		// Token: 0x06000B27 RID: 2855 RVA: 0x0009898F File Offset: 0x00096B8F
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoBrawlRewardTabById.LogPair = null;
			ConfigDangoBrawlRewardTabById.HandleId = 0;
		}

		// Token: 0x06000B28 RID: 2856 RVA: 0x0009899D File Offset: 0x00096B9D
		public static void Init()
		{
			ConfigDangoBrawlRewardTabById.HandleId = ConfigCommon.InitDataStatement(ConfigDangoBrawlRewardTabById.HandleId, "db_dangobrawl.db", "select BinData from `DangoBrawlRewardTab` where Id=?");
		}

		// Token: 0x06000B29 RID: 2857 RVA: 0x000989B8 File Offset: 0x00096BB8
		public static DangoBrawlRewardTab? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDangoBrawlRewardTabById.HandleId, ConfigDangoBrawlRewardTabById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBrawlRewardTabById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DangoBrawlRewardTab?(DangoBrawlRewardTab.GetRootAsDangoBrawlRewardTab(configBuffer));
				}
			}
			ConfigDangoBrawlRewardTabById.LogPair.Clear();
			ConfigDangoBrawlRewardTabById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDangoBrawlRewardTabById.HandleId, 1, p0Id, ConfigDangoBrawlRewardTabById.LogPair) || ConfigCommon.Step(ConfigDangoBrawlRewardTabById.HandleId, true, ConfigDangoBrawlRewardTabById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDangoBrawlRewardTabById.HandleId, ConfigDangoBrawlRewardTabById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDangoBrawlRewardTabById.HandleId, 0, ConfigDangoBrawlRewardTabById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDangoBrawlRewardTabById.HandleId, ConfigDangoBrawlRewardTabById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DangoBrawlRewardTab rootAsDangoBrawlRewardTab = DangoBrawlRewardTab.GetRootAsDangoBrawlRewardTab(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBrawlRewardTabById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDangoBrawlRewardTabById.HandleId, ConfigDangoBrawlRewardTabById.LogPair);
			return new DangoBrawlRewardTab?(rootAsDangoBrawlRewardTab);
		}

		// Token: 0x04000CE1 RID: 3297
		private const string DB = "db_dangobrawl.db";

		// Token: 0x04000CE2 RID: 3298
		private const string FILE = "t.团子乱斗外围.xlsx";

		// Token: 0x04000CE3 RID: 3299
		private const string TABLE = "DangoBrawlRewardTab";

		// Token: 0x04000CE4 RID: 3300
		private const string COMMAND = "select BinData from `DangoBrawlRewardTab` where Id=?";

		// Token: 0x04000CE5 RID: 3301
		private const string KEY_PREFIX = "DangoBrawlRewardTabById";

		// Token: 0x04000CE6 RID: 3302
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000CE7 RID: 3303
		private static int HandleId;
	}
}
