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
	// Token: 0x020051CB RID: 20939
	public class RhythmShipSetTipsView : UiViewBase
	{
		// Token: 0x0603430D RID: 213773 RVA: 0x00E9A4F1 File Offset: 0x00E986F1
		[NullableContext(1)]
		public RhythmShipSetTipsView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603430E RID: 213774 RVA: 0x00E9A4FA File Offset: 0x00E986FA
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent))
			};
		}

		// Token: 0x0603430F RID: 213775 RVA: 0x00E9A534 File Offset: 0x00E98734
		protected override UniTask OnBeforeStartAsync()
		{
			RhythmShipSetTipsView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RhythmShipSetTipsView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034310 RID: 213776 RVA: 0x00E9A578 File Offset: 0x00E98778
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

		// Token: 0x0401BAEC RID: 113388
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401BAED RID: 113389
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<KeyItem, int> ScrollView;
	}
}
