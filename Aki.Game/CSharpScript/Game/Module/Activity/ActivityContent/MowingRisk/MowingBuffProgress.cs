using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x0200535B RID: 21339
	[NullableContext(1)]
	[Nullable(0)]
	public class MowingBuffProgress : UiPanelBase
	{
		// Token: 0x0603518B RID: 217483 RVA: 0x00ED43C8 File Offset: 0x00ED25C8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603518C RID: 217484 RVA: 0x00ED44B8 File Offset: 0x00ED26B8
		protected override UniTask OnBeforeStartAsync()
		{
			MowingBuffProgress.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MowingBuffProgress.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603518D RID: 217485 RVA: 0x00ED44FC File Offset: 0x00ED26FC
		private UniTask CreateBuffItem(int index)
		{
			MowingBuffProgress.<CreateBuffItem>d__12 <CreateBuffItem>d__;
			<CreateBuffItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateBuffItem>d__.<>4__this = this;
			<CreateBuffItem>d__.index = index;
			<CreateBuffItem>d__.<>1__state = -1;
			<CreateBuffItem>d__.<>t__builder.Start<MowingBuffProgress.<CreateBuffItem>d__12>(ref <CreateBuffItem>d__);
			return <CreateBuffItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603518E RID: 217486 RVA: 0x00ED4548 File Offset: 0x00ED2748
		public void RefreshByCustomData(IMowingBuffProgressData data)
		{
			MowingBuffProgress.<>c__DisplayClass13_0 CS$<>8__locals1 = new MowingBuffProgress.<>c__DisplayClass13_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.data = data;
			UiAsyncTask task = new UiAsyncTask("MowingBuffProgress.RefreshByCustomDataAsync", delegate()
			{
				MowingBuffProgress.<>c__DisplayClass13_0.<<RefreshByCustomData>b__0>d <<RefreshByCustomData>b__0>d;
				<<RefreshByCustomData>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<RefreshByCustomData>b__0>d.<>4__this = CS$<>8__locals1;
				<<RefreshByCustomData>b__0>d.<>1__state = -1;
				<<RefreshByCustomData>b__0>d.<>t__builder.Start<MowingBuffProgress.<>c__DisplayClass13_0.<<RefreshByCustomData>b__0>d>(ref <<RefreshByCustomData>b__0>d);
				return <<RefreshByCustomData>b__0>d.<>t__builder.Task;
			}, null);
			base.RunAsyncTask(task);
		}

		// Token: 0x0603518F RID: 217487 RVA: 0x00ED458C File Offset: 0x00ED278C
		public UniTask RefreshByCustomDataAsync(IMowingBuffProgressData data)
		{
			MowingBuffProgress.<RefreshByCustomDataAsync>d__14 <RefreshByCustomDataAsync>d__;
			<RefreshByCustomDataAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshByCustomDataAsync>d__.<>4__this = this;
			<RefreshByCustomDataAsync>d__.data = data;
			<RefreshByCustomDataAsync>d__.<>1__state = -1;
			<RefreshByCustomDataAsync>d__.<>t__builder.Start<MowingBuffProgress.<RefreshByCustomDataAsync>d__14>(ref <RefreshByCustomDataAsync>d__);
			return <RefreshByCustomDataAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035190 RID: 217488 RVA: 0x00ED45D8 File Offset: 0x00ED27D8
		public UniTask PlayStartSequenceAsync()
		{
			MowingBuffProgress.<PlayStartSequenceAsync>d__15 <PlayStartSequenceAsync>d__;
			<PlayStartSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayStartSequenceAsync>d__.<>4__this = this;
			<PlayStartSequenceAsync>d__.<>1__state = -1;
			<PlayStartSequenceAsync>d__.<>t__builder.Start<MowingBuffProgress.<PlayStartSequenceAsync>d__15>(ref <PlayStartSequenceAsync>d__);
			return <PlayStartSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035191 RID: 217489 RVA: 0x00ED461C File Offset: 0x00ED281C
		public UniTask PlayProgressTween()
		{
			MowingBuffProgress.<PlayProgressTween>d__16 <PlayProgressTween>d__;
			<PlayProgressTween>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayProgressTween>d__.<>4__this = this;
			<PlayProgressTween>d__.<>1__state = -1;
			<PlayProgressTween>d__.<>t__builder.Start<MowingBuffProgress.<PlayProgressTween>d__16>(ref <PlayProgressTween>d__);
			return <PlayProgressTween>d__.<>t__builder.Task;
		}

		// Token: 0x06035192 RID: 217490 RVA: 0x00ED4660 File Offset: 0x00ED2860
		private void PlayFillAmount(float value)
		{
			base.GetSprite(1).SetFillAmount(value);
			if (this.BuffNodeTweenDataQueue.Size == 0)
			{
				return;
			}
			BuffNodeTweenData front = this.BuffNodeTweenDataQueue.Front;
			if (front == null)
			{
				return;
			}
			if (value >= front.Percentage)
			{
				front.BuffNodeItem.PlayUnlockSequence();
				this.BuffNodeTweenDataQueue.Pop();
			}
		}

		// Token: 0x06035193 RID: 217491 RVA: 0x00ED46B8 File Offset: 0x00ED28B8
		private void CheckKillTweener()
		{
			if (this.Tweener != null && this.Tweener.IsValid())
			{
				this.Tweener.Kill(false);
			}
			this.Tweener = null;
		}

		// Token: 0x06035194 RID: 217492 RVA: 0x00ED46E2 File Offset: 0x00ED28E2
		protected override void OnBeforeDestroy()
		{
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<float>(this.PlayFillAmount));
			this.CheckKillTweener();
		}

		// Token: 0x0401C082 RID: 114818
		private readonly List<MowingBuffUnit> BuffUnitList = new List<MowingBuffUnit>();

		// Token: 0x0401C083 RID: 114819
		private MowingBuffIntroduce BuffIntroduce;

		// Token: 0x0401C084 RID: 114820
		private UiSequencePlayer Player;

		// Token: 0x0401C085 RID: 114821
		[Nullable(2)]
		protected FLTweenFloatSetterDynamic Delegate;

		// Token: 0x0401C086 RID: 114822
		[Nullable(2)]
		protected ULTweener Tweener;

		// Token: 0x0401C087 RID: 114823
		private bool NeedPlayTween;

		// Token: 0x0401C088 RID: 114824
		private float FromProgress;

		// Token: 0x0401C089 RID: 114825
		private float ToProgress;

		// Token: 0x0401C08A RID: 114826
		private readonly Queue<BuffNodeTweenData> BuffNodeTweenDataQueue = new Queue<BuffNodeTweenData>(4);

		// Token: 0x0200AFC9 RID: 45001
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x04036559 RID: 222553
			public const int CountText = 0;

			// Token: 0x0403655A RID: 222554
			public const int ProgressSprite = 1;

			// Token: 0x0403655B RID: 222555
			public const int BuffLayout = 2;

			// Token: 0x0403655C RID: 222556
			public const int UpwardBuffTemplateItem = 3;

			// Token: 0x0403655D RID: 222557
			public const int DownwardBuffTemplateItem = 4;

			// Token: 0x0403655E RID: 222558
			public const int BuffIntroduceItem = 5;
		}
	}
}
