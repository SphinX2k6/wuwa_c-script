using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000044 RID: 68
	public class ConfigActivityConditionByType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000198 RID: 408 RVA: 0x000663D4 File Offset: 0x000645D4
		static ConfigActivityConditionByType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigActivityConditionByType.CreateStaticDefaultValue), new Action(ConfigActivityConditionByType.ResetStaticDefaultValue));
		}

		// Token: 0x06000199 RID: 409 RVA: 0x000663F4 File Offset: 0x000645F4
		public static void CreateStaticDefaultValue()
		{
			ConfigActivityConditionByType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigActivityConditionByType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_activitycondition.db"),
				new ValueTuple<string, object>("文件", "h.活动条件.xlsx"),
				new ValueTuple<string, object>("表名", "ActivityCondition"),
				new ValueTuple<string, object>("语句", "select BinData from `ActivityCondition` where Type=?")
			});
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00066473 File Offset: 0x00064673
		public static void ResetStaticDefaultValue()
		{
			ConfigActivityConditionByType.LogPair = null;
			ConfigActivityConditionByType.HandleId = 0;
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00066481 File Offset: 0x00064681
		public static void Init()
		{
			ConfigActivityConditionByType.HandleId = ConfigCommon.InitDataStatement(ConfigActivityConditionByType.HandleId, "db_activitycondition.db", "select BinData from `ActivityCondition` where Type=?");
		}

		// Token: 0x0600019C RID: 412 RVA: 0x0006649C File Offset: 0x0006469C
		[NullableContext(2)]
		public static IReadOnlyList<ActivityCondition> GetConfigList(int p0Type, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigActivityConditionByType.HandleId, ConfigActivityConditionByType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ActivityConditionByType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Type);
				IReadOnlyList<ActivityCondition> readOnlyList = (IReadOnlyList<ActivityCondition>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigActivityConditionByType.LogPair.Clear();
			ConfigActivityConditionByType.LogPair.Add(new ValueTuple<string, object>("Type", p0Type));
			if (!ConfigCommon.BindInt(ConfigActivityConditionByType.HandleId, 1, p0Type, ConfigActivityConditionByType.LogPair))
			{
				ConfigCommon.Reset(ConfigActivityConditionByType.HandleId, ConfigActivityConditionByType.LogPair);
				return null;
			}
			List<ActivityCondition> list = new List<ActivityCondition>();
			while (ConfigCommon.Step(ConfigActivityConditionByType.HandleId, false, ConfigActivityConditionByType.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigActivityConditionByType.HandleId, 0, ConfigActivityConditionByType.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigActivityConditionByType.HandleId, ConfigActivityConditionByType.LogPair);
					return null;
				}
				ActivityCondition rootAsActivityCondition = ActivityCondition.GetRootAsActivityCondition(new ByteBuffer(item2));
				list.Add(rootAsActivityCondition);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ActivityConditionByType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Type);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigActivityConditionByType.HandleId, ConfigActivityConditionByType.LogPair);
			return list;
		}

		// Token: 0x040001C0 RID: 448
		private const string DB = "db_activitycondition.db";

		// Token: 0x040001C1 RID: 449
		private const string FILE = "h.活动条件.xlsx";

		// Token: 0x040001C2 RID: 450
		private const string TABLE = "ActivityCondition";

		// Token: 0x040001C3 RID: 451
		private const string COMMAND = "select BinData from `ActivityCondition` where Type=?";

		// Token: 0x040001C4 RID: 452
		private const string KEY_PREFIX = "ActivityConditionByType";

		// Token: 0x040001C5 RID: 453
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040001C6 RID: 454
		private static int HandleId;
	}
}
