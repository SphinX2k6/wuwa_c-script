using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo.Movement
{
	// Token: 0x0200365F RID: 13919
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class GridMoveParticipantExecution : IGridMoveParticipantExecution
	{
		// Token: 0x170049B5 RID: 18869
		// (get) Token: 0x0602419F RID: 147871 RVA: 0x00A378B8 File Offset: 0x00A35AB8
		// (set) Token: 0x060241A0 RID: 147872 RVA: 0x00A378C0 File Offset: 0x00A35AC0
		[RequiredMember]
		public IWuWaGoGridMoveParticipant Participant { get; set; }

		// Token: 0x170049B6 RID: 18870
		// (get) Token: 0x060241A1 RID: 147873 RVA: 0x00A378C9 File Offset: 0x00A35AC9
		// (set) Token: 0x060241A2 RID: 147874 RVA: 0x00A378D1 File Offset: 0x00A35AD1
		[RequiredMember]
		public IWuWaGoGridRelocationContext Context { get; set; }

		// Token: 0x060241A3 RID: 147875 RVA: 0x00A378DA File Offset: 0x00A35ADA
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public GridMoveParticipantExecution()
		{
		}
	}
}
