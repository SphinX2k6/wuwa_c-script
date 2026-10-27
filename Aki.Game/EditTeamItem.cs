using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200130F RID: 4879
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class EditTeamItem : GridProxyAbstract<EditTeamData>
{
	// Token: 0x06008728 RID: 34600 RVA: 0x001CD64C File Offset: 0x001CB84C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIText)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggle))
		};
	}

	// Token: 0x06008729 RID: 34601 RVA: 0x001CD7AC File Offset: 0x001CB9AC
	private UniTask InitCharacterItem(UUIItem uiItem)
	{
		EditTeamItem.<InitCharacterItem>d__8 <InitCharacterItem>d__;
		<InitCharacterItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitCharacterItem>d__.<>4__this = this;
		<InitCharacterItem>d__.uiItem = uiItem;
		<InitCharacterItem>d__.<>1__state = -1;
		<InitCharacterItem>d__.<>t__builder.Start<EditTeamItem.<InitCharacterItem>d__8>(ref <InitCharacterItem>d__);
		return <InitCharacterItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600872A RID: 34602 RVA: 0x001CD7F8 File Offset: 0x001CB9F8
	protected override UniTask OnBeforeStartAsync()
	{
		EditTeamItem.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<EditTeamItem.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600872B RID: 34603 RVA: 0x001CD83C File Offset: 0x001CBA3C
	public override void Refresh(EditTeamData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		base.GetItem(8).SetUIActive(!data.IsOwn);
		base.GetItem(10).SetUIActive(data.IsOwn);
		base.GetTexture(2).SetUIActive(!data.IsOwn);
		base.GetTexture(1).SetUIActive(data.IsOwn);
		EntrustRole entrustRoleById = BusinessConfig.Instance.GetEntrustRoleById(this.Data.Id);
		EEditTeamDataUnLockState teamDataUnLockState = data.GetTeamDataUnLockState();
		base.GetItem(12).SetUIActive(teamDataUnLockState == EEditTeamDataUnLockState.TaskUnFinish);
		if (!data.IsOwn)
		{
			this.SetToggleState(false, false);
			string unLockConditionDesc = data.GetUnLockConditionDesc();
			base.GetText(9).SetText(unLockConditionDesc, true);
			base.SetTextureByPath(entrustRoleById.Icon, base.GetTexture(2), null, null);
			return;
		}
		TEditTeamItemSelected isItemSelected = this.IsItemSelected;
		bool isSelected2 = (isItemSelected != null) ? isItemSelected(this.Data.Id) : isSelected;
		this.SetToggleState(isSelected2, false);
		List<CharacterData> characterDataList = data.GetCharacterDataList();
		for (int i = 0; i < characterDataList.Count; i++)
		{
			this.CharacterList[i].Refresh(characterDataList[i], false, 0);
		}
		base.SetTextureByPath(entrustRoleById.Icon, base.GetTexture(1), null, null);
		base.GetText(3).SetText(this.Data.Level.ToString(), true);
		base.GetText(4).SetText(this.Data.Name, true);
		this.RefreshRedDot(this.Data.Id);
	}

	// Token: 0x0600872C RID: 34604 RVA: 0x001CD9DC File Offset: 0x001CBBDC
	public void RefreshRedDot(int roleId)
	{
		bool flag = MoonChasingModel.Instance.CheckRoleIdRedDotState(roleId);
		if (this.RedDotState == flag)
		{
			return;
		}
		this.RedDotState = flag;
		base.GetItem(11).SetUIActive(this.RedDotState);
	}

	// Token: 0x0600872D RID: 34605 RVA: 0x001CDA19 File Offset: 0x001CBC19
	private void ReadRedDot()
	{
		if (!this.RedDotState)
		{
			return;
		}
		if (!this.Data.IsOwn)
		{
			return;
		}
		MoonChasingModel.Instance.ReadRoleIdUnlockFlag(this.Data.Id);
		this.RefreshRedDot(this.Data.Id);
	}

	// Token: 0x0600872E RID: 34606 RVA: 0x001CDA58 File Offset: 0x001CBC58
	private void OnToggle(EToggleState state)
	{
		this.ReadRedDot();
		this.OnClickEvent(this.Data.Id, state == EToggleState.ETT_Checked, base.GridIndex);
	}

	// Token: 0x0600872F RID: 34607 RVA: 0x001CDA80 File Offset: 0x001CBC80
	private bool OnCanExecuteChange()
	{
		EToggleState toggleState = base.GetExtendToggle(0).ToggleState;
		return this.CanExecuteChange == null || this.CanExecuteChange(this.Data.Id, toggleState);
	}

	// Token: 0x06008730 RID: 34608 RVA: 0x001CDABB File Offset: 0x001CBCBB
	public void SetClickEvent(TEditTeamClick onClickEvent)
	{
		this.OnClickEvent = onClickEvent;
	}

	// Token: 0x06008731 RID: 34609 RVA: 0x001CDAC4 File Offset: 0x001CBCC4
	[NullableContext(2)]
	public void SetCanExecuteChange(TEditTeamCanExecuteChange canExecuteChange)
	{
		this.CanExecuteChange = canExecuteChange;
	}

	// Token: 0x06008732 RID: 34610 RVA: 0x001CDACD File Offset: 0x001CBCCD
	[NullableContext(2)]
	public void SetIsItemSelected(TEditTeamItemSelected isItemSelected)
	{
		this.IsItemSelected = isItemSelected;
	}

	// Token: 0x06008733 RID: 34611 RVA: 0x001CDAD6 File Offset: 0x001CBCD6
	public void SetToggleState(bool isSelected, bool bFireEvent = false)
	{
		base.GetExtendToggle(0).SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, bFireEvent, false, false);
	}

	// Token: 0x06008734 RID: 34612 RVA: 0x001CDAEF File Offset: 0x001CBCEF
	public override void OnSelected(bool fireEvent)
	{
		this.SetToggleState(true, fireEvent);
	}

	// Token: 0x06008735 RID: 34613 RVA: 0x001CDAF9 File Offset: 0x001CBCF9
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleState(false, false);
	}

	// Token: 0x04003C57 RID: 15447
	protected List<CharacterItem> CharacterList = new List<CharacterItem>();

	// Token: 0x04003C58 RID: 15448
	protected TEditTeamClick OnClickEvent;

	// Token: 0x04003C59 RID: 15449
	[Nullable(2)]
	protected TEditTeamCanExecuteChange CanExecuteChange;

	// Token: 0x04003C5A RID: 15450
	[Nullable(2)]
	protected TEditTeamItemSelected IsItemSelected;

	// Token: 0x04003C5B RID: 15451
	protected EditTeamData Data;

	// Token: 0x04003C5C RID: 15452
	protected bool RedDotState;

	// Token: 0x0200794B RID: 31051
	[NullableContext(0)]
	private static class EEditTeamItem
	{
		// Token: 0x04027F2E RID: 163630
		public const int Toggle = 0;

		// Token: 0x04027F2F RID: 163631
		public const int RoleIcon = 1;

		// Token: 0x04027F30 RID: 163632
		public const int RoleLockIcon = 2;

		// Token: 0x04027F31 RID: 163633
		public const int RoleLevel = 3;

		// Token: 0x04027F32 RID: 163634
		public const int RoleName = 4;

		// Token: 0x04027F33 RID: 163635
		public const int FirstCharacterItem = 5;

		// Token: 0x04027F34 RID: 163636
		public const int SecondCharacterItem = 6;

		// Token: 0x04027F35 RID: 163637
		public const int ThirdCharacterItem = 7;

		// Token: 0x04027F36 RID: 163638
		public const int LockItem = 8;

		// Token: 0x04027F37 RID: 163639
		public const int LockText = 9;

		// Token: 0x04027F38 RID: 163640
		public const int UnlockItem = 10;

		// Token: 0x04027F39 RID: 163641
		public const int RedDot = 11;

		// Token: 0x04027F3A RID: 163642
		public const int TaskTipItem = 12;
	}
}
