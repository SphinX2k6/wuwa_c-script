using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000159 RID: 345
	public class ConfigChildUiCameraMappingAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000817 RID: 2071 RVA: 0x00087464 File Offset: 0x00085664
		static ConfigChildUiCameraMappingAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigChildUiCameraMappingAll.CreateStaticDefaultValue), new Action(ConfigChildUiCameraMappingAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x00087484 File Offset: 0x00085684
		public static void CreateStaticDefaultValue()
		{
			ConfigChildUiCameraMappingAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigChildUiCameraMappingAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_uicamera.db"),
				new ValueTuple<string, object>("文件", "u.Ui相机.xlsx"),
				new ValueTuple<string, object>("表名", "ChildUiCameraMapping"),
				new ValueTuple<string, object>("语句", "select BinData from `ChildUiCameraMapping`")
			});
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x00087503 File Offset: 0x00085703
		public static void ResetStaticDefaultValue()
		{
			ConfigChildUiCameraMappingAll.LogPair = null;
			ConfigChildUiCameraMappingAll.HandleId = 0;
		}

		// Token: 0x0600081A RID: 2074 RVA: 0x00087511 File Offset: 0x00085711
		public static void Init()
		{
			ConfigChildUiCameraMappingAll.HandleId = ConfigCommon.InitDataStatement(ConfigChildUiCameraMappingAll.HandleId, "db_uicamera.db", "select BinData from `ChildUiCameraMapping`");
		}

		// Token: 0x0600081B RID: 2075 RVA: 0x0008752C File Offset: 0x0008572C
		[NullableContext(2)]
		public static IReadOnlyList<ChildUiCameraMapping> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigChildUiCameraMappingAll.HandleId, ConfigChildUiCameraMappingAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<ChildUiCameraMapping> readOnlyList = (IReadOnlyList<ChildUiCameraMapping>)ConfigCommon.GetConfig("ChildUiCameraMappingAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<ChildUiCameraMapping> list = new List<ChildUiCameraMapping>();
			while (ConfigCommon.Step(ConfigChildUiCameraMappingAll.HandleId, false, ConfigChildUiCameraMappingAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigChildUiCameraMappingAll.HandleId, 0, ConfigChildUiCameraMappingAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigChildUiCameraMappingAll.HandleId, ConfigChildUiCameraMappingAll.LogPair);
					return null;
				}
				ChildUiCameraMapping rootAsChildUiCameraMapping = ChildUiCameraMapping.GetRootAsChildUiCameraMapping(new ByteBuffer(item2));
				list.Add(rootAsChildUiCameraMapping);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("ChildUiCameraMappingAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigChildUiCameraMappingAll.HandleId, ConfigChildUiCameraMappingAll.LogPair);
			return list;
		}

		// Token: 0x04000953 RID: 2387
		private const string DB = "db_uicamera.db";

		// Token: 0x04000954 RID: 2388
		private const string FILE = "u.Ui相机.xlsx";

		// Token: 0x04000955 RID: 2389
		private const string TABLE = "ChildUiCameraMapping";

		// Token: 0x04000956 RID: 2390
		private const string COMMAND = "select BinData from `ChildUiCameraMapping`";

		// Token: 0x04000957 RID: 2391
		private const string KEY_PREFIX = "ChildUiCameraMappingAll";

		// Token: 0x04000958 RID: 2392
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000959 RID: 2393
		private static int HandleId;
	}
}
