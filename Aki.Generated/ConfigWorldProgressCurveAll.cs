using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A9D RID: 2717
	public class ConfigWorldProgressCurveAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003FC3 RID: 16323 RVA: 0x001C2EA0 File Offset: 0x001C10A0
		static ConfigWorldProgressCurveAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWorldProgressCurveAll.CreateStaticDefaultValue), new Action(ConfigWorldProgressCurveAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003FC4 RID: 16324 RVA: 0x001C2EC0 File Offset: 0x001C10C0
		public static void CreateStaticDefaultValue()
		{
			ConfigWorldProgressCurveAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigWorldProgressCurveAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_anniversaryt.db"),
				new ValueTuple<string, object>("文件", "z.周年庆主题活动.xlsx"),
				new ValueTuple<string, object>("表名", "WorldProgressCurve"),
				new ValueTuple<string, object>("语句", "select BinData from `WorldProgressCurve`")
			});
		}

		// Token: 0x06003FC5 RID: 16325 RVA: 0x001C2F3F File Offset: 0x001C113F
		public static void ResetStaticDefaultValue()
		{
			ConfigWorldProgressCurveAll.LogPair = null;
			ConfigWorldProgressCurveAll.HandleId = 0;
		}

		// Token: 0x06003FC6 RID: 16326 RVA: 0x001C2F4D File Offset: 0x001C114D
		public static void Init()
		{
			ConfigWorldProgressCurveAll.HandleId = ConfigCommon.InitDataStatement(ConfigWorldProgressCurveAll.HandleId, "db_anniversaryt.db", "select BinData from `WorldProgressCurve`");
		}

		// Token: 0x06003FC7 RID: 16327 RVA: 0x001C2F68 File Offset: 0x001C1168
		[NullableContext(2)]
		public static IReadOnlyList<WorldProgressCurve> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigWorldProgressCurveAll.HandleId, ConfigWorldProgressCurveAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<WorldProgressCurve> readOnlyList = (IReadOnlyList<WorldProgressCurve>)ConfigCommon.GetConfig("WorldProgressCurveAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<WorldProgressCurve> list = new List<WorldProgressCurve>();
			while (ConfigCommon.Step(ConfigWorldProgressCurveAll.HandleId, false, ConfigWorldProgressCurveAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigWorldProgressCurveAll.HandleId, 0, ConfigWorldProgressCurveAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigWorldProgressCurveAll.HandleId, ConfigWorldProgressCurveAll.LogPair);
					return null;
				}
				WorldProgressCurve rootAsWorldProgressCurve = WorldProgressCurve.GetRootAsWorldProgressCurve(new ByteBuffer(item2));
				list.Add(rootAsWorldProgressCurve);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("WorldProgressCurveAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigWorldProgressCurveAll.HandleId, ConfigWorldProgressCurveAll.LogPair);
			return list;
		}

		// Token: 0x04004A31 RID: 18993
		private const string DB = "db_anniversaryt.db";

		// Token: 0x04004A32 RID: 18994
		private const string FILE = "z.周年庆主题活动.xlsx";

		// Token: 0x04004A33 RID: 18995
		private const string TABLE = "WorldProgressCurve";

		// Token: 0x04004A34 RID: 18996
		private const string COMMAND = "select BinData from `WorldProgressCurve`";

		// Token: 0x04004A35 RID: 18997
		private const string KEY_PREFIX = "WorldProgressCurveAll";

		// Token: 0x04004A36 RID: 18998
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004A37 RID: 18999
		private static int HandleId;
	}
}
