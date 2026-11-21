using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B40 RID: 2880
	public class ConfigUiPlayItemById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004394 RID: 17300 RVA: 0x001DB22B File Offset: 0x001D942B
		static ConfigUiPlayItemById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigUiPlayItemById.CreateStaticDefaultValue), new Action(ConfigUiPlayItemById.ResetStaticDefaultValue));
		}

		// Token: 0x06004395 RID: 17301 RVA: 0x001DB24C File Offset: 0x001D944C
		public static void CreateStaticDefaultValue()
		{
			ConfigUiPlayItemById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigUiPlayItemById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_uiplayitem.db"),
				new ValueTuple<string, object>("文件", "u.UI玩法道具.xlsx"),
				new ValueTuple<string, object>("表名", "UiPlayItem"),
				new ValueTuple<string, object>("语句", "select BinData from `UiPlayItem` where Id=?")
			});
		}

		// Token: 0x06004396 RID: 17302 RVA: 0x001DB2CB File Offset: 0x001D94CB
		public static void ResetStaticDefaultValue()
		{
			ConfigUiPlayItemById.LogPair = null;
			ConfigUiPlayItemById.HandleId = 0;
		}

		// Token: 0x06004397 RID: 17303 RVA: 0x001DB2D9 File Offset: 0x001D94D9
		public static void Init()
		{
			ConfigUiPlayItemById.HandleId = ConfigCommon.InitDataStatement(ConfigUiPlayItemById.HandleId, "db_uiplayitem.db", "select BinData from `UiPlayItem` where Id=?");
		}

		// Token: 0x06004398 RID: 17304 RVA: 0x001DB2F4 File Offset: 0x001D94F4
		public static UiPlayItem? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigUiPlayItemById.HandleId, ConfigUiPlayItemById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("UiPlayItemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new UiPlayItem?(UiPlayItem.GetRootAsUiPlayItem(configBuffer));
				}
			}
			ConfigUiPlayItemById.LogPair.Clear();
			ConfigUiPlayItemById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigUiPlayItemById.HandleId, 1, p0Id, ConfigUiPlayItemById.LogPair) || ConfigCommon.Step(ConfigUiPlayItemById.HandleId, true, ConfigUiPlayItemById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigUiPlayItemById.HandleId, ConfigUiPlayItemById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigUiPlayItemById.HandleId, 0, ConfigUiPlayItemById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigUiPlayItemById.HandleId, ConfigUiPlayItemById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			UiPlayItem rootAsUiPlayItem = UiPlayItem.GetRootAsUiPlayItem(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("UiPlayItemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigUiPlayItemById.HandleId, ConfigUiPlayItemById.LogPair);
			return new UiPlayItem?(rootAsUiPlayItem);
		}

		// Token: 0x04004EA6 RID: 20134
		private const string DB = "db_uiplayitem.db";

		// Token: 0x04004EA7 RID: 20135
		private const string FILE = "u.UI玩法道具.xlsx";

		// Token: 0x04004EA8 RID: 20136
		private const string TABLE = "UiPlayItem";

		// Token: 0x04004EA9 RID: 20137
		private const string COMMAND = "select BinData from `UiPlayItem` where Id=?";

		// Token: 0x04004EAA RID: 20138
		private const string KEY_PREFIX = "UiPlayItemById";

		// Token: 0x04004EAB RID: 20139
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004EAC RID: 20140
		private static int HandleId;
	}
}
