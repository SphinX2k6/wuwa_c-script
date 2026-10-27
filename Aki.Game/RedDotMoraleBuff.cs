using System;

// Token: 0x020033CA RID: 13258
public class RedDotMoraleBuff : RedDotBase
{
	// Token: 0x0601CBE0 RID: 117728 RVA: 0x00808F72 File Offset: 0x00807172
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.Morale);
	}
}
