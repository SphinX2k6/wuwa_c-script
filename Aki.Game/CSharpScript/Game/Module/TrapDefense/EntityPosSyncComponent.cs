using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A34 RID: 18996
	public class EntityPosSyncComponent : TrapMapComponentBase
	{
		// Token: 0x0603152C RID: 202028 RVA: 0x00B711EC File Offset: 0x00B6F3EC
		[NullableContext(1)]
		public EntityPosSyncComponent(TrapMapEntity parent) : base(parent)
		{
		}

		// Token: 0x17007A32 RID: 31282
		// (get) Token: 0x0603152D RID: 202029 RVA: 0x00B711F5 File Offset: 0x00B6F3F5
		public override ETrapDefenseMapComponent ComponentType
		{
			get
			{
				return ETrapDefenseMapComponent.EntityPosSyncComponent;
			}
		}
	}
}
