using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000169 RID: 361
	public class ConfigChildUiCameraMappingAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000877 RID: 2167 RVA: 0x0008CFC1 File Offset: 0x0008B1C1
		static ConfigChildUiCameraMappingAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigChildUiCameraMappingAll.CreateStaticDefaultValue), new Action(ConfigChildUiCameraMappingAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x0008CFE0 File Offset: 0x0008B1E0
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

		// Token: 0x06000879 RID: 2169 RVA: 0x0008D05F File Offset: 0x0008B25F
		public static void ResetStaticDefaultValue()
		{
			ConfigChildUiCameraMappingAll.LogPair = null;
			ConfigChildUiCameraMappingAll.HandleId = 0;
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x0008D06D File Offset: 0x0008B26D
		public static void Init()
		{
			ConfigChildUiCameraMappingAll.HandleId = ConfigCommon.InitDataStatement(ConfigChildUiCameraMappingAll.HandleId, "db_uicamera.db", "select BinData from `ChildUiCameraMapping`");
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x0008D088 File Offset: 0x0008B288
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

		// Token: 0x040009C3 RID: 2499
		private const string DB = "db_uicamera.db";

		// Token: 0x040009C4 RID: 2500
		private const string FILE = "u.Ui相机.xlsx";

		// Token: 0x040009C5 RID: 2501
		private const string TABLE = "ChildUiCameraMapping";

		// Token: 0x040009C6 RID: 2502
		private const string COMMAND = "select BinData from `ChildUiCameraMapping`";

		// Token: 0x040009C7 RID: 2503
		private const string KEY_PREFIX = "ChildUiCameraMappingAll";

		// Token: 0x040009C8 RID: 2504
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040009C9 RID: 2505
		private static int HandleId;
	}
}
