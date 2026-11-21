using System;
using System.Runtime.CompilerServices;

// Token: 0x02001093 RID: 4243
[NullableContext(2)]
public interface IViewExtension
{
	// Token: 0x0600A87A RID: 43130
	bool ShouldActivate();

	// Token: 0x0600A87B RID: 43131
	void OnViewStart();

	// Token: 0x0600A87C RID: 43132
	void OnViewRefresh();

	// Token: 0x0600A87D RID: 43133
	void OnDetach();

	// Token: 0x0600A87E RID: 43134 RVA: 0x0031929B File Offset: 0x0031749B
	IEnterGateResult ContributeEnterGate()
	{
		return null;
	}
}
