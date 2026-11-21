using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.SceneItem.Jigsaw;

namespace CSharpScript.Game.NewWorld.SceneItem.Manipulate
{
	// Token: 0x0200629F RID: 25247
	public class SceneItemManipulableMatchJigsawBaseState : SceneItemManipulableMatchOutletState
	{
		// Token: 0x0603CF17 RID: 249623 RVA: 0x01182939 File Offset: 0x01180B39
		[NullableContext(1)]
		public SceneItemManipulableMatchJigsawBaseState(SceneItemManipulatableComponent SceneItem) : base(SceneItem)
		{
		}

		// Token: 0x0603CF18 RID: 249624 RVA: 0x01182944 File Offset: 0x01180B44
		protected override void OnEnter()
		{
			this.SceneItem.TryAddTagById(this.GetIsCorrect() ? GameplayTagDefine.EGameplayTagId["关卡.Common.属性.底座中.正确"] : GameplayTagDefine.EGameplayTagId["关卡.Common.属性.底座中.错误"]);
			this.SceneItem.IsCanBeHeld = true;
			base.OpenPhysicsSplit();
		}

		// Token: 0x0603CF19 RID: 249625 RVA: 0x01182996 File Offset: 0x01180B96
		protected override void OnExit()
		{
			this.SceneItem.TryRemoveTagById(GameplayTagDefine.EGameplayTagId["关卡.Common.属性.底座中.正确"]);
			this.SceneItem.TryRemoveTagById(GameplayTagDefine.EGameplayTagId["关卡.Common.属性.底座中.错误"]);
			base.ClosePhysicsSplit();
		}

		// Token: 0x0603CF1A RID: 249626 RVA: 0x011829D4 File Offset: 0x01180BD4
		private bool GetIsCorrect()
		{
			SceneItemJigsawItemComponent component = this.SceneItem.Entity.GetComponent<SceneItemJigsawItemComponent>();
			SceneItemJigsawBaseComponent putDownBase = component.PutDownBase;
			JigsawIndex index = (putDownBase != null && putDownBase.Valid) ? component.PutDownIndex : null;
			return this.SceneItem.ActivatedOutlet.GetIsCorrect(this.SceneItem.Entity, index);
		}
	}
}
