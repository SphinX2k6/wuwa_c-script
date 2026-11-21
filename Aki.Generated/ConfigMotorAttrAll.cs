using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000589 RID: 1417
	public class ConfigMotorAttrAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002143 RID: 8515 RVA: 0x00119077 File Offset: 0x00117277
		static ConfigMotorAttrAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorAttrAll.CreateStaticDefaultValue), new Action(ConfigMotorAttrAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002144 RID: 8516 RVA: 0x00119098 File Offset: 0x00117298
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorAttrAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorAttrAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motor.db"),
				new ValueTuple<string, object>("文件", "m.摩托车.xlsx"),
				new ValueTuple<string, object>("表名", "MotorAttr"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorAttr`")
			});
		}

		// Token: 0x06002145 RID: 8517 RVA: 0x00119117 File Offset: 0x00117317
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorAttrAll.LogPair = null;
			ConfigMotorAttrAll.HandleId = 0;
		}

		// Token: 0x06002146 RID: 8518 RVA: 0x00119125 File Offset: 0x00117325
		public static void Init()
		{
			ConfigMotorAttrAll.HandleId = ConfigCommon.InitDataStatement(ConfigMotorAttrAll.HandleId, "db_motor.db", "select BinData from `MotorAttr`");
		}

		// Token: 0x06002147 RID: 8519 RVA: 0x00119140 File Offset: 0x00117340
		[NullableContext(2)]
		public static IReadOnlyList<MotorAttr> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorAttrAll.HandleId, ConfigMotorAttrAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<MotorAttr> readOnlyList = (IReadOnlyList<MotorAttr>)ConfigCommon.GetConfig("MotorAttrAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<MotorAttr> list = new List<MotorAttr>();
			while (ConfigCommon.Step(ConfigMotorAttrAll.HandleId, false, ConfigMotorAttrAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorAttrAll.HandleId, 0, ConfigMotorAttrAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMotorAttrAll.HandleId, ConfigMotorAttrAll.LogPair);
					return null;
				}
				MotorAttr rootAsMotorAttr = MotorAttr.GetRootAsMotorAttr(new ByteBuffer(item2));
				list.Add(rootAsMotorAttr);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("MotorAttrAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigMotorAttrAll.HandleId, ConfigMotorAttrAll.LogPair);
			return list;
		}

		// Token: 0x040026A3 RID: 9891
		private const string DB = "db_motor.db";

		// Token: 0x040026A4 RID: 9892
		private const string FILE = "m.摩托车.xlsx";

		// Token: 0x040026A5 RID: 9893
		private const string TABLE = "MotorAttr";

		// Token: 0x040026A6 RID: 9894
		private const string COMMAND = "select BinData from `MotorAttr`";

		// Token: 0x040026A7 RID: 9895
		private const string KEY_PREFIX = "MotorAttrAll";

		// Token: 0x040026A8 RID: 9896
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040026A9 RID: 9897
		private static int HandleId;
	}
}
