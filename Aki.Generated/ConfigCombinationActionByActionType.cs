using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200017A RID: 378
	public class ConfigCombinationActionByActionType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060008DD RID: 2269 RVA: 0x0008B87D File Offset: 0x00089A7D
		static ConfigCombinationActionByActionType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCombinationActionByActionType.CreateStaticDefaultValue), new Action(ConfigCombinationActionByActionType.ResetStaticDefaultValue));
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x0008B89C File Offset: 0x00089A9C
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

		// Token: 0x060008DF RID: 2271 RVA: 0x0008B91B File Offset: 0x00089B1B
		public static void ResetStaticDefaultValue()
		{
			ConfigCombinationActionByActionType.LogPair = null;
			ConfigCombinationActionByActionType.HandleId = 0;
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x0008B929 File Offset: 0x00089B29
		public static void Init()
		{
			ConfigCombinationActionByActionType.HandleId = ConfigCommon.InitDataStatement(ConfigCombinationActionByActionType.HandleId, "db_input_settings.db", "select BinData from `CombinationAction` where ActionType=?");
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x0008B944 File Offset: 0x00089B44
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

		// Token: 0x04000A3A RID: 2618
		private const string DB = "db_input_settings.db";

		// Token: 0x04000A3B RID: 2619
		private const string FILE = "s.输入配置.xlsx";

		// Token: 0x04000A3C RID: 2620
		private const string TABLE = "CombinationAction";

		// Token: 0x04000A3D RID: 2621
		private const string COMMAND = "select BinData from `CombinationAction` where ActionType=?";

		// Token: 0x04000A3E RID: 2622
		private const string KEY_PREFIX = "CombinationActionByActionType";

		// Token: 0x04000A3F RID: 2623
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000A40 RID: 2624
		private static int HandleId;
	}
}
