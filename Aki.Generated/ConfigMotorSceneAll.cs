using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005D8 RID: 1496
	public class ConfigMotorSceneAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600231D RID: 8989 RVA: 0x00123984 File Offset: 0x00121B84
		static ConfigMotorSceneAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorSceneAll.CreateStaticDefaultValue), new Action(ConfigMotorSceneAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600231E RID: 8990 RVA: 0x001239A4 File Offset: 0x00121BA4
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorSceneAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorSceneAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motordiy.db"),
				new ValueTuple<string, object>("文件", "m.摩托车自定义.xlsx"),
				new ValueTuple<string, object>("表名", "MotorScene"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorScene`")
			});
		}

		// Token: 0x0600231F RID: 8991 RVA: 0x00123A23 File Offset: 0x00121C23
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorSceneAll.LogPair = null;
			ConfigMotorSceneAll.HandleId = 0;
		}

		// Token: 0x06002320 RID: 8992 RVA: 0x00123A31 File Offset: 0x00121C31
		public static void Init()
		{
			ConfigMotorSceneAll.HandleId = ConfigCommon.InitDataStatement(ConfigMotorSceneAll.HandleId, "db_motordiy.db", "select BinData from `MotorScene`");
		}

		// Token: 0x06002321 RID: 8993 RVA: 0x00123A4C File Offset: 0x00121C4C
		[NullableContext(2)]
		public static IReadOnlyList<MotorScene> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorSceneAll.HandleId, ConfigMotorSceneAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<MotorScene> readOnlyList = (IReadOnlyList<MotorScene>)ConfigCommon.GetConfig("MotorSceneAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<MotorScene> list = new List<MotorScene>();
			while (ConfigCommon.Step(ConfigMotorSceneAll.HandleId, false, ConfigMotorSceneAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorSceneAll.HandleId, 0, ConfigMotorSceneAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMotorSceneAll.HandleId, ConfigMotorSceneAll.LogPair);
					return null;
				}
				MotorScene rootAsMotorScene = MotorScene.GetRootAsMotorScene(new ByteBuffer(item2));
				list.Add(rootAsMotorScene);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("MotorSceneAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigMotorSceneAll.HandleId, ConfigMotorSceneAll.LogPair);
			return list;
		}

		// Token: 0x040028CC RID: 10444
		private const string DB = "db_motordiy.db";

		// Token: 0x040028CD RID: 10445
		private const string FILE = "m.摩托车自定义.xlsx";

		// Token: 0x040028CE RID: 10446
		private const string TABLE = "MotorScene";

		// Token: 0x040028CF RID: 10447
		private const string COMMAND = "select BinData from `MotorScene`";

		// Token: 0x040028D0 RID: 10448
		private const string KEY_PREFIX = "MotorSceneAll";

		// Token: 0x040028D1 RID: 10449
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040028D2 RID: 10450
		private static int HandleId;
	}
}
