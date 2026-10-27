using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect.Scene;
using UnrealEngine;

namespace CSharpScript.Game.Render.Effect.PostProcess
{
	// Token: 0x020045F2 RID: 17906
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneEffectStateManager : Singleton
	{
		// Token: 0x0602E2F6 RID: 189174 RVA: 0x00AAD778 File Offset: 0x00AAB978
		public SceneEffectStatePostVolume_C GetPostProcessVolume()
		{
			if (this.PostProcessVolume == null)
			{
				this.PostProcessVolume = (ActorSystem.Instance.Get(SceneEffectStatePostVolume_C.StaticClass(), new FTransformDouble(), null, true) as SceneEffectStatePostVolume_C);
			}
			return this.PostProcessVolume;
		}

		// Token: 0x0602E2F7 RID: 189175 RVA: 0x00AAD7A9 File Offset: 0x00AAB9A9
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

		// Token: 0x0602E2F8 RID: 189176 RVA: 0x00AAD7C2 File Offset: 0x00AAB9C2
		public void SetAirWall(float value)
		{
			SceneEffectStatePostVolume_C postProcessVolume = this.GetPostProcessVolume();
			if (postProcessVolume == null || !postProcessVolume.IsValid())
			{
				return;
			}
			this.GetPostProcessVolume().SetAirWall(value);
		}

		// Token: 0x0602E2F9 RID: 189177 RVA: 0x00AAD7E8 File Offset: 0x00AAB9E8
		public void SetToxicFog(float value)
		{
			SceneEffectStatePostVolume_C postProcessVolume = this.GetPostProcessVolume();
			if (postProcessVolume == null || !postProcessVolume.IsValid())
			{
				return;
			}
			this.GetPostProcessVolume().SetToxicFog(value);
		}

		// Token: 0x170075B0 RID: 30128
		// (get) Token: 0x0602E2FA RID: 189178 RVA: 0x00AAD80E File Offset: 0x00AABA0E
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

		// Token: 0x0602E2FB RID: 189179 RVA: 0x00AAD831 File Offset: 0x00AABA31
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602E2FC RID: 189180 RVA: 0x00AAD833 File Offset: 0x00AABA33
		public static void ResetStaticDefaultValue()
		{
			SceneEffectStateManager instance = SceneEffectStateManager._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			SceneEffectStateManager._instance = null;
		}

		// Token: 0x0602E2FD RID: 189181 RVA: 0x00AAD84C File Offset: 0x00AABA4C
		static SceneEffectStateManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SceneEffectStateManager.CreateStaticDefaultValue), new Action(SceneEffectStateManager.ResetStaticDefaultValue));
		}

		// Token: 0x04018C82 RID: 101506
		[Nullable(2)]
		public SceneEffectStatePostVolume_C PostProcessVolume;

		// Token: 0x04018C83 RID: 101507
		[Nullable(2)]
		private static SceneEffectStateManager _instance;
	}
}
