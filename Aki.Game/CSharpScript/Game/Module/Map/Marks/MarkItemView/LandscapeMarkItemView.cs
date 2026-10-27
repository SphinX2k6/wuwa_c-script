using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView
{
	// Token: 0x02005515 RID: 21781
	public class LandscapeMarkItemView : ConfigMarkItemView
	{
		// Token: 0x060379D8 RID: 227800 RVA: 0x00D33EA4 File Offset: 0x00D320A4
		[NullableContext(1)]
		public LandscapeMarkItemView(LandscapeMarkItem holder) : base(holder)
		{
		}

		// Token: 0x060379D9 RID: 227801 RVA: 0x00D33EAD File Offset: 0x00D320AD
		protected override void OnViewRefresh()
		{
			this.DestroyEffect();
			this.LoadEffect();
		}

		// Token: 0x060379DA RID: 227802 RVA: 0x00D33EBC File Offset: 0x00D320BC
		public override bool GetInteractiveFlag()
		{
			return false;
		}

		// Token: 0x060379DB RID: 227803 RVA: 0x00D33EC0 File Offset: 0x00D320C0
		private UniTask LoadEffect()
		{
			LandscapeMarkItemView.<LoadEffect>d__4 <LoadEffect>d__;
			<LoadEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadEffect>d__.<>4__this = this;
			<LoadEffect>d__.<>1__state = -1;
			<LoadEffect>d__.<>t__builder.Start<LandscapeMarkItemView.<LoadEffect>d__4>(ref <LoadEffect>d__);
			return <LoadEffect>d__.<>t__builder.Task;
		}

		// Token: 0x060379DC RID: 227804 RVA: 0x00D33F03 File Offset: 0x00D32103
		private void DestroyEffect()
		{
			if (this.Effect != null)
			{
				ULGUIBPLibrary.DestroyActorWithHierarchy(this.Effect.GetOwner(), true);
				this.Effect = null;
			}
		}

		// Token: 0x060379DD RID: 227805 RVA: 0x00D33F25 File Offset: 0x00D32125
		protected override void OnBeforeDestroy()
		{
			this.DestroyEffect();
			base.OnBeforeDestroy();
		}

		// Token: 0x060379DE RID: 227806 RVA: 0x00D33F33 File Offset: 0x00D32133
		public override void SetScale(float scale)
		{
		}

		// Token: 0x0401D40E RID: 119822
		[Nullable(2)]
		private UUIItem Effect;
	}
}
