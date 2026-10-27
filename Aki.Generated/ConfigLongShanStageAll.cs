using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004EE RID: 1262
	public class ConfigLongShanStageAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001D9F RID: 7583 RVA: 0x00100AE4 File Offset: 0x000FECE4
		static ConfigLongShanStageAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLongShanStageAll.CreateStaticDefaultValue), new Action(ConfigLongShanStageAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001DA0 RID: 7584 RVA: 0x00100B04 File Offset: 0x000FED04
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

		// Token: 0x06001DA1 RID: 7585 RVA: 0x00100B83 File Offset: 0x000FED83
		public static void ResetStaticDefaultValue()
		{
			ConfigLongShanStageAll.LogPair = null;
			ConfigLongShanStageAll.HandleId = 0;
		}

		// Token: 0x06001DA2 RID: 7586 RVA: 0x00100B91 File Offset: 0x000FED91
		public static void Init()
		{
			ConfigLongShanStageAll.HandleId = ConfigCommon.InitDataStatement(ConfigLongShanStageAll.HandleId, "db_longshanactivity.db", "select BinData from `LongShanStage` where ActivityId=?");
		}

		// Token: 0x06001DA3 RID: 7587 RVA: 0x00100BAC File Offset: 0x000FEDAC
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

		// Token: 0x04002266 RID: 8806
		private const string DB = "db_longshanactivity.db";

		// Token: 0x04002267 RID: 8807
		private const string FILE = "l.龙山主题活动.xlsx";

		// Token: 0x04002268 RID: 8808
		private const string TABLE = "LongShanStage";

		// Token: 0x04002269 RID: 8809
		private const string COMMAND = "select BinData from `LongShanStage` where ActivityId=?";

		// Token: 0x0400226A RID: 8810
		private const string KEY_PREFIX = "LongShanStageAll";

		// Token: 0x0400226B RID: 8811
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400226C RID: 8812
		private static int HandleId;
	}
}
