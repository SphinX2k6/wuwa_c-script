using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Kurotato.Data;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.Activity
{
	// Token: 0x02004766 RID: 18278
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoNormalRewardView : UiViewBase
	{
		// Token: 0x0602DE04 RID: 187908 RVA: 0x00CD745F File Offset: 0x00CD565F
		public KurotatoNormalRewardView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0602DE05 RID: 187909 RVA: 0x00CD747C File Offset: 0x00CD567C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602DE06 RID: 187910 RVA: 0x00CD7506 File Offset: 0x00CD5706
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnRefreshKurotatoNormalRewardData, new Action(this.RefreshView));
		}

		// Token: 0x0602DE07 RID: 187911 RVA: 0x00CD7524 File Offset: 0x00CD5724
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnRefreshKurotatoNormalRewardData, new Action(this.RefreshView));
		}

		// Token: 0x0602DE08 RID: 187912 RVA: 0x00CD7544 File Offset: 0x00CD5744
		protected override UniTask OnBeforeStartAsync()
		{
			KurotatoNormalRewardView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<KurotatoNormalRewardView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602DE09 RID: 187913 RVA: 0x00CD7587 File Offset: 0x00CD5787
		protected override void OnBeforeShow()
		{
			this.RefreshView();
		}

		// Token: 0x0602DE0A RID: 187914 RVA: 0x00CD758F File Offset: 0x00CD578F
		private void InitQuestScroll()
		{
			this.QuestScroll = new GenericLayout<KurotatoRewardItem, KurotatoRewardItemData>(base.GetVerticalLayout(1), new Func<KurotatoRewardItem>(this.CreateQuestItem), null, false, true);
		}

		// Token: 0x0602DE0B RID: 187915 RVA: 0x00CD75B4 File Offset: 0x00CD57B4
		private void RefreshQuestScroll()
		{
			List<KurotatoNormalRewardItemData> normalRewardDataList = KurotatoActivityController.Instance.GetActivityData().GetNormalRewardDataList();
			normalRewardDataList.Sort((KurotatoNormalRewardItemData a, KurotatoNormalRewardItemData b) => Array.IndexOf<EKurotatoRewardStatus>(this.StatusOrder, a.Status) - Array.IndexOf<EKurotatoRewardStatus>(this.StatusOrder, b.Status));
			GenericLayout<KurotatoRewardItem, KurotatoRewardItemData> questScroll = this.QuestScroll;
			if (questScroll == null)
			{
				return;
			}
			questScroll.RefreshByData(normalRewardDataList, null, true);
		}

		// Token: 0x0602DE0C RID: 187916 RVA: 0x00CD75F6 File Offset: 0x00CD57F6
		private KurotatoRewardItem CreateQuestItem()
		{
			KurotatoRewardItem kurotatoRewardItem = new KurotatoRewardItem();
			kurotatoRewardItem.SetReceiveClickCallback(new Action(this.OnClickTaskReceive));
			return kurotatoRewardItem;
		}

		// Token: 0x0602DE0D RID: 187917 RVA: 0x00CD7610 File Offset: 0x00CD5810
		private void OnClickTaskReceive()
		{
			List<int> normalRewardCanClaimableIdList = KurotatoActivityController.Instance.GetActivityData().GetNormalRewardCanClaimableIdList();
			if (normalRewardCanClaimableIdList.Count <= 0)
			{
				return;
			}
			KurotatoActivityController.Instance.RequestNormalReward(normalRewardCanClaimableIdList);
		}

		// Token: 0x0602DE0E RID: 187918 RVA: 0x00CD7642 File Offset: 0x00CD5842
		private void RefreshView()
		{
			this.RefreshQuestScroll();
		}

		// Token: 0x0602DE0F RID: 187919 RVA: 0x00CD764A File Offset: 0x00CD584A
		private void OnCloseClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x04018818 RID: 100376
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x04018819 RID: 100377
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<KurotatoRewardItem, KurotatoRewardItemData> QuestScroll;

		// Token: 0x0401881A RID: 100378
		private readonly EKurotatoRewardStatus[] StatusOrder = new EKurotatoRewardStatus[]
		{
			EKurotatoRewardStatus.CanReceive,
			EKurotatoRewardStatus.Doing,
			EKurotatoRewardStatus.Taken
		};

		// Token: 0x0200A3CC RID: 41932
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x04032C5D RID: 207965
			Caption,
			// Token: 0x04032C5E RID: 207966
			QuestScroll,
			// Token: 0x04032C5F RID: 207967
			QuestItem
		}
	}
}
