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
	// Token: 0x02004BC6 RID: 19398
	[NullableContext(1)]
	[Nullable(0)]
	public class CiacconaGalChapterEntryView : UiViewBase
	{
		// Token: 0x060306CA RID: 198346 RVA: 0x00D7EBA6 File Offset: 0x00D7CDA6
		public CiacconaGalChapterEntryView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060306CB RID: 198347 RVA: 0x00D7EBB0 File Offset: 0x00D7CDB0
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

		// Token: 0x060306CC RID: 198348 RVA: 0x00D7ECA0 File Offset: 0x00D7CEA0
		protected override UniTask OnBeforeStartAsync()
		{
			CiacconaGalChapterEntryView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CiacconaGalChapterEntryView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060306CD RID: 198349 RVA: 0x00D7ECE3 File Offset: 0x00D7CEE3
		protected override void OnBeforeShow()
		{
			this.RefreshView();
		}

		// Token: 0x060306CE RID: 198350 RVA: 0x00D7ECEC File Offset: 0x00D7CEEC
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

		// Token: 0x060306CF RID: 198351 RVA: 0x00D7EE38 File Offset: 0x00D7D038
		private CiacconaGalChapterEntryItem GetChapterEntryItem()
		{
			return new CiacconaGalChapterEntryItem();
		}

		// Token: 0x060306D0 RID: 198352 RVA: 0x00D7EE3F File Offset: 0x00D7D03F
		private void OnEndingRewardClick()
		{
			CiacconaGalController.Instance.OpenEndingView();
		}

		// Token: 0x060306D1 RID: 198353 RVA: 0x00D7EE4B File Offset: 0x00D7D04B
		private void OnProgressRewardClick()
		{
			CiacconaGalController.Instance.OpenRewardViewByActivityId(this.Data.Id);
		}

		// Token: 0x060306D2 RID: 198354 RVA: 0x00D7EE64 File Offset: 0x00D7D064
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

		// Token: 0x04019A6B RID: 105067
		private PopupCaptionItem Caption;

		// Token: 0x04019A6C RID: 105068
		private GenericLayout<CiacconaGalChapterEntryItem, CiacconaGalChapterSlotData> LayoutChapter;

		// Token: 0x04019A6D RID: 105069
		private CiacconaTitleInspirationItem CiacconaTitleItem;

		// Token: 0x04019A6E RID: 105070
		private CiacconaGalRewardButtonItem CiacconaEndingRewardItem;

		// Token: 0x04019A6F RID: 105071
		private CiacconaGalRewardButtonItem CiacconaProgressRewardItem;

		// Token: 0x04019A70 RID: 105072
		private CiacconaGalActivityData Data;

		// Token: 0x0200A7D3 RID: 42963
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04033D6A RID: 212330
			public const int ItemCaption = 0;

			// Token: 0x04033D6B RID: 212331
			public const int LayoutChapter = 1;

			// Token: 0x04033D6C RID: 212332
			public const int ItemChapter = 2;

			// Token: 0x04033D6D RID: 212333
			public const int ItemEndingReward = 3;

			// Token: 0x04033D6E RID: 212334
			public const int ItemProgressReward = 4;

			// Token: 0x04033D6F RID: 212335
			public const int TextTitle = 5;
		}
	}
}
