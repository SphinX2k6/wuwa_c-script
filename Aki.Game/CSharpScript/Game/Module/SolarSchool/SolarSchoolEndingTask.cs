using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058E9 RID: 22761
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolEndingTask : SolarSchoolTaskBase
	{
		// Token: 0x17006BAC RID: 27564
		// (get) Token: 0x060381CD RID: 229837 RVA: 0x00FAEC71 File Offset: 0x00FACE71
		// (set) Token: 0x060381CE RID: 229838 RVA: 0x00FAEC79 File Offset: 0x00FACE79
		public bool ActionSucceeded { get; private set; }

		// Token: 0x060381CF RID: 229839 RVA: 0x00FAEC82 File Offset: 0x00FACE82
		public SolarSchoolEndingTask(SolarSchoolActionBase action)
		{
			this.Action = action;
			this.Action.SetFinishCallback(new Action(this.OnActionDone), new Action(this.OnActionAbort));
		}

		// Token: 0x060381D0 RID: 229840 RVA: 0x00FAECB4 File Offset: 0x00FACEB4
		protected override void OnExecute()
		{
			base.PushAction(this.Action);
		}

		// Token: 0x060381D1 RID: 229841 RVA: 0x00FAECC2 File Offset: 0x00FACEC2
		protected override void OnTick(float deltaTime)
		{
			if (!this.ActionFinished)
			{
				return;
			}
			if (base.HandlerHasWork)
			{
				return;
			}
			base.Complete(null);
		}

		// Token: 0x060381D2 RID: 229842 RVA: 0x00FAECDD File Offset: 0x00FACEDD
		private void OnActionDone()
		{
			this.ActionSucceeded = true;
			this.ActionFinished = true;
		}

		// Token: 0x060381D3 RID: 229843 RVA: 0x00FAECED File Offset: 0x00FACEED
		private void OnActionAbort()
		{
			this.ActionSucceeded = false;
			this.ActionFinished = true;
		}

		// Token: 0x0401D8E8 RID: 121064
		private readonly SolarSchoolActionBase Action;

		// Token: 0x0401D8E9 RID: 121065
		private bool ActionFinished;
	}
}
