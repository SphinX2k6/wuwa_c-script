using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Capability;

namespace CSharpScript.Game.LevelGameplay.SplineConstrainedDrag.Capability
{
	// Token: 0x02005AA6 RID: 23206
	[NullableContext(2)]
	[Nullable(0)]
	public class DraggableHoverStateData : CapabilityData
	{
		// Token: 0x060392DD RID: 234205 RVA: 0x010044B1 File Offset: 0x010026B1
		public DraggableHoverStateData(ICapabilityGameObject ownerGameObject = null) : base(ownerGameObject)
		{
		}

		// Token: 0x060392DE RID: 234206 RVA: 0x010044BA File Offset: 0x010026BA
		public override void OnAdded()
		{
			this.HasResult = false;
			this.HoveredActorKey = null;
		}

		// Token: 0x060392DF RID: 234207 RVA: 0x010044CA File Offset: 0x010026CA
		public override void OnRemoved()
		{
			this.HasResult = false;
			this.HoveredActorKey = null;
		}

		// Token: 0x0401E18F RID: 123279
		public bool HasResult;

		// Token: 0x0401E190 RID: 123280
		public string HoveredActorKey;
	}
}
