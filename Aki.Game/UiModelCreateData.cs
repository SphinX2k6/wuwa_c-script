using System;
using System.Runtime.CompilerServices;

// Token: 0x02002CC2 RID: 11458
[NullableContext(1)]
[Nullable(0)]
public class UiModelCreateData
{
	// Token: 0x06017F1D RID: 98077 RVA: 0x00616C60 File Offset: 0x00614E60
	public UiModelCreateData(EUiModelType modelType, EUiModelActorType modelActorType, EUiModelUseWay modelUseWay, Type[] components)
	{
		this.ModelType = modelType;
		this.ModelActorType = modelActorType;
		this.ModelUseWay = modelUseWay;
		this.Components = components;
	}

	// Token: 0x0400B279 RID: 45689
	public EUiModelType ModelType;

	// Token: 0x0400B27A RID: 45690
	public EUiModelActorType ModelActorType;

	// Token: 0x0400B27B RID: 45691
	public EUiModelUseWay ModelUseWay;

	// Token: 0x0400B27C RID: 45692
	public Type[] Components;
}
