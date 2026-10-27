using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200057A RID: 1402
	public class ConfigMotorDecalPreviewByStickerId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060020E9 RID: 8425 RVA: 0x001137A4 File Offset: 0x001119A4
		static ConfigMotorDecalPreviewByStickerId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorDecalPreviewByStickerId.CreateStaticDefaultValue), new Action(ConfigMotorDecalPreviewByStickerId.ResetStaticDefaultValue));
		}

		// Token: 0x060020EA RID: 8426 RVA: 0x001137C4 File Offset: 0x001119C4
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

		// Token: 0x060020EB RID: 8427 RVA: 0x00113843 File Offset: 0x00111A43
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorDecalPreviewByStickerId.LogPair = null;
			ConfigMotorDecalPreviewByStickerId.HandleId = 0;
		}

		// Token: 0x060020EC RID: 8428 RVA: 0x00113851 File Offset: 0x00111A51
		public static void Init()
		{
			ConfigMotorDecalPreviewByStickerId.HandleId = ConfigCommon.InitDataStatement(ConfigMotorDecalPreviewByStickerId.HandleId, "db_motorstickerip.db", "select BinData from `MotorDecalPreview` where StickerId=?");
		}

		// Token: 0x060020ED RID: 8429 RVA: 0x0011386C File Offset: 0x00111A6C
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

		// Token: 0x0400263A RID: 9786
		private const string DB = "db_motorstickerip.db";

		// Token: 0x0400263B RID: 9787
		private const string FILE = "m.摩托车贴纸活动.xlsx";

		// Token: 0x0400263C RID: 9788
		private const string TABLE = "MotorDecalPreview";

		// Token: 0x0400263D RID: 9789
		private const string COMMAND = "select BinData from `MotorDecalPreview` where StickerId=?";

		// Token: 0x0400263E RID: 9790
		private const string KEY_PREFIX = "MotorDecalPreviewByStickerId";

		// Token: 0x0400263F RID: 9791
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002640 RID: 9792
		private static int HandleId;
	}
}
