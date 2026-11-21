using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200087C RID: 2172
[NullableContext(1)]
[Nullable(0)]
public class NewPlayerSupportTrialRoleListItem : UiPanelBase
{
	// Token: 0x0600627F RID: 25215 RVA: 0x001F6786 File Offset: 0x001F4986
	public NewPlayerSupportTrialRoleListItem(TrialRoleGroupData trialRoleData)
	{
		this.TrialRoleData = trialRoleData;
	}

	// Token: 0x06006280 RID: 25216 RVA: 0x001F6798 File Offset: 0x001F4998
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUITexture)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnSelectItem))
		};
	}

	// Token: 0x06006281 RID: 25217 RVA: 0x001F6870 File Offset: 0x001F4A70
	protected override void OnStart()
	{
		this.ExtendToggle = base.GetExtendToggle(0);
		this.ExtendToggle.CanExecuteChange.Bind(new Func<bool>(this.CanExecuteChange));
		this.RefreshView();
		RedDotController.Instance.BindRedDot(ERedDotName.RedDotTrialRoleGroup, base.GetItem(6), null, this.TrialRoleData.TrialRoleGroupId);
	}

	// Token: 0x06006282 RID: 25218 RVA: 0x001F68CE File Offset: 0x001F4ACE
	protected override void OnBeforeDestroy()
	{
		RedDotController.Instance.UnBindGivenUi(ERedDotName.RedDotTrialRoleGroup, base.GetItem(6), this.TrialRoleData.TrialRoleGroupId);
	}

	// Token: 0x06006283 RID: 25219 RVA: 0x001F68F4 File Offset: 0x001F4AF4
	private void RefreshView()
	{
		bool flag = this.TrialRoleData.IsLocked();
		UUIItem item = base.GetItem(1);
		if (item != null)
		{
			item.SetUIActive(!flag);
		}
		UUIItem item2 = base.GetItem(4);
		if (item2 != null)
		{
			item2.SetUIActive(!flag);
		}
		UUIItem item3 = base.GetItem(2);
		if (item3 != null)
		{
			item3.SetUIActive(flag);
		}
		UUIItem item4 = base.GetItem(5);
		if (item4 != null)
		{
			item4.SetUIActive(flag);
		}
		UUITexture texture = base.GetTexture(3);
		UUIItem uuiitem = texture;
		bool bUseChangeColor = flag;
		FColor? fcolor = new FColor?(texture.changeColor);
		uuiitem.SetChangeColor(bUseChangeColor, fcolor);
		RoleConfig instance = RoleConfig.Instance;
		RoleInfo? roleInfo = (instance != null) ? instance.GetRoleConfig(this.TrialRoleData.RealRoleId) : null;
		string path = ((roleInfo != null) ? roleInfo.GetValueOrDefault().FormationRoleCard : null) ?? "";
		base.SetTextureByPath(path, texture, null, null);
	}

	// Token: 0x06006284 RID: 25220 RVA: 0x001F69DC File Offset: 0x001F4BDC
	public void SetSelectCallback(Action<NewPlayerSupportTrialRoleListItem, int> callback)
	{
		this.OnSelectCallback = callback;
	}

	// Token: 0x06006285 RID: 25221 RVA: 0x001F69E8 File Offset: 0x001F4BE8
	public void SetSelected(bool selected)
	{
		EToggleState state = selected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		UUIExtendToggle extendToggle = this.ExtendToggle;
		if (extendToggle != null)
		{
			extendToggle.SetToggleState(state, false, false, false);
		}
		if (selected)
		{
			TrialRoleModel.Instance.SaveTrialRoleUnlockRedDotById(this.TrialRoleData.TrialRoleGroupId, false);
		}
	}

	// Token: 0x06006286 RID: 25222 RVA: 0x001F6A2C File Offset: 0x001F4C2C
	public void SelectItem()
	{
		if (this.OnSelectCallback != null)
		{
			this.OnSelectCallback(this, this.TrialRoleData.TrialRoleGroupId);
		}
	}

	// Token: 0x06006287 RID: 25223 RVA: 0x001F6A4D File Offset: 0x001F4C4D
	private void OnSelectItem(EToggleState state)
	{
		this.SelectItem();
	}

	// Token: 0x06006288 RID: 25224 RVA: 0x001F6A55 File Offset: 0x001F4C55
	public void SetCanSelectCallback(Func<bool> callback)
	{
		this.CanSelectCallback = callback;
	}

	// Token: 0x06006289 RID: 25225 RVA: 0x001F6A5E File Offset: 0x001F4C5E
	private bool CanExecuteChange()
	{
		return this.CanSelectCallback == null || this.CanSelectCallback();
	}

	// Token: 0x04003FC9 RID: 16329
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<NewPlayerSupportTrialRoleListItem, int> OnSelectCallback;

	// Token: 0x04003FCA RID: 16330
	[Nullable(2)]
	private Func<bool> CanSelectCallback;

	// Token: 0x04003FCB RID: 16331
	[Nullable(2)]
	private readonly TrialRoleGroupData TrialRoleData;

	// Token: 0x04003FCC RID: 16332
	[Nullable(2)]
	private UUIExtendToggle ExtendToggle;

	// Token: 0x02006BD3 RID: 27603
	[NullableContext(0)]
	private static class EComponentType
	{
		// Token: 0x0402372D RID: 145197
		public const int RoleItem = 0;

		// Token: 0x0402372E RID: 145198
		public const int RoleBg = 1;

		// Token: 0x0402372F RID: 145199
		public const int RoleLockBg = 2;

		// Token: 0x04023730 RID: 145200
		public const int RoleTex = 3;

		// Token: 0x04023731 RID: 145201
		public const int NormalItem = 4;

		// Token: 0x04023732 RID: 145202
		public const int LockItem = 5;

		// Token: 0x04023733 RID: 145203
		public const int RedDotItem = 6;
	}
}
