using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000974 RID: 2420
	public class ConfigSpringFestivalAreaByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060038CC RID: 14540 RVA: 0x0019AAFB File Offset: 0x00198CFB
		static ConfigSpringFestivalAreaByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpringFestivalAreaByActivityId.CreateStaticDefaultValue), new Action(ConfigSpringFestivalAreaByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x060038CD RID: 14541 RVA: 0x0019AB1C File Offset: 0x00198D1C
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

		// Token: 0x060038CE RID: 14542 RVA: 0x0019AB9B File Offset: 0x00198D9B
		public static void ResetStaticDefaultValue()
		{
			ConfigSpringFestivalAreaByActivityId.LogPair = null;
			ConfigSpringFestivalAreaByActivityId.HandleId = 0;
		}

		// Token: 0x060038CF RID: 14543 RVA: 0x0019ABA9 File Offset: 0x00198DA9
		public static void Init()
		{
			ConfigSpringFestivalAreaByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigSpringFestivalAreaByActivityId.HandleId, "db_spring26.db", "select BinData from `SpringFestivalArea` where ActivityId=?");
		}

		// Token: 0x060038D0 RID: 14544 RVA: 0x0019ABC4 File Offset: 0x00198DC4
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

		// Token: 0x04004212 RID: 16914
		private const string DB = "db_spring26.db";

		// Token: 0x04004213 RID: 16915
		private const string FILE = "c.3.1春节活动外围.xlsx";

		// Token: 0x04004214 RID: 16916
		private const string TABLE = "SpringFestivalArea";

		// Token: 0x04004215 RID: 16917
		private const string COMMAND = "select BinData from `SpringFestivalArea` where ActivityId=?";

		// Token: 0x04004216 RID: 16918
		private const string KEY_PREFIX = "SpringFestivalAreaByActivityId";

		// Token: 0x04004217 RID: 16919
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004218 RID: 16920
		private static int HandleId;
	}
}
