using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B5F RID: 23391
	public class IMotorInteractConstraintTypeT
	{
		// Token: 0x1700AAC7 RID: 43719
		// (get) Token: 0x060267F8 RID: 157688 RVA: 0x00545956 File Offset: 0x00543B56
		// (set) Token: 0x060267F9 RID: 157689 RVA: 0x0054595E File Offset: 0x00543B5E
		public EMotorInteractConstraintType Type { get; set; }

		// Token: 0x060267FA RID: 157690 RVA: 0x00545967 File Offset: 0x00543B67
		public IMotorInteractConstraintTypeT()
		{
			this.Type = EMotorInteractConstraintType.FaceToTarget;
		}
	}
}
