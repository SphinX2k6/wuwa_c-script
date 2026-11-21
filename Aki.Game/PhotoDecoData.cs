using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001A48 RID: 6728
[NullableContext(1)]
[Nullable(0)]
public class PhotoDecoData
{
	// Token: 0x17001926 RID: 6438
	// (get) Token: 0x06010993 RID: 67987 RVA: 0x004DB594 File Offset: 0x004D9794
	public int RelativeItem
	{
		get
		{
			if (this.DecoType != EPhotoDecorationSubTabType.Frame)
			{
				if (this.StickerConfig == null)
				{
					return 0;
				}
				return this.StickerConfig.GetValueOrDefault().RelativeItem;
			}
			else
			{
				if (this.FrameConfig == null)
				{
					return 0;
				}
				return this.FrameConfig.GetValueOrDefault().RelativeItem;
			}
		}
	}

	// Token: 0x17001927 RID: 6439
	// (get) Token: 0x06010994 RID: 67988 RVA: 0x004DB5E8 File Offset: 0x004D97E8
	public bool IsDefault
	{
		get
		{
			if (this.DecoType != EPhotoDecorationSubTabType.Frame)
			{
				return this.StickerConfig != null && this.StickerConfig.GetValueOrDefault().IsDefault;
			}
			return this.FrameConfig != null && this.FrameConfig.GetValueOrDefault().Mode == 0;
		}
	}

	// Token: 0x06010995 RID: 67989 RVA: 0x004DB63E File Offset: 0x004D983E
	public static PhotoDecoData FromFrame(PhotoFrame cfg)
	{
		return new PhotoDecoData
		{
			DecoType = EPhotoDecorationSubTabType.Frame,
			Id = cfg.Id,
			FrameConfig = new PhotoFrame?(cfg)
		};
	}

	// Token: 0x06010996 RID: 67990 RVA: 0x004DB665 File Offset: 0x004D9865
	public static PhotoDecoData FromSticker(PhotoSticker cfg)
	{
		return new PhotoDecoData
		{
			DecoType = EPhotoDecorationSubTabType.Sticker,
			Id = cfg.Id,
			StickerConfig = new PhotoSticker?(cfg)
		};
	}

	// Token: 0x040092E7 RID: 37607
	public int Id;

	// Token: 0x040092E8 RID: 37608
	public EPhotoDecorationSubTabType DecoType;

	// Token: 0x040092E9 RID: 37609
	public PhotoFrame? FrameConfig;

	// Token: 0x040092EA RID: 37610
	public PhotoSticker? StickerConfig;
}
