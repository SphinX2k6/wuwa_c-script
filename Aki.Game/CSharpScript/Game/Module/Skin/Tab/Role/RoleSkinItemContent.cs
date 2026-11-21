using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MoonChasing;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Skin.Tab.Role
{
	// Token: 0x02003B9B RID: 15259
	public class RoleSkinItemContent : UiPanelBase
	{
		// Token: 0x060271BF RID: 160191 RVA: 0x00AF10D9 File Offset: 0x00AEF2D9
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(USpineSkeletonAnimationComponent))
			};
		}

		// Token: 0x060271C0 RID: 160192 RVA: 0x00AF1114 File Offset: 0x00AEF314
		protected override UniTask OnBeforeStartAsync()
		{
			RoleSkinItemContent.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoleSkinItemContent.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060271C1 RID: 160193 RVA: 0x00AF1158 File Offset: 0x00AEF358
		public void Refresh(int recommendId)
		{
			RoleSkinRecommendItem roleSkinRecommendItem = this.RoleSkinRecommendItem;
			if (roleSkinRecommendItem != null)
			{
				roleSkinRecommendItem.Refresh(recommendId);
			}
			RoleSkinRecommendItem roleSkinRecommendItem2 = this.RoleSkinRecommendItem;
			if (roleSkinRecommendItem2 != null)
			{
				roleSkinRecommendItem2.SetActive(true);
			}
			base.GetSpine(1).SetAnimation(0, ESpineAnimation.Idle.ToString(), true);
		}

		// Token: 0x04015524 RID: 87332
		[Nullable(2)]
		private RoleSkinRecommendItem RoleSkinRecommendItem;

		// Token: 0x020097FC RID: 38908
		private enum EContentComponent
		{
			// Token: 0x0402F680 RID: 194176
			Content,
			// Token: 0x0402F681 RID: 194177
			SpineTexture
		}
	}
}
