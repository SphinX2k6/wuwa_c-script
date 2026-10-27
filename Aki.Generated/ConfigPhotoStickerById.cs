using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006F8 RID: 1784
	public class ConfigPhotoStickerById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060029E0 RID: 10720 RVA: 0x001461C3 File Offset: 0x001443C3
		static ConfigPhotoStickerById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoStickerById.CreateStaticDefaultValue), new Action(ConfigPhotoStickerById.ResetStaticDefaultValue));
		}

		// Token: 0x060029E1 RID: 10721 RVA: 0x001461E4 File Offset: 0x001443E4
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

		// Token: 0x060029E2 RID: 10722 RVA: 0x00146263 File Offset: 0x00144463
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoStickerById.LogPair = null;
			ConfigPhotoStickerById.HandleId = 0;
		}

		// Token: 0x060029E3 RID: 10723 RVA: 0x00146271 File Offset: 0x00144471
		public static void Init()
		{
			ConfigPhotoStickerById.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoStickerById.HandleId, "db_photonew.db", "select BinData from `PhotoSticker` where Id=?");
		}

		// Token: 0x060029E4 RID: 10724 RVA: 0x0014628C File Offset: 0x0014448C
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

		// Token: 0x040030AE RID: 12462
		private const string DB = "db_photonew.db";

		// Token: 0x040030AF RID: 12463
		private const string FILE = "p.拍照新.xlsx";

		// Token: 0x040030B0 RID: 12464
		private const string TABLE = "PhotoSticker";

		// Token: 0x040030B1 RID: 12465
		private const string COMMAND = "select BinData from `PhotoSticker` where Id=?";

		// Token: 0x040030B2 RID: 12466
		private const string KEY_PREFIX = "PhotoStickerById";

		// Token: 0x040030B3 RID: 12467
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040030B4 RID: 12468
		private static int HandleId;
	}
}
