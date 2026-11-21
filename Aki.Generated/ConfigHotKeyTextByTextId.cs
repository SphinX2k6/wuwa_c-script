using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000428 RID: 1064
	public class ConfigHotKeyTextByTextId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060018F7 RID: 6391 RVA: 0x000EA870 File Offset: 0x000E8A70
		static ConfigHotKeyTextByTextId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHotKeyTextByTextId.CreateStaticDefaultValue), new Action(ConfigHotKeyTextByTextId.ResetStaticDefaultValue));
		}

		// Token: 0x060018F8 RID: 6392 RVA: 0x000EA890 File Offset: 0x000E8A90
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

		// Token: 0x060018F9 RID: 6393 RVA: 0x000EA90F File Offset: 0x000E8B0F
		public static void ResetStaticDefaultValue()
		{
			ConfigHotKeyTextByTextId.LogPair = null;
			ConfigHotKeyTextByTextId.HandleId = 0;
		}

		// Token: 0x060018FA RID: 6394 RVA: 0x000EA91D File Offset: 0x000E8B1D
		public static void Init()
		{
			ConfigHotKeyTextByTextId.HandleId = ConfigCommon.InitDataStatement(ConfigHotKeyTextByTextId.HandleId, "db_uihotkot.db", "select BinData from `HotKeyText` where TextId=?");
		}

		// Token: 0x060018FB RID: 6395 RVA: 0x000EA938 File Offset: 0x000E8B38
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

		// Token: 0x04001CFC RID: 7420
		private const string DB = "db_uihotkot.db";

		// Token: 0x04001CFD RID: 7421
		private const string FILE = "j.界面快捷键.xlsx";

		// Token: 0x04001CFE RID: 7422
		private const string TABLE = "HotKeyText";

		// Token: 0x04001CFF RID: 7423
		private const string COMMAND = "select BinData from `HotKeyText` where TextId=?";

		// Token: 0x04001D00 RID: 7424
		private const string KEY_PREFIX = "HotKeyTextByTextId";

		// Token: 0x04001D01 RID: 7425
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001D02 RID: 7426
		private static int HandleId;
	}
}
