using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000478 RID: 1144
	public class ConfigItemMotorPreviewByItemId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001ADA RID: 6874 RVA: 0x000F4BAC File Offset: 0x000F2DAC
		static ConfigItemMotorPreviewByItemId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigItemMotorPreviewByItemId.CreateStaticDefaultValue), new Action(ConfigItemMotorPreviewByItemId.ResetStaticDefaultValue));
		}

		// Token: 0x06001ADB RID: 6875 RVA: 0x000F4BCC File Offset: 0x000F2DCC
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

		// Token: 0x06001ADC RID: 6876 RVA: 0x000F4C4B File Offset: 0x000F2E4B
		public static void ResetStaticDefaultValue()
		{
			ConfigItemMotorPreviewByItemId.LogPair = null;
			ConfigItemMotorPreviewByItemId.HandleId = 0;
		}

		// Token: 0x06001ADD RID: 6877 RVA: 0x000F4C59 File Offset: 0x000F2E59
		public static void Init()
		{
			ConfigItemMotorPreviewByItemId.HandleId = ConfigCommon.InitDataStatement(ConfigItemMotorPreviewByItemId.HandleId, "db_motorgeneralpreview.db", "select BinData from `ItemMotorPreview` where ItemId=?");
		}

		// Token: 0x06001ADE RID: 6878 RVA: 0x000F4C74 File Offset: 0x000F2E74
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

		// Token: 0x04001F2C RID: 7980
		private const string DB = "db_motorgeneralpreview.db";

		// Token: 0x04001F2D RID: 7981
		private const string FILE = "m.摩托车通用预览.xlsx";

		// Token: 0x04001F2E RID: 7982
		private const string TABLE = "ItemMotorPreview";

		// Token: 0x04001F2F RID: 7983
		private const string COMMAND = "select BinData from `ItemMotorPreview` where ItemId=?";

		// Token: 0x04001F30 RID: 7984
		private const string KEY_PREFIX = "ItemMotorPreviewByItemId";

		// Token: 0x04001F31 RID: 7985
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001F32 RID: 7986
		private static int HandleId;
	}
}
