using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000427 RID: 1063
	public class ConfigHotKeyMapById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060018F1 RID: 6385 RVA: 0x000EA629 File Offset: 0x000E8829
		static ConfigHotKeyMapById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHotKeyMapById.CreateStaticDefaultValue), new Action(ConfigHotKeyMapById.ResetStaticDefaultValue));
		}

		// Token: 0x060018F2 RID: 6386 RVA: 0x000EA648 File Offset: 0x000E8848
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

		// Token: 0x060018F3 RID: 6387 RVA: 0x000EA6C7 File Offset: 0x000E88C7
		public static void ResetStaticDefaultValue()
		{
			ConfigHotKeyMapById.LogPair = null;
			ConfigHotKeyMapById.HandleId = 0;
		}

		// Token: 0x060018F4 RID: 6388 RVA: 0x000EA6D5 File Offset: 0x000E88D5
		public static void Init()
		{
			ConfigHotKeyMapById.HandleId = ConfigCommon.InitDataStatement(ConfigHotKeyMapById.HandleId, "db_uihotkot.db", "select BinData from `HotKeyMap` where Id=?");
		}

		// Token: 0x060018F5 RID: 6389 RVA: 0x000EA6F0 File Offset: 0x000E88F0
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

		// Token: 0x04001CF5 RID: 7413
		private const string DB = "db_uihotkot.db";

		// Token: 0x04001CF6 RID: 7414
		private const string FILE = "j.界面快捷键.xlsx";

		// Token: 0x04001CF7 RID: 7415
		private const string TABLE = "HotKeyMap";

		// Token: 0x04001CF8 RID: 7416
		private const string COMMAND = "select BinData from `HotKeyMap` where Id=?";

		// Token: 0x04001CF9 RID: 7417
		private const string KEY_PREFIX = "HotKeyMapById";

		// Token: 0x04001CFA RID: 7418
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001CFB RID: 7419
		private static int HandleId;
	}
}
