using System;

// Token: 0x0200292F RID: 10543
public class RedDotMapAreaExplore : RedDotBase
{
	// Token: 0x0601A8A1 RID: 108705 RVA: 0x0082F061 File Offset: 0x0082D261
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.FunctionMap);
	}
}
