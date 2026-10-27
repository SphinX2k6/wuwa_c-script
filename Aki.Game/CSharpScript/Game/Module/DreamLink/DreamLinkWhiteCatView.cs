using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x02005AB6 RID: 23222
	[NullableContext(2)]
	[Nullable(0)]
	public class DreamLinkWhiteCatView : UiTickViewBase
	{
		// Token: 0x0603AD0E RID: 240910 RVA: 0x00E035AE File Offset: 0x00E017AE
		[NullableContext(1)]
		public DreamLinkWhiteCatView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603AD0F RID: 240911 RVA: 0x00E035B8 File Offset: 0x00E017B8
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

		// Token: 0x0603AD10 RID: 240912 RVA: 0x00E03794 File Offset: 0x00E01994
		protected override UniTask OnBeforeStartAsync()
		{
			DreamLinkWhiteCatView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DreamLinkWhiteCatView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603AD11 RID: 240913 RVA: 0x00E037D8 File Offset: 0x00E019D8
		protected override void OnStart()
		{
			bool flag = PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Female;
			EDreamLinkSpineDefine edreamLinkSpineDefine = flag ? EDreamLinkSpineDefine.MainFemale : EDreamLinkSpineDefine.MainMale;
			base.GetSpine(4).SetAnimation(0, edreamLinkSpineDefine.ToString(), true);
			base.GetItem(5).SetUIActive(!flag);
			base.GetItem(6).SetUIActive(flag);
		}

		// Token: 0x0603AD12 RID: 240914 RVA: 0x00E0383C File Offset: 0x00E01A3C
		protected override void OnBeforeShow()
		{
			this.RefreshRedDot();
		}

		// Token: 0x0603AD13 RID: 240915 RVA: 0x00E03844 File Offset: 0x00E01A44
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<string>(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
			EventSystem.Instance.Add(EEventName.ActivityCrossDayRefresh, new Action(this.OnActivityCrossDayRefresh));
			EventSystem.Instance.Add(EEventName.DreamLinkRewardRefresh, new Action(this.RefreshRedDot));
		}

		// Token: 0x0603AD14 RID: 240916 RVA: 0x00E038A8 File Offset: 0x00E01AA8
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
			EventSystem.Instance.Remove(EEventName.ActivityCrossDayRefresh, new Action(this.OnActivityCrossDayRefresh));
			EventSystem.Instance.Remove(EEventName.DreamLinkRewardRefresh, new Action(this.RefreshRedDot));
		}

		// Token: 0x0603AD15 RID: 240917 RVA: 0x00E03909 File Offset: 0x00E01B09
		protected override void OnTick(float delta)
		{
			if (!this.NeedTickState)
			{
				return;
			}
			this.RefreshFunctionCondition();
		}

		// Token: 0x0603AD16 RID: 240918 RVA: 0x00E0391C File Offset: 0x00E01B1C
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

		// Token: 0x0603AD17 RID: 240919 RVA: 0x00E03982 File Offset: 0x00E01B82
		private void OnActivityCrossDayRefresh()
		{
			if (this.SelectOnData != null)
			{
				this.LoopScrollView.RefreshAllGridProxies();
				this.RefreshFunctionArea(this.SelectOnData);
			}
		}

		// Token: 0x0603AD18 RID: 240920 RVA: 0x00E039A3 File Offset: 0x00E01BA3
		private void RefreshRedDot()
		{
			this.ButtonItem.SetRedDotVisible(this.ActivityBaseData.CheckHasBossReward());
		}

		// Token: 0x0603AD19 RID: 240921 RVA: 0x00E039BB File Offset: 0x00E01BBB
		[NullableContext(1)]
		private DreamLinkBossInstanceItem OnCreateInstanceItem()
		{
			return new DreamLinkBossInstanceItem
			{
				ToggleFunction = new Action<DreamLinkBossInstanceData, int>(this.InstItemSelectOnFunction)
			};
		}

		// Token: 0x0603AD1A RID: 240922 RVA: 0x00E039D4 File Offset: 0x00E01BD4
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

		// Token: 0x0603AD1B RID: 240923 RVA: 0x00E03A14 File Offset: 0x00E01C14
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

		// Token: 0x0603AD1C RID: 240924 RVA: 0x00E03B24 File Offset: 0x00E01D24
		private void RefreshFunctionCondition()
		{
			if (this.SelectOnData != null)
			{
				this.FunctionalComponent.SetLockTextByText(this.SelectOnData.GetUnlockText());
			}
		}

		// Token: 0x0603AD1D RID: 240925 RVA: 0x00E03B44 File Offset: 0x00E01D44
		private UniTask RefreshLayout()
		{
			DreamLinkWhiteCatView.<RefreshLayout>d__25 <RefreshLayout>d__;
			<RefreshLayout>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshLayout>d__.<>4__this = this;
			<RefreshLayout>d__.<>1__state = -1;
			<RefreshLayout>d__.<>t__builder.Start<DreamLinkWhiteCatView.<RefreshLayout>d__25>(ref <RefreshLayout>d__);
			return <RefreshLayout>d__.<>t__builder.Task;
		}

		// Token: 0x0603AD1E RID: 240926 RVA: 0x00E03B88 File Offset: 0x00E01D88
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
			InstanceDungeonController.Instance.PrewarTeamFightRequest(instId, bossRoleIdList.ToList<int>(), 0, 0, null, null);
		}

		// Token: 0x0603AD1F RID: 240927 RVA: 0x00E03C31 File Offset: 0x00E01E31
		private void OpenBossReward(int _)
		{
			this.ActivityBaseData.SaveFirstCheckRedDotState(7, 0);
			UiManager.Instance.OpenView(EUiViewName.ActivityRewardPopUpView, this.ActivityBaseData.GetBossRewardData(), null);
			this.RefreshRedDot();
		}

		// Token: 0x0401EB17 RID: 125719
		protected DreamLinkData ActivityBaseData;

		// Token: 0x0401EB18 RID: 125720
		private PopupCaptionItem CaptionComponent;

		// Token: 0x0401EB19 RID: 125721
		private DreamLinkRoleSelectPanel SelectRolePanel;

		// Token: 0x0401EB1A RID: 125722
		private ButtonItem ButtonItem;

		// Token: 0x0401EB1B RID: 125723
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<DreamLinkBossInstanceItem, DreamLinkBossInstanceData> LoopScrollView;

		// Token: 0x0401EB1C RID: 125724
		private ActivityFunctionalTypeA FunctionalComponent;

		// Token: 0x0401EB1D RID: 125725
		private DreamLinkBossInstanceData SelectOnData;

		// Token: 0x0401EB1E RID: 125726
		private bool NeedTickState;

		// Token: 0x0401EB1F RID: 125727
		private int SelectOnIndex;

		// Token: 0x0200BD06 RID: 48390
		[NullableContext(0)]
		private class EDreamLinkWhiteCatViewDefine
		{
			// Token: 0x0403900B RID: 233483
			public const int CaptionItem = 0;

			// Token: 0x0403900C RID: 233484
			public const int SelectRolePanel = 1;

			// Token: 0x0403900D RID: 233485
			public const int FunctionArea = 2;

			// Token: 0x0403900E RID: 233486
			public const int SpineCat = 3;

			// Token: 0x0403900F RID: 233487
			public const int SpineCharacter = 4;

			// Token: 0x04039010 RID: 233488
			public const int CharacterMaleItem = 5;

			// Token: 0x04039011 RID: 233489
			public const int CharacterFemaleItem = 6;

			// Token: 0x04039012 RID: 233490
			public const int PanelLayout = 7;

			// Token: 0x04039013 RID: 233491
			public const int InstanceItem = 8;

			// Token: 0x04039014 RID: 233492
			public const int ButtonReward = 9;

			// Token: 0x04039015 RID: 233493
			public const int InstTitle = 10;

			// Token: 0x04039016 RID: 233494
			public const int InstDescription = 11;

			// Token: 0x04039017 RID: 233495
			public const int InstAttribute = 12;
		}
	}
}
