using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MoonChasing;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Skin.Tab.Motor
{
	// Token: 0x02004BEE RID: 19438
	public class MotorSkinItemContent : UiPanelBase
	{
		// Token: 0x06032439 RID: 205881 RVA: 0x00BAD59A File Offset: 0x00BAB79A
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(USpineSkeletonAnimationComponent))
			};
		}

		// Token: 0x0603243A RID: 205882 RVA: 0x00BAD5D4 File Offset: 0x00BAB7D4
		protected override UniTask OnBeforeStartAsync()
		{
			MotorSkinItemContent.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MotorSkinItemContent.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603243B RID: 205883 RVA: 0x00BAD618 File Offset: 0x00BAB818
		public void Refresh(int recommendId)
		{
			MotorSkinRecommendItem motorSkinRecommendItem = this.MotorSkinRecommendItem;
			if (motorSkinRecommendItem != null)
			{
				motorSkinRecommendItem.Refresh(recommendId);
			}
			MotorSkinRecommendItem motorSkinRecommendItem2 = this.MotorSkinRecommendItem;
			if (motorSkinRecommendItem2 != null)
			{
				motorSkinRecommendItem2.SetActive(true);
			}
			base.GetSpine(1).SetAnimation(0, ESpineAnimation.Idle.ToString(), true);
		}

		// Token: 0x0401ABD2 RID: 109522
		[Nullable(2)]
		private MotorSkinRecommendItem MotorSkinRecommendItem;

		// Token: 0x0200ADE3 RID: 44515
		private enum EContentComponent
		{
			// Token: 0x04034CF8 RID: 216312
			Content,
			// Token: 0x04034CF9 RID: 216313
			SpineTexture
		}
	}
}
