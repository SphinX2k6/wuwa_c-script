using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x02005359 RID: 21337
	[NullableContext(1)]
	[Nullable(0)]
	public class MowingBuffOverview : UiPanelBase
	{
		// Token: 0x0603517C RID: 217468 RVA: 0x00ED409C File Offset: 0x00ED229C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603517D RID: 217469 RVA: 0x00ED418C File Offset: 0x00ED238C
		protected override UniTask OnBeforeStartAsync()
		{
			MowingBuffOverview.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MowingBuffOverview.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603517E RID: 217470 RVA: 0x00ED41D0 File Offset: 0x00ED23D0
		private UniTask CreateBuffIntroduceAsync()
		{
			MowingBuffOverview.<CreateBuffIntroduceAsync>d__7 <CreateBuffIntroduceAsync>d__;
			<CreateBuffIntroduceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateBuffIntroduceAsync>d__.<>4__this = this;
			<CreateBuffIntroduceAsync>d__.<>1__state = -1;
			<CreateBuffIntroduceAsync>d__.<>t__builder.Start<MowingBuffOverview.<CreateBuffIntroduceAsync>d__7>(ref <CreateBuffIntroduceAsync>d__);
			return <CreateBuffIntroduceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603517F RID: 217471 RVA: 0x00ED4213 File Offset: 0x00ED2413
		private void CreateFilterEntrance()
		{
			base.GetItem(2).SetUIActive(false);
		}

		// Token: 0x06035180 RID: 217472 RVA: 0x00ED4222 File Offset: 0x00ED2422
		private void CreateBuffContent()
		{
			this.BuffContent = new GenericLayout<MowingBuffGridGroup, IMowingBuffGridGroupData>(base.GetVerticalLayout(3), new Func<MowingBuffGridGroup>(this.BuildGridGroup), null, true, true);
		}

		// Token: 0x06035181 RID: 217473 RVA: 0x00ED4248 File Offset: 0x00ED2448
		public UniTask RefreshByCustomDataAsync(IMowingBuffOverviewData data)
		{
			MowingBuffOverview.<RefreshByCustomDataAsync>d__10 <RefreshByCustomDataAsync>d__;
			<RefreshByCustomDataAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshByCustomDataAsync>d__.<>4__this = this;
			<RefreshByCustomDataAsync>d__.data = data;
			<RefreshByCustomDataAsync>d__.<>1__state = -1;
			<RefreshByCustomDataAsync>d__.<>t__builder.Start<MowingBuffOverview.<RefreshByCustomDataAsync>d__10>(ref <RefreshByCustomDataAsync>d__);
			return <RefreshByCustomDataAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035182 RID: 217474 RVA: 0x00ED4294 File Offset: 0x00ED2494
		public UniTask PlayStartSequenceAsync()
		{
			MowingBuffOverview.<PlayStartSequenceAsync>d__11 <PlayStartSequenceAsync>d__;
			<PlayStartSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayStartSequenceAsync>d__.<>4__this = this;
			<PlayStartSequenceAsync>d__.<>1__state = -1;
			<PlayStartSequenceAsync>d__.<>t__builder.Start<MowingBuffOverview.<PlayStartSequenceAsync>d__11>(ref <PlayStartSequenceAsync>d__);
			return <PlayStartSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035183 RID: 217475 RVA: 0x00ED42D8 File Offset: 0x00ED24D8
		public void PlayUnlockSequenceAsync()
		{
			if (this.Data == null)
			{
				return;
			}
			foreach (MowingBuffGridGroup mowingBuffGridGroup in this.BuffContent.GetLayoutItemList())
			{
				foreach (MowingBuffGridItem mowingBuffGridItem in mowingBuffGridGroup.GetBuffGridItemLayout().GetLayoutItemList())
				{
					if (mowingBuffGridItem.CheckNeedPlayUnlockSequence())
					{
						mowingBuffGridItem.PlayUnlockEffect();
					}
				}
			}
		}

		// Token: 0x06035184 RID: 217476 RVA: 0x00ED4380 File Offset: 0x00ED2580
		private MowingBuffGridGroup BuildGridGroup()
		{
			return new MowingBuffGridGroup();
		}

		// Token: 0x0401C07C RID: 114812
		[Nullable(2)]
		private IMowingBuffOverviewData Data;

		// Token: 0x0401C07D RID: 114813
		private MowingBuffIntroduce BuffIntroduce;

		// Token: 0x0401C07E RID: 114814
		private GenericLayout<MowingBuffGridGroup, IMowingBuffGridGroupData> BuffContent;

		// Token: 0x0401C07F RID: 114815
		private UiSequencePlayer Player;

		// Token: 0x0200AFC4 RID: 44996
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x04036541 RID: 222529
			public const int IntroduceItem = 0;

			// Token: 0x04036542 RID: 222530
			public const int NonExistRoot = 1;

			// Token: 0x04036543 RID: 222531
			public const int FilterItem = 2;

			// Token: 0x04036544 RID: 222532
			public const int BuffLayout = 3;

			// Token: 0x04036545 RID: 222533
			public const int BuffItem = 4;

			// Token: 0x04036546 RID: 222534
			public const int ExistRoot = 5;
		}
	}
}
