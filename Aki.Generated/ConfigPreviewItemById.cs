using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000762 RID: 1890
	public class ConfigPreviewItemById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002C5D RID: 11357 RVA: 0x00154043 File Offset: 0x00152243
		static ConfigPreviewItemById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPreviewItemById.CreateStaticDefaultValue), new Action(ConfigPreviewItemById.ResetStaticDefaultValue));
		}

		// Token: 0x06002C5E RID: 11358 RVA: 0x00154064 File Offset: 0x00152264
		public static void CreateStaticDefaultValue()
		{
			ConfigPreviewItemById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPreviewItemById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_item.db"),
				new ValueTuple<string, object>("文件", "d.道具.xlsx"),
				new ValueTuple<string, object>("表名", "PreviewItem"),
				new ValueTuple<string, object>("语句", "select BinData from `PreviewItem` where Id=?")
			});
		}

		// Token: 0x06002C5F RID: 11359 RVA: 0x001540E3 File Offset: 0x001522E3
		public static void ResetStaticDefaultValue()
		{
			ConfigPreviewItemById.LogPair = null;
			ConfigPreviewItemById.HandleId = 0;
		}

		// Token: 0x06002C60 RID: 11360 RVA: 0x001540F1 File Offset: 0x001522F1
		public static void Init()
		{
			ConfigPreviewItemById.HandleId = ConfigCommon.InitDataStatement(ConfigPreviewItemById.HandleId, "db_item.db", "select BinData from `PreviewItem` where Id=?");
		}

		// Token: 0x06002C61 RID: 11361 RVA: 0x0015410C File Offset: 0x0015230C
		public static PreviewItem? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPreviewItemById.HandleId, ConfigPreviewItemById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PreviewItemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PreviewItem?(PreviewItem.GetRootAsPreviewItem(configBuffer));
				}
			}
			ConfigPreviewItemById.LogPair.Clear();
			ConfigPreviewItemById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPreviewItemById.HandleId, 1, p0Id, ConfigPreviewItemById.LogPair) || ConfigCommon.Step(ConfigPreviewItemById.HandleId, true, ConfigPreviewItemById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPreviewItemById.HandleId, ConfigPreviewItemById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPreviewItemById.HandleId, 0, ConfigPreviewItemById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPreviewItemById.HandleId, ConfigPreviewItemById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PreviewItem rootAsPreviewItem = PreviewItem.GetRootAsPreviewItem(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PreviewItemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPreviewItemById.HandleId, ConfigPreviewItemById.LogPair);
			return new PreviewItem?(rootAsPreviewItem);
		}

		// Token: 0x04003394 RID: 13204
		private const string DB = "db_item.db";

		// Token: 0x04003395 RID: 13205
		private const string FILE = "d.道具.xlsx";

		// Token: 0x04003396 RID: 13206
		private const string TABLE = "PreviewItem";

		// Token: 0x04003397 RID: 13207
		private const string COMMAND = "select BinData from `PreviewItem` where Id=?";

		// Token: 0x04003398 RID: 13208
		private const string KEY_PREFIX = "PreviewItemById";

		// Token: 0x04003399 RID: 13209
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400339A RID: 13210
		private static int HandleId;
	}
}
