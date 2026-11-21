using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;

// Token: 0x02001A46 RID: 6726
[NullableContext(1)]
[Nullable(0)]
public class PhotoSelfieItemData : IComparable<PhotoSelfieItemData>
{
	// Token: 0x1700191E RID: 6430
	// (get) Token: 0x0601097D RID: 67965 RVA: 0x004DAF46 File Offset: 0x004D9146
	private bool IsMotion
	{
		get
		{
			return this.SubTabType == EPhotoCharacterSubTabType.Motion;
		}
	}

	// Token: 0x1700191F RID: 6431
	// (get) Token: 0x0601097E RID: 67966 RVA: 0x004DAF54 File Offset: 0x004D9154
	public string Icon
	{
		get
		{
			return (this.IsMotion ? ((this.MotionConfig != null) ? this.MotionConfig.GetValueOrDefault().Icon : null) : ((this.ExpressionConfig != null) ? this.ExpressionConfig.GetValueOrDefault().Icon : null)) ?? "";
		}
	}

	// Token: 0x17001920 RID: 6432
	// (get) Token: 0x0601097F RID: 67967 RVA: 0x004DAFB4 File Offset: 0x004D91B4
	public string Name
	{
		get
		{
			return (this.IsMotion ? ((this.MotionConfig != null) ? this.MotionConfig.GetValueOrDefault().Name : null) : ((this.ExpressionConfig != null) ? this.ExpressionConfig.GetValueOrDefault().Name : null)) ?? "";
		}
	}

	// Token: 0x17001921 RID: 6433
	// (get) Token: 0x06010980 RID: 67968 RVA: 0x004DB014 File Offset: 0x004D9214
	public int RelativeItem
	{
		get
		{
			return (this.IsMotion ? ((this.MotionConfig != null) ? new int?(this.MotionConfig.GetValueOrDefault().RelativeItem) : null) : ((this.ExpressionConfig != null) ? new int?(this.ExpressionConfig.GetValueOrDefault().RelativeItem) : null)).GetValueOrDefault();
		}
	}

	// Token: 0x17001922 RID: 6434
	// (get) Token: 0x06010981 RID: 67969 RVA: 0x004DB08C File Offset: 0x004D928C
	public bool IsDefault
	{
		get
		{
			return (this.IsMotion ? ((this.MotionConfig != null) ? new bool?(this.MotionConfig.GetValueOrDefault().IsDefault) : null) : ((this.ExpressionConfig != null) ? new bool?(this.ExpressionConfig.GetValueOrDefault().IsDefault) : null)).GetValueOrDefault();
		}
	}

	// Token: 0x17001923 RID: 6435
	// (get) Token: 0x06010982 RID: 67970 RVA: 0x004DB104 File Offset: 0x004D9304
	public int MontageConfigDtId
	{
		get
		{
			return (this.IsMotion ? ((this.MotionConfig != null) ? new int?(this.MotionConfig.GetValueOrDefault().MontageConfigDtId) : null) : ((this.ExpressionConfig != null) ? new int?(this.ExpressionConfig.GetValueOrDefault().MontageConfigDtId) : null)).GetValueOrDefault();
		}
	}

	// Token: 0x17001924 RID: 6436
	// (get) Token: 0x06010983 RID: 67971 RVA: 0x004DB17B File Offset: 0x004D937B
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

	// Token: 0x17001925 RID: 6437
	// (get) Token: 0x06010984 RID: 67972 RVA: 0x004DB188 File Offset: 0x004D9388
	public int SortId
	{
		get
		{
			return (this.IsMotion ? ((this.MotionConfig != null) ? new int?(this.MotionConfig.GetValueOrDefault().SortId) : null) : ((this.ExpressionConfig != null) ? new int?(this.ExpressionConfig.GetValueOrDefault().SortId) : null)).GetValueOrDefault();
		}
	}

	// Token: 0x06010985 RID: 67973 RVA: 0x004DB200 File Offset: 0x004D9400
	public int CompareTo(PhotoSelfieItemData other)
	{
		if (this.IsDefault != other.IsDefault)
		{
			if (!this.IsDefault)
			{
				return 1;
			}
			return -1;
		}
		else
		{
			bool flag = PhotoUnlockAnimPlayer.IsUnlockAnimationUnplayed(this.RelativeItem);
			bool flag2 = PhotoUnlockAnimPlayer.IsUnlockAnimationUnplayed(other.RelativeItem);
			if (flag != flag2)
			{
				if (!flag)
				{
					return 1;
				}
				return -1;
			}
			else
			{
				bool flag3 = PhotoUnlockAnimPlayer.IsUnlockByItem(this.RelativeItem);
				bool flag4 = PhotoUnlockAnimPlayer.IsUnlockByItem(other.RelativeItem);
				if (flag3 == flag4)
				{
					return this.SortId.CompareTo(other.SortId);
				}
				if (!flag3)
				{
					return 1;
				}
				return -1;
			}
		}
	}

	// Token: 0x06010986 RID: 67974 RVA: 0x004DB282 File Offset: 0x004D9482
	public static PhotoSelfieItemData FromMotion(PhotoSelfieMontage cfg)
	{
		return new PhotoSelfieItemData
		{
			SubTabType = EPhotoCharacterSubTabType.Motion,
			Id = cfg.Id,
			MotionConfig = new PhotoSelfieMontage?(cfg)
		};
	}

	// Token: 0x06010987 RID: 67975 RVA: 0x004DB2A9 File Offset: 0x004D94A9
	public static PhotoSelfieItemData FromExpression(PhotoExpression cfg)
	{
		return new PhotoSelfieItemData
		{
			SubTabType = EPhotoCharacterSubTabType.Expression,
			Id = cfg.Id,
			ExpressionConfig = new PhotoExpression?(cfg)
		};
	}

	// Token: 0x040092DF RID: 37599
	public int Id;

	// Token: 0x040092E0 RID: 37600
	public EPhotoCharacterSubTabType SubTabType;

	// Token: 0x040092E1 RID: 37601
	public PhotoSelfieMontage? MotionConfig;

	// Token: 0x040092E2 RID: 37602
	public PhotoExpression? ExpressionConfig;
}
