using System;
using System.Runtime.CompilerServices;

// Token: 0x02001BD4 RID: 7124
[NullableContext(2)]
public interface IViewExtension
{
	// Token: 0x0600D468 RID: 54376
	bool ShouldActivate();

	// Token: 0x0600D469 RID: 54377
	void OnViewStart();

	// Token: 0x0600D46A RID: 54378
	void OnViewRefresh();

	// Token: 0x0600D46B RID: 54379
	void OnDetach();

	// Token: 0x0600D46C RID: 54380 RVA: 0x0030E127 File Offset: 0x0030C327
	IEnterGateResult ContributeEnterGate()
	{
		return null;
	}
}
