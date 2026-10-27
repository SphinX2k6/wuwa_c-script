using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x02005BF6 RID: 23542
	[NullableContext(1)]
	[Nullable(0)]
	public class CiacconaActivityRewardView : UiTickViewBase
	{
		// Token: 0x0603B7EE RID: 243694 RVA: 0x00E306F4 File Offset: 0x00E2E8F4
		public CiacconaActivityRewardView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603B7EF RID: 243695 RVA: 0x00E30700 File Offset: 0x00E2E900
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

		// Token: 0x0603B7F0 RID: 243696 RVA: 0x00E307F0 File Offset: 0x00E2E9F0
		protected override UniTask OnBeforeStartAsync()
		{
			CiacconaActivityRewardView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CiacconaActivityRewardView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603B7F1 RID: 243697 RVA: 0x00E30834 File Offset: 0x00E2EA34
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

		// Token: 0x0603B7F2 RID: 243698 RVA: 0x00E30895 File Offset: 0x00E2EA95
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.OnCiacconaRewardDataUpdate, new Action(this.OnDataUpdate));
		}

		// Token: 0x0603B7F3 RID: 243699 RVA: 0x00E308B3 File Offset: 0x00E2EAB3
		protected override void OnTick(float _)
		{
			this.RefreshTimeStr();
		}

		// Token: 0x0603B7F4 RID: 243700 RVA: 0x00E308BC File Offset: 0x00E2EABC
		private void Refresh()
		{
			CiacconaGalRewardData[] allRewardDataByActivityId = CiacconaGalModel.Instance.GetAllRewardDataByActivityId(this.ActivityData.Id);
			GenericScrollViewNew<CiacconaActivityRewardItem, CiacconaGalRewardData> scrollView = this.ScrollView;
			if (scrollView != null)
			{
				scrollView.RefreshByData(allRewardDataByActivityId.ToList<CiacconaGalRewardData>(), null, false);
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

		// Token: 0x0603B7F5 RID: 243701 RVA: 0x00E30968 File Offset: 0x00E2EB68
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

		// Token: 0x0603B7F6 RID: 243702 RVA: 0x00E309AB File Offset: 0x00E2EBAB
		private CiacconaActivityRewardItem CreateItem()
		{
			return new CiacconaActivityRewardItem();
		}

		// Token: 0x0603B7F7 RID: 243703 RVA: 0x00E309B2 File Offset: 0x00E2EBB2
		private void OnDataUpdate()
		{
			this.Refresh();
		}

		// Token: 0x0401EFE8 RID: 126952
		private PopupCaptionItem ItemCaption;

		// Token: 0x0401EFE9 RID: 126953
		private GenericScrollViewNew<CiacconaActivityRewardItem, CiacconaGalRewardData> ScrollView;

		// Token: 0x0401EFEA RID: 126954
		private CiacconaGalActivityData ActivityData;

		// Token: 0x0200BDE0 RID: 48608
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04039408 RID: 234504
			public const int ItemCaption = 0;

			// Token: 0x04039409 RID: 234505
			public const int TextNum = 1;

			// Token: 0x0403940A RID: 234506
			public const int SpriteProgress = 2;

			// Token: 0x0403940B RID: 234507
			public const int ScrollView = 3;

			// Token: 0x0403940C RID: 234508
			public const int ItemTask = 4;

			// Token: 0x0403940D RID: 234509
			public const int TextTime = 5;
		}
	}
}
