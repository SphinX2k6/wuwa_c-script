using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Fight.Struct;

// Token: 0x02002594 RID: 9620
[NullableContext(1)]
[Nullable(0)]
public class CameraLockOnConfig
{
	// Token: 0x06017C82 RID: 97410 RVA: 0x0070B5F5 File Offset: 0x007097F5
	public CameraLockOnConfig(SCameraLockOnConfig config)
	{
		this.IsEnabled = config.IsEnabled;
		this.CameraLockOnBoneName = config.CameraLockOnBoneName;
	}

	// Token: 0x0400CB0E RID: 51982
	public bool IsEnabled;

	// Token: 0x0400CB0F RID: 51983
	public string CameraLockOnBoneName = "";
}
