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

// Token: 0x020014EF RID: 5359
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ScratchTicketCellItem : GridProxyAbstract<ScratchTicketCellData>
{
	// Token: 0x060098BC RID: 39100 RVA: 0x0020FF40 File Offset: 0x0020E140
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

	// Token: 0x060098BD RID: 39101 RVA: 0x00210028 File Offset: 0x0020E228
	protected override void OnBeforeCreate()
	{
		this.UiLevelSequence = new UiBehaviorLevelSequence(this);
		base.AddUiBehavior(this.UiLevelSequence);
	}

	// Token: 0x060098BE RID: 39102 RVA: 0x00210044 File Offset: 0x0020E244
	protected override UniTask OnBeforeStartAsync()
	{
		ScratchTicketCellItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ScratchTicketCellItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060098BF RID: 39103 RVA: 0x00210087 File Offset: 0x0020E287
	protected override void OnBeforeShow()
	{
		this.UiLevelSequence.AddSequenceFinishEvent("RevaelA", new Action<string>(this.OnRevealAnimationFinish), false);
	}

	// Token: 0x060098C0 RID: 39104 RVA: 0x002100A6 File Offset: 0x0020E2A6
	public override void Refresh(ScratchTicketCellData data, bool isSelected, int gridIndex)
	{
		this.RefreshUi(data);
		base.GetItem(2).SetUIActive(false);
		base.GetItem(3).SetUIActive(false);
		base.GetSprite(1).SetUIActive(false);
	}

	// Token: 0x060098C1 RID: 39105 RVA: 0x002100D6 File Offset: 0x0020E2D6
	public void RefreshByResultData(ScratchTicketCellData cellData, IScratchTicketRewardResult resultData)
	{
		this.CellData = cellData;
		if (resultData.SequenceType != ECellSequenceType.Warning && resultData.SequenceType != ECellSequenceType.Reveal)
		{
			this.RefreshUi(this.CellData);
		}
		this.PlaySequence(resultData.SequenceType);
	}

	// Token: 0x060098C2 RID: 39106 RVA: 0x0021010C File Offset: 0x0020E30C
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

	// Token: 0x060098C3 RID: 39107 RVA: 0x002101D4 File Offset: 0x0020E3D4
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

	// Token: 0x060098C4 RID: 39108 RVA: 0x002102C4 File Offset: 0x0020E4C4
	protected override void OnBeforeHide()
	{
		this.UiLevelSequence.RemoveSequenceFinishEvent("RevaelA", new Action<string>(this.OnRevealAnimationFinish));
	}

	// Token: 0x060098C5 RID: 39109 RVA: 0x002102E4 File Offset: 0x0020E4E4
	private void OnRevealAnimationFinish(string _)
	{
		this.RefreshUi(this.CellData);
		this.UiLevelSequence.PlaySequence("RevaelB", false, null);
	}

	// Token: 0x060098C6 RID: 39110 RVA: 0x00210317 File Offset: 0x0020E517
	private void OnClickRewardButton()
	{
		if (this.ClickCallBack != null)
		{
			this.ClickCallBack(this.CellData);
		}
	}

	// Token: 0x060098C7 RID: 39111 RVA: 0x00210332 File Offset: 0x0020E532
	public void SetClickCallback(Action<ScratchTicketCellData> callback)
	{
		this.ClickCallBack = callback;
	}

	// Token: 0x060098C8 RID: 39112 RVA: 0x0021033B File Offset: 0x0020E53B
	[NullableContext(2)]
	private bool CanRewardItemChangeToggle(object data, bool isForcedSelect, EToggleState toggleState)
	{
		return false;
	}

	// Token: 0x04004335 RID: 17205
	[Nullable(2)]
	private ScratchTicketCellData CellData;

	// Token: 0x04004336 RID: 17206
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<ScratchTicketCellData> ClickCallBack;

	// Token: 0x04004337 RID: 17207
	[Nullable(2)]
	public UiBehaviorLevelSequence UiLevelSequence;

	// Token: 0x04004338 RID: 17208
	[Nullable(2)]
	private SmallItemGrid ItemGrid;

	// Token: 0x04004339 RID: 17209
	private readonly Action<MediumItemGridExtendCallback> OnRewardItemClick = delegate(MediumItemGridExtendCallback callbackParameter)
	{
		ItemController.Instance.OpenItemTipsByItemId(((TItem)callbackParameter.Data).ItemData.ItemId, true, null);
	};

	// Token: 0x02007B21 RID: 31521
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x040287F2 RID: 165874
		public const int RewardButton = 0;

		// Token: 0x040287F3 RID: 165875
		public const int BgIcon = 1;

		// Token: 0x040287F4 RID: 165876
		public const int RewardRoot = 2;

		// Token: 0x040287F5 RID: 165877
		public const int ReceivedItem = 3;
	}
}
