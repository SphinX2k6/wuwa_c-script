using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200255D RID: 9565
[NullableContext(1)]
[Nullable(0)]
public class PhotoDecoData
{
	// Token: 0x170018EC RID: 6380
	// (get) Token: 0x060134B1 RID: 79025 RVA: 0x004CC960 File Offset: 0x004CAB60
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

	// Token: 0x170018ED RID: 6381
	// (get) Token: 0x060134B2 RID: 79026 RVA: 0x004CC9B4 File Offset: 0x004CABB4
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

	// Token: 0x060134B3 RID: 79027 RVA: 0x004CCA0A File Offset: 0x004CAC0A
	public static PhotoDecoData FromFrame(PhotoFrame cfg)
	{
		return new PhotoDecoData
		{
			DecoType = EPhotoDecorationSubTabType.Frame,
			Id = cfg.Id,
			FrameConfig = new PhotoFrame?(cfg)
		};
	}

	// Token: 0x060134B4 RID: 79028 RVA: 0x004CCA31 File Offset: 0x004CAC31
	public static PhotoDecoData FromSticker(PhotoSticker cfg)
	{
		return new PhotoDecoData
		{
			DecoType = EPhotoDecorationSubTabType.Sticker,
			Id = cfg.Id,
			StickerConfig = new PhotoSticker?(cfg)
		};
	}

	// Token: 0x0400918E RID: 37262
	public int Id;

	// Token: 0x0400918F RID: 37263
	public EPhotoDecorationSubTabType DecoType;

	// Token: 0x04009190 RID: 37264
	public PhotoFrame? FrameConfig;

	// Token: 0x04009191 RID: 37265
	public PhotoSticker? StickerConfig;
}
