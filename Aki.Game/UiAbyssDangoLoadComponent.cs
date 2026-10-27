using System;
using System.Runtime.CompilerServices;

// Token: 0x02002C98 RID: 11416
[NullableContext(2)]
[Nullable(0)]
public class UiAbyssDangoLoadComponent : UiModelLoadComponent
{
	// Token: 0x06017DCC RID: 97740 RVA: 0x006115CE File Offset: 0x0060F7CE
	protected override void OnInit()
	{
		base.OnInit();
		this.UiDangoDataComponent = base.Owner.CheckGetComponent<UiDangoDataComponent>();
	}

	// Token: 0x06017DCD RID: 97741 RVA: 0x006115E7 File Offset: 0x0060F7E7
	protected override void OnEnd()
	{
		base.OnEnd();
		this.UiDangoDataComponent = null;
	}

	// Token: 0x06017DCE RID: 97742 RVA: 0x006115F6 File Offset: 0x0060F7F6
	public void LoadModelByDangoId(int dangoId, int meshId, bool waitMeshStreaming, Action loadFinishCallBack = null)
	{
		this.UiDangoDataComponent.DangoId = dangoId;
		this.UiModelDataComponent.ModelConfigId = meshId;
		this.LoadFinishCallBack = loadFinishCallBack;
		base.LoadModel(waitMeshStreaming, null, 1);
	}

	// Token: 0x0400B1E6 RID: 45542
	private UiDangoDataComponent UiDangoDataComponent;
}
