using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000647 RID: 1607
	public class ConfigOpenAndCloseViewHotKeyByInputControllerType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060025BA RID: 9658 RVA: 0x00132745 File Offset: 0x00130945
		static ConfigOpenAndCloseViewHotKeyByInputControllerType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigOpenAndCloseViewHotKeyByInputControllerType.CreateStaticDefaultValue), new Action(ConfigOpenAndCloseViewHotKeyByInputControllerType.ResetStaticDefaultValue));
		}

		// Token: 0x060025BB RID: 9659 RVA: 0x00132764 File Offset: 0x00130964
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

		// Token: 0x060025BC RID: 9660 RVA: 0x001327E3 File Offset: 0x001309E3
		public static void ResetStaticDefaultValue()
		{
			ConfigOpenAndCloseViewHotKeyByInputControllerType.LogPair = null;
			ConfigOpenAndCloseViewHotKeyByInputControllerType.HandleId = 0;
		}

		// Token: 0x060025BD RID: 9661 RVA: 0x001327F1 File Offset: 0x001309F1
		public static void Init()
		{
			ConfigOpenAndCloseViewHotKeyByInputControllerType.HandleId = ConfigCommon.InitDataStatement(ConfigOpenAndCloseViewHotKeyByInputControllerType.HandleId, "db_input_settings.db", "select BinData from `OpenAndCloseViewHotKey` where InputControllerType=?");
		}

		// Token: 0x060025BE RID: 9662 RVA: 0x0013280C File Offset: 0x00130A0C
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

		// Token: 0x04002BD7 RID: 11223
		private const string DB = "db_input_settings.db";

		// Token: 0x04002BD8 RID: 11224
		private const string FILE = "s.输入配置.xlsx";

		// Token: 0x04002BD9 RID: 11225
		private const string TABLE = "OpenAndCloseViewHotKey";

		// Token: 0x04002BDA RID: 11226
		private const string COMMAND = "select BinData from `OpenAndCloseViewHotKey` where InputControllerType=?";

		// Token: 0x04002BDB RID: 11227
		private const string KEY_PREFIX = "OpenAndCloseViewHotKeyByInputControllerType";

		// Token: 0x04002BDC RID: 11228
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002BDD RID: 11229
		private static int HandleId;
	}
}
