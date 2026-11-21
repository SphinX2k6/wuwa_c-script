using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.Card;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Area.Functional
{
	// Token: 0x020042A2 RID: 17058
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class PhantomArenaAreaProxyBase
	{
		// Token: 0x170056B6 RID: 22198
		// (get) Token: 0x0602B30F RID: 176911 RVA: 0x00C234B5 File Offset: 0x00C216B5
		// (set) Token: 0x0602B310 RID: 176912 RVA: 0x00C234BD File Offset: 0x00C216BD
		public double Distance { get; set; }

		// Token: 0x170056B7 RID: 22199
		// (get) Token: 0x0602B311 RID: 176913 RVA: 0x00C234C6 File Offset: 0x00C216C6
		// (set) Token: 0x0602B312 RID: 176914 RVA: 0x00C234CE File Offset: 0x00C216CE
		public PhantomArenaAreaItemBase AreaItem { get; set; }

		// Token: 0x0602B313 RID: 176915 RVA: 0x00C234D7 File Offset: 0x00C216D7
		public PhantomArenaAreaProxyBase(int index, PhantomArenaFunctionalArea area)
		{
			this.Distance = 99999.0;
			this.Index = index;
			this.ParentArea = area;
		}

		// Token: 0x0602B314 RID: 176916 RVA: 0x00C2350E File Offset: 0x00C2170E
		protected void SetCardResetPosition(PhantomArenaCard card)
		{
			card.SetUiParent(this.GetCardRootItem(), true);
			card.PlayStateSequence("SeleClose");
		}

		// Token: 0x0602B315 RID: 176917 RVA: 0x00C23528 File Offset: 0x00C21728
		protected void DestroyCard()
		{
			if (this.Card != null)
			{
				Log.Instance.Info(ELogModule.PhantomArena, ELogAuthor.XXJ, "Card Destroy", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.Card.Destroy(null);
				this.Card = null;
			}
		}

		// Token: 0x0602B316 RID: 176918 RVA: 0x00C2356F File Offset: 0x00C2176F
		public void SetAreaItem(PhantomArenaAreaItemBase areaItem)
		{
			this.AreaItem = areaItem;
			this.AreaItem.SetProxy(this);
		}

		// Token: 0x0602B317 RID: 176919 RVA: 0x00C23584 File Offset: 0x00C21784
		[NullableContext(2)]
		public IPhantomCardProxyBase GetCardProxy()
		{
			return this as IPhantomCardProxyBase;
		}

		// Token: 0x0602B318 RID: 176920 RVA: 0x00C2358C File Offset: 0x00C2178C
		[NullableContext(2)]
		public virtual UniTask SetCard(PhantomArenaCard card)
		{
			PhantomArenaAreaProxyBase.<SetCard>d__18 <SetCard>d__;
			<SetCard>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetCard>d__.<>4__this = this;
			<SetCard>d__.card = card;
			<SetCard>d__.<>1__state = -1;
			<SetCard>d__.<>t__builder.Start<PhantomArenaAreaProxyBase.<SetCard>d__18>(ref <SetCard>d__);
			return <SetCard>d__.<>t__builder.Task;
		}

		// Token: 0x0602B319 RID: 176921 RVA: 0x00C235D8 File Offset: 0x00C217D8
		public UniTask ChangeCard(PhantomArenaCard card)
		{
			PhantomArenaAreaProxyBase.<ChangeCard>d__19 <ChangeCard>d__;
			<ChangeCard>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ChangeCard>d__.<>4__this = this;
			<ChangeCard>d__.card = card;
			<ChangeCard>d__.<>1__state = -1;
			<ChangeCard>d__.<>t__builder.Start<PhantomArenaAreaProxyBase.<ChangeCard>d__19>(ref <ChangeCard>d__);
			return <ChangeCard>d__.<>t__builder.Task;
		}

		// Token: 0x0602B31A RID: 176922 RVA: 0x00C23624 File Offset: 0x00C21824
		public UniTask DissolveByLibrary()
		{
			PhantomArenaAreaProxyBase.<DissolveByLibrary>d__20 <DissolveByLibrary>d__;
			<DissolveByLibrary>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<DissolveByLibrary>d__.<>4__this = this;
			<DissolveByLibrary>d__.<>1__state = -1;
			<DissolveByLibrary>d__.<>t__builder.Start<PhantomArenaAreaProxyBase.<DissolveByLibrary>d__20>(ref <DissolveByLibrary>d__);
			return <DissolveByLibrary>d__.<>t__builder.Task;
		}

		// Token: 0x0602B31B RID: 176923 RVA: 0x00C23667 File Offset: 0x00C21867
		public bool IsCanSettingCard(PhantomArenaCard card)
		{
			return this.CheckSettingCardCondition(card) && this.IsCardNearlyAreaItem(card);
		}

		// Token: 0x0602B31C RID: 176924 RVA: 0x00C2367B File Offset: 0x00C2187B
		public void SetHoverStateActive(bool value)
		{
			this.AreaItem.SetHoverStateActive(value);
		}

		// Token: 0x0602B31D RID: 176925 RVA: 0x00C23689 File Offset: 0x00C21889
		public void SetCanUseStateActive(bool value)
		{
			this.AreaItem.SetCanUseStateActive(value);
		}

		// Token: 0x0602B31E RID: 176926 RVA: 0x00C23698 File Offset: 0x00C21898
		[NullableContext(0)]
		public UniTask<bool> HandleCardSetting([Nullable(1)] PhantomArenaCard card)
		{
			PhantomArenaAreaProxyBase.<HandleCardSetting>d__24 <HandleCardSetting>d__;
			<HandleCardSetting>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<HandleCardSetting>d__.<>4__this = this;
			<HandleCardSetting>d__.card = card;
			<HandleCardSetting>d__.<>1__state = -1;
			<HandleCardSetting>d__.<>t__builder.Start<PhantomArenaAreaProxyBase.<HandleCardSetting>d__24>(ref <HandleCardSetting>d__);
			return <HandleCardSetting>d__.<>t__builder.Task;
		}

		// Token: 0x0602B31F RID: 176927 RVA: 0x00C236E3 File Offset: 0x00C218E3
		public void ResetCardSelectState()
		{
			PhantomArenaCard card = this.Card;
			if (card == null)
			{
				return;
			}
			card.SetToggleState(EToggleState.ETT_UnChecked, false);
		}

		// Token: 0x0602B320 RID: 176928 RVA: 0x00C236F8 File Offset: 0x00C218F8
		public bool IsCardNearlyAreaItem(PhantomArenaCard card)
		{
			Vector worldLocation = this.AreaItem.GetWorldLocation();
			Vector worldLocation2 = card.GetWorldLocation();
			this.Distance = Vector.Distance(worldLocation, worldLocation2);
			return this.Distance <= 200.0;
		}

		// Token: 0x0602B321 RID: 176929 RVA: 0x00C23739 File Offset: 0x00C21939
		public EPhantomCardSettingFailReason GetSettingFailReason()
		{
			return this.SettingFailReason;
		}

		// Token: 0x0602B322 RID: 176930 RVA: 0x00C23741 File Offset: 0x00C21941
		public void ResetSettingFailReason()
		{
			this.SettingFailReason = EPhantomCardSettingFailReason.None;
		}

		// Token: 0x0602B323 RID: 176931 RVA: 0x00C2374E File Offset: 0x00C2194E
		public void SetCardSelectedState(bool value)
		{
			PhantomArenaCard card = this.Card;
			if (card == null)
			{
				return;
			}
			card.SetSelectedState(value);
		}

		// Token: 0x0602B324 RID: 176932 RVA: 0x00C23764 File Offset: 0x00C21964
		public UniTask PlayResetPositionTween()
		{
			PhantomArenaAreaProxyBase.<PlayResetPositionTween>d__30 <PlayResetPositionTween>d__;
			<PlayResetPositionTween>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayResetPositionTween>d__.<>4__this = this;
			<PlayResetPositionTween>d__.<>1__state = -1;
			<PlayResetPositionTween>d__.<>t__builder.Start<PhantomArenaAreaProxyBase.<PlayResetPositionTween>d__30>(ref <PlayResetPositionTween>d__);
			return <PlayResetPositionTween>d__.<>t__builder.Task;
		}

		// Token: 0x0602B325 RID: 176933 RVA: 0x00C237A8 File Offset: 0x00C219A8
		public UniTask PlayChangeCardTween(UUIItem fromItem)
		{
			PhantomArenaAreaProxyBase.<PlayChangeCardTween>d__31 <PlayChangeCardTween>d__;
			<PlayChangeCardTween>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayChangeCardTween>d__.<>4__this = this;
			<PlayChangeCardTween>d__.fromItem = fromItem;
			<PlayChangeCardTween>d__.<>1__state = -1;
			<PlayChangeCardTween>d__.<>t__builder.Start<PhantomArenaAreaProxyBase.<PlayChangeCardTween>d__31>(ref <PlayChangeCardTween>d__);
			return <PlayChangeCardTween>d__.<>t__builder.Task;
		}

		// Token: 0x0602B326 RID: 176934 RVA: 0x00C237F4 File Offset: 0x00C219F4
		public UniTask PlaySetCardTween()
		{
			PhantomArenaAreaProxyBase.<PlaySetCardTween>d__32 <PlaySetCardTween>d__;
			<PlaySetCardTween>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlaySetCardTween>d__.<>4__this = this;
			<PlaySetCardTween>d__.<>1__state = -1;
			<PlaySetCardTween>d__.<>t__builder.Start<PhantomArenaAreaProxyBase.<PlaySetCardTween>d__32>(ref <PlaySetCardTween>d__);
			return <PlaySetCardTween>d__.<>t__builder.Task;
		}

		// Token: 0x0602B327 RID: 176935 RVA: 0x00C23838 File Offset: 0x00C21A38
		public UniTask PlayFunctionalCardToFunctionalTopTween(UUIItem toItem, bool needDragUpTween)
		{
			PhantomArenaAreaProxyBase.<PlayFunctionalCardToFunctionalTopTween>d__33 <PlayFunctionalCardToFunctionalTopTween>d__;
			<PlayFunctionalCardToFunctionalTopTween>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayFunctionalCardToFunctionalTopTween>d__.<>4__this = this;
			<PlayFunctionalCardToFunctionalTopTween>d__.toItem = toItem;
			<PlayFunctionalCardToFunctionalTopTween>d__.needDragUpTween = needDragUpTween;
			<PlayFunctionalCardToFunctionalTopTween>d__.<>1__state = -1;
			<PlayFunctionalCardToFunctionalTopTween>d__.<>t__builder.Start<PhantomArenaAreaProxyBase.<PlayFunctionalCardToFunctionalTopTween>d__33>(ref <PlayFunctionalCardToFunctionalTopTween>d__);
			return <PlayFunctionalCardToFunctionalTopTween>d__.<>t__builder.Task;
		}

		// Token: 0x0602B328 RID: 176936 RVA: 0x00C2388C File Offset: 0x00C21A8C
		public UniTask PlayFunctionalCardToRecycleTween()
		{
			PhantomArenaAreaProxyBase.<PlayFunctionalCardToRecycleTween>d__34 <PlayFunctionalCardToRecycleTween>d__;
			<PlayFunctionalCardToRecycleTween>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayFunctionalCardToRecycleTween>d__.<>4__this = this;
			<PlayFunctionalCardToRecycleTween>d__.<>1__state = -1;
			<PlayFunctionalCardToRecycleTween>d__.<>t__builder.Start<PhantomArenaAreaProxyBase.<PlayFunctionalCardToRecycleTween>d__34>(ref <PlayFunctionalCardToRecycleTween>d__);
			return <PlayFunctionalCardToRecycleTween>d__.<>t__builder.Task;
		}

		// Token: 0x0602B329 RID: 176937 RVA: 0x00C238D0 File Offset: 0x00C21AD0
		public UniTask PlayCardToLibraryTween()
		{
			PhantomArenaAreaProxyBase.<PlayCardToLibraryTween>d__35 <PlayCardToLibraryTween>d__;
			<PlayCardToLibraryTween>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayCardToLibraryTween>d__.<>4__this = this;
			<PlayCardToLibraryTween>d__.<>1__state = -1;
			<PlayCardToLibraryTween>d__.<>t__builder.Start<PhantomArenaAreaProxyBase.<PlayCardToLibraryTween>d__35>(ref <PlayCardToLibraryTween>d__);
			return <PlayCardToLibraryTween>d__.<>t__builder.Task;
		}

		// Token: 0x0602B32A RID: 176938 RVA: 0x00C23913 File Offset: 0x00C21B13
		public PhantomArenaAreaItemBase GetAreaItem()
		{
			return this.AreaItem;
		}

		// Token: 0x170056B8 RID: 22200
		// (get) Token: 0x0602B32B RID: 176939
		public abstract EPhantomArenaCardAreaType AreaType { get; }

		// Token: 0x0602B32C RID: 176940
		public abstract bool CheckSettingCardCondition(PhantomArenaCard card);

		// Token: 0x0602B32D RID: 176941
		public abstract bool CheckGuideCondition(PhantomArenaCard card);

		// Token: 0x0602B32E RID: 176942
		[NullableContext(0)]
		protected abstract UniTask<bool> OnHandleCardSetting([Nullable(1)] PhantomArenaCard card);

		// Token: 0x0602B32F RID: 176943
		protected abstract UUIItem GetCardRootItem();

		// Token: 0x04017519 RID: 95513
		public int Index = -1;

		// Token: 0x0401751A RID: 95514
		[Nullable(2)]
		public PhantomArenaCard Card;

		// Token: 0x0401751C RID: 95516
		public PhantomArenaFunctionalArea ParentArea;

		// Token: 0x0401751D RID: 95517
		protected EPhantomCardSettingFailReason SettingFailReason = EPhantomCardSettingFailReason.None;

		// Token: 0x0401751E RID: 95518
		public bool IsInCardTween;
	}
}
