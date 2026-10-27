using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020013C8 RID: 5064
[NullableContext(1)]
[Nullable(0)]
public class NewPlayerSupportTrialRoleListItem : UiPanelBase
{
	// Token: 0x06008EEA RID: 36586 RVA: 0x001EDC66 File Offset: 0x001EBE66
	public NewPlayerSupportTrialRoleListItem(TrialRoleGroupData trialRoleData)
	{
		this.TrialRoleData = trialRoleData;
	}

	// Token: 0x06008EEB RID: 36587 RVA: 0x001EDC78 File Offset: 0x001EBE78
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

	// Token: 0x06008EEC RID: 36588 RVA: 0x001EDD50 File Offset: 0x001EBF50
	protected override void OnStart()
	{
		this.ExtendToggle = base.GetExtendToggle(0);
		this.ExtendToggle.CanExecuteChange.Bind(new Func<bool>(this.CanExecuteChange));
		this.RefreshView();
		RedDotController.Instance.BindRedDot(ERedDotName.RedDotTrialRoleGroup, base.GetItem(6), null, this.TrialRoleData.TrialRoleGroupId);
	}

	// Token: 0x06008EED RID: 36589 RVA: 0x001EDDAE File Offset: 0x001EBFAE
	protected override void OnBeforeDestroy()
	{
		RedDotController.Instance.UnBindGivenUi(ERedDotName.RedDotTrialRoleGroup, base.GetItem(6), this.TrialRoleData.TrialRoleGroupId);
	}

	// Token: 0x06008EEE RID: 36590 RVA: 0x001EDDD4 File Offset: 0x001EBFD4
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

	// Token: 0x06008EEF RID: 36591 RVA: 0x001EDEBC File Offset: 0x001EC0BC
	public void SetSelectCallback(Action<NewPlayerSupportTrialRoleListItem, int> callback)
	{
		this.OnSelectCallback = callback;
	}

	// Token: 0x06008EF0 RID: 36592 RVA: 0x001EDEC8 File Offset: 0x001EC0C8
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

	// Token: 0x06008EF1 RID: 36593 RVA: 0x001EDF0C File Offset: 0x001EC10C
	public void SelectItem()
	{
		if (this.OnSelectCallback != null)
		{
			this.OnSelectCallback(this, this.TrialRoleData.TrialRoleGroupId);
		}
	}

	// Token: 0x06008EF2 RID: 36594 RVA: 0x001EDF2D File Offset: 0x001EC12D
	private void OnSelectItem(EToggleState state)
	{
		this.SelectItem();
	}

	// Token: 0x06008EF3 RID: 36595 RVA: 0x001EDF35 File Offset: 0x001EC135
	public void SetCanSelectCallback(Func<bool> callback)
	{
		this.CanSelectCallback = callback;
	}

	// Token: 0x06008EF4 RID: 36596 RVA: 0x001EDF3E File Offset: 0x001EC13E
	private bool CanExecuteChange()
	{
		return this.CanSelectCallback == null || this.CanSelectCallback();
	}

	// Token: 0x04003F31 RID: 16177
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<NewPlayerSupportTrialRoleListItem, int> OnSelectCallback;

	// Token: 0x04003F32 RID: 16178
	[Nullable(2)]
	private Func<bool> CanSelectCallback;

	// Token: 0x04003F33 RID: 16179
	[Nullable(2)]
	private readonly TrialRoleGroupData TrialRoleData;

	// Token: 0x04003F34 RID: 16180
	[Nullable(2)]
	private UUIExtendToggle ExtendToggle;

	// Token: 0x02007A4D RID: 31309
	[NullableContext(0)]
	private static class EComponentType
	{
		// Token: 0x04028410 RID: 164880
		public const int RoleItem = 0;

		// Token: 0x04028411 RID: 164881
		public const int RoleBg = 1;

		// Token: 0x04028412 RID: 164882
		public const int RoleLockBg = 2;

		// Token: 0x04028413 RID: 164883
		public const int RoleTex = 3;

		// Token: 0x04028414 RID: 164884
		public const int NormalItem = 4;

		// Token: 0x04028415 RID: 164885
		public const int LockItem = 5;

		// Token: 0x04028416 RID: 164886
		public const int RedDotItem = 6;
	}
}
