using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000061 RID: 97
	public class ConfigActivityViewNameByType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000246 RID: 582 RVA: 0x0006A0E4 File Offset: 0x000682E4
		static ConfigActivityViewNameByType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigActivityViewNameByType.CreateStaticDefaultValue), new Action(ConfigActivityViewNameByType.ResetStaticDefaultValue));
		}

		// Token: 0x06000247 RID: 583 RVA: 0x0006A104 File Offset: 0x00068304
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

		// Token: 0x06000248 RID: 584 RVA: 0x0006A183 File Offset: 0x00068383
		public static void ResetStaticDefaultValue()
		{
			ConfigActivityViewNameByType.LogPair = null;
			ConfigActivityViewNameByType.HandleId = 0;
		}

		// Token: 0x06000249 RID: 585 RVA: 0x0006A191 File Offset: 0x00068391
		public static void Init()
		{
			ConfigActivityViewNameByType.HandleId = ConfigCommon.InitDataStatement(ConfigActivityViewNameByType.HandleId, "db_activity.db", "select BinData from `ActivityViewName` where Type=?");
		}

		// Token: 0x0600024A RID: 586 RVA: 0x0006A1AC File Offset: 0x000683AC
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

		// Token: 0x0400028B RID: 651
		private const string DB = "db_activity.db";

		// Token: 0x0400028C RID: 652
		private const string FILE = "h.活动.xlsx";

		// Token: 0x0400028D RID: 653
		private const string TABLE = "ActivityViewName";

		// Token: 0x0400028E RID: 654
		private const string COMMAND = "select BinData from `ActivityViewName` where Type=?";

		// Token: 0x0400028F RID: 655
		private const string KEY_PREFIX = "ActivityViewNameByType";

		// Token: 0x04000290 RID: 656
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000291 RID: 657
		private static int HandleId;
	}
}
