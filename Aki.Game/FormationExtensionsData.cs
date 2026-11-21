using System;
using System.Runtime.CompilerServices;

// Token: 0x020010B4 RID: 4276
[NullableContext(2)]
[Nullable(0)]
public class FormationExtensionsData
{
	// Token: 0x0600A95C RID: 43356 RVA: 0x0031D301 File Offset: 0x0031B501
	public void Clear()
	{
		this.DangoExtensionData = null;
		this.PhantomExtensionData = null;
		this.TrialRoleExtensionData = null;
	}

	// Token: 0x04006283 RID: 25219
	public object DangoExtensionData;

	// Token: 0x04006284 RID: 25220
	public object PhantomExtensionData;

	// Token: 0x04006285 RID: 25221
	public object TrialRoleExtensionData;
}
