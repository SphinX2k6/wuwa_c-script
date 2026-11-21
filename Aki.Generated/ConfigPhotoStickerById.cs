using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000710 RID: 1808
	public class ConfigPhotoStickerById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002A70 RID: 10864 RVA: 0x0014CC3F File Offset: 0x0014AE3F
		static ConfigPhotoStickerById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoStickerById.CreateStaticDefaultValue), new Action(ConfigPhotoStickerById.ResetStaticDefaultValue));
		}

		// Token: 0x06002A71 RID: 10865 RVA: 0x0014CC60 File Offset: 0x0014AE60
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoStickerById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoStickerById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_photonew.db"),
				new ValueTuple<string, object>("文件", "p.拍照新.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoSticker"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoSticker` where Id=?")
			});
		}

		// Token: 0x06002A72 RID: 10866 RVA: 0x0014CCDF File Offset: 0x0014AEDF
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoStickerById.LogPair = null;
			ConfigPhotoStickerById.HandleId = 0;
		}

		// Token: 0x06002A73 RID: 10867 RVA: 0x0014CCED File Offset: 0x0014AEED
		public static void Init()
		{
			ConfigPhotoStickerById.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoStickerById.HandleId, "db_photonew.db", "select BinData from `PhotoSticker` where Id=?");
		}

		// Token: 0x06002A74 RID: 10868 RVA: 0x0014CD08 File Offset: 0x0014AF08
		public static PhotoSticker? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoStickerById.HandleId, ConfigPhotoStickerById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoStickerById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhotoSticker?(PhotoSticker.GetRootAsPhotoSticker(configBuffer));
				}
			}
			ConfigPhotoStickerById.LogPair.Clear();
			ConfigPhotoStickerById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhotoStickerById.HandleId, 1, p0Id, ConfigPhotoStickerById.LogPair) || ConfigCommon.Step(ConfigPhotoStickerById.HandleId, true, ConfigPhotoStickerById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhotoStickerById.HandleId, ConfigPhotoStickerById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoStickerById.HandleId, 0, ConfigPhotoStickerById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhotoStickerById.HandleId, ConfigPhotoStickerById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhotoSticker rootAsPhotoSticker = PhotoSticker.GetRootAsPhotoSticker(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoStickerById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhotoStickerById.HandleId, ConfigPhotoStickerById.LogPair);
			return new PhotoSticker?(rootAsPhotoSticker);
		}

		// Token: 0x04003156 RID: 12630
		private const string DB = "db_photonew.db";

		// Token: 0x04003157 RID: 12631
		private const string FILE = "p.拍照新.xlsx";

		// Token: 0x04003158 RID: 12632
		private const string TABLE = "PhotoSticker";

		// Token: 0x04003159 RID: 12633
		private const string COMMAND = "select BinData from `PhotoSticker` where Id=?";

		// Token: 0x0400315A RID: 12634
		private const string KEY_PREFIX = "PhotoStickerById";

		// Token: 0x0400315B RID: 12635
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400315C RID: 12636
		private static int HandleId;
	}
}
