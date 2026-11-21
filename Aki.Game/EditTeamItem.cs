using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020007C3 RID: 1987
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class EditTeamItem : GridProxyAbstract<EditTeamData>
{
	// Token: 0x06005AC3 RID: 23235 RVA: 0x001D64B8 File Offset: 0x001D46B8
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

	// Token: 0x06005AC4 RID: 23236 RVA: 0x001D6618 File Offset: 0x001D4818
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

	// Token: 0x06005AC5 RID: 23237 RVA: 0x001D6664 File Offset: 0x001D4864
	protected override UniTask OnBeforeStartAsync()
	{
		EditTeamItem.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<EditTeamItem.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06005AC6 RID: 23238 RVA: 0x001D66A8 File Offset: 0x001D48A8
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

	// Token: 0x06005AC7 RID: 23239 RVA: 0x001D6848 File Offset: 0x001D4A48
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

	// Token: 0x06005AC8 RID: 23240 RVA: 0x001D6885 File Offset: 0x001D4A85
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

	// Token: 0x06005AC9 RID: 23241 RVA: 0x001D68C4 File Offset: 0x001D4AC4
	private void OnToggle(EToggleState state)
	{
		this.ReadRedDot();
		this.OnClickEvent(this.Data.Id, state == EToggleState.ETT_Checked, base.GridIndex);
	}

	// Token: 0x06005ACA RID: 23242 RVA: 0x001D68EC File Offset: 0x001D4AEC
	private bool OnCanExecuteChange()
	{
		EToggleState toggleState = base.GetExtendToggle(0).ToggleState;
		return this.CanExecuteChange == null || this.CanExecuteChange(this.Data.Id, toggleState);
	}

	// Token: 0x06005ACB RID: 23243 RVA: 0x001D6927 File Offset: 0x001D4B27
	public void SetClickEvent(TEditTeamClick onClickEvent)
	{
		this.OnClickEvent = onClickEvent;
	}

	// Token: 0x06005ACC RID: 23244 RVA: 0x001D6930 File Offset: 0x001D4B30
	[NullableContext(2)]
	public void SetCanExecuteChange(TEditTeamCanExecuteChange canExecuteChange)
	{
		this.CanExecuteChange = canExecuteChange;
	}

	// Token: 0x06005ACD RID: 23245 RVA: 0x001D6939 File Offset: 0x001D4B39
	[NullableContext(2)]
	public void SetIsItemSelected(TEditTeamItemSelected isItemSelected)
	{
		this.IsItemSelected = isItemSelected;
	}

	// Token: 0x06005ACE RID: 23246 RVA: 0x001D6942 File Offset: 0x001D4B42
	public void SetToggleState(bool isSelected, bool bFireEvent = false)
	{
		base.GetExtendToggle(0).SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, bFireEvent, false, false);
	}

	// Token: 0x06005ACF RID: 23247 RVA: 0x001D695B File Offset: 0x001D4B5B
	public override void OnSelected(bool fireEvent)
	{
		this.SetToggleState(true, fireEvent);
	}

	// Token: 0x06005AD0 RID: 23248 RVA: 0x001D6965 File Offset: 0x001D4B65
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleState(false, false);
	}

	// Token: 0x04003CEF RID: 15599
	protected List<CharacterItem> CharacterList = new List<CharacterItem>();

	// Token: 0x04003CF0 RID: 15600
	protected TEditTeamClick OnClickEvent;

	// Token: 0x04003CF1 RID: 15601
	[Nullable(2)]
	protected TEditTeamCanExecuteChange CanExecuteChange;

	// Token: 0x04003CF2 RID: 15602
	[Nullable(2)]
	protected TEditTeamItemSelected IsItemSelected;

	// Token: 0x04003CF3 RID: 15603
	protected EditTeamData Data;

	// Token: 0x04003CF4 RID: 15604
	protected bool RedDotState;

	// Token: 0x02006AD5 RID: 27349
	[NullableContext(0)]
	private static class EEditTeamItem
	{
		// Token: 0x0402325B RID: 143963
		public const int Toggle = 0;

		// Token: 0x0402325C RID: 143964
		public const int RoleIcon = 1;

		// Token: 0x0402325D RID: 143965
		public const int RoleLockIcon = 2;

		// Token: 0x0402325E RID: 143966
		public const int RoleLevel = 3;

		// Token: 0x0402325F RID: 143967
		public const int RoleName = 4;

		// Token: 0x04023260 RID: 143968
		public const int FirstCharacterItem = 5;

		// Token: 0x04023261 RID: 143969
		public const int SecondCharacterItem = 6;

		// Token: 0x04023262 RID: 143970
		public const int ThirdCharacterItem = 7;

		// Token: 0x04023263 RID: 143971
		public const int LockItem = 8;

		// Token: 0x04023264 RID: 143972
		public const int LockText = 9;

		// Token: 0x04023265 RID: 143973
		public const int UnlockItem = 10;

		// Token: 0x04023266 RID: 143974
		public const int RedDot = 11;

		// Token: 0x04023267 RID: 143975
		public const int TaskTipItem = 12;
	}
}
