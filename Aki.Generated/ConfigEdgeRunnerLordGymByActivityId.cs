using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200025E RID: 606
	public class ConfigEdgeRunnerLordGymByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000E38 RID: 3640 RVA: 0x000AD69C File Offset: 0x000AB89C
		static ConfigEdgeRunnerLordGymByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEdgeRunnerLordGymByActivityId.CreateStaticDefaultValue), new Action(ConfigEdgeRunnerLordGymByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06000E39 RID: 3641 RVA: 0x000AD6BC File Offset: 0x000AB8BC
		public static void CreateStaticDefaultValue()
		{
			ConfigEdgeRunnerLordGymByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigEdgeRunnerLordGymByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_edgerunner.db"),
				new ValueTuple<string, object>("文件", "b.边缘行者联动.xlsx"),
				new ValueTuple<string, object>("表名", "EdgeRunnerLordGym"),
				new ValueTuple<string, object>("语句", "select BinData from `EdgeRunnerLordGym` where ActivityId=?")
			});
		}

		// Token: 0x06000E3A RID: 3642 RVA: 0x000AD73B File Offset: 0x000AB93B
		public static void ResetStaticDefaultValue()
		{
			ConfigEdgeRunnerLordGymByActivityId.LogPair = null;
			ConfigEdgeRunnerLordGymByActivityId.HandleId = 0;
		}

		// Token: 0x06000E3B RID: 3643 RVA: 0x000AD749 File Offset: 0x000AB949
		public static void Init()
		{
			ConfigEdgeRunnerLordGymByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigEdgeRunnerLordGymByActivityId.HandleId, "db_edgerunner.db", "select BinData from `EdgeRunnerLordGym` where ActivityId=?");
		}

		// Token: 0x06000E3C RID: 3644 RVA: 0x000AD764 File Offset: 0x000AB964
		[NullableContext(2)]
		public static IReadOnlyList<EdgeRunnerLordGym> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigEdgeRunnerLordGymByActivityId.HandleId, ConfigEdgeRunnerLordGymByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("EdgeRunnerLordGymByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<EdgeRunnerLordGym> readOnlyList = (IReadOnlyList<EdgeRunnerLordGym>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigEdgeRunnerLordGymByActivityId.LogPair.Clear();
			ConfigEdgeRunnerLordGymByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigEdgeRunnerLordGymByActivityId.HandleId, 1, p0ActivityId, ConfigEdgeRunnerLordGymByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigEdgeRunnerLordGymByActivityId.HandleId, ConfigEdgeRunnerLordGymByActivityId.LogPair);
				return null;
			}
			List<EdgeRunnerLordGym> list = new List<EdgeRunnerLordGym>();
			while (ConfigCommon.Step(ConfigEdgeRunnerLordGymByActivityId.HandleId, false, ConfigEdgeRunnerLordGymByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigEdgeRunnerLordGymByActivityId.HandleId, 0, ConfigEdgeRunnerLordGymByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigEdgeRunnerLordGymByActivityId.HandleId, ConfigEdgeRunnerLordGymByActivityId.LogPair);
					return null;
				}
				EdgeRunnerLordGym rootAsEdgeRunnerLordGym = EdgeRunnerLordGym.GetRootAsEdgeRunnerLordGym(new ByteBuffer(item2));
				list.Add(rootAsEdgeRunnerLordGym);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("EdgeRunnerLordGymByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigEdgeRunnerLordGymByActivityId.HandleId, ConfigEdgeRunnerLordGymByActivityId.LogPair);
			return list;
		}

		// Token: 0x04001076 RID: 4214
		private const string DB = "db_edgerunner.db";

		// Token: 0x04001077 RID: 4215
		private const string FILE = "b.边缘行者联动.xlsx";

		// Token: 0x04001078 RID: 4216
		private const string TABLE = "EdgeRunnerLordGym";

		// Token: 0x04001079 RID: 4217
		private const string COMMAND = "select BinData from `EdgeRunnerLordGym` where ActivityId=?";

		// Token: 0x0400107A RID: 4218
		private const string KEY_PREFIX = "EdgeRunnerLordGymByActivityId";

		// Token: 0x0400107B RID: 4219
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400107C RID: 4220
		private static int HandleId;
	}
}
