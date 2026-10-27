using System;
using System.Runtime.CompilerServices;

// Token: 0x02001BF5 RID: 7157
[NullableContext(2)]
[Nullable(0)]
public class FormationExtensionsData
{
	// Token: 0x0600D549 RID: 54601 RVA: 0x0031204D File Offset: 0x0031024D
	public void Clear()
	{
		this.DangoExtensionData = null;
		this.PhantomExtensionData = null;
		this.TrialRoleExtensionData = null;
	}

	// Token: 0x040061B1 RID: 25009
	public object DangoExtensionData;

	// Token: 0x040061B2 RID: 25010
	public object PhantomExtensionData;

	// Token: 0x040061B3 RID: 25011
	public object TrialRoleExtensionData;
}
