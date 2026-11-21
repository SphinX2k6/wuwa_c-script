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
	// Token: 0x020053AD RID: 21421
	public class MotorFightSuccessView : UiViewBase
	{
		// Token: 0x06035486 RID: 218246 RVA: 0x00EE23BA File Offset: 0x00EE05BA
		[NullableContext(1)]
		public MotorFightSuccessView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06035487 RID: 218247 RVA: 0x00EE23C4 File Offset: 0x00EE05C4
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

		// Token: 0x06035488 RID: 218248 RVA: 0x00EE25E0 File Offset: 0x00EE07E0
		protected override UniTask OnBeforeStartAsync()
		{
			MotorFightSuccessView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MotorFightSuccessView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035489 RID: 218249 RVA: 0x00EE2623 File Offset: 0x00EE0823
		[NullableContext(1)]
		private CommonItemSmallItemGrid InitGridItem()
		{
			return new CommonItemSmallItemGrid();
		}

		// Token: 0x0603548A RID: 218250 RVA: 0x00EE262A File Offset: 0x00EE082A
		private void OnReChallengeBtnClick()
		{
			MotorFightController.Instance.ReChallengeMotorFightDungeon();
		}

		// Token: 0x0603548B RID: 218251 RVA: 0x00EE2636 File Offset: 0x00EE0836
		private void OnExitBtnClick()
		{
			MotorFightController.Instance.LeaveInstanceDungeon();
		}

		// Token: 0x0401C18F RID: 115087
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<CommonItemSmallItemGrid, TItem> RewardLayout;

		// Token: 0x0200B055 RID: 45141
		private class EComponents
		{
			// Token: 0x040367E2 RID: 223202
			public const int TextWaveNum = 0;

			// Token: 0x040367E3 RID: 223203
			public const int TextWaveScore = 1;

			// Token: 0x040367E4 RID: 223204
			public const int TextKillNum = 2;

			// Token: 0x040367E5 RID: 223205
			public const int TextKillScore = 3;

			// Token: 0x040367E6 RID: 223206
			public const int TextBuffGateNum = 4;

			// Token: 0x040367E7 RID: 223207
			public const int TextBuffGateScore = 5;

			// Token: 0x040367E8 RID: 223208
			public const int ArtTextTotalScore = 6;

			// Token: 0x040367E9 RID: 223209
			public const int ItemNewRecordLabel = 7;

			// Token: 0x040367EA RID: 223210
			public const int LayoutReward = 8;

			// Token: 0x040367EB RID: 223211
			public const int ItemRewardPanel = 9;

			// Token: 0x040367EC RID: 223212
			public const int BtnExit = 10;

			// Token: 0x040367ED RID: 223213
			public const int BtnReChallenge = 11;
		}
	}
}
