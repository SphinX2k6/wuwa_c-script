using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.InstanceDungeon.ExchangeReward;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020021A7 RID: 8615
public class LordGymItem : UiPanelBase, IGridProxy<int>
{
	// Token: 0x06010C17 RID: 68631 RVA: 0x0041266B File Offset: 0x0041086B
	[NullableContext(1)]
	public LordGymItem(Action<int> onClickBack, Func<int, bool> lordCanExecuteChange)
	{
		this.OnClickBack = onClickBack;
		this.LordCanExecuteChange = lordCanExecuteChange;
	}

	// Token: 0x17001545 RID: 5445
	// (get) Token: 0x06010C18 RID: 68632 RVA: 0x00412688 File Offset: 0x00410888
	// (set) Token: 0x06010C19 RID: 68633 RVA: 0x00412690 File Offset: 0x00410890
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public IScrollViewDelegate<IGridProxy<int>, int> ScrollViewDelegate { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }

	// Token: 0x17001546 RID: 5446
	// (get) Token: 0x06010C1A RID: 68634 RVA: 0x00412699 File Offset: 0x00410899
	// (set) Token: 0x06010C1B RID: 68635 RVA: 0x004126A1 File Offset: 0x004108A1
	public int GridIndex { get; set; }

	// Token: 0x17001547 RID: 5447
	// (get) Token: 0x06010C1C RID: 68636 RVA: 0x004126AA File Offset: 0x004108AA
	// (set) Token: 0x06010C1D RID: 68637 RVA: 0x004126B2 File Offset: 0x004108B2
	public int DisplayIndex { get; set; }

	// Token: 0x06010C1E RID: 68638 RVA: 0x004126BC File Offset: 0x004108BC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUISprite)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickLordBtn))
		};
	}

	// Token: 0x06010C1F RID: 68639 RVA: 0x00412765 File Offset: 0x00410965
	protected override void OnStart()
	{
		this.LordToggle = base.GetExtendToggle(0);
		this.LordToggle.CanExecuteChange.Bind(new Func<bool>(this.CanExecuteChange));
	}

	// Token: 0x06010C20 RID: 68640 RVA: 0x00412790 File Offset: 0x00410990
	protected override void OnBeforeDestroy()
	{
		this.OnClickBack = null;
		this.LordId = -1;
	}

	// Token: 0x06010C21 RID: 68641 RVA: 0x004127A0 File Offset: 0x004109A0
	public void Refresh(int data, bool isSelected, int gridIndex)
	{
		this.RefreshByLordId(data);
		this.LordToggle.SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06010C22 RID: 68642 RVA: 0x004127BF File Offset: 0x004109BF
	public void Clear()
	{
	}

	// Token: 0x06010C23 RID: 68643 RVA: 0x004127C1 File Offset: 0x004109C1
	public void OnSelected(bool fireEvent)
	{
		this.LordToggle.SetToggleState(EToggleState.ETT_Checked, fireEvent, false, false);
	}

	// Token: 0x06010C24 RID: 68644 RVA: 0x004127D3 File Offset: 0x004109D3
	public void OnDeselected(bool fireEvent)
	{
		this.LordToggle.SetToggleState(EToggleState.ETT_UnChecked, fireEvent, false, false);
	}

	// Token: 0x06010C25 RID: 68645 RVA: 0x004127E5 File Offset: 0x004109E5
	[NullableContext(1)]
	public object GetKey(int data, int gridIndex)
	{
		return this.LordId;
	}

	// Token: 0x06010C26 RID: 68646 RVA: 0x004127F4 File Offset: 0x004109F4
	public void RefreshByLordId(int lordId)
	{
		this.LordId = lordId;
		base.GetItem(3).SetUIActive(!LordGymModel.Instance.GetLordGymIsUnLock(this.LordId) || !LordGymModel.Instance.GetLastGymFinish(this.LordId));
		LordGym? lordGymConfig = LordGymConfig.Instance.GetLordGymConfig(this.LordId);
		if (lordGymConfig == null)
		{
			return;
		}
		LordGym value = lordGymConfig.Value;
		base.GetItem(4).SetUIActive(!ExchangeRewardModel.Instance.GetRewardIfCanExchange(value.RewardId));
		this.SetSpriteByPath(value.IconPath, base.GetSprite(2), false, null, null);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), value.GymTitle, Array.Empty<object>());
	}

	// Token: 0x06010C27 RID: 68647 RVA: 0x004128BB File Offset: 0x00410ABB
	private void OnClickLordBtn(EToggleState toggleState)
	{
		if (this.OnClickBack != null)
		{
			this.OnClickBack(this.LordId);
		}
	}

	// Token: 0x06010C28 RID: 68648 RVA: 0x004128D6 File Offset: 0x00410AD6
	private bool CanExecuteChange()
	{
		return this.LordCanExecuteChange == null || this.LordCanExecuteChange(this.LordId);
	}

	// Token: 0x04007F82 RID: 32642
	private int LordId = -1;

	// Token: 0x04007F83 RID: 32643
	[Nullable(2)]
	private Action<int> OnClickBack;

	// Token: 0x04007F84 RID: 32644
	[Nullable(2)]
	private readonly Func<int, bool> LordCanExecuteChange;

	// Token: 0x04007F85 RID: 32645
	[Nullable(2)]
	private UUIExtendToggle LordToggle;

	// Token: 0x020086DF RID: 34527
	private class EChildType
	{
		// Token: 0x0402BE27 RID: 179751
		public const int LordToggle = 0;

		// Token: 0x0402BE28 RID: 179752
		public const int LevelText = 1;

		// Token: 0x0402BE29 RID: 179753
		public const int IconSprite = 2;

		// Token: 0x0402BE2A RID: 179754
		public const int LockItem = 3;

		// Token: 0x0402BE2B RID: 179755
		public const int FinishItem = 4;
	}
}
