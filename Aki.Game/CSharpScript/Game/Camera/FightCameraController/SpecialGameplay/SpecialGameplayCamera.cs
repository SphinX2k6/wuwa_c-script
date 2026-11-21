using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Camera.FightCameraController.SpecialGameplay
{
	// Token: 0x02006471 RID: 25713
	public class SpecialGameplayCamera : IStaticVariableResetter
	{
		// Token: 0x0603E791 RID: 255889 RVA: 0x0122F10E File Offset: 0x0122D30E
		static SpecialGameplayCamera()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SpecialGameplayCamera.CreateStaticDefaultValue), new Action(SpecialGameplayCamera.ResetStaticDefaultValue));
		}

		// Token: 0x0603E792 RID: 255890 RVA: 0x0122F130 File Offset: 0x0122D330
		public static void CreateStaticDefaultValue()
		{
			SpecialGameplayCamera.GameplayMap = new Dictionary<int, Func<ISpecialGameplayCamera>>();
			SpecialGameplayCamera.GameplayMap.Add(0, () => new AiShengGuYangCamera());
			SpecialGameplayCamera.GameplayMap.Add(1, () => new PilotThrowCamera());
			SpecialGameplayCamera.GameplayMap.Add(2, () => new RhythmGameCamera());
			SpecialGameplayCamera.GameplayMap.Add(3, () => new ZoneFollowCamera());
			SpecialGameplayCamera.GameplayMap.Add(4, () => new PhotoCamera());
		}

		// Token: 0x0603E793 RID: 255891 RVA: 0x0122F219 File Offset: 0x0122D419
		public static void ResetStaticDefaultValue()
		{
			SpecialGameplayCamera.GameplayMap = null;
		}

		// Token: 0x04021537 RID: 136503
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public static Dictionary<int, Func<ISpecialGameplayCamera>> GameplayMap;
	}
}
