using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo.Movement
{
	// Token: 0x0200472E RID: 18222
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class GridMoveParticipantExecution : IGridMoveParticipantExecution
	{
		// Token: 0x170076F9 RID: 30457
		// (get) Token: 0x0602F9D5 RID: 195029 RVA: 0x00B07A2C File Offset: 0x00B05C2C
		// (set) Token: 0x0602F9D6 RID: 195030 RVA: 0x00B07A34 File Offset: 0x00B05C34
		[RequiredMember]
		public IWuWaGoGridMoveParticipant Participant { get; set; }

		// Token: 0x170076FA RID: 30458
		// (get) Token: 0x0602F9D7 RID: 195031 RVA: 0x00B07A3D File Offset: 0x00B05C3D
		// (set) Token: 0x0602F9D8 RID: 195032 RVA: 0x00B07A45 File Offset: 0x00B05C45
		[RequiredMember]
		public IWuWaGoGridRelocationContext Context { get; set; }

		// Token: 0x0602F9D9 RID: 195033 RVA: 0x00B07A4E File Offset: 0x00B05C4E
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public GridMoveParticipantExecution()
		{
		}
	}
}
