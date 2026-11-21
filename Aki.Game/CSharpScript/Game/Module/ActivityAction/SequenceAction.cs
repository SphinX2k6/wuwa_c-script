using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ActivityAction
{
	// Token: 0x02005A93 RID: 23187
	[NullableContext(1)]
	[Nullable(0)]
	internal class SequenceAction : ActivityActionBase
	{
		// Token: 0x06039267 RID: 234087 RVA: 0x01001173 File Offset: 0x00FFF373
		public SequenceAction(params ActivityActionBase[] children)
		{
			if (children != null)
			{
				this.Children.AddRange(children);
			}
		}

		// Token: 0x06039268 RID: 234088 RVA: 0x0100119C File Offset: 0x00FFF39C
		public SequenceAction(List<ActivityActionBase> children)
		{
			if (children != null)
			{
				this.Children.AddRange(children);
			}
		}

		// Token: 0x06039269 RID: 234089 RVA: 0x010011C5 File Offset: 0x00FFF3C5
		public SequenceAction Add(ActivityActionBase child)
		{
			this.Children.Add(child);
			return this;
		}

		// Token: 0x0603926A RID: 234090 RVA: 0x010011D4 File Offset: 0x00FFF3D4
		protected override void OnStart()
		{
			this.StartNext();
		}

		// Token: 0x0603926B RID: 234091 RVA: 0x010011DC File Offset: 0x00FFF3DC
		protected override void OnTick(float delta)
		{
			if (this.Index < 0 || this.Index >= this.Children.Count)
			{
				base.MarkDone();
				return;
			}
			ActivityActionBase activityActionBase = this.Children[this.Index];
			activityActionBase.Tick(delta);
			if (activityActionBase.IsFailed())
			{
				activityActionBase.Finish();
				base.MarkFailed();
				return;
			}
			if (activityActionBase.IsDone())
			{
				activityActionBase.Finish();
				this.StartNext();
			}
		}

		// Token: 0x0603926C RID: 234092 RVA: 0x0100124E File Offset: 0x00FFF44E
		private void StartNext()
		{
			this.Index++;
			if (this.Index >= this.Children.Count)
			{
				base.MarkDone();
				return;
			}
			this.Children[this.Index].Start();
		}

		// Token: 0x0603926D RID: 234093 RVA: 0x0100128E File Offset: 0x00FFF48E
		protected override void OnPause()
		{
			if (this.Index >= 0 && this.Index < this.Children.Count)
			{
				this.Children[this.Index].Pause();
			}
		}

		// Token: 0x0603926E RID: 234094 RVA: 0x010012C2 File Offset: 0x00FFF4C2
		protected override void OnResume()
		{
			if (this.Index >= 0 && this.Index < this.Children.Count)
			{
				this.Children[this.Index].Resume();
			}
		}

		// Token: 0x0603926F RID: 234095 RVA: 0x010012F8 File Offset: 0x00FFF4F8
		protected override void OnDelete()
		{
			if (this.Index >= 0 && this.Index < this.Children.Count)
			{
				ActivityActionBase activityActionBase = this.Children[this.Index];
				if (!activityActionBase.IsDone())
				{
					activityActionBase.Delete();
				}
			}
		}

		// Token: 0x0401E113 RID: 123155
		private readonly List<ActivityActionBase> Children = new List<ActivityActionBase>();

		// Token: 0x0401E114 RID: 123156
		private int Index = -1;
	}
}
