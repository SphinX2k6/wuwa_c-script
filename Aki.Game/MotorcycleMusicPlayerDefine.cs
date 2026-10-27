using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020022B8 RID: 8888
public class MotorcycleMusicPlayerDefine : IStaticVariableResetter
{
	// Token: 0x060116ED RID: 71405 RVA: 0x0044570E File Offset: 0x0044390E
	static MotorcycleMusicPlayerDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MotorcycleMusicPlayerDefine.CreateStaticDefaultValue), new Action(MotorcycleMusicPlayerDefine.ResetStaticDefaultValue));
	}

	// Token: 0x060116EE RID: 71406 RVA: 0x00445730 File Offset: 0x00443930
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

	// Token: 0x060116EF RID: 71407 RVA: 0x00445799 File Offset: 0x00443999
	public static void ResetStaticDefaultValue()
	{
		MotorcycleMusicPlayerDefine.motorMusicPlayModeIcon = null;
		MotorcycleMusicPlayerDefine.motorPlayModeName = null;
	}

	// Token: 0x04008462 RID: 33890
	[Nullable(1)]
	public static Dictionary<EMotorMusicPlayMode, string> motorMusicPlayModeIcon;

	// Token: 0x04008463 RID: 33891
	[Nullable(1)]
	public static Dictionary<EMotorMusicPlayMode, string> motorPlayModeName;
}
