using System;
using CSharpScript.Core.Common;

namespace CSharpScript.Game.LevelGamePlay.Guarantee
{
	// Token: 0x02006E01 RID: 28161
	[EnumExtensions]
	public enum EGuaranteeAction
	{
		// Token: 0x04023BCE RID: 146382
		[EnumStringMember("EnablePlayerMoveControl")]
		EnablePlayerMoveControl,
		// Token: 0x04023BCF RID: 146383
		[EnumStringMember("ExitOrbitalCamera")]
		ExitOrbitalCamera,
		// Token: 0x04023BD0 RID: 146384
		[EnumStringMember("RestorePlayerCameraAdjustment")]
		RestorePlayerCameraAdjustment,
		// Token: 0x04023BD1 RID: 146385
		[EnumStringMember("UnLimitPlayerOperation")]
		UnLimitPlayerOperation,
		// Token: 0x04023BD2 RID: 146386
		[EnumStringMember("ActionBlackScreenFadeOut")]
		ActionBlackScreenFadeOut,
		// Token: 0x04023BD3 RID: 146387
		[EnumStringMember("DisableSplineMoveModel")]
		DisableSplineMoveModel,
		// Token: 0x04023BD4 RID: 146388
		[EnumStringMember("StopEffect")]
		StopEffect,
		// Token: 0x04023BD5 RID: 146389
		[EnumStringMember("Preload")]
		Preload,
		// Token: 0x04023BD6 RID: 146390
		[EnumStringMember("DisableKey4Func")]
		DisableKey4Func,
		// Token: 0x04023BD7 RID: 146391
		[EnumStringMember("ActionExitMovieMode")]
		ActionExitMovieMode,
		// Token: 0x04023BD8 RID: 146392
		[EnumStringMember("StopGamepadShake")]
		StopGamepadShake
	}
}
