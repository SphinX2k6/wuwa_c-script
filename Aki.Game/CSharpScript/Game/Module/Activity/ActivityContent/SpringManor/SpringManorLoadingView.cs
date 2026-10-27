using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x0200608E RID: 24718
	[NullableContext(1)]
	[Nullable(0)]
	public class SpringManorLoadingView : LoadingViewBase
	{
		// Token: 0x0603E7C6 RID: 255942 RVA: 0x00F1A6A7 File Offset: 0x00F188A7
		public SpringManorLoadingView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603E7C7 RID: 255943 RVA: 0x00F1A6BC File Offset: 0x00F188BC
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

		// Token: 0x0603E7C8 RID: 255944 RVA: 0x00F1A770 File Offset: 0x00F18970
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

		// Token: 0x0603E7C9 RID: 255945 RVA: 0x00F1A844 File Offset: 0x00F18A44
		protected override void UpdateProgressRate(float rate)
		{
			UUINiagara niagaraBar = this.NiagaraBar;
			if (niagaraBar == null)
			{
				return;
			}
			niagaraBar.SetNiagaraVarFloat("Dissolve", rate);
		}

		// Token: 0x0603E7CA RID: 255946 RVA: 0x00F1A85C File Offset: 0x00F18A5C
		protected override void UpdateShowTipsUi(string title, string tips)
		{
			UUIText text = base.GetText(1);
			if (text == null)
			{
				return;
			}
			text.ShowTextNew(tips);
		}

		// Token: 0x0603E7CB RID: 255947 RVA: 0x00F1A870 File Offset: 0x00F18A70
		protected override void UpdateProgressValue(float value)
		{
		}

		// Token: 0x04020B2D RID: 133933
		private readonly List<SpineAnimationQueue> SpineList = new List<SpineAnimationQueue>();

		// Token: 0x04020B2E RID: 133934
		[Nullable(2)]
		private UUINiagara NiagaraBar;
	}
}
