using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.SceneItem.Jigsaw;

namespace CSharpScript.Game.NewWorld.SceneItem.Manipulate
{
	// Token: 0x020071EA RID: 29162
	public class SceneItemManipulableMatchJigsawBaseState : SceneItemManipulableMatchOutletState
	{
		// Token: 0x06047615 RID: 292373 RVA: 0x01228B01 File Offset: 0x01226D01
		[NullableContext(1)]
		public SceneItemManipulableMatchJigsawBaseState(SceneItemManipulatableComponent SceneItem) : base(SceneItem)
		{
		}

		// Token: 0x06047616 RID: 292374 RVA: 0x01228B0C File Offset: 0x01226D0C
		protected override void OnEnter()
		{
			this.SceneItem.TryAddTagById(this.GetIsCorrect() ? GameplayTagDefine.EGameplayTagId["关卡.Common.属性.底座中.正确"] : GameplayTagDefine.EGameplayTagId["关卡.Common.属性.底座中.错误"]);
			this.SceneItem.IsCanBeHeld = true;
			base.OpenPhysicsSplit();
		}

		// Token: 0x06047617 RID: 292375 RVA: 0x01228B5E File Offset: 0x01226D5E
		protected override void OnExit()
		{
			this.SceneItem.TryRemoveTagById(GameplayTagDefine.EGameplayTagId["关卡.Common.属性.底座中.正确"]);
			this.SceneItem.TryRemoveTagById(GameplayTagDefine.EGameplayTagId["关卡.Common.属性.底座中.错误"]);
			base.ClosePhysicsSplit();
		}

		// Token: 0x06047618 RID: 292376 RVA: 0x01228B9C File Offset: 0x01226D9C
		private bool GetIsCorrect()
		{
			SceneItemJigsawItemComponent component = this.SceneItem.Entity.GetComponent<SceneItemJigsawItemComponent>();
			return this.SceneItem.ActivatedOutlet.GetIsCorrect(this.SceneItem.Entity, component.PutDownIndex);
		}
	}
}
