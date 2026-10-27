using System;
using System.Runtime.CompilerServices;

// Token: 0x02002CA2 RID: 11426
[NullableContext(2)]
[Nullable(0)]
public class UiMotorLoadComponent : UiModelLoadComponent
{
	// Token: 0x06017E1D RID: 97821 RVA: 0x006122BC File Offset: 0x006104BC
	protected override void OnInit()
	{
		base.OnInit();
		this.UiMotorDataComponent = base.Owner.CheckGetComponent<UiMotorDataComponent>();
	}

	// Token: 0x06017E1E RID: 97822 RVA: 0x006122D5 File Offset: 0x006104D5
	protected override void OnEnd()
	{
		base.OnEnd();
		this.UiMotorDataComponent = null;
	}

	// Token: 0x06017E1F RID: 97823 RVA: 0x006122E4 File Offset: 0x006104E4
	public void LoadModelBySkinId(int skinId, bool waitMeshStreaming, Action loadFinishCallBack = null, int? roleId = null, int? roleSkinId = null)
	{
		this.UiMotorDataComponent.SetSkinId(skinId);
		this.UiModelDataComponent.ModelConfigId = skinId;
		this.LoadFinishCallBack = loadFinishCallBack;
		if (roleId != null && roleSkinId != null)
		{
			this.UiMotorDataComponent.SetRoleData(roleId.Value, roleSkinId.Value, null);
		}
		base.LoadModel(waitMeshStreaming, null, 1);
	}

	// Token: 0x0400B208 RID: 45576
	private UiMotorDataComponent UiMotorDataComponent;
}
