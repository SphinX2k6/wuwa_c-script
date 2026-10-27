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
	// Token: 0x02006585 RID: 25989
	[NullableContext(1)]
	[Nullable(0)]
	public class FishingRewardProgressPanel : UiPanelBase
	{
		// Token: 0x06041229 RID: 266793 RVA: 0x00FC8F9C File Offset: 0x00FC719C
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

		// Token: 0x0604122A RID: 266794 RVA: 0x00FC9068 File Offset: 0x00FC7268
		protected override void OnStart()
		{
			this.ProgressLayout = new GenericLayout<FishingRewardProgressItem, FishingRewardProgressData>(base.GetHorizontalLayout(1), new Func<FishingRewardProgressItem>(this.ProgressItemProxyCreate), null, false, true);
			this.ProgressBarWidth = base.GetSprite(4).GetWidth();
		}

		// Token: 0x0604122B RID: 266795 RVA: 0x00FC909D File Offset: 0x00FC729D
		private FishingRewardProgressItem ProgressItemProxyCreate()
		{
			return new FishingRewardProgressItem
			{
				OnClickToGet = this.OnClickToGet
			};
		}

		// Token: 0x0604122C RID: 266796 RVA: 0x00FC90B0 File Offset: 0x00FC72B0
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

		// Token: 0x04021EE7 RID: 138983
		private const int REWARD_ITEM_WIDTH = 108;

		// Token: 0x04021EE8 RID: 138984
		protected GenericLayout<FishingRewardProgressItem, FishingRewardProgressData> ProgressLayout;

		// Token: 0x04021EE9 RID: 138985
		protected float ProgressBarWidth;

		// Token: 0x04021EEA RID: 138986
		[Nullable(2)]
		public Action OnClickToGet;

		// Token: 0x0200C77B RID: 51067
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x0403C44C RID: 246860
			public const int TxtProgress = 0;

			// Token: 0x0403C44D RID: 246861
			public const int ProgressLayout = 1;

			// Token: 0x0403C44E RID: 246862
			public const int ProgressItem = 2;

			// Token: 0x0403C44F RID: 246863
			public const int DotStart = 3;

			// Token: 0x0403C450 RID: 246864
			public const int BarProgress = 4;
		}
	}
}
