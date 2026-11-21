using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x0200500C RID: 20492
	[NullableContext(1)]
	[Nullable(0)]
	public class SpringManorLoadingView : LoadingViewBase
	{
		// Token: 0x0603348A RID: 210058 RVA: 0x00E6146B File Offset: 0x00E5F66B
		public SpringManorLoadingView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603348B RID: 210059 RVA: 0x00E61480 File Offset: 0x00E5F680
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(USpineSkeletonAnimationComponent)),
				new ValueTuple<int, Type>(3, typeof(USpineSkeletonAnimationComponent)),
				new ValueTuple<int, Type>(4, typeof(USpineSkeletonAnimationComponent)),
				new ValueTuple<int, Type>(5, typeof(USpineSkeletonAnimationComponent)),
				new ValueTuple<int, Type>(6, typeof(UUINiagara))
			};
		}

		// Token: 0x0603348C RID: 210060 RVA: 0x00E61534 File Offset: 0x00E5F734
		protected override void OnStart()
		{
			base.OnStart();
			this.SpineList.Add(new SpineAnimationQueue(base.GetSpine(2)));
			this.SpineList.Add(new SpineAnimationQueue(base.GetSpine(3)));
			this.SpineList.Add(new SpineAnimationQueue(base.GetSpine(4)));
			this.SpineList.Add(new SpineAnimationQueue(base.GetSpine(5)));
			foreach (SpineAnimationQueue spineAnimationQueue in this.SpineList)
			{
				spineAnimationQueue.PushAnimation(0, "start", false);
				spineAnimationQueue.PushAnimation(0, "idle", true);
			}
			this.NiagaraBar = base.GetUiNiagara(6);
		}

		// Token: 0x0603348D RID: 210061 RVA: 0x00E61608 File Offset: 0x00E5F808
		protected override void UpdateProgressRate(float rate)
		{
			UUINiagara niagaraBar = this.NiagaraBar;
			if (niagaraBar == null)
			{
				return;
			}
			niagaraBar.SetNiagaraVarFloat("Dissolve", rate);
		}

		// Token: 0x0603348E RID: 210062 RVA: 0x00E61620 File Offset: 0x00E5F820
		protected override void UpdateShowTipsUi(string title, string tips)
		{
			UUIText text = base.GetText(1);
			if (text == null)
			{
				return;
			}
			text.ShowTextNew(tips);
		}

		// Token: 0x0603348F RID: 210063 RVA: 0x00E61634 File Offset: 0x00E5F834
		protected override void UpdateProgressValue(float value)
		{
		}

		// Token: 0x0401B45A RID: 111706
		private readonly List<SpineAnimationQueue> SpineList = new List<SpineAnimationQueue>();

		// Token: 0x0401B45B RID: 111707
		[Nullable(2)]
		private UUINiagara NiagaraBar;
	}
}
