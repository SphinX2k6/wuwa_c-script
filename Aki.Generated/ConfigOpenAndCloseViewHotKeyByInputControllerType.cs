using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200062F RID: 1583
	public class ConfigOpenAndCloseViewHotKeyByInputControllerType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600252A RID: 9514 RVA: 0x0012BCC9 File Offset: 0x00129EC9
		static ConfigOpenAndCloseViewHotKeyByInputControllerType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigOpenAndCloseViewHotKeyByInputControllerType.CreateStaticDefaultValue), new Action(ConfigOpenAndCloseViewHotKeyByInputControllerType.ResetStaticDefaultValue));
		}

		// Token: 0x0600252B RID: 9515 RVA: 0x0012BCE8 File Offset: 0x00129EE8
		public static void CreateStaticDefaultValue()
		{
			ConfigOpenAndCloseViewHotKeyByInputControllerType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigOpenAndCloseViewHotKeyByInputControllerType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_input_settings.db"),
				new ValueTuple<string, object>("文件", "s.输入配置.xlsx"),
				new ValueTuple<string, object>("表名", "OpenAndCloseViewHotKey"),
				new ValueTuple<string, object>("语句", "select BinData from `OpenAndCloseViewHotKey` where InputControllerType=?")
			});
		}

		// Token: 0x0600252C RID: 9516 RVA: 0x0012BD67 File Offset: 0x00129F67
		public static void ResetStaticDefaultValue()
		{
			ConfigOpenAndCloseViewHotKeyByInputControllerType.LogPair = null;
			ConfigOpenAndCloseViewHotKeyByInputControllerType.HandleId = 0;
		}

		// Token: 0x0600252D RID: 9517 RVA: 0x0012BD75 File Offset: 0x00129F75
		public static void Init()
		{
			ConfigOpenAndCloseViewHotKeyByInputControllerType.HandleId = ConfigCommon.InitDataStatement(ConfigOpenAndCloseViewHotKeyByInputControllerType.HandleId, "db_input_settings.db", "select BinData from `OpenAndCloseViewHotKey` where InputControllerType=?");
		}

		// Token: 0x0600252E RID: 9518 RVA: 0x0012BD90 File Offset: 0x00129F90
		[NullableContext(2)]
		public static IReadOnlyList<OpenAndCloseViewHotKey> GetConfigList(int p0InputControllerType, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigOpenAndCloseViewHotKeyByInputControllerType.HandleId, ConfigOpenAndCloseViewHotKeyByInputControllerType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("OpenAndCloseViewHotKeyByInputControllerType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0InputControllerType);
				IReadOnlyList<OpenAndCloseViewHotKey> readOnlyList = (IReadOnlyList<OpenAndCloseViewHotKey>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigOpenAndCloseViewHotKeyByInputControllerType.LogPair.Clear();
			ConfigOpenAndCloseViewHotKeyByInputControllerType.LogPair.Add(new ValueTuple<string, object>("InputControllerType", p0InputControllerType));
			if (!ConfigCommon.BindInt(ConfigOpenAndCloseViewHotKeyByInputControllerType.HandleId, 1, p0InputControllerType, ConfigOpenAndCloseViewHotKeyByInputControllerType.LogPair))
			{
				ConfigCommon.Reset(ConfigOpenAndCloseViewHotKeyByInputControllerType.HandleId, ConfigOpenAndCloseViewHotKeyByInputControllerType.LogPair);
				return null;
			}
			List<OpenAndCloseViewHotKey> list = new List<OpenAndCloseViewHotKey>();
			while (ConfigCommon.Step(ConfigOpenAndCloseViewHotKeyByInputControllerType.HandleId, false, ConfigOpenAndCloseViewHotKeyByInputControllerType.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigOpenAndCloseViewHotKeyByInputControllerType.HandleId, 0, ConfigOpenAndCloseViewHotKeyByInputControllerType.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigOpenAndCloseViewHotKeyByInputControllerType.HandleId, ConfigOpenAndCloseViewHotKeyByInputControllerType.LogPair);
					return null;
				}
				OpenAndCloseViewHotKey rootAsOpenAndCloseViewHotKey = OpenAndCloseViewHotKey.GetRootAsOpenAndCloseViewHotKey(new ByteBuffer(item2));
				list.Add(rootAsOpenAndCloseViewHotKey);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("OpenAndCloseViewHotKeyByInputControllerType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0InputControllerType);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigOpenAndCloseViewHotKeyByInputControllerType.HandleId, ConfigOpenAndCloseViewHotKeyByInputControllerType.LogPair);
			return list;
		}

		// Token: 0x04002B2F RID: 11055
		private const string DB = "db_input_settings.db";

		// Token: 0x04002B30 RID: 11056
		private const string FILE = "s.输入配置.xlsx";

		// Token: 0x04002B31 RID: 11057
		private const string TABLE = "OpenAndCloseViewHotKey";

		// Token: 0x04002B32 RID: 11058
		private const string COMMAND = "select BinData from `OpenAndCloseViewHotKey` where InputControllerType=?";

		// Token: 0x04002B33 RID: 11059
		private const string KEY_PREFIX = "OpenAndCloseViewHotKeyByInputControllerType";

		// Token: 0x04002B34 RID: 11060
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002B35 RID: 11061
		private static int HandleId;
	}
}
