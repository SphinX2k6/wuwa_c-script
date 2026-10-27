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

// Token: 0x02001B5B RID: 7003
[NullableContext(2)]
[Nullable(0)]
public class FloroRanchCardSelectView : UiViewBase
{
	// Token: 0x0600CFC6 RID: 53190 RVA: 0x002F54A8 File Offset: 0x002F36A8
	[NullableContext(1)]
	public FloroRanchCardSelectView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600CFC7 RID: 53191 RVA: 0x002F54B8 File Offset: 0x002F36B8
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

	// Token: 0x0600CFC8 RID: 53192 RVA: 0x002F5738 File Offset: 0x002F3938
	protected override UniTask OnBeforeStartAsync()
	{
		FloroRanchCardSelectView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FloroRanchCardSelectView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600CFC9 RID: 53193 RVA: 0x002F577B File Offset: 0x002F397B
	protected override void OnBeforeShow()
	{
		this.RefreshView();
		this.UiBlur.SetEnableUiBlur(true);
	}

	// Token: 0x0600CFCA RID: 53194 RVA: 0x002F578F File Offset: 0x002F398F
	protected override void OnBeforeHide()
	{
		this.UiBlur.SetEnableUiBlur(false);
	}

	// Token: 0x0600CFCB RID: 53195 RVA: 0x002F57A0 File Offset: 0x002F39A0
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

	// Token: 0x0600CFCC RID: 53196 RVA: 0x002F593C File Offset: 0x002F3B3C
	private UniTask RefreshCardLayout()
	{
		FloroRanchCardSelectView.<RefreshCardLayout>d__15 <RefreshCardLayout>d__;
		<RefreshCardLayout>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshCardLayout>d__.<>4__this = this;
		<RefreshCardLayout>d__.<>1__state = -1;
		<RefreshCardLayout>d__.<>t__builder.Start<FloroRanchCardSelectView.<RefreshCardLayout>d__15>(ref <RefreshCardLayout>d__);
		return <RefreshCardLayout>d__.<>t__builder.Task;
	}

	// Token: 0x0600CFCD RID: 53197 RVA: 0x002F597F File Offset: 0x002F3B7F
	private void ClearTimerId()
	{
		if (TimerSystem.GameplayTimeInstance.Has(this.TimerId))
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimerId);
		}
		this.TimerId = null;
	}

	// Token: 0x0600CFCE RID: 53198 RVA: 0x002F59AB File Offset: 0x002F3BAB
	protected override void OnBeforeDestroy()
	{
		this.ClearTimerId();
	}

	// Token: 0x0600CFCF RID: 53199 RVA: 0x002F59B3 File Offset: 0x002F3BB3
	private void InitUiBlur()
	{
		AUIBaseActor rootActor = this.RootActor;
		this.UiBlur = (((rootActor != null) ? rootActor.GetComponentByClass(TsUiBlur.StaticClass()) : null) as TsUiBlur);
		this.UiBlur.SetEnableUiBlur(false);
	}

	// Token: 0x0600CFD0 RID: 53200 RVA: 0x002F59E8 File Offset: 0x002F3BE8
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

	// Token: 0x0600CFD1 RID: 53201 RVA: 0x002F5A48 File Offset: 0x002F3C48
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

	// Token: 0x0600CFD2 RID: 53202 RVA: 0x002F5A9B File Offset: 0x002F3C9B
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

	// Token: 0x0600CFD3 RID: 53203 RVA: 0x002F5AD2 File Offset: 0x002F3CD2
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

	// Token: 0x0600CFD4 RID: 53204 RVA: 0x002F5AF8 File Offset: 0x002F3CF8
	private bool CanCardToggleExecuteChange(int gridIndex)
	{
		return this.CardLayout.GetSelectedGridIndex() != gridIndex;
	}

	// Token: 0x0600CFD5 RID: 53205 RVA: 0x002F5B0C File Offset: 0x002F3D0C
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

	// Token: 0x0600CFD6 RID: 53206 RVA: 0x002F5BD4 File Offset: 0x002F3DD4
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

	// Token: 0x0600CFD7 RID: 53207 RVA: 0x002F5CB8 File Offset: 0x002F3EB8
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

	// Token: 0x0600CFD8 RID: 53208 RVA: 0x002F5D2E File Offset: 0x002F3F2E
	private void OnClickHideButton()
	{
		if (!this.IsFreeClick)
		{
			return;
		}
		FloroRanchGamePlayModel.Instance.HideRecordView();
	}

	// Token: 0x04005F80 RID: 24448
	private FloroRanchGacha GachaData;

	// Token: 0x04005F81 RID: 24449
	private Action CloseCallback;

	// Token: 0x04005F82 RID: 24450
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<FloroRanchCardItem, int> CardLayout;

	// Token: 0x04005F83 RID: 24451
	private FloroRanchCurrencyItem CurrencyItem;

	// Token: 0x04005F84 RID: 24452
	private int SelectedCardId;

	// Token: 0x04005F85 RID: 24453
	private TimerHandle TimerId;

	// Token: 0x04005F86 RID: 24454
	private TsUiBlur UiBlur;

	// Token: 0x04005F87 RID: 24455
	private bool IsFreeClick = true;

	// Token: 0x020080AB RID: 32939
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04029F75 RID: 171893
		public const int LayoutCard = 0;

		// Token: 0x04029F76 RID: 171894
		public const int ItemCard = 1;

		// Token: 0x04029F77 RID: 171895
		public const int ButtonRefresh = 2;

		// Token: 0x04029F78 RID: 171896
		public const int ButtonConfirm = 3;

		// Token: 0x04029F79 RID: 171897
		public const int ButtonSkip = 4;

		// Token: 0x04029F7A RID: 171898
		public const int HideButton = 5;

		// Token: 0x04029F7B RID: 171899
		public const int ItemCost = 6;

		// Token: 0x04029F7C RID: 171900
		public const int ItemHidePanel = 7;

		// Token: 0x04029F7D RID: 171901
		public const int RefreshTexture = 8;

		// Token: 0x04029F7E RID: 171902
		public const int RefreshPrice = 9;

		// Token: 0x04029F7F RID: 171903
		public const int RefreshButtonText = 10;

		// Token: 0x04029F80 RID: 171904
		public const int RefreshTimePanel = 11;

		// Token: 0x04029F81 RID: 171905
		public const int RefreshTimeText = 12;
	}
}
