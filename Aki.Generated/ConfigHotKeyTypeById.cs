using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000413 RID: 1043
	public class ConfigHotKeyTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001879 RID: 6265 RVA: 0x000E4315 File Offset: 0x000E2515
		static ConfigHotKeyTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHotKeyTypeById.CreateStaticDefaultValue), new Action(ConfigHotKeyTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x0600187A RID: 6266 RVA: 0x000E4334 File Offset: 0x000E2534
		public static void CreateStaticDefaultValue()
		{
			ConfigHotKeyTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHotKeyTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_uihotkot.db"),
				new ValueTuple<string, object>("文件", "j.界面快捷键.xlsx"),
				new ValueTuple<string, object>("表名", "HotKeyType"),
				new ValueTuple<string, object>("语句", "select BinData from `HotKeyType` where Id=?")
			});
		}

		// Token: 0x0600187B RID: 6267 RVA: 0x000E43B3 File Offset: 0x000E25B3
		public static void ResetStaticDefaultValue()
		{
			ConfigHotKeyTypeById.LogPair = null;
			ConfigHotKeyTypeById.HandleId = 0;
		}

		// Token: 0x0600187C RID: 6268 RVA: 0x000E43C1 File Offset: 0x000E25C1
		public static void Init()
		{
			ConfigHotKeyTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigHotKeyTypeById.HandleId, "db_uihotkot.db", "select BinData from `HotKeyType` where Id=?");
		}

		// Token: 0x0600187D RID: 6269 RVA: 0x000E43DC File Offset: 0x000E25DC
		public static HotKeyType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHotKeyTypeById.HandleId, ConfigHotKeyTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HotKeyTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new HotKeyType?(HotKeyType.GetRootAsHotKeyType(configBuffer));
				}
			}
			ConfigHotKeyTypeById.LogPair.Clear();
			ConfigHotKeyTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigHotKeyTypeById.HandleId, 1, p0Id, ConfigHotKeyTypeById.LogPair) || ConfigCommon.Step(ConfigHotKeyTypeById.HandleId, true, ConfigHotKeyTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigHotKeyTypeById.HandleId, ConfigHotKeyTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHotKeyTypeById.HandleId, 0, ConfigHotKeyTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigHotKeyTypeById.HandleId, ConfigHotKeyTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			HotKeyType rootAsHotKeyType = HotKeyType.GetRootAsHotKeyType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HotKeyTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigHotKeyTypeById.HandleId, ConfigHotKeyTypeById.LogPair);
			return new HotKeyType?(rootAsHotKeyType);
		}

		// Token: 0x04001C69 RID: 7273
		private const string DB = "db_uihotkot.db";

		// Token: 0x04001C6A RID: 7274
		private const string FILE = "j.界面快捷键.xlsx";

		// Token: 0x04001C6B RID: 7275
		private const string TABLE = "HotKeyType";

		// Token: 0x04001C6C RID: 7276
		private const string COMMAND = "select BinData from `HotKeyType` where Id=?";

		// Token: 0x04001C6D RID: 7277
		private const string KEY_PREFIX = "HotKeyTypeById";

		// Token: 0x04001C6E RID: 7278
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001C6F RID: 7279
		private static int HandleId;
	}
}
