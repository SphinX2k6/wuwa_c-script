using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.Card;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Area.Functional
{
	// Token: 0x020052D2 RID: 21202
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class PhantomArenaAreaProxyBase
	{
		// Token: 0x170082F6 RID: 33526
		// (get) Token: 0x06036414 RID: 222228 RVA: 0x00CD5D8D File Offset: 0x00CD3F8D
		// (set) Token: 0x06036415 RID: 222229 RVA: 0x00CD5D95 File Offset: 0x00CD3F95
		public double Distance { get; set; }

		// Token: 0x170082F7 RID: 33527
		// (get) Token: 0x06036416 RID: 222230 RVA: 0x00CD5D9E File Offset: 0x00CD3F9E
		// (set) Token: 0x06036417 RID: 222231 RVA: 0x00CD5DA6 File Offset: 0x00CD3FA6
		public PhantomArenaAreaItemBase AreaItem { get; set; }

		// Token: 0x06036418 RID: 222232 RVA: 0x00CD5DAF File Offset: 0x00CD3FAF
		public PhantomArenaAreaProxyBase(int index, PhantomArenaFunctionalArea area)
		{
			this.Distance = 99999.0;
			this.Index = index;
			this.ParentArea = area;
		}

		// Token: 0x06036419 RID: 222233 RVA: 0x00CD5DE6 File Offset: 0x00CD3FE6
		protected void SetCardResetPosition(PhantomArenaCard card)
		{
			card.SetUiParent(this.GetCardRootItem(), true);
			card.PlayStateSequence("SeleClose");
		}

		// Token: 0x0603641A RID: 222234 RVA: 0x00CD5E00 File Offset: 0x00CD4000
		protected void DestroyCard()
		{
			if (this.Card != null)
			{
				Log.Instance.Info(ELogModule.PhantomArena, ELogAuthor.XXJ, "Card Destroy", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.Card.Destroy(null);
				this.Card = null;
			}
		}

		// Token: 0x0603641B RID: 222235 RVA: 0x00CD5E47 File Offset: 0x00CD4047
		public void SetAreaItem(PhantomArenaAreaItemBase areaItem)
		{
			this.AreaItem = areaItem;
			this.AreaItem.SetProxy(this);
		}

		// Token: 0x0603641C RID: 222236 RVA: 0x00CD5E5C File Offset: 0x00CD405C
		[NullableContext(2)]
		public IPhantomCardProxyBase GetCardProxy()
		{
			return this as IPhantomCardProxyBase;
		}

		// Token: 0x0603641D RID: 222237 RVA: 0x00CD5E64 File Offset: 0x00CD4064
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

		// Token: 0x0603641E RID: 222238 RVA: 0x00CD5EB0 File Offset: 0x00CD40B0
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

		// Token: 0x0603641F RID: 222239 RVA: 0x00CD5EFC File Offset: 0x00CD40FC
		public UniTask DissolveByLibrary()
		{
			PhantomArenaAreaProxyBase.<DissolveByLibrary>d__20 <DissolveByLibrary>d__;
			<DissolveByLibrary>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<DissolveByLibrary>d__.<>4__this = this;
			<DissolveByLibrary>d__.<>1__state = -1;
			<DissolveByLibrary>d__.<>t__builder.Start<PhantomArenaAreaProxyBase.<DissolveByLibrary>d__20>(ref <DissolveByLibrary>d__);
			return <DissolveByLibrary>d__.<>t__builder.Task;
		}

		// Token: 0x06036420 RID: 222240 RVA: 0x00CD5F3F File Offset: 0x00CD413F
		public bool IsCanSettingCard(PhantomArenaCard card)
		{
			return this.CheckSettingCardCondition(card) && this.IsCardNearlyAreaItem(card);
		}

		// Token: 0x06036421 RID: 222241 RVA: 0x00CD5F53 File Offset: 0x00CD4153
		public void SetHoverStateActive(bool value)
		{
			this.AreaItem.SetHoverStateActive(value);
		}

		// Token: 0x06036422 RID: 222242 RVA: 0x00CD5F61 File Offset: 0x00CD4161
		public void SetCanUseStateActive(bool value)
		{
			this.AreaItem.SetCanUseStateActive(value);
		}

		// Token: 0x06036423 RID: 222243 RVA: 0x00CD5F70 File Offset: 0x00CD4170
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

		// Token: 0x06036424 RID: 222244 RVA: 0x00CD5FBB File Offset: 0x00CD41BB
		public void ResetCardSelectState()
		{
			PhantomArenaCard card = this.Card;
			if (card == null)
			{
				return;
			}
			card.SetToggleState(EToggleState.ETT_UnChecked, false);
		}

		// Token: 0x06036425 RID: 222245 RVA: 0x00CD5FD0 File Offset: 0x00CD41D0
		public bool IsCardNearlyAreaItem(PhantomArenaCard card)
		{
			Vector worldLocation = this.AreaItem.GetWorldLocation();
			Vector worldLocation2 = card.GetWorldLocation();
			this.Distance = Vector.Distance(worldLocation, worldLocation2);
			return this.Distance <= 200.0;
		}

		// Token: 0x06036426 RID: 222246 RVA: 0x00CD6011 File Offset: 0x00CD4211
		public EPhantomCardSettingFailReason GetSettingFailReason()
		{
			return this.SettingFailReason;
		}

		// Token: 0x06036427 RID: 222247 RVA: 0x00CD6019 File Offset: 0x00CD4219
		public void ResetSettingFailReason()
		{
			this.SettingFailReason = EPhantomCardSettingFailReason.None;
		}

		// Token: 0x06036428 RID: 222248 RVA: 0x00CD6026 File Offset: 0x00CD4226
		public void SetCardSelectedState(bool value)
		{
			PhantomArenaCard card = this.Card;
			if (card == null)
			{
				return;
			}
			card.SetSelectedState(value);
		}

		// Token: 0x06036429 RID: 222249 RVA: 0x00CD603C File Offset: 0x00CD423C
		public UniTask PlayResetPositionTween()
		{
			PhantomArenaAreaProxyBase.<PlayResetPositionTween>d__30 <PlayResetPositionTween>d__;
			<PlayResetPositionTween>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayResetPositionTween>d__.<>4__this = this;
			<PlayResetPositionTween>d__.<>1__state = -1;
			<PlayResetPositionTween>d__.<>t__builder.Start<PhantomArenaAreaProxyBase.<PlayResetPositionTween>d__30>(ref <PlayResetPositionTween>d__);
			return <PlayResetPositionTween>d__.<>t__builder.Task;
		}

		// Token: 0x0603642A RID: 222250 RVA: 0x00CD6080 File Offset: 0x00CD4280
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

		// Token: 0x0603642B RID: 222251 RVA: 0x00CD60CC File Offset: 0x00CD42CC
		public UniTask PlaySetCardTween()
		{
			PhantomArenaAreaProxyBase.<PlaySetCardTween>d__32 <PlaySetCardTween>d__;
			<PlaySetCardTween>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlaySetCardTween>d__.<>4__this = this;
			<PlaySetCardTween>d__.<>1__state = -1;
			<PlaySetCardTween>d__.<>t__builder.Start<PhantomArenaAreaProxyBase.<PlaySetCardTween>d__32>(ref <PlaySetCardTween>d__);
			return <PlaySetCardTween>d__.<>t__builder.Task;
		}

		// Token: 0x0603642C RID: 222252 RVA: 0x00CD6110 File Offset: 0x00CD4310
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

		// Token: 0x0603642D RID: 222253 RVA: 0x00CD6164 File Offset: 0x00CD4364
		public UniTask PlayFunctionalCardToRecycleTween()
		{
			PhantomArenaAreaProxyBase.<PlayFunctionalCardToRecycleTween>d__34 <PlayFunctionalCardToRecycleTween>d__;
			<PlayFunctionalCardToRecycleTween>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayFunctionalCardToRecycleTween>d__.<>4__this = this;
			<PlayFunctionalCardToRecycleTween>d__.<>1__state = -1;
			<PlayFunctionalCardToRecycleTween>d__.<>t__builder.Start<PhantomArenaAreaProxyBase.<PlayFunctionalCardToRecycleTween>d__34>(ref <PlayFunctionalCardToRecycleTween>d__);
			return <PlayFunctionalCardToRecycleTween>d__.<>t__builder.Task;
		}

		// Token: 0x0603642E RID: 222254 RVA: 0x00CD61A8 File Offset: 0x00CD43A8
		public UniTask PlayCardToLibraryTween()
		{
			PhantomArenaAreaProxyBase.<PlayCardToLibraryTween>d__35 <PlayCardToLibraryTween>d__;
			<PlayCardToLibraryTween>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayCardToLibraryTween>d__.<>4__this = this;
			<PlayCardToLibraryTween>d__.<>1__state = -1;
			<PlayCardToLibraryTween>d__.<>t__builder.Start<PhantomArenaAreaProxyBase.<PlayCardToLibraryTween>d__35>(ref <PlayCardToLibraryTween>d__);
			return <PlayCardToLibraryTween>d__.<>t__builder.Task;
		}

		// Token: 0x0603642F RID: 222255 RVA: 0x00CD61EB File Offset: 0x00CD43EB
		public PhantomArenaAreaItemBase GetAreaItem()
		{
			return this.AreaItem;
		}

		// Token: 0x170082F8 RID: 33528
		// (get) Token: 0x06036430 RID: 222256
		public abstract EPhantomArenaCardAreaType AreaType { get; }

		// Token: 0x06036431 RID: 222257
		public abstract bool CheckSettingCardCondition(PhantomArenaCard card);

		// Token: 0x06036432 RID: 222258
		public abstract bool CheckGuideCondition(PhantomArenaCard card);

		// Token: 0x06036433 RID: 222259
		[NullableContext(0)]
		protected abstract UniTask<bool> OnHandleCardSetting([Nullable(1)] PhantomArenaCard card);

		// Token: 0x06036434 RID: 222260
		protected abstract UUIItem GetCardRootItem();

		// Token: 0x0401CAE4 RID: 117476
		public int Index = -1;

		// Token: 0x0401CAE5 RID: 117477
		[Nullable(2)]
		public PhantomArenaCard Card;

		// Token: 0x0401CAE7 RID: 117479
		public PhantomArenaFunctionalArea ParentArea;

		// Token: 0x0401CAE8 RID: 117480
		protected EPhantomCardSettingFailReason SettingFailReason = EPhantomCardSettingFailReason.None;

		// Token: 0x0401CAE9 RID: 117481
		public bool IsInCardTween;
	}
}
