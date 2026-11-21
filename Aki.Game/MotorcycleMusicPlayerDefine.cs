using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200179C RID: 6044
public class MotorcycleMusicPlayerDefine : IStaticVariableResetter
{
	// Token: 0x0600EB85 RID: 60293 RVA: 0x00452362 File Offset: 0x00450562
	static MotorcycleMusicPlayerDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MotorcycleMusicPlayerDefine.CreateStaticDefaultValue), new Action(MotorcycleMusicPlayerDefine.ResetStaticDefaultValue));
	}

	// Token: 0x0600EB86 RID: 60294 RVA: 0x00452384 File Offset: 0x00450584
	public static void CreateStaticDefaultValue()
	{
		MotorcycleMusicPlayerDefine.motorMusicPlayModeIcon = new Dictionary<EMotorMusicPlayMode, string>
		{
			{
				EMotorMusicPlayMode.Order,
				"SP_BtnPlayerFuncSequential"
			},
			{
				EMotorMusicPlayMode.Random,
				"SP_BtnPlayerFuncRandom"
			},
			{
				EMotorMusicPlayMode.Repeat,
				"SP_BtnPlayerFuncSingle"
			}
		};
		MotorcycleMusicPlayerDefine.motorPlayModeName = new Dictionary<EMotorMusicPlayMode, string>
		{
			{
				EMotorMusicPlayMode.Order,
				"MotorMusicTips04"
			},
			{
				EMotorMusicPlayMode.Random,
				"MotorMusicTips03"
			},
			{
				EMotorMusicPlayMode.Repeat,
				"MotorMusicTips02"
			}
		};
	}

	// Token: 0x0600EB87 RID: 60295 RVA: 0x004523ED File Offset: 0x004505ED
	public static void ResetStaticDefaultValue()
	{
		MotorcycleMusicPlayerDefine.motorMusicPlayModeIcon = null;
		MotorcycleMusicPlayerDefine.motorPlayModeName = null;
	}

	// Token: 0x040085A0 RID: 34208
	[Nullable(1)]
	public static Dictionary<EMotorMusicPlayMode, string> motorMusicPlayModeIcon;

	// Token: 0x040085A1 RID: 34209
	[Nullable(1)]
	public static Dictionary<EMotorMusicPlayMode, string> motorPlayModeName;
}
