using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B38 RID: 2872
	public class ConfigUiCameraMappingByViewName : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004364 RID: 17252 RVA: 0x001DA058 File Offset: 0x001D8258
		static ConfigUiCameraMappingByViewName()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigUiCameraMappingByViewName.CreateStaticDefaultValue), new Action(ConfigUiCameraMappingByViewName.ResetStaticDefaultValue));
		}

		// Token: 0x06004365 RID: 17253 RVA: 0x001DA078 File Offset: 0x001D8278
		public static void CreateStaticDefaultValue()
		{
			ConfigUiCameraMappingByViewName.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigUiCameraMappingByViewName.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_uicamera.db"),
				new ValueTuple<string, object>("文件", "u.Ui相机.xlsx"),
				new ValueTuple<string, object>("表名", "UiCameraMapping"),
				new ValueTuple<string, object>("语句", "select BinData from `UiCameraMapping` where ViewName=?")
			});
		}

		// Token: 0x06004366 RID: 17254 RVA: 0x001DA0F7 File Offset: 0x001D82F7
		public static void ResetStaticDefaultValue()
		{
			ConfigUiCameraMappingByViewName.LogPair = null;
			ConfigUiCameraMappingByViewName.HandleId = 0;
		}

		// Token: 0x06004367 RID: 17255 RVA: 0x001DA105 File Offset: 0x001D8305
		public static void Init()
		{
			ConfigUiCameraMappingByViewName.HandleId = ConfigCommon.InitDataStatement(ConfigUiCameraMappingByViewName.HandleId, "db_uicamera.db", "select BinData from `UiCameraMapping` where ViewName=?");
		}

		// Token: 0x06004368 RID: 17256 RVA: 0x001DA120 File Offset: 0x001D8320
		public static UiCameraMapping? GetConfig(string p0ViewName, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigUiCameraMappingByViewName.HandleId, ConfigUiCameraMappingByViewName.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("UiCameraMappingByViewName#" + p0ViewName);
				if (configBuffer != null)
				{
					return new UiCameraMapping?(UiCameraMapping.GetRootAsUiCameraMapping(configBuffer));
				}
			}
			ConfigUiCameraMappingByViewName.LogPair.Clear();
			ConfigUiCameraMappingByViewName.LogPair.Add(new ValueTuple<string, object>("ViewName", p0ViewName));
			if (!ConfigCommon.BindString(ConfigUiCameraMappingByViewName.HandleId, 1, p0ViewName, ConfigUiCameraMappingByViewName.LogPair) || ConfigCommon.Step(ConfigUiCameraMappingByViewName.HandleId, true, ConfigUiCameraMappingByViewName.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigUiCameraMappingByViewName.HandleId, ConfigUiCameraMappingByViewName.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigUiCameraMappingByViewName.HandleId, 0, ConfigUiCameraMappingByViewName.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigUiCameraMappingByViewName.HandleId, ConfigUiCameraMappingByViewName.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			UiCameraMapping rootAsUiCameraMapping = UiCameraMapping.GetRootAsUiCameraMapping(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("UiCameraMappingByViewName#" + p0ViewName, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigUiCameraMappingByViewName.HandleId, ConfigUiCameraMappingByViewName.LogPair);
			return new UiCameraMapping?(rootAsUiCameraMapping);
		}

		// Token: 0x04004E6E RID: 20078
		private const string DB = "db_uicamera.db";

		// Token: 0x04004E6F RID: 20079
		private const string FILE = "u.Ui相机.xlsx";

		// Token: 0x04004E70 RID: 20080
		private const string TABLE = "UiCameraMapping";

		// Token: 0x04004E71 RID: 20081
		private const string COMMAND = "select BinData from `UiCameraMapping` where ViewName=?";

		// Token: 0x04004E72 RID: 20082
		private const string KEY_PREFIX = "UiCameraMappingByViewName";

		// Token: 0x04004E73 RID: 20083
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004E74 RID: 20084
		private static int HandleId;
	}
}
