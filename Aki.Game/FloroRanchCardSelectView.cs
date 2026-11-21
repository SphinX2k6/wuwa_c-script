using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200101A RID: 4122
[NullableContext(2)]
[Nullable(0)]
public class FloroRanchCardSelectView : UiViewBase
{
	// Token: 0x0600A3D7 RID: 41943 RVA: 0x00300580 File Offset: 0x002FE780
	[NullableContext(1)]
	public FloroRanchCardSelectView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600A3D8 RID: 41944 RVA: 0x00300590 File Offset: 0x002FE790
	protected unsafe override void OnRegisterComponent()
	{
		int num = 13;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 4;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickRefreshBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickConfirmBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickSkipBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnClickHideButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600A3D9 RID: 41945 RVA: 0x00300810 File Offset: 0x002FEA10
	protected override UniTask OnBeforeStartAsync()
	{
		FloroRanchCardSelectView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FloroRanchCardSelectView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600A3DA RID: 41946 RVA: 0x00300853 File Offset: 0x002FEA53
	protected override void OnBeforeShow()
	{
		this.RefreshView();
		this.UiBlur.SetEnableUiBlur(true);
	}

	// Token: 0x0600A3DB RID: 41947 RVA: 0x00300867 File Offset: 0x002FEA67
	protected override void OnBeforeHide()
	{
		this.UiBlur.SetEnableUiBlur(false);
	}

	// Token: 0x0600A3DC RID: 41948 RVA: 0x00300878 File Offset: 0x002FEA78
	private void RefreshView()
	{
		FloroRanchGacha gachaData = this.GachaData;
		bool flag = gachaData != null && gachaData.AllowedRefresh;
		UUIButtonComponent button = base.GetButton(2);
		if (button != null)
		{
			UUIItem uuiitem = button.RootUIComp.Get();
			if (uuiitem != null)
			{
				uuiitem.SetUIActive(flag);
			}
		}
		if (flag)
		{
			FloroRanchCurrencyData diamondData = FloroRanchGamePlayModel.Instance.DiamondData;
			base.SetTextureByPath(diamondData.ConfigData.GetSmallIcon(), base.GetTexture(8), null, null);
			int freeTimes = this.GachaData.FreeTimes;
			UUIText text = base.GetText(10);
			if (text != null)
			{
				text.ShowTextNew((freeTimes > 0) ? "Farm_Edit5" : "Farm_Edit4");
			}
			UUIText text2 = base.GetText(9);
			if (freeTimes > 0)
			{
				text2.SetText("-0", true);
				text2.useChangeColor = false;
				UUIItem item = base.GetItem(11);
				if (item != null)
				{
					item.SetUIActive(true);
				}
				UUIText text3 = base.GetText(12);
				if (text3 != null)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
					defaultInterpolatedStringHandler.AppendFormatted<int>(freeTimes);
					text3.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
				}
			}
			else
			{
				long amount = diamondData.GetAmount();
				int count = this.GachaData.Cost[0].Count;
				bool flag2 = amount >= (long)count;
				UUIText uuitext = text2;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
				defaultInterpolatedStringHandler.AppendLiteral("-");
				defaultInterpolatedStringHandler.AppendFormatted<int>(count);
				uuitext.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
				text2.useChangeColor = !flag2;
				UUIItem item2 = base.GetItem(11);
				if (item2 != null)
				{
					item2.SetUIActive(false);
				}
			}
		}
		this.CurrencyItem.SetCurrencyData(FloroRanchGamePlayModel.Instance.DiamondData);
	}

	// Token: 0x0600A3DD RID: 41949 RVA: 0x00300A14 File Offset: 0x002FEC14
	private UniTask RefreshCardLayout()
	{
		FloroRanchCardSelectView.<RefreshCardLayout>d__15 <RefreshCardLayout>d__;
		<RefreshCardLayout>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshCardLayout>d__.<>4__this = this;
		<RefreshCardLayout>d__.<>1__state = -1;
		<RefreshCardLayout>d__.<>t__builder.Start<FloroRanchCardSelectView.<RefreshCardLayout>d__15>(ref <RefreshCardLayout>d__);
		return <RefreshCardLayout>d__.<>t__builder.Task;
	}

	// Token: 0x0600A3DE RID: 41950 RVA: 0x00300A57 File Offset: 0x002FEC57
	private void ClearTimerId()
	{
		if (TimerSystem.GameplayTimeInstance.Has(this.TimerId))
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimerId);
		}
		this.TimerId = null;
	}

	// Token: 0x0600A3DF RID: 41951 RVA: 0x00300A83 File Offset: 0x002FEC83
	protected override void OnBeforeDestroy()
	{
		this.ClearTimerId();
	}

	// Token: 0x0600A3E0 RID: 41952 RVA: 0x00300A8B File Offset: 0x002FEC8B
	private void InitUiBlur()
	{
		AUIBaseActor rootActor = this.RootActor;
		this.UiBlur = (((rootActor != null) ? rootActor.GetComponentByClass(TsUiBlur.StaticClass()) : null) as TsUiBlur);
		this.UiBlur.SetEnableUiBlur(false);
	}

	// Token: 0x0600A3E1 RID: 41953 RVA: 0x00300AC0 File Offset: 0x002FECC0
	[NullableContext(1)]
	private void OnRefreshCacheResponse(FloroRanchPlayGachaRefreshResponse response)
	{
		if (response == null)
		{
			Log.Instance.Error(ELogModule.FloroRanch, ELogAuthor.CXJ, "刷新抽卡请求，返回数据为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.GachaData = response.Task;
		this.DeselectCard();
		this.RefreshView();
		this.RefreshCardLayout().Forget();
		UiNavigationNewController.Instance.MarkViewHandleRefreshNavigationDirty();
	}

	// Token: 0x0600A3E2 RID: 41954 RVA: 0x00300B20 File Offset: 0x002FED20
	[NullableContext(1)]
	private FloroRanchCardItem CreateCardItem()
	{
		FloroRanchCardItem floroRanchCardItem = new FloroRanchCardItem();
		global::FloroRanchActivityData currentActivityData = FloroRanchGamePlayModel.Instance.GetCurrentActivityData();
		floroRanchCardItem.SetActivityDataType((currentActivityData != null) ? currentActivityData.ActivityDataType : EFloroRanchActivityDataType.Normal);
		floroRanchCardItem.SetToggleCallBack(new Action<int, int>(this.CardToggleClick));
		floroRanchCardItem.SetCanToggleExecuteFunction(new Func<int, bool>(this.CanCardToggleExecuteChange));
		return floroRanchCardItem;
	}

	// Token: 0x0600A3E3 RID: 41955 RVA: 0x00300B73 File Offset: 0x002FED73
	public void CardToggleClick(int gridIndex, int cardId)
	{
		if (this.CardLayout.GetSelectedGridIndex() == gridIndex)
		{
			return;
		}
		this.SelectedCardId = cardId;
		this.CardLayout.SelectGridProxy(gridIndex, false);
		UUIButtonComponent button = base.GetButton(3);
		if (button == null)
		{
			return;
		}
		button.SetSelfInteractive(true);
	}

	// Token: 0x0600A3E4 RID: 41956 RVA: 0x00300BAA File Offset: 0x002FEDAA
	private void DeselectCard()
	{
		this.CardLayout.DeselectCurrentGridProxy();
		this.SelectedCardId = 0;
		UUIButtonComponent button = base.GetButton(3);
		if (button == null)
		{
			return;
		}
		button.SetSelfInteractive(false);
	}

	// Token: 0x0600A3E5 RID: 41957 RVA: 0x00300BD0 File Offset: 0x002FEDD0
	private bool CanCardToggleExecuteChange(int gridIndex)
	{
		return this.CardLayout.GetSelectedGridIndex() != gridIndex;
	}

	// Token: 0x0600A3E6 RID: 41958 RVA: 0x00300BE4 File Offset: 0x002FEDE4
	private void OnClickRefreshBtn()
	{
		if (!this.IsFreeClick)
		{
			return;
		}
		if (!this.GachaData.AllowedRefresh)
		{
			Log.Instance.Error(ELogModule.FloroRanchGamePlay, ELogAuthor.LRC, "抽卡刷新 allowedRefresh 为 false", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (FloroRanchGamePlayModel.Instance.DiamondData.GetAmount() < (long)this.GachaData.Cost[0].Count)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("Farm_MoneyNotEnough", Array.Empty<object>());
			return;
		}
		int id = FloroRanchGamePlayModel.Instance.GetCurrentActivityData().Id;
		int subInstanceId = FloroRanchGamePlayModel.Instance.SubInstanceId;
		this.IsFreeClick = false;
		FloroRanchController.Instance.FloroRanchPlayRefreshGachaRequest(id, subInstanceId, this.GachaData.IncId, delegate(FloroRanchPlayGachaRefreshResponse response)
		{
			this.OnRefreshCacheResponse(response);
			this.IsFreeClick = true;
		});
	}

	// Token: 0x0600A3E7 RID: 41959 RVA: 0x00300CAC File Offset: 0x002FEEAC
	private void OnClickConfirmBtn()
	{
		if (!this.IsFreeClick)
		{
			return;
		}
		global::FloroRanchActivityData currentActivityData = FloroRanchGamePlayModel.Instance.GetCurrentActivityData();
		int id = currentActivityData.Id;
		int subInstanceId = FloroRanchGamePlayModel.Instance.SubInstanceId;
		if (this.SelectedCardId == 0)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("Farm_ChooseCard", Array.Empty<object>());
			return;
		}
		if (FloroRanchGamePlayModel.Instance.OwnCardEntityCount >= currentActivityData.CardLimitCount)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("PhrolovaFarm_AnimalMax", Array.Empty<object>());
			return;
		}
		HashSet<int> hashSet = LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.FloroRanchCardInGameRedDot, null) ?? new HashSet<int>();
		if (!hashSet.Contains(this.SelectedCardId))
		{
			hashSet.Add(this.SelectedCardId);
			LocalStorage.SetPlayer<HashSet<int>>(ELocalStoragePlayerKey.FloroRanchCardInGameRedDot, hashSet);
		}
		this.IsFreeClick = false;
		FloroRanchController.Instance.FloroRanchPlayGachaRequest(id, subInstanceId, this.SelectedCardId, this.GachaData.IncId, delegate(FloroRanchPlayGachaResponse _)
		{
			base.CloseMe(null);
			Action closeCallback = this.CloseCallback;
			if (closeCallback != null)
			{
				closeCallback();
			}
			this.IsFreeClick = true;
		});
	}

	// Token: 0x0600A3E8 RID: 41960 RVA: 0x00300D90 File Offset: 0x002FEF90
	private void OnClickSkipBtn()
	{
		if (!this.IsFreeClick)
		{
			return;
		}
		base.CloseMe(null);
		Action closeCallback = this.CloseCallback;
		if (closeCallback != null)
		{
			closeCallback();
		}
		if (this.GachaData != null)
		{
			int activityId = FloroRanchGamePlayModel.Instance.ActivityId;
			int subInstanceId = FloroRanchGamePlayModel.Instance.SubInstanceId;
			this.IsFreeClick = false;
			FloroRanchController.Instance.SendFloroRanchCloseTaskRequest(activityId, subInstanceId, this.GachaData.IncId, delegate(FloroRanchCloseTaskResponse response)
			{
				this.IsFreeClick = true;
			});
		}
	}

	// Token: 0x0600A3E9 RID: 41961 RVA: 0x00300E06 File Offset: 0x002FF006
	private void OnClickHideButton()
	{
		if (!this.IsFreeClick)
		{
			return;
		}
		FloroRanchGamePlayModel.Instance.HideRecordView();
	}

	// Token: 0x0400604F RID: 24655
	private FloroRanchGacha GachaData;

	// Token: 0x04006050 RID: 24656
	private Action CloseCallback;

	// Token: 0x04006051 RID: 24657
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<FloroRanchCardItem, int> CardLayout;

	// Token: 0x04006052 RID: 24658
	private FloroRanchCurrencyItem CurrencyItem;

	// Token: 0x04006053 RID: 24659
	private int SelectedCardId;

	// Token: 0x04006054 RID: 24660
	private TimerHandle TimerId;

	// Token: 0x04006055 RID: 24661
	private TsUiBlur UiBlur;

	// Token: 0x04006056 RID: 24662
	private bool IsFreeClick = true;

	// Token: 0x02007239 RID: 29241
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x040252A9 RID: 152233
		public const int LayoutCard = 0;

		// Token: 0x040252AA RID: 152234
		public const int ItemCard = 1;

		// Token: 0x040252AB RID: 152235
		public const int ButtonRefresh = 2;

		// Token: 0x040252AC RID: 152236
		public const int ButtonConfirm = 3;

		// Token: 0x040252AD RID: 152237
		public const int ButtonSkip = 4;

		// Token: 0x040252AE RID: 152238
		public const int HideButton = 5;

		// Token: 0x040252AF RID: 152239
		public const int ItemCost = 6;

		// Token: 0x040252B0 RID: 152240
		public const int ItemHidePanel = 7;

		// Token: 0x040252B1 RID: 152241
		public const int RefreshTexture = 8;

		// Token: 0x040252B2 RID: 152242
		public const int RefreshPrice = 9;

		// Token: 0x040252B3 RID: 152243
		public const int RefreshButtonText = 10;

		// Token: 0x040252B4 RID: 152244
		public const int RefreshTimePanel = 11;

		// Token: 0x040252B5 RID: 152245
		public const int RefreshTimeText = 12;
	}
}
