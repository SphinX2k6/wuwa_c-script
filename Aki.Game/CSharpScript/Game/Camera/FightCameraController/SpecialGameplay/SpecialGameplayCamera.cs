using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Camera.FightCameraController.SpecialGameplay
{
	// Token: 0x020072EE RID: 29422
	public class SpecialGameplayCamera : IStaticVariableResetter
	{
		// Token: 0x06048345 RID: 295749 RVA: 0x0128C75A File Offset: 0x0128A95A
		static SpecialGameplayCamera()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SpecialGameplayCamera.CreateStaticDefaultValue), new Action(SpecialGameplayCamera.ResetStaticDefaultValue));
		}

		// Token: 0x06048346 RID: 295750 RVA: 0x0128C77C File Offset: 0x0128A97C
		public static void CreateStaticDefaultValue()
		{
			SpecialGameplayCamera.GameplayMap = new Dictionary<int, Func<ISpecialGameplayCamera>>();
			SpecialGameplayCamera.GameplayMap.Add(0, () => new AiShengGuYangCamera());
			SpecialGameplayCamera.GameplayMap.Add(1, () => new PilotThrowCamera());
			SpecialGameplayCamera.GameplayMap.Add(2, () => new RhythmGameCamera());
			SpecialGameplayCamera.GameplayMap.Add(3, () => new ZoneFollowCamera());
			SpecialGameplayCamera.GameplayMap.Add(4, () => new PhotoCamera());
		}

		// Token: 0x06048347 RID: 295751 RVA: 0x0128C865 File Offset: 0x0128AA65
		public static void ResetStaticDefaultValue()
		{
			SpecialGameplayCamera.GameplayMap = null;
		}

		// Token: 0x0402624C RID: 156236
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public static Dictionary<int, Func<ISpecialGameplayCamera>> GameplayMap;
	}
}
