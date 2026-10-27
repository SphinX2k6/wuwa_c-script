using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorFight
{
	// Token: 0x0200642F RID: 25647
	public class MotorFightSuccessView : UiViewBase
	{
		// Token: 0x060407C5 RID: 264133 RVA: 0x00F9B41A File Offset: 0x00F9961A
		[NullableContext(1)]
		public MotorFightSuccessView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060407C6 RID: 264134 RVA: 0x00F9B424 File Offset: 0x00F99624
		protected unsafe override void OnRegisterComponent()
		{
			int num = 12;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIArtText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(10, new Action(this.OnExitBtnClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(11, new Action(this.OnReChallengeBtnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060407C7 RID: 264135 RVA: 0x00F9B640 File Offset: 0x00F99840
		protected override UniTask OnBeforeStartAsync()
		{
			MotorFightSuccessView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MotorFightSuccessView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060407C8 RID: 264136 RVA: 0x00F9B683 File Offset: 0x00F99883
		[NullableContext(1)]
		private CommonItemSmallItemGrid InitGridItem()
		{
			return new CommonItemSmallItemGrid();
		}

		// Token: 0x060407C9 RID: 264137 RVA: 0x00F9B68A File Offset: 0x00F9988A
		private void OnReChallengeBtnClick()
		{
			MotorFightController.Instance.ReChallengeMotorFightDungeon();
		}

		// Token: 0x060407CA RID: 264138 RVA: 0x00F9B696 File Offset: 0x00F99896
		private void OnExitBtnClick()
		{
			MotorFightController.Instance.LeaveInstanceDungeon();
		}

		// Token: 0x04021860 RID: 137312
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<CommonItemSmallItemGrid, TItem> RewardLayout;

		// Token: 0x0200C66E RID: 50798
		private class EComponents
		{
			// Token: 0x0403BE85 RID: 245381
			public const int TextWaveNum = 0;

			// Token: 0x0403BE86 RID: 245382
			public const int TextWaveScore = 1;

			// Token: 0x0403BE87 RID: 245383
			public const int TextKillNum = 2;

			// Token: 0x0403BE88 RID: 245384
			public const int TextKillScore = 3;

			// Token: 0x0403BE89 RID: 245385
			public const int TextBuffGateNum = 4;

			// Token: 0x0403BE8A RID: 245386
			public const int TextBuffGateScore = 5;

			// Token: 0x0403BE8B RID: 245387
			public const int ArtTextTotalScore = 6;

			// Token: 0x0403BE8C RID: 245388
			public const int ItemNewRecordLabel = 7;

			// Token: 0x0403BE8D RID: 245389
			public const int LayoutReward = 8;

			// Token: 0x0403BE8E RID: 245390
			public const int ItemRewardPanel = 9;

			// Token: 0x0403BE8F RID: 245391
			public const int BtnExit = 10;

			// Token: 0x0403BE90 RID: 245392
			public const int BtnReChallenge = 11;
		}
	}
}
