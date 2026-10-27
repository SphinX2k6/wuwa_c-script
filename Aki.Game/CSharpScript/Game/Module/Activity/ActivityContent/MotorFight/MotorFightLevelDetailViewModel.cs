using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorFight
{
	// Token: 0x02006428 RID: 25640
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorFightLevelDetailViewModel
	{
		// Token: 0x0604077D RID: 264061 RVA: 0x00F99C00 File Offset: 0x00F97E00
		public MotorFightLevelDetailViewModel(MotorFightActivityData ActivityData, MotorFightLevelData LevelData)
		{
			this.ActivityData = ActivityData;
			this.LevelData = LevelData;
			this.SelectedRoleId = ActivityData.GetLevelUsedRole(LevelData.Id);
		}

		// Token: 0x1700947A RID: 38010
		// (get) Token: 0x0604077E RID: 264062 RVA: 0x00F99C28 File Offset: 0x00F97E28
		// (set) Token: 0x0604077F RID: 264063 RVA: 0x00F99C30 File Offset: 0x00F97E30
		public MotorFightActivityData ActivityData { get; set; }

		// Token: 0x1700947B RID: 38011
		// (get) Token: 0x06040780 RID: 264064 RVA: 0x00F99C39 File Offset: 0x00F97E39
		// (set) Token: 0x06040781 RID: 264065 RVA: 0x00F99C41 File Offset: 0x00F97E41
		public MotorFightLevelData LevelData { get; set; }

		// Token: 0x04021841 RID: 137281
		public int SelectedRoleId;
	}
}
