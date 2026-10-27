using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000414 RID: 1044
	public class ConfigHotKeyViewById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600187F RID: 6271 RVA: 0x000E455C File Offset: 0x000E275C
		static ConfigHotKeyViewById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHotKeyViewById.CreateStaticDefaultValue), new Action(ConfigHotKeyViewById.ResetStaticDefaultValue));
		}

		// Token: 0x06001880 RID: 6272 RVA: 0x000E457C File Offset: 0x000E277C
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

		// Token: 0x06001881 RID: 6273 RVA: 0x000E45FB File Offset: 0x000E27FB
		public static void ResetStaticDefaultValue()
		{
			ConfigHotKeyViewById.LogPair = null;
			ConfigHotKeyViewById.HandleId = 0;
		}

		// Token: 0x06001882 RID: 6274 RVA: 0x000E4609 File Offset: 0x000E2809
		public static void Init()
		{
			ConfigHotKeyViewById.HandleId = ConfigCommon.InitDataStatement(ConfigHotKeyViewById.HandleId, "db_uihotkot.db", "select BinData from `HotKeyView` where Id=?");
		}

		// Token: 0x06001883 RID: 6275 RVA: 0x000E4624 File Offset: 0x000E2824
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

		// Token: 0x04001C70 RID: 7280
		private const string DB = "db_uihotkot.db";

		// Token: 0x04001C71 RID: 7281
		private const string FILE = "j.界面快捷键.xlsx";

		// Token: 0x04001C72 RID: 7282
		private const string TABLE = "HotKeyView";

		// Token: 0x04001C73 RID: 7283
		private const string COMMAND = "select BinData from `HotKeyView` where Id=?";

		// Token: 0x04001C74 RID: 7284
		private const string KEY_PREFIX = "HotKeyViewById";

		// Token: 0x04001C75 RID: 7285
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001C76 RID: 7286
		private static int HandleId;
	}
}
