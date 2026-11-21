using System;
using System.Runtime.CompilerServices;

// Token: 0x020021FB RID: 8699
[NullableContext(2)]
[Nullable(0)]
public class UiMotorLoadComponent : UiModelLoadComponent
{
	// Token: 0x06015691 RID: 87697 RVA: 0x00637E40 File Offset: 0x00636040
	protected override void OnInit()
	{
		base.OnInit();
		this.UiMotorDataComponent = base.Owner.CheckGetComponent<UiMotorDataComponent>();
	}

	// Token: 0x06015692 RID: 87698 RVA: 0x00637E59 File Offset: 0x00636059
	protected override void OnEnd()
	{
		base.OnEnd();
		this.UiMotorDataComponent = null;
	}

	// Token: 0x06015693 RID: 87699 RVA: 0x00637E68 File Offset: 0x00636068
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

	// Token: 0x0400B573 RID: 46451
	private UiMotorDataComponent UiMotorDataComponent;
}
