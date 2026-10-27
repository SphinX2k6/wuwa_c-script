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
	// Token: 0x02004BEA RID: 19434
	public class RoleSkinItemContent : UiPanelBase
	{
		// Token: 0x0603241B RID: 205851 RVA: 0x00BACB59 File Offset: 0x00BAAD59
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(USpineSkeletonAnimationComponent))
			};
		}

		// Token: 0x0603241C RID: 205852 RVA: 0x00BACB94 File Offset: 0x00BAAD94
		protected override UniTask OnBeforeStartAsync()
		{
			RoleSkinItemContent.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoleSkinItemContent.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603241D RID: 205853 RVA: 0x00BACBD8 File Offset: 0x00BAADD8
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

		// Token: 0x0401ABC9 RID: 109513
		[Nullable(2)]
		private RoleSkinRecommendItem RoleSkinRecommendItem;

		// Token: 0x0200ADDD RID: 44509
		private enum EContentComponent
		{
			// Token: 0x04034CD9 RID: 216281
			Content,
			// Token: 0x04034CDA RID: 216282
			SpineTexture
		}
	}
}
