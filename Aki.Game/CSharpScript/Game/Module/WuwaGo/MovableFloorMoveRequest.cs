using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.WuwaGo.Controller.GameplayEntity;

namespace CSharpScript.Game.Module.WuwaGo
{
	// Token: 0x02003647 RID: 13895
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class MovableFloorMoveRequest : IMovableFloorMoveRequest
	{
		// Token: 0x170049A9 RID: 18857
		// (get) Token: 0x0602409B RID: 147611 RVA: 0x00A33660 File Offset: 0x00A31860
		// (set) Token: 0x0602409C RID: 147612 RVA: 0x00A33668 File Offset: 0x00A31868
		[RequiredMember]
		public MovableFloorController Controller { get; set; }

		// Token: 0x170049AA RID: 18858
		// (get) Token: 0x0602409D RID: 147613 RVA: 0x00A33671 File Offset: 0x00A31871
		// (set) Token: 0x0602409E RID: 147614 RVA: 0x00A33679 File Offset: 0x00A31879
		[RequiredMember]
		public IWuWaGoGridRelocationRequest RelocationRequest { get; set; }

		// Token: 0x0602409F RID: 147615 RVA: 0x00A33682 File Offset: 0x00A31882
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public MovableFloorMoveRequest()
		{
		}
	}
}
