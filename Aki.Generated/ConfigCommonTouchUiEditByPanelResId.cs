using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200019C RID: 412
	public class ConfigCommonTouchUiEditByPanelResId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060009A9 RID: 2473 RVA: 0x00093A4C File Offset: 0x00091C4C
		static ConfigCommonTouchUiEditByPanelResId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCommonTouchUiEditByPanelResId.CreateStaticDefaultValue), new Action(ConfigCommonTouchUiEditByPanelResId.ResetStaticDefaultValue));
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x00093A6C File Offset: 0x00091C6C
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

		// Token: 0x060009AB RID: 2475 RVA: 0x00093AEB File Offset: 0x00091CEB
		public static void ResetStaticDefaultValue()
		{
			ConfigCommonTouchUiEditByPanelResId.LogPair = null;
			ConfigCommonTouchUiEditByPanelResId.HandleId = 0;
		}

		// Token: 0x060009AC RID: 2476 RVA: 0x00093AF9 File Offset: 0x00091CF9
		public static void Init()
		{
			ConfigCommonTouchUiEditByPanelResId.HandleId = ConfigCommon.InitDataStatement(ConfigCommonTouchUiEditByPanelResId.HandleId, "db_commontouchuiedit.db", "select BinData from `CommonTouchUiEdit` where PanelResId=?");
		}

		// Token: 0x060009AD RID: 2477 RVA: 0x00093B14 File Offset: 0x00091D14
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

		// Token: 0x060009AE RID: 2478 RVA: 0x00093C40 File Offset: 0x00091E40
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

		// Token: 0x04000B28 RID: 2856
		private const string DB = "db_commontouchuiedit.db";

		// Token: 0x04000B29 RID: 2857
		private const string FILE = "y.移动端活动玩法主界面键位配置.xlsx";

		// Token: 0x04000B2A RID: 2858
		private const string TABLE = "CommonTouchUiEdit";

		// Token: 0x04000B2B RID: 2859
		private const string COMMAND = "select BinData from `CommonTouchUiEdit` where PanelResId=?";

		// Token: 0x04000B2C RID: 2860
		private const string KEY_PREFIX = "CommonTouchUiEditByPanelResId";

		// Token: 0x04000B2D RID: 2861
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000B2E RID: 2862
		private static int HandleId;
	}
}
