using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200024A RID: 586
	public class ConfigEdgeRunnerLordGymByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000DC0 RID: 3520 RVA: 0x000A73D8 File Offset: 0x000A55D8
		static ConfigEdgeRunnerLordGymByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEdgeRunnerLordGymByActivityId.CreateStaticDefaultValue), new Action(ConfigEdgeRunnerLordGymByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x000A73F8 File Offset: 0x000A55F8
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

		// Token: 0x06000DC2 RID: 3522 RVA: 0x000A7477 File Offset: 0x000A5677
		public static void ResetStaticDefaultValue()
		{
			ConfigEdgeRunnerLordGymByActivityId.LogPair = null;
			ConfigEdgeRunnerLordGymByActivityId.HandleId = 0;
		}

		// Token: 0x06000DC3 RID: 3523 RVA: 0x000A7485 File Offset: 0x000A5685
		public static void Init()
		{
			ConfigEdgeRunnerLordGymByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigEdgeRunnerLordGymByActivityId.HandleId, "db_edgerunner.db", "select BinData from `EdgeRunnerLordGym` where ActivityId=?");
		}

		// Token: 0x06000DC4 RID: 3524 RVA: 0x000A74A0 File Offset: 0x000A56A0
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

		// Token: 0x04000FEA RID: 4074
		private const string DB = "db_edgerunner.db";

		// Token: 0x04000FEB RID: 4075
		private const string FILE = "b.边缘行者联动.xlsx";

		// Token: 0x04000FEC RID: 4076
		private const string TABLE = "EdgeRunnerLordGym";

		// Token: 0x04000FED RID: 4077
		private const string COMMAND = "select BinData from `EdgeRunnerLordGym` where ActivityId=?";

		// Token: 0x04000FEE RID: 4078
		private const string KEY_PREFIX = "EdgeRunnerLordGymByActivityId";

		// Token: 0x04000FEF RID: 4079
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000FF0 RID: 4080
		private static int HandleId;
	}
}
