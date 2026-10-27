using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002586 RID: 9606
public class PhotographDefine
{
	// Token: 0x04009297 RID: 37527
	public const int DEFAULT_FOV = 60;

	// Token: 0x04009298 RID: 37528
	public const int MIN_FOV = 30;

	// Token: 0x04009299 RID: 37529
	public const int MAX_FOV = 90;

	// Token: 0x0400929A RID: 37530
	public const int MAX_DISTANCE_VALUE = 9999999;

	// Token: 0x0400929B RID: 37531
	public const int DEFAULT_FILTER_CONFIGID = 1;

	// Token: 0x0400929C RID: 37532
	public const int FILTER_MIN_STRENGTH = 0;

	// Token: 0x0400929D RID: 37533
	public const int FILTER_MAX_STREGNTH = 100;

	// Token: 0x0400929E RID: 37534
	public const int FILTER_DEFAULT_STRENGTH = 100;

	// Token: 0x0400929F RID: 37535
	public const int DEFAULT_PHOTO_LIGHT_ID = 1;

	// Token: 0x040092A0 RID: 37536
	public const int ENV_TIME_MIN = 0;

	// Token: 0x040092A1 RID: 37537
	public const int ENV_TIME_MAX = 24;

	// Token: 0x040092A2 RID: 37538
	public const int DEFAULT_MANUAL_FOCUS_DISTANCE = 300;

	// Token: 0x040092A3 RID: 37539
	public const int DEFAULT_FOCAL_LENTGH = 35;

	// Token: 0x040092A4 RID: 37540
	public const int DEFAULT_APERTURE = 0;

	// Token: 0x040092A5 RID: 37541
	public const int MIN_TOUCH_MOVE_DIFFERENCE = -50000;

	// Token: 0x040092A6 RID: 37542
	public const int MAX_TOUCH_MOVE_DIFFERENCE = 50000;

	// Token: 0x040092A7 RID: 37543
	public static readonly FName SPAWN_SOCKET_NAME = new FName("HitCase");

	// Token: 0x040092A8 RID: 37544
	public const float SCREEN_SHOT_TEXTURE_SCALE = 1.5f;

	// Token: 0x040092A9 RID: 37545
	public const int MAX_HIGH_RES_MULTIPLIER = 4;

	// Token: 0x040092AA RID: 37546
	public const int MIN_HIGH_RES_MULTIPLIER = 1;

	// Token: 0x040092AB RID: 37547
	public const int MAX_LOD_BIAS = -7;

	// Token: 0x040092AC RID: 37548
	public const int DEFAULT_LOD_BIAS = 0;

	// Token: 0x040092AD RID: 37549
	public const int FIRST_SHARE_DROP_ID = 90005;

	// Token: 0x040092AE RID: 37550
	public const float PHOTOGRAPH_CAMERA_BLEND_OUT = 0.5f;

	// Token: 0x040092AF RID: 37551
	public static readonly FName ignoreTouchTag = new FName("IgnoreTouch");

	// Token: 0x040092B0 RID: 37552
	public const int DEFAULT_SHARE_WIDTH = 1750;

	// Token: 0x040092B1 RID: 37553
	public const int DEFAULT_SHARE_HEIGHT = 986;

	// Token: 0x040092B2 RID: 37554
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	public static readonly Dictionary<EPhotoTabType, Func<PhotoDetailPanelBase>> PhotoTabDetailPanelMap = new Dictionary<EPhotoTabType, Func<PhotoDetailPanelBase>>
	{
		{
			EPhotoTabType.Setting,
			() => new PhotoSettingPanel()
		},
		{
			EPhotoTabType.Filter,
			() => new PhotoFilterPanel()
		},
		{
			EPhotoTabType.Light,
			() => new PhotoLightPanel()
		},
		{
			EPhotoTabType.Environment,
			() => new PhotoEnvironmentPanel()
		},
		{
			EPhotoTabType.Character,
			() => new PhotoCharacterPanel()
		},
		{
			EPhotoTabType.Decoration,
			() => new PhotoDecorationPanel()
		}
	};
}
