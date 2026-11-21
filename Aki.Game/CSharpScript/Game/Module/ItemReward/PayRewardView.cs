using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020047CF RID: 18383
	public class PayRewardView : UiViewBase, ICommonRewardComponentUiAccessor, ICommonRewardComponentChildType, ICommonRewardComponentCallbacks
	{
		// Token: 0x0602E31F RID: 189215 RVA: 0x00CE2800 File Offset: 0x00CE0A00
		[NullableContext(2)]
		public UUIItem GetItemForComponent(int childType)
		{
			return base.GetItem(childType);
		}

		// Token: 0x0602E320 RID: 189216 RVA: 0x00CE2809 File Offset: 0x00CE0A09
		[NullableContext(2)]
		public UUIText GetTextForComponent(int childType)
		{
			return base.GetText(childType);
		}

		// Token: 0x0602E321 RID: 189217 RVA: 0x00CE2812 File Offset: 0x00CE0A12
		[NullableContext(2)]
		public UUIGridLayout GetGridLayoutForComponent(int childType)
		{
			return base.GetGridLayout(childType);
		}

		// Token: 0x0602E322 RID: 189218 RVA: 0x00CE281B File Offset: 0x00CE0A1B
		[NullableContext(2)]
		public UUIButtonComponent GetButtonForComponent(int childType)
		{
			return base.GetButton(childType);
		}

		// Token: 0x17005DE8 RID: 24040
		// (get) Token: 0x0602E323 RID: 189219 RVA: 0x00CE2824 File Offset: 0x00CE0A24
		public int TitleText
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x17005DE9 RID: 24041
		// (get) Token: 0x0602E324 RID: 189220 RVA: 0x00CE2827 File Offset: 0x00CE0A27
		public int TitlePanelItem
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x17005DEA RID: 24042
		// (get) Token: 0x0602E325 RID: 189221 RVA: 0x00CE282A File Offset: 0x00CE0A2A
		public int RewardItemListItem
		{
			get
			{
				return 3;
			}
		}

		// Token: 0x17005DEB RID: 24043
		// (get) Token: 0x0602E326 RID: 189222 RVA: 0x00CE282D File Offset: 0x00CE0A2D
		public int ContinueText
		{
			get
			{
				return 4;
			}
		}

		// Token: 0x17005DEC RID: 24044
		// (get) Token: 0x0602E327 RID: 189223 RVA: 0x00CE2830 File Offset: 0x00CE0A30
		public int LeftButton
		{
			get
			{
				return 5;
			}
		}

		// Token: 0x17005DED RID: 24045
		// (get) Token: 0x0602E328 RID: 189224 RVA: 0x00CE2833 File Offset: 0x00CE0A33
		public int RightButton
		{
			get
			{
				return 6;
			}
		}

		// Token: 0x17005DEE RID: 24046
		// (get) Token: 0x0602E329 RID: 189225 RVA: 0x00CE2836 File Offset: 0x00CE0A36
		public int RewardItemLoopListItem
		{
			get
			{
				return 7;
			}
		}

		// Token: 0x17005DEF RID: 24047
		// (get) Token: 0x0602E32A RID: 189226 RVA: 0x00CE2839 File Offset: 0x00CE0A39
		public int ListContentItem
		{
			get
			{
				return 8;
			}
		}

		// Token: 0x17005DF0 RID: 24048
		// (get) Token: 0x0602E32B RID: 189227 RVA: 0x00CE283C File Offset: 0x00CE0A3C
		public int MaskButton
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x0602E32C RID: 189228 RVA: 0x00CE283F File Offset: 0x00CE0A3F
		void ICommonRewardComponentCallbacks.OnCloseView()
		{
			this.OnCloseView();
		}

		// Token: 0x0602E32D RID: 189229 RVA: 0x00CE2847 File Offset: 0x00CE0A47
		void ICommonRewardComponentCallbacks.OnRefreshView()
		{
			this.OnRefreshView();
		}

		// Token: 0x0602E32E RID: 189230 RVA: 0x00CE284F File Offset: 0x00CE0A4F
		[NullableContext(1)]
		public PayRewardView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602E32F RID: 189231 RVA: 0x00CE2858 File Offset: 0x00CE0A58
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
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
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIGridLayout));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickedMaskButton));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602E330 RID: 189232 RVA: 0x00CE29E6 File Offset: 0x00CE0BE6
		protected override void OnAddEventListener()
		{
			CommonRewardComponent commonRewardComponent = this.CommonRewardComponent;
			if (commonRewardComponent == null)
			{
				return;
			}
			commonRewardComponent.AddEventListener();
		}

		// Token: 0x0602E331 RID: 189233 RVA: 0x00CE29F8 File Offset: 0x00CE0BF8
		protected override void OnRemoveEventListener()
		{
			CommonRewardComponent commonRewardComponent = this.CommonRewardComponent;
			if (commonRewardComponent == null)
			{
				return;
			}
			commonRewardComponent.RemoveEventListener();
		}

		// Token: 0x0602E332 RID: 189234 RVA: 0x00CE2A0C File Offset: 0x00CE0C0C
		protected override UniTask OnCreateAsync()
		{
			PayRewardView.<OnCreateAsync>d__30 <OnCreateAsync>d__;
			<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnCreateAsync>d__.<>4__this = this;
			<OnCreateAsync>d__.<>1__state = -1;
			<OnCreateAsync>d__.<>t__builder.Start<PayRewardView.<OnCreateAsync>d__30>(ref <OnCreateAsync>d__);
			return <OnCreateAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E333 RID: 189235 RVA: 0x00CE2A50 File Offset: 0x00CE0C50
		protected override UniTask OnBeforeStartAsync()
		{
			PayRewardView.<OnBeforeStartAsync>d__31 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PayRewardView.<OnBeforeStartAsync>d__31>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E334 RID: 189236 RVA: 0x00CE2A94 File Offset: 0x00CE0C94
		protected override void OnStart()
		{
			RewardData<ICommonRewardInfo> rewardData = this.PickLastRewardData();
			if (rewardData == null)
			{
				return;
			}
			this.RefreshDisplay(rewardData);
		}

		// Token: 0x0602E335 RID: 189237 RVA: 0x00CE2AB4 File Offset: 0x00CE0CB4
		[NullableContext(1)]
		private void RefreshDisplay(RewardData<ICommonRewardInfo> rewardData)
		{
			CommonRewardComponent commonRewardComponent = this.CommonRewardComponent;
			if (commonRewardComponent != null)
			{
				commonRewardComponent.OnRefreshRewardView(rewardData);
			}
			string audioId = rewardData.GetRewardInfo().AudioId;
			ItemRewardController.Instance.PlayAudio(audioId, null);
		}

		// Token: 0x0602E336 RID: 189238 RVA: 0x00CE2AEC File Offset: 0x00CE0CEC
		protected override void OnAfterPlayStartSequence()
		{
			this.UiViewSequence.PlaySequence("Switch", false, null);
		}

		// Token: 0x0602E337 RID: 189239 RVA: 0x00CE2B13 File Offset: 0x00CE0D13
		protected override void OnAfterShow()
		{
			EventSystem.Instance.Emit(EEventName.OnShowRewardView);
		}

		// Token: 0x0602E338 RID: 189240 RVA: 0x00CE2B25 File Offset: 0x00CE0D25
		protected override void OnBeforePlayCloseSequence()
		{
			this.UiViewSequence.StopSequenceByKey("Switch", false, false);
		}

		// Token: 0x0602E339 RID: 189241 RVA: 0x00CE2B3C File Offset: 0x00CE0D3C
		protected override void OnBeforeDestroy()
		{
			CommonRewardComponent commonRewardComponent = this.CommonRewardComponent;
			if (commonRewardComponent != null)
			{
				commonRewardComponent.HandleCloseCallback();
			}
			CommonRewardComponent commonRewardComponent2 = this.CommonRewardComponent;
			if (commonRewardComponent2 != null)
			{
				commonRewardComponent2.Destroy();
			}
			this.CommonRewardComponent = null;
			EventSystem.Instance.Emit(EEventName.OnCloseRewardView);
			ItemRewardModel.Instance.ClearCurrentRewardData();
		}

		// Token: 0x0602E33A RID: 189242 RVA: 0x00CE2B8C File Offset: 0x00CE0D8C
		private void OnCloseView()
		{
			RewardData<ICommonRewardInfo> rewardData = this.PickLastRewardData();
			if (rewardData == null)
			{
				UiInteractLogReport.ReportSpaceKeyInteract(EUiInteractSpaceKeyType.Reward);
				base.CloseMe(null);
				return;
			}
			this.RefreshDisplay(rewardData);
		}

		// Token: 0x0602E33B RID: 189243 RVA: 0x00CE2BB9 File Offset: 0x00CE0DB9
		private void OnRefreshView()
		{
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence == null)
			{
				return;
			}
			uiViewSequence.PlaySequencePurely("Start01", true, false);
		}

		// Token: 0x0602E33C RID: 189244 RVA: 0x00CE2BD2 File Offset: 0x00CE0DD2
		private void OnClickedMaskButton()
		{
			CommonRewardComponent commonRewardComponent = this.CommonRewardComponent;
			if (commonRewardComponent == null)
			{
				return;
			}
			commonRewardComponent.OnClickMaskButton();
		}

		// Token: 0x0602E33D RID: 189245 RVA: 0x00CE2BE4 File Offset: 0x00CE0DE4
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private RewardData<ICommonRewardInfo> PickLastRewardData()
		{
			List<RewardData<ICommonRewardInfo>> cacheCommonRewardDataList = ItemRewardModel.Instance.CacheCommonRewardDataList;
			if (cacheCommonRewardDataList.Count > 0)
			{
				RewardData<ICommonRewardInfo> rewardData = cacheCommonRewardDataList[0];
				cacheCommonRewardDataList.RemoveAt(0);
				if (rewardData != null)
				{
					return rewardData;
				}
			}
			return null;
		}

		// Token: 0x040189C4 RID: 100804
		[Nullable(2)]
		private CommonRewardComponent CommonRewardComponent;

		// Token: 0x0200A3FE RID: 41982
		private class EChildType
		{
			// Token: 0x04032D36 RID: 208182
			public const int MaskButton = 0;

			// Token: 0x04032D37 RID: 208183
			public const int TitleText = 1;

			// Token: 0x04032D38 RID: 208184
			public const int TitlePanelItem = 2;

			// Token: 0x04032D39 RID: 208185
			public const int RewardItemListItem = 3;

			// Token: 0x04032D3A RID: 208186
			public const int ContinueText = 4;

			// Token: 0x04032D3B RID: 208187
			public const int LeftButton = 5;

			// Token: 0x04032D3C RID: 208188
			public const int RightButton = 6;

			// Token: 0x04032D3D RID: 208189
			public const int RewardItemLoopListItem = 7;

			// Token: 0x04032D3E RID: 208190
			public const int ListContentItem = 8;
		}
	}
}
