using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000504 RID: 1284
	public class ConfigLongShanStageAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001E23 RID: 7715 RVA: 0x00107238 File Offset: 0x00105438
		static ConfigLongShanStageAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLongShanStageAll.CreateStaticDefaultValue), new Action(ConfigLongShanStageAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001E24 RID: 7716 RVA: 0x00107258 File Offset: 0x00105458
		public static void CreateStaticDefaultValue()
		{
			ConfigLongShanStageAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigLongShanStageAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_longshanactivity.db"),
				new ValueTuple<string, object>("文件", "l.龙山主题活动.xlsx"),
				new ValueTuple<string, object>("表名", "LongShanStage"),
				new ValueTuple<string, object>("语句", "select BinData from `LongShanStage` where ActivityId=?")
			});
		}

		// Token: 0x06001E25 RID: 7717 RVA: 0x001072D7 File Offset: 0x001054D7
		public static void ResetStaticDefaultValue()
		{
			ConfigLongShanStageAll.LogPair = null;
			ConfigLongShanStageAll.HandleId = 0;
		}

		// Token: 0x06001E26 RID: 7718 RVA: 0x001072E5 File Offset: 0x001054E5
		public static void Init()
		{
			ConfigLongShanStageAll.HandleId = ConfigCommon.InitDataStatement(ConfigLongShanStageAll.HandleId, "db_longshanactivity.db", "select BinData from `LongShanStage` where ActivityId=?");
		}

		// Token: 0x06001E27 RID: 7719 RVA: 0x00107300 File Offset: 0x00105500
		[NullableContext(2)]
		public static IReadOnlyList<LongShanStage> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigLongShanStageAll.HandleId, ConfigLongShanStageAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LongShanStageAll");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<LongShanStage> readOnlyList = (IReadOnlyList<LongShanStage>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigLongShanStageAll.LogPair.Clear();
			ConfigLongShanStageAll.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigLongShanStageAll.HandleId, 1, p0ActivityId, ConfigLongShanStageAll.LogPair))
			{
				ConfigCommon.Reset(ConfigLongShanStageAll.HandleId, ConfigLongShanStageAll.LogPair);
				return null;
			}
			List<LongShanStage> list = new List<LongShanStage>();
			while (ConfigCommon.Step(ConfigLongShanStageAll.HandleId, false, ConfigLongShanStageAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigLongShanStageAll.HandleId, 0, ConfigLongShanStageAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigLongShanStageAll.HandleId, ConfigLongShanStageAll.LogPair);
					return null;
				}
				LongShanStage rootAsLongShanStage = LongShanStage.GetRootAsLongShanStage(new ByteBuffer(item2));
				list.Add(rootAsLongShanStage);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LongShanStageAll");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigLongShanStageAll.HandleId, ConfigLongShanStageAll.LogPair);
			return list;
		}

		// Token: 0x04002300 RID: 8960
		private const string DB = "db_longshanactivity.db";

		// Token: 0x04002301 RID: 8961
		private const string FILE = "l.龙山主题活动.xlsx";

		// Token: 0x04002302 RID: 8962
		private const string TABLE = "LongShanStage";

		// Token: 0x04002303 RID: 8963
		private const string COMMAND = "select BinData from `LongShanStage` where ActivityId=?";

		// Token: 0x04002304 RID: 8964
		private const string KEY_PREFIX = "LongShanStageAll";

		// Token: 0x04002305 RID: 8965
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002306 RID: 8966
		private static int HandleId;
	}
}
