using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B36 RID: 2870
	public class ConfigUiCameraMappingAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004358 RID: 17240 RVA: 0x001D9C7C File Offset: 0x001D7E7C
		static ConfigUiCameraMappingAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigUiCameraMappingAll.CreateStaticDefaultValue), new Action(ConfigUiCameraMappingAll.ResetStaticDefaultValue));
		}

		// Token: 0x06004359 RID: 17241 RVA: 0x001D9C9C File Offset: 0x001D7E9C
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

		// Token: 0x0600435A RID: 17242 RVA: 0x001D9D1B File Offset: 0x001D7F1B
		public static void ResetStaticDefaultValue()
		{
			ConfigUiCameraMappingAll.LogPair = null;
			ConfigUiCameraMappingAll.HandleId = 0;
		}

		// Token: 0x0600435B RID: 17243 RVA: 0x001D9D29 File Offset: 0x001D7F29
		public static void Init()
		{
			ConfigUiCameraMappingAll.HandleId = ConfigCommon.InitDataStatement(ConfigUiCameraMappingAll.HandleId, "db_uicamera.db", "select BinData from `UiCameraMapping`");
		}

		// Token: 0x0600435C RID: 17244 RVA: 0x001D9D44 File Offset: 0x001D7F44
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

		// Token: 0x04004E60 RID: 20064
		private const string DB = "db_uicamera.db";

		// Token: 0x04004E61 RID: 20065
		private const string FILE = "u.Ui相机.xlsx";

		// Token: 0x04004E62 RID: 20066
		private const string TABLE = "UiCameraMapping";

		// Token: 0x04004E63 RID: 20067
		private const string COMMAND = "select BinData from `UiCameraMapping`";

		// Token: 0x04004E64 RID: 20068
		private const string KEY_PREFIX = "UiCameraMappingAll";

		// Token: 0x04004E65 RID: 20069
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004E66 RID: 20070
		private static int HandleId;
	}
}
