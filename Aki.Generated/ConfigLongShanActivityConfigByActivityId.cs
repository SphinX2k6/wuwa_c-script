using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000501 RID: 1281
	public class ConfigLongShanActivityConfigByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001E11 RID: 7697 RVA: 0x00106B70 File Offset: 0x00104D70
		static ConfigLongShanActivityConfigByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLongShanActivityConfigByActivityId.CreateStaticDefaultValue), new Action(ConfigLongShanActivityConfigByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06001E12 RID: 7698 RVA: 0x00106B90 File Offset: 0x00104D90
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

		// Token: 0x06001E13 RID: 7699 RVA: 0x00106C0F File Offset: 0x00104E0F
		public static void ResetStaticDefaultValue()
		{
			ConfigLongShanActivityConfigByActivityId.LogPair = null;
			ConfigLongShanActivityConfigByActivityId.HandleId = 0;
		}

		// Token: 0x06001E14 RID: 7700 RVA: 0x00106C1D File Offset: 0x00104E1D
		public static void Init()
		{
			ConfigLongShanActivityConfigByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigLongShanActivityConfigByActivityId.HandleId, "db_longshanactivity.db", "select BinData from `LongShanActivityConfig` where ActivityId=?");
		}

		// Token: 0x06001E15 RID: 7701 RVA: 0x00106C38 File Offset: 0x00104E38
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

		// Token: 0x040022EB RID: 8939
		private const string DB = "db_longshanactivity.db";

		// Token: 0x040022EC RID: 8940
		private const string FILE = "l.龙山主题活动.xlsx";

		// Token: 0x040022ED RID: 8941
		private const string TABLE = "LongShanActivityConfig";

		// Token: 0x040022EE RID: 8942
		private const string COMMAND = "select BinData from `LongShanActivityConfig` where ActivityId=?";

		// Token: 0x040022EF RID: 8943
		private const string KEY_PREFIX = "LongShanActivityConfigByActivityId";

		// Token: 0x040022F0 RID: 8944
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040022F1 RID: 8945
		private static int HandleId;
	}
}
