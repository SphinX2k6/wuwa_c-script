using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004AF0 RID: 19184
	[NullableContext(2)]
	[Nullable(0)]
	public class TrapDefenseTransitionView : UiViewBase
	{
		// Token: 0x17007AE9 RID: 31465
		// (get) Token: 0x06031B19 RID: 203545 RVA: 0x00B8A028 File Offset: 0x00B88228
		public new TrapDefenseTransitionViewParams OpenParam
		{
			get
			{
				return this.OpenParam as TrapDefenseTransitionViewParams;
			}
		}

		// Token: 0x06031B1A RID: 203546 RVA: 0x00B8A035 File Offset: 0x00B88235
		[NullableContext(1)]
		public TrapDefenseTransitionView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06031B1B RID: 203547 RVA: 0x00B8A03E File Offset: 0x00B8823E
		protected override void OnStart()
		{
		}

		// Token: 0x06031B1C RID: 203548 RVA: 0x00B8A040 File Offset: 0x00B88240
		protected override void OnFinishShow()
		{
			base.CloseMe(null);
		}

		// Token: 0x06031B1D RID: 203549 RVA: 0x00B8A049 File Offset: 0x00B88249
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
