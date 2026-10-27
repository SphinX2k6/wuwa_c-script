using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Character.Npc.Controller
{
	// Token: 0x02007097 RID: 28823
	[NullableContext(1)]
	[Nullable(0)]
	public class PatrolSavedData
	{
		// Token: 0x060463C6 RID: 287686 RVA: 0x01192E5C File Offset: 0x0119105C
		public bool IsValid()
		{
			return this.SplineId != 0 && this.PointId != -1 && this.PatrolState != "";
		}

		// Token: 0x060463C7 RID: 287687 RVA: 0x01192E84 File Offset: 0x01191084
		public PatrolSavedData DeepCopy()
		{
			return new PatrolSavedData
			{
				SplineId = this.SplineId,
				PointId = this.PointId,
				Direction = this.Direction,
				State = this.State,
				PatrolState = this.PatrolState,
				ActionIndex = this.ActionIndex,
				ActionType = this.ActionType
			};
		}

		// Token: 0x04024CD9 RID: 150745
		public int SplineId;

		// Token: 0x04024CDA RID: 150746
		public int PointId = -1;

		// Token: 0x04024CDB RID: 150747
		public bool Direction;

		// Token: 0x04024CDC RID: 150748
		public EPatrolState State;

		// Token: 0x04024CDD RID: 150749
		public string PatrolState = "";

		// Token: 0x04024CDE RID: 150750
		public int ActionIndex;

		// Token: 0x04024CDF RID: 150751
		public int ActionType;
	}
}
