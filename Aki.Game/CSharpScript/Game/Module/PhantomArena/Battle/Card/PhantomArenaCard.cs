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
	// Token: 0x020052BC RID: 21180
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PhantomArenaCard : CommonBaseCardItem<PhantomCardData>
	{
		// Token: 0x060362B8 RID: 221880 RVA: 0x00CD0E04 File Offset: 0x00CCF004
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

		// Token: 0x060362B9 RID: 221881 RVA: 0x00CD0F54 File Offset: 0x00CCF154
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

		// Token: 0x060362BA RID: 221882 RVA: 0x00CD0F8C File Offset: 0x00CCF18C
		protected override UniTask OnBeforeChildStartAsync()
		{
			PhantomArenaCard.<OnBeforeChildStartAsync>d__24 <OnBeforeChildStartAsync>d__;
			<OnBeforeChildStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeChildStartAsync>d__.<>4__this = this;
			<OnBeforeChildStartAsync>d__.<>1__state = -1;
			<OnBeforeChildStartAsync>d__.<>t__builder.Start<PhantomArenaCard.<OnBeforeChildStartAsync>d__24>(ref <OnBeforeChildStartAsync>d__);
			return <OnBeforeChildStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060362BB RID: 221883 RVA: 0x00CD0FD0 File Offset: 0x00CCF1D0
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

		// Token: 0x060362BC RID: 221884 RVA: 0x00CD1158 File Offset: 0x00CCF358
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

		// Token: 0x060362BD RID: 221885 RVA: 0x00CD11B7 File Offset: 0x00CCF3B7
		private void OnEndSequenceEvent(string sequenceName)
		{
			if (sequenceName == "Dissolve".ToString() || sequenceName == "MagicUse".ToString())
			{
				base.Destroy(null);
			}
		}

		// Token: 0x060362BE RID: 221886 RVA: 0x00CD11E4 File Offset: 0x00CCF3E4
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

		// Token: 0x060362BF RID: 221887 RVA: 0x00CD1238 File Offset: 0x00CCF438
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

		// Token: 0x060362C0 RID: 221888 RVA: 0x00CD125D File Offset: 0x00CCF45D
		private IBattleCardComponent GetBattleCardComponent()
		{
			if (PhantomArenaBattleModel.Instance.IsOldBvb)
			{
				return base.GetComponent<BattleCardComponent>(ECardItemComponent.BattleCardComponent);
			}
			return base.GetComponent<NewBattleCardComponent>(ECardItemComponent.NewBattleCardComponent);
		}

		// Token: 0x060362C1 RID: 221889 RVA: 0x00CD127A File Offset: 0x00CCF47A
		private void SetCardData(PhantomCardData data)
		{
			this.Data = data;
		}

		// Token: 0x060362C2 RID: 221890 RVA: 0x00CD1284 File Offset: 0x00CCF484
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

		// Token: 0x060362C3 RID: 221891 RVA: 0x00CD12BA File Offset: 0x00CCF4BA
		private void OnPointerEnter(EToggleState _)
		{
			IPhantomCardProxy subProxy = this.GetSubProxy<IPhantomCardProxy>();
			if (subProxy == null)
			{
				return;
			}
			subProxy.PointerEnterCard(this.Data.CardId);
		}

		// Token: 0x060362C4 RID: 221892 RVA: 0x00CD12D8 File Offset: 0x00CCF4D8
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

		// Token: 0x060362C5 RID: 221893 RVA: 0x00CD1318 File Offset: 0x00CCF518
		private void OnPointerUp(EToggleState _)
		{
			this.SetPress(false);
		}

		// Token: 0x060362C6 RID: 221894 RVA: 0x00CD1321 File Offset: 0x00CCF521
		private void OnPointerCancel(EToggleState _)
		{
			this.SetPress(false);
			this.IsTriggerDragging = false;
			this.SetToggleState(EToggleState.ETT_UnChecked, false);
		}

		// Token: 0x060362C7 RID: 221895 RVA: 0x00CD1339 File Offset: 0x00CCF539
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

		// Token: 0x060362C8 RID: 221896 RVA: 0x00CD1363 File Offset: 0x00CCF563
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

		// Token: 0x060362C9 RID: 221897 RVA: 0x00CD1386 File Offset: 0x00CCF586
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

		// Token: 0x060362CA RID: 221898 RVA: 0x00CD13AC File Offset: 0x00CCF5AC
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

		// Token: 0x060362CB RID: 221899 RVA: 0x00CD13FF File Offset: 0x00CCF5FF
		public void AddComponentsRegisterInfoByResourceId(Tuple<ECardItemComponent, string> data)
		{
			this.ComponentsDataList.Add(data);
		}

		// Token: 0x060362CC RID: 221900 RVA: 0x00CD140D File Offset: 0x00CCF60D
		public override void Refresh(PhantomCardData data)
		{
			this.RefreshAsync(data).Forget();
		}

		// Token: 0x060362CD RID: 221901 RVA: 0x00CD141C File Offset: 0x00CCF61C
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

		// Token: 0x060362CE RID: 221902 RVA: 0x00CD1468 File Offset: 0x00CCF668
		public UniTask RefreshSelfAsync()
		{
			PhantomArenaCard.<RefreshSelfAsync>d__44 <RefreshSelfAsync>d__;
			<RefreshSelfAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshSelfAsync>d__.<>4__this = this;
			<RefreshSelfAsync>d__.<>1__state = -1;
			<RefreshSelfAsync>d__.<>t__builder.Start<PhantomArenaCard.<RefreshSelfAsync>d__44>(ref <RefreshSelfAsync>d__);
			return <RefreshSelfAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060362CF RID: 221903 RVA: 0x00CD14AB File Offset: 0x00CCF6AB
		public void RegisterCardLogic(PhantomArenaCardLogic logic)
		{
			this.CardLogic = logic;
		}

		// Token: 0x060362D0 RID: 221904 RVA: 0x00CD14B4 File Offset: 0x00CCF6B4
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

		// Token: 0x060362D1 RID: 221905 RVA: 0x00CD14D6 File Offset: 0x00CCF6D6
		public void RecordLastDragPos(FVector position)
		{
			LguiUtil.Instance.ConvertPointerPositionToLguiPosition(position, this.LastDragPos);
		}

		// Token: 0x060362D2 RID: 221906 RVA: 0x00CD14EC File Offset: 0x00CCF6EC
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

		// Token: 0x060362D3 RID: 221907 RVA: 0x00CD15E4 File Offset: 0x00CCF7E4
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

		// Token: 0x060362D4 RID: 221908 RVA: 0x00CD1674 File Offset: 0x00CCF874
		public Vector GetWorldLocation()
		{
			Vector worldLocation = this.WorldLocation;
			FVectorDouble fvectorDouble = this.RootItem.D_K2_GetComponentLocation();
			worldLocation.FromUeVector(fvectorDouble);
			return this.WorldLocation;
		}

		// Token: 0x060362D5 RID: 221909 RVA: 0x00CD16A0 File Offset: 0x00CCF8A0
		public void SetToggleState(EToggleState state, bool bFireEvent = true)
		{
			this.GetBattleCardComponent().GetCardToggle().SetToggleState(state, bFireEvent, false, false);
		}

		// Token: 0x060362D6 RID: 221910 RVA: 0x00CD16B7 File Offset: 0x00CCF8B7
		public EToggleState GetToggleState()
		{
			return this.GetBattleCardComponent().GetCardToggle().GetToggleState();
		}

		// Token: 0x060362D7 RID: 221911 RVA: 0x00CD16C9 File Offset: 0x00CCF8C9
		public void RefreshDebugText()
		{
			IBattleCardComponent battleCardComponent = this.GetBattleCardComponent();
			if (battleCardComponent == null)
			{
				return;
			}
			battleCardComponent.SetDebugText();
		}

		// Token: 0x060362D8 RID: 221912 RVA: 0x00CD16DC File Offset: 0x00CCF8DC
		public void OverrideCanvasSortOrder(bool bActive)
		{
			UUIItem originalItem = this.GetOriginalItem();
			ULGUICanvas ulguicanvas = (originalItem != null) ? originalItem.GetRenderCanvas() : null;
			if (ulguicanvas != null)
			{
				ulguicanvas.SetSortOrderNew(bActive ? 2 : 0, true);
			}
		}

		// Token: 0x060362D9 RID: 221913 RVA: 0x00CD1710 File Offset: 0x00CCF910
		public UniTask Dissolve()
		{
			PhantomArenaCard.<Dissolve>d__55 <Dissolve>d__;
			<Dissolve>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Dissolve>d__.<>4__this = this;
			<Dissolve>d__.<>1__state = -1;
			<Dissolve>d__.<>t__builder.Start<PhantomArenaCard.<Dissolve>d__55>(ref <Dissolve>d__);
			return <Dissolve>d__.<>t__builder.Task;
		}

		// Token: 0x060362DA RID: 221914 RVA: 0x00CD1754 File Offset: 0x00CCF954
		public UniTask MagicUse()
		{
			PhantomArenaCard.<MagicUse>d__56 <MagicUse>d__;
			<MagicUse>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<MagicUse>d__.<>4__this = this;
			<MagicUse>d__.<>1__state = -1;
			<MagicUse>d__.<>t__builder.Start<PhantomArenaCard.<MagicUse>d__56>(ref <MagicUse>d__);
			return <MagicUse>d__.<>t__builder.Task;
		}

		// Token: 0x060362DB RID: 221915 RVA: 0x00CD1797 File Offset: 0x00CCF997
		public void PlayStateSequence(string sequenceName)
		{
			IBattleCardComponent battleCardComponent = this.GetBattleCardComponent();
			if (battleCardComponent == null)
			{
				return;
			}
			battleCardComponent.PlaySequence(sequenceName);
		}

		// Token: 0x060362DC RID: 221916 RVA: 0x00CD17AA File Offset: 0x00CCF9AA
		public void PlayLocationByItem(UUIItem fromItem, UUIItem toItem, [Nullable(2)] PhantomArenaTweenLogic data = null)
		{
			this.TweenLogic.PlayLocationByItem(fromItem, toItem, data);
		}

		// Token: 0x060362DD RID: 221917 RVA: 0x00CD17BA File Offset: 0x00CCF9BA
		public void StopSequence(string sequenceName)
		{
			this.Sequence.StopSequenceByKey(sequenceName, false, true);
		}

		// Token: 0x060362DE RID: 221918 RVA: 0x00CD17CA File Offset: 0x00CCF9CA
		public void PlaySequence(string sequenceName, bool isReverse = false)
		{
			this.Sequence.StopPrevSequence(false, true);
			this.Sequence.PlaySequencePurely(sequenceName, false, isReverse);
		}

		// Token: 0x060362DF RID: 221919 RVA: 0x00CD17E7 File Offset: 0x00CCF9E7
		public void PlaySequenceWithoutStop(string sequenceName, bool isReverse = false)
		{
			this.Sequence.PlaySequencePurely(sequenceName, false, isReverse);
		}

		// Token: 0x060362E0 RID: 221920 RVA: 0x00CD17F8 File Offset: 0x00CCF9F8
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

		// Token: 0x060362E1 RID: 221921 RVA: 0x00CD1843 File Offset: 0x00CCFA43
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

		// Token: 0x060362E2 RID: 221922 RVA: 0x00CD1864 File Offset: 0x00CCFA64
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

		// Token: 0x060362E3 RID: 221923 RVA: 0x00CD1894 File Offset: 0x00CCFA94
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

		// Token: 0x060362E4 RID: 221924 RVA: 0x00CD18C4 File Offset: 0x00CCFAC4
		public void SetSelectedStateByGamepad(bool value)
		{
			PhantomArenaCardLogic cardLogic = this.CardLogic;
			if (cardLogic == null)
			{
				return;
			}
			cardLogic.SetSelectedState(value);
		}

		// Token: 0x060362E5 RID: 221925 RVA: 0x00CD18D8 File Offset: 0x00CCFAD8
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

		// Token: 0x060362E6 RID: 221926 RVA: 0x00CD1924 File Offset: 0x00CCFB24
		public UniTask ShowCopyEffect()
		{
			PhantomArenaCard.<ShowCopyEffect>d__68 <ShowCopyEffect>d__;
			<ShowCopyEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowCopyEffect>d__.<>4__this = this;
			<ShowCopyEffect>d__.<>1__state = -1;
			<ShowCopyEffect>d__.<>t__builder.Start<PhantomArenaCard.<ShowCopyEffect>d__68>(ref <ShowCopyEffect>d__);
			return <ShowCopyEffect>d__.<>t__builder.Task;
		}

		// Token: 0x060362E7 RID: 221927 RVA: 0x00CD1968 File Offset: 0x00CCFB68
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

		// Token: 0x060362E8 RID: 221928 RVA: 0x00CD19B3 File Offset: 0x00CCFBB3
		public UUIItem GetPhantomArenaCardRootItem()
		{
			return base.GetCardRootItem();
		}

		// Token: 0x060362E9 RID: 221929 RVA: 0x00CD19BB File Offset: 0x00CCFBBB
		public UUIItem GetPhantomArenaCardSpineRootItem()
		{
			return base.GetSpineRootItem();
		}

		// Token: 0x060362EA RID: 221930 RVA: 0x00CD19C4 File Offset: 0x00CCFBC4
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

		// Token: 0x0401CA88 RID: 117384
		private const int TICK_DURATION = 1000;

		// Token: 0x0401CA89 RID: 117385
		private readonly Vector2D LastDragPos = Vector2D.Create();

		// Token: 0x0401CA8A RID: 117386
		private readonly Vector2D CurDragPos = Vector2D.Create();

		// Token: 0x0401CA8B RID: 117387
		private readonly Vector2D TempAnchorOffset = Vector2D.Create();

		// Token: 0x0401CA8C RID: 117388
		private readonly Vector WorldLocation = Vector.Create();

		// Token: 0x0401CA8D RID: 117389
		protected readonly Transform ItemWorldTrans = Transform.Create();

		// Token: 0x0401CA8E RID: 117390
		protected readonly Vector TempWorldPos = Vector.Create();

		// Token: 0x0401CA8F RID: 117391
		[Nullable(2)]
		private IPhantomCardProxyBase CardProxy;

		// Token: 0x0401CA90 RID: 117392
		private bool IsPress;

		// Token: 0x0401CA91 RID: 117393
		private bool IsTriggerDragging;

		// Token: 0x0401CA92 RID: 117394
		private bool IsCanTick;

		// Token: 0x0401CA93 RID: 117395
		private bool IsProxyChange;

		// Token: 0x0401CA94 RID: 117396
		private int TickId = -1;

		// Token: 0x0401CA95 RID: 117397
		private float TickTime;

		// Token: 0x0401CA96 RID: 117398
		protected UiSequencePlayer Sequence;

		// Token: 0x0401CA97 RID: 117399
		protected PhantomArenaCardTweenLogic TweenLogic;

		// Token: 0x0401CA98 RID: 117400
		public PhantomArenaCardLogic CardLogic;

		// Token: 0x0401CA99 RID: 117401
		private readonly List<Tuple<ECardItemComponent, string>> ComponentsDataList = new List<Tuple<ECardItemComponent, string>>();

		// Token: 0x0401CA9A RID: 117402
		public PhantomCardData Data;

		// Token: 0x0401CA9B RID: 117403
		public float HalfWidth;

		// Token: 0x0401CA9C RID: 117404
		public float HalfHeight;

		// Token: 0x0401CA9D RID: 117405
		protected AActor CopyEffect;
	}
}
