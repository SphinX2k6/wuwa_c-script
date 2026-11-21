using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02004BD6 RID: 19414
	[NullableContext(1)]
	[Nullable(0)]
	public class CiacconaActivityRewardView : UiTickViewBase
	{
		// Token: 0x06030739 RID: 198457 RVA: 0x00D80A00 File Offset: 0x00D7EC00
		public CiacconaActivityRewardView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603073A RID: 198458 RVA: 0x00D80A0C File Offset: 0x00D7EC0C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603073B RID: 198459 RVA: 0x00D80AFC File Offset: 0x00D7ECFC
		protected override UniTask OnBeforeStartAsync()
		{
			CiacconaActivityRewardView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CiacconaActivityRewardView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603073C RID: 198460 RVA: 0x00D80B40 File Offset: 0x00D7ED40
		protected override void OnStart()
		{
			this.ScrollView = new GenericScrollViewNew<CiacconaActivityRewardItem, CiacconaGalRewardData>(base.GetScrollViewWithScrollbar(3), new Func<CiacconaActivityRewardItem>(this.CreateItem), null, false, null);
			this.Refresh();
			GenericScrollViewNew<CiacconaActivityRewardItem, CiacconaGalRewardData> scrollView = this.ScrollView;
			if (scrollView != null)
			{
				scrollView.PlayTurnAnimation();
			}
			EventSystem.Instance.Add(EEventName.OnCiacconaRewardDataUpdate, new Action(this.OnDataUpdate));
		}

		// Token: 0x0603073D RID: 198461 RVA: 0x00D80BA1 File Offset: 0x00D7EDA1
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.OnCiacconaRewardDataUpdate, new Action(this.OnDataUpdate));
		}

		// Token: 0x0603073E RID: 198462 RVA: 0x00D80BBF File Offset: 0x00D7EDBF
		protected override void OnTick(float _)
		{
			this.RefreshTimeStr();
		}

		// Token: 0x0603073F RID: 198463 RVA: 0x00D80BC8 File Offset: 0x00D7EDC8
		private void Refresh()
		{
			CiacconaGalRewardData[] allRewardDataByActivityId = CiacconaGalModel.Instance.GetAllRewardDataByActivityId(this.ActivityData.Id);
			GenericScrollViewNew<CiacconaActivityRewardItem, CiacconaGalRewardData> scrollView = this.ScrollView;
			if (scrollView != null)
			{
				scrollView.RefreshByData(allRewardDataByActivityId, null, false);
			}
			ValueTuple<int, int> progressRewardProgress = CiacconaGalModel.Instance.GetProgressRewardProgress();
			int item = progressRewardProgress.Item1;
			int item2 = progressRewardProgress.Item2;
			UUIText text = base.GetText(1);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(item);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(item2);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			base.GetSprite(2).fillAmount = (float)item * 1f / (float)((item2 == 0) ? 1 : item2);
		}

		// Token: 0x06030740 RID: 198464 RVA: 0x00D80C6C File Offset: 0x00D7EE6C
		private void RefreshTimeStr()
		{
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew("Xkjsx_Rewards_Timeless", null);
			string rewardRemainTimeStr = this.ActivityData.RewardRemainTimeStr;
			string newText = localTextNew + " " + rewardRemainTimeStr;
			UUIText text = base.GetText(5);
			if (text == null)
			{
				return;
			}
			text.SetText(newText, true);
		}

		// Token: 0x06030741 RID: 198465 RVA: 0x00D80CAF File Offset: 0x00D7EEAF
		private CiacconaActivityRewardItem CreateItem()
		{
			return new CiacconaActivityRewardItem();
		}

		// Token: 0x06030742 RID: 198466 RVA: 0x00D80CB6 File Offset: 0x00D7EEB6
		private void OnDataUpdate()
		{
			this.Refresh();
		}

		// Token: 0x04019A99 RID: 105113
		private PopupCaptionItem ItemCaption;

		// Token: 0x04019A9A RID: 105114
		private GenericScrollViewNew<CiacconaActivityRewardItem, CiacconaGalRewardData> ScrollView;

		// Token: 0x04019A9B RID: 105115
		private CiacconaGalActivityData ActivityData;

		// Token: 0x0200A7E8 RID: 42984
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04033DCB RID: 212427
			public const int ItemCaption = 0;

			// Token: 0x04033DCC RID: 212428
			public const int TextNum = 1;

			// Token: 0x04033DCD RID: 212429
			public const int SpriteProgress = 2;

			// Token: 0x04033DCE RID: 212430
			public const int ScrollView = 3;

			// Token: 0x04033DCF RID: 212431
			public const int ItemTask = 4;

			// Token: 0x04033DD0 RID: 212432
			public const int TextTime = 5;
		}
	}
}
