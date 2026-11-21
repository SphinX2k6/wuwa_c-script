using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.SceneItem.Manipulate
{
	// Token: 0x020062A2 RID: 25250
	internal class SceneItemManipulableResetState : SceneItemManipulableBaseState
	{
		// Token: 0x0603CF26 RID: 249638 RVA: 0x01182E98 File Offset: 0x01181098
		[NullableContext(1)]
		public SceneItemManipulableResetState(SceneItemManipulatableComponent sceneItem) : base(sceneItem)
		{
		}

		// Token: 0x0603CF27 RID: 249639 RVA: 0x01182EA4 File Offset: 0x011810A4
		protected override void OnEnter()
		{
			base.OnEnter();
			this.SceneItem.TryAddTagById(GameplayTagDefine.EGameplayTagId["关卡.Common.属性.未被控"]);
			if (!FNameUtil.IsNothing(this.SceneItem.ManipulateBaseConfig.待机状态碰撞预设))
			{
				this.SceneItem.ActorComp.GetPrimitiveComponent().SetCollisionProfileName(this.SceneItem.ManipulateBaseConfig.待机状态碰撞预设, true);
			}
			base.OpenPhysicsSplit();
			this.PropComp.IsMoving = false;
			if (this.SceneItem.FinishCheckInitAttach && this.SceneItem.EnableDynamicAttach)
			{
				this.SceneItem.TryReqAttachToFloor();
			}
		}

		// Token: 0x0603CF28 RID: 249640 RVA: 0x01182F45 File Offset: 0x01181145
		protected override void OnExit()
		{
			base.OnExit();
			this.SceneItem.TryRemoveTagById(GameplayTagDefine.EGameplayTagId["关卡.Common.属性.未被控"]);
			base.ClosePhysicsSplit();
			this.PropComp.IsMoving = true;
		}
	}
}
