using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200018A RID: 394
	public class ConfigCommonTouchUiEditByPanelResId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600093D RID: 2365 RVA: 0x0008DB14 File Offset: 0x0008BD14
		static ConfigCommonTouchUiEditByPanelResId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCommonTouchUiEditByPanelResId.CreateStaticDefaultValue), new Action(ConfigCommonTouchUiEditByPanelResId.ResetStaticDefaultValue));
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x0008DB34 File Offset: 0x0008BD34
		public static void CreateStaticDefaultValue()
		{
			ConfigCommonTouchUiEditByPanelResId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCommonTouchUiEditByPanelResId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_commontouchuiedit.db"),
				new ValueTuple<string, object>("文件", "y.移动端活动玩法主界面键位配置.xlsx"),
				new ValueTuple<string, object>("表名", "CommonTouchUiEdit"),
				new ValueTuple<string, object>("语句", "select BinData from `CommonTouchUiEdit` where PanelResId=?")
			});
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x0008DBB3 File Offset: 0x0008BDB3
		public static void ResetStaticDefaultValue()
		{
			ConfigCommonTouchUiEditByPanelResId.LogPair = null;
			ConfigCommonTouchUiEditByPanelResId.HandleId = 0;
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x0008DBC1 File Offset: 0x0008BDC1
		public static void Init()
		{
			ConfigCommonTouchUiEditByPanelResId.HandleId = ConfigCommon.InitDataStatement(ConfigCommonTouchUiEditByPanelResId.HandleId, "db_commontouchuiedit.db", "select BinData from `CommonTouchUiEdit` where PanelResId=?");
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x0008DBDC File Offset: 0x0008BDDC
		public static CommonTouchUiEdit? GetConfig(string p0PanelResId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCommonTouchUiEditByPanelResId.HandleId, ConfigCommonTouchUiEditByPanelResId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("CommonTouchUiEditByPanelResId#" + p0PanelResId);
				if (configBuffer != null)
				{
					return new CommonTouchUiEdit?(CommonTouchUiEdit.GetRootAsCommonTouchUiEdit(configBuffer));
				}
			}
			ConfigCommonTouchUiEditByPanelResId.LogPair.Clear();
			ConfigCommonTouchUiEditByPanelResId.LogPair.Add(new ValueTuple<string, object>("PanelResId", p0PanelResId));
			if (!ConfigCommon.BindString(ConfigCommonTouchUiEditByPanelResId.HandleId, 1, p0PanelResId, ConfigCommonTouchUiEditByPanelResId.LogPair) || ConfigCommon.Step(ConfigCommonTouchUiEditByPanelResId.HandleId, true, ConfigCommonTouchUiEditByPanelResId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCommonTouchUiEditByPanelResId.HandleId, ConfigCommonTouchUiEditByPanelResId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCommonTouchUiEditByPanelResId.HandleId, 0, ConfigCommonTouchUiEditByPanelResId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCommonTouchUiEditByPanelResId.HandleId, ConfigCommonTouchUiEditByPanelResId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			CommonTouchUiEdit rootAsCommonTouchUiEdit = CommonTouchUiEdit.GetRootAsCommonTouchUiEdit(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("CommonTouchUiEditByPanelResId#" + p0PanelResId, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCommonTouchUiEditByPanelResId.HandleId, ConfigCommonTouchUiEditByPanelResId.LogPair);
			return new CommonTouchUiEdit?(rootAsCommonTouchUiEdit);
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x0008DD08 File Offset: 0x0008BF08
		[return: Nullable(2)]
		public static IReadOnlyList<CommonTouchUiEdit> GetConfigList(string p0PanelResId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCommonTouchUiEditByPanelResId.HandleId, ConfigCommonTouchUiEditByPanelResId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<CommonTouchUiEdit> readOnlyList = (IReadOnlyList<CommonTouchUiEdit>)ConfigCommon.GetConfig("CommonTouchUiEditByPanelResId#" + p0PanelResId);
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigCommonTouchUiEditByPanelResId.LogPair.Clear();
			ConfigCommonTouchUiEditByPanelResId.LogPair.Add(new ValueTuple<string, object>("PanelResId", p0PanelResId));
			if (!ConfigCommon.BindString(ConfigCommonTouchUiEditByPanelResId.HandleId, 1, p0PanelResId, ConfigCommonTouchUiEditByPanelResId.LogPair))
			{
				ConfigCommon.Reset(ConfigCommonTouchUiEditByPanelResId.HandleId, ConfigCommonTouchUiEditByPanelResId.LogPair);
				return null;
			}
			List<CommonTouchUiEdit> list = new List<CommonTouchUiEdit>();
			while (ConfigCommon.Step(ConfigCommonTouchUiEditByPanelResId.HandleId, false, ConfigCommonTouchUiEditByPanelResId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCommonTouchUiEditByPanelResId.HandleId, 0, ConfigCommonTouchUiEditByPanelResId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigCommonTouchUiEditByPanelResId.HandleId, ConfigCommonTouchUiEditByPanelResId.LogPair);
					return null;
				}
				CommonTouchUiEdit rootAsCommonTouchUiEdit = CommonTouchUiEdit.GetRootAsCommonTouchUiEdit(new ByteBuffer(item2));
				list.Add(rootAsCommonTouchUiEdit);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("CommonTouchUiEditByPanelResId#" + p0PanelResId, list, list.Count);
			}
			ConfigCommon.Reset(ConfigCommonTouchUiEditByPanelResId.HandleId, ConfigCommonTouchUiEditByPanelResId.LogPair);
			return list;
		}

		// Token: 0x04000AAA RID: 2730
		private const string DB = "db_commontouchuiedit.db";

		// Token: 0x04000AAB RID: 2731
		private const string FILE = "y.移动端活动玩法主界面键位配置.xlsx";

		// Token: 0x04000AAC RID: 2732
		private const string TABLE = "CommonTouchUiEdit";

		// Token: 0x04000AAD RID: 2733
		private const string COMMAND = "select BinData from `CommonTouchUiEdit` where PanelResId=?";

		// Token: 0x04000AAE RID: 2734
		private const string KEY_PREFIX = "CommonTouchUiEditByPanelResId";

		// Token: 0x04000AAF RID: 2735
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000AB0 RID: 2736
		private static int HandleId;
	}
}
