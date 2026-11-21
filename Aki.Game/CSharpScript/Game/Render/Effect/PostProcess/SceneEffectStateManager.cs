using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect.Scene;
using UnrealEngine;

namespace CSharpScript.Game.Render.Effect.PostProcess
{
	// Token: 0x0200351B RID: 13595
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneEffectStateManager : Singleton
	{
		// Token: 0x060229EB RID: 141803 RVA: 0x009D9F14 File Offset: 0x009D8114
		public SceneEffectStatePostVolume_C GetPostProcessVolume()
		{
			if (this.PostProcessVolume == null)
			{
				this.PostProcessVolume = (ActorSystem.Instance.Get(SceneEffectStatePostVolume_C.StaticClass(), new FTransformDouble(), null, true) as SceneEffectStatePostVolume_C);
			}
			return this.PostProcessVolume;
		}

		// Token: 0x060229EC RID: 141804 RVA: 0x009D9F45 File Offset: 0x009D8145
		public void SetSceneEffectState(ESceneEffectStateType stateType, float value)
		{
			if (stateType == ESceneEffectStateType.AirWall)
			{
				this.SetAirWall(value);
				return;
			}
			if (stateType != ESceneEffectStateType.ToxicFog)
			{
				return;
			}
			this.SetToxicFog(value);
		}

		// Token: 0x060229ED RID: 141805 RVA: 0x009D9F5E File Offset: 0x009D815E
		public void SetAirWall(float value)
		{
			SceneEffectStatePostVolume_C postProcessVolume = this.GetPostProcessVolume();
			if (postProcessVolume == null || !postProcessVolume.IsValid())
			{
				return;
			}
			this.GetPostProcessVolume().SetAirWall(value);
		}

		// Token: 0x060229EE RID: 141806 RVA: 0x009D9F84 File Offset: 0x009D8184
		public void SetToxicFog(float value)
		{
			SceneEffectStatePostVolume_C postProcessVolume = this.GetPostProcessVolume();
			if (postProcessVolume == null || !postProcessVolume.IsValid())
			{
				return;
			}
			this.GetPostProcessVolume().SetToxicFog(value);
		}

		// Token: 0x17004868 RID: 18536
		// (get) Token: 0x060229EF RID: 141807 RVA: 0x009D9FAA File Offset: 0x009D81AA
		public static SceneEffectStateManager Instance
		{
			get
			{
				if (SceneEffectStateManager._instance == null)
				{
					SceneEffectStateManager._instance = new SceneEffectStateManager();
					SceneEffectStateManager._instance.OnInit();
				}
				return SceneEffectStateManager._instance;
			}
		}

		// Token: 0x060229F0 RID: 141808 RVA: 0x009D9FCD File Offset: 0x009D81CD
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060229F1 RID: 141809 RVA: 0x009D9FCF File Offset: 0x009D81CF
		public static void ResetStaticDefaultValue()
		{
			SceneEffectStateManager instance = SceneEffectStateManager._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			SceneEffectStateManager._instance = null;
		}

		// Token: 0x060229F2 RID: 141810 RVA: 0x009D9FE8 File Offset: 0x009D81E8
		static SceneEffectStateManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SceneEffectStateManager.CreateStaticDefaultValue), new Action(SceneEffectStateManager.ResetStaticDefaultValue));
		}

		// Token: 0x040132C1 RID: 78529
		[Nullable(2)]
		public SceneEffectStatePostVolume_C PostProcessVolume;

		// Token: 0x040132C2 RID: 78530
		[Nullable(2)]
		private static SceneEffectStateManager _instance;
	}
}
