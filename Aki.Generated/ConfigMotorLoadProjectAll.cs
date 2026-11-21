using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005C5 RID: 1477
	public class ConfigMotorLoadProjectAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060022AB RID: 8875 RVA: 0x001211C0 File Offset: 0x0011F3C0
		static ConfigMotorLoadProjectAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorLoadProjectAll.CreateStaticDefaultValue), new Action(ConfigMotorLoadProjectAll.ResetStaticDefaultValue));
		}

		// Token: 0x060022AC RID: 8876 RVA: 0x001211E0 File Offset: 0x0011F3E0
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorLoadProjectAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorLoadProjectAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motordiy.db"),
				new ValueTuple<string, object>("文件", "m.摩托车自定义.xlsx"),
				new ValueTuple<string, object>("表名", "MotorLoadProject"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorLoadProject`")
			});
		}

		// Token: 0x060022AD RID: 8877 RVA: 0x0012125F File Offset: 0x0011F45F
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorLoadProjectAll.LogPair = null;
			ConfigMotorLoadProjectAll.HandleId = 0;
		}

		// Token: 0x060022AE RID: 8878 RVA: 0x0012126D File Offset: 0x0011F46D
		public static void Init()
		{
			ConfigMotorLoadProjectAll.HandleId = ConfigCommon.InitDataStatement(ConfigMotorLoadProjectAll.HandleId, "db_motordiy.db", "select BinData from `MotorLoadProject`");
		}

		// Token: 0x060022AF RID: 8879 RVA: 0x00121288 File Offset: 0x0011F488
		[NullableContext(2)]
		public static IReadOnlyList<MotorLoadProject> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorLoadProjectAll.HandleId, ConfigMotorLoadProjectAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<MotorLoadProject> readOnlyList = (IReadOnlyList<MotorLoadProject>)ConfigCommon.GetConfig("MotorLoadProjectAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<MotorLoadProject> list = new List<MotorLoadProject>();
			while (ConfigCommon.Step(ConfigMotorLoadProjectAll.HandleId, false, ConfigMotorLoadProjectAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorLoadProjectAll.HandleId, 0, ConfigMotorLoadProjectAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMotorLoadProjectAll.HandleId, ConfigMotorLoadProjectAll.LogPair);
					return null;
				}
				MotorLoadProject rootAsMotorLoadProject = MotorLoadProject.GetRootAsMotorLoadProject(new ByteBuffer(item2));
				list.Add(rootAsMotorLoadProject);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("MotorLoadProjectAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigMotorLoadProjectAll.HandleId, ConfigMotorLoadProjectAll.LogPair);
			return list;
		}

		// Token: 0x04002847 RID: 10311
		private const string DB = "db_motordiy.db";

		// Token: 0x04002848 RID: 10312
		private const string FILE = "m.摩托车自定义.xlsx";

		// Token: 0x04002849 RID: 10313
		private const string TABLE = "MotorLoadProject";

		// Token: 0x0400284A RID: 10314
		private const string COMMAND = "select BinData from `MotorLoadProject`";

		// Token: 0x0400284B RID: 10315
		private const string KEY_PREFIX = "MotorLoadProjectAll";

		// Token: 0x0400284C RID: 10316
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400284D RID: 10317
		private static int HandleId;
	}
}
