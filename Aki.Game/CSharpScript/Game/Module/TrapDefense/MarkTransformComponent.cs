using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x020039DD RID: 14813
	public class MarkTransformComponent : TrapMapComponentBase
	{
		// Token: 0x060262BE RID: 156350 RVA: 0x00AB516C File Offset: 0x00AB336C
		[NullableContext(1)]
		public MarkTransformComponent(TrapMapEntity parent) : base(parent)
		{
		}

		// Token: 0x17004DE0 RID: 19936
		// (get) Token: 0x060262BF RID: 156351 RVA: 0x00AB5175 File Offset: 0x00AB3375
		public override ETrapDefenseMapComponent ComponentType
		{
			get
			{
				return ETrapDefenseMapComponent.MarkTransformComponent;
			}
		}
	}
}
