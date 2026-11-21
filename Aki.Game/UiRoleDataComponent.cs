using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x02002205 RID: 8709
public class UiRoleDataComponent : UiModelComponentBase
{
	// Token: 0x17002088 RID: 8328
	// (get) Token: 0x060156CB RID: 87755 RVA: 0x00638D88 File Offset: 0x00636F88
	public int RoleDataId
	{
		get
		{
			return this.RoleDataIdInternal;
		}
	}

	// Token: 0x17002089 RID: 8329
	// (get) Token: 0x060156CC RID: 87756 RVA: 0x00638D90 File Offset: 0x00636F90
	public int RoleConfigId
	{
		get
		{
			return this.RoleConfigIdInternal;
		}
	}

	// Token: 0x1700208A RID: 8330
	// (get) Token: 0x060156CD RID: 87757 RVA: 0x00638D98 File Offset: 0x00636F98
	public int RoleSkinId
	{
		get
		{
			return this.RoleSkinIdInternal;
		}
	}

	// Token: 0x060156CE RID: 87758 RVA: 0x00638DA0 File Offset: 0x00636FA0
	protected override void OnInit()
	{
		this.ModelDataComponent = base.Owner.CheckGetComponent<UiModelDataComponent>();
	}

	// Token: 0x060156CF RID: 87759 RVA: 0x00638DB4 File Offset: 0x00636FB4
	public void SetRoleConfigId(int roleConfigId, int skinId = -1)
	{
		this.RoleConfigIdInternal = roleConfigId;
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(roleConfigId);
		this.RoleSkinIdInternal = ((skinId == -1) ? roleConfig.Value.SkinId : skinId);
		if (this.RoleSkinIdInternal <= 0)
		{
			this.ModelDataComponent.ModelConfigId = roleConfig.Value.UiMeshId;
		}
		else
		{
			RoleSkinData roleSkinData = RoleSkinModel.Instance.GetRoleSkinData(this.RoleSkinIdInternal);
			this.ModelDataComponent.ModelConfigId = roleSkinData.GetUiMeshId();
		}
		EventSystem.Instance.EmitWithTarget(base.Owner, EEventName.OnUiModelRoleConfigIdChange);
	}

	// Token: 0x060156D0 RID: 87760 RVA: 0x00638E50 File Offset: 0x00637050
	public void SetRoleDataId(int roleDataId, int skinId = -1)
	{
		this.RoleDataIdInternal = roleDataId;
		RoleModel instance = RoleModel.Instance;
		RoleDataBase roleDataBase = (instance != null) ? instance.GetRoleDataById(roleDataId, true) : null;
		if (roleDataBase == null)
		{
			return;
		}
		this.SetRoleConfigId(roleDataBase.GetRoleId(), skinId);
		EventSystem.Instance.EmitWithTarget(base.Owner, EEventName.OnUiModelRoleDataIdChange);
	}

	// Token: 0x0400B591 RID: 46481
	[Nullable(2)]
	private UiModelDataComponent ModelDataComponent;

	// Token: 0x0400B592 RID: 46482
	private int RoleDataIdInternal;

	// Token: 0x0400B593 RID: 46483
	private int RoleConfigIdInternal;

	// Token: 0x0400B594 RID: 46484
	private int RoleSkinIdInternal;
}
