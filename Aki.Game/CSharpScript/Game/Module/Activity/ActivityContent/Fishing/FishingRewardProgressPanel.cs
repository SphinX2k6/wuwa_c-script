using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02005503 RID: 21763
	[NullableContext(1)]
	[Nullable(0)]
	public class FishingRewardProgressPanel : UiPanelBase
	{
		// Token: 0x06035EEE RID: 220910 RVA: 0x00F0FF50 File Offset: 0x00F0E150
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06035EEF RID: 220911 RVA: 0x00F1001C File Offset: 0x00F0E21C
		protected override void OnStart()
		{
			this.ProgressLayout = new GenericLayout<FishingRewardProgressItem, FishingRewardProgressData>(base.GetHorizontalLayout(1), new Func<FishingRewardProgressItem>(this.ProgressItemProxyCreate), null, false, true);
			this.ProgressBarWidth = base.GetSprite(4).GetWidth();
		}

		// Token: 0x06035EF0 RID: 220912 RVA: 0x00F10051 File Offset: 0x00F0E251
		private FishingRewardProgressItem ProgressItemProxyCreate()
		{
			return new FishingRewardProgressItem
			{
				OnClickToGet = this.OnClickToGet
			};
		}

		// Token: 0x06035EF1 RID: 220913 RVA: 0x00F10064 File Offset: 0x00F0E264
		public UniTask RefreshProgressItem(int currentProgress, int maxProgress, FishingRewardProgressData[] dataList)
		{
			FishingRewardProgressPanel.<RefreshProgressItem>d__8 <RefreshProgressItem>d__;
			<RefreshProgressItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshProgressItem>d__.<>4__this = this;
			<RefreshProgressItem>d__.currentProgress = currentProgress;
			<RefreshProgressItem>d__.dataList = dataList;
			<RefreshProgressItem>d__.<>1__state = -1;
			<RefreshProgressItem>d__.<>t__builder.Start<FishingRewardProgressPanel.<RefreshProgressItem>d__8>(ref <RefreshProgressItem>d__);
			return <RefreshProgressItem>d__.<>t__builder.Task;
		}

		// Token: 0x0401C818 RID: 116760
		private const int REWARD_ITEM_WIDTH = 108;

		// Token: 0x0401C819 RID: 116761
		protected GenericLayout<FishingRewardProgressItem, FishingRewardProgressData> ProgressLayout;

		// Token: 0x0401C81A RID: 116762
		protected float ProgressBarWidth;

		// Token: 0x0401C81B RID: 116763
		[Nullable(2)]
		public Action OnClickToGet;

		// Token: 0x0200B160 RID: 45408
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x04036D9D RID: 224669
			public const int TxtProgress = 0;

			// Token: 0x04036D9E RID: 224670
			public const int ProgressLayout = 1;

			// Token: 0x04036D9F RID: 224671
			public const int ProgressItem = 2;

			// Token: 0x04036DA0 RID: 224672
			public const int DotStart = 3;

			// Token: 0x04036DA1 RID: 224673
			public const int BarProgress = 4;
		}
	}
}
