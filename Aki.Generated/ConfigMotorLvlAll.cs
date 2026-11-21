using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005C7 RID: 1479
	public class ConfigMotorLvlAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060022B7 RID: 8887 RVA: 0x0012159C File Offset: 0x0011F79C
		static ConfigMotorLvlAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorLvlAll.CreateStaticDefaultValue), new Action(ConfigMotorLvlAll.ResetStaticDefaultValue));
		}

		// Token: 0x060022B8 RID: 8888 RVA: 0x001215BC File Offset: 0x0011F7BC
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorLvlAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorLvlAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motor.db"),
				new ValueTuple<string, object>("文件", "m.摩托车.xlsx"),
				new ValueTuple<string, object>("表名", "MotorLvl"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorLvl`")
			});
		}

		// Token: 0x060022B9 RID: 8889 RVA: 0x0012163B File Offset: 0x0011F83B
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorLvlAll.LogPair = null;
			ConfigMotorLvlAll.HandleId = 0;
		}

		// Token: 0x060022BA RID: 8890 RVA: 0x00121649 File Offset: 0x0011F849
		public static void Init()
		{
			ConfigMotorLvlAll.HandleId = ConfigCommon.InitDataStatement(ConfigMotorLvlAll.HandleId, "db_motor.db", "select BinData from `MotorLvl`");
		}

		// Token: 0x060022BB RID: 8891 RVA: 0x00121664 File Offset: 0x0011F864
		[NullableContext(2)]
		public static IReadOnlyList<MotorLvl> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorLvlAll.HandleId, ConfigMotorLvlAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<MotorLvl> readOnlyList = (IReadOnlyList<MotorLvl>)ConfigCommon.GetConfig("MotorLvlAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<MotorLvl> list = new List<MotorLvl>();
			while (ConfigCommon.Step(ConfigMotorLvlAll.HandleId, false, ConfigMotorLvlAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorLvlAll.HandleId, 0, ConfigMotorLvlAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMotorLvlAll.HandleId, ConfigMotorLvlAll.LogPair);
					return null;
				}
				MotorLvl rootAsMotorLvl = MotorLvl.GetRootAsMotorLvl(new ByteBuffer(item2));
				list.Add(rootAsMotorLvl);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("MotorLvlAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigMotorLvlAll.HandleId, ConfigMotorLvlAll.LogPair);
			return list;
		}

		// Token: 0x04002855 RID: 10325
		private const string DB = "db_motor.db";

		// Token: 0x04002856 RID: 10326
		private const string FILE = "m.摩托车.xlsx";

		// Token: 0x04002857 RID: 10327
		private const string TABLE = "MotorLvl";

		// Token: 0x04002858 RID: 10328
		private const string COMMAND = "select BinData from `MotorLvl`";

		// Token: 0x04002859 RID: 10329
		private const string KEY_PREFIX = "MotorLvlAll";

		// Token: 0x0400285A RID: 10330
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400285B RID: 10331
		private static int HandleId;
	}
}
