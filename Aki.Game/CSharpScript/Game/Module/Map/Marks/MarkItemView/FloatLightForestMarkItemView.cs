using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView
{
	// Token: 0x0200550F RID: 21775
	public class FloatLightForestMarkItemView : ConfigMarkItemView
	{
		// Token: 0x060379B9 RID: 227769 RVA: 0x00D33991 File Offset: 0x00D31B91
		[NullableContext(1)]
		public FloatLightForestMarkItemView(FloatLightForestMarkItem holder) : base(holder)
		{
		}

		// Token: 0x060379BA RID: 227770 RVA: 0x00D3399C File Offset: 0x00D31B9C
		protected override UniTask OnBeforeStartAsync()
		{
			FloatLightForestMarkItemView.<OnBeforeStartAsync>d__2 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<FloatLightForestMarkItemView.<OnBeforeStartAsync>d__2>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060379BB RID: 227771 RVA: 0x00D339DF File Offset: 0x00D31BDF
		protected override void OnBeforeDestroy()
		{
			this.DestroyEffect();
			base.OnBeforeDestroy();
		}

		// Token: 0x060379BC RID: 227772 RVA: 0x00D339F0 File Offset: 0x00D31BF0
		private UniTask LoadEffect()
		{
			FloatLightForestMarkItemView.<LoadEffect>d__4 <LoadEffect>d__;
			<LoadEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadEffect>d__.<>4__this = this;
			<LoadEffect>d__.<>1__state = -1;
			<LoadEffect>d__.<>t__builder.Start<FloatLightForestMarkItemView.<LoadEffect>d__4>(ref <LoadEffect>d__);
			return <LoadEffect>d__.<>t__builder.Task;
		}

		// Token: 0x060379BD RID: 227773 RVA: 0x00D33A33 File Offset: 0x00D31C33
		private void DestroyEffect()
		{
			if (this.Effect != null)
			{
				ULGUIBPLibrary.DestroyActorWithHierarchy(this.Effect.GetOwner(), true);
				this.Effect = null;
			}
		}

		// Token: 0x060379BE RID: 227774 RVA: 0x00D33A55 File Offset: 0x00D31C55
		public override void SetScale(float scale)
		{
		}

		// Token: 0x060379BF RID: 227775 RVA: 0x00D33A57 File Offset: 0x00D31C57
		public override bool GetInteractiveFlag()
		{
			return false;
		}

		// Token: 0x0401D40A RID: 119818
		[Nullable(2)]
		private UUIItem Effect;
	}
}
