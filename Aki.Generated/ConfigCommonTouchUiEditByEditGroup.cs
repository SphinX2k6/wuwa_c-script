using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200019A RID: 410
	public class ConfigCommonTouchUiEditByEditGroup : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600099D RID: 2461 RVA: 0x000935CC File Offset: 0x000917CC
		static ConfigCommonTouchUiEditByEditGroup()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCommonTouchUiEditByEditGroup.CreateStaticDefaultValue), new Action(ConfigCommonTouchUiEditByEditGroup.ResetStaticDefaultValue));
		}

		// Token: 0x0600099E RID: 2462 RVA: 0x000935EC File Offset: 0x000917EC
		public static void CreateStaticDefaultValue()
		{
			ConfigCommonTouchUiEditByEditGroup.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCommonTouchUiEditByEditGroup.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_commontouchuiedit.db"),
				new ValueTuple<string, object>("文件", "y.移动端活动玩法主界面键位配置.xlsx"),
				new ValueTuple<string, object>("表名", "CommonTouchUiEdit"),
				new ValueTuple<string, object>("语句", "select BinData from `CommonTouchUiEdit` where EditGroup=?")
			});
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x0009366B File Offset: 0x0009186B
		public static void ResetStaticDefaultValue()
		{
			ConfigCommonTouchUiEditByEditGroup.LogPair = null;
			ConfigCommonTouchUiEditByEditGroup.HandleId = 0;
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x00093679 File Offset: 0x00091879
		public static void Init()
		{
			ConfigCommonTouchUiEditByEditGroup.HandleId = ConfigCommon.InitDataStatement(ConfigCommonTouchUiEditByEditGroup.HandleId, "db_commontouchuiedit.db", "select BinData from `CommonTouchUiEdit` where EditGroup=?");
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x00093694 File Offset: 0x00091894
		[NullableContext(2)]
		public static IReadOnlyList<CommonTouchUiEdit> GetConfigList(int p0EditGroup, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCommonTouchUiEditByEditGroup.HandleId, ConfigCommonTouchUiEditByEditGroup.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CommonTouchUiEditByEditGroup");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0EditGroup);
				IReadOnlyList<CommonTouchUiEdit> readOnlyList = (IReadOnlyList<CommonTouchUiEdit>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigCommonTouchUiEditByEditGroup.LogPair.Clear();
			ConfigCommonTouchUiEditByEditGroup.LogPair.Add(new ValueTuple<string, object>("EditGroup", p0EditGroup));
			if (!ConfigCommon.BindInt(ConfigCommonTouchUiEditByEditGroup.HandleId, 1, p0EditGroup, ConfigCommonTouchUiEditByEditGroup.LogPair))
			{
				ConfigCommon.Reset(ConfigCommonTouchUiEditByEditGroup.HandleId, ConfigCommonTouchUiEditByEditGroup.LogPair);
				return null;
			}
			List<CommonTouchUiEdit> list = new List<CommonTouchUiEdit>();
			while (ConfigCommon.Step(ConfigCommonTouchUiEditByEditGroup.HandleId, false, ConfigCommonTouchUiEditByEditGroup.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCommonTouchUiEditByEditGroup.HandleId, 0, ConfigCommonTouchUiEditByEditGroup.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigCommonTouchUiEditByEditGroup.HandleId, ConfigCommonTouchUiEditByEditGroup.LogPair);
					return null;
				}
				CommonTouchUiEdit rootAsCommonTouchUiEdit = CommonTouchUiEdit.GetRootAsCommonTouchUiEdit(new ByteBuffer(item2));
				list.Add(rootAsCommonTouchUiEdit);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CommonTouchUiEditByEditGroup");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0EditGroup);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigCommonTouchUiEditByEditGroup.HandleId, ConfigCommonTouchUiEditByEditGroup.LogPair);
			return list;
		}

		// Token: 0x04000B1A RID: 2842
		private const string DB = "db_commontouchuiedit.db";

		// Token: 0x04000B1B RID: 2843
		private const string FILE = "y.移动端活动玩法主界面键位配置.xlsx";

		// Token: 0x04000B1C RID: 2844
		private const string TABLE = "CommonTouchUiEdit";

		// Token: 0x04000B1D RID: 2845
		private const string COMMAND = "select BinData from `CommonTouchUiEdit` where EditGroup=?";

		// Token: 0x04000B1E RID: 2846
		private const string KEY_PREFIX = "CommonTouchUiEditByEditGroup";

		// Token: 0x04000B1F RID: 2847
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000B20 RID: 2848
		private static int HandleId;
	}
}
