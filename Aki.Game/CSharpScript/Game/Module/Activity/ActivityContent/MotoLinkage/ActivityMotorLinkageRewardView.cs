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
	// Token: 0x020053C9 RID: 21449
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityMotorLinkageRewardView : UiViewBase
	{
		// Token: 0x0603553E RID: 218430 RVA: 0x00EE59B4 File Offset: 0x00EE3BB4
		public ActivityMotorLinkageRewardView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603553F RID: 218431 RVA: 0x00EE59D0 File Offset: 0x00EE3BD0
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

		// Token: 0x06035540 RID: 218432 RVA: 0x00EE5AEC File Offset: 0x00EE3CEC
		protected override UniTask OnBeforeStartAsync()
		{
			ActivityMotorLinkageRewardView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityMotorLinkageRewardView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035541 RID: 218433 RVA: 0x00EE5B30 File Offset: 0x00EE3D30
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

		// Token: 0x06035542 RID: 218434 RVA: 0x00EE5BC8 File Offset: 0x00EE3DC8
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

		// Token: 0x06035543 RID: 218435 RVA: 0x00EE5C0A File Offset: 0x00EE3E0A
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshRedDot));
		}

		// Token: 0x06035544 RID: 218436 RVA: 0x00EE5C28 File Offset: 0x00EE3E28
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshRedDot));
		}

		// Token: 0x06035545 RID: 218437 RVA: 0x00EE5C48 File Offset: 0x00EE3E48
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

		// Token: 0x06035546 RID: 218438 RVA: 0x00EE5C8C File Offset: 0x00EE3E8C
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

		// Token: 0x06035547 RID: 218439 RVA: 0x00EE5CDA File Offset: 0x00EE3EDA
		private void OnClickLeft()
		{
			this.RefreshByIpId(this.GetLeftIpId(), false);
		}

		// Token: 0x06035548 RID: 218440 RVA: 0x00EE5CE9 File Offset: 0x00EE3EE9
		private void OnClickRight()
		{
			this.RefreshByIpId(this.GetRightIpId(), false);
		}

		// Token: 0x06035549 RID: 218441 RVA: 0x00EE5CF8 File Offset: 0x00EE3EF8
		private void RefreshByIpId(int ipId, bool skipAnim = false)
		{
			this.RefreshBackground(ipId, skipAnim);
			this.SelectedIpId = ipId;
			this.RefreshIpProgress(ipId);
			this.RefreshQuestListByIpId(ipId, !skipAnim);
			this.RefreshArrowRedPoint();
			this.RefreshTitle();
		}

		// Token: 0x0603554A RID: 218442 RVA: 0x00EE5D28 File Offset: 0x00EE3F28
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

		// Token: 0x0603554B RID: 218443 RVA: 0x00EE5D60 File Offset: 0x00EE3F60
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

		// Token: 0x0603554C RID: 218444 RVA: 0x00EE5DBC File Offset: 0x00EE3FBC
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

		// Token: 0x0603554D RID: 218445 RVA: 0x00EE5E18 File Offset: 0x00EE4018
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

		// Token: 0x0603554E RID: 218446 RVA: 0x00EE5E74 File Offset: 0x00EE4074
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

		// Token: 0x0603554F RID: 218447 RVA: 0x00EE5EA5 File Offset: 0x00EE40A5
		private MotorQuestItem QuestItemProxyCreate()
		{
			return new MotorQuestItem();
		}

		// Token: 0x06035550 RID: 218448 RVA: 0x00EE5EAC File Offset: 0x00EE40AC
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

		// Token: 0x06035551 RID: 218449 RVA: 0x00EE5EE4 File Offset: 0x00EE40E4
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

		// Token: 0x06035552 RID: 218450 RVA: 0x00EE5F1C File Offset: 0x00EE411C
		private int IpToIndex(int ipId)
		{
			return this.GetSortedIpList().FindIndex((int id) => id == ipId);
		}

		// Token: 0x06035553 RID: 218451 RVA: 0x00EE5F4D File Offset: 0x00EE414D
		private int IndexToIp(int index)
		{
			return this.GetSortedIpList()[index];
		}

		// Token: 0x06035554 RID: 218452 RVA: 0x00EE5F5B File Offset: 0x00EE415B
		private List<int> GetSortedIpList()
		{
			return ActivityMotorLinkageController.Instance.ActivityData.GetSortedIpList();
		}

		// Token: 0x0401C222 RID: 115234
		[Nullable(2)]
		private PopupCaptionItem Caption;

		// Token: 0x0401C223 RID: 115235
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<MotorQuestItem, int> QuestScrollView;

		// Token: 0x0401C224 RID: 115236
		private int SelectedIpId = -1;

		// Token: 0x0401C225 RID: 115237
		private readonly Dictionary<int, MotorLinkageBackgroundItem> BackgroundItemMap = new Dictionary<int, MotorLinkageBackgroundItem>();
	}
}
