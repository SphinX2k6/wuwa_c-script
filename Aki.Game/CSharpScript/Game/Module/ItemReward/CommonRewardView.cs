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
	// Token: 0x020047CC RID: 18380
	public class CommonRewardView : UiViewBase, ICommonRewardComponentUiAccessor, ICommonRewardComponentChildType, ICommonRewardComponentCallbacks
	{
		// Token: 0x0602E2C3 RID: 189123 RVA: 0x00CE0FC8 File Offset: 0x00CDF1C8
		[NullableContext(2)]
		public UUIItem GetItemForComponent(int childType)
		{
			return base.GetItem(childType);
		}

		// Token: 0x0602E2C4 RID: 189124 RVA: 0x00CE0FD1 File Offset: 0x00CDF1D1
		[NullableContext(2)]
		public UUIText GetTextForComponent(int childType)
		{
			return base.GetText(childType);
		}

		// Token: 0x0602E2C5 RID: 189125 RVA: 0x00CE0FDA File Offset: 0x00CDF1DA
		[NullableContext(2)]
		public UUIGridLayout GetGridLayoutForComponent(int childType)
		{
			return base.GetGridLayout(childType);
		}

		// Token: 0x0602E2C6 RID: 189126 RVA: 0x00CE0FE3 File Offset: 0x00CDF1E3
		[NullableContext(2)]
		public UUIButtonComponent GetButtonForComponent(int childType)
		{
			return base.GetButton(childType);
		}

		// Token: 0x17005DDF RID: 24031
		// (get) Token: 0x0602E2C7 RID: 189127 RVA: 0x00CE0FEC File Offset: 0x00CDF1EC
		public int TitleText
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x17005DE0 RID: 24032
		// (get) Token: 0x0602E2C8 RID: 189128 RVA: 0x00CE0FEF File Offset: 0x00CDF1EF
		public int TitlePanelItem
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x17005DE1 RID: 24033
		// (get) Token: 0x0602E2C9 RID: 189129 RVA: 0x00CE0FF2 File Offset: 0x00CDF1F2
		public int RewardItemListItem
		{
			get
			{
				return 3;
			}
		}

		// Token: 0x17005DE2 RID: 24034
		// (get) Token: 0x0602E2CA RID: 189130 RVA: 0x00CE0FF5 File Offset: 0x00CDF1F5
		public int ContinueText
		{
			get
			{
				return 4;
			}
		}

		// Token: 0x17005DE3 RID: 24035
		// (get) Token: 0x0602E2CB RID: 189131 RVA: 0x00CE0FF8 File Offset: 0x00CDF1F8
		public int LeftButton
		{
			get
			{
				return 5;
			}
		}

		// Token: 0x17005DE4 RID: 24036
		// (get) Token: 0x0602E2CC RID: 189132 RVA: 0x00CE0FFB File Offset: 0x00CDF1FB
		public int RightButton
		{
			get
			{
				return 6;
			}
		}

		// Token: 0x17005DE5 RID: 24037
		// (get) Token: 0x0602E2CD RID: 189133 RVA: 0x00CE0FFE File Offset: 0x00CDF1FE
		public int RewardItemLoopListItem
		{
			get
			{
				return 7;
			}
		}

		// Token: 0x17005DE6 RID: 24038
		// (get) Token: 0x0602E2CE RID: 189134 RVA: 0x00CE1001 File Offset: 0x00CDF201
		public int ListContentItem
		{
			get
			{
				return 8;
			}
		}

		// Token: 0x17005DE7 RID: 24039
		// (get) Token: 0x0602E2CF RID: 189135 RVA: 0x00CE1004 File Offset: 0x00CDF204
		public int MaskButton
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x0602E2D0 RID: 189136 RVA: 0x00CE1007 File Offset: 0x00CDF207
		void ICommonRewardComponentCallbacks.OnCloseView()
		{
			this.OnCloseView();
		}

		// Token: 0x0602E2D1 RID: 189137 RVA: 0x00CE100F File Offset: 0x00CDF20F
		void ICommonRewardComponentCallbacks.OnRefreshView()
		{
			this.OnRefreshView();
		}

		// Token: 0x0602E2D2 RID: 189138 RVA: 0x00CE1017 File Offset: 0x00CDF217
		[NullableContext(1)]
		public CommonRewardView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0602E2D3 RID: 189139 RVA: 0x00CE1020 File Offset: 0x00CDF220
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

		// Token: 0x0602E2D4 RID: 189140 RVA: 0x00CE11AE File Offset: 0x00CDF3AE
		protected override void OnAddEventListener()
		{
			CommonRewardComponent commonRewardComponent = this.CommonRewardComponent;
			if (commonRewardComponent != null)
			{
				commonRewardComponent.AddEventListener();
			}
			EventSystem.Instance.Add<IRewardDataInterface>(EEventName.OnRefreshRewardView, new Action<IRewardDataInterface>(this.OnRefreshRewardView));
		}

		// Token: 0x0602E2D5 RID: 189141 RVA: 0x00CE11DD File Offset: 0x00CDF3DD
		protected override void OnRemoveEventListener()
		{
			CommonRewardComponent commonRewardComponent = this.CommonRewardComponent;
			if (commonRewardComponent != null)
			{
				commonRewardComponent.RemoveEventListener();
			}
			EventSystem.Instance.Remove(EEventName.OnRefreshRewardView, new Action<IRewardDataInterface>(this.OnRefreshRewardView));
		}

		// Token: 0x0602E2D6 RID: 189142 RVA: 0x00CE120C File Offset: 0x00CDF40C
		[NullableContext(1)]
		private void OnRefreshRewardView(IRewardDataInterface rewardData)
		{
			CommonRewardComponent commonRewardComponent = this.CommonRewardComponent;
			if (commonRewardComponent == null)
			{
				return;
			}
			commonRewardComponent.OnRefreshRewardView(rewardData);
		}

		// Token: 0x0602E2D7 RID: 189143 RVA: 0x00CE1220 File Offset: 0x00CDF420
		protected override UniTask OnCreateAsync()
		{
			CommonRewardView.<OnCreateAsync>d__31 <OnCreateAsync>d__;
			<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnCreateAsync>d__.<>4__this = this;
			<OnCreateAsync>d__.<>1__state = -1;
			<OnCreateAsync>d__.<>t__builder.Start<CommonRewardView.<OnCreateAsync>d__31>(ref <OnCreateAsync>d__);
			return <OnCreateAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E2D8 RID: 189144 RVA: 0x00CE1264 File Offset: 0x00CDF464
		protected override UniTask OnBeforeStartAsync()
		{
			CommonRewardView.<OnBeforeStartAsync>d__32 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CommonRewardView.<OnBeforeStartAsync>d__32>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E2D9 RID: 189145 RVA: 0x00CE12A8 File Offset: 0x00CDF4A8
		protected override void OnStart()
		{
			RewardData<ICommonRewardInfo> rewardData = this.OpenParam as RewardData<ICommonRewardInfo>;
			CommonRewardComponent commonRewardComponent = this.CommonRewardComponent;
			if (commonRewardComponent != null)
			{
				commonRewardComponent.Refresh(rewardData);
			}
			string audioId = rewardData.GetRewardInfo().AudioId;
			ItemRewardController.Instance.PlayAudio(audioId, null);
		}

		// Token: 0x0602E2DA RID: 189146 RVA: 0x00CE12EC File Offset: 0x00CDF4EC
		protected override void OnAfterPlayStartSequence()
		{
			this.UiViewSequence.PlaySequence("Switch", false, null);
		}

		// Token: 0x0602E2DB RID: 189147 RVA: 0x00CE1313 File Offset: 0x00CDF513
		protected override void OnAfterShow()
		{
			EventSystem.Instance.Emit(EEventName.OnShowRewardView);
		}

		// Token: 0x0602E2DC RID: 189148 RVA: 0x00CE1325 File Offset: 0x00CDF525
		protected override void OnBeforePlayCloseSequence()
		{
			this.UiViewSequence.StopSequenceByKey("Switch", false, false);
		}

		// Token: 0x0602E2DD RID: 189149 RVA: 0x00CE133C File Offset: 0x00CDF53C
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

		// Token: 0x0602E2DE RID: 189150 RVA: 0x00CE138C File Offset: 0x00CDF58C
		private void OnCloseView()
		{
			UiInteractLogReport.ReportSpaceKeyInteract(EUiInteractSpaceKeyType.Reward);
			base.CloseMe(null);
		}

		// Token: 0x0602E2DF RID: 189151 RVA: 0x00CE139C File Offset: 0x00CDF59C
		private void OnRefreshView()
		{
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence == null)
			{
				return;
			}
			uiViewSequence.PlaySequencePurely("Start01", true, false);
		}

		// Token: 0x0602E2E0 RID: 189152 RVA: 0x00CE13B5 File Offset: 0x00CDF5B5
		private void OnClickedMaskButton()
		{
			CommonRewardComponent commonRewardComponent = this.CommonRewardComponent;
			if (commonRewardComponent == null)
			{
				return;
			}
			commonRewardComponent.OnClickMaskButton();
		}

		// Token: 0x040189AA RID: 100778
		[Nullable(2)]
		private CommonRewardComponent CommonRewardComponent;

		// Token: 0x0200A3E5 RID: 41957
		private class EChildType
		{
			// Token: 0x04032CB6 RID: 208054
			public const int MaskButton = 0;

			// Token: 0x04032CB7 RID: 208055
			public const int TitleText = 1;

			// Token: 0x04032CB8 RID: 208056
			public const int TitlePanelItem = 2;

			// Token: 0x04032CB9 RID: 208057
			public const int RewardItemListItem = 3;

			// Token: 0x04032CBA RID: 208058
			public const int ContinueText = 4;

			// Token: 0x04032CBB RID: 208059
			public const int LeftButton = 5;

			// Token: 0x04032CBC RID: 208060
			public const int RightButton = 6;

			// Token: 0x04032CBD RID: 208061
			public const int RewardItemLoopListItem = 7;

			// Token: 0x04032CBE RID: 208062
			public const int ListContentItem = 8;
		}
	}
}
