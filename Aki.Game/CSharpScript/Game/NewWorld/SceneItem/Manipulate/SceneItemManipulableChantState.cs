using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.Manipulate
{
	// Token: 0x0200629A RID: 25242
	public class SceneItemManipulableChantState : SceneItemManipulableBaseState
	{
		// Token: 0x0603CEDF RID: 249567 RVA: 0x0117FE1C File Offset: 0x0117E01C
		[NullableContext(1)]
		public SceneItemManipulableChantState(SceneItemManipulatableComponent sceneItem, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UCameraShakeBase> cameraShake, FGameplayTag subCameraTag) : base(sceneItem)
		{
			this.CameraShake = new TSubclassOf<UCameraShakeBase>?(cameraShake);
			this.SubCameraTag = new FGameplayTag?(subCameraTag);
		}

		// Token: 0x0603CEE0 RID: 249568 RVA: 0x0117FE3D File Offset: 0x0117E03D
		protected override void OnEnter()
		{
			base.StartCameraShake(this.CameraShake);
			EventSystem.Instance.Emit<FGameplayTag>(EEventName.AddSubCameraTag, this.SubCameraTag.Value);
			this.SceneItem.NeedRemoveControllerId = true;
		}

		// Token: 0x0603CEE1 RID: 249569 RVA: 0x0117FE72 File Offset: 0x0117E072
		protected override void OnExit()
		{
			base.StopCameraShake();
			EventSystem.Instance.Emit<FGameplayTag>(EEventName.RemoveSubCameraTag, this.SubCameraTag.Value);
		}

		// Token: 0x040204D7 RID: 132311
		[Nullable(new byte[]
		{
			0,
			1
		})]
		private readonly TSubclassOf<UCameraShakeBase>? CameraShake;

		// Token: 0x040204D8 RID: 132312
		private readonly FGameplayTag? SubCameraTag;
	}
}
