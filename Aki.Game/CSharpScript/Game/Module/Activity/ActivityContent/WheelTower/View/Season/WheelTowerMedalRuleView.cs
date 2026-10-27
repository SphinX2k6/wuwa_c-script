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
	// Token: 0x02005F5A RID: 24410
	public class WheelTowerMedalRuleView : UiViewBase
	{
		// Token: 0x0603DFF9 RID: 253945 RVA: 0x00EF6B90 File Offset: 0x00EF4D90
		[NullableContext(1)]
		public WheelTowerMedalRuleView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603DFFA RID: 253946 RVA: 0x00EF6B9C File Offset: 0x00EF4D9C
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

		// Token: 0x0603DFFB RID: 253947 RVA: 0x00EF6C48 File Offset: 0x00EF4E48
		protected override UniTask OnBeforeStartAsync()
		{
			WheelTowerMedalRuleView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<WheelTowerMedalRuleView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603DFFC RID: 253948 RVA: 0x00EF6C8B File Offset: 0x00EF4E8B
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x040205B6 RID: 132534
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x040205B7 RID: 132535
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<WheelTowerMedalRuleItem, WheelTowerMedalRuleItemData> TargetLoopScroll;
	}
}
