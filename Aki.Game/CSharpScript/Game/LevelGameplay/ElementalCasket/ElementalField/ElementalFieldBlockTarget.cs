using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket.ElementalField
{
	// Token: 0x02006024 RID: 24612
	[RequiredMember]
	public class ElementalFieldBlockTarget : IElementalFieldBlockTarget
	{
		// Token: 0x17006FB2 RID: 28594
		// (get) Token: 0x0603B1CE RID: 242126 RVA: 0x010B7B7F File Offset: 0x010B5D7F
		// (set) Token: 0x0603B1CF RID: 242127 RVA: 0x010B7B87 File Offset: 0x010B5D87
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

		// Token: 0x17006FB3 RID: 28595
		// (get) Token: 0x0603B1D0 RID: 242128 RVA: 0x010B7B90 File Offset: 0x010B5D90
		// (set) Token: 0x0603B1D1 RID: 242129 RVA: 0x010B7B98 File Offset: 0x010B5D98
		[RequiredMember]
		public ECollisionChannel TargetChannel { get; set; }

		// Token: 0x0603B1D2 RID: 242130 RVA: 0x010B7BA1 File Offset: 0x010B5DA1
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public ElementalFieldBlockTarget()
		{
		}
	}
}
