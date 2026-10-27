using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common;

// Token: 0x020019C9 RID: 6601
public class CommonTipsData : CommonTipsBaseData
{
	// Token: 0x0400569C RID: 22172
	public int CurrentStar;

	// Token: 0x0400569D RID: 22173
	public int MaxStar;

	// Token: 0x0400569E RID: 22174
	[Nullable(1)]
	public List<CSharpScript.Game.Module.Common.AttributeData> AttributeList = new List<CSharpScript.Game.Module.Common.AttributeData>();
}
