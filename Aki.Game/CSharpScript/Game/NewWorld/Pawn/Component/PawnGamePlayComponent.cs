using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Pawn.Component
{
	// Token: 0x0200706A RID: 28778
	public class PawnGamePlayComponent : EntityComponent
	{
		// Token: 0x060460DE RID: 286942 RVA: 0x0117922D File Offset: 0x0117742D
		public void ScanResponse()
		{
		}

		// Token: 0x060460DF RID: 286943 RVA: 0x0117922F File Offset: 0x0117742F
		public void WeightResponse()
		{
		}

		// Token: 0x060460E0 RID: 286944 RVA: 0x01179231 File Offset: 0x01177431
		public void GrabResponse()
		{
		}

		// Token: 0x060460E1 RID: 286945 RVA: 0x01179233 File Offset: 0x01177433
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			PawnGamePlayComponent pawnGamePlayComponent = (PawnGamePlayComponent)componentTemplate;
			return true;
		}
	}
}
