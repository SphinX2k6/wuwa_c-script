using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020009A7 RID: 2471
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ScratchTicketCellItem : GridProxyAbstract<ScratchTicketCellData>
{
	// Token: 0x06006C96 RID: 27798 RVA: 0x00219C2C File Offset: 0x00217E2C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickRewardButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06006C97 RID: 27799 RVA: 0x00219D14 File Offset: 0x00217F14
	protected override void OnBeforeCreate()
	{
		this.UiLevelSequence = new UiBehaviorLevelSequence(this);
		base.AddUiBehavior(this.UiLevelSequence);
	}

	// Token: 0x06006C98 RID: 27800 RVA: 0x00219D30 File Offset: 0x00217F30
	protected override UniTask OnBeforeStartAsync()
	{
		ScratchTicketCellItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ScratchTicketCellItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006C99 RID: 27801 RVA: 0x00219D73 File Offset: 0x00217F73
	protected override void OnBeforeShow()
	{
		this.UiLevelSequence.AddSequenceFinishEvent("RevaelA", new Action<string>(this.OnRevealAnimationFinish), false);
	}

	// Token: 0x06006C9A RID: 27802 RVA: 0x00219D92 File Offset: 0x00217F92
	public override void Refresh(ScratchTicketCellData data, bool isSelected, int gridIndex)
	{
		this.RefreshUi(data);
		base.GetItem(2).SetUIActive(false);
		base.GetItem(3).SetUIActive(false);
		base.GetSprite(1).SetUIActive(false);
	}

	// Token: 0x06006C9B RID: 27803 RVA: 0x00219DC2 File Offset: 0x00217FC2
	public void RefreshByResultData(ScratchTicketCellData cellData, IScratchTicketRewardResult resultData)
	{
		this.CellData = cellData;
		if (resultData.SequenceType != ECellSequenceType.Warning && resultData.SequenceType != ECellSequenceType.Reveal)
		{
			this.RefreshUi(this.CellData);
		}
		this.PlaySequence(resultData.SequenceType);
	}

	// Token: 0x06006C9C RID: 27804 RVA: 0x00219DF8 File Offset: 0x00217FF8
	private void RefreshUi(ScratchTicketCellData data)
	{
		this.CellData = data;
		TItem? itemData = data.GetItemData();
		if (itemData == null)
		{
			base.GetItem(2).SetUIActive(false);
			base.GetItem(3).SetUIActive(false);
			base.GetSprite(1).SetUIActive(false);
			return;
		}
		base.GetItem(2).SetUIActive(true);
		base.GetItem(3).SetUIActive(true);
		base.GetSprite(1).SetUIActive(true);
		PropSmallItemGrid parameters = new PropSmallItemGrid
		{
			Data = itemData,
			ItemConfigId = new int?(itemData.Value.ItemData.ItemId),
			BottomText = itemData.Value.Count.ToString()
		};
		this.ItemGrid.Apply<PropSmallItemGrid>(parameters);
	}

	// Token: 0x06006C9D RID: 27805 RVA: 0x00219EC0 File Offset: 0x002180C0
	private void PlaySequence(ECellSequenceType sequenceType)
	{
		switch (sequenceType)
		{
		case ECellSequenceType.Center:
		case ECellSequenceType.Last:
			this.UiLevelSequence.PlaySequence("Strike", false, null);
			return;
		case ECellSequenceType.Left:
			this.UiLevelSequence.PlaySequence("StrikeL", false, null);
			return;
		case ECellSequenceType.Right:
			this.UiLevelSequence.PlaySequence("StrikeR", false, null);
			return;
		case ECellSequenceType.Top:
			this.UiLevelSequence.PlaySequence("StrikeA", false, null);
			return;
		case ECellSequenceType.Bottom:
			this.UiLevelSequence.PlaySequence("StrikeB", false, null);
			return;
		case ECellSequenceType.Warning:
			this.UiLevelSequence.PlaySequence("Warning", false, null);
			return;
		case ECellSequenceType.Reveal:
			this.UiLevelSequence.PlaySequence("RevaelA", false, null);
			return;
		default:
			return;
		}
	}

	// Token: 0x06006C9E RID: 27806 RVA: 0x00219FB0 File Offset: 0x002181B0
	protected override void OnBeforeHide()
	{
		this.UiLevelSequence.RemoveSequenceFinishEvent("RevaelA", new Action<string>(this.OnRevealAnimationFinish));
	}

	// Token: 0x06006C9F RID: 27807 RVA: 0x00219FD0 File Offset: 0x002181D0
	private void OnRevealAnimationFinish(string _)
	{
		this.RefreshUi(this.CellData);
		this.UiLevelSequence.PlaySequence("RevaelB", false, null);
	}

	// Token: 0x06006CA0 RID: 27808 RVA: 0x0021A003 File Offset: 0x00218203
	private void OnClickRewardButton()
	{
		if (this.ClickCallBack != null)
		{
			this.ClickCallBack(this.CellData);
		}
	}

	// Token: 0x06006CA1 RID: 27809 RVA: 0x0021A01E File Offset: 0x0021821E
	public void SetClickCallback(Action<ScratchTicketCellData> callback)
	{
		this.ClickCallBack = callback;
	}

	// Token: 0x06006CA2 RID: 27810 RVA: 0x0021A027 File Offset: 0x00218227
	[NullableContext(2)]
	private bool CanRewardItemChangeToggle(object data, bool isForcedSelect, EToggleState toggleState)
	{
		return false;
	}

	// Token: 0x040043DA RID: 17370
	[Nullable(2)]
	private ScratchTicketCellData CellData;

	// Token: 0x040043DB RID: 17371
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<ScratchTicketCellData> ClickCallBack;

	// Token: 0x040043DC RID: 17372
	[Nullable(2)]
	public UiBehaviorLevelSequence UiLevelSequence;

	// Token: 0x040043DD RID: 17373
	[Nullable(2)]
	private SmallItemGrid ItemGrid;

	// Token: 0x040043DE RID: 17374
	private readonly Action<MediumItemGridExtendCallback> OnRewardItemClick = delegate(MediumItemGridExtendCallback callbackParameter)
	{
		ItemController.Instance.OpenItemTipsByItemId(((TItem)callbackParameter.Data).ItemData.ItemId, true, null, false);
	};

	// Token: 0x02006CAD RID: 27821
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x04023B30 RID: 146224
		public const int RewardButton = 0;

		// Token: 0x04023B31 RID: 146225
		public const int BgIcon = 1;

		// Token: 0x04023B32 RID: 146226
		public const int RewardRoot = 2;

		// Token: 0x04023B33 RID: 146227
		public const int ReceivedItem = 3;
	}
}
