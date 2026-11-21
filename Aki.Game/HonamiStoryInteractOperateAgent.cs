using System;
using System.Runtime.CompilerServices;

// Token: 0x02001357 RID: 4951
[NullableContext(2)]
[Nullable(0)]
public class HonamiStoryInteractOperateAgent
{
	// Token: 0x0600C434 RID: 50228 RVA: 0x003A39CA File Offset: 0x003A1BCA
	public void Clear()
	{
		this.StartOperateBackpack = null;
		this.OperateData = null;
		this.BaseHeight = 0f;
		this.BaseWidth = 0f;
		this.TargetOperateBackpack = null;
		this.TargetPosition = -1;
	}

	// Token: 0x04006FF0 RID: 28656
	public HonamiStoryBackpackPanelBase StartOperateBackpack;

	// Token: 0x04006FF1 RID: 28657
	public HonamiStoryItemDataBase OperateData;

	// Token: 0x04006FF2 RID: 28658
	public float BaseWidth;

	// Token: 0x04006FF3 RID: 28659
	public float BaseHeight;

	// Token: 0x04006FF4 RID: 28660
	public HonamiStoryBackpackPanelBase TargetOperateBackpack;

	// Token: 0x04006FF5 RID: 28661
	public int TargetPosition = -1;
}
