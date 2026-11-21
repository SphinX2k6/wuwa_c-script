using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.ScreenEffect;
using UnrealEngine;

namespace CSharpScript.Game.Render.Effect.ScreenEffectSystem
{
	// Token: 0x0200351A RID: 13594
	public class ScreenEffectSystem : IStaticVariableResetter
	{
		// Token: 0x060229E6 RID: 141798 RVA: 0x009D9EA6 File Offset: 0x009D80A6
		static ScreenEffectSystem()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ScreenEffectSystem.CreateStaticDefaultValue), new Action(ScreenEffectSystem.ResetStaticDefaultValue));
		}

		// Token: 0x060229E7 RID: 141799 RVA: 0x009D9EC5 File Offset: 0x009D80C5
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060229E8 RID: 141800 RVA: 0x009D9EC7 File Offset: 0x009D80C7
		public static void ResetStaticDefaultValue()
		{
			ScreenEffectSystem._instance = null;
		}

		// Token: 0x060229E9 RID: 141801 RVA: 0x009D9ECF File Offset: 0x009D80CF
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

		// Token: 0x040132C0 RID: 78528
		[Nullable(2)]
		private static BP_ScreenEffectSystem_C _instance;
	}
}
