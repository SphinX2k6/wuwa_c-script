using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.Card.Logic;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using CSharpScript.Game.Module.PhantomArena.Common.CardItem;
using CSharpScript.Game.Module.PhantomArena.Common.CardItem.Component;
using CSharpScript.Game.Module.PhantomArena.Common.CardItem.Component.Bvb;
using CSharpScript.Game.Module.PhantomArena.Common.CardItem.Item;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Card
{
	// Token: 0x0200428C RID: 17036
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PhantomArenaCard : CommonBaseCardItem<PhantomCardData>
	{
		// Token: 0x0602B1B3 RID: 176563 RVA: 0x00C1E52C File Offset: 0x00C1C72C
		protected override void OnRegisterCardComponent()
		{
			if (PhantomArenaBattleModel.Instance.IsOldBvb)
			{
				this.ComponentsRegisterInfoByItem = new List<TCardComponentsRegisterInfoByItem>
				{
					new TCardComponentsRegisterInfoByItem(ECardItemComponent.BattleCardComponent, base.GetCardRootItem())
				};
			}
			else
			{
				this.ComponentsRegisterInfoByItem = new List<TCardComponentsRegisterInfoByItem>
				{
					new TCardComponentsRegisterInfoByItem(ECardItemComponent.NewBattleCardComponent, base.GetCardRootItem())
				};
			}
			this.ComponentsRegisterInfoByResourceId = new List<TCardComponentsRegisterInfoByResourceId>
			{
				new TCardComponentsRegisterInfoByResourceId(ECardItemComponent.CardSelectedComponent, "PnlStateChoose1", base.GetCardRootItem())
			};
			foreach (Tuple<ECardItemComponent, string> value in this.ComponentsDataList)
			{
				ECardItemComponent ecardItemComponent;
				string text;
				value.Deconstruct(out ecardItemComponent, out text);
				ECardItemComponent componentType = ecardItemComponent;
				string resourceId = text;
				this.ComponentsRegisterInfoByResourceId.Add(new TCardComponentsRegisterInfoByResourceId(componentType, resourceId, base.GetCardRootItem()));
			}
			if (this.CardLogic != null)
			{
				foreach (TCardComponentsRegisterInfoByResourceId tcardComponentsRegisterInfoByResourceId in this.CardLogic.GetComponentsDataList())
				{
					ECardItemComponent ecardItemComponent;
					string text;
					UUIItem uuiitem;
					tcardComponentsRegisterInfoByResourceId.Deconstruct(out ecardItemComponent, out text, out uuiitem);
					ECardItemComponent componentType2 = ecardItemComponent;
					string resourceId2 = text;
					UUIItem parentItem = uuiitem;
					this.ComponentsRegisterInfoByResourceId.Add(new TCardComponentsRegisterInfoByResourceId(componentType2, resourceId2, parentItem));
				}
			}
		}

		// Token: 0x0602B1B4 RID: 176564 RVA: 0x00C1E67C File Offset: 0x00C1C87C
		private void CardClick(EToggleState state)
		{
			if (this.IsTriggerDragging)
			{
				this.IsTriggerDragging = false;
				this.SetToggleState(EToggleState.ETT_UnChecked, false);
				return;
			}
			IPhantomCardProxy subProxy = this.GetSubProxy<IPhantomCardProxy>();
			if (subProxy == null)
			{
				return;
			}
			subProxy.PointerClickCard(this.Data.CardId, state);
		}

		// Token: 0x0602B1B5 RID: 176565 RVA: 0x00C1E6B4 File Offset: 0x00C1C8B4
		protected override UniTask OnBeforeChildStartAsync()
		{
			PhantomArenaCard.<OnBeforeChildStartAsync>d__24 <OnBeforeChildStartAsync>d__;
			<OnBeforeChildStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeChildStartAsync>d__.<>4__this = this;
			<OnBeforeChildStartAsync>d__.<>1__state = -1;
			<OnBeforeChildStartAsync>d__.<>t__builder.Start<PhantomArenaCard.<OnBeforeChildStartAsync>d__24>(ref <OnBeforeChildStartAsync>d__);
			return <OnBeforeChildStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602B1B6 RID: 176566 RVA: 0x00C1E6F8 File Offset: 0x00C1C8F8
		protected override void OnStart()
		{
			this.Sequence = new UiSequencePlayer(base.GetCardRootItem());
			this.Sequence.BindOnEndSequenceEvent(new Action<string>(this.OnEndSequenceEvent));
			IBattleCardComponent battleCardComponent = this.GetBattleCardComponent();
			battleCardComponent.RootUiSequencePlayer = this.Sequence;
			battleCardComponent.CardClickCallback = new Action<EToggleState>(this.CardClick);
			UUIExtendToggle cardToggle = battleCardComponent.GetCardToggle();
			cardToggle.OnPointEnterCallBack.Bind(new Action<EToggleState>(this.OnPointerEnter));
			cardToggle.OnPointDownCallBack.Bind(new Action<EToggleState>(this.OnPointerDown));
			cardToggle.OnPointUpCallBack.Bind(new Action<EToggleState>(this.OnPointerUp));
			cardToggle.OnPointCancelCallBack.Bind(new Action<EToggleState>(this.OnPointerCancel));
			cardToggle.OnPointerBeginDragCallBack.Bind(new Func<ULGUIPointerEventData, bool>(this.OnPointerBeginDrag));
			cardToggle.OnPointerDragCallBack.Bind(new Func<ULGUIPointerEventData, bool>(this.OnPointerDrag));
			cardToggle.OnPointerEndDragCallBack.Bind(new Func<ULGUIPointerEventData, bool>(this.OnPointerEndDrag));
			PhantomArenaCardLogic cardLogic = this.CardLogic;
			if (cardLogic != null)
			{
				cardLogic.BeforeStart();
			}
			Ticker ticker = TickSystem.Instance.Add(new Action<float>(this.Tick), "LongPressComponent", ETickingGroup.TG_PrePhysics, true, 0, true);
			if (ticker != null)
			{
				this.TickId = ticker.Id;
			}
			this.HalfWidth = base.GetCardRootItem().Width / 2f;
			this.HalfHeight = base.GetCardRootItem().Height / 2f;
			this.TweenLogic = new PhantomArenaCardTweenLogic();
			this.TweenLogic.Init(base.GetRootItem());
		}

		// Token: 0x0602B1B7 RID: 176567 RVA: 0x00C1E880 File Offset: 0x00C1CA80
		protected override void OnBeforeDestroy()
		{
			if (this.CopyEffect != null)
			{
				ULGUIBPLibrary.DestroyActorWithHierarchy(this.CopyEffect, true);
				this.CopyEffect = null;
			}
			if (this.TickId != -1)
			{
				TickSystem.Instance.Remove(this.TickId);
				this.TickId = -1;
			}
			this.Sequence.Clear();
			this.TweenLogic.Destroy();
		}

		// Token: 0x0602B1B8 RID: 176568 RVA: 0x00C1E8DF File Offset: 0x00C1CADF
		private void OnEndSequenceEvent(string sequenceName)
		{
			if (sequenceName == "Dissolve".ToString() || sequenceName == "MagicUse".ToString())
			{
				base.Destroy(null);
			}
		}

		// Token: 0x0602B1B9 RID: 176569 RVA: 0x00C1E90C File Offset: 0x00C1CB0C
		private void Tick(float delta)
		{
			if (!this.IsCanTick)
			{
				return;
			}
			if (this.TickTime < 1000f)
			{
				this.TickTime += delta;
				return;
			}
			this.SetPress(false);
			IPhantomCardLongPressProxy subProxy = this.GetSubProxy<IPhantomCardLongPressProxy>();
			if (subProxy == null)
			{
				return;
			}
			subProxy.PointerLongPressCard(this.Data.CardId);
		}

		// Token: 0x0602B1BA RID: 176570 RVA: 0x00C1E960 File Offset: 0x00C1CB60
		private void SetPress(bool value)
		{
			if (value == this.IsPress)
			{
				return;
			}
			this.TickTime = 0f;
			this.IsCanTick = value;
			this.IsPress = value;
		}

		// Token: 0x0602B1BB RID: 176571 RVA: 0x00C1E985 File Offset: 0x00C1CB85
		private IBattleCardComponent GetBattleCardComponent()
		{
			if (PhantomArenaBattleModel.Instance.IsOldBvb)
			{
				return base.GetComponent<BattleCardComponent>(ECardItemComponent.BattleCardComponent);
			}
			return base.GetComponent<NewBattleCardComponent>(ECardItemComponent.NewBattleCardComponent);
		}

		// Token: 0x0602B1BC RID: 176572 RVA: 0x00C1E9A2 File Offset: 0x00C1CBA2
		private void SetCardData(PhantomCardData data)
		{
			this.Data = data;
		}

		// Token: 0x0602B1BD RID: 176573 RVA: 0x00C1E9AC File Offset: 0x00C1CBAC
		[return: Nullable(2)]
		private T GetSubProxy<T>() where T : class
		{
			if (this.IsProxyChange)
			{
				this.IsProxyChange = false;
				return default(T);
			}
			return this.CardProxy as T;
		}

		// Token: 0x0602B1BE RID: 176574 RVA: 0x00C1E9E2 File Offset: 0x00C1CBE2
		private void OnPointerEnter(EToggleState _)
		{
			IPhantomCardProxy subProxy = this.GetSubProxy<IPhantomCardProxy>();
			if (subProxy == null)
			{
				return;
			}
			subProxy.PointerEnterCard(this.Data.CardId);
		}

		// Token: 0x0602B1BF RID: 176575 RVA: 0x00C1EA00 File Offset: 0x00C1CC00
		private void OnPointerDown(EToggleState _)
		{
			this.SetPress(true);
			ULGUIPointerEventData pointerEventData = LguiEventSystemManager.Instance.GetPointerEventData(0, false);
			if (pointerEventData != null)
			{
				IPhantomCardProxy subProxy = this.GetSubProxy<IPhantomCardProxy>();
				if (subProxy == null)
				{
					return;
				}
				subProxy.PointerDownCard(this.Data.CardId, pointerEventData);
			}
		}

		// Token: 0x0602B1C0 RID: 176576 RVA: 0x00C1EA40 File Offset: 0x00C1CC40
		private void OnPointerUp(EToggleState _)
		{
			this.SetPress(false);
		}

		// Token: 0x0602B1C1 RID: 176577 RVA: 0x00C1EA49 File Offset: 0x00C1CC49
		private void OnPointerCancel(EToggleState _)
		{
			this.SetPress(false);
			this.IsTriggerDragging = false;
			this.SetToggleState(EToggleState.ETT_UnChecked, false);
		}

		// Token: 0x0602B1C2 RID: 176578 RVA: 0x00C1EA61 File Offset: 0x00C1CC61
		private bool OnPointerBeginDrag(ULGUIPointerEventData eventData)
		{
			this.IsTriggerDragging = true;
			if (eventData != null)
			{
				IPhantomCardDragProxy subProxy = this.GetSubProxy<IPhantomCardDragProxy>();
				if (subProxy != null)
				{
					subProxy.PointerBeginDrag(this.Data.CardId, eventData);
				}
			}
			return true;
		}

		// Token: 0x0602B1C3 RID: 176579 RVA: 0x00C1EA8B File Offset: 0x00C1CC8B
		private bool OnPointerDrag(ULGUIPointerEventData eventData)
		{
			if (eventData != null)
			{
				IPhantomCardDragProxy subProxy = this.GetSubProxy<IPhantomCardDragProxy>();
				if (subProxy != null)
				{
					subProxy.PointerDragCard(this.Data.CardId, eventData);
				}
			}
			return true;
		}

		// Token: 0x0602B1C4 RID: 176580 RVA: 0x00C1EAAE File Offset: 0x00C1CCAE
		private bool OnPointerEndDrag(ULGUIPointerEventData eventData)
		{
			if (eventData != null)
			{
				IPhantomCardDragProxy subProxy = this.GetSubProxy<IPhantomCardDragProxy>();
				if (subProxy != null)
				{
					subProxy.PointerEndDrag(this.Data.CardId, eventData);
				}
			}
			return true;
		}

		// Token: 0x0602B1C5 RID: 176581 RVA: 0x00C1EAD4 File Offset: 0x00C1CCD4
		public UniTask InitializePhantomArenaCard(PhantomCardData cardData, UUIItem rootItem)
		{
			PhantomArenaCard.<InitializePhantomArenaCard>d__40 <InitializePhantomArenaCard>d__;
			<InitializePhantomArenaCard>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitializePhantomArenaCard>d__.<>4__this = this;
			<InitializePhantomArenaCard>d__.cardData = cardData;
			<InitializePhantomArenaCard>d__.rootItem = rootItem;
			<InitializePhantomArenaCard>d__.<>1__state = -1;
			<InitializePhantomArenaCard>d__.<>t__builder.Start<PhantomArenaCard.<InitializePhantomArenaCard>d__40>(ref <InitializePhantomArenaCard>d__);
			return <InitializePhantomArenaCard>d__.<>t__builder.Task;
		}

		// Token: 0x0602B1C6 RID: 176582 RVA: 0x00C1EB27 File Offset: 0x00C1CD27
		public void AddComponentsRegisterInfoByResourceId(Tuple<ECardItemComponent, string> data)
		{
			this.ComponentsDataList.Add(data);
		}

		// Token: 0x0602B1C7 RID: 176583 RVA: 0x00C1EB35 File Offset: 0x00C1CD35
		public override void Refresh(PhantomCardData data)
		{
			this.RefreshAsync(data).Forget();
		}

		// Token: 0x0602B1C8 RID: 176584 RVA: 0x00C1EB44 File Offset: 0x00C1CD44
		public UniTask RefreshAsync(PhantomCardData data)
		{
			PhantomArenaCard.<RefreshAsync>d__43 <RefreshAsync>d__;
			<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshAsync>d__.<>4__this = this;
			<RefreshAsync>d__.data = data;
			<RefreshAsync>d__.<>1__state = -1;
			<RefreshAsync>d__.<>t__builder.Start<PhantomArenaCard.<RefreshAsync>d__43>(ref <RefreshAsync>d__);
			return <RefreshAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602B1C9 RID: 176585 RVA: 0x00C1EB90 File Offset: 0x00C1CD90
		public UniTask RefreshSelfAsync()
		{
			PhantomArenaCard.<RefreshSelfAsync>d__44 <RefreshSelfAsync>d__;
			<RefreshSelfAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshSelfAsync>d__.<>4__this = this;
			<RefreshSelfAsync>d__.<>1__state = -1;
			<RefreshSelfAsync>d__.<>t__builder.Start<PhantomArenaCard.<RefreshSelfAsync>d__44>(ref <RefreshSelfAsync>d__);
			return <RefreshSelfAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602B1CA RID: 176586 RVA: 0x00C1EBD3 File Offset: 0x00C1CDD3
		public void RegisterCardLogic(PhantomArenaCardLogic logic)
		{
			this.CardLogic = logic;
		}

		// Token: 0x0602B1CB RID: 176587 RVA: 0x00C1EBDC File Offset: 0x00C1CDDC
		[NullableContext(2)]
		public void SetCardProxy(IPhantomCardProxyBase proxy)
		{
			if (this.CardProxy == proxy)
			{
				return;
			}
			if (this.IsTriggerDragging)
			{
				this.IsProxyChange = true;
			}
			this.CardProxy = proxy;
		}

		// Token: 0x0602B1CC RID: 176588 RVA: 0x00C1EBFE File Offset: 0x00C1CDFE
		public void RecordLastDragPos(FVector position)
		{
			LguiUtil.Instance.ConvertPointerPositionToLguiPosition(position, this.LastDragPos);
		}

		// Token: 0x0602B1CD RID: 176589 RVA: 0x00C1EC14 File Offset: 0x00C1CE14
		public void MoveCard(FVector position)
		{
			if (this.RootItem == null)
			{
				return;
			}
			LguiUtil.Instance.ConvertPointerPositionToLguiPosition(position, this.CurDragPos);
			if (Vector2D.Create(this.CurDragPos.X, this.CurDragPos.Y).SubtractionEqual(this.LastDragPos).IsNearlyZero(0.0))
			{
				return;
			}
			double num = this.CurDragPos.X - this.LastDragPos.X;
			double num2 = this.CurDragPos.Y - this.LastDragPos.Y;
			this.TempAnchorOffset.FromUeVector2D(this.RootItem.GetAnchorOffset());
			this.TempAnchorOffset.X += num;
			this.TempAnchorOffset.Y += num2;
			this.RootItem.SetAnchorOffset(this.TempAnchorOffset.ToUeVector2D(false));
			this.LastDragPos.DeepCopy(this.CurDragPos);
		}

		// Token: 0x0602B1CE RID: 176590 RVA: 0x00C1ED0C File Offset: 0x00C1CF0C
		public void SetUiParent(UUIItem parentItem, bool reset = false)
		{
			Vector tempWorldPos = this.TempWorldPos;
			FVectorDouble fvectorDouble = this.RootItem.D_K2_GetComponentLocation();
			tempWorldPos.FromUeVector(fvectorDouble);
			Transform itemWorldTrans = this.ItemWorldTrans;
			FTransform ftransform = parentItem.K2_GetComponentToWorld();
			itemWorldTrans.FromUeTransform(ftransform);
			this.ItemWorldTrans.InverseTransformPosition(this.TempWorldPos, this.TempWorldPos);
			this.GetOriginalItem().SetUIParent(parentItem, false);
			this.ParentUiItem = parentItem;
			this.RootItem.SetUIRelativeLocation(this.TempWorldPos.ToUeVectorOld());
			if (reset)
			{
				this.RootItem.SetAnchorOffset(Vector2D.ZeroVector);
			}
		}

		// Token: 0x0602B1CF RID: 176591 RVA: 0x00C1ED9C File Offset: 0x00C1CF9C
		public Vector GetWorldLocation()
		{
			Vector worldLocation = this.WorldLocation;
			FVectorDouble fvectorDouble = this.RootItem.D_K2_GetComponentLocation();
			worldLocation.FromUeVector(fvectorDouble);
			return this.WorldLocation;
		}

		// Token: 0x0602B1D0 RID: 176592 RVA: 0x00C1EDC8 File Offset: 0x00C1CFC8
		public void SetToggleState(EToggleState state, bool bFireEvent = true)
		{
			this.GetBattleCardComponent().GetCardToggle().SetToggleState(state, bFireEvent, false, false);
		}

		// Token: 0x0602B1D1 RID: 176593 RVA: 0x00C1EDDF File Offset: 0x00C1CFDF
		public EToggleState GetToggleState()
		{
			return this.GetBattleCardComponent().GetCardToggle().GetToggleState();
		}

		// Token: 0x0602B1D2 RID: 176594 RVA: 0x00C1EDF1 File Offset: 0x00C1CFF1
		public void RefreshDebugText()
		{
			IBattleCardComponent battleCardComponent = this.GetBattleCardComponent();
			if (battleCardComponent == null)
			{
				return;
			}
			battleCardComponent.SetDebugText();
		}

		// Token: 0x0602B1D3 RID: 176595 RVA: 0x00C1EE04 File Offset: 0x00C1D004
		public void OverrideCanvasSortOrder(bool bActive)
		{
			UUIItem originalItem = this.GetOriginalItem();
			ULGUICanvas ulguicanvas = (originalItem != null) ? originalItem.GetRenderCanvas() : null;
			if (ulguicanvas != null)
			{
				ulguicanvas.SetSortOrderNew(bActive ? 2 : 0, true);
			}
		}

		// Token: 0x0602B1D4 RID: 176596 RVA: 0x00C1EE38 File Offset: 0x00C1D038
		public UniTask Dissolve()
		{
			PhantomArenaCard.<Dissolve>d__55 <Dissolve>d__;
			<Dissolve>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Dissolve>d__.<>4__this = this;
			<Dissolve>d__.<>1__state = -1;
			<Dissolve>d__.<>t__builder.Start<PhantomArenaCard.<Dissolve>d__55>(ref <Dissolve>d__);
			return <Dissolve>d__.<>t__builder.Task;
		}

		// Token: 0x0602B1D5 RID: 176597 RVA: 0x00C1EE7C File Offset: 0x00C1D07C
		public UniTask MagicUse()
		{
			PhantomArenaCard.<MagicUse>d__56 <MagicUse>d__;
			<MagicUse>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<MagicUse>d__.<>4__this = this;
			<MagicUse>d__.<>1__state = -1;
			<MagicUse>d__.<>t__builder.Start<PhantomArenaCard.<MagicUse>d__56>(ref <MagicUse>d__);
			return <MagicUse>d__.<>t__builder.Task;
		}

		// Token: 0x0602B1D6 RID: 176598 RVA: 0x00C1EEBF File Offset: 0x00C1D0BF
		public void PlayStateSequence(string sequenceName)
		{
			IBattleCardComponent battleCardComponent = this.GetBattleCardComponent();
			if (battleCardComponent == null)
			{
				return;
			}
			battleCardComponent.PlaySequence(sequenceName);
		}

		// Token: 0x0602B1D7 RID: 176599 RVA: 0x00C1EED2 File Offset: 0x00C1D0D2
		public void PlayLocationByItem(UUIItem fromItem, UUIItem toItem, [Nullable(2)] PhantomArenaTweenLogic data = null)
		{
			this.TweenLogic.PlayLocationByItem(fromItem, toItem, data);
		}

		// Token: 0x0602B1D8 RID: 176600 RVA: 0x00C1EEE2 File Offset: 0x00C1D0E2
		public void StopSequence(string sequenceName)
		{
			this.Sequence.StopSequenceByKey(sequenceName, false, true);
		}

		// Token: 0x0602B1D9 RID: 176601 RVA: 0x00C1EEF2 File Offset: 0x00C1D0F2
		public void PlaySequence(string sequenceName, bool isReverse = false)
		{
			this.Sequence.StopPrevSequence(false, true);
			this.Sequence.PlaySequencePurely(sequenceName, false, isReverse);
		}

		// Token: 0x0602B1DA RID: 176602 RVA: 0x00C1EF0F File Offset: 0x00C1D10F
		public void PlaySequenceWithoutStop(string sequenceName, bool isReverse = false)
		{
			this.Sequence.PlaySequencePurely(sequenceName, false, isReverse);
		}

		// Token: 0x0602B1DB RID: 176603 RVA: 0x00C1EF20 File Offset: 0x00C1D120
		public UniTask PlaySequenceAsync(string sequenceName)
		{
			PhantomArenaCard.<PlaySequenceAsync>d__62 <PlaySequenceAsync>d__;
			<PlaySequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlaySequenceAsync>d__.<>4__this = this;
			<PlaySequenceAsync>d__.sequenceName = sequenceName;
			<PlaySequenceAsync>d__.<>1__state = -1;
			<PlaySequenceAsync>d__.<>t__builder.Start<PhantomArenaCard.<PlaySequenceAsync>d__62>(ref <PlaySequenceAsync>d__);
			return <PlaySequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602B1DC RID: 176604 RVA: 0x00C1EF6B File Offset: 0x00C1D16B
		public void PlaySpineAnimAndEffect(string animationName, bool isLoop)
		{
			IBattleCardComponent battleCardComponent = this.GetBattleCardComponent();
			if (battleCardComponent != null)
			{
				battleCardComponent.PlaySpineAnim(animationName, isLoop);
			}
			if (battleCardComponent == null)
			{
				return;
			}
			battleCardComponent.PlayEffect();
		}

		// Token: 0x0602B1DD RID: 176605 RVA: 0x00C1EF8C File Offset: 0x00C1D18C
		public void SetSelectedStateWithoutSequence()
		{
			CardCommonComponent component = base.GetComponent<CardCommonComponent>(ECardItemComponent.CardSelectedComponent);
			if (component != null)
			{
				component.SetComponentDisActiveWithoutSequence();
			}
			PhantomArenaCardLogic cardLogic = this.CardLogic;
			if (cardLogic == null)
			{
				return;
			}
			cardLogic.SetSelectedState(false);
		}

		// Token: 0x0602B1DE RID: 176606 RVA: 0x00C1EFBC File Offset: 0x00C1D1BC
		public void SetSelectedState(bool value)
		{
			CardCommonComponent component = base.GetComponent<CardCommonComponent>(ECardItemComponent.CardSelectedComponent);
			if (component != null)
			{
				component.SetComponentActive(value);
			}
			PhantomArenaCardLogic cardLogic = this.CardLogic;
			if (cardLogic == null)
			{
				return;
			}
			cardLogic.SetSelectedState(value);
		}

		// Token: 0x0602B1DF RID: 176607 RVA: 0x00C1EFEC File Offset: 0x00C1D1EC
		public void SetSelectedStateByGamepad(bool value)
		{
			PhantomArenaCardLogic cardLogic = this.CardLogic;
			if (cardLogic == null)
			{
				return;
			}
			cardLogic.SetSelectedState(value);
		}

		// Token: 0x0602B1E0 RID: 176608 RVA: 0x00C1F000 File Offset: 0x00C1D200
		public UniTask RefreshEffect(int curEffectCount)
		{
			PhantomArenaCard.<RefreshEffect>d__67 <RefreshEffect>d__;
			<RefreshEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshEffect>d__.<>4__this = this;
			<RefreshEffect>d__.curEffectCount = curEffectCount;
			<RefreshEffect>d__.<>1__state = -1;
			<RefreshEffect>d__.<>t__builder.Start<PhantomArenaCard.<RefreshEffect>d__67>(ref <RefreshEffect>d__);
			return <RefreshEffect>d__.<>t__builder.Task;
		}

		// Token: 0x0602B1E1 RID: 176609 RVA: 0x00C1F04C File Offset: 0x00C1D24C
		public UniTask ShowCopyEffect()
		{
			PhantomArenaCard.<ShowCopyEffect>d__68 <ShowCopyEffect>d__;
			<ShowCopyEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowCopyEffect>d__.<>4__this = this;
			<ShowCopyEffect>d__.<>1__state = -1;
			<ShowCopyEffect>d__.<>t__builder.Start<PhantomArenaCard.<ShowCopyEffect>d__68>(ref <ShowCopyEffect>d__);
			return <ShowCopyEffect>d__.<>t__builder.Task;
		}

		// Token: 0x0602B1E2 RID: 176610 RVA: 0x00C1F090 File Offset: 0x00C1D290
		public UniTask PlayHitEffect(UUIItem toItem)
		{
			PhantomArenaCard.<PlayHitEffect>d__69 <PlayHitEffect>d__;
			<PlayHitEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayHitEffect>d__.<>4__this = this;
			<PlayHitEffect>d__.toItem = toItem;
			<PlayHitEffect>d__.<>1__state = -1;
			<PlayHitEffect>d__.<>t__builder.Start<PhantomArenaCard.<PlayHitEffect>d__69>(ref <PlayHitEffect>d__);
			return <PlayHitEffect>d__.<>t__builder.Task;
		}

		// Token: 0x0602B1E3 RID: 176611 RVA: 0x00C1F0DB File Offset: 0x00C1D2DB
		public UUIItem GetPhantomArenaCardRootItem()
		{
			return base.GetCardRootItem();
		}

		// Token: 0x0602B1E4 RID: 176612 RVA: 0x00C1F0E3 File Offset: 0x00C1D2E3
		public UUIItem GetPhantomArenaCardSpineRootItem()
		{
			return base.GetSpineRootItem();
		}

		// Token: 0x0602B1E5 RID: 176613 RVA: 0x00C1F0EC File Offset: 0x00C1D2EC
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams == null || configParams.Length == 0)
			{
				return null;
			}
			if (configParams[0] == "BattleCardSkillById")
			{
				CardSkillComponent component = base.GetComponent<CardSkillComponent>(ECardItemComponent.CardSkillComponent);
				UUIItem uuiitem = (component != null) ? component.GetGuideUiItem("T_技能按钮") : null;
				UUIItem uuiitem2 = (component != null) ? component.GetGuideUiItem("V_技能按钮") : null;
				if (uuiitem != null && uuiitem2 != null)
				{
					return new UUIItem[]
					{
						uuiitem,
						uuiitem2
					};
				}
				return null;
			}
			else
			{
				IBattleCardComponent battleCardComponent = this.GetBattleCardComponent();
				UUIItem uuiitem3 = (battleCardComponent != null) ? battleCardComponent.GetRootItem() : null;
				if (uuiitem3 != null)
				{
					return new UUIItem[]
					{
						uuiitem3,
						uuiitem3
					};
				}
				return null;
			}
		}

		// Token: 0x040174BD RID: 95421
		private const int TICK_DURATION = 1000;

		// Token: 0x040174BE RID: 95422
		private readonly Vector2D LastDragPos = Vector2D.Create();

		// Token: 0x040174BF RID: 95423
		private readonly Vector2D CurDragPos = Vector2D.Create();

		// Token: 0x040174C0 RID: 95424
		private readonly Vector2D TempAnchorOffset = Vector2D.Create();

		// Token: 0x040174C1 RID: 95425
		private readonly Vector WorldLocation = Vector.Create();

		// Token: 0x040174C2 RID: 95426
		protected readonly Transform ItemWorldTrans = Transform.Create();

		// Token: 0x040174C3 RID: 95427
		protected readonly Vector TempWorldPos = Vector.Create();

		// Token: 0x040174C4 RID: 95428
		[Nullable(2)]
		private IPhantomCardProxyBase CardProxy;

		// Token: 0x040174C5 RID: 95429
		private bool IsPress;

		// Token: 0x040174C6 RID: 95430
		private bool IsTriggerDragging;

		// Token: 0x040174C7 RID: 95431
		private bool IsCanTick;

		// Token: 0x040174C8 RID: 95432
		private bool IsProxyChange;

		// Token: 0x040174C9 RID: 95433
		private int TickId = -1;

		// Token: 0x040174CA RID: 95434
		private float TickTime;

		// Token: 0x040174CB RID: 95435
		protected UiSequencePlayer Sequence;

		// Token: 0x040174CC RID: 95436
		protected PhantomArenaCardTweenLogic TweenLogic;

		// Token: 0x040174CD RID: 95437
		public PhantomArenaCardLogic CardLogic;

		// Token: 0x040174CE RID: 95438
		private readonly List<Tuple<ECardItemComponent, string>> ComponentsDataList = new List<Tuple<ECardItemComponent, string>>();

		// Token: 0x040174CF RID: 95439
		public PhantomCardData Data;

		// Token: 0x040174D0 RID: 95440
		public float HalfWidth;

		// Token: 0x040174D1 RID: 95441
		public float HalfHeight;

		// Token: 0x040174D2 RID: 95442
		protected AActor CopyEffect;
	}
}
