using System;
using System.Runtime.CompilerServices;

// Token: 0x02002C9B RID: 11419
[NullableContext(2)]
[Nullable(0)]
public class UiDangoLoadComponent : UiModelLoadComponent
{
	// Token: 0x06017DD9 RID: 97753 RVA: 0x006117BF File Offset: 0x0060F9BF
	protected override void OnInit()
	{
		base.OnInit();
		this.UiDangoDataComponent = base.Owner.CheckGetComponent<UiDangoDataComponent>();
	}

	// Token: 0x06017DDA RID: 97754 RVA: 0x006117D8 File Offset: 0x0060F9D8
	protected override void OnEnd()
	{
		base.OnEnd();
		this.UiDangoDataComponent = null;
	}

	// Token: 0x06017DDB RID: 97755 RVA: 0x006117E8 File Offset: 0x0060F9E8
	public void LoadModelByDangoId(int id, bool waitMeshStreaming, Action loadFinishCallBack = null)
	{
		this.UiDangoDataComponent.DangoId = id;
		DangoData dangoData = DangoManager.Instance.GetDangoData(id);
		this.UiModelDataComponent.ModelConfigId = dangoData.ModelId;
		this.LoadFinishCallBack = loadFinishCallBack;
		base.LoadModel(waitMeshStreaming, null, 1);
	}

	// Token: 0x0400B1EB RID: 45547
	private UiDangoDataComponent UiDangoDataComponent;
}
