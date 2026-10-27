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
	// Token: 0x020063DB RID: 25563
	[NullableContext(1)]
	[Nullable(0)]
	public class MowingBuffOverview : UiPanelBase
	{
		// Token: 0x060404BB RID: 263355 RVA: 0x00F8D104 File Offset: 0x00F8B304
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

		// Token: 0x060404BC RID: 263356 RVA: 0x00F8D1F4 File Offset: 0x00F8B3F4
		protected override UniTask OnBeforeStartAsync()
		{
			MowingBuffOverview.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MowingBuffOverview.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060404BD RID: 263357 RVA: 0x00F8D238 File Offset: 0x00F8B438
		private UniTask CreateBuffIntroduceAsync()
		{
			MowingBuffOverview.<CreateBuffIntroduceAsync>d__7 <CreateBuffIntroduceAsync>d__;
			<CreateBuffIntroduceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateBuffIntroduceAsync>d__.<>4__this = this;
			<CreateBuffIntroduceAsync>d__.<>1__state = -1;
			<CreateBuffIntroduceAsync>d__.<>t__builder.Start<MowingBuffOverview.<CreateBuffIntroduceAsync>d__7>(ref <CreateBuffIntroduceAsync>d__);
			return <CreateBuffIntroduceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060404BE RID: 263358 RVA: 0x00F8D27B File Offset: 0x00F8B47B
		private void CreateFilterEntrance()
		{
			base.GetItem(2).SetUIActive(false);
		}

		// Token: 0x060404BF RID: 263359 RVA: 0x00F8D28A File Offset: 0x00F8B48A
		private void CreateBuffContent()
		{
			this.BuffContent = new GenericLayout<MowingBuffGridGroup, IMowingBuffGridGroupData>(base.GetVerticalLayout(3), new Func<MowingBuffGridGroup>(this.BuildGridGroup), null, true, true);
		}

		// Token: 0x060404C0 RID: 263360 RVA: 0x00F8D2B0 File Offset: 0x00F8B4B0
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

		// Token: 0x060404C1 RID: 263361 RVA: 0x00F8D2FC File Offset: 0x00F8B4FC
		public UniTask PlayStartSequenceAsync()
		{
			MowingBuffOverview.<PlayStartSequenceAsync>d__11 <PlayStartSequenceAsync>d__;
			<PlayStartSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayStartSequenceAsync>d__.<>4__this = this;
			<PlayStartSequenceAsync>d__.<>1__state = -1;
			<PlayStartSequenceAsync>d__.<>t__builder.Start<MowingBuffOverview.<PlayStartSequenceAsync>d__11>(ref <PlayStartSequenceAsync>d__);
			return <PlayStartSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060404C2 RID: 263362 RVA: 0x00F8D340 File Offset: 0x00F8B540
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

		// Token: 0x060404C3 RID: 263363 RVA: 0x00F8D3E8 File Offset: 0x00F8B5E8
		private MowingBuffGridGroup BuildGridGroup()
		{
			return new MowingBuffGridGroup();
		}

		// Token: 0x0402174D RID: 137037
		[Nullable(2)]
		private IMowingBuffOverviewData Data;

		// Token: 0x0402174E RID: 137038
		private MowingBuffIntroduce BuffIntroduce;

		// Token: 0x0402174F RID: 137039
		private GenericLayout<MowingBuffGridGroup, IMowingBuffGridGroupData> BuffContent;

		// Token: 0x04021750 RID: 137040
		private UiSequencePlayer Player;

		// Token: 0x0200C5DD RID: 50653
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x0403BBE2 RID: 244706
			public const int IntroduceItem = 0;

			// Token: 0x0403BBE3 RID: 244707
			public const int NonExistRoot = 1;

			// Token: 0x0403BBE4 RID: 244708
			public const int FilterItem = 2;

			// Token: 0x0403BBE5 RID: 244709
			public const int BuffLayout = 3;

			// Token: 0x0403BBE6 RID: 244710
			public const int BuffItem = 4;

			// Token: 0x0403BBE7 RID: 244711
			public const int ExistRoot = 5;
		}
	}
}
