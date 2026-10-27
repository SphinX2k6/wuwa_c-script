using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001274 RID: 4724
public class FightPhotoDefine
{
	// Token: 0x04003A70 RID: 14960
	public const int DEFAULT_FIGHT_PHOTO_FILTER_ID = 1;

	// Token: 0x04003A71 RID: 14961
	[Nullable(1)]
	public static readonly Dictionary<EFightPhotoFrameMode, float> fightPhotoFrameModeToActorMode = new Dictionary<EFightPhotoFrameMode, float>
	{
		{
			EFightPhotoFrameMode.None,
			0.1f
		},
		{
			EFightPhotoFrameMode.Mask,
			0.5f
		},
		{
			EFightPhotoFrameMode.Frame,
			0.9f
		}
	};
}
