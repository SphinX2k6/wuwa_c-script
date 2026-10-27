using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000059 RID: 89
	public class ConfigActivityViewNameByType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000216 RID: 534 RVA: 0x00065830 File Offset: 0x00063A30
		static ConfigActivityViewNameByType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigActivityViewNameByType.CreateStaticDefaultValue), new Action(ConfigActivityViewNameByType.ResetStaticDefaultValue));
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00065850 File Offset: 0x00063A50
		public static void CreateStaticDefaultValue()
		{
			ConfigActivityViewNameByType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigActivityViewNameByType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_activity.db"),
				new ValueTuple<string, object>("文件", "h.活动.xlsx"),
				new ValueTuple<string, object>("表名", "ActivityViewName"),
				new ValueTuple<string, object>("语句", "select BinData from `ActivityViewName` where Type=?")
			});
		}

		// Token: 0x06000218 RID: 536 RVA: 0x000658CF File Offset: 0x00063ACF
		public static void ResetStaticDefaultValue()
		{
			ConfigActivityViewNameByType.LogPair = null;
			ConfigActivityViewNameByType.HandleId = 0;
		}

		// Token: 0x06000219 RID: 537 RVA: 0x000658DD File Offset: 0x00063ADD
		public static void Init()
		{
			ConfigActivityViewNameByType.HandleId = ConfigCommon.InitDataStatement(ConfigActivityViewNameByType.HandleId, "db_activity.db", "select BinData from `ActivityViewName` where Type=?");
		}

		// Token: 0x0600021A RID: 538 RVA: 0x000658F8 File Offset: 0x00063AF8
		[NullableContext(2)]
		public static IReadOnlyList<ActivityViewName> GetConfigList(int p0Type, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigActivityViewNameByType.HandleId, ConfigActivityViewNameByType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ActivityViewNameByType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Type);
				IReadOnlyList<ActivityViewName> readOnlyList = (IReadOnlyList<ActivityViewName>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigActivityViewNameByType.LogPair.Clear();
			ConfigActivityViewNameByType.LogPair.Add(new ValueTuple<string, object>("Type", p0Type));
			if (!ConfigCommon.BindInt(ConfigActivityViewNameByType.HandleId, 1, p0Type, ConfigActivityViewNameByType.LogPair))
			{
				ConfigCommon.Reset(ConfigActivityViewNameByType.HandleId, ConfigActivityViewNameByType.LogPair);
				return null;
			}
			List<ActivityViewName> list = new List<ActivityViewName>();
			while (ConfigCommon.Step(ConfigActivityViewNameByType.HandleId, false, ConfigActivityViewNameByType.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigActivityViewNameByType.HandleId, 0, ConfigActivityViewNameByType.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigActivityViewNameByType.HandleId, ConfigActivityViewNameByType.LogPair);
					return null;
				}
				ActivityViewName rootAsActivityViewName = ActivityViewName.GetRootAsActivityViewName(new ByteBuffer(item2));
				list.Add(rootAsActivityViewName);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ActivityViewNameByType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Type);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigActivityViewNameByType.HandleId, ConfigActivityViewNameByType.LogPair);
			return list;
		}

		// Token: 0x04000253 RID: 595
		private const string DB = "db_activity.db";

		// Token: 0x04000254 RID: 596
		private const string FILE = "h.活动.xlsx";

		// Token: 0x04000255 RID: 597
		private const string TABLE = "ActivityViewName";

		// Token: 0x04000256 RID: 598
		private const string COMMAND = "select BinData from `ActivityViewName` where Type=?";

		// Token: 0x04000257 RID: 599
		private const string KEY_PREFIX = "ActivityViewNameByType";

		// Token: 0x04000258 RID: 600
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000259 RID: 601
		private static int HandleId;
	}
}
