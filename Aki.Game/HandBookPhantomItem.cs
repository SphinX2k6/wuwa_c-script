using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020012CD RID: 4813
[NullableContext(1)]
[Nullable(0)]
public class HandBookPhantomItem : UiPanelBase
{
	// Token: 0x0600BE0B RID: 48651 RVA: 0x003816D5 File Offset: 0x0037F8D5
	public void Initialize(HandBookCommonItemData handBookCommonItemData, [Nullable(2)] UUIItem item)
	{
		this.HandBookCommonItemData = handBookCommonItemData;
		if (item != null)
		{
			base.CreateThenShowByActor(item.GetOwner(), null);
		}
	}

	// Token: 0x0600BE0C RID: 48652 RVA: 0x003816F0 File Offset: 0x0037F8F0
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

	// Token: 0x0600BE0D RID: 48653 RVA: 0x00381760 File Offset: 0x0037F960
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

	// Token: 0x0600BE0E RID: 48654 RVA: 0x00381863 File Offset: 0x0037FA63
	public void BindToggleCallback(THandBookPhantomItemToggleFunction toggleFunction)
	{
		this.OnToggleCallback = toggleFunction;
	}

	// Token: 0x0600BE0F RID: 48655 RVA: 0x0038186C File Offset: 0x0037FA6C
	private void OnToggleClicked(MediumItemGridExtendCallback callbackParameter)
	{
		if (this.OnToggleCallback != null)
		{
			this.OnToggleCallback(this.HandBookCommonItemData, 0);
		}
	}

	// Token: 0x0600BE10 RID: 48656 RVA: 0x00381888 File Offset: 0x0037FA88
	public void SetToggleStateForce(EToggleState state, bool bFire = false)
	{
		this.HandBookCommonItem.SetSelected(state == EToggleState.ETT_Checked, false);
	}

	// Token: 0x0600BE11 RID: 48657 RVA: 0x0038189A File Offset: 0x0037FA9A
	public void OnSelected(bool fireEvent)
	{
		this.HandBookCommonItem.OnSelected(fireEvent);
	}

	// Token: 0x0600BE12 RID: 48658 RVA: 0x003818A8 File Offset: 0x0037FAA8
	protected override void OnBeforeDestroy()
	{
		this.HandBookCommonItem = null;
		this.HandBookCommonItemData = null;
		this.OnToggleCallback = null;
	}

	// Token: 0x04006D67 RID: 28007
	[Nullable(2)]
	private HandBookCommonItem HandBookCommonItem;

	// Token: 0x04006D68 RID: 28008
	[Nullable(2)]
	private HandBookCommonItemData HandBookCommonItemData;

	// Token: 0x04006D69 RID: 28009
	[Nullable(2)]
	private THandBookPhantomItemToggleFunction OnToggleCallback;

	// Token: 0x0200754C RID: 30028
	[NullableContext(0)]
	private class EHandBookPhantomItemDefine
	{
		// Token: 0x040261A4 RID: 156068
		public const int HandBookCommonItem = 0;

		// Token: 0x040261A5 RID: 156069
		public const int NameText = 1;

		// Token: 0x040261A6 RID: 156070
		public const int HaveText = 2;

		// Token: 0x040261A7 RID: 156071
		public const int PlaceText = 3;
	}
}
