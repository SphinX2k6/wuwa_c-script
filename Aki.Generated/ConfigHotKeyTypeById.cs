using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000429 RID: 1065
	public class ConfigHotKeyTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060018FD RID: 6397 RVA: 0x000EAA69 File Offset: 0x000E8C69
		static ConfigHotKeyTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHotKeyTypeById.CreateStaticDefaultValue), new Action(ConfigHotKeyTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x060018FE RID: 6398 RVA: 0x000EAA88 File Offset: 0x000E8C88
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

		// Token: 0x060018FF RID: 6399 RVA: 0x000EAB07 File Offset: 0x000E8D07
		public static void ResetStaticDefaultValue()
		{
			ConfigHotKeyTypeById.LogPair = null;
			ConfigHotKeyTypeById.HandleId = 0;
		}

		// Token: 0x06001900 RID: 6400 RVA: 0x000EAB15 File Offset: 0x000E8D15
		public static void Init()
		{
			ConfigHotKeyTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigHotKeyTypeById.HandleId, "db_uihotkot.db", "select BinData from `HotKeyType` where Id=?");
		}

		// Token: 0x06001901 RID: 6401 RVA: 0x000EAB30 File Offset: 0x000E8D30
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

		// Token: 0x04001D03 RID: 7427
		private const string DB = "db_uihotkot.db";

		// Token: 0x04001D04 RID: 7428
		private const string FILE = "j.界面快捷键.xlsx";

		// Token: 0x04001D05 RID: 7429
		private const string TABLE = "HotKeyType";

		// Token: 0x04001D06 RID: 7430
		private const string COMMAND = "select BinData from `HotKeyType` where Id=?";

		// Token: 0x04001D07 RID: 7431
		private const string KEY_PREFIX = "HotKeyTypeById";

		// Token: 0x04001D08 RID: 7432
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001D09 RID: 7433
		private static int HandleId;
	}
}
