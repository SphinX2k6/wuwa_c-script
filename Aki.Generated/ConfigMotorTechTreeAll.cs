using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005E6 RID: 1510
	public class ConfigMotorTechTreeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002371 RID: 9073 RVA: 0x00125738 File Offset: 0x00123938
		static ConfigMotorTechTreeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorTechTreeAll.CreateStaticDefaultValue), new Action(ConfigMotorTechTreeAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002372 RID: 9074 RVA: 0x00125758 File Offset: 0x00123958
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

		// Token: 0x06002373 RID: 9075 RVA: 0x001257D7 File Offset: 0x001239D7
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorTechTreeAll.LogPair = null;
			ConfigMotorTechTreeAll.HandleId = 0;
		}

		// Token: 0x06002374 RID: 9076 RVA: 0x001257E5 File Offset: 0x001239E5
		public static void Init()
		{
			ConfigMotorTechTreeAll.HandleId = ConfigCommon.InitDataStatement(ConfigMotorTechTreeAll.HandleId, "db_motor.db", "select BinData from `MotorTechTree`");
		}

		// Token: 0x06002375 RID: 9077 RVA: 0x00125800 File Offset: 0x00123A00
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

		// Token: 0x0400292E RID: 10542
		private const string DB = "db_motor.db";

		// Token: 0x0400292F RID: 10543
		private const string FILE = "m.摩托车.xlsx";

		// Token: 0x04002930 RID: 10544
		private const string TABLE = "MotorTechTree";

		// Token: 0x04002931 RID: 10545
		private const string COMMAND = "select BinData from `MotorTechTree`";

		// Token: 0x04002932 RID: 10546
		private const string KEY_PREFIX = "MotorTechTreeAll";

		// Token: 0x04002933 RID: 10547
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002934 RID: 10548
		private static int HandleId;
	}
}
