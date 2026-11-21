using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView
{
	// Token: 0x020044E2 RID: 17634
	public class FloatLightForestMarkItemView : ConfigMarkItemView
	{
		// Token: 0x0602C887 RID: 182407 RVA: 0x00C8186E File Offset: 0x00C7FA6E
		[NullableContext(1)]
		public FloatLightForestMarkItemView(FloatLightForestMarkItem holder) : base(holder)
		{
		}

		// Token: 0x0602C888 RID: 182408 RVA: 0x00C81878 File Offset: 0x00C7FA78
		protected override UniTask OnBeforeStartAsync()
		{
			FloatLightForestMarkItemView.<OnBeforeStartAsync>d__2 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<FloatLightForestMarkItemView.<OnBeforeStartAsync>d__2>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602C889 RID: 182409 RVA: 0x00C818BB File Offset: 0x00C7FABB
		protected override void OnBeforeDestroy()
		{
			this.DestroyEffect();
			base.OnBeforeDestroy();
		}

		// Token: 0x0602C88A RID: 182410 RVA: 0x00C818CC File Offset: 0x00C7FACC
		private UniTask LoadEffect()
		{
			FloatLightForestMarkItemView.<LoadEffect>d__4 <LoadEffect>d__;
			<LoadEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadEffect>d__.<>4__this = this;
			<LoadEffect>d__.<>1__state = -1;
			<LoadEffect>d__.<>t__builder.Start<FloatLightForestMarkItemView.<LoadEffect>d__4>(ref <LoadEffect>d__);
			return <LoadEffect>d__.<>t__builder.Task;
		}

		// Token: 0x0602C88B RID: 182411 RVA: 0x00C8190F File Offset: 0x00C7FB0F
		private void DestroyEffect()
		{
			if (this.Effect != null)
			{
				ULGUIBPLibrary.DestroyActorWithHierarchy(this.Effect.GetOwner(), true);
				this.Effect = null;
			}
		}

		// Token: 0x0602C88C RID: 182412 RVA: 0x00C81931 File Offset: 0x00C7FB31
		public override void SetScale(float scale)
		{
		}

		// Token: 0x0602C88D RID: 182413 RVA: 0x00C81933 File Offset: 0x00C7FB33
		public override bool GetInteractiveFlag()
		{
			return false;
		}

		// Token: 0x04017E8E RID: 97934
		[Nullable(2)]
		private UUIItem Effect;
	}
}
