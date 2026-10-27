using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000412 RID: 1042
	public class ConfigHotKeyTextByTextId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001873 RID: 6259 RVA: 0x000E411C File Offset: 0x000E231C
		static ConfigHotKeyTextByTextId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHotKeyTextByTextId.CreateStaticDefaultValue), new Action(ConfigHotKeyTextByTextId.ResetStaticDefaultValue));
		}

		// Token: 0x06001874 RID: 6260 RVA: 0x000E413C File Offset: 0x000E233C
		public static void CreateStaticDefaultValue()
		{
			ConfigHotKeyTextByTextId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHotKeyTextByTextId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_uihotkot.db"),
				new ValueTuple<string, object>("文件", "j.界面快捷键.xlsx"),
				new ValueTuple<string, object>("表名", "HotKeyText"),
				new ValueTuple<string, object>("语句", "select BinData from `HotKeyText` where TextId=?")
			});
		}

		// Token: 0x06001875 RID: 6261 RVA: 0x000E41BB File Offset: 0x000E23BB
		public static void ResetStaticDefaultValue()
		{
			ConfigHotKeyTextByTextId.LogPair = null;
			ConfigHotKeyTextByTextId.HandleId = 0;
		}

		// Token: 0x06001876 RID: 6262 RVA: 0x000E41C9 File Offset: 0x000E23C9
		public static void Init()
		{
			ConfigHotKeyTextByTextId.HandleId = ConfigCommon.InitDataStatement(ConfigHotKeyTextByTextId.HandleId, "db_uihotkot.db", "select BinData from `HotKeyText` where TextId=?");
		}

		// Token: 0x06001877 RID: 6263 RVA: 0x000E41E4 File Offset: 0x000E23E4
		public static HotKeyText? GetConfig(string p0TextId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHotKeyTextByTextId.HandleId, ConfigHotKeyTextByTextId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("HotKeyTextByTextId#" + p0TextId);
				if (configBuffer != null)
				{
					return new HotKeyText?(HotKeyText.GetRootAsHotKeyText(configBuffer));
				}
			}
			ConfigHotKeyTextByTextId.LogPair.Clear();
			ConfigHotKeyTextByTextId.LogPair.Add(new ValueTuple<string, object>("TextId", p0TextId));
			if (!ConfigCommon.BindString(ConfigHotKeyTextByTextId.HandleId, 1, p0TextId, ConfigHotKeyTextByTextId.LogPair) || ConfigCommon.Step(ConfigHotKeyTextByTextId.HandleId, true, ConfigHotKeyTextByTextId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigHotKeyTextByTextId.HandleId, ConfigHotKeyTextByTextId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHotKeyTextByTextId.HandleId, 0, ConfigHotKeyTextByTextId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigHotKeyTextByTextId.HandleId, ConfigHotKeyTextByTextId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			HotKeyText rootAsHotKeyText = HotKeyText.GetRootAsHotKeyText(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("HotKeyTextByTextId#" + p0TextId, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigHotKeyTextByTextId.HandleId, ConfigHotKeyTextByTextId.LogPair);
			return new HotKeyText?(rootAsHotKeyText);
		}

		// Token: 0x04001C62 RID: 7266
		private const string DB = "db_uihotkot.db";

		// Token: 0x04001C63 RID: 7267
		private const string FILE = "j.界面快捷键.xlsx";

		// Token: 0x04001C64 RID: 7268
		private const string TABLE = "HotKeyText";

		// Token: 0x04001C65 RID: 7269
		private const string COMMAND = "select BinData from `HotKeyText` where TextId=?";

		// Token: 0x04001C66 RID: 7270
		private const string KEY_PREFIX = "HotKeyTextByTextId";

		// Token: 0x04001C67 RID: 7271
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001C68 RID: 7272
		private static int HandleId;
	}
}
