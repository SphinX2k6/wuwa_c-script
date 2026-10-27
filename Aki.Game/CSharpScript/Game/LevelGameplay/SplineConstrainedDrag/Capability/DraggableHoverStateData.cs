using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Capability;

namespace CSharpScript.Game.LevelGameplay.SplineConstrainedDrag.Capability
{
	// Token: 0x0200694B RID: 26955
	[NullableContext(2)]
	[Nullable(0)]
	public class DraggableHoverStateData : CapabilityData
	{
		// Token: 0x060432A6 RID: 275110 RVA: 0x01060251 File Offset: 0x0105E451
		public DraggableHoverStateData(ICapabilityGameObject ownerGameObject = null) : base(ownerGameObject)
		{
		}

		// Token: 0x060432A7 RID: 275111 RVA: 0x0106025A File Offset: 0x0105E45A
		public override void OnAdded()
		{
			this.HasResult = false;
			this.HoveredActorKey = null;
		}

		// Token: 0x060432A8 RID: 275112 RVA: 0x0106026A File Offset: 0x0105E46A
		public override void OnRemoved()
		{
			this.HasResult = false;
			this.HoveredActorKey = null;
		}

		// Token: 0x04022FA5 RID: 143269
		public bool HasResult;

		// Token: 0x04022FA6 RID: 143270
		public string HoveredActorKey;
	}
}
