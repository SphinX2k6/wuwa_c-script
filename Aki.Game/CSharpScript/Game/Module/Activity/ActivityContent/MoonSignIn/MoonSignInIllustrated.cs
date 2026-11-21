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
	// Token: 0x020053E5 RID: 21477
	internal class MoonSignInIllustrated : UiPanelBase
	{
		// Token: 0x06035641 RID: 218689 RVA: 0x00EE995C File Offset: 0x00EE7B5C
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

		// Token: 0x06035642 RID: 218690 RVA: 0x00EE9BBC File Offset: 0x00EE7DBC
		protected override UniTask OnBeforeStartAsync()
		{
			MoonSignInIllustrated.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MoonSignInIllustrated.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035643 RID: 218691 RVA: 0x00EE9C00 File Offset: 0x00EE7E00
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

		// Token: 0x06035644 RID: 218692 RVA: 0x00EE9C67 File Offset: 0x00EE7E67
		private void OnClickSwitchToWishBtn()
		{
			Action onClickSwitchWishBtnCallBack = this.OnClickSwitchWishBtnCallBack;
			if (onClickSwitchWishBtnCallBack == null)
			{
				return;
			}
			onClickSwitchWishBtnCallBack();
		}

		// Token: 0x06035645 RID: 218693 RVA: 0x00EE9C79 File Offset: 0x00EE7E79
		private void OnClickRewardBtn()
		{
			UiManager.Instance.OpenView(EUiViewName.MoonSignInRewardView, null, null);
		}

		// Token: 0x0401C284 RID: 115332
		[Nullable(2)]
		public Action OnClickSwitchWishBtnCallBack;

		// Token: 0x0401C285 RID: 115333
		[Nullable(1)]
		private readonly Dictionary<int, MoonSignInPhase> PhaseItemMap = new Dictionary<int, MoonSignInPhase>();

		// Token: 0x0200B078 RID: 45176
		private class EMoonSignInIllustratedDefine
		{
			// Token: 0x04036881 RID: 223361
			public const int MoonPhaseItem1 = 0;

			// Token: 0x04036882 RID: 223362
			public const int MoonPhaseItem2 = 1;

			// Token: 0x04036883 RID: 223363
			public const int MoonPhaseItem3 = 2;

			// Token: 0x04036884 RID: 223364
			public const int MoonPhaseItem4 = 3;

			// Token: 0x04036885 RID: 223365
			public const int MoonPhaseItem5 = 4;

			// Token: 0x04036886 RID: 223366
			public const int MoonPhaseItem6 = 5;

			// Token: 0x04036887 RID: 223367
			public const int MoonPhaseItem7 = 6;

			// Token: 0x04036888 RID: 223368
			public const int MoonPhaseItem8 = 7;

			// Token: 0x04036889 RID: 223369
			public const int MoonPhaseItem9 = 8;

			// Token: 0x0403688A RID: 223370
			public const int MoonPhaseItem10 = 9;

			// Token: 0x0403688B RID: 223371
			public const int RewardBtn = 10;

			// Token: 0x0403688C RID: 223372
			public const int ProgressText = 11;

			// Token: 0x0403688D RID: 223373
			public const int SwitchToWishBtn = 12;

			// Token: 0x0403688E RID: 223374
			public const int RewardBtnRedDotItem = 13;
		}
	}
}
