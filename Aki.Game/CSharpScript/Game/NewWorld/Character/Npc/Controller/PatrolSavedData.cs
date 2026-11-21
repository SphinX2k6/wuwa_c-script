using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Character.Npc.Controller
{
	// Token: 0x020062FC RID: 25340
	[NullableContext(1)]
	[Nullable(0)]
	public class PatrolSavedData
	{
		// Token: 0x0603D4B1 RID: 251057 RVA: 0x011B5F68 File Offset: 0x011B4168
		public bool IsValid()
		{
			return this.SplineId != 0 && this.PointId != -1 && this.PatrolState != "";
		}

		// Token: 0x0603D4B2 RID: 251058 RVA: 0x011B5F90 File Offset: 0x011B4190
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

		// Token: 0x0402082B RID: 133163
		public int SplineId;

		// Token: 0x0402082C RID: 133164
		public int PointId = -1;

		// Token: 0x0402082D RID: 133165
		public bool Direction;

		// Token: 0x0402082E RID: 133166
		public EPatrolState State;

		// Token: 0x0402082F RID: 133167
		public string PatrolState = "";

		// Token: 0x04020830 RID: 133168
		public int ActionIndex;

		// Token: 0x04020831 RID: 133169
		public int ActionType;
	}
}
