using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A49 RID: 2633
	public class ConfigSpringFestivalAreaByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003DCA RID: 15818 RVA: 0x001B9E8F File Offset: 0x001B808F
		static ConfigSpringFestivalAreaByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpringFestivalAreaByActivityId.CreateStaticDefaultValue), new Action(ConfigSpringFestivalAreaByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003DCB RID: 15819 RVA: 0x001B9EB0 File Offset: 0x001B80B0
		public static void CreateStaticDefaultValue()
		{
			ConfigSpringFestivalAreaByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSpringFestivalAreaByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_spring26.db"),
				new ValueTuple<string, object>("文件", "c.3.1春节活动外围.xlsx"),
				new ValueTuple<string, object>("表名", "SpringFestivalArea"),
				new ValueTuple<string, object>("语句", "select BinData from `SpringFestivalArea` where ActivityId=?")
			});
		}

		// Token: 0x06003DCC RID: 15820 RVA: 0x001B9F2F File Offset: 0x001B812F
		public static void ResetStaticDefaultValue()
		{
			ConfigSpringFestivalAreaByActivityId.LogPair = null;
			ConfigSpringFestivalAreaByActivityId.HandleId = 0;
		}

		// Token: 0x06003DCD RID: 15821 RVA: 0x001B9F3D File Offset: 0x001B813D
		public static void Init()
		{
			ConfigSpringFestivalAreaByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigSpringFestivalAreaByActivityId.HandleId, "db_spring26.db", "select BinData from `SpringFestivalArea` where ActivityId=?");
		}

		// Token: 0x06003DCE RID: 15822 RVA: 0x001B9F58 File Offset: 0x001B8158
		[NullableContext(2)]
		public static IReadOnlyList<SpringFestivalArea> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSpringFestivalAreaByActivityId.HandleId, ConfigSpringFestivalAreaByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SpringFestivalAreaByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<SpringFestivalArea> readOnlyList = (IReadOnlyList<SpringFestivalArea>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSpringFestivalAreaByActivityId.LogPair.Clear();
			ConfigSpringFestivalAreaByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigSpringFestivalAreaByActivityId.HandleId, 1, p0ActivityId, ConfigSpringFestivalAreaByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigSpringFestivalAreaByActivityId.HandleId, ConfigSpringFestivalAreaByActivityId.LogPair);
				return null;
			}
			List<SpringFestivalArea> list = new List<SpringFestivalArea>();
			while (ConfigCommon.Step(ConfigSpringFestivalAreaByActivityId.HandleId, false, ConfigSpringFestivalAreaByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSpringFestivalAreaByActivityId.HandleId, 0, ConfigSpringFestivalAreaByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSpringFestivalAreaByActivityId.HandleId, ConfigSpringFestivalAreaByActivityId.LogPair);
					return null;
				}
				SpringFestivalArea rootAsSpringFestivalArea = SpringFestivalArea.GetRootAsSpringFestivalArea(new ByteBuffer(item2));
				list.Add(rootAsSpringFestivalArea);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SpringFestivalAreaByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSpringFestivalAreaByActivityId.HandleId, ConfigSpringFestivalAreaByActivityId.LogPair);
			return list;
		}

		// Token: 0x040047E5 RID: 18405
		private const string DB = "db_spring26.db";

		// Token: 0x040047E6 RID: 18406
		private const string FILE = "c.3.1春节活动外围.xlsx";

		// Token: 0x040047E7 RID: 18407
		private const string TABLE = "SpringFestivalArea";

		// Token: 0x040047E8 RID: 18408
		private const string COMMAND = "select BinData from `SpringFestivalArea` where ActivityId=?";

		// Token: 0x040047E9 RID: 18409
		private const string KEY_PREFIX = "SpringFestivalAreaByActivityId";

		// Token: 0x040047EA RID: 18410
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040047EB RID: 18411
		private static int HandleId;
	}
}
