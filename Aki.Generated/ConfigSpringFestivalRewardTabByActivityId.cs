using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200097F RID: 2431
	public class ConfigSpringFestivalRewardTabByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600390E RID: 14606 RVA: 0x0019C27C File Offset: 0x0019A47C
		static ConfigSpringFestivalRewardTabByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpringFestivalRewardTabByActivityId.CreateStaticDefaultValue), new Action(ConfigSpringFestivalRewardTabByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x0600390F RID: 14607 RVA: 0x0019C29C File Offset: 0x0019A49C
		public static void CreateStaticDefaultValue()
		{
			ConfigSpringFestivalRewardTabByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSpringFestivalRewardTabByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_spring26.db"),
				new ValueTuple<string, object>("文件", "c.3.1春节活动外围.xlsx"),
				new ValueTuple<string, object>("表名", "SpringFestivalRewardTab"),
				new ValueTuple<string, object>("语句", "select BinData from `SpringFestivalRewardTab` where ActivityId=?")
			});
		}

		// Token: 0x06003910 RID: 14608 RVA: 0x0019C31B File Offset: 0x0019A51B
		public static void ResetStaticDefaultValue()
		{
			ConfigSpringFestivalRewardTabByActivityId.LogPair = null;
			ConfigSpringFestivalRewardTabByActivityId.HandleId = 0;
		}

		// Token: 0x06003911 RID: 14609 RVA: 0x0019C329 File Offset: 0x0019A529
		public static void Init()
		{
			ConfigSpringFestivalRewardTabByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigSpringFestivalRewardTabByActivityId.HandleId, "db_spring26.db", "select BinData from `SpringFestivalRewardTab` where ActivityId=?");
		}

		// Token: 0x06003912 RID: 14610 RVA: 0x0019C344 File Offset: 0x0019A544
		[NullableContext(2)]
		public static IReadOnlyList<SpringFestivalRewardTab> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSpringFestivalRewardTabByActivityId.HandleId, ConfigSpringFestivalRewardTabByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SpringFestivalRewardTabByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<SpringFestivalRewardTab> readOnlyList = (IReadOnlyList<SpringFestivalRewardTab>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSpringFestivalRewardTabByActivityId.LogPair.Clear();
			ConfigSpringFestivalRewardTabByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigSpringFestivalRewardTabByActivityId.HandleId, 1, p0ActivityId, ConfigSpringFestivalRewardTabByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigSpringFestivalRewardTabByActivityId.HandleId, ConfigSpringFestivalRewardTabByActivityId.LogPair);
				return null;
			}
			List<SpringFestivalRewardTab> list = new List<SpringFestivalRewardTab>();
			while (ConfigCommon.Step(ConfigSpringFestivalRewardTabByActivityId.HandleId, false, ConfigSpringFestivalRewardTabByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSpringFestivalRewardTabByActivityId.HandleId, 0, ConfigSpringFestivalRewardTabByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSpringFestivalRewardTabByActivityId.HandleId, ConfigSpringFestivalRewardTabByActivityId.LogPair);
					return null;
				}
				SpringFestivalRewardTab rootAsSpringFestivalRewardTab = SpringFestivalRewardTab.GetRootAsSpringFestivalRewardTab(new ByteBuffer(item2));
				list.Add(rootAsSpringFestivalRewardTab);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SpringFestivalRewardTabByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSpringFestivalRewardTabByActivityId.HandleId, ConfigSpringFestivalRewardTabByActivityId.LogPair);
			return list;
		}

		// Token: 0x0400425F RID: 16991
		private const string DB = "db_spring26.db";

		// Token: 0x04004260 RID: 16992
		private const string FILE = "c.3.1春节活动外围.xlsx";

		// Token: 0x04004261 RID: 16993
		private const string TABLE = "SpringFestivalRewardTab";

		// Token: 0x04004262 RID: 16994
		private const string COMMAND = "select BinData from `SpringFestivalRewardTab` where ActivityId=?";

		// Token: 0x04004263 RID: 16995
		private const string KEY_PREFIX = "SpringFestivalRewardTabByActivityId";

		// Token: 0x04004264 RID: 16996
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004265 RID: 16997
		private static int HandleId;
	}
}
