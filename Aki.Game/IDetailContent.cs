using System;
using System.Runtime.CompilerServices;

// Token: 0x0200246A RID: 9322
[NullableContext(1)]
public interface IDetailContent
{
	// Token: 0x06012B8B RID: 76683
	void SetUiActive(bool active);

	// Token: 0x06012B8C RID: 76684
	void Refresh(PhantomInteractDetailViewModel viewModel);

	// Token: 0x06012B8D RID: 76685
	void SetScrollListenerActive(bool active);
}
