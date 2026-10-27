using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.Manipulate
{
	// Token: 0x020071E5 RID: 29157
	public class SceneItemManipulableChantState : SceneItemManipulableBaseState
	{
		// Token: 0x060475DD RID: 292317 RVA: 0x01225FE4 File Offset: 0x012241E4
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

		// Token: 0x060475DE RID: 292318 RVA: 0x01226005 File Offset: 0x01224205
		protected override void OnEnter()
		{
			base.StartCameraShake(this.CameraShake);
			EventSystem.Instance.Emit<FGameplayTag>(EEventName.AddSubCameraTag, this.SubCameraTag.Value);
			this.SceneItem.NeedRemoveControllerId = true;
		}

		// Token: 0x060475DF RID: 292319 RVA: 0x0122603A File Offset: 0x0122423A
		protected override void OnExit()
		{
			base.StopCameraShake();
			EventSystem.Instance.Emit<FGameplayTag>(EEventName.RemoveSubCameraTag, this.SubCameraTag.Value);
		}

		// Token: 0x04025868 RID: 153704
		[Nullable(new byte[]
		{
			0,
			1
		})]
		private readonly TSubclassOf<UCameraShakeBase>? CameraShake;

		// Token: 0x04025869 RID: 153705
		private readonly FGameplayTag? SubCameraTag;
	}
}
