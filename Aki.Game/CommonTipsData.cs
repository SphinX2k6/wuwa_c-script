using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common;

// Token: 0x02000E88 RID: 3720
public class CommonTipsData : CommonTipsBaseData
{
	// Token: 0x0400574E RID: 22350
	public int CurrentStar;

	// Token: 0x0400574F RID: 22351
	public int MaxStar;

	// Token: 0x04005750 RID: 22352
	[Nullable(1)]
	public List<CSharpScript.Game.Module.Common.AttributeData> AttributeList = new List<CSharpScript.Game.Module.Common.AttributeData>();
}
