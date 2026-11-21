using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A98 RID: 15000
	[NullableContext(2)]
	[Nullable(0)]
	public class TrapDefenseTransitionView : UiViewBase
	{
		// Token: 0x17004E96 RID: 20118
		// (get) Token: 0x060268A9 RID: 157865 RVA: 0x00ACDFDC File Offset: 0x00ACC1DC
		public new TrapDefenseTransitionViewParams OpenParam
		{
			get
			{
				return this.OpenParam as TrapDefenseTransitionViewParams;
			}
		}

		// Token: 0x060268AA RID: 157866 RVA: 0x00ACDFE9 File Offset: 0x00ACC1E9
		[NullableContext(1)]
		public TrapDefenseTransitionView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060268AB RID: 157867 RVA: 0x00ACDFF2 File Offset: 0x00ACC1F2
		protected override void OnStart()
		{
		}

		// Token: 0x060268AC RID: 157868 RVA: 0x00ACDFF4 File Offset: 0x00ACC1F4
		protected override void OnFinishShow()
		{
			base.CloseMe(null);
		}

		// Token: 0x060268AD RID: 157869 RVA: 0x00ACDFFD File Offset: 0x00ACC1FD
		protected override void OnBeforePlayCloseSequence()
		{
			TrapDefenseTransitionViewParams openParam = this.OpenParam;
			if (openParam == null)
			{
				return;
			}
			Action beforeCloseCallback = openParam.BeforeCloseCallback;
			if (beforeCloseCallback == null)
			{
				return;
			}
			beforeCloseCallback();
		}
	}
}
