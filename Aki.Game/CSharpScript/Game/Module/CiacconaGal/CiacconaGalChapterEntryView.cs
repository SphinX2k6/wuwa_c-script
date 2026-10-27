using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02005BE6 RID: 23526
	[NullableContext(1)]
	[Nullable(0)]
	public class CiacconaGalChapterEntryView : UiViewBase
	{
		// Token: 0x0603B77F RID: 243583 RVA: 0x00E2E896 File Offset: 0x00E2CA96
		public CiacconaGalChapterEntryView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603B780 RID: 243584 RVA: 0x00E2E8A0 File Offset: 0x00E2CAA0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603B781 RID: 243585 RVA: 0x00E2E990 File Offset: 0x00E2CB90
		protected override UniTask OnBeforeStartAsync()
		{
			CiacconaGalChapterEntryView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CiacconaGalChapterEntryView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603B782 RID: 243586 RVA: 0x00E2E9D3 File Offset: 0x00E2CBD3
		protected override void OnBeforeShow()
		{
			this.RefreshView();
		}

		// Token: 0x0603B783 RID: 243587 RVA: 0x00E2E9DC File Offset: 0x00E2CBDC
		private void RefreshView()
		{
			this.Data = (this.OpenParam as CiacconaGalActivityData);
			List<CiacconaGalChapterSlotData> list = new List<CiacconaGalChapterSlotData>();
			foreach (int id in this.Data.SlotIds)
			{
				CiacconaGalChapterSlotData chapterSlotDataById = CiacconaGalModel.Instance.GetChapterSlotDataById(id);
				if (chapterSlotDataById != null)
				{
					list.Add(chapterSlotDataById);
				}
			}
			this.LayoutChapter.RefreshByData(list, null, false);
			this.CiacconaEndingRewardItem.SetRedDotVisible(CiacconaGalModel.Instance.HasAnyEndingReward());
			ValueTuple<int, int> endingProgress = CiacconaGalModel.Instance.GetEndingProgress();
			CiacconaGalRewardButtonItem ciacconaEndingRewardItem = this.CiacconaEndingRewardItem;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(endingProgress.Item1);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(endingProgress.Item2);
			ciacconaEndingRewardItem.SetProgressText(defaultInterpolatedStringHandler.ToStringAndClear());
			this.CiacconaProgressRewardItem.SetRedDotVisible(CiacconaGalModel.Instance.HasAnyProgressReward());
			this.CiacconaProgressRewardItem.SetUiActive(CiacconaGalModel.Instance.ActivityData.IsInRewardTime);
			ValueTuple<int, int> progressRewardProgress = CiacconaGalModel.Instance.GetProgressRewardProgress();
			CiacconaGalRewardButtonItem ciacconaProgressRewardItem = this.CiacconaProgressRewardItem;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(progressRewardProgress.Item1);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(progressRewardProgress.Item2);
			ciacconaProgressRewardItem.SetProgressText(defaultInterpolatedStringHandler.ToStringAndClear());
		}

		// Token: 0x0603B784 RID: 243588 RVA: 0x00E2EB28 File Offset: 0x00E2CD28
		private CiacconaGalChapterEntryItem GetChapterEntryItem()
		{
			return new CiacconaGalChapterEntryItem();
		}

		// Token: 0x0603B785 RID: 243589 RVA: 0x00E2EB2F File Offset: 0x00E2CD2F
		private void OnEndingRewardClick()
		{
			CiacconaGalController.Instance.OpenEndingView();
		}

		// Token: 0x0603B786 RID: 243590 RVA: 0x00E2EB3B File Offset: 0x00E2CD3B
		private void OnProgressRewardClick()
		{
			CiacconaGalController.Instance.OpenRewardViewByActivityId(this.Data.Id);
		}

		// Token: 0x0603B787 RID: 243591 RVA: 0x00E2EB54 File Offset: 0x00E2CD54
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams.Length == 0)
			{
				return null;
			}
			GenericLayout<CiacconaGalChapterEntryItem, CiacconaGalChapterSlotData> layoutChapter = this.LayoutChapter;
			UUIItem uuiitem = (layoutChapter != null) ? layoutChapter.GetGridByDisplayIndex(0) : null;
			if (uuiitem == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				uuiitem,
				uuiitem
			};
		}

		// Token: 0x0401EFBA RID: 126906
		private PopupCaptionItem Caption;

		// Token: 0x0401EFBB RID: 126907
		private GenericLayout<CiacconaGalChapterEntryItem, CiacconaGalChapterSlotData> LayoutChapter;

		// Token: 0x0401EFBC RID: 126908
		private CiacconaTitleInspirationItem CiacconaTitleItem;

		// Token: 0x0401EFBD RID: 126909
		private CiacconaGalRewardButtonItem CiacconaEndingRewardItem;

		// Token: 0x0401EFBE RID: 126910
		private CiacconaGalRewardButtonItem CiacconaProgressRewardItem;

		// Token: 0x0401EFBF RID: 126911
		private CiacconaGalActivityData Data;

		// Token: 0x0200BDCB RID: 48587
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x040393A7 RID: 234407
			public const int ItemCaption = 0;

			// Token: 0x040393A8 RID: 234408
			public const int LayoutChapter = 1;

			// Token: 0x040393A9 RID: 234409
			public const int ItemChapter = 2;

			// Token: 0x040393AA RID: 234410
			public const int ItemEndingReward = 3;

			// Token: 0x040393AB RID: 234411
			public const int ItemProgressReward = 4;

			// Token: 0x040393AC RID: 234412
			public const int TextTitle = 5;
		}
	}
}
