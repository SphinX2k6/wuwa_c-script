using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000652 RID: 1618
	public class ConfigPersonProgressCurveAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060025FC RID: 9724 RVA: 0x00130764 File Offset: 0x0012E964
		static ConfigPersonProgressCurveAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPersonProgressCurveAll.CreateStaticDefaultValue), new Action(ConfigPersonProgressCurveAll.ResetStaticDefaultValue));
		}

		// Token: 0x060025FD RID: 9725 RVA: 0x00130784 File Offset: 0x0012E984
		public static void CreateStaticDefaultValue()
		{
			ConfigPersonProgressCurveAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPersonProgressCurveAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_anniversaryt.db"),
				new ValueTuple<string, object>("文件", "z.周年庆主题活动.xlsx"),
				new ValueTuple<string, object>("表名", "PersonProgressCurve"),
				new ValueTuple<string, object>("语句", "select BinData from `PersonProgressCurve`")
			});
		}

		// Token: 0x060025FE RID: 9726 RVA: 0x00130803 File Offset: 0x0012EA03
		public static void ResetStaticDefaultValue()
		{
			ConfigPersonProgressCurveAll.LogPair = null;
			ConfigPersonProgressCurveAll.HandleId = 0;
		}

		// Token: 0x060025FF RID: 9727 RVA: 0x00130811 File Offset: 0x0012EA11
		public static void Init()
		{
			ConfigPersonProgressCurveAll.HandleId = ConfigCommon.InitDataStatement(ConfigPersonProgressCurveAll.HandleId, "db_anniversaryt.db", "select BinData from `PersonProgressCurve`");
		}

		// Token: 0x06002600 RID: 9728 RVA: 0x0013082C File Offset: 0x0012EA2C
		[NullableContext(2)]
		public static IReadOnlyList<PersonProgressCurve> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPersonProgressCurveAll.HandleId, ConfigPersonProgressCurveAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PersonProgressCurve> readOnlyList = (IReadOnlyList<PersonProgressCurve>)ConfigCommon.GetConfig("PersonProgressCurveAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PersonProgressCurve> list = new List<PersonProgressCurve>();
			while (ConfigCommon.Step(ConfigPersonProgressCurveAll.HandleId, false, ConfigPersonProgressCurveAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPersonProgressCurveAll.HandleId, 0, ConfigPersonProgressCurveAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPersonProgressCurveAll.HandleId, ConfigPersonProgressCurveAll.LogPair);
					return null;
				}
				PersonProgressCurve rootAsPersonProgressCurve = PersonProgressCurve.GetRootAsPersonProgressCurve(new ByteBuffer(item2));
				list.Add(rootAsPersonProgressCurve);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PersonProgressCurveAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPersonProgressCurveAll.HandleId, ConfigPersonProgressCurveAll.LogPair);
			return list;
		}

		// Token: 0x04002C24 RID: 11300
		private const string DB = "db_anniversaryt.db";

		// Token: 0x04002C25 RID: 11301
		private const string FILE = "z.周年庆主题活动.xlsx";

		// Token: 0x04002C26 RID: 11302
		private const string TABLE = "PersonProgressCurve";

		// Token: 0x04002C27 RID: 11303
		private const string COMMAND = "select BinData from `PersonProgressCurve`";

		// Token: 0x04002C28 RID: 11304
		private const string KEY_PREFIX = "PersonProgressCurveAll";

		// Token: 0x04002C29 RID: 11305
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002C2A RID: 11306
		private static int HandleId;
	}
}
