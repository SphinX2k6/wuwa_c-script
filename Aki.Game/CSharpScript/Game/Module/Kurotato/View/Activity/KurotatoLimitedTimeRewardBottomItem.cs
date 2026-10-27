using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.Activity
{
	// Token: 0x02005786 RID: 22406
	public class KurotatoLimitedTimeRewardBottomItem : UiPanelBase
	{
		// Token: 0x06038EA3 RID: 233123 RVA: 0x00D86D38 File Offset: 0x00D84F38
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUILayoutBase));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06038EA4 RID: 233124 RVA: 0x00D86DE3 File Offset: 0x00D84FE3
		protected override void OnStart()
		{
			this.GiftLayout = new GenericLayout<GiftItem, int>(base.GetLayoutBase(1), new Func<GiftItem>(this.CreateGiftItem), null, false, true);
			this.ProgressBarWidth = base.GetSprite(3).GetWidth();
		}

		// Token: 0x06038EA5 RID: 233125 RVA: 0x00D86E18 File Offset: 0x00D85018
		[NullableContext(1)]
		private GiftItem CreateGiftItem()
		{
			return new GiftItem
			{
				ReceiveCallback = new Action(this.OnReceiveCallback)
			};
		}

		// Token: 0x06038EA6 RID: 233126 RVA: 0x00D86E31 File Offset: 0x00D85031
		private void OnReceiveCallback()
		{
			this.Refresh();
		}

		// Token: 0x06038EA7 RID: 233127 RVA: 0x00D86E3C File Offset: 0x00D8503C
		public void Refresh()
		{
			int currentMilestone = KurotatoActivityController.Instance.GetActivityData().GetCurrentMilestone();
			List<int> tabIdList = (from config in KurotatoConfig.Instance.GetAllKurotatoScoreAwardConfig()
			select config.Id).ToList<int>();
			this.RefreshProgressItem(currentMilestone, tabIdList);
		}

		// Token: 0x06038EA8 RID: 233128 RVA: 0x00D86E98 File Offset: 0x00D85098
		[NullableContext(1)]
		public void RefreshProgressItem(int currentProgress, IReadOnlyList<int> tabIdList)
		{
			UUIText text = base.GetText(0);
			if (text != null)
			{
				text.SetText(currentProgress.ToString(), true);
			}
			float num = 0f;
			float num2 = 0f;
			int count = tabIdList.Count;
			int num3 = 0;
			for (int i = 0; i < count; i++)
			{
				int rewardId = tabIdList[i];
				KurotatoScoreAward value = KurotatoConfig.Instance.GetKurotatoScoreAwardConfigById(rewardId).Value;
				if (currentProgress >= value.Score)
				{
					num += 1f / (float)count;
				}
				else if (currentProgress > num3)
				{
					int score = value.Score;
					float num4 = this.ProgressBarWidth / (float)count - 130f;
					float num5 = (float)(currentProgress - num3) / (float)(score - num3);
					num2 = (num4 * num5 + 65f) / this.ProgressBarWidth;
					break;
				}
				num3 = value.Score;
			}
			base.GetSprite(3).SetFillAmount(num + num2);
			GenericLayout<GiftItem, int> giftLayout = this.GiftLayout;
			if (giftLayout == null)
			{
				return;
			}
			giftLayout.RefreshByData(tabIdList.ToList<int>(), null, false);
		}

		// Token: 0x0401DD63 RID: 122211
		private const int REWARD_ITEM_WIDTH = 130;

		// Token: 0x0401DD64 RID: 122212
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<GiftItem, int> GiftLayout;

		// Token: 0x0401DD65 RID: 122213
		private float ProgressBarWidth;

		// Token: 0x0200B9A8 RID: 47528
		private enum EComponents
		{
			// Token: 0x04038229 RID: 229929
			ProgressNum,
			// Token: 0x0403822A RID: 229930
			RewardLayout,
			// Token: 0x0403822B RID: 229931
			GiftItem,
			// Token: 0x0403822C RID: 229932
			ProgressBar
		}
	}
}
