using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A63 RID: 2659
	public class ConfigUiCameraMappingByViewName : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003E66 RID: 15974 RVA: 0x001BACC4 File Offset: 0x001B8EC4
		static ConfigUiCameraMappingByViewName()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigUiCameraMappingByViewName.CreateStaticDefaultValue), new Action(ConfigUiCameraMappingByViewName.ResetStaticDefaultValue));
		}

		// Token: 0x06003E67 RID: 15975 RVA: 0x001BACE4 File Offset: 0x001B8EE4
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

		// Token: 0x06003E68 RID: 15976 RVA: 0x001BAD63 File Offset: 0x001B8F63
		public static void ResetStaticDefaultValue()
		{
			ConfigUiCameraMappingByViewName.LogPair = null;
			ConfigUiCameraMappingByViewName.HandleId = 0;
		}

		// Token: 0x06003E69 RID: 15977 RVA: 0x001BAD71 File Offset: 0x001B8F71
		public static void Init()
		{
			ConfigUiCameraMappingByViewName.HandleId = ConfigCommon.InitDataStatement(ConfigUiCameraMappingByViewName.HandleId, "db_uicamera.db", "select BinData from `UiCameraMapping` where ViewName=?");
		}

		// Token: 0x06003E6A RID: 15978 RVA: 0x001BAD8C File Offset: 0x001B8F8C
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

		// Token: 0x0400489B RID: 18587
		private const string DB = "db_uicamera.db";

		// Token: 0x0400489C RID: 18588
		private const string FILE = "u.Ui相机.xlsx";

		// Token: 0x0400489D RID: 18589
		private const string TABLE = "UiCameraMapping";

		// Token: 0x0400489E RID: 18590
		private const string COMMAND = "select BinData from `UiCameraMapping` where ViewName=?";

		// Token: 0x0400489F RID: 18591
		private const string KEY_PREFIX = "UiCameraMappingByViewName";

		// Token: 0x040048A0 RID: 18592
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040048A1 RID: 18593
		private static int HandleId;
	}
}
