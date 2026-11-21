using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000590 RID: 1424
	public class ConfigMotorDecalPreviewByStickerId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600216D RID: 8557 RVA: 0x00119EF8 File Offset: 0x001180F8
		static ConfigMotorDecalPreviewByStickerId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorDecalPreviewByStickerId.CreateStaticDefaultValue), new Action(ConfigMotorDecalPreviewByStickerId.ResetStaticDefaultValue));
		}

		// Token: 0x0600216E RID: 8558 RVA: 0x00119F18 File Offset: 0x00118118
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorDecalPreviewByStickerId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorDecalPreviewByStickerId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorstickerip.db"),
				new ValueTuple<string, object>("文件", "m.摩托车贴纸活动.xlsx"),
				new ValueTuple<string, object>("表名", "MotorDecalPreview"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorDecalPreview` where StickerId=?")
			});
		}

		// Token: 0x0600216F RID: 8559 RVA: 0x00119F97 File Offset: 0x00118197
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorDecalPreviewByStickerId.LogPair = null;
			ConfigMotorDecalPreviewByStickerId.HandleId = 0;
		}

		// Token: 0x06002170 RID: 8560 RVA: 0x00119FA5 File Offset: 0x001181A5
		public static void Init()
		{
			ConfigMotorDecalPreviewByStickerId.HandleId = ConfigCommon.InitDataStatement(ConfigMotorDecalPreviewByStickerId.HandleId, "db_motorstickerip.db", "select BinData from `MotorDecalPreview` where StickerId=?");
		}

		// Token: 0x06002171 RID: 8561 RVA: 0x00119FC0 File Offset: 0x001181C0
		public static MotorDecalPreview? GetConfig(int p0StickerId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorDecalPreviewByStickerId.HandleId, ConfigMotorDecalPreviewByStickerId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorDecalPreviewByStickerId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0StickerId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorDecalPreview?(MotorDecalPreview.GetRootAsMotorDecalPreview(configBuffer));
				}
			}
			ConfigMotorDecalPreviewByStickerId.LogPair.Clear();
			ConfigMotorDecalPreviewByStickerId.LogPair.Add(new ValueTuple<string, object>("StickerId", p0StickerId));
			if (!ConfigCommon.BindInt(ConfigMotorDecalPreviewByStickerId.HandleId, 1, p0StickerId, ConfigMotorDecalPreviewByStickerId.LogPair) || ConfigCommon.Step(ConfigMotorDecalPreviewByStickerId.HandleId, true, ConfigMotorDecalPreviewByStickerId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorDecalPreviewByStickerId.HandleId, ConfigMotorDecalPreviewByStickerId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorDecalPreviewByStickerId.HandleId, 0, ConfigMotorDecalPreviewByStickerId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorDecalPreviewByStickerId.HandleId, ConfigMotorDecalPreviewByStickerId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorDecalPreview rootAsMotorDecalPreview = MotorDecalPreview.GetRootAsMotorDecalPreview(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorDecalPreviewByStickerId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0StickerId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorDecalPreviewByStickerId.HandleId, ConfigMotorDecalPreviewByStickerId.LogPair);
			return new MotorDecalPreview?(rootAsMotorDecalPreview);
		}

		// Token: 0x040026D4 RID: 9940
		private const string DB = "db_motorstickerip.db";

		// Token: 0x040026D5 RID: 9941
		private const string FILE = "m.摩托车贴纸活动.xlsx";

		// Token: 0x040026D6 RID: 9942
		private const string TABLE = "MotorDecalPreview";

		// Token: 0x040026D7 RID: 9943
		private const string COMMAND = "select BinData from `MotorDecalPreview` where StickerId=?";

		// Token: 0x040026D8 RID: 9944
		private const string KEY_PREFIX = "MotorDecalPreviewByStickerId";

		// Token: 0x040026D9 RID: 9945
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040026DA RID: 9946
		private static int HandleId;
	}
}
