using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.ScreenEffect;
using UnrealEngine;

namespace CSharpScript.Game.Render.Effect.ScreenEffectSystem
{
	// Token: 0x020045F1 RID: 17905
	public class ScreenEffectSystem : IStaticVariableResetter
	{
		// Token: 0x0602E2F1 RID: 189169 RVA: 0x00AAD70A File Offset: 0x00AAB90A
		static ScreenEffectSystem()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ScreenEffectSystem.CreateStaticDefaultValue), new Action(ScreenEffectSystem.ResetStaticDefaultValue));
		}

		// Token: 0x0602E2F2 RID: 189170 RVA: 0x00AAD729 File Offset: 0x00AAB929
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602E2F3 RID: 189171 RVA: 0x00AAD72B File Offset: 0x00AAB92B
		public static void ResetStaticDefaultValue()
		{
			ScreenEffectSystem._instance = null;
		}

		// Token: 0x0602E2F4 RID: 189172 RVA: 0x00AAD733 File Offset: 0x00AAB933
		[NullableContext(1)]
		public static BP_ScreenEffectSystem_C GetInstance()
		{
			BP_ScreenEffectSystem_C instance = ScreenEffectSystem._instance;
			if (instance == null || !instance.IsValid())
			{
				ScreenEffectSystem._instance = (ActorSystem.Instance.Get(BP_ScreenEffectSystem_C.StaticClass(), new FTransformDouble(), null, true) as BP_ScreenEffectSystem_C);
			}
			return ScreenEffectSystem._instance;
		}

		// Token: 0x04018C81 RID: 101505
		[Nullable(2)]
		private static BP_ScreenEffectSystem_C _instance;
	}
}
