using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02001A71 RID: 6769
public class PhotographDefine
{
	// Token: 0x040093EF RID: 37871
	public const int DEFAULT_FOV = 60;

	// Token: 0x040093F0 RID: 37872
	public const int MIN_FOV = 30;

	// Token: 0x040093F1 RID: 37873
	public const int MAX_FOV = 90;

	// Token: 0x040093F2 RID: 37874
	public const int MAX_DISTANCE_VALUE = 9999999;

	// Token: 0x040093F3 RID: 37875
	public const int DEFAULT_FILTER_CONFIGID = 1;

	// Token: 0x040093F4 RID: 37876
	public const int FILTER_MIN_STRENGTH = 0;

	// Token: 0x040093F5 RID: 37877
	public const int FILTER_MAX_STREGNTH = 100;

	// Token: 0x040093F6 RID: 37878
	public const int FILTER_DEFAULT_STRENGTH = 100;

	// Token: 0x040093F7 RID: 37879
	public const int DEFAULT_PHOTO_LIGHT_ID = 1;

	// Token: 0x040093F8 RID: 37880
	public const int ENV_TIME_MIN = 0;

	// Token: 0x040093F9 RID: 37881
	public const int ENV_TIME_MAX = 24;

	// Token: 0x040093FA RID: 37882
	public const int DEFAULT_MANUAL_FOCUS_DISTANCE = 300;

	// Token: 0x040093FB RID: 37883
	public const int DEFAULT_FOCAL_LENTGH = 35;

	// Token: 0x040093FC RID: 37884
	public const int DEFAULT_APERTURE = 0;

	// Token: 0x040093FD RID: 37885
	public const int MIN_TOUCH_MOVE_DIFFERENCE = -50000;

	// Token: 0x040093FE RID: 37886
	public const int MAX_TOUCH_MOVE_DIFFERENCE = 50000;

	// Token: 0x040093FF RID: 37887
	public static readonly FName SPAWN_SOCKET_NAME = new FName("CameraPosition");

	// Token: 0x04009400 RID: 37888
	public const float SCREEN_SHOT_TEXTURE_SCALE = 1.5f;

	// Token: 0x04009401 RID: 37889
	public const int MAX_HIGH_RES_MULTIPLIER = 4;

	// Token: 0x04009402 RID: 37890
	public const int MIN_HIGH_RES_MULTIPLIER = 1;

	// Token: 0x04009403 RID: 37891
	public const int MAX_LOD_BIAS = -7;

	// Token: 0x04009404 RID: 37892
	public const int DEFAULT_LOD_BIAS = 0;

	// Token: 0x04009405 RID: 37893
	public const int FIRST_SHARE_DROP_ID = 90005;

	// Token: 0x04009406 RID: 37894
	public const float PHOTOGRAPH_CAMERA_BLEND_OUT = 0.5f;

	// Token: 0x04009407 RID: 37895
	public static readonly FName ignoreTouchTag = new FName("IgnoreTouch");

	// Token: 0x04009408 RID: 37896
	public const int DEFAULT_SHARE_WIDTH = 1750;

	// Token: 0x04009409 RID: 37897
	public const int DEFAULT_SHARE_HEIGHT = 986;

	// Token: 0x0400940A RID: 37898
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
