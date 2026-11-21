using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo.Controller.GameplayEntity
{
	// Token: 0x020036A1 RID: 13985
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class GearTrapMoveStep : IGearTrapMoveStep
	{
		// Token: 0x17004A26 RID: 18982
		// (get) Token: 0x060244B1 RID: 148657 RVA: 0x00A436AC File Offset: 0x00A418AC
		// (set) Token: 0x060244B2 RID: 148658 RVA: 0x00A436B4 File Offset: 0x00A418B4
		[RequiredMember]
		public Vector Direction { get; set; }

		// Token: 0x17004A27 RID: 18983
		// (get) Token: 0x060244B3 RID: 148659 RVA: 0x00A436BD File Offset: 0x00A418BD
		// (set) Token: 0x060244B4 RID: 148660 RVA: 0x00A436C5 File Offset: 0x00A418C5
		[RequiredMember]
		public Vector TargetCoordinate { get; set; }

		// Token: 0x060244B5 RID: 148661 RVA: 0x00A436CE File Offset: 0x00A418CE
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public GearTrapMoveStep()
		{
		}
	}
}
