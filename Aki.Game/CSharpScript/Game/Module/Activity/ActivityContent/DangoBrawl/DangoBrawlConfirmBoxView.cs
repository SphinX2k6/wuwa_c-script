using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x0200574D RID: 22349
	public class DangoBrawlConfirmBoxView : ConfirmBoxView
	{
		// Token: 0x060371C1 RID: 225729 RVA: 0x00F613A2 File Offset: 0x00F5F5A2
		[NullableContext(1)]
		public DangoBrawlConfirmBoxView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060371C2 RID: 225730 RVA: 0x00F613AB File Offset: 0x00F5F5AB
		protected override void OnRegisterComponent()
		{
			base.OnRegisterComponent();
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(11, typeof(UUIItem)));
		}

		// Token: 0x060371C3 RID: 225731 RVA: 0x00F613D0 File Offset: 0x00F5F5D0
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlConfirmBoxView.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlConfirmBoxView.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060371C4 RID: 225732 RVA: 0x00F61413 File Offset: 0x00F5F613
		protected override void OnBeforeShow()
		{
			IUiPopFrameInterface childPopView = this.ChildPopView;
			if (childPopView == null)
			{
				return;
			}
			childPopView.SetTitleByTextIdAndArg("ConfirmBox_538_Title", Array.Empty<object>());
		}

		// Token: 0x0200B33A RID: 45882
		private class EConfirmBoxViewDefine
		{
			// Token: 0x04037622 RID: 226850
			public const int Toggle = 6;

			// Token: 0x04037623 RID: 226851
			public const int Line = 11;
		}
	}
}
