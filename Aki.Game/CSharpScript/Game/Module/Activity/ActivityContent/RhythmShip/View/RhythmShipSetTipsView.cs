using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip.View
{
	// Token: 0x0200624D RID: 25165
	public class RhythmShipSetTipsView : UiViewBase
	{
		// Token: 0x0603F64C RID: 259660 RVA: 0x00F53595 File Offset: 0x00F51795
		[NullableContext(1)]
		public RhythmShipSetTipsView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603F64D RID: 259661 RVA: 0x00F5359E File Offset: 0x00F5179E
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent))
			};
		}

		// Token: 0x0603F64E RID: 259662 RVA: 0x00F535D8 File Offset: 0x00F517D8
		protected override UniTask OnBeforeStartAsync()
		{
			RhythmShipSetTipsView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RhythmShipSetTipsView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603F64F RID: 259663 RVA: 0x00F5361C File Offset: 0x00F5181C
		protected override void OnStart()
		{
			List<int> rhythmShipActionAll = RhythmShipConfig.Instance.GetRhythmShipActionAll();
			GenericScrollViewNew<KeyItem, int> scrollView = this.ScrollView;
			if (scrollView == null)
			{
				return;
			}
			scrollView.RefreshByData(rhythmShipActionAll, null, false);
		}

		// Token: 0x040211BD RID: 135613
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x040211BE RID: 135614
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<KeyItem, int> ScrollView;
	}
}
