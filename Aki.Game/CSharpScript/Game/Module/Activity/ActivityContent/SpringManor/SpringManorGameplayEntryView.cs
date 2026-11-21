using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x02005009 RID: 20489
	[NullableContext(1)]
	[Nullable(0)]
	public class SpringManorGameplayEntryView : UiTickViewBase
	{
		// Token: 0x06033474 RID: 210036 RVA: 0x00E60CD4 File Offset: 0x00E5EED4
		public SpringManorGameplayEntryView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06033475 RID: 210037 RVA: 0x00E60CE8 File Offset: 0x00E5EEE8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(5, new Action(this.OnClickClose))
			};
		}

		// Token: 0x06033476 RID: 210038 RVA: 0x00E60DA8 File Offset: 0x00E5EFA8
		protected override UniTask OnBeforeStartAsync()
		{
			SpringManorGameplayEntryView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpringManorGameplayEntryView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033477 RID: 210039 RVA: 0x00E60DEB File Offset: 0x00E5EFEB
		protected override void OnBeforeShow()
		{
			this.PauseTimeDilation();
		}

		// Token: 0x06033478 RID: 210040 RVA: 0x00E60DF3 File Offset: 0x00E5EFF3
		protected override void OnBeforeHide()
		{
			this.ResumeTimeDilation();
		}

		// Token: 0x06033479 RID: 210041 RVA: 0x00E60DFB File Offset: 0x00E5EFFB
		protected override void OnStart()
		{
			PopupCaptionItem caption = this.Caption;
			if (caption == null)
			{
				return;
			}
			caption.SetCloseCallBack(new Action(this.OnClickClose));
		}

		// Token: 0x0603347A RID: 210042 RVA: 0x00E60E19 File Offset: 0x00E5F019
		protected void PauseTimeDilation()
		{
			UiTimeDilation.Instance.AddWaitSetTimeDilationTag("SpringManorGameplayEntryView");
		}

		// Token: 0x0603347B RID: 210043 RVA: 0x00E60E2A File Offset: 0x00E5F02A
		protected void ResumeTimeDilation()
		{
			UiTimeDilation.Instance.DeleteWaitSetTimeDilationTag("SpringManorGameplayEntryView");
		}

		// Token: 0x0603347C RID: 210044 RVA: 0x00E60E3C File Offset: 0x00E5F03C
		protected override void OnTick(float delta)
		{
			if (this.Timer > 0.0)
			{
				this.Timer -= (double)delta;
				return;
			}
			this.Timer = 500.0;
			foreach (FunctionItem functionItem in this.FunctionItems)
			{
				functionItem.Refresh();
			}
		}

		// Token: 0x0603347D RID: 210045 RVA: 0x00E60EBC File Offset: 0x00E5F0BC
		private void OnClickClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x0401B44B RID: 111691
		private const int TICK_INTERVAL = 500;

		// Token: 0x0401B44C RID: 111692
		private readonly List<FunctionItem> FunctionItems = new List<FunctionItem>();

		// Token: 0x0401B44D RID: 111693
		[Nullable(2)]
		private PopupCaptionItem Caption;

		// Token: 0x0401B44E RID: 111694
		private double Timer;
	}
}
