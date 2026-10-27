using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000411 RID: 1041
	public class ConfigHotKeyMapById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600186D RID: 6253 RVA: 0x000E3ED5 File Offset: 0x000E20D5
		static ConfigHotKeyMapById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHotKeyMapById.CreateStaticDefaultValue), new Action(ConfigHotKeyMapById.ResetStaticDefaultValue));
		}

		// Token: 0x0600186E RID: 6254 RVA: 0x000E3EF4 File Offset: 0x000E20F4
		public static void CreateStaticDefaultValue()
		{
			ConfigHotKeyMapById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHotKeyMapById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_uihotkot.db"),
				new ValueTuple<string, object>("文件", "j.界面快捷键.xlsx"),
				new ValueTuple<string, object>("表名", "HotKeyMap"),
				new ValueTuple<string, object>("语句", "select BinData from `HotKeyMap` where Id=?")
			});
		}

		// Token: 0x0600186F RID: 6255 RVA: 0x000E3F73 File Offset: 0x000E2173
		public static void ResetStaticDefaultValue()
		{
			ConfigHotKeyMapById.LogPair = null;
			ConfigHotKeyMapById.HandleId = 0;
		}

		// Token: 0x06001870 RID: 6256 RVA: 0x000E3F81 File Offset: 0x000E2181
		public static void Init()
		{
			ConfigHotKeyMapById.HandleId = ConfigCommon.InitDataStatement(ConfigHotKeyMapById.HandleId, "db_uihotkot.db", "select BinData from `HotKeyMap` where Id=?");
		}

		// Token: 0x06001871 RID: 6257 RVA: 0x000E3F9C File Offset: 0x000E219C
		public static HotKeyMap? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHotKeyMapById.HandleId, ConfigHotKeyMapById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HotKeyMapById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new HotKeyMap?(HotKeyMap.GetRootAsHotKeyMap(configBuffer));
				}
			}
			ConfigHotKeyMapById.LogPair.Clear();
			ConfigHotKeyMapById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigHotKeyMapById.HandleId, 1, p0Id, ConfigHotKeyMapById.LogPair) || ConfigCommon.Step(ConfigHotKeyMapById.HandleId, true, ConfigHotKeyMapById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigHotKeyMapById.HandleId, ConfigHotKeyMapById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHotKeyMapById.HandleId, 0, ConfigHotKeyMapById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigHotKeyMapById.HandleId, ConfigHotKeyMapById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			HotKeyMap rootAsHotKeyMap = HotKeyMap.GetRootAsHotKeyMap(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HotKeyMapById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigHotKeyMapById.HandleId, ConfigHotKeyMapById.LogPair);
			return new HotKeyMap?(rootAsHotKeyMap);
		}

		// Token: 0x04001C5B RID: 7259
		private const string DB = "db_uihotkot.db";

		// Token: 0x04001C5C RID: 7260
		private const string FILE = "j.界面快捷键.xlsx";

		// Token: 0x04001C5D RID: 7261
		private const string TABLE = "HotKeyMap";

		// Token: 0x04001C5E RID: 7262
		private const string COMMAND = "select BinData from `HotKeyMap` where Id=?";

		// Token: 0x04001C5F RID: 7263
		private const string KEY_PREFIX = "HotKeyMapById";

		// Token: 0x04001C60 RID: 7264
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001C61 RID: 7265
		private static int HandleId;
	}
}
