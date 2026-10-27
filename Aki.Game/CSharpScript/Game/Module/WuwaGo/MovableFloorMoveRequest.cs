using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.WuwaGo.Controller.GameplayEntity;

namespace CSharpScript.Game.Module.WuwaGo
{
	// Token: 0x02004717 RID: 18199
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class MovableFloorMoveRequest : IMovableFloorMoveRequest
	{
		// Token: 0x170076ED RID: 30445
		// (get) Token: 0x0602F8D5 RID: 194773 RVA: 0x00B03990 File Offset: 0x00B01B90
		// (set) Token: 0x0602F8D6 RID: 194774 RVA: 0x00B03998 File Offset: 0x00B01B98
		[RequiredMember]
		public MovableFloorController Controller { get; set; }

		// Token: 0x170076EE RID: 30446
		// (get) Token: 0x0602F8D7 RID: 194775 RVA: 0x00B039A1 File Offset: 0x00B01BA1
		// (set) Token: 0x0602F8D8 RID: 194776 RVA: 0x00B039A9 File Offset: 0x00B01BA9
		[RequiredMember]
		public IWuWaGoGridRelocationRequest RelocationRequest { get; set; }

		// Token: 0x0602F8D9 RID: 194777 RVA: 0x00B039B2 File Offset: 0x00B01BB2
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public MovableFloorMoveRequest()
		{
		}
	}
}
