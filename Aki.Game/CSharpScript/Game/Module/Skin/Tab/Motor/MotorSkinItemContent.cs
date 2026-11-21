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
	// Token: 0x02003B9F RID: 15263
	public class MotorSkinItemContent : UiPanelBase
	{
		// Token: 0x060271DD RID: 160221 RVA: 0x00AF1B1A File Offset: 0x00AEFD1A
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(USpineSkeletonAnimationComponent))
			};
		}

		// Token: 0x060271DE RID: 160222 RVA: 0x00AF1B54 File Offset: 0x00AEFD54
		protected override UniTask OnBeforeStartAsync()
		{
			MotorSkinItemContent.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MotorSkinItemContent.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060271DF RID: 160223 RVA: 0x00AF1B98 File Offset: 0x00AEFD98
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

		// Token: 0x0401552D RID: 87341
		[Nullable(2)]
		private MotorSkinRecommendItem MotorSkinRecommendItem;

		// Token: 0x02009802 RID: 38914
		private enum EContentComponent
		{
			// Token: 0x0402F69F RID: 194207
			Content,
			// Token: 0x0402F6A0 RID: 194208
			SpineTexture
		}
	}
}
