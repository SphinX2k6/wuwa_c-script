using System;
using System.Runtime.CompilerServices;

// Token: 0x0200221B RID: 8731
[NullableContext(1)]
[Nullable(0)]
public class UiModelCreateData
{
	// Token: 0x06015796 RID: 87958 RVA: 0x0063C920 File Offset: 0x0063AB20
	public UiModelCreateData(EUiModelType modelType, EUiModelActorType modelActorType, EUiModelUseWay modelUseWay, Type[] components)
	{
		this.ModelType = modelType;
		this.ModelActorType = modelActorType;
		this.ModelUseWay = modelUseWay;
		this.Components = components;
	}

	// Token: 0x0400B5E4 RID: 46564
	public EUiModelType ModelType;

	// Token: 0x0400B5E5 RID: 46565
	public EUiModelActorType ModelActorType;

	// Token: 0x0400B5E6 RID: 46566
	public EUiModelUseWay ModelUseWay;

	// Token: 0x0400B5E7 RID: 46567
	public Type[] Components;
}
