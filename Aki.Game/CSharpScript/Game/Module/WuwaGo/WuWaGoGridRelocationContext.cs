using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.WuwaGo.Model;

namespace CSharpScript.Game.Module.WuwaGo
{
	// Token: 0x02003633 RID: 13875
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class WuWaGoGridRelocationContext : IWuWaGoGridRelocationContext
	{
		// Token: 0x1700495B RID: 18779
		// (get) Token: 0x0602400F RID: 147471 RVA: 0x00A33391 File Offset: 0x00A31591
		// (set) Token: 0x06024010 RID: 147472 RVA: 0x00A33399 File Offset: 0x00A31599
		[RequiredMember]
		public WuWaGoGrid Grid { get; set; }

		// Token: 0x1700495C RID: 18780
		// (get) Token: 0x06024011 RID: 147473 RVA: 0x00A333A2 File Offset: 0x00A315A2
		// (set) Token: 0x06024012 RID: 147474 RVA: 0x00A333AA File Offset: 0x00A315AA
		[RequiredMember]
		public Vector StartCoordinate { get; set; }

		// Token: 0x1700495D RID: 18781
		// (get) Token: 0x06024013 RID: 147475 RVA: 0x00A333B3 File Offset: 0x00A315B3
		// (set) Token: 0x06024014 RID: 147476 RVA: 0x00A333BB File Offset: 0x00A315BB
		[RequiredMember]
		public Vector TargetCoordinate { get; set; }

		// Token: 0x06024015 RID: 147477 RVA: 0x00A333C4 File Offset: 0x00A315C4
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public WuWaGoGridRelocationContext()
		{
		}
	}
}
