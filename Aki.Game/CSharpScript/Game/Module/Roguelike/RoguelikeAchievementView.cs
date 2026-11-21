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
	// Token: 0x02003DCC RID: 15820
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeAchievementView : UiViewBase
	{
		// Token: 0x060286DE RID: 165598 RVA: 0x00B53E38 File Offset: 0x00B52038
		public RoguelikeAchievementView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060286DF RID: 165599 RVA: 0x00B53E4C File Offset: 0x00B5204C
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

		// Token: 0x060286E0 RID: 165600 RVA: 0x00B53ED8 File Offset: 0x00B520D8
		protected override UniTask OnBeforeStartAsync()
		{
			RoguelikeAchievementView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoguelikeAchievementView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060286E1 RID: 165601 RVA: 0x00B53F1B File Offset: 0x00B5211B
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.OnAchievementDataWithIdNotify, new Action<int>(this.OnAchievementDataWithIdNotify));
		}

		// Token: 0x060286E2 RID: 165602 RVA: 0x00B53F39 File Offset: 0x00B52139
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<int>(EEventName.OnAchievementDataWithIdNotify, new Action<int>(this.OnAchievementDataWithIdNotify));
		}

		// Token: 0x060286E3 RID: 165603 RVA: 0x00B53F57 File Offset: 0x00B52157
		protected void OnAchievementDataWithIdNotify(int id)
		{
			this.ToggleCallBack(this.TabComponent.GetSelectedIndex());
		}

		// Token: 0x060286E4 RID: 165604 RVA: 0x00B53F6A File Offset: 0x00B5216A
		private RoguelikeAchievementItem CreateAchievementItem()
		{
			return new RoguelikeAchievementItem
			{
				OnBtnRewardClick = new Action(this.OnBtnRewardClick)
			};
		}

		// Token: 0x060286E5 RID: 165605 RVA: 0x00B53F84 File Offset: 0x00B52184
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

		// Token: 0x060286E6 RID: 165606 RVA: 0x00B54024 File Offset: 0x00B52224
		protected void CloseClick()
		{
			UiManager.Instance.CloseView(this.ViewInfo.Name, null);
		}

		// Token: 0x060286E7 RID: 165607 RVA: 0x00B5403C File Offset: 0x00B5223C
		private CommonTabItem ProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
		{
			return new CommonTabItem();
		}

		// Token: 0x060286E8 RID: 165608 RVA: 0x00B54044 File Offset: 0x00B52244
		private void ToggleCallBack(int index)
		{
			AchievementGroupData groupData = this.AchievementGroupDataList[index];
			this.RefreshAchievementList(groupData);
		}

		// Token: 0x060286E9 RID: 165609 RVA: 0x00B54068 File Offset: 0x00B52268
		private CommonTabData GetCommonData(int index)
		{
			AchievementGroupData groupData = this.AchievementGroupDataList[index];
			return this.CreateCommonTabData(groupData);
		}

		// Token: 0x060286EA RID: 165610 RVA: 0x00B54089 File Offset: 0x00B52289
		private CommonTabItemData CreateTabItemData(AchievementGroupData groupData)
		{
			return new CommonTabItemData
			{
				RedDotName = new ERedDotName?(ERedDotName.RoguelikeAchievementGroup),
				RedDotUid = new int?(groupData.GetId()),
				Data = this.CreateCommonTabData(groupData)
			};
		}

		// Token: 0x060286EB RID: 165611 RVA: 0x00B540BB File Offset: 0x00B522BB
		private CommonTabData CreateCommonTabData(AchievementGroupData groupData)
		{
			return new CommonTabData(groupData.GetTexture(), new CommonTabTitleData(groupData.GetTitleId(), Array.Empty<object>()), null);
		}

		// Token: 0x060286EC RID: 165612 RVA: 0x00B540DC File Offset: 0x00B522DC
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

		// Token: 0x04015F37 RID: 89911
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public TabComponentWithCaptionItem<CommonTabItem> TabComponent;

		// Token: 0x04015F38 RID: 89912
		public List<AchievementGroupData> AchievementGroupDataList = new List<AchievementGroupData>();

		// Token: 0x04015F39 RID: 89913
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public GenericScrollViewNew<RoguelikeAchievementItem, AchievementData> AchievementScrollView;

		// Token: 0x04015F3A RID: 89914
		private int CurrentGroupId;

		// Token: 0x020099C6 RID: 39366
		[NullableContext(0)]
		private class ERoguelikeAchievementViewDefine
		{
			// Token: 0x0402FF11 RID: 196369
			public const int CaptionItem = 0;

			// Token: 0x0402FF12 RID: 196370
			public const int PanelContent = 1;

			// Token: 0x0402FF13 RID: 196371
			public const int ScrollViewItem = 2;
		}
	}
}
