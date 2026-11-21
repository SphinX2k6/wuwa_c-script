using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200018C RID: 396
	public class ConfigCombinationActionByActionType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000949 RID: 2377 RVA: 0x000917B5 File Offset: 0x0008F9B5
		static ConfigCombinationActionByActionType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCombinationActionByActionType.CreateStaticDefaultValue), new Action(ConfigCombinationActionByActionType.ResetStaticDefaultValue));
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x000917D4 File Offset: 0x0008F9D4
		public static void CreateStaticDefaultValue()
		{
			ConfigCombinationActionByActionType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCombinationActionByActionType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_input_settings.db"),
				new ValueTuple<string, object>("文件", "s.输入配置.xlsx"),
				new ValueTuple<string, object>("表名", "CombinationAction"),
				new ValueTuple<string, object>("语句", "select BinData from `CombinationAction` where ActionType=?")
			});
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x00091853 File Offset: 0x0008FA53
		public static void ResetStaticDefaultValue()
		{
			ConfigCombinationActionByActionType.LogPair = null;
			ConfigCombinationActionByActionType.HandleId = 0;
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x00091861 File Offset: 0x0008FA61
		public static void Init()
		{
			ConfigCombinationActionByActionType.HandleId = ConfigCommon.InitDataStatement(ConfigCombinationActionByActionType.HandleId, "db_input_settings.db", "select BinData from `CombinationAction` where ActionType=?");
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x0009187C File Offset: 0x0008FA7C
		[NullableContext(2)]
		public static IReadOnlyList<CombinationAction> GetConfigList(int p0ActionType, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCombinationActionByActionType.HandleId, ConfigCombinationActionByActionType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CombinationActionByActionType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActionType);
				IReadOnlyList<CombinationAction> readOnlyList = (IReadOnlyList<CombinationAction>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigCombinationActionByActionType.LogPair.Clear();
			ConfigCombinationActionByActionType.LogPair.Add(new ValueTuple<string, object>("ActionType", p0ActionType));
			if (!ConfigCommon.BindInt(ConfigCombinationActionByActionType.HandleId, 1, p0ActionType, ConfigCombinationActionByActionType.LogPair))
			{
				ConfigCommon.Reset(ConfigCombinationActionByActionType.HandleId, ConfigCombinationActionByActionType.LogPair);
				return null;
			}
			List<CombinationAction> list = new List<CombinationAction>();
			while (ConfigCommon.Step(ConfigCombinationActionByActionType.HandleId, false, ConfigCombinationActionByActionType.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCombinationActionByActionType.HandleId, 0, ConfigCombinationActionByActionType.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigCombinationActionByActionType.HandleId, ConfigCombinationActionByActionType.LogPair);
					return null;
				}
				CombinationAction rootAsCombinationAction = CombinationAction.GetRootAsCombinationAction(new ByteBuffer(item2));
				list.Add(rootAsCombinationAction);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CombinationActionByActionType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActionType);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigCombinationActionByActionType.HandleId, ConfigCombinationActionByActionType.LogPair);
			return list;
		}

		// Token: 0x04000AB8 RID: 2744
		private const string DB = "db_input_settings.db";

		// Token: 0x04000AB9 RID: 2745
		private const string FILE = "s.输入配置.xlsx";

		// Token: 0x04000ABA RID: 2746
		private const string TABLE = "CombinationAction";

		// Token: 0x04000ABB RID: 2747
		private const string COMMAND = "select BinData from `CombinationAction` where ActionType=?";

		// Token: 0x04000ABC RID: 2748
		private const string KEY_PREFIX = "CombinationActionByActionType";

		// Token: 0x04000ABD RID: 2749
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000ABE RID: 2750
		private static int HandleId;
	}
}
