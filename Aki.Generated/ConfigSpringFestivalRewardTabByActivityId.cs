using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A54 RID: 2644
	public class ConfigSpringFestivalRewardTabByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003E0C RID: 15884 RVA: 0x001BB610 File Offset: 0x001B9810
		static ConfigSpringFestivalRewardTabByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpringFestivalRewardTabByActivityId.CreateStaticDefaultValue), new Action(ConfigSpringFestivalRewardTabByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003E0D RID: 15885 RVA: 0x001BB630 File Offset: 0x001B9830
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

		// Token: 0x06003E0E RID: 15886 RVA: 0x001BB6AF File Offset: 0x001B98AF
		public static void ResetStaticDefaultValue()
		{
			ConfigSpringFestivalRewardTabByActivityId.LogPair = null;
			ConfigSpringFestivalRewardTabByActivityId.HandleId = 0;
		}

		// Token: 0x06003E0F RID: 15887 RVA: 0x001BB6BD File Offset: 0x001B98BD
		public static void Init()
		{
			ConfigSpringFestivalRewardTabByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigSpringFestivalRewardTabByActivityId.HandleId, "db_spring26.db", "select BinData from `SpringFestivalRewardTab` where ActivityId=?");
		}

		// Token: 0x06003E10 RID: 15888 RVA: 0x001BB6D8 File Offset: 0x001B98D8
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

		// Token: 0x04004832 RID: 18482
		private const string DB = "db_spring26.db";

		// Token: 0x04004833 RID: 18483
		private const string FILE = "c.3.1春节活动外围.xlsx";

		// Token: 0x04004834 RID: 18484
		private const string TABLE = "SpringFestivalRewardTab";

		// Token: 0x04004835 RID: 18485
		private const string COMMAND = "select BinData from `SpringFestivalRewardTab` where ActivityId=?";

		// Token: 0x04004836 RID: 18486
		private const string KEY_PREFIX = "SpringFestivalRewardTabByActivityId";

		// Token: 0x04004837 RID: 18487
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004838 RID: 18488
		private static int HandleId;
	}
}
