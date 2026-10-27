using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A35 RID: 18997
	public class MarkTransformComponent : TrapMapComponentBase
	{
		// Token: 0x0603152E RID: 202030 RVA: 0x00B711F8 File Offset: 0x00B6F3F8
		[NullableContext(1)]
		public MarkTransformComponent(TrapMapEntity parent) : base(parent)
		{
		}

		// Token: 0x17007A33 RID: 31283
		// (get) Token: 0x0603152F RID: 202031 RVA: 0x00B71201 File Offset: 0x00B6F401
		public override ETrapDefenseMapComponent ComponentType
		{
			get
			{
				return ETrapDefenseMapComponent.MarkTransformComponent;
			}
		}
	}
}
