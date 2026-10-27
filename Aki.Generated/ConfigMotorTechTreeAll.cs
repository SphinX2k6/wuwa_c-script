using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005CE RID: 1486
	public class ConfigMotorTechTreeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060022E1 RID: 8929 RVA: 0x0011ECBC File Offset: 0x0011CEBC
		static ConfigMotorTechTreeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorTechTreeAll.CreateStaticDefaultValue), new Action(ConfigMotorTechTreeAll.ResetStaticDefaultValue));
		}

		// Token: 0x060022E2 RID: 8930 RVA: 0x0011ECDC File Offset: 0x0011CEDC
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorTechTreeAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorTechTreeAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motor.db"),
				new ValueTuple<string, object>("文件", "m.摩托车.xlsx"),
				new ValueTuple<string, object>("表名", "MotorTechTree"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorTechTree`")
			});
		}

		// Token: 0x060022E3 RID: 8931 RVA: 0x0011ED5B File Offset: 0x0011CF5B
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorTechTreeAll.LogPair = null;
			ConfigMotorTechTreeAll.HandleId = 0;
		}

		// Token: 0x060022E4 RID: 8932 RVA: 0x0011ED69 File Offset: 0x0011CF69
		public static void Init()
		{
			ConfigMotorTechTreeAll.HandleId = ConfigCommon.InitDataStatement(ConfigMotorTechTreeAll.HandleId, "db_motor.db", "select BinData from `MotorTechTree`");
		}

		// Token: 0x060022E5 RID: 8933 RVA: 0x0011ED84 File Offset: 0x0011CF84
		[NullableContext(2)]
		public static IReadOnlyList<MotorTechTree> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorTechTreeAll.HandleId, ConfigMotorTechTreeAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<MotorTechTree> readOnlyList = (IReadOnlyList<MotorTechTree>)ConfigCommon.GetConfig("MotorTechTreeAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<MotorTechTree> list = new List<MotorTechTree>();
			while (ConfigCommon.Step(ConfigMotorTechTreeAll.HandleId, false, ConfigMotorTechTreeAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorTechTreeAll.HandleId, 0, ConfigMotorTechTreeAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMotorTechTreeAll.HandleId, ConfigMotorTechTreeAll.LogPair);
					return null;
				}
				MotorTechTree rootAsMotorTechTree = MotorTechTree.GetRootAsMotorTechTree(new ByteBuffer(item2));
				list.Add(rootAsMotorTechTree);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("MotorTechTreeAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigMotorTechTreeAll.HandleId, ConfigMotorTechTreeAll.LogPair);
			return list;
		}

		// Token: 0x04002886 RID: 10374
		private const string DB = "db_motor.db";

		// Token: 0x04002887 RID: 10375
		private const string FILE = "m.摩托车.xlsx";

		// Token: 0x04002888 RID: 10376
		private const string TABLE = "MotorTechTree";

		// Token: 0x04002889 RID: 10377
		private const string COMMAND = "select BinData from `MotorTechTree`";

		// Token: 0x0400288A RID: 10378
		private const string KEY_PREFIX = "MotorTechTreeAll";

		// Token: 0x0400288B RID: 10379
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400288C RID: 10380
		private static int HandleId;
	}
}
