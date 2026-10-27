using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02005BF2 RID: 23538
	[NullableContext(2)]
	[Nullable(0)]
	public class CiacconaGalEndingView : UiViewBase
	{
		// Token: 0x0603B7C9 RID: 243657 RVA: 0x00E2FD95 File Offset: 0x00E2DF95
		[NullableContext(1)]
		public CiacconaGalEndingView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603B7CA RID: 243658 RVA: 0x00E2FDA0 File Offset: 0x00E2DFA0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
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
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603B7CB RID: 243659 RVA: 0x00E2FE6C File Offset: 0x00E2E06C
		protected override UniTask OnBeforeStartAsync()
		{
			CiacconaGalEndingView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CiacconaGalEndingView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603B7CC RID: 243660 RVA: 0x00E2FEAF File Offset: 0x00E2E0AF
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<RewardPopupData>(EEventName.RefreshRewardPopUp, new Action<RewardPopupData>(this.OnRefreshRewardPopUp));
		}

		// Token: 0x0603B7CD RID: 243661 RVA: 0x00E2FECD File Offset: 0x00E2E0CD
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RefreshRewardPopUp, new Action<RewardPopupData>(this.OnRefreshRewardPopUp));
		}

		// Token: 0x0603B7CE RID: 243662 RVA: 0x00E2FEEB File Offset: 0x00E2E0EB
		[NullableContext(1)]
		private void OnRefreshRewardPopUp(RewardPopupData data)
		{
			CommonRewardPopup rewardPreviewPopup = this.RewardPreviewPopup;
			if (rewardPreviewPopup != null)
			{
				rewardPreviewPopup.SetUiActive(true);
			}
			CommonRewardPopup rewardPreviewPopup2 = this.RewardPreviewPopup;
			if (rewardPreviewPopup2 == null)
			{
				return;
			}
			rewardPreviewPopup2.Refresh(data);
		}

		// Token: 0x0401EFD9 RID: 126937
		private CiacconaGalEndingItem EndingItem1;

		// Token: 0x0401EFDA RID: 126938
		private CiacconaGalEndingItem EndingItem2;

		// Token: 0x0401EFDB RID: 126939
		private CiacconaGalEndingItem EndingItem3;

		// Token: 0x0401EFDC RID: 126940
		private PopupCaptionItem Caption;

		// Token: 0x0401EFDD RID: 126941
		private CommonRewardPopup RewardPreviewPopup;

		// Token: 0x0200BDD8 RID: 48600
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x040393E5 RID: 234469
			public const int ItemCaption = 0;

			// Token: 0x040393E6 RID: 234470
			public const int ItemEnding1 = 1;

			// Token: 0x040393E7 RID: 234471
			public const int ItemEnding2 = 2;

			// Token: 0x040393E8 RID: 234472
			public const int ItemEnding3 = 3;

			// Token: 0x040393E9 RID: 234473
			public const int TextTitle = 4;
		}
	}
}
