using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200015B RID: 347
	public class ConfigChildUiCameraMappingByViewName : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000823 RID: 2083 RVA: 0x00087840 File Offset: 0x00085A40
		static ConfigChildUiCameraMappingByViewName()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigChildUiCameraMappingByViewName.CreateStaticDefaultValue), new Action(ConfigChildUiCameraMappingByViewName.ResetStaticDefaultValue));
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x00087860 File Offset: 0x00085A60
		public static void CreateStaticDefaultValue()
		{
			ConfigChildUiCameraMappingByViewName.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigChildUiCameraMappingByViewName.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_uicamera.db"),
				new ValueTuple<string, object>("文件", "u.Ui相机.xlsx"),
				new ValueTuple<string, object>("表名", "ChildUiCameraMapping"),
				new ValueTuple<string, object>("语句", "select BinData from `ChildUiCameraMapping` where ViewName=?")
			});
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x000878DF File Offset: 0x00085ADF
		public static void ResetStaticDefaultValue()
		{
			ConfigChildUiCameraMappingByViewName.LogPair = null;
			ConfigChildUiCameraMappingByViewName.HandleId = 0;
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x000878ED File Offset: 0x00085AED
		public static void Init()
		{
			ConfigChildUiCameraMappingByViewName.HandleId = ConfigCommon.InitDataStatement(ConfigChildUiCameraMappingByViewName.HandleId, "db_uicamera.db", "select BinData from `ChildUiCameraMapping` where ViewName=?");
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x00087908 File Offset: 0x00085B08
		public static ChildUiCameraMapping? GetConfig(string p0ViewName, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigChildUiCameraMappingByViewName.HandleId, ConfigChildUiCameraMappingByViewName.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("ChildUiCameraMappingByViewName#" + p0ViewName);
				if (configBuffer != null)
				{
					return new ChildUiCameraMapping?(ChildUiCameraMapping.GetRootAsChildUiCameraMapping(configBuffer));
				}
			}
			ConfigChildUiCameraMappingByViewName.LogPair.Clear();
			ConfigChildUiCameraMappingByViewName.LogPair.Add(new ValueTuple<string, object>("ViewName", p0ViewName));
			if (!ConfigCommon.BindString(ConfigChildUiCameraMappingByViewName.HandleId, 1, p0ViewName, ConfigChildUiCameraMappingByViewName.LogPair) || ConfigCommon.Step(ConfigChildUiCameraMappingByViewName.HandleId, true, ConfigChildUiCameraMappingByViewName.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigChildUiCameraMappingByViewName.HandleId, ConfigChildUiCameraMappingByViewName.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigChildUiCameraMappingByViewName.HandleId, 0, ConfigChildUiCameraMappingByViewName.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigChildUiCameraMappingByViewName.HandleId, ConfigChildUiCameraMappingByViewName.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ChildUiCameraMapping rootAsChildUiCameraMapping = ChildUiCameraMapping.GetRootAsChildUiCameraMapping(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("ChildUiCameraMappingByViewName#" + p0ViewName, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigChildUiCameraMappingByViewName.HandleId, ConfigChildUiCameraMappingByViewName.LogPair);
			return new ChildUiCameraMapping?(rootAsChildUiCameraMapping);
		}

		// Token: 0x04000961 RID: 2401
		private const string DB = "db_uicamera.db";

		// Token: 0x04000962 RID: 2402
		private const string FILE = "u.Ui相机.xlsx";

		// Token: 0x04000963 RID: 2403
		private const string TABLE = "ChildUiCameraMapping";

		// Token: 0x04000964 RID: 2404
		private const string COMMAND = "select BinData from `ChildUiCameraMapping` where ViewName=?";

		// Token: 0x04000965 RID: 2405
		private const string KEY_PREFIX = "ChildUiCameraMappingByViewName";

		// Token: 0x04000966 RID: 2406
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000967 RID: 2407
		private static int HandleId;
	}
}
