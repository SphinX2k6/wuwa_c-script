using System;
using System.Runtime.CompilerServices;

// Token: 0x020021F4 RID: 8692
[NullableContext(2)]
[Nullable(0)]
public class UiDangoLoadComponent : UiModelLoadComponent
{
	// Token: 0x0601564D RID: 87629 RVA: 0x00637341 File Offset: 0x00635541
	protected override void OnInit()
	{
		base.OnInit();
		this.UiDangoDataComponent = base.Owner.CheckGetComponent<UiDangoDataComponent>();
	}

	// Token: 0x0601564E RID: 87630 RVA: 0x0063735A File Offset: 0x0063555A
	protected override void OnEnd()
	{
		base.OnEnd();
		this.UiDangoDataComponent = null;
	}

	// Token: 0x0601564F RID: 87631 RVA: 0x0063736C File Offset: 0x0063556C
	public void LoadModelByDangoId(int id, bool waitMeshStreaming, Action loadFinishCallBack = null)
	{
		this.UiDangoDataComponent.DangoId = id;
		DangoData dangoData = DangoManager.Instance.GetDangoData(id);
		this.UiModelDataComponent.ModelConfigId = dangoData.ModelId;
		this.LoadFinishCallBack = loadFinishCallBack;
		base.LoadModel(waitMeshStreaming, null, 1);
	}

	// Token: 0x0400B556 RID: 46422
	private UiDangoDataComponent UiDangoDataComponent;
}
