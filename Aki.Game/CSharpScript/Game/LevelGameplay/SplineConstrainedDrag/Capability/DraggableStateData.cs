using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Capability;
using CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag.Define;
using CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag.Interface;

namespace CSharpScript.Game.LevelGameplay.SplineConstrainedDrag.Capability
{
	// Token: 0x0200694F RID: 26959
	[NullableContext(1)]
	[Nullable(0)]
	public class DraggableStateData : CapabilityData
	{
		// Token: 0x060432D0 RID: 275152 RVA: 0x01061044 File Offset: 0x0105F244
		[NullableContext(2)]
		public DraggableStateData(ICapabilityGameObject ownerGameObject = null) : base(ownerGameObject)
		{
		}

		// Token: 0x060432D1 RID: 275153 RVA: 0x01061079 File Offset: 0x0105F279
		public override void OnAdded()
		{
			this.ResetSpeedSample();
		}

		// Token: 0x060432D2 RID: 275154 RVA: 0x01061081 File Offset: 0x0105F281
		public override void OnRemoved()
		{
			this.Appliers.Clear();
			this.States.Clear();
			this.PendingRegister.Clear();
			this.PendingUnregister.Clear();
			this.ResetSpeedSample();
		}

		// Token: 0x060432D3 RID: 275155 RVA: 0x010610B8 File Offset: 0x0105F2B8
		public void PushRegister(IKuroSplineConstrainedDrag drag)
		{
			string actorKey = drag.GetActorKey();
			this.PendingUnregister.Remove(actorKey);
			this.PendingRegister[actorKey] = drag;
		}

		// Token: 0x060432D4 RID: 275156 RVA: 0x010610E8 File Offset: 0x0105F2E8
		public void PushUnregister(IKuroSplineConstrainedDrag drag)
		{
			string actorKey = drag.GetActorKey();
			this.PendingRegister.Remove(actorKey);
			this.PendingUnregister[actorKey] = drag;
		}

		// Token: 0x060432D5 RID: 275157 RVA: 0x01061116 File Offset: 0x0105F316
		public void ResetSpeedSample()
		{
			this.SpeedSampleDrag = null;
			this.SpeedSampleDistance = 0f;
			this.SelectedMovingSpeed = 0f;
			this.ActiveDragMoving = false;
			this.LowSpeedDurationSeconds = 0f;
		}

		// Token: 0x04022FAB RID: 143275
		public readonly Dictionary<string, IDraggableStateApplier> Appliers = new Dictionary<string, IDraggableStateApplier>();

		// Token: 0x04022FAC RID: 143276
		public readonly Dictionary<string, EDraggableState> States = new Dictionary<string, EDraggableState>();

		// Token: 0x04022FAD RID: 143277
		public readonly Dictionary<string, IKuroSplineConstrainedDrag> PendingRegister = new Dictionary<string, IKuroSplineConstrainedDrag>();

		// Token: 0x04022FAE RID: 143278
		public readonly Dictionary<string, IKuroSplineConstrainedDrag> PendingUnregister = new Dictionary<string, IKuroSplineConstrainedDrag>();

		// Token: 0x04022FAF RID: 143279
		[Nullable(2)]
		public IKuroSplineConstrainedDrag SpeedSampleDrag;

		// Token: 0x04022FB0 RID: 143280
		public float SpeedSampleDistance;

		// Token: 0x04022FB1 RID: 143281
		public float SelectedMovingSpeed;

		// Token: 0x04022FB2 RID: 143282
		public bool ActiveDragMoving;

		// Token: 0x04022FB3 RID: 143283
		public float LowSpeedDurationSeconds;
	}
}
