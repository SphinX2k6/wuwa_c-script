using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200066A RID: 1642
	public class ConfigPersonProgressCurveAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600268C RID: 9868 RVA: 0x001371E0 File Offset: 0x001353E0
		static ConfigPersonProgressCurveAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPersonProgressCurveAll.CreateStaticDefaultValue), new Action(ConfigPersonProgressCurveAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600268D RID: 9869 RVA: 0x00137200 File Offset: 0x00135400
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

		// Token: 0x0600268E RID: 9870 RVA: 0x0013727F File Offset: 0x0013547F
		public static void ResetStaticDefaultValue()
		{
			ConfigPersonProgressCurveAll.LogPair = null;
			ConfigPersonProgressCurveAll.HandleId = 0;
		}

		// Token: 0x0600268F RID: 9871 RVA: 0x0013728D File Offset: 0x0013548D
		public static void Init()
		{
			ConfigPersonProgressCurveAll.HandleId = ConfigCommon.InitDataStatement(ConfigPersonProgressCurveAll.HandleId, "db_anniversaryt.db", "select BinData from `PersonProgressCurve`");
		}

		// Token: 0x06002690 RID: 9872 RVA: 0x001372A8 File Offset: 0x001354A8
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

		// Token: 0x04002CCC RID: 11468
		private const string DB = "db_anniversaryt.db";

		// Token: 0x04002CCD RID: 11469
		private const string FILE = "z.周年庆主题活动.xlsx";

		// Token: 0x04002CCE RID: 11470
		private const string TABLE = "PersonProgressCurve";

		// Token: 0x04002CCF RID: 11471
		private const string COMMAND = "select BinData from `PersonProgressCurve`";

		// Token: 0x04002CD0 RID: 11472
		private const string KEY_PREFIX = "PersonProgressCurveAll";

		// Token: 0x04002CD1 RID: 11473
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002CD2 RID: 11474
		private static int HandleId;
	}
}
