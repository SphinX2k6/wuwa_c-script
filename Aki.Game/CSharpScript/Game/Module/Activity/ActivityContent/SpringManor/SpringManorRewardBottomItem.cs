using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x02004FE8 RID: 20456
	[NullableContext(1)]
	[Nullable(0)]
	public class SpringManorRewardBottomItem : UiPanelBase
	{
		// Token: 0x0603339E RID: 209822 RVA: 0x00E5B980 File Offset: 0x00E59B80
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
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
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603339F RID: 209823 RVA: 0x00E5BA4C File Offset: 0x00E59C4C
		protected override void OnStart()
		{
			this.GiftLayout = new GenericLayout<GiftItem, int>(base.GetLayoutBase(1), new Func<GiftItem>(this.CreateGiftItem), null, false, true);
			this.ProgressBarWidth = base.GetSprite(4).GetWidth();
		}

		// Token: 0x060333A0 RID: 209824 RVA: 0x00E5BA81 File Offset: 0x00E59C81
		private GiftItem CreateGiftItem()
		{
			return new GiftItem
			{
				ReceiveCallback = new Action(this.OnReceiveCallback)
			};
		}

		// Token: 0x060333A1 RID: 209825 RVA: 0x00E5BA9A File Offset: 0x00E59C9A
		private void OnReceiveCallback()
		{
			this.Refresh();
		}

		// Token: 0x060333A2 RID: 209826 RVA: 0x00E5BAA4 File Offset: 0x00E59CA4
		public void Refresh()
		{
			int currentMilestone = SpringManorModel.Instance.ActivityData.GetCurrentMilestone();
			List<int> list = new List<int>();
			foreach (SpringFestivalScoreReward springFestivalScoreReward in SpringManorModel.Instance.GetScoreRewardConfigList())
			{
				list.Add(springFestivalScoreReward.Id);
			}
			this.RefreshProgressItem(currentMilestone, list);
		}

		// Token: 0x060333A3 RID: 209827 RVA: 0x00E5BB1C File Offset: 0x00E59D1C
		public UniTask RefreshProgressItem(int currentProgress, List<int> dataList)
		{
			SpringManorRewardBottomItem.<RefreshProgressItem>d__7 <RefreshProgressItem>d__;
			<RefreshProgressItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshProgressItem>d__.<>4__this = this;
			<RefreshProgressItem>d__.currentProgress = currentProgress;
			<RefreshProgressItem>d__.dataList = dataList;
			<RefreshProgressItem>d__.<>1__state = -1;
			<RefreshProgressItem>d__.<>t__builder.Start<SpringManorRewardBottomItem.<RefreshProgressItem>d__7>(ref <RefreshProgressItem>d__);
			return <RefreshProgressItem>d__.<>t__builder.Task;
		}

		// Token: 0x0401B34E RID: 111438
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<GiftItem, int> GiftLayout;

		// Token: 0x0401B34F RID: 111439
		private float ProgressBarWidth;

		// Token: 0x0401B350 RID: 111440
		private const int REWARD_ITEM_WIDTH = 130;
	}
}
