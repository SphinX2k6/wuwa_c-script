using System;
using System.Runtime.CompilerServices;

// Token: 0x020021F1 RID: 8689
[NullableContext(2)]
[Nullable(0)]
public class UiAbyssDangoLoadComponent : UiModelLoadComponent
{
	// Token: 0x06015640 RID: 87616 RVA: 0x00637172 File Offset: 0x00635372
	protected override void OnInit()
	{
		base.OnInit();
		this.UiDangoDataComponent = base.Owner.CheckGetComponent<UiDangoDataComponent>();
	}

	// Token: 0x06015641 RID: 87617 RVA: 0x0063718B File Offset: 0x0063538B
	protected override void OnEnd()
	{
		base.OnEnd();
		this.UiDangoDataComponent = null;
	}

	// Token: 0x06015642 RID: 87618 RVA: 0x0063719A File Offset: 0x0063539A
	public void LoadModelByDangoId(int dangoId, int meshId, bool waitMeshStreaming, Action loadFinishCallBack = null)
	{
		this.UiDangoDataComponent.DangoId = dangoId;
		this.UiModelDataComponent.ModelConfigId = meshId;
		this.LoadFinishCallBack = loadFinishCallBack;
		base.LoadModel(waitMeshStreaming, null, 1);
	}

	// Token: 0x0400B551 RID: 46417
	private UiDangoDataComponent UiDangoDataComponent;
}
