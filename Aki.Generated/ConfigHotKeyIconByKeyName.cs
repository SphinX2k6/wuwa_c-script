using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000426 RID: 1062
	public class ConfigHotKeyIconByKeyName : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060018EB RID: 6379 RVA: 0x000EA42F File Offset: 0x000E862F
		static ConfigHotKeyIconByKeyName()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHotKeyIconByKeyName.CreateStaticDefaultValue), new Action(ConfigHotKeyIconByKeyName.ResetStaticDefaultValue));
		}

		// Token: 0x060018EC RID: 6380 RVA: 0x000EA450 File Offset: 0x000E8650
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

		// Token: 0x060018ED RID: 6381 RVA: 0x000EA4CF File Offset: 0x000E86CF
		public static void ResetStaticDefaultValue()
		{
			ConfigHotKeyIconByKeyName.LogPair = null;
			ConfigHotKeyIconByKeyName.HandleId = 0;
		}

		// Token: 0x060018EE RID: 6382 RVA: 0x000EA4DD File Offset: 0x000E86DD
		public static void Init()
		{
			ConfigHotKeyIconByKeyName.HandleId = ConfigCommon.InitDataStatement(ConfigHotKeyIconByKeyName.HandleId, "db_uihotkot.db", "select BinData from `HotKeyIcon` where KeyName=?");
		}

		// Token: 0x060018EF RID: 6383 RVA: 0x000EA4F8 File Offset: 0x000E86F8
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

		// Token: 0x04001CEE RID: 7406
		private const string DB = "db_uihotkot.db";

		// Token: 0x04001CEF RID: 7407
		private const string FILE = "j.界面快捷键.xlsx";

		// Token: 0x04001CF0 RID: 7408
		private const string TABLE = "HotKeyIcon";

		// Token: 0x04001CF1 RID: 7409
		private const string COMMAND = "select BinData from `HotKeyIcon` where KeyName=?";

		// Token: 0x04001CF2 RID: 7410
		private const string KEY_PREFIX = "HotKeyIconByKeyName";

		// Token: 0x04001CF3 RID: 7411
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001CF4 RID: 7412
		private static int HandleId;
	}
}
