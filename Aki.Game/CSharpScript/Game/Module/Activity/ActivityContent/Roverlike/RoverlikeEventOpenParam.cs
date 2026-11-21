using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02005080 RID: 20608
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeEventOpenParam : IRoverlikeEventOpenParam
	{
		// Token: 0x170064CD RID: 25805
		// (get) Token: 0x06033956 RID: 211286 RVA: 0x00E70A25 File Offset: 0x00E6EC25
		// (set) Token: 0x06033957 RID: 211287 RVA: 0x00E70A2D File Offset: 0x00E6EC2D
		public int EventIncId { get; set; }

		// Token: 0x170064CE RID: 25806
		// (get) Token: 0x06033958 RID: 211288 RVA: 0x00E70A36 File Offset: 0x00E6EC36
		// (set) Token: 0x06033959 RID: 211289 RVA: 0x00E70A3E File Offset: 0x00E6EC3E
		public List<int> ChoiceList { get; set; } = new List<int>();
	}
}
