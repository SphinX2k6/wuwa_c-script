using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;

namespace CSharpScript.Game.NewWorld.SceneItem.Manipulate
{
	// Token: 0x020062A0 RID: 25248
	public class SceneItemManipulableMatchOutletState : SceneItemManipulableBaseState
	{
		// Token: 0x0603CF1B RID: 249627 RVA: 0x01182A2C File Offset: 0x01180C2C
		[NullableContext(1)]
		public SceneItemManipulableMatchOutletState(SceneItemManipulatableComponent SceneItem) : base(SceneItem)
		{
		}

		// Token: 0x0603CF1C RID: 249628 RVA: 0x01182A38 File Offset: 0x01180C38
		protected override void OnEnter()
		{
			this.SceneItem.ClearCastDestroyTimer();
			this.SceneItem.TryAddTagById(GameplayTagDefine.EGameplayTagId["关卡.Common.属性.底座中"]);
			if (!FNameUtil.IsNothing(this.SceneItem.ManipulateBaseConfig.待机状态碰撞预设))
			{
				this.SceneItem.ActorComp.GetPrimitiveComponent().SetCollisionProfileName(this.SceneItem.ManipulateBaseConfig.待机状态碰撞预设, true);
			}
			this.SceneItem.IsCanBeHeld = true;
			base.OpenPhysicsSplit();
			this.PropComp.IsMoving = false;
			this.TryAttachToOutlet();
		}

		// Token: 0x0603CF1D RID: 249629 RVA: 0x01182ACB File Offset: 0x01180CCB
		protected override void OnExit()
		{
			this.SceneItem.TryRemoveTagById(GameplayTagDefine.EGameplayTagId["关卡.Common.属性.底座中"]);
			base.ClosePhysicsSplit();
			this.PropComp.IsMoving = true;
			this.TryDetachFromOutlet();
		}

		// Token: 0x0603CF1E RID: 249630 RVA: 0x01182B00 File Offset: 0x01180D00
		private void TryAttachToOutlet()
		{
			SceneItemDynamicAttachTargetComponent component = this.SceneItem.Entity.GetComponent<SceneItemDynamicAttachTargetComponent>();
			SceneItemOutletComponent activatedOutlet = this.SceneItem.ActivatedOutlet;
			if (component == null || activatedOutlet == null || !activatedOutlet.GetIsNeedAttach())
			{
				return;
			}
			Vector socketLocationOffset = activatedOutlet.GetSocketLocationOffset(this.SceneItem.Entity);
			Vector matchSequenceOffset = activatedOutlet.GetMatchSequenceOffset(this.SceneItem.Entity);
			SceneItemDynamicAttachTargetComponent.AttachParam attachParam = new SceneItemDynamicAttachTargetComponent.AttachParam();
			attachParam.PosAttachType = SceneItemDynamicAttachTargetComponent.EAttachType.UseZeroRelativeTransform;
			attachParam.PosAttachOffset = socketLocationOffset.Addition(matchSequenceOffset, Vector.Create());
			attachParam.PosAbsolute = false;
			attachParam.RotAttachType = SceneItemDynamicAttachTargetComponent.EAttachType.UseZeroRelativeTransform;
			attachParam.RotAttachOffset = activatedOutlet.GetSocketRotatorOffset(this.SceneItem.Entity);
			attachParam.RotAbsolute = false;
			component.RegEntityTarget(activatedOutlet.Entity.GetComponent<CreatureDataComponent>().GetPbDataId(), activatedOutlet.GetSocketName(this.SceneItem.Entity), attachParam, "[MatchOutletState] TryAttachToOutlet");
		}

		// Token: 0x0603CF1F RID: 249631 RVA: 0x01182BE0 File Offset: 0x01180DE0
		private void TryDetachFromOutlet()
		{
			SceneItemDynamicAttachTargetComponent component = this.SceneItem.Entity.GetComponent<SceneItemDynamicAttachTargetComponent>();
			if (component == null)
			{
				return;
			}
			component.UnRegTarget("[MatchOutletState] TryDetachFromOutlet");
		}
	}
}
