using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Capability;
using CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag.Define;
using CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag.Interface;

namespace CSharpScript.Game.LevelGameplay.SplineConstrainedDrag.Capability
{
	// Token: 0x02005AAA RID: 23210
	[NullableContext(1)]
	[Nullable(0)]
	public class DraggableStateData : CapabilityData
	{
		// Token: 0x06039307 RID: 234247 RVA: 0x010052A4 File Offset: 0x010034A4
		[NullableContext(2)]
		public DraggableStateData(ICapabilityGameObject ownerGameObject = null) : base(ownerGameObject)
		{
		}

		// Token: 0x06039308 RID: 234248 RVA: 0x010052D9 File Offset: 0x010034D9
		public override void OnAdded()
		{
			this.ResetSpeedSample();
		}

		// Token: 0x06039309 RID: 234249 RVA: 0x010052E1 File Offset: 0x010034E1
		public override void OnRemoved()
		{
			this.Appliers.Clear();
			this.States.Clear();
			this.PendingRegister.Clear();
			this.PendingUnregister.Clear();
			this.ResetSpeedSample();
		}

		// Token: 0x0603930A RID: 234250 RVA: 0x01005318 File Offset: 0x01003518
		public void PushRegister(IKuroSplineConstrainedDrag drag)
		{
			string actorKey = drag.GetActorKey();
			this.PendingUnregister.Remove(actorKey);
			this.PendingRegister[actorKey] = drag;
		}

		// Token: 0x0603930B RID: 234251 RVA: 0x01005348 File Offset: 0x01003548
		public void PushUnregister(IKuroSplineConstrainedDrag drag)
		{
			string actorKey = drag.GetActorKey();
			this.PendingRegister.Remove(actorKey);
			this.PendingUnregister[actorKey] = drag;
		}

		// Token: 0x0603930C RID: 234252 RVA: 0x01005376 File Offset: 0x01003576
		public void ResetSpeedSample()
		{
			this.SpeedSampleDrag = null;
			this.SpeedSampleDistance = 0f;
			this.SelectedMovingSpeed = 0f;
			this.ActiveDragMoving = false;
			this.LowSpeedDurationSeconds = 0f;
		}

		// Token: 0x0401E195 RID: 123285
		public readonly Dictionary<string, IDraggableStateApplier> Appliers = new Dictionary<string, IDraggableStateApplier>();

		// Token: 0x0401E196 RID: 123286
		public readonly Dictionary<string, EDraggableState> States = new Dictionary<string, EDraggableState>();

		// Token: 0x0401E197 RID: 123287
		public readonly Dictionary<string, IKuroSplineConstrainedDrag> PendingRegister = new Dictionary<string, IKuroSplineConstrainedDrag>();

		// Token: 0x0401E198 RID: 123288
		public readonly Dictionary<string, IKuroSplineConstrainedDrag> PendingUnregister = new Dictionary<string, IKuroSplineConstrainedDrag>();

		// Token: 0x0401E199 RID: 123289
		[Nullable(2)]
		public IKuroSplineConstrainedDrag SpeedSampleDrag;

		// Token: 0x0401E19A RID: 123290
		public float SpeedSampleDistance;

		// Token: 0x0401E19B RID: 123291
		public float SelectedMovingSpeed;

		// Token: 0x0401E19C RID: 123292
		public bool ActiveDragMoving;

		// Token: 0x0401E19D RID: 123293
		public float LowSpeedDurationSeconds;
	}
}
