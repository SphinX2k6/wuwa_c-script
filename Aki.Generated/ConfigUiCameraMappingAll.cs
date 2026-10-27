using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A61 RID: 2657
	public class ConfigUiCameraMappingAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003E5A RID: 15962 RVA: 0x001BA8E8 File Offset: 0x001B8AE8
		static ConfigUiCameraMappingAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigUiCameraMappingAll.CreateStaticDefaultValue), new Action(ConfigUiCameraMappingAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003E5B RID: 15963 RVA: 0x001BA908 File Offset: 0x001B8B08
		public static void CreateStaticDefaultValue()
		{
			ConfigUiCameraMappingAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigUiCameraMappingAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_uicamera.db"),
				new ValueTuple<string, object>("文件", "u.Ui相机.xlsx"),
				new ValueTuple<string, object>("表名", "UiCameraMapping"),
				new ValueTuple<string, object>("语句", "select BinData from `UiCameraMapping`")
			});
		}

		// Token: 0x06003E5C RID: 15964 RVA: 0x001BA987 File Offset: 0x001B8B87
		public static void ResetStaticDefaultValue()
		{
			ConfigUiCameraMappingAll.LogPair = null;
			ConfigUiCameraMappingAll.HandleId = 0;
		}

		// Token: 0x06003E5D RID: 15965 RVA: 0x001BA995 File Offset: 0x001B8B95
		public static void Init()
		{
			ConfigUiCameraMappingAll.HandleId = ConfigCommon.InitDataStatement(ConfigUiCameraMappingAll.HandleId, "db_uicamera.db", "select BinData from `UiCameraMapping`");
		}

		// Token: 0x06003E5E RID: 15966 RVA: 0x001BA9B0 File Offset: 0x001B8BB0
		[NullableContext(2)]
		public static IReadOnlyList<UiCameraMapping> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigUiCameraMappingAll.HandleId, ConfigUiCameraMappingAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<UiCameraMapping> readOnlyList = (IReadOnlyList<UiCameraMapping>)ConfigCommon.GetConfig("UiCameraMappingAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<UiCameraMapping> list = new List<UiCameraMapping>();
			while (ConfigCommon.Step(ConfigUiCameraMappingAll.HandleId, false, ConfigUiCameraMappingAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigUiCameraMappingAll.HandleId, 0, ConfigUiCameraMappingAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigUiCameraMappingAll.HandleId, ConfigUiCameraMappingAll.LogPair);
					return null;
				}
				UiCameraMapping rootAsUiCameraMapping = UiCameraMapping.GetRootAsUiCameraMapping(new ByteBuffer(item2));
				list.Add(rootAsUiCameraMapping);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("UiCameraMappingAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigUiCameraMappingAll.HandleId, ConfigUiCameraMappingAll.LogPair);
			return list;
		}

		// Token: 0x0400488D RID: 18573
		private const string DB = "db_uicamera.db";

		// Token: 0x0400488E RID: 18574
		private const string FILE = "u.Ui相机.xlsx";

		// Token: 0x0400488F RID: 18575
		private const string TABLE = "UiCameraMapping";

		// Token: 0x04004890 RID: 18576
		private const string COMMAND = "select BinData from `UiCameraMapping`";

		// Token: 0x04004891 RID: 18577
		private const string KEY_PREFIX = "UiCameraMappingAll";

		// Token: 0x04004892 RID: 18578
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004893 RID: 18579
		private static int HandleId;
	}
}
