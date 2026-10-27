using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;

// Token: 0x0200255B RID: 9563
[NullableContext(1)]
[Nullable(0)]
public class PhotoSelfieItemData
{
	// Token: 0x170018E5 RID: 6373
	// (get) Token: 0x0601349D RID: 79005 RVA: 0x004CC40A File Offset: 0x004CA60A
	private bool IsMotion
	{
		get
		{
			return this.SubTabType == EPhotoCharacterSubTabType.Motion;
		}
	}

	// Token: 0x170018E6 RID: 6374
	// (get) Token: 0x0601349E RID: 79006 RVA: 0x004CC418 File Offset: 0x004CA618
	public string Icon
	{
		get
		{
			return (this.IsMotion ? ((this.MotionConfig != null) ? this.MotionConfig.GetValueOrDefault().Icon : null) : ((this.ExpressionConfig != null) ? this.ExpressionConfig.GetValueOrDefault().Icon : null)) ?? "";
		}
	}

	// Token: 0x170018E7 RID: 6375
	// (get) Token: 0x0601349F RID: 79007 RVA: 0x004CC478 File Offset: 0x004CA678
	public string Name
	{
		get
		{
			return (this.IsMotion ? ((this.MotionConfig != null) ? this.MotionConfig.GetValueOrDefault().Name : null) : ((this.ExpressionConfig != null) ? this.ExpressionConfig.GetValueOrDefault().Name : null)) ?? "";
		}
	}

	// Token: 0x170018E8 RID: 6376
	// (get) Token: 0x060134A0 RID: 79008 RVA: 0x004CC4D8 File Offset: 0x004CA6D8
	public int RelativeItem
	{
		get
		{
			return (this.IsMotion ? ((this.MotionConfig != null) ? new int?(this.MotionConfig.GetValueOrDefault().RelativeItem) : null) : ((this.ExpressionConfig != null) ? new int?(this.ExpressionConfig.GetValueOrDefault().RelativeItem) : null)).GetValueOrDefault();
		}
	}

	// Token: 0x170018E9 RID: 6377
	// (get) Token: 0x060134A1 RID: 79009 RVA: 0x004CC550 File Offset: 0x004CA750
	public bool IsDefault
	{
		get
		{
			return (this.IsMotion ? ((this.MotionConfig != null) ? new bool?(this.MotionConfig.GetValueOrDefault().IsDefault) : null) : ((this.ExpressionConfig != null) ? new bool?(this.ExpressionConfig.GetValueOrDefault().IsDefault) : null)).GetValueOrDefault();
		}
	}

	// Token: 0x170018EA RID: 6378
	// (get) Token: 0x060134A2 RID: 79010 RVA: 0x004CC5C8 File Offset: 0x004CA7C8
	public int MontageConfigDtId
	{
		get
		{
			return (this.IsMotion ? ((this.MotionConfig != null) ? new int?(this.MotionConfig.GetValueOrDefault().MontageConfigDtId) : null) : ((this.ExpressionConfig != null) ? new int?(this.ExpressionConfig.GetValueOrDefault().MontageConfigDtId) : null)).GetValueOrDefault();
		}
	}

	// Token: 0x170018EB RID: 6379
	// (get) Token: 0x060134A3 RID: 79011 RVA: 0x004CC63F File Offset: 0x004CA83F
	public ESelfieMontageType MontageType
	{
		get
		{
			if (!this.IsMotion)
			{
				return ESelfieMontageType.FacePerform;
			}
			return ESelfieMontageType.UpperPerform;
		}
	}

	// Token: 0x060134A4 RID: 79012 RVA: 0x004CC64C File Offset: 0x004CA84C
	public static PhotoSelfieItemData FromMotion(PhotoSelfieMontage cfg)
	{
		return new PhotoSelfieItemData
		{
			SubTabType = EPhotoCharacterSubTabType.Motion,
			Id = cfg.Id,
			MotionConfig = new PhotoSelfieMontage?(cfg)
		};
	}

	// Token: 0x060134A5 RID: 79013 RVA: 0x004CC673 File Offset: 0x004CA873
	public static PhotoSelfieItemData FromExpression(PhotoExpression cfg)
	{
		return new PhotoSelfieItemData
		{
			SubTabType = EPhotoCharacterSubTabType.Expression,
			Id = cfg.Id,
			ExpressionConfig = new PhotoExpression?(cfg)
		};
	}

	// Token: 0x04009186 RID: 37254
	public int Id;

	// Token: 0x04009187 RID: 37255
	public EPhotoCharacterSubTabType SubTabType;

	// Token: 0x04009188 RID: 37256
	public PhotoSelfieMontage? MotionConfig;

	// Token: 0x04009189 RID: 37257
	public PhotoExpression? ExpressionConfig;
}
