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
	// Token: 0x02004BD2 RID: 19410
	[NullableContext(2)]
	[Nullable(0)]
	public class CiacconaGalEndingView : UiViewBase
	{
		// Token: 0x06030714 RID: 198420 RVA: 0x00D800A5 File Offset: 0x00D7E2A5
		[NullableContext(1)]
		public CiacconaGalEndingView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06030715 RID: 198421 RVA: 0x00D800B0 File Offset: 0x00D7E2B0
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

		// Token: 0x06030716 RID: 198422 RVA: 0x00D8017C File Offset: 0x00D7E37C
		protected override UniTask OnBeforeStartAsync()
		{
			CiacconaGalEndingView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CiacconaGalEndingView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06030717 RID: 198423 RVA: 0x00D801BF File Offset: 0x00D7E3BF
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<RewardPopupData>(EEventName.RefreshRewardPopUp, new Action<RewardPopupData>(this.OnRefreshRewardPopUp));
		}

		// Token: 0x06030718 RID: 198424 RVA: 0x00D801DD File Offset: 0x00D7E3DD
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RefreshRewardPopUp, new Action<RewardPopupData>(this.OnRefreshRewardPopUp));
		}

		// Token: 0x06030719 RID: 198425 RVA: 0x00D801FB File Offset: 0x00D7E3FB
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

		// Token: 0x04019A8A RID: 105098
		private CiacconaGalEndingItem EndingItem1;

		// Token: 0x04019A8B RID: 105099
		private CiacconaGalEndingItem EndingItem2;

		// Token: 0x04019A8C RID: 105100
		private CiacconaGalEndingItem EndingItem3;

		// Token: 0x04019A8D RID: 105101
		private PopupCaptionItem Caption;

		// Token: 0x04019A8E RID: 105102
		private CommonRewardPopup RewardPreviewPopup;

		// Token: 0x0200A7E0 RID: 42976
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04033DA8 RID: 212392
			public const int ItemCaption = 0;

			// Token: 0x04033DA9 RID: 212393
			public const int ItemEnding1 = 1;

			// Token: 0x04033DAA RID: 212394
			public const int ItemEnding2 = 2;

			// Token: 0x04033DAB RID: 212395
			public const int ItemEnding3 = 3;

			// Token: 0x04033DAC RID: 212396
			public const int TextTitle = 4;
		}
	}
}
