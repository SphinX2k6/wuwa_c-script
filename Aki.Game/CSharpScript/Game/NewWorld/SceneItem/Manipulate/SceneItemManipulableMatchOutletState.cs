using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;

namespace CSharpScript.Game.NewWorld.SceneItem.Manipulate
{
	// Token: 0x020071EB RID: 29163
	public class SceneItemManipulableMatchOutletState : SceneItemManipulableBaseState
	{
		// Token: 0x06047619 RID: 292377 RVA: 0x01228BDB File Offset: 0x01226DDB
		[NullableContext(1)]
		public SceneItemManipulableMatchOutletState(SceneItemManipulatableComponent SceneItem) : base(SceneItem)
		{
		}

		// Token: 0x0604761A RID: 292378 RVA: 0x01228BE4 File Offset: 0x01226DE4
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

		// Token: 0x0604761B RID: 292379 RVA: 0x01228C77 File Offset: 0x01226E77
		protected override void OnExit()
		{
			this.SceneItem.TryRemoveTagById(GameplayTagDefine.EGameplayTagId["关卡.Common.属性.底座中"]);
			base.ClosePhysicsSplit();
			this.PropComp.IsMoving = true;
			this.TryDetachFromOutlet();
		}

		// Token: 0x0604761C RID: 292380 RVA: 0x01228CAC File Offset: 0x01226EAC
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

		// Token: 0x0604761D RID: 292381 RVA: 0x01228D8C File Offset: 0x01226F8C
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
