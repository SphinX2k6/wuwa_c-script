using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02004FAB RID: 20395
	[NullableContext(2)]
	[Nullable(0)]
	public class TotalTopUpPreviewView : UiViewBase
	{
		// Token: 0x060331C1 RID: 209345 RVA: 0x00E536F3 File Offset: 0x00E518F3
		[NullableContext(1)]
		public TotalTopUpPreviewView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060331C2 RID: 209346 RVA: 0x00E536FC File Offset: 0x00E518FC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
		}

		// Token: 0x060331C3 RID: 209347 RVA: 0x00E53738 File Offset: 0x00E51938
		protected override UniTask OnBeforeStartAsync()
		{
			TotalTopUpPreviewView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TotalTopUpPreviewView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060331C4 RID: 209348 RVA: 0x00E5377B File Offset: 0x00E5197B
		private void OnClickedCloseButton()
		{
			base.CloseMe(null);
		}

		// Token: 0x0401B231 RID: 111153
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401B232 RID: 111154
		private TotalTopUpPreviewSubView SubView;
	}
}
