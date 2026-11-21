using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower.View.Season
{
	// Token: 0x02004F41 RID: 20289
	public class WheelTowerMedalRuleView : UiViewBase
	{
		// Token: 0x06032F94 RID: 208788 RVA: 0x00E488BC File Offset: 0x00E46ABC
		[NullableContext(1)]
		public WheelTowerMedalRuleView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06032F95 RID: 208789 RVA: 0x00E488C8 File Offset: 0x00E46AC8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUILoopScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06032F96 RID: 208790 RVA: 0x00E48974 File Offset: 0x00E46B74
		protected override UniTask OnBeforeStartAsync()
		{
			WheelTowerMedalRuleView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<WheelTowerMedalRuleView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032F97 RID: 208791 RVA: 0x00E489B7 File Offset: 0x00E46BB7
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0401B088 RID: 110728
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401B089 RID: 110729
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<WheelTowerMedalRuleItem, WheelTowerMedalRuleItemData> TargetLoopScroll;
	}
}
