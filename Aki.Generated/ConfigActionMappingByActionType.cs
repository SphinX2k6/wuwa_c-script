using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200003D RID: 61
	public class ConfigActionMappingByActionType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600016E RID: 366 RVA: 0x00061CB5 File Offset: 0x0005FEB5
		static ConfigActionMappingByActionType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigActionMappingByActionType.CreateStaticDefaultValue), new Action(ConfigActionMappingByActionType.ResetStaticDefaultValue));
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00061CD4 File Offset: 0x0005FED4
		public static void CreateStaticDefaultValue()
		{
			ConfigActionMappingByActionType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigActionMappingByActionType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_input_settings.db"),
				new ValueTuple<string, object>("文件", "s.输入配置.xlsx"),
				new ValueTuple<string, object>("表名", "ActionMapping"),
				new ValueTuple<string, object>("语句", "select BinData from `ActionMapping` where ActionType=?")
			});
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00061D53 File Offset: 0x0005FF53
		public static void ResetStaticDefaultValue()
		{
			ConfigActionMappingByActionType.LogPair = null;
			ConfigActionMappingByActionType.HandleId = 0;
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00061D61 File Offset: 0x0005FF61
		public static void Init()
		{
			ConfigActionMappingByActionType.HandleId = ConfigCommon.InitDataStatement(ConfigActionMappingByActionType.HandleId, "db_input_settings.db", "select BinData from `ActionMapping` where ActionType=?");
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00061D7C File Offset: 0x0005FF7C
		[NullableContext(2)]
		public static IReadOnlyList<ActionMapping> GetConfigList(int p0ActionType, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigActionMappingByActionType.HandleId, ConfigActionMappingByActionType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ActionMappingByActionType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActionType);
				IReadOnlyList<ActionMapping> readOnlyList = (IReadOnlyList<ActionMapping>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigActionMappingByActionType.LogPair.Clear();
			ConfigActionMappingByActionType.LogPair.Add(new ValueTuple<string, object>("ActionType", p0ActionType));
			if (!ConfigCommon.BindInt(ConfigActionMappingByActionType.HandleId, 1, p0ActionType, ConfigActionMappingByActionType.LogPair))
			{
				ConfigCommon.Reset(ConfigActionMappingByActionType.HandleId, ConfigActionMappingByActionType.LogPair);
				return null;
			}
			List<ActionMapping> list = new List<ActionMapping>();
			while (ConfigCommon.Step(ConfigActionMappingByActionType.HandleId, false, ConfigActionMappingByActionType.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigActionMappingByActionType.HandleId, 0, ConfigActionMappingByActionType.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigActionMappingByActionType.HandleId, ConfigActionMappingByActionType.LogPair);
					return null;
				}
				ActionMapping rootAsActionMapping = ActionMapping.GetRootAsActionMapping(new ByteBuffer(item2));
				list.Add(rootAsActionMapping);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ActionMappingByActionType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActionType);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigActionMappingByActionType.HandleId, ConfigActionMappingByActionType.LogPair);
			return list;
		}

		// Token: 0x0400018F RID: 399
		private const string DB = "db_input_settings.db";

		// Token: 0x04000190 RID: 400
		private const string FILE = "s.输入配置.xlsx";

		// Token: 0x04000191 RID: 401
		private const string TABLE = "ActionMapping";

		// Token: 0x04000192 RID: 402
		private const string COMMAND = "select BinData from `ActionMapping` where ActionType=?";

		// Token: 0x04000193 RID: 403
		private const string KEY_PREFIX = "ActionMappingByActionType";

		// Token: 0x04000194 RID: 404
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000195 RID: 405
		private static int HandleId;
	}
}
