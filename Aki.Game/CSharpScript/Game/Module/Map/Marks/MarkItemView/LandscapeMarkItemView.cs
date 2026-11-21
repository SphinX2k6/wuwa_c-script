using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView
{
	// Token: 0x020044E8 RID: 17640
	public class LandscapeMarkItemView : ConfigMarkItemView
	{
		// Token: 0x0602C8A6 RID: 182438 RVA: 0x00C81D64 File Offset: 0x00C7FF64
		[NullableContext(1)]
		public LandscapeMarkItemView(LandscapeMarkItem holder) : base(holder)
		{
		}

		// Token: 0x0602C8A7 RID: 182439 RVA: 0x00C81D6D File Offset: 0x00C7FF6D
		protected override void OnViewRefresh()
		{
			this.DestroyEffect();
			this.LoadEffect();
		}

		// Token: 0x0602C8A8 RID: 182440 RVA: 0x00C81D7C File Offset: 0x00C7FF7C
		public override bool GetInteractiveFlag()
		{
			return false;
		}

		// Token: 0x0602C8A9 RID: 182441 RVA: 0x00C81D80 File Offset: 0x00C7FF80
		private UniTask LoadEffect()
		{
			LandscapeMarkItemView.<LoadEffect>d__4 <LoadEffect>d__;
			<LoadEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadEffect>d__.<>4__this = this;
			<LoadEffect>d__.<>1__state = -1;
			<LoadEffect>d__.<>t__builder.Start<LandscapeMarkItemView.<LoadEffect>d__4>(ref <LoadEffect>d__);
			return <LoadEffect>d__.<>t__builder.Task;
		}

		// Token: 0x0602C8AA RID: 182442 RVA: 0x00C81DC3 File Offset: 0x00C7FFC3
		private void DestroyEffect()
		{
			if (this.Effect != null)
			{
				ULGUIBPLibrary.DestroyActorWithHierarchy(this.Effect.GetOwner(), true);
				this.Effect = null;
			}
		}

		// Token: 0x0602C8AB RID: 182443 RVA: 0x00C81DE5 File Offset: 0x00C7FFE5
		protected override void OnBeforeDestroy()
		{
			this.DestroyEffect();
			base.OnBeforeDestroy();
		}

		// Token: 0x0602C8AC RID: 182444 RVA: 0x00C81DF3 File Offset: 0x00C7FFF3
		public override void SetScale(float scale)
		{
		}

		// Token: 0x04017E92 RID: 97938
		[Nullable(2)]
		private UUIItem Effect;
	}
}
