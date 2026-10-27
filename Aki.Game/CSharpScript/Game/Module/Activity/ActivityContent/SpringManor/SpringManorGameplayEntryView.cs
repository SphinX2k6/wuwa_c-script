using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x0200608B RID: 24715
	[NullableContext(1)]
	[Nullable(0)]
	public class SpringManorGameplayEntryView : UiTickViewBase
	{
		// Token: 0x0603E7B0 RID: 255920 RVA: 0x00F19F10 File Offset: 0x00F18110
		public SpringManorGameplayEntryView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603E7B1 RID: 255921 RVA: 0x00F19F24 File Offset: 0x00F18124
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

		// Token: 0x0603E7B2 RID: 255922 RVA: 0x00F19FE4 File Offset: 0x00F181E4
		protected override UniTask OnBeforeStartAsync()
		{
			SpringManorGameplayEntryView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpringManorGameplayEntryView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603E7B3 RID: 255923 RVA: 0x00F1A027 File Offset: 0x00F18227
		protected override void OnBeforeShow()
		{
			this.PauseTimeDilation();
		}

		// Token: 0x0603E7B4 RID: 255924 RVA: 0x00F1A02F File Offset: 0x00F1822F
		protected override void OnBeforeHide()
		{
			this.ResumeTimeDilation();
		}

		// Token: 0x0603E7B5 RID: 255925 RVA: 0x00F1A037 File Offset: 0x00F18237
		protected override void OnStart()
		{
			PopupCaptionItem caption = this.Caption;
			if (caption == null)
			{
				return;
			}
			caption.SetCloseCallBack(new Action(this.OnClickClose));
		}

		// Token: 0x0603E7B6 RID: 255926 RVA: 0x00F1A055 File Offset: 0x00F18255
		protected void PauseTimeDilation()
		{
			UiTimeDilation.Instance.AddWaitSetTimeDilationTag("SpringManorGameplayEntryView");
		}

		// Token: 0x0603E7B7 RID: 255927 RVA: 0x00F1A066 File Offset: 0x00F18266
		protected void ResumeTimeDilation()
		{
			UiTimeDilation.Instance.DeleteWaitSetTimeDilationTag("SpringManorGameplayEntryView");
		}

		// Token: 0x0603E7B8 RID: 255928 RVA: 0x00F1A078 File Offset: 0x00F18278
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

		// Token: 0x0603E7B9 RID: 255929 RVA: 0x00F1A0F8 File Offset: 0x00F182F8
		private void OnClickClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x04020B1E RID: 133918
		private const int TICK_INTERVAL = 500;

		// Token: 0x04020B1F RID: 133919
		private readonly List<FunctionItem> FunctionItems = new List<FunctionItem>();

		// Token: 0x04020B20 RID: 133920
		[Nullable(2)]
		private PopupCaptionItem Caption;

		// Token: 0x04020B21 RID: 133921
		private double Timer;
	}
}
