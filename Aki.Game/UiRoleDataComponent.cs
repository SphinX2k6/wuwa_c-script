using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x02002CAC RID: 11436
public class UiRoleDataComponent : UiModelComponentBase
{
	// Token: 0x17002037 RID: 8247
	// (get) Token: 0x06017E57 RID: 97879 RVA: 0x00613204 File Offset: 0x00611404
	public int RoleDataId
	{
		get
		{
			return this.RoleDataIdInternal;
		}
	}

	// Token: 0x17002038 RID: 8248
	// (get) Token: 0x06017E58 RID: 97880 RVA: 0x0061320C File Offset: 0x0061140C
	public int RoleConfigId
	{
		get
		{
			return this.RoleConfigIdInternal;
		}
	}

	// Token: 0x17002039 RID: 8249
	// (get) Token: 0x06017E59 RID: 97881 RVA: 0x00613214 File Offset: 0x00611414
	public int RoleSkinId
	{
		get
		{
			return this.RoleSkinIdInternal;
		}
	}

	// Token: 0x06017E5A RID: 97882 RVA: 0x0061321C File Offset: 0x0061141C
	protected override void OnInit()
	{
		this.ModelDataComponent = base.Owner.CheckGetComponent<UiModelDataComponent>();
	}

	// Token: 0x06017E5B RID: 97883 RVA: 0x00613230 File Offset: 0x00611430
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

	// Token: 0x06017E5C RID: 97884 RVA: 0x006132CC File Offset: 0x006114CC
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

	// Token: 0x0400B226 RID: 45606
	[Nullable(2)]
	private UiModelDataComponent ModelDataComponent;

	// Token: 0x0400B227 RID: 45607
	private int RoleDataIdInternal;

	// Token: 0x0400B228 RID: 45608
	private int RoleConfigIdInternal;

	// Token: 0x0400B229 RID: 45609
	private int RoleSkinIdInternal;
}
