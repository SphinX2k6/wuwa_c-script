using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x020039DC RID: 14812
	public class EntityPosSyncComponent : TrapMapComponentBase
	{
		// Token: 0x060262BC RID: 156348 RVA: 0x00AB5160 File Offset: 0x00AB3360
		[NullableContext(1)]
		public EntityPosSyncComponent(TrapMapEntity parent) : base(parent)
		{
		}

		// Token: 0x17004DDF RID: 19935
		// (get) Token: 0x060262BD RID: 156349 RVA: 0x00AB5169 File Offset: 0x00AB3369
		public override ETrapDefenseMapComponent ComponentType
		{
			get
			{
				return ETrapDefenseMapComponent.EntityPosSyncComponent;
			}
		}
	}
}
