using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.SceneItem.Manipulate
{
	// Token: 0x020071ED RID: 29165
	internal class SceneItemManipulableResetState : SceneItemManipulableBaseState
	{
		// Token: 0x06047624 RID: 292388 RVA: 0x01229044 File Offset: 0x01227244
		[NullableContext(1)]
		public SceneItemManipulableResetState(SceneItemManipulatableComponent sceneItem) : base(sceneItem)
		{
		}

		// Token: 0x06047625 RID: 292389 RVA: 0x01229050 File Offset: 0x01227250
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

		// Token: 0x06047626 RID: 292390 RVA: 0x012290F1 File Offset: 0x012272F1
		protected override void OnExit()
		{
			base.OnExit();
			this.SceneItem.TryRemoveTagById(GameplayTagDefine.EGameplayTagId["关卡.Common.属性.未被控"]);
			base.ClosePhysicsSplit();
			this.PropComp.IsMoving = true;
		}
	}
}
