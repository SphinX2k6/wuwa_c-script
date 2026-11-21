using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058F9 RID: 22777
	[NullableContext(2)]
	[Nullable(0)]
	public class SolarSchoolInstanceInProgressState : SolarSchoolInProgressStateBase
	{
		// Token: 0x17006BBB RID: 27579
		// (get) Token: 0x06038269 RID: 229993 RVA: 0x00FB272E File Offset: 0x00FB092E
		private SolarSchoolInstanceExploreTask ExploreTask
		{
			get
			{
				return base.CurrentTask as SolarSchoolInstanceExploreTask;
			}
		}

		// Token: 0x0603826A RID: 229994 RVA: 0x00FB273B File Offset: 0x00FB093B
		protected override void OnEnterState(ESolarSchoolStageStateType? prev)
		{
			base.RunTask(new SolarSchoolInstanceExploreTask());
		}

		// Token: 0x0603826B RID: 229995 RVA: 0x00FB2748 File Offset: 0x00FB0948
		protected override void OnTaskFinish(int taskId)
		{
			base.FinishDay();
		}

		// Token: 0x0603826C RID: 229996 RVA: 0x00FB2750 File Offset: 0x00FB0950
		public override void OnClickGoOut()
		{
			SolarSchoolInstanceExploreTask exploreTask = this.ExploreTask;
			if (exploreTask == null)
			{
				base.OnClickGoOut();
				return;
			}
			exploreTask.OnClickGoOut();
		}

		// Token: 0x0603826D RID: 229997 RVA: 0x00FB2774 File Offset: 0x00FB0974
		public override void OnClickMapLocation(int locationId)
		{
			SolarSchoolInstanceExploreTask exploreTask = this.ExploreTask;
			if (exploreTask == null)
			{
				base.OnClickMapLocation(locationId);
				return;
			}
			exploreTask.OnClickMapLocation(locationId);
		}

		// Token: 0x0603826E RID: 229998 RVA: 0x00FB279C File Offset: 0x00FB099C
		public override void OnPlayerChooseOption(int locationId, int optionId)
		{
			SolarSchoolInstanceExploreTask exploreTask = this.ExploreTask;
			if (exploreTask == null)
			{
				base.OnPlayerChooseOption(locationId, optionId);
				return;
			}
			exploreTask.OnPlayerChooseOption(locationId, optionId);
		}
	}
}
