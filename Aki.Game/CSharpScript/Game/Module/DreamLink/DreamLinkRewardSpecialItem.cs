using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.DreamLink
{
	// Token: 0x02005ABF RID: 23231
	[NullableContext(1)]
	[Nullable(0)]
	public class DreamLinkRewardSpecialItem : UiPanelBase
	{
		// Token: 0x0603AD67 RID: 240999 RVA: 0x00E056A5 File Offset: 0x00E038A5
		public DreamLinkRewardSpecialItem(DreamLinkRewardData rewardData)
		{
			this.RewardData = rewardData;
		}

		// Token: 0x0603AD68 RID: 241000 RVA: 0x00E056B4 File Offset: 0x00E038B4
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
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603AD69 RID: 241001 RVA: 0x00E057A1 File Offset: 0x00E039A1
		protected override void OnStart()
		{
			this.RewardScrollView = new GenericScrollViewNew<DreamLinkRewardSmallGrid, IDreamLinkRewardGridData>(base.GetScrollViewWithScrollbar(4), new Func<DreamLinkRewardSmallGrid>(this.InitGridItem), null, false, null);
		}

		// Token: 0x0603AD6A RID: 241002 RVA: 0x00E057C4 File Offset: 0x00E039C4
		protected override void OnBeforeShow()
		{
			this.Refresh();
		}

		// Token: 0x0603AD6B RID: 241003 RVA: 0x00E057CC File Offset: 0x00E039CC
		private DreamLinkRewardSmallGrid InitGridItem()
		{
			return new DreamLinkRewardSmallGrid();
		}

		// Token: 0x0603AD6C RID: 241004 RVA: 0x00E057D3 File Offset: 0x00E039D3
		public void Refresh()
		{
			this.RefreshProgress();
			this.RefreshReward();
		}

		// Token: 0x0603AD6D RID: 241005 RVA: 0x00E057E4 File Offset: 0x00E039E4
		private void RefreshProgress()
		{
			int current = this.RewardData.Current;
			int target = this.RewardData.Target;
			UUIText text = base.GetText(2);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(current);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(target);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			base.GetSprite(3).SetFillAmount((float)current / (float)target);
		}

		// Token: 0x0603AD6E RID: 241006 RVA: 0x00E05854 File Offset: 0x00E03A54
		private void RefreshReward()
		{
			RogueLimitTimeReward? limitTimeRewardConfig = DreamLinkConfig.Instance.GetLimitTimeRewardConfig(this.RewardData.Id);
			if (limitTimeRewardConfig == null)
			{
				return;
			}
			List<TItem> dropPackagePreviewItemList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(limitTimeRewardConfig.Value.TargetReward);
			IDreamLinkRewardGridData[] array = new IDreamLinkRewardGridData[dropPackagePreviewItemList.Count];
			for (int i = 0; i < dropPackagePreviewItemList.Count; i++)
			{
				TItem item = dropPackagePreviewItemList[i];
				array[i] = new DreamLinkRewardGridData
				{
					RewardId = this.RewardData.Id,
					Item = item,
					Status = this.RewardData.Status,
					ReceiveDelegate = new Action(this.OnReceiveDelegate)
				};
			}
			this.RewardScrollView.RefreshByData(array.ToList<IDreamLinkRewardGridData>(), null, false);
		}

		// Token: 0x0603AD6F RID: 241007 RVA: 0x00E0591E File Offset: 0x00E03B1E
		private void OnReceiveDelegate()
		{
			DreamLinkController.Instance.LimitTimeRewardRequest(this.RewardData.Id);
		}

		// Token: 0x0401EB3D RID: 125757
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected GenericScrollViewNew<DreamLinkRewardSmallGrid, IDreamLinkRewardGridData> RewardScrollView;

		// Token: 0x0401EB3E RID: 125758
		protected DreamLinkRewardData RewardData;

		// Token: 0x0200BD11 RID: 48401
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403905A RID: 233562
			public const int Panel = 0;

			// Token: 0x0403905B RID: 233563
			public const int TxtTitle = 1;

			// Token: 0x0403905C RID: 233564
			public const int TxtProgress = 2;

			// Token: 0x0403905D RID: 233565
			public const int SpriteProgress = 3;

			// Token: 0x0403905E RID: 233566
			public const int RewardLayout = 4;

			// Token: 0x0403905F RID: 233567
			public const int RewardItem = 5;
		}
	}
}
