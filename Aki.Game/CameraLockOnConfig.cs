using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Fight.Struct;

// Token: 0x0200303E RID: 12350
[NullableContext(1)]
[Nullable(0)]
public class CameraLockOnConfig
{
	// Token: 0x0601A318 RID: 107288 RVA: 0x006E3A6D File Offset: 0x006E1C6D
	public CameraLockOnConfig(SCameraLockOnConfig config)
	{
		this.IsEnabled = config.IsEnabled;
		this.CameraLockOnBoneName = config.CameraLockOnBoneName;
	}

	// Token: 0x0400C735 RID: 50997
	public bool IsEnabled;

	// Token: 0x0400C736 RID: 50998
	public string CameraLockOnBoneName = "";
}
