using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.DreamLink
{
	// Token: 0x02004A92 RID: 19090
	[NullableContext(2)]
	[Nullable(0)]
	public class DreamLinkWhiteCatView : UiTickViewBase
	{
		// Token: 0x0602FC5A RID: 195674 RVA: 0x00D53B76 File Offset: 0x00D51D76
		[NullableContext(1)]
		public DreamLinkWhiteCatView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0602FC5B RID: 195675 RVA: 0x00D53B80 File Offset: 0x00D51D80
		protected unsafe override void OnRegisterComponent()
		{
			int num = 13;
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
			*span[num2] = new ValueTuple<int, Type>(3, typeof(USpineSkeletonAnimationComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(USpineSkeletonAnimationComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUILoopScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602FC5C RID: 195676 RVA: 0x00D53D5C File Offset: 0x00D51F5C
		protected override UniTask OnBeforeStartAsync()
		{
			DreamLinkWhiteCatView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DreamLinkWhiteCatView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602FC5D RID: 195677 RVA: 0x00D53DA0 File Offset: 0x00D51FA0
		protected override void OnStart()
		{
			bool flag = PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Female;
			EDreamLinkSpineDefine edreamLinkSpineDefine = flag ? EDreamLinkSpineDefine.MainFemale : EDreamLinkSpineDefine.MainMale;
			base.GetSpine(4).SetAnimation(0, edreamLinkSpineDefine.ToString(), true);
			base.GetItem(5).SetUIActive(!flag);
			base.GetItem(6).SetUIActive(flag);
		}

		// Token: 0x0602FC5E RID: 195678 RVA: 0x00D53E04 File Offset: 0x00D52004
		protected override void OnBeforeShow()
		{
			this.RefreshRedDot();
		}

		// Token: 0x0602FC5F RID: 195679 RVA: 0x00D53E0C File Offset: 0x00D5200C
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<string>(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
			EventSystem.Instance.Add(EEventName.ActivityCrossDayRefresh, new Action(this.OnActivityCrossDayRefresh));
			EventSystem.Instance.Add(EEventName.DreamLinkRewardRefresh, new Action(this.RefreshRedDot));
		}

		// Token: 0x0602FC60 RID: 195680 RVA: 0x00D53E70 File Offset: 0x00D52070
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
			EventSystem.Instance.Remove(EEventName.ActivityCrossDayRefresh, new Action(this.OnActivityCrossDayRefresh));
			EventSystem.Instance.Remove(EEventName.DreamLinkRewardRefresh, new Action(this.RefreshRedDot));
		}

		// Token: 0x0602FC61 RID: 195681 RVA: 0x00D53ED1 File Offset: 0x00D520D1
		protected override void OnTick(float delta)
		{
			if (!this.NeedTickState)
			{
				return;
			}
			this.RefreshFunctionCondition();
		}

		// Token: 0x0602FC62 RID: 195682 RVA: 0x00D53EE4 File Offset: 0x00D520E4
		[NullableContext(1)]
		private void OnActivitySequenceEmitEvent(string param)
		{
			if (param == "Start")
			{
				base.GetSpine(3).SetAnimation(0, EDreamLinkSpineDefine.Start.ToString(), false);
				return;
			}
			if (param == "idle")
			{
				base.GetSpine(3).SetAnimation(0, EDreamLinkSpineDefine.Idle.ToString(), true);
			}
		}

		// Token: 0x0602FC63 RID: 195683 RVA: 0x00D53F4A File Offset: 0x00D5214A
		private void OnActivityCrossDayRefresh()
		{
			if (this.SelectOnData != null)
			{
				this.LoopScrollView.RefreshAllGridProxies();
				this.RefreshFunctionArea(this.SelectOnData);
			}
		}

		// Token: 0x0602FC64 RID: 195684 RVA: 0x00D53F6B File Offset: 0x00D5216B
		private void RefreshRedDot()
		{
			this.ButtonItem.SetRedDotVisible(this.ActivityBaseData.CheckHasBossReward());
		}

		// Token: 0x0602FC65 RID: 195685 RVA: 0x00D53F83 File Offset: 0x00D52183
		[NullableContext(1)]
		private DreamLinkBossInstanceItem OnCreateInstanceItem()
		{
			return new DreamLinkBossInstanceItem
			{
				ToggleFunction = new Action<DreamLinkBossInstanceData, int>(this.InstItemSelectOnFunction)
			};
		}

		// Token: 0x0602FC66 RID: 195686 RVA: 0x00D53F9C File Offset: 0x00D5219C
		[NullableContext(1)]
		private void InstItemSelectOnFunction(DreamLinkBossInstanceData data, int index)
		{
			this.SelectOnData = data;
			this.RefreshFunctionArea(data);
			if (this.SelectOnIndex == index)
			{
				return;
			}
			this.LoopScrollView.DeselectCurrentGridProxy(true);
			this.SelectOnIndex = index;
			this.LoopScrollView.SelectGridProxy(this.SelectOnIndex, false);
		}

		// Token: 0x0602FC67 RID: 195687 RVA: 0x00D53FDC File Offset: 0x00D521DC
		[NullableContext(1)]
		private void RefreshFunctionArea(DreamLinkBossInstanceData data)
		{
			this.SelectOnData = data;
			this.NeedTickState = data.GetTickState();
			this.SelectRolePanel.SetActive(data.IsUnlock);
			this.ActivityBaseData.FixBossRoleId(data.InstId);
			this.SelectRolePanel.RefreshInstId(data.InstId);
			this.FunctionalComponent.FunctionButton.SetActive(data.IsUnlock);
			this.FunctionalComponent.SetPanelConditionVisible(!data.IsUnlock);
			this.RefreshFunctionCondition();
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(data.InstId);
			if (config == null)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(10), config.Value.MapName, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(11), config.Value.DungeonDesc, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(12), config.Value.MonsterTips, Array.Empty<object>());
		}

		// Token: 0x0602FC68 RID: 195688 RVA: 0x00D540EC File Offset: 0x00D522EC
		private void RefreshFunctionCondition()
		{
			if (this.SelectOnData != null)
			{
				this.FunctionalComponent.SetLockTextByText(this.SelectOnData.GetUnlockText());
			}
		}

		// Token: 0x0602FC69 RID: 195689 RVA: 0x00D5410C File Offset: 0x00D5230C
		private UniTask RefreshLayout()
		{
			DreamLinkWhiteCatView.<RefreshLayout>d__25 <RefreshLayout>d__;
			<RefreshLayout>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshLayout>d__.<>4__this = this;
			<RefreshLayout>d__.<>1__state = -1;
			<RefreshLayout>d__.<>t__builder.Start<DreamLinkWhiteCatView.<RefreshLayout>d__25>(ref <RefreshLayout>d__);
			return <RefreshLayout>d__.<>t__builder.Task;
		}

		// Token: 0x0602FC6A RID: 195690 RVA: 0x00D54150 File Offset: 0x00D52350
		private void OnBtnConfirmClick()
		{
			int[] bossRoleIdList = this.SelectOnData.GetBossRoleIdList();
			int[] array = bossRoleIdList;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == 0)
				{
					ScrollingTipsController.Instance.ShowTipsByTextId("DaMaoTips_NotEnough", Array.Empty<object>());
					return;
				}
			}
			int instId = this.SelectOnData.InstId;
			RogueWhiteCatCtx rogueWhiteCatCtx = new RogueWhiteCatCtx();
			rogueWhiteCatCtx.ActivityId = this.ActivityBaseData.Id;
			rogueWhiteCatCtx.IsFirst = false;
			rogueWhiteCatCtx.Idnex = this.SelectOnData.TypeId;
			InstanceDungeonModel.Instance.InstanceEnterContentText.RogueWhiteCatCtx = rogueWhiteCatCtx;
			InstanceDungeonController.Instance.PrewarTeamFightRequest(instId, new List<int>(bossRoleIdList), 0, 0, null, null);
		}

		// Token: 0x0602FC6B RID: 195691 RVA: 0x00D541F9 File Offset: 0x00D523F9
		private void OpenBossReward(int _)
		{
			this.ActivityBaseData.SaveFirstCheckRedDotState(7, 0);
			UiManager.Instance.OpenView(EUiViewName.ActivityRewardPopUpView, this.ActivityBaseData.GetBossRewardData(), null);
			this.RefreshRedDot();
		}

		// Token: 0x040195BE RID: 103870
		protected DreamLinkData ActivityBaseData;

		// Token: 0x040195BF RID: 103871
		private PopupCaptionItem CaptionComponent;

		// Token: 0x040195C0 RID: 103872
		private DreamLinkRoleSelectPanel SelectRolePanel;

		// Token: 0x040195C1 RID: 103873
		private ButtonItem ButtonItem;

		// Token: 0x040195C2 RID: 103874
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<DreamLinkBossInstanceItem, DreamLinkBossInstanceData> LoopScrollView;

		// Token: 0x040195C3 RID: 103875
		private ActivityFunctionalTypeA FunctionalComponent;

		// Token: 0x040195C4 RID: 103876
		private DreamLinkBossInstanceData SelectOnData;

		// Token: 0x040195C5 RID: 103877
		private bool NeedTickState;

		// Token: 0x040195C6 RID: 103878
		private int SelectOnIndex;

		// Token: 0x0200A70E RID: 42766
		[NullableContext(0)]
		private class EDreamLinkWhiteCatViewDefine
		{
			// Token: 0x040339D5 RID: 211413
			public const int CaptionItem = 0;

			// Token: 0x040339D6 RID: 211414
			public const int SelectRolePanel = 1;

			// Token: 0x040339D7 RID: 211415
			public const int FunctionArea = 2;

			// Token: 0x040339D8 RID: 211416
			public const int SpineCat = 3;

			// Token: 0x040339D9 RID: 211417
			public const int SpineCharacter = 4;

			// Token: 0x040339DA RID: 211418
			public const int CharacterMaleItem = 5;

			// Token: 0x040339DB RID: 211419
			public const int CharacterFemaleItem = 6;

			// Token: 0x040339DC RID: 211420
			public const int PanelLayout = 7;

			// Token: 0x040339DD RID: 211421
			public const int InstanceItem = 8;

			// Token: 0x040339DE RID: 211422
			public const int ButtonReward = 9;

			// Token: 0x040339DF RID: 211423
			public const int InstTitle = 10;

			// Token: 0x040339E0 RID: 211424
			public const int InstDescription = 11;

			// Token: 0x040339E1 RID: 211425
			public const int InstAttribute = 12;
		}
	}
}
