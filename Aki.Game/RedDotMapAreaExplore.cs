using System;

// Token: 0x020033BD RID: 13245
public class RedDotMapAreaExplore : RedDotBase
{
	// Token: 0x0601CBA9 RID: 117673 RVA: 0x00808A9D File Offset: 0x00806C9D
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.FunctionMap);
	}
}
