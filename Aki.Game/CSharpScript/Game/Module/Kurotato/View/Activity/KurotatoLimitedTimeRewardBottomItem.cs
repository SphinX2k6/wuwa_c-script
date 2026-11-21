using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.Activity
{
	// Token: 0x0200475D RID: 18269
	public class KurotatoLimitedTimeRewardBottomItem : UiPanelBase
	{
		// Token: 0x0602DDB3 RID: 187827 RVA: 0x00CD5A7C File Offset: 0x00CD3C7C
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

		// Token: 0x0602DDB4 RID: 187828 RVA: 0x00CD5B27 File Offset: 0x00CD3D27
		protected override void OnStart()
		{
			this.GiftLayout = new GenericLayout<GiftItem, int>(base.GetLayoutBase(1), new Func<GiftItem>(this.CreateGiftItem), null, false, true);
			this.ProgressBarWidth = base.GetSprite(3).GetWidth();
		}

		// Token: 0x0602DDB5 RID: 187829 RVA: 0x00CD5B5C File Offset: 0x00CD3D5C
		[NullableContext(1)]
		private GiftItem CreateGiftItem()
		{
			return new GiftItem
			{
				ReceiveCallback = new Action(this.OnReceiveCallback)
			};
		}

		// Token: 0x0602DDB6 RID: 187830 RVA: 0x00CD5B75 File Offset: 0x00CD3D75
		private void OnReceiveCallback()
		{
			this.Refresh();
		}

		// Token: 0x0602DDB7 RID: 187831 RVA: 0x00CD5B80 File Offset: 0x00CD3D80
		public void Refresh()
		{
			int currentMilestone = KurotatoActivityController.Instance.GetActivityData().GetCurrentMilestone();
			List<int> list = new List<int>();
			foreach (KurotatoScoreAward kurotatoScoreAward in KurotatoConfig.Instance.GetAllKurotatoScoreAwardConfig())
			{
				list.Add(kurotatoScoreAward.Id);
			}
			this.RefreshProgressItem(currentMilestone, list);
		}

		// Token: 0x0602DDB8 RID: 187832 RVA: 0x00CD5BF8 File Offset: 0x00CD3DF8
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
			giftLayout.RefreshByData(tabIdList, null, false);
		}

		// Token: 0x040187F9 RID: 100345
		private const int REWARD_ITEM_WIDTH = 130;

		// Token: 0x040187FA RID: 100346
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<GiftItem, int> GiftLayout;

		// Token: 0x040187FB RID: 100347
		private float ProgressBarWidth;

		// Token: 0x0200A3BF RID: 41919
		private enum EComponents
		{
			// Token: 0x04032C1B RID: 207899
			ProgressNum,
			// Token: 0x04032C1C RID: 207900
			RewardLayout,
			// Token: 0x04032C1D RID: 207901
			GiftItem,
			// Token: 0x04032C1E RID: 207902
			ProgressBar
		}
	}
}
