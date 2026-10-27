using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo.Controller.GameplayEntity
{
	// Token: 0x02004770 RID: 18288
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class GearTrapMoveStep : IGearTrapMoveStep
	{
		// Token: 0x1700776A RID: 30570
		// (get) Token: 0x0602FCE7 RID: 195815 RVA: 0x00B136EC File Offset: 0x00B118EC
		// (set) Token: 0x0602FCE8 RID: 195816 RVA: 0x00B136F4 File Offset: 0x00B118F4
		[RequiredMember]
		public Vector Direction { get; set; }

		// Token: 0x1700776B RID: 30571
		// (get) Token: 0x0602FCE9 RID: 195817 RVA: 0x00B136FD File Offset: 0x00B118FD
		// (set) Token: 0x0602FCEA RID: 195818 RVA: 0x00B13705 File Offset: 0x00B11905
		[RequiredMember]
		public Vector TargetCoordinate { get; set; }

		// Token: 0x0602FCEB RID: 195819 RVA: 0x00B1370E File Offset: 0x00B1190E
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public GearTrapMoveStep()
		{
		}
	}
}
