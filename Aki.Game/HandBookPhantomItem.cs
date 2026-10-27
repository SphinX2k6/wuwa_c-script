using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001E0B RID: 7691
[NullableContext(1)]
[Nullable(0)]
public class HandBookPhantomItem : UiPanelBase
{
	// Token: 0x0600E9EC RID: 59884 RVA: 0x003759CD File Offset: 0x00373BCD
	public void Initialize(HandBookCommonItemData handBookCommonItemData, [Nullable(2)] UUIItem item)
	{
		this.HandBookCommonItemData = handBookCommonItemData;
		if (item != null)
		{
			base.CreateThenShowByActor(item.GetOwner(), null);
		}
	}

	// Token: 0x0600E9ED RID: 59885 RVA: 0x003759E8 File Offset: 0x00373BE8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText))
		};
	}

	// Token: 0x0600E9EE RID: 59886 RVA: 0x00375A58 File Offset: 0x00373C58
	protected override void OnStart()
	{
		this.HandBookCommonItem = new HandBookCommonItem();
		this.HandBookCommonItem.Initialize(base.GetItem(0).GetOwner());
		PhantomItem phantomItem = (PhantomItem)this.HandBookCommonItemData.Config;
		HandBookCommonItemData handBookCommonItemData = new HandBookCommonItemData();
		HandBookEntry handBookInfo = HandBookModel.Instance.GetHandBookInfo(EHandBookTabType.Phantom, phantomItem.MonsterId);
		bool flag = handBookInfo == null;
		bool isNew = handBookInfo != null && !handBookInfo.IsRead;
		handBookCommonItemData.Icon = phantomItem.Icon;
		handBookCommonItemData.IsLock = flag;
		handBookCommonItemData.IsNew = isNew;
		this.HandBookCommonItem.Refresh(handBookCommonItemData, false, 0);
		this.HandBookCommonItem.BindOnExtendToggleClicked(new Action<MediumItemGridExtendCallback>(this.OnToggleClicked));
		this.HandBookCommonItem.SetNewFlagVisible(new bool?(false));
		UUIText text = base.GetText(1);
		base.GetText(3).SetUIActive(false);
		if (flag)
		{
			string textContentIdById = TextConfig.Instance.GetTextContentIdById("Unknown");
			text.ShowTextNew(textContentIdById);
			return;
		}
		text.ShowTextNew(phantomItem.MonsterName);
	}

	// Token: 0x0600E9EF RID: 59887 RVA: 0x00375B5B File Offset: 0x00373D5B
	public void BindToggleCallback(THandBookPhantomItemToggleFunction toggleFunction)
	{
		this.OnToggleCallback = toggleFunction;
	}

	// Token: 0x0600E9F0 RID: 59888 RVA: 0x00375B64 File Offset: 0x00373D64
	private void OnToggleClicked(MediumItemGridExtendCallback callbackParameter)
	{
		if (this.OnToggleCallback != null)
		{
			this.OnToggleCallback(this.HandBookCommonItemData, 0);
		}
	}

	// Token: 0x0600E9F1 RID: 59889 RVA: 0x00375B80 File Offset: 0x00373D80
	public void SetToggleStateForce(EToggleState state, bool bFire = false)
	{
		this.HandBookCommonItem.SetSelected(state == EToggleState.ETT_Checked, false);
	}

	// Token: 0x0600E9F2 RID: 59890 RVA: 0x00375B92 File Offset: 0x00373D92
	public void OnSelected(bool fireEvent)
	{
		this.HandBookCommonItem.OnSelected(fireEvent);
	}

	// Token: 0x0600E9F3 RID: 59891 RVA: 0x00375BA0 File Offset: 0x00373DA0
	protected override void OnBeforeDestroy()
	{
		this.HandBookCommonItem = null;
		this.HandBookCommonItemData = null;
		this.OnToggleCallback = null;
	}

	// Token: 0x04006C86 RID: 27782
	[Nullable(2)]
	private HandBookCommonItem HandBookCommonItem;

	// Token: 0x04006C87 RID: 27783
	[Nullable(2)]
	private HandBookCommonItemData HandBookCommonItemData;

	// Token: 0x04006C88 RID: 27784
	[Nullable(2)]
	private THandBookPhantomItemToggleFunction OnToggleCallback;

	// Token: 0x020083C7 RID: 33735
	[NullableContext(0)]
	private class EHandBookPhantomItemDefine
	{
		// Token: 0x0402AE81 RID: 175745
		public const int HandBookCommonItem = 0;

		// Token: 0x0402AE82 RID: 175746
		public const int NameText = 1;

		// Token: 0x0402AE83 RID: 175747
		public const int HaveText = 2;

		// Token: 0x0402AE84 RID: 175748
		public const int PlaceText = 3;
	}
}
