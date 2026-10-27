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
	// Token: 0x0200606A RID: 24682
	[NullableContext(1)]
	[Nullable(0)]
	public class SpringManorRewardBottomItem : UiPanelBase
	{
		// Token: 0x0603E6DA RID: 255706 RVA: 0x00F14BBC File Offset: 0x00F12DBC
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

		// Token: 0x0603E6DB RID: 255707 RVA: 0x00F14C88 File Offset: 0x00F12E88
		protected override void OnStart()
		{
			this.GiftLayout = new GenericLayout<GiftItem, int>(base.GetLayoutBase(1), new Func<GiftItem>(this.CreateGiftItem), null, false, true);
			this.ProgressBarWidth = base.GetSprite(4).GetWidth();
		}

		// Token: 0x0603E6DC RID: 255708 RVA: 0x00F14CBD File Offset: 0x00F12EBD
		private GiftItem CreateGiftItem()
		{
			return new GiftItem
			{
				ReceiveCallback = new Action(this.OnReceiveCallback)
			};
		}

		// Token: 0x0603E6DD RID: 255709 RVA: 0x00F14CD6 File Offset: 0x00F12ED6
		private void OnReceiveCallback()
		{
			this.Refresh();
		}

		// Token: 0x0603E6DE RID: 255710 RVA: 0x00F14CE0 File Offset: 0x00F12EE0
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

		// Token: 0x0603E6DF RID: 255711 RVA: 0x00F14D58 File Offset: 0x00F12F58
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

		// Token: 0x04020A21 RID: 133665
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<GiftItem, int> GiftLayout;

		// Token: 0x04020A22 RID: 133666
		private float ProgressBarWidth;

		// Token: 0x04020A23 RID: 133667
		private const int REWARD_ITEM_WIDTH = 130;
	}
}
