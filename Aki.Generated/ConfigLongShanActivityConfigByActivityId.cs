using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004EB RID: 1259
	public class ConfigLongShanActivityConfigByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001D8D RID: 7565 RVA: 0x0010041C File Offset: 0x000FE61C
		static ConfigLongShanActivityConfigByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLongShanActivityConfigByActivityId.CreateStaticDefaultValue), new Action(ConfigLongShanActivityConfigByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06001D8E RID: 7566 RVA: 0x0010043C File Offset: 0x000FE63C
		public static void CreateStaticDefaultValue()
		{
			ConfigLongShanActivityConfigByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigLongShanActivityConfigByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_longshanactivity.db"),
				new ValueTuple<string, object>("文件", "l.龙山主题活动.xlsx"),
				new ValueTuple<string, object>("表名", "LongShanActivityConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `LongShanActivityConfig` where ActivityId=?")
			});
		}

		// Token: 0x06001D8F RID: 7567 RVA: 0x001004BB File Offset: 0x000FE6BB
		public static void ResetStaticDefaultValue()
		{
			ConfigLongShanActivityConfigByActivityId.LogPair = null;
			ConfigLongShanActivityConfigByActivityId.HandleId = 0;
		}

		// Token: 0x06001D90 RID: 7568 RVA: 0x001004C9 File Offset: 0x000FE6C9
		public static void Init()
		{
			ConfigLongShanActivityConfigByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigLongShanActivityConfigByActivityId.HandleId, "db_longshanactivity.db", "select BinData from `LongShanActivityConfig` where ActivityId=?");
		}

		// Token: 0x06001D91 RID: 7569 RVA: 0x001004E4 File Offset: 0x000FE6E4
		public static LongShanActivityConfig? GetConfig(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigLongShanActivityConfigByActivityId.HandleId, ConfigLongShanActivityConfigByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LongShanActivityConfigByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new LongShanActivityConfig?(LongShanActivityConfig.GetRootAsLongShanActivityConfig(configBuffer));
				}
			}
			ConfigLongShanActivityConfigByActivityId.LogPair.Clear();
			ConfigLongShanActivityConfigByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigLongShanActivityConfigByActivityId.HandleId, 1, p0ActivityId, ConfigLongShanActivityConfigByActivityId.LogPair) || ConfigCommon.Step(ConfigLongShanActivityConfigByActivityId.HandleId, true, ConfigLongShanActivityConfigByActivityId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigLongShanActivityConfigByActivityId.HandleId, ConfigLongShanActivityConfigByActivityId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigLongShanActivityConfigByActivityId.HandleId, 0, ConfigLongShanActivityConfigByActivityId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigLongShanActivityConfigByActivityId.HandleId, ConfigLongShanActivityConfigByActivityId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			LongShanActivityConfig rootAsLongShanActivityConfig = LongShanActivityConfig.GetRootAsLongShanActivityConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LongShanActivityConfigByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigLongShanActivityConfigByActivityId.HandleId, ConfigLongShanActivityConfigByActivityId.LogPair);
			return new LongShanActivityConfig?(rootAsLongShanActivityConfig);
		}

		// Token: 0x04002251 RID: 8785
		private const string DB = "db_longshanactivity.db";

		// Token: 0x04002252 RID: 8786
		private const string FILE = "l.龙山主题活动.xlsx";

		// Token: 0x04002253 RID: 8787
		private const string TABLE = "LongShanActivityConfig";

		// Token: 0x04002254 RID: 8788
		private const string COMMAND = "select BinData from `LongShanActivityConfig` where ActivityId=?";

		// Token: 0x04002255 RID: 8789
		private const string KEY_PREFIX = "LongShanActivityConfigByActivityId";

		// Token: 0x04002256 RID: 8790
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002257 RID: 8791
		private static int HandleId;
	}
}
