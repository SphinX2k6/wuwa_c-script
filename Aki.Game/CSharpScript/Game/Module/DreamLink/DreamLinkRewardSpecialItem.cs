using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.DreamLink
{
	// Token: 0x02004A9B RID: 19099
	[NullableContext(1)]
	[Nullable(0)]
	public class DreamLinkRewardSpecialItem : UiPanelBase
	{
		// Token: 0x0602FCB3 RID: 195763 RVA: 0x00D55C6E File Offset: 0x00D53E6E
		public DreamLinkRewardSpecialItem(DreamLinkRewardData rewardData)
		{
			this.RewardData = rewardData;
		}

		// Token: 0x0602FCB4 RID: 195764 RVA: 0x00D55C80 File Offset: 0x00D53E80
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

		// Token: 0x0602FCB5 RID: 195765 RVA: 0x00D55D6D File Offset: 0x00D53F6D
		protected override void OnStart()
		{
			this.RewardScrollView = new GenericScrollViewNew<DreamLinkRewardSmallGrid, IDreamLinkRewardGridData>(base.GetScrollViewWithScrollbar(4), new Func<DreamLinkRewardSmallGrid>(this.InitGridItem), null, false, null);
		}

		// Token: 0x0602FCB6 RID: 195766 RVA: 0x00D55D90 File Offset: 0x00D53F90
		protected override void OnBeforeShow()
		{
			this.Refresh();
		}

		// Token: 0x0602FCB7 RID: 195767 RVA: 0x00D55D98 File Offset: 0x00D53F98
		private DreamLinkRewardSmallGrid InitGridItem()
		{
			return new DreamLinkRewardSmallGrid();
		}

		// Token: 0x0602FCB8 RID: 195768 RVA: 0x00D55D9F File Offset: 0x00D53F9F
		public void Refresh()
		{
			this.RefreshProgress();
			this.RefreshReward();
		}

		// Token: 0x0602FCB9 RID: 195769 RVA: 0x00D55DB0 File Offset: 0x00D53FB0
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

		// Token: 0x0602FCBA RID: 195770 RVA: 0x00D55E20 File Offset: 0x00D54020
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
			this.RewardScrollView.RefreshByData(array, null, false);
		}

		// Token: 0x0602FCBB RID: 195771 RVA: 0x00D55EE5 File Offset: 0x00D540E5
		private void OnReceiveDelegate()
		{
			DreamLinkController.Instance.LimitTimeRewardRequest(this.RewardData.Id);
		}

		// Token: 0x040195E4 RID: 103908
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected GenericScrollViewNew<DreamLinkRewardSmallGrid, IDreamLinkRewardGridData> RewardScrollView;

		// Token: 0x040195E5 RID: 103909
		protected DreamLinkRewardData RewardData;

		// Token: 0x0200A719 RID: 42777
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04033A24 RID: 211492
			public const int Panel = 0;

			// Token: 0x04033A25 RID: 211493
			public const int TxtTitle = 1;

			// Token: 0x04033A26 RID: 211494
			public const int TxtProgress = 2;

			// Token: 0x04033A27 RID: 211495
			public const int SpriteProgress = 3;

			// Token: 0x04033A28 RID: 211496
			public const int RewardLayout = 4;

			// Token: 0x04033A29 RID: 211497
			public const int RewardItem = 5;
		}
	}
}
