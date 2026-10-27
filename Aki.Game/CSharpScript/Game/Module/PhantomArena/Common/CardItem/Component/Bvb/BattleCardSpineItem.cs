using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem.Component.Bvb
{
	// Token: 0x020051FF RID: 20991
	public class BattleCardSpineItem : UiPanelBase
	{
		// Token: 0x06035B31 RID: 219953 RVA: 0x00CB73A4 File Offset: 0x00CB55A4
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(USpineSkeletonAnimationComponent))
			};
		}

		// Token: 0x06035B32 RID: 219954 RVA: 0x00CB73C8 File Offset: 0x00CB55C8
		protected override UniTask OnBeforeStartAsync()
		{
			BattleCardSpineItem.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BattleCardSpineItem.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035B33 RID: 219955 RVA: 0x00CB740C File Offset: 0x00CB560C
		private UniTask RefreshSpine(int configId)
		{
			BattleCardSpineItem.<RefreshSpine>d__4 <RefreshSpine>d__;
			<RefreshSpine>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshSpine>d__.<>4__this = this;
			<RefreshSpine>d__.configId = configId;
			<RefreshSpine>d__.<>1__state = -1;
			<RefreshSpine>d__.<>t__builder.Start<BattleCardSpineItem.<RefreshSpine>d__4>(ref <RefreshSpine>d__);
			return <RefreshSpine>d__.<>t__builder.Task;
		}

		// Token: 0x06035B34 RID: 219956 RVA: 0x00CB7458 File Offset: 0x00CB5658
		public UniTask RefreshSpineById(int configId)
		{
			BattleCardSpineItem.<RefreshSpineById>d__5 <RefreshSpineById>d__;
			<RefreshSpineById>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshSpineById>d__.<>4__this = this;
			<RefreshSpineById>d__.configId = configId;
			<RefreshSpineById>d__.<>1__state = -1;
			<RefreshSpineById>d__.<>t__builder.Start<BattleCardSpineItem.<RefreshSpineById>d__5>(ref <RefreshSpineById>d__);
			return <RefreshSpineById>d__.<>t__builder.Task;
		}

		// Token: 0x06035B35 RID: 219957 RVA: 0x00CB74A4 File Offset: 0x00CB56A4
		[NullableContext(1)]
		public void PlaySpineAnim(string animName, bool isLoop)
		{
			USpineSkeletonAnimationComponent spine = base.GetSpine(0);
			if (spine != null && spine.IsValid())
			{
				UTrackEntry utrackEntry = spine.SetAnimation(0, animName, isLoop);
				if (animName == ECardSpineAnimation.Start.ToString() && utrackEntry != null)
				{
					utrackEntry.AnimationComplete.Add(delegate(UTrackEntry _)
					{
						this.PlaySpineAnim(ECardSpineAnimation.Idle.ToString(), true);
					});
				}
			}
		}

		// Token: 0x06035B36 RID: 219958 RVA: 0x00CB7500 File Offset: 0x00CB5700
		public void SetCardConfigId(int cardConfigId)
		{
			this.CardConfigId = cardConfigId;
		}

		// Token: 0x0401C79B RID: 116635
		protected int CardConfigId;

		// Token: 0x0200B39A RID: 45978
		private static class EBattleCardSpineItem
		{
			// Token: 0x040366F5 RID: 222965
			public const int CardSpine = 0;
		}
	}
}
