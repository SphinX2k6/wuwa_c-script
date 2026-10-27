using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A6B RID: 2667
	public class ConfigUiPlayItemById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003E96 RID: 16022 RVA: 0x001BBE97 File Offset: 0x001BA097
		static ConfigUiPlayItemById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigUiPlayItemById.CreateStaticDefaultValue), new Action(ConfigUiPlayItemById.ResetStaticDefaultValue));
		}

		// Token: 0x06003E97 RID: 16023 RVA: 0x001BBEB8 File Offset: 0x001BA0B8
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

		// Token: 0x06003E98 RID: 16024 RVA: 0x001BBF37 File Offset: 0x001BA137
		public static void ResetStaticDefaultValue()
		{
			ConfigUiPlayItemById.LogPair = null;
			ConfigUiPlayItemById.HandleId = 0;
		}

		// Token: 0x06003E99 RID: 16025 RVA: 0x001BBF45 File Offset: 0x001BA145
		public static void Init()
		{
			ConfigUiPlayItemById.HandleId = ConfigCommon.InitDataStatement(ConfigUiPlayItemById.HandleId, "db_uiplayitem.db", "select BinData from `UiPlayItem` where Id=?");
		}

		// Token: 0x06003E9A RID: 16026 RVA: 0x001BBF60 File Offset: 0x001BA160
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

		// Token: 0x040048D3 RID: 18643
		private const string DB = "db_uiplayitem.db";

		// Token: 0x040048D4 RID: 18644
		private const string FILE = "u.UI玩法道具.xlsx";

		// Token: 0x040048D5 RID: 18645
		private const string TABLE = "UiPlayItem";

		// Token: 0x040048D6 RID: 18646
		private const string COMMAND = "select BinData from `UiPlayItem` where Id=?";

		// Token: 0x040048D7 RID: 18647
		private const string KEY_PREFIX = "UiPlayItemById";

		// Token: 0x040048D8 RID: 18648
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040048D9 RID: 18649
		private static int HandleId;
	}
}
