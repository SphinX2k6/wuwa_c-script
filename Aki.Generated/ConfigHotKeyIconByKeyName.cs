using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000410 RID: 1040
	public class ConfigHotKeyIconByKeyName : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001867 RID: 6247 RVA: 0x000E3CDB File Offset: 0x000E1EDB
		static ConfigHotKeyIconByKeyName()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHotKeyIconByKeyName.CreateStaticDefaultValue), new Action(ConfigHotKeyIconByKeyName.ResetStaticDefaultValue));
		}

		// Token: 0x06001868 RID: 6248 RVA: 0x000E3CFC File Offset: 0x000E1EFC
		public static void CreateStaticDefaultValue()
		{
			ConfigHotKeyIconByKeyName.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHotKeyIconByKeyName.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_uihotkot.db"),
				new ValueTuple<string, object>("文件", "j.界面快捷键.xlsx"),
				new ValueTuple<string, object>("表名", "HotKeyIcon"),
				new ValueTuple<string, object>("语句", "select BinData from `HotKeyIcon` where KeyName=?")
			});
		}

		// Token: 0x06001869 RID: 6249 RVA: 0x000E3D7B File Offset: 0x000E1F7B
		public static void ResetStaticDefaultValue()
		{
			ConfigHotKeyIconByKeyName.LogPair = null;
			ConfigHotKeyIconByKeyName.HandleId = 0;
		}

		// Token: 0x0600186A RID: 6250 RVA: 0x000E3D89 File Offset: 0x000E1F89
		public static void Init()
		{
			ConfigHotKeyIconByKeyName.HandleId = ConfigCommon.InitDataStatement(ConfigHotKeyIconByKeyName.HandleId, "db_uihotkot.db", "select BinData from `HotKeyIcon` where KeyName=?");
		}

		// Token: 0x0600186B RID: 6251 RVA: 0x000E3DA4 File Offset: 0x000E1FA4
		public static HotKeyIcon? GetConfig(string p0KeyName, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHotKeyIconByKeyName.HandleId, ConfigHotKeyIconByKeyName.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("HotKeyIconByKeyName#" + p0KeyName);
				if (configBuffer != null)
				{
					return new HotKeyIcon?(HotKeyIcon.GetRootAsHotKeyIcon(configBuffer));
				}
			}
			ConfigHotKeyIconByKeyName.LogPair.Clear();
			ConfigHotKeyIconByKeyName.LogPair.Add(new ValueTuple<string, object>("KeyName", p0KeyName));
			if (!ConfigCommon.BindString(ConfigHotKeyIconByKeyName.HandleId, 1, p0KeyName, ConfigHotKeyIconByKeyName.LogPair) || ConfigCommon.Step(ConfigHotKeyIconByKeyName.HandleId, true, ConfigHotKeyIconByKeyName.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigHotKeyIconByKeyName.HandleId, ConfigHotKeyIconByKeyName.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHotKeyIconByKeyName.HandleId, 0, ConfigHotKeyIconByKeyName.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigHotKeyIconByKeyName.HandleId, ConfigHotKeyIconByKeyName.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			HotKeyIcon rootAsHotKeyIcon = HotKeyIcon.GetRootAsHotKeyIcon(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("HotKeyIconByKeyName#" + p0KeyName, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigHotKeyIconByKeyName.HandleId, ConfigHotKeyIconByKeyName.LogPair);
			return new HotKeyIcon?(rootAsHotKeyIcon);
		}

		// Token: 0x04001C54 RID: 7252
		private const string DB = "db_uihotkot.db";

		// Token: 0x04001C55 RID: 7253
		private const string FILE = "j.界面快捷键.xlsx";

		// Token: 0x04001C56 RID: 7254
		private const string TABLE = "HotKeyIcon";

		// Token: 0x04001C57 RID: 7255
		private const string COMMAND = "select BinData from `HotKeyIcon` where KeyName=?";

		// Token: 0x04001C58 RID: 7256
		private const string KEY_PREFIX = "HotKeyIconByKeyName";

		// Token: 0x04001C59 RID: 7257
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001C5A RID: 7258
		private static int HandleId;
	}
}
