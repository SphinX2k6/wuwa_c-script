using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000AC9 RID: 2761
public class WheelTowerBuffSelectView : UiViewBase, IUiViewResource
{
	// Token: 0x060072E0 RID: 29408 RVA: 0x00236896 File Offset: 0x00234A96
	[NullableContext(1)]
	public WheelTowerBuffSelectView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060072E1 RID: 29409 RVA: 0x002368A8 File Offset: 0x00234AA8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUILoopScrollViewComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickConfirm));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060072E2 RID: 29410 RVA: 0x002369F4 File Offset: 0x00234BF4
	protected override UniTask OnBeforeStartAsync()
	{
		WheelTowerBuffSelectView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WheelTowerBuffSelectView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060072E3 RID: 29411 RVA: 0x00236A38 File Offset: 0x00234C38
	protected override void OnStart()
	{
		List<int> levelBuffList = WheelTowerModel.Instance.GetLevelBuffList();
		LoopScrollView<WheelTowerBuffSelectView.BuffCard, int> cardScroll = this.CardScroll;
		if (cardScroll != null)
		{
			cardScroll.RefreshByData(new <>z__ReadOnlyArray<int>(levelBuffList.ToArray()), false, null, false);
		}
		PopupCaptionItem captionItem = this.CaptionItem;
		if (captionItem != null)
		{
			captionItem.SetCloseCallBack(delegate
			{
				base.CloseMe(null);
			});
		}
		UUIButtonComponent button = base.GetButton(4);
		if (button == null)
		{
			return;
		}
		button.SetSelfInteractive(this.SelectedBuffId != -1);
	}

	// Token: 0x060072E4 RID: 29412 RVA: 0x00236AA9 File Offset: 0x00234CA9
	[NullableContext(1)]
	private WheelTowerBuffSelectView.BuffCard CreateCard()
	{
		WheelTowerBuffSelectView.BuffCard buffCard = new WheelTowerBuffSelectView.BuffCard();
		buffCard.SetToggleCallback(new Action<int, int>(this.OnClickCard));
		return buffCard;
	}

	// Token: 0x060072E5 RID: 29413 RVA: 0x00236AC2 File Offset: 0x00234CC2
	private void OnClickCard(int buffId, int index)
	{
		this.SelectedBuffId = buffId;
		LoopScrollView<WheelTowerBuffSelectView.BuffCard, int> cardScroll = this.CardScroll;
		if (cardScroll != null)
		{
			cardScroll.SelectGridProxy(index, false);
		}
		UUIButtonComponent button = base.GetButton(4);
		if (button == null)
		{
			return;
		}
		button.SetSelfInteractive(true);
	}

	// Token: 0x060072E6 RID: 29414 RVA: 0x00236AF0 File Offset: 0x00234CF0
	private void OnClickConfirm()
	{
		if (this.SelectedBuffId != -1)
		{
			WheelTowerModel.Instance.SelectedBuff = this.SelectedBuffId;
		}
		base.CloseMe(null);
	}

	// Token: 0x060072E7 RID: 29415 RVA: 0x00236B14 File Offset: 0x00234D14
	[NullableContext(1)]
	public string GetExtraResourceId([Nullable(2)] object param = null)
	{
		if ((param as int?).GetValueOrDefault() != 32)
		{
			return string.Empty;
		}
		return "UiView_WheelTowerBuffSelect32";
	}

	// Token: 0x04004806 RID: 18438
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04004807 RID: 18439
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private LoopScrollView<WheelTowerBuffSelectView.BuffCard, int> CardScroll;

	// Token: 0x04004808 RID: 18440
	private int SelectedBuffId = -1;

	// Token: 0x02006D60 RID: 28000
	private class BuffCard : GridProxyAbstract<int>
	{
		// Token: 0x0603FBC7 RID: 261063 RVA: 0x012A69FC File Offset: 0x012A4BFC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603FBC8 RID: 261064 RVA: 0x012A6B08 File Offset: 0x012A4D08
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
			this.BuffId = data;
			NewTowerBuff? buffConfigById = WheelTowerConfig.Instance.GetBuffConfigById(data);
			if (buffConfigById == null)
			{
				return;
			}
			base.SetTextureShowUntilLoaded(buffConfigById.Value.Icon, base.GetTexture(1), null);
			UUIText text = base.GetText(2);
			if (text != null)
			{
				text.ShowTextNew(buffConfigById.Value.Name);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), buffConfigById.Value.Desc, buffConfigById.Value.DescParam());
			UUIItem item = base.GetItem(4);
			if (item != null)
			{
				item.SetUIActive(WheelTowerModel.Instance.SelectedBuff == data);
			}
			this.SetToggleSelect(false, true);
		}

		// Token: 0x0603FBC9 RID: 261065 RVA: 0x012A6BC6 File Offset: 0x012A4DC6
		public override void OnDeselected(bool fireEvent)
		{
			this.SetToggleSelect(false, false);
		}

		// Token: 0x0603FBCA RID: 261066 RVA: 0x012A6BD0 File Offset: 0x012A4DD0
		[NullableContext(1)]
		public void SetToggleCallback(Action<int, int> callback)
		{
			this.ToggleCallback = callback;
		}

		// Token: 0x0603FBCB RID: 261067 RVA: 0x012A6BD9 File Offset: 0x012A4DD9
		public void SetToggleSelect(bool selected, bool skipAnim = false)
		{
			base.GetExtendToggle(0).SetToggleStateForce(selected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, skipAnim);
		}

		// Token: 0x0603FBCC RID: 261068 RVA: 0x012A6BF1 File Offset: 0x012A4DF1
		private void OnToggleClick(EToggleState state)
		{
			Action<int, int> toggleCallback = this.ToggleCallback;
			if (toggleCallback == null)
			{
				return;
			}
			toggleCallback(this.BuffId, base.GridIndex);
		}

		// Token: 0x04023E3E RID: 147006
		private int BuffId = -1;

		// Token: 0x04023E3F RID: 147007
		[Nullable(2)]
		private Action<int, int> ToggleCallback;
	}
}
