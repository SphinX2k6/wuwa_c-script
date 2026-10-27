using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02005FC4 RID: 24516
	[NullableContext(2)]
	[Nullable(0)]
	public class TotalTopUpPreviewView : UiViewBase
	{
		// Token: 0x0603E227 RID: 254503 RVA: 0x00F01A37 File Offset: 0x00EFFC37
		[NullableContext(1)]
		public TotalTopUpPreviewView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603E228 RID: 254504 RVA: 0x00F01A40 File Offset: 0x00EFFC40
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
		}

		// Token: 0x0603E229 RID: 254505 RVA: 0x00F01A7C File Offset: 0x00EFFC7C
		protected override UniTask OnBeforeStartAsync()
		{
			TotalTopUpPreviewView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TotalTopUpPreviewView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603E22A RID: 254506 RVA: 0x00F01ABF File Offset: 0x00EFFCBF
		private void OnClickedCloseButton()
		{
			base.CloseMe(null);
		}

		// Token: 0x0402075F RID: 132959
		private PopupCaptionItem CaptionItem;

		// Token: 0x04020760 RID: 132960
		private TotalTopUpPreviewSubView SubView;
	}
}
