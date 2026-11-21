using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200042A RID: 1066
	public class ConfigHotKeyViewById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001903 RID: 6403 RVA: 0x000EACB0 File Offset: 0x000E8EB0
		static ConfigHotKeyViewById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHotKeyViewById.CreateStaticDefaultValue), new Action(ConfigHotKeyViewById.ResetStaticDefaultValue));
		}

		// Token: 0x06001904 RID: 6404 RVA: 0x000EACD0 File Offset: 0x000E8ED0
		public static void CreateStaticDefaultValue()
		{
			ConfigHotKeyViewById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHotKeyViewById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_uihotkot.db"),
				new ValueTuple<string, object>("文件", "j.界面快捷键.xlsx"),
				new ValueTuple<string, object>("表名", "HotKeyView"),
				new ValueTuple<string, object>("语句", "select BinData from `HotKeyView` where Id=?")
			});
		}

		// Token: 0x06001905 RID: 6405 RVA: 0x000EAD4F File Offset: 0x000E8F4F
		public static void ResetStaticDefaultValue()
		{
			ConfigHotKeyViewById.LogPair = null;
			ConfigHotKeyViewById.HandleId = 0;
		}

		// Token: 0x06001906 RID: 6406 RVA: 0x000EAD5D File Offset: 0x000E8F5D
		public static void Init()
		{
			ConfigHotKeyViewById.HandleId = ConfigCommon.InitDataStatement(ConfigHotKeyViewById.HandleId, "db_uihotkot.db", "select BinData from `HotKeyView` where Id=?");
		}

		// Token: 0x06001907 RID: 6407 RVA: 0x000EAD78 File Offset: 0x000E8F78
		public static HotKeyView? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHotKeyViewById.HandleId, ConfigHotKeyViewById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HotKeyViewById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new HotKeyView?(HotKeyView.GetRootAsHotKeyView(configBuffer));
				}
			}
			ConfigHotKeyViewById.LogPair.Clear();
			ConfigHotKeyViewById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigHotKeyViewById.HandleId, 1, p0Id, ConfigHotKeyViewById.LogPair) || ConfigCommon.Step(ConfigHotKeyViewById.HandleId, true, ConfigHotKeyViewById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigHotKeyViewById.HandleId, ConfigHotKeyViewById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHotKeyViewById.HandleId, 0, ConfigHotKeyViewById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigHotKeyViewById.HandleId, ConfigHotKeyViewById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			HotKeyView rootAsHotKeyView = HotKeyView.GetRootAsHotKeyView(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HotKeyViewById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigHotKeyViewById.HandleId, ConfigHotKeyViewById.LogPair);
			return new HotKeyView?(rootAsHotKeyView);
		}

		// Token: 0x04001D0A RID: 7434
		private const string DB = "db_uihotkot.db";

		// Token: 0x04001D0B RID: 7435
		private const string FILE = "j.界面快捷键.xlsx";

		// Token: 0x04001D0C RID: 7436
		private const string TABLE = "HotKeyView";

		// Token: 0x04001D0D RID: 7437
		private const string COMMAND = "select BinData from `HotKeyView` where Id=?";

		// Token: 0x04001D0E RID: 7438
		private const string KEY_PREFIX = "HotKeyViewById";

		// Token: 0x04001D0F RID: 7439
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001D10 RID: 7440
		private static int HandleId;
	}
}
