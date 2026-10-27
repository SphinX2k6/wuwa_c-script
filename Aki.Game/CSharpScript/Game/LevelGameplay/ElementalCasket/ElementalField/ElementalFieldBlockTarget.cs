using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket.ElementalField
{
	// Token: 0x02006EA4 RID: 28324
	[RequiredMember]
	public class ElementalFieldBlockTarget : IElementalFieldBlockTarget
	{
		// Token: 0x17009A7B RID: 39547
		// (get) Token: 0x0604502D RID: 282669 RVA: 0x0110DAA3 File Offset: 0x0110BCA3
		// (set) Token: 0x0604502E RID: 282670 RVA: 0x0110DAAB File Offset: 0x0110BCAB
		[Nullable(new byte[]
		{
			1,
			2
		})]
		[RequiredMember]
		public Func<UPrimitiveComponent, bool> IsBlockTarget { [return: Nullable(new byte[]
		{
			1,
			2
		})] get; [param: Nullable(new byte[]
		{
			1,
			2
		})] set; }

		// Token: 0x17009A7C RID: 39548
		// (get) Token: 0x0604502F RID: 282671 RVA: 0x0110DAB4 File Offset: 0x0110BCB4
		// (set) Token: 0x06045030 RID: 282672 RVA: 0x0110DABC File Offset: 0x0110BCBC
		[RequiredMember]
		public ECollisionChannel TargetChannel { get; set; }

		// Token: 0x06045031 RID: 282673 RVA: 0x0110DAC5 File Offset: 0x0110BCC5
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public ElementalFieldBlockTarget()
		{
		}
	}
}
