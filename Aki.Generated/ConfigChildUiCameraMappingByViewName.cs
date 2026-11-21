using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200016B RID: 363
	public class ConfigChildUiCameraMappingByViewName : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000883 RID: 2179 RVA: 0x0008D39C File Offset: 0x0008B59C
		static ConfigChildUiCameraMappingByViewName()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigChildUiCameraMappingByViewName.CreateStaticDefaultValue), new Action(ConfigChildUiCameraMappingByViewName.ResetStaticDefaultValue));
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x0008D3BC File Offset: 0x0008B5BC
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

		// Token: 0x06000885 RID: 2181 RVA: 0x0008D43B File Offset: 0x0008B63B
		public static void ResetStaticDefaultValue()
		{
			ConfigChildUiCameraMappingByViewName.LogPair = null;
			ConfigChildUiCameraMappingByViewName.HandleId = 0;
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x0008D449 File Offset: 0x0008B649
		public static void Init()
		{
			ConfigChildUiCameraMappingByViewName.HandleId = ConfigCommon.InitDataStatement(ConfigChildUiCameraMappingByViewName.HandleId, "db_uicamera.db", "select BinData from `ChildUiCameraMapping` where ViewName=?");
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x0008D464 File Offset: 0x0008B664
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

		// Token: 0x040009D1 RID: 2513
		private const string DB = "db_uicamera.db";

		// Token: 0x040009D2 RID: 2514
		private const string FILE = "u.Ui相机.xlsx";

		// Token: 0x040009D3 RID: 2515
		private const string TABLE = "ChildUiCameraMapping";

		// Token: 0x040009D4 RID: 2516
		private const string COMMAND = "select BinData from `ChildUiCameraMapping` where ViewName=?";

		// Token: 0x040009D5 RID: 2517
		private const string KEY_PREFIX = "ChildUiCameraMappingByViewName";

		// Token: 0x040009D6 RID: 2518
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040009D7 RID: 2519
		private static int HandleId;
	}
}
