using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ActivityAction
{
	// Token: 0x02005A94 RID: 23188
	[NullableContext(1)]
	[Nullable(0)]
	internal class ParallelAction : ActivityActionBase
	{
		// Token: 0x06039270 RID: 234096 RVA: 0x01001341 File Offset: 0x00FFF541
		public ParallelAction(params ActivityActionBase[] children)
		{
			if (children != null)
			{
				this.Children.AddRange(children);
			}
		}

		// Token: 0x06039271 RID: 234097 RVA: 0x01001363 File Offset: 0x00FFF563
		public ParallelAction(List<ActivityActionBase> children)
		{
			if (children != null)
			{
				this.Children.AddRange(children);
			}
		}

		// Token: 0x06039272 RID: 234098 RVA: 0x01001385 File Offset: 0x00FFF585
		public ParallelAction Add(ActivityActionBase child)
		{
			this.Children.Add(child);
			return this;
		}

		// Token: 0x06039273 RID: 234099 RVA: 0x01001394 File Offset: 0x00FFF594
		protected override void OnStart()
		{
			if (this.Children.Count == 0)
			{
				base.MarkDone();
				return;
			}
			foreach (ActivityActionBase activityActionBase in this.Children)
			{
				activityActionBase.Start();
			}
		}

		// Token: 0x06039274 RID: 234100 RVA: 0x010013F8 File Offset: 0x00FFF5F8
		protected override void OnTick(float delta)
		{
			bool flag = true;
			bool flag2 = false;
			foreach (ActivityActionBase activityActionBase in this.Children)
			{
				if (!activityActionBase.IsDone())
				{
					activityActionBase.Tick(delta);
					if (activityActionBase.IsDone())
					{
						activityActionBase.Finish();
					}
					else
					{
						flag = false;
					}
				}
				if (activityActionBase.IsFailed())
				{
					flag2 = true;
				}
			}
			if (flag2)
			{
				foreach (ActivityActionBase activityActionBase2 in this.Children)
				{
					if (!activityActionBase2.IsDone())
					{
						activityActionBase2.Delete();
					}
				}
				base.MarkFailed();
				return;
			}
			if (flag)
			{
				base.MarkDone();
			}
		}

		// Token: 0x06039275 RID: 234101 RVA: 0x010014D4 File Offset: 0x00FFF6D4
		protected override void OnPause()
		{
			foreach (ActivityActionBase activityActionBase in this.Children)
			{
				activityActionBase.Pause();
			}
		}

		// Token: 0x06039276 RID: 234102 RVA: 0x01001524 File Offset: 0x00FFF724
		protected override void OnResume()
		{
			foreach (ActivityActionBase activityActionBase in this.Children)
			{
				activityActionBase.Resume();
			}
		}

		// Token: 0x06039277 RID: 234103 RVA: 0x01001574 File Offset: 0x00FFF774
		protected override void OnDelete()
		{
			foreach (ActivityActionBase activityActionBase in this.Children)
			{
				if (!activityActionBase.IsDone())
				{
					activityActionBase.Delete();
				}
			}
		}

		// Token: 0x0401E115 RID: 123157
		private readonly List<ActivityActionBase> Children = new List<ActivityActionBase>();
	}
}
