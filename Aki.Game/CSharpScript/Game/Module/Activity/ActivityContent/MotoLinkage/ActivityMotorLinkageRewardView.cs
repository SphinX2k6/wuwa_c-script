using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotoLinkage
{
	// Token: 0x0200644B RID: 25675
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityMotorLinkageRewardView : UiViewBase
	{
		// Token: 0x0604087D RID: 264317 RVA: 0x00F9EA38 File Offset: 0x00F9CC38
		public ActivityMotorLinkageRewardView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0604087E RID: 264318 RVA: 0x00F9EA54 File Offset: 0x00F9CC54
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(4, new Action(this.OnClickRight)),
				new ValueTuple<int, Delegate>(5, new Action(this.OnClickLeft))
			};
		}

		// Token: 0x0604087F RID: 264319 RVA: 0x00F9EB70 File Offset: 0x00F9CD70
		protected override UniTask OnBeforeStartAsync()
		{
			ActivityMotorLinkageRewardView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityMotorLinkageRewardView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040880 RID: 264320 RVA: 0x00F9EBB4 File Offset: 0x00F9CDB4
		protected override void OnStart()
		{
			PopupCaptionItem caption = this.Caption;
			if (caption != null)
			{
				caption.SetCloseCallBack(delegate
				{
					base.CloseMe(null);
				});
			}
			foreach (KeyValuePair<int, MotorLinkageBackgroundItem> keyValuePair in this.BackgroundItemMap)
			{
				AUIBaseActor auibaseActor = keyValuePair.Value.GetRootActor() as AUIBaseActor;
				if (auibaseActor != null)
				{
					auibaseActor.OnSequencePlayEvent.Bind(new Action<string, string>(this.OnSequencePlayEvent));
				}
			}
		}

		// Token: 0x06040881 RID: 264321 RVA: 0x00F9EC4C File Offset: 0x00F9CE4C
		protected override void OnBeforeShow()
		{
			int num = this.SelectedIpId;
			if (num == -1)
			{
				object openParam = this.OpenParam;
				if (openParam is int)
				{
					int num2 = (int)openParam;
					num = num2;
				}
				else
				{
					num = this.IndexToIp(0);
				}
			}
			this.RefreshByIpId(num, false);
		}

		// Token: 0x06040882 RID: 264322 RVA: 0x00F9EC8E File Offset: 0x00F9CE8E
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshRedDot));
		}

		// Token: 0x06040883 RID: 264323 RVA: 0x00F9ECAC File Offset: 0x00F9CEAC
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshRedDot));
		}

		// Token: 0x06040884 RID: 264324 RVA: 0x00F9ECCC File Offset: 0x00F9CECC
		private void OnSequencePlayEvent(string seqName, string eventName)
		{
			if (seqName != "Switch" || eventName != "Switch")
			{
				return;
			}
			MotorLinkageBackgroundItem motorLinkageBackgroundItem;
			if (!this.BackgroundItemMap.TryGetValue(this.SelectedIpId, out motorLinkageBackgroundItem))
			{
				return;
			}
			motorLinkageBackgroundItem.RefreshTexture();
		}

		// Token: 0x06040885 RID: 264325 RVA: 0x00F9ED10 File Offset: 0x00F9CF10
		private void OnRefreshRedDot(int activityId)
		{
			ActivityMotorLinkageController instance = ActivityMotorLinkageController.Instance;
			int? num = (instance != null) ? new int?(instance.ActivityId) : null;
			if (!(activityId == num.GetValueOrDefault() & num != null))
			{
				return;
			}
			this.RefreshByIpId(this.SelectedIpId, true);
		}

		// Token: 0x06040886 RID: 264326 RVA: 0x00F9ED5E File Offset: 0x00F9CF5E
		private void OnClickLeft()
		{
			this.RefreshByIpId(this.GetLeftIpId(), false);
		}

		// Token: 0x06040887 RID: 264327 RVA: 0x00F9ED6D File Offset: 0x00F9CF6D
		private void OnClickRight()
		{
			this.RefreshByIpId(this.GetRightIpId(), false);
		}

		// Token: 0x06040888 RID: 264328 RVA: 0x00F9ED7C File Offset: 0x00F9CF7C
		private void RefreshByIpId(int ipId, bool skipAnim = false)
		{
			this.RefreshBackground(ipId, skipAnim);
			this.SelectedIpId = ipId;
			this.RefreshIpProgress(ipId);
			this.RefreshQuestListByIpId(ipId, !skipAnim);
			this.RefreshArrowRedPoint();
			this.RefreshTitle();
		}

		// Token: 0x06040889 RID: 264329 RVA: 0x00F9EDAC File Offset: 0x00F9CFAC
		private void RefreshTitle()
		{
			MotorLinkageIp ipConfig = ActivityMotorLinkageConfig.Instance.GetIpConfig(this.SelectedIpId);
			PopupCaptionItem caption = this.Caption;
			if (caption == null)
			{
				return;
			}
			caption.SetTitleLocalText(ipConfig.IpName);
		}

		// Token: 0x0604088A RID: 264330 RVA: 0x00F9EDE4 File Offset: 0x00F9CFE4
		private void RefreshArrowRedPoint()
		{
			ActivityMotorLinkageData activityData = ActivityMotorLinkageController.Instance.ActivityData;
			int leftIpId = this.GetLeftIpId();
			bool uiactive = activityData.IpHasAnyRewardCanReceive(leftIpId);
			UUIItem item = base.GetItem(8);
			if (item != null)
			{
				item.SetUIActive(uiactive);
			}
			int rightIpId = this.GetRightIpId();
			bool uiactive2 = activityData.IpHasAnyRewardCanReceive(rightIpId);
			UUIItem item2 = base.GetItem(7);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(uiactive2);
		}

		// Token: 0x0604088B RID: 264331 RVA: 0x00F9EE40 File Offset: 0x00F9D040
		private void RefreshBackground(int ipId, bool skipAnim = false)
		{
			MotorLinkageBackgroundItem motorLinkageBackgroundItem;
			this.BackgroundItemMap.TryGetValue(this.SelectedIpId, out motorLinkageBackgroundItem);
			if (ipId == this.SelectedIpId)
			{
				if (motorLinkageBackgroundItem != null)
				{
					motorLinkageBackgroundItem.Refresh(skipAnim);
				}
				return;
			}
			if (motorLinkageBackgroundItem != null)
			{
				motorLinkageBackgroundItem.Hide(null);
			}
			MotorLinkageBackgroundItem motorLinkageBackgroundItem2;
			if (this.BackgroundItemMap.TryGetValue(ipId, out motorLinkageBackgroundItem2) && motorLinkageBackgroundItem2 != null)
			{
				motorLinkageBackgroundItem2.Show(null);
			}
		}

		// Token: 0x0604088C RID: 264332 RVA: 0x00F9EE9C File Offset: 0x00F9D09C
		private void RefreshIpProgress(int ipId)
		{
			ActivityMotorLinkageData activityData = ActivityMotorLinkageController.Instance.ActivityData;
			int ipCurrentProgress = activityData.GetIpCurrentProgress(ipId);
			int ipTotalProgress = activityData.GetIpTotalProgress(ipId);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "MotorLinkage_IP_Progress", new <>z__ReadOnlyArray<object>(new object[]
			{
				ipCurrentProgress,
				ipTotalProgress
			}));
		}

		// Token: 0x0604088D RID: 264333 RVA: 0x00F9EEF8 File Offset: 0x00F9D0F8
		private void RefreshQuestListByIpId(int ipId, bool playAnim = true)
		{
			List<int> sortedQuestList = ActivityMotorLinkageController.Instance.ActivityData.GetSortedQuestList(ipId);
			GenericScrollViewNew<MotorQuestItem, int> questScrollView = this.QuestScrollView;
			if (questScrollView == null)
			{
				return;
			}
			questScrollView.RefreshByData(sortedQuestList, null, playAnim);
		}

		// Token: 0x0604088E RID: 264334 RVA: 0x00F9EF29 File Offset: 0x00F9D129
		private MotorQuestItem QuestItemProxyCreate()
		{
			return new MotorQuestItem();
		}

		// Token: 0x0604088F RID: 264335 RVA: 0x00F9EF30 File Offset: 0x00F9D130
		private int GetLeftIpId()
		{
			int num = this.IpToIndex(this.SelectedIpId);
			int count = this.GetSortedIpList().Count;
			int num2 = num - 1;
			if (num2 < 0)
			{
				num2 += count;
			}
			return this.IndexToIp(num2);
		}

		// Token: 0x06040890 RID: 264336 RVA: 0x00F9EF68 File Offset: 0x00F9D168
		private int GetRightIpId()
		{
			int num = this.IpToIndex(this.SelectedIpId);
			int count = this.GetSortedIpList().Count;
			int num2 = num + 1;
			if (num2 >= count)
			{
				num2 -= count;
			}
			return this.IndexToIp(num2);
		}

		// Token: 0x06040891 RID: 264337 RVA: 0x00F9EFA0 File Offset: 0x00F9D1A0
		private int IpToIndex(int ipId)
		{
			return this.GetSortedIpList().FindIndex((int id) => id == ipId);
		}

		// Token: 0x06040892 RID: 264338 RVA: 0x00F9EFD1 File Offset: 0x00F9D1D1
		private int IndexToIp(int index)
		{
			return this.GetSortedIpList()[index];
		}

		// Token: 0x06040893 RID: 264339 RVA: 0x00F9EFDF File Offset: 0x00F9D1DF
		private List<int> GetSortedIpList()
		{
			return ActivityMotorLinkageController.Instance.ActivityData.GetSortedIpList();
		}

		// Token: 0x040218F3 RID: 137459
		[Nullable(2)]
		private PopupCaptionItem Caption;

		// Token: 0x040218F4 RID: 137460
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<MotorQuestItem, int> QuestScrollView;

		// Token: 0x040218F5 RID: 137461
		private int SelectedIpId = -1;

		// Token: 0x040218F6 RID: 137462
		private readonly Dictionary<int, MotorLinkageBackgroundItem> BackgroundItemMap = new Dictionary<int, MotorLinkageBackgroundItem>();
	}
}
