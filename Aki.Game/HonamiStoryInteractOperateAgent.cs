using System;
using System.Runtime.CompilerServices;

// Token: 0x02001E95 RID: 7829
[NullableContext(2)]
[Nullable(0)]
public class HonamiStoryInteractOperateAgent
{
	// Token: 0x0600F015 RID: 61461 RVA: 0x00397E0E File Offset: 0x0039600E
	public void Clear()
	{
		this.StartOperateBackpack = null;
		this.OperateData = null;
		this.BaseHeight = 0f;
		this.BaseWidth = 0f;
		this.TargetOperateBackpack = null;
		this.TargetPosition = -1;
	}

	// Token: 0x04006F0F RID: 28431
	public HonamiStoryBackpackPanelBase StartOperateBackpack;

	// Token: 0x04006F10 RID: 28432
	public HonamiStoryItemDataBase OperateData;

	// Token: 0x04006F11 RID: 28433
	public float BaseWidth;

	// Token: 0x04006F12 RID: 28434
	public float BaseHeight;

	// Token: 0x04006F13 RID: 28435
	public HonamiStoryBackpackPanelBase TargetOperateBackpack;

	// Token: 0x04006F14 RID: 28436
	public int TargetPosition = -1;
}
