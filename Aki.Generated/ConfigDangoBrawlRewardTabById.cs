using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001ED RID: 493
	public class ConfigDangoBrawlRewardTabById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000B91 RID: 2961 RVA: 0x0009E827 File Offset: 0x0009CA27
		static ConfigDangoBrawlRewardTabById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoBrawlRewardTabById.CreateStaticDefaultValue), new Action(ConfigDangoBrawlRewardTabById.ResetStaticDefaultValue));
		}

		// Token: 0x06000B92 RID: 2962 RVA: 0x0009E848 File Offset: 0x0009CA48
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

		// Token: 0x06000B93 RID: 2963 RVA: 0x0009E8C7 File Offset: 0x0009CAC7
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoBrawlRewardTabById.LogPair = null;
			ConfigDangoBrawlRewardTabById.HandleId = 0;
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x0009E8D5 File Offset: 0x0009CAD5
		public static void Init()
		{
			ConfigDangoBrawlRewardTabById.HandleId = ConfigCommon.InitDataStatement(ConfigDangoBrawlRewardTabById.HandleId, "db_dangobrawl.db", "select BinData from `DangoBrawlRewardTab` where Id=?");
		}

		// Token: 0x06000B95 RID: 2965 RVA: 0x0009E8F0 File Offset: 0x0009CAF0
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

		// Token: 0x04000D5F RID: 3423
		private const string DB = "db_dangobrawl.db";

		// Token: 0x04000D60 RID: 3424
		private const string FILE = "t.团子乱斗外围.xlsx";

		// Token: 0x04000D61 RID: 3425
		private const string TABLE = "DangoBrawlRewardTab";

		// Token: 0x04000D62 RID: 3426
		private const string COMMAND = "select BinData from `DangoBrawlRewardTab` where Id=?";

		// Token: 0x04000D63 RID: 3427
		private const string KEY_PREFIX = "DangoBrawlRewardTabById";

		// Token: 0x04000D64 RID: 3428
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000D65 RID: 3429
		private static int HandleId;
	}
}
