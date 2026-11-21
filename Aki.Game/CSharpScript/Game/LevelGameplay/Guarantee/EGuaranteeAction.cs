using System;
using CSharpScript.Core.Common;

namespace CSharpScript.Game.LevelGamePlay.Guarantee
{
	// Token: 0x02005F80 RID: 24448
	[EnumExtensions]
	public enum EGuaranteeAction
	{
		// Token: 0x0401EE71 RID: 126577
		[EnumStringMember("EnablePlayerMoveControl")]
		EnablePlayerMoveControl,
		// Token: 0x0401EE72 RID: 126578
		[EnumStringMember("ExitOrbitalCamera")]
		ExitOrbitalCamera,
		// Token: 0x0401EE73 RID: 126579
		[EnumStringMember("RestorePlayerCameraAdjustment")]
		RestorePlayerCameraAdjustment,
		// Token: 0x0401EE74 RID: 126580
		[EnumStringMember("UnLimitPlayerOperation")]
		UnLimitPlayerOperation,
		// Token: 0x0401EE75 RID: 126581
		[EnumStringMember("ActionBlackScreenFadeOut")]
		ActionBlackScreenFadeOut,
		// Token: 0x0401EE76 RID: 126582
		[EnumStringMember("DisableSplineMoveModel")]
		DisableSplineMoveModel,
		// Token: 0x0401EE77 RID: 126583
		[EnumStringMember("StopEffect")]
		StopEffect,
		// Token: 0x0401EE78 RID: 126584
		[EnumStringMember("Preload")]
		Preload,
		// Token: 0x0401EE79 RID: 126585
		[EnumStringMember("DisableKey4Func")]
		DisableKey4Func,
		// Token: 0x0401EE7A RID: 126586
		[EnumStringMember("ActionExitMovieMode")]
		ActionExitMovieMode,
		// Token: 0x0401EE7B RID: 126587
		[EnumStringMember("StopGamepadShake")]
		StopGamepadShake
	}
}
