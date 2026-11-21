using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000728 RID: 1832
public class FightPhotoDefine
{
	// Token: 0x04003B08 RID: 15112
	public const int DEFAULT_FIGHT_PHOTO_FILTER_ID = 1;

	// Token: 0x04003B09 RID: 15113
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
