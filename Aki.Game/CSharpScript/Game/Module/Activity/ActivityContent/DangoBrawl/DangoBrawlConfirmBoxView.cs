using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020067FD RID: 26621
	public class DangoBrawlConfirmBoxView : ConfirmBoxView
	{
		// Token: 0x0604266C RID: 271980 RVA: 0x0101FE5E File Offset: 0x0101E05E
		[NullableContext(1)]
		public DangoBrawlConfirmBoxView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0604266D RID: 271981 RVA: 0x0101FE67 File Offset: 0x0101E067
		protected override void OnRegisterComponent()
		{
			base.OnRegisterComponent();
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(11, typeof(UUIItem)));
		}

		// Token: 0x0604266E RID: 271982 RVA: 0x0101FE8C File Offset: 0x0101E08C
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlConfirmBoxView.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlConfirmBoxView.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0604266F RID: 271983 RVA: 0x0101FECF File Offset: 0x0101E0CF
		protected override void OnBeforeShow()
		{
			IUiPopFrameInterface childPopView = this.ChildPopView;
			if (childPopView == null)
			{
				return;
			}
			childPopView.SetTitleByTextIdAndArg("ConfirmBox_538_Title", Array.Empty<object>());
		}

		// Token: 0x0200C96D RID: 51565
		private class EConfirmBoxViewDefine
		{
			// Token: 0x0403CD35 RID: 249141
			public const int Toggle = 6;

			// Token: 0x0403CD36 RID: 249142
			public const int Line = 11;
		}
	}
}
