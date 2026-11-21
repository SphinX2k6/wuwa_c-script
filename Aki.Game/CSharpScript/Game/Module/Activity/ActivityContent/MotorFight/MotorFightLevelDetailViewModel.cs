using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorFight
{
	// Token: 0x020053A6 RID: 21414
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorFightLevelDetailViewModel
	{
		// Token: 0x0603543E RID: 218174 RVA: 0x00EE0BA0 File Offset: 0x00EDEDA0
		public MotorFightLevelDetailViewModel(MotorFightActivityData ActivityData, MotorFightLevelData LevelData)
		{
			this.ActivityData = ActivityData;
			this.LevelData = LevelData;
			this.SelectedRoleId = ActivityData.GetLevelUsedRole(LevelData.Id);
		}

		// Token: 0x170067DC RID: 26588
		// (get) Token: 0x0603543F RID: 218175 RVA: 0x00EE0BC8 File Offset: 0x00EDEDC8
		// (set) Token: 0x06035440 RID: 218176 RVA: 0x00EE0BD0 File Offset: 0x00EDEDD0
		public MotorFightActivityData ActivityData { get; set; }

		// Token: 0x170067DD RID: 26589
		// (get) Token: 0x06035441 RID: 218177 RVA: 0x00EE0BD9 File Offset: 0x00EDEDD9
		// (set) Token: 0x06035442 RID: 218178 RVA: 0x00EE0BE1 File Offset: 0x00EDEDE1
		public MotorFightLevelData LevelData { get; set; }

		// Token: 0x0401C170 RID: 115056
		public int SelectedRoleId;
	}
}
