using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000462 RID: 1122
	public class ConfigItemMotorPreviewByItemId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001A56 RID: 6742 RVA: 0x000EE458 File Offset: 0x000EC658
		static ConfigItemMotorPreviewByItemId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigItemMotorPreviewByItemId.CreateStaticDefaultValue), new Action(ConfigItemMotorPreviewByItemId.ResetStaticDefaultValue));
		}

		// Token: 0x06001A57 RID: 6743 RVA: 0x000EE478 File Offset: 0x000EC678
		public static void CreateStaticDefaultValue()
		{
			ConfigItemMotorPreviewByItemId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigItemMotorPreviewByItemId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorgeneralpreview.db"),
				new ValueTuple<string, object>("文件", "m.摩托车通用预览.xlsx"),
				new ValueTuple<string, object>("表名", "ItemMotorPreview"),
				new ValueTuple<string, object>("语句", "select BinData from `ItemMotorPreview` where ItemId=?")
			});
		}

		// Token: 0x06001A58 RID: 6744 RVA: 0x000EE4F7 File Offset: 0x000EC6F7
		public static void ResetStaticDefaultValue()
		{
			ConfigItemMotorPreviewByItemId.LogPair = null;
			ConfigItemMotorPreviewByItemId.HandleId = 0;
		}

		// Token: 0x06001A59 RID: 6745 RVA: 0x000EE505 File Offset: 0x000EC705
		public static void Init()
		{
			ConfigItemMotorPreviewByItemId.HandleId = ConfigCommon.InitDataStatement(ConfigItemMotorPreviewByItemId.HandleId, "db_motorgeneralpreview.db", "select BinData from `ItemMotorPreview` where ItemId=?");
		}

		// Token: 0x06001A5A RID: 6746 RVA: 0x000EE520 File Offset: 0x000EC720
		public static ItemMotorPreview? GetConfig(int p0ItemId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigItemMotorPreviewByItemId.HandleId, ConfigItemMotorPreviewByItemId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ItemMotorPreviewByItemId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ItemId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ItemMotorPreview?(ItemMotorPreview.GetRootAsItemMotorPreview(configBuffer));
				}
			}
			ConfigItemMotorPreviewByItemId.LogPair.Clear();
			ConfigItemMotorPreviewByItemId.LogPair.Add(new ValueTuple<string, object>("ItemId", p0ItemId));
			if (!ConfigCommon.BindInt(ConfigItemMotorPreviewByItemId.HandleId, 1, p0ItemId, ConfigItemMotorPreviewByItemId.LogPair) || ConfigCommon.Step(ConfigItemMotorPreviewByItemId.HandleId, true, ConfigItemMotorPreviewByItemId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigItemMotorPreviewByItemId.HandleId, ConfigItemMotorPreviewByItemId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigItemMotorPreviewByItemId.HandleId, 0, ConfigItemMotorPreviewByItemId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigItemMotorPreviewByItemId.HandleId, ConfigItemMotorPreviewByItemId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ItemMotorPreview rootAsItemMotorPreview = ItemMotorPreview.GetRootAsItemMotorPreview(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ItemMotorPreviewByItemId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ItemId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigItemMotorPreviewByItemId.HandleId, ConfigItemMotorPreviewByItemId.LogPair);
			return new ItemMotorPreview?(rootAsItemMotorPreview);
		}

		// Token: 0x04001E92 RID: 7826
		private const string DB = "db_motorgeneralpreview.db";

		// Token: 0x04001E93 RID: 7827
		private const string FILE = "m.摩托车通用预览.xlsx";

		// Token: 0x04001E94 RID: 7828
		private const string TABLE = "ItemMotorPreview";

		// Token: 0x04001E95 RID: 7829
		private const string COMMAND = "select BinData from `ItemMotorPreview` where ItemId=?";

		// Token: 0x04001E96 RID: 7830
		private const string KEY_PREFIX = "ItemMotorPreviewByItemId";

		// Token: 0x04001E97 RID: 7831
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001E98 RID: 7832
		private static int HandleId;
	}
}
