using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005AE RID: 1454
	public class ConfigMotorLoadProjectAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002221 RID: 8737 RVA: 0x0011A8D8 File Offset: 0x00118AD8
		static ConfigMotorLoadProjectAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorLoadProjectAll.CreateStaticDefaultValue), new Action(ConfigMotorLoadProjectAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002222 RID: 8738 RVA: 0x0011A8F8 File Offset: 0x00118AF8
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

		// Token: 0x06002223 RID: 8739 RVA: 0x0011A977 File Offset: 0x00118B77
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorLoadProjectAll.LogPair = null;
			ConfigMotorLoadProjectAll.HandleId = 0;
		}

		// Token: 0x06002224 RID: 8740 RVA: 0x0011A985 File Offset: 0x00118B85
		public static void Init()
		{
			ConfigMotorLoadProjectAll.HandleId = ConfigCommon.InitDataStatement(ConfigMotorLoadProjectAll.HandleId, "db_motordiy.db", "select BinData from `MotorLoadProject`");
		}

		// Token: 0x06002225 RID: 8741 RVA: 0x0011A9A0 File Offset: 0x00118BA0
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

		// Token: 0x040027A6 RID: 10150
		private const string DB = "db_motordiy.db";

		// Token: 0x040027A7 RID: 10151
		private const string FILE = "m.摩托车自定义.xlsx";

		// Token: 0x040027A8 RID: 10152
		private const string TABLE = "MotorLoadProject";

		// Token: 0x040027A9 RID: 10153
		private const string COMMAND = "select BinData from `MotorLoadProject`";

		// Token: 0x040027AA RID: 10154
		private const string KEY_PREFIX = "MotorLoadProjectAll";

		// Token: 0x040027AB RID: 10155
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040027AC RID: 10156
		private static int HandleId;
	}
}
