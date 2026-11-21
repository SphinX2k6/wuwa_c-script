using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.InstanceDungeon.ExchangeReward;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200168B RID: 5771
public class LordGymItem : UiPanelBase, IGridProxy<int>
{
	// Token: 0x0600E0A8 RID: 57512 RVA: 0x0041EF53 File Offset: 0x0041D153
	[NullableContext(1)]
	public LordGymItem(Action<int> onClickBack, Func<int, bool> lordCanExecuteChange)
	{
		this.OnClickBack = onClickBack;
		this.LordCanExecuteChange = lordCanExecuteChange;
	}

	// Token: 0x1700157C RID: 5500
	// (get) Token: 0x0600E0A9 RID: 57513 RVA: 0x0041EF70 File Offset: 0x0041D170
	// (set) Token: 0x0600E0AA RID: 57514 RVA: 0x0041EF78 File Offset: 0x0041D178
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

	// Token: 0x1700157D RID: 5501
	// (get) Token: 0x0600E0AB RID: 57515 RVA: 0x0041EF81 File Offset: 0x0041D181
	// (set) Token: 0x0600E0AC RID: 57516 RVA: 0x0041EF89 File Offset: 0x0041D189
	public int GridIndex { get; set; }

	// Token: 0x1700157E RID: 5502
	// (get) Token: 0x0600E0AD RID: 57517 RVA: 0x0041EF92 File Offset: 0x0041D192
	// (set) Token: 0x0600E0AE RID: 57518 RVA: 0x0041EF9A File Offset: 0x0041D19A
	public int DisplayIndex { get; set; }

	// Token: 0x0600E0AF RID: 57519 RVA: 0x0041EFA4 File Offset: 0x0041D1A4
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

	// Token: 0x0600E0B0 RID: 57520 RVA: 0x0041F04D File Offset: 0x0041D24D
	protected override void OnStart()
	{
		this.LordToggle = base.GetExtendToggle(0);
		this.LordToggle.CanExecuteChange.Bind(new Func<bool>(this.CanExecuteChange));
	}

	// Token: 0x0600E0B1 RID: 57521 RVA: 0x0041F078 File Offset: 0x0041D278
	protected override void OnBeforeDestroy()
	{
		this.OnClickBack = null;
		this.LordId = -1;
	}

	// Token: 0x0600E0B2 RID: 57522 RVA: 0x0041F088 File Offset: 0x0041D288
	public void Refresh(int data, bool isSelected, int gridIndex)
	{
		this.RefreshByLordId(data);
		this.LordToggle.SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0600E0B3 RID: 57523 RVA: 0x0041F0A7 File Offset: 0x0041D2A7
	public void Clear()
	{
	}

	// Token: 0x0600E0B4 RID: 57524 RVA: 0x0041F0A9 File Offset: 0x0041D2A9
	public void OnSelected(bool fireEvent)
	{
		this.LordToggle.SetToggleState(EToggleState.ETT_Checked, fireEvent, false, false);
	}

	// Token: 0x0600E0B5 RID: 57525 RVA: 0x0041F0BB File Offset: 0x0041D2BB
	public void OnDeselected(bool fireEvent)
	{
		this.LordToggle.SetToggleState(EToggleState.ETT_UnChecked, fireEvent, false, false);
	}

	// Token: 0x0600E0B6 RID: 57526 RVA: 0x0041F0CD File Offset: 0x0041D2CD
	[NullableContext(1)]
	public object GetKey(int data, int gridIndex)
	{
		return this.LordId;
	}

	// Token: 0x0600E0B7 RID: 57527 RVA: 0x0041F0DC File Offset: 0x0041D2DC
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

	// Token: 0x0600E0B8 RID: 57528 RVA: 0x0041F1A3 File Offset: 0x0041D3A3
	private void OnClickLordBtn(EToggleState toggleState)
	{
		if (this.OnClickBack != null)
		{
			this.OnClickBack(this.LordId);
		}
	}

	// Token: 0x0600E0B9 RID: 57529 RVA: 0x0041F1BE File Offset: 0x0041D3BE
	private bool CanExecuteChange()
	{
		return this.LordCanExecuteChange == null || this.LordCanExecuteChange(this.LordId);
	}

	// Token: 0x040080C9 RID: 32969
	private int LordId = -1;

	// Token: 0x040080CA RID: 32970
	[Nullable(2)]
	private Action<int> OnClickBack;

	// Token: 0x040080CB RID: 32971
	[Nullable(2)]
	private readonly Func<int, bool> LordCanExecuteChange;

	// Token: 0x040080CC RID: 32972
	[Nullable(2)]
	private UUIExtendToggle LordToggle;

	// Token: 0x0200786A RID: 30826
	private class EChildType
	{
		// Token: 0x04027148 RID: 160072
		public const int LordToggle = 0;

		// Token: 0x04027149 RID: 160073
		public const int LevelText = 1;

		// Token: 0x0402714A RID: 160074
		public const int IconSprite = 2;

		// Token: 0x0402714B RID: 160075
		public const int LockItem = 3;

		// Token: 0x0402714C RID: 160076
		public const int FinishItem = 4;
	}
}
