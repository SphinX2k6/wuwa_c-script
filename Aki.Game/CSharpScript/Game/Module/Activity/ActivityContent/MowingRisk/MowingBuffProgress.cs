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
	// Token: 0x020063DD RID: 25565
	[NullableContext(1)]
	[Nullable(0)]
	public class MowingBuffProgress : UiPanelBase
	{
		// Token: 0x060404CA RID: 263370 RVA: 0x00F8D430 File Offset: 0x00F8B630
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

		// Token: 0x060404CB RID: 263371 RVA: 0x00F8D520 File Offset: 0x00F8B720
		protected override UniTask OnBeforeStartAsync()
		{
			MowingBuffProgress.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MowingBuffProgress.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060404CC RID: 263372 RVA: 0x00F8D564 File Offset: 0x00F8B764
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

		// Token: 0x060404CD RID: 263373 RVA: 0x00F8D5B0 File Offset: 0x00F8B7B0
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

		// Token: 0x060404CE RID: 263374 RVA: 0x00F8D5F4 File Offset: 0x00F8B7F4
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

		// Token: 0x060404CF RID: 263375 RVA: 0x00F8D640 File Offset: 0x00F8B840
		public UniTask PlayStartSequenceAsync()
		{
			MowingBuffProgress.<PlayStartSequenceAsync>d__15 <PlayStartSequenceAsync>d__;
			<PlayStartSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayStartSequenceAsync>d__.<>4__this = this;
			<PlayStartSequenceAsync>d__.<>1__state = -1;
			<PlayStartSequenceAsync>d__.<>t__builder.Start<MowingBuffProgress.<PlayStartSequenceAsync>d__15>(ref <PlayStartSequenceAsync>d__);
			return <PlayStartSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060404D0 RID: 263376 RVA: 0x00F8D684 File Offset: 0x00F8B884
		public UniTask PlayProgressTween()
		{
			MowingBuffProgress.<PlayProgressTween>d__16 <PlayProgressTween>d__;
			<PlayProgressTween>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayProgressTween>d__.<>4__this = this;
			<PlayProgressTween>d__.<>1__state = -1;
			<PlayProgressTween>d__.<>t__builder.Start<MowingBuffProgress.<PlayProgressTween>d__16>(ref <PlayProgressTween>d__);
			return <PlayProgressTween>d__.<>t__builder.Task;
		}

		// Token: 0x060404D1 RID: 263377 RVA: 0x00F8D6C8 File Offset: 0x00F8B8C8
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

		// Token: 0x060404D2 RID: 263378 RVA: 0x00F8D720 File Offset: 0x00F8B920
		private void CheckKillTweener()
		{
			if (this.Tweener != null && this.Tweener.IsValid())
			{
				this.Tweener.Kill(false);
			}
			this.Tweener = null;
		}

		// Token: 0x060404D3 RID: 263379 RVA: 0x00F8D74A File Offset: 0x00F8B94A
		protected override void OnBeforeDestroy()
		{
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<float>(this.PlayFillAmount));
			this.CheckKillTweener();
		}

		// Token: 0x04021753 RID: 137043
		private readonly List<MowingBuffUnit> BuffUnitList = new List<MowingBuffUnit>();

		// Token: 0x04021754 RID: 137044
		private MowingBuffIntroduce BuffIntroduce;

		// Token: 0x04021755 RID: 137045
		private UiSequencePlayer Player;

		// Token: 0x04021756 RID: 137046
		[Nullable(2)]
		protected FLTweenFloatSetterDynamic Delegate;

		// Token: 0x04021757 RID: 137047
		[Nullable(2)]
		protected ULTweener Tweener;

		// Token: 0x04021758 RID: 137048
		private bool NeedPlayTween;

		// Token: 0x04021759 RID: 137049
		private float FromProgress;

		// Token: 0x0402175A RID: 137050
		private float ToProgress;

		// Token: 0x0402175B RID: 137051
		private readonly Queue<BuffNodeTweenData> BuffNodeTweenDataQueue = new Queue<BuffNodeTweenData>(4);

		// Token: 0x0200C5E2 RID: 50658
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x0403BBFA RID: 244730
			public const int CountText = 0;

			// Token: 0x0403BBFB RID: 244731
			public const int ProgressSprite = 1;

			// Token: 0x0403BBFC RID: 244732
			public const int BuffLayout = 2;

			// Token: 0x0403BBFD RID: 244733
			public const int UpwardBuffTemplateItem = 3;

			// Token: 0x0403BBFE RID: 244734
			public const int DownwardBuffTemplateItem = 4;

			// Token: 0x0403BBFF RID: 244735
			public const int BuffIntroduceItem = 5;
		}
	}
}
