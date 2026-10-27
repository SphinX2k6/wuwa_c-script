using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MoonSignIn
{
	// Token: 0x02006467 RID: 25703
	internal class MoonSignInIllustrated : UiPanelBase
	{
		// Token: 0x06040980 RID: 264576 RVA: 0x00FA29E0 File Offset: 0x00FA0BE0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 14;
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
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(12, new Action(this.OnClickSwitchToWishBtn));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(10, new Action(this.OnClickRewardBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06040981 RID: 264577 RVA: 0x00FA2C40 File Offset: 0x00FA0E40
		protected override UniTask OnBeforeStartAsync()
		{
			MoonSignInIllustrated.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MoonSignInIllustrated.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040982 RID: 264578 RVA: 0x00FA2C84 File Offset: 0x00FA0E84
		public void RefreshPhaseView()
		{
			for (int i = 1; i <= 10; i++)
			{
				MoonSignInPhase moonSignInPhase = this.PhaseItemMap[i];
				if (moonSignInPhase != null)
				{
					moonSignInPhase.RefreshItemLockState();
				}
			}
			MoonSignInData data = MoonSignInController.Instance.GetData();
			if (data == null)
			{
				return;
			}
			base.GetText(11).SetText(data.GetMoonPhaseProgress(), true);
			base.GetItem(13).SetUIActive(data.GetCanGetMoonGrandReward());
		}

		// Token: 0x06040983 RID: 264579 RVA: 0x00FA2CEB File Offset: 0x00FA0EEB
		private void OnClickSwitchToWishBtn()
		{
			Action onClickSwitchWishBtnCallBack = this.OnClickSwitchWishBtnCallBack;
			if (onClickSwitchWishBtnCallBack == null)
			{
				return;
			}
			onClickSwitchWishBtnCallBack();
		}

		// Token: 0x06040984 RID: 264580 RVA: 0x00FA2CFD File Offset: 0x00FA0EFD
		private void OnClickRewardBtn()
		{
			UiManager.Instance.OpenView(EUiViewName.MoonSignInRewardView, null, null);
		}

		// Token: 0x04021955 RID: 137557
		[Nullable(2)]
		public Action OnClickSwitchWishBtnCallBack;

		// Token: 0x04021956 RID: 137558
		[Nullable(1)]
		private readonly Dictionary<int, MoonSignInPhase> PhaseItemMap = new Dictionary<int, MoonSignInPhase>();

		// Token: 0x0200C692 RID: 50834
		private class EMoonSignInIllustratedDefine
		{
			// Token: 0x0403BF26 RID: 245542
			public const int MoonPhaseItem1 = 0;

			// Token: 0x0403BF27 RID: 245543
			public const int MoonPhaseItem2 = 1;

			// Token: 0x0403BF28 RID: 245544
			public const int MoonPhaseItem3 = 2;

			// Token: 0x0403BF29 RID: 245545
			public const int MoonPhaseItem4 = 3;

			// Token: 0x0403BF2A RID: 245546
			public const int MoonPhaseItem5 = 4;

			// Token: 0x0403BF2B RID: 245547
			public const int MoonPhaseItem6 = 5;

			// Token: 0x0403BF2C RID: 245548
			public const int MoonPhaseItem7 = 6;

			// Token: 0x0403BF2D RID: 245549
			public const int MoonPhaseItem8 = 7;

			// Token: 0x0403BF2E RID: 245550
			public const int MoonPhaseItem9 = 8;

			// Token: 0x0403BF2F RID: 245551
			public const int MoonPhaseItem10 = 9;

			// Token: 0x0403BF30 RID: 245552
			public const int RewardBtn = 10;

			// Token: 0x0403BF31 RID: 245553
			public const int ProgressText = 11;

			// Token: 0x0403BF32 RID: 245554
			public const int SwitchToWishBtn = 12;

			// Token: 0x0403BF33 RID: 245555
			public const int RewardBtnRedDotItem = 13;
		}
	}
}
