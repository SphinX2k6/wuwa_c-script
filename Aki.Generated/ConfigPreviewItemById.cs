using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200077A RID: 1914
	public class ConfigPreviewItemById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002CED RID: 11501 RVA: 0x0015AABF File Offset: 0x00158CBF
		static ConfigPreviewItemById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPreviewItemById.CreateStaticDefaultValue), new Action(ConfigPreviewItemById.ResetStaticDefaultValue));
		}

		// Token: 0x06002CEE RID: 11502 RVA: 0x0015AAE0 File Offset: 0x00158CE0
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

		// Token: 0x06002CEF RID: 11503 RVA: 0x0015AB5F File Offset: 0x00158D5F
		public static void ResetStaticDefaultValue()
		{
			ConfigPreviewItemById.LogPair = null;
			ConfigPreviewItemById.HandleId = 0;
		}

		// Token: 0x06002CF0 RID: 11504 RVA: 0x0015AB6D File Offset: 0x00158D6D
		public static void Init()
		{
			ConfigPreviewItemById.HandleId = ConfigCommon.InitDataStatement(ConfigPreviewItemById.HandleId, "db_item.db", "select BinData from `PreviewItem` where Id=?");
		}

		// Token: 0x06002CF1 RID: 11505 RVA: 0x0015AB88 File Offset: 0x00158D88
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

		// Token: 0x0400343C RID: 13372
		private const string DB = "db_item.db";

		// Token: 0x0400343D RID: 13373
		private const string FILE = "d.道具.xlsx";

		// Token: 0x0400343E RID: 13374
		private const string TABLE = "PreviewItem";

		// Token: 0x0400343F RID: 13375
		private const string COMMAND = "select BinData from `PreviewItem` where Id=?";

		// Token: 0x04003440 RID: 13376
		private const string KEY_PREFIX = "PreviewItemById";

		// Token: 0x04003441 RID: 13377
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003442 RID: 13378
		private static int HandleId;
	}
}
