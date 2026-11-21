using System;
using CSharpScript.Game.Input;

// Token: 0x020026B4 RID: 9908
public class IInputBehaviorReleaseEvent
{
	// Token: 0x1700277A RID: 10106
	// (get) Token: 0x06018D58 RID: 101720 RVA: 0x0078A5BE File Offset: 0x007887BE
	// (set) Token: 0x06018D59 RID: 101721 RVA: 0x0078A5C6 File Offset: 0x007887C6
	public EInputAction Action { get; set; }

	// Token: 0x1700277B RID: 10107
	// (get) Token: 0x06018D5A RID: 101722 RVA: 0x0078A5CF File Offset: 0x007887CF
	// (set) Token: 0x06018D5B RID: 101723 RVA: 0x0078A5D7 File Offset: 0x007887D7
	public double ElapsedSinceAnsBegin { get; set; }
}
