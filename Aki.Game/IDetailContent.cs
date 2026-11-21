using System;
using System.Runtime.CompilerServices;

// Token: 0x0200194F RID: 6479
[NullableContext(1)]
public interface IDetailContent
{
	// Token: 0x06010043 RID: 65603
	void SetUiActive(bool active);

	// Token: 0x06010044 RID: 65604
	void Refresh(PhantomInteractDetailViewModel viewModel);

	// Token: 0x06010045 RID: 65605
	void SetScrollListenerActive(bool active);
}
