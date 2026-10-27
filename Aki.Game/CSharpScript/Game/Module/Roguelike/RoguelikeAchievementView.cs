using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004E03 RID: 19971
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeAchievementView : UiViewBase
	{
		// Token: 0x06033873 RID: 211059 RVA: 0x00C0A928 File Offset: 0x00C08B28
		public RoguelikeAchievementView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06033874 RID: 211060 RVA: 0x00C0A93C File Offset: 0x00C08B3C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06033875 RID: 211061 RVA: 0x00C0A9C8 File Offset: 0x00C08BC8
		protected override UniTask OnBeforeStartAsync()
		{
			RoguelikeAchievementView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoguelikeAchievementView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033876 RID: 211062 RVA: 0x00C0AA0B File Offset: 0x00C08C0B
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.OnAchievementDataWithIdNotify, new Action<int>(this.OnAchievementDataWithIdNotify));
		}

		// Token: 0x06033877 RID: 211063 RVA: 0x00C0AA29 File Offset: 0x00C08C29
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<int>(EEventName.OnAchievementDataWithIdNotify, new Action<int>(this.OnAchievementDataWithIdNotify));
		}

		// Token: 0x06033878 RID: 211064 RVA: 0x00C0AA47 File Offset: 0x00C08C47
		protected void OnAchievementDataWithIdNotify(int id)
		{
			this.ToggleCallBack(this.TabComponent.GetSelectedIndex());
		}

		// Token: 0x06033879 RID: 211065 RVA: 0x00C0AA5A File Offset: 0x00C08C5A
		private RoguelikeAchievementItem CreateAchievementItem()
		{
			return new RoguelikeAchievementItem
			{
				OnBtnRewardClick = new Action(this.OnBtnRewardClick)
			};
		}

		// Token: 0x0603387A RID: 211066 RVA: 0x00C0AA74 File Offset: 0x00C08C74
		private void OnBtnRewardClick()
		{
			List<int> list = new List<int>();
			foreach (AchievementData achievementData in AchievementModel.Instance.GetGroupAchievements(this.CurrentGroupId, true))
			{
				if (achievementData.GetFinishState() == EAchievementStateEnum.CanGetReward && achievementData.GetRewards().Count > 0)
				{
					list.Add(achievementData.GetId());
				}
			}
			if (list.Count <= 0)
			{
				return;
			}
			AchievementController.Instance.RequestGetMultiAchievementReward(list.ToArray(), Array.Empty<int>());
		}

		// Token: 0x0603387B RID: 211067 RVA: 0x00C0AB14 File Offset: 0x00C08D14
		protected void CloseClick()
		{
			UiManager.Instance.CloseView(this.ViewInfo.Name, null);
		}

		// Token: 0x0603387C RID: 211068 RVA: 0x00C0AB2C File Offset: 0x00C08D2C
		private CommonTabItem ProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
		{
			return new CommonTabItem();
		}

		// Token: 0x0603387D RID: 211069 RVA: 0x00C0AB34 File Offset: 0x00C08D34
		private void ToggleCallBack(int index)
		{
			AchievementGroupData groupData = this.AchievementGroupDataList[index];
			this.RefreshAchievementList(groupData);
		}

		// Token: 0x0603387E RID: 211070 RVA: 0x00C0AB58 File Offset: 0x00C08D58
		private CommonTabData GetCommonData(int index)
		{
			AchievementGroupData groupData = this.AchievementGroupDataList[index];
			return this.CreateCommonTabData(groupData);
		}

		// Token: 0x0603387F RID: 211071 RVA: 0x00C0AB79 File Offset: 0x00C08D79
		private CommonTabItemData CreateTabItemData(AchievementGroupData groupData)
		{
			return new CommonTabItemData
			{
				RedDotName = new ERedDotName?(ERedDotName.RoguelikeAchievementGroup),
				RedDotUid = new int?(groupData.GetId()),
				Data = this.CreateCommonTabData(groupData)
			};
		}

		// Token: 0x06033880 RID: 211072 RVA: 0x00C0ABAB File Offset: 0x00C08DAB
		private CommonTabData CreateCommonTabData(AchievementGroupData groupData)
		{
			return new CommonTabData(groupData.GetTexture(), new CommonTabTitleData(groupData.GetTitleId(), Array.Empty<object>()), null);
		}

		// Token: 0x06033881 RID: 211073 RVA: 0x00C0ABCC File Offset: 0x00C08DCC
		public void RefreshAchievementList(AchievementGroupData groupData)
		{
			this.CurrentGroupId = groupData.GetId();
			List<AchievementData> groupAchievements = AchievementModel.Instance.GetGroupAchievements(this.CurrentGroupId, true);
			groupAchievements.Sort((AchievementData a, AchievementData b) => b.GetFinishSort() - a.GetFinishSort());
			this.AchievementScrollView.RefreshByData(groupAchievements, delegate
			{
				RoguelikeAchievementItem scrollItemByIndex = this.AchievementScrollView.GetScrollItemByIndex(0);
				if (scrollItemByIndex != null)
				{
					this.AchievementScrollView.LateScrollTo(scrollItemByIndex.GetRootItem(), null, false);
				}
			}, false);
		}

		// Token: 0x0401B564 RID: 111972
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public TabComponentWithCaptionItem<CommonTabItem> TabComponent;

		// Token: 0x0401B565 RID: 111973
		public List<AchievementGroupData> AchievementGroupDataList = new List<AchievementGroupData>();

		// Token: 0x0401B566 RID: 111974
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public GenericScrollViewNew<RoguelikeAchievementItem, AchievementData> AchievementScrollView;

		// Token: 0x0401B567 RID: 111975
		private int CurrentGroupId;

		// Token: 0x0200AF91 RID: 44945
		[NullableContext(0)]
		private class ERoguelikeAchievementViewDefine
		{
			// Token: 0x040354DE RID: 218334
			public const int CaptionItem = 0;

			// Token: 0x040354DF RID: 218335
			public const int PanelContent = 1;

			// Token: 0x040354E0 RID: 218336
			public const int ScrollViewItem = 2;
		}
	}
}
