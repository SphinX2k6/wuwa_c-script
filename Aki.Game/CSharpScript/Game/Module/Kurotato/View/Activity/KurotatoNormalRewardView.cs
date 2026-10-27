using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x0200578F RID: 22415
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoNormalRewardView : UiViewBase
	{
		// Token: 0x06038EF4 RID: 233204 RVA: 0x00D88703 File Offset: 0x00D86903
		public KurotatoNormalRewardView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06038EF5 RID: 233205 RVA: 0x00D88720 File Offset: 0x00D86920
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

		// Token: 0x06038EF6 RID: 233206 RVA: 0x00D887AA File Offset: 0x00D869AA
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnRefreshKurotatoNormalRewardData, new Action(this.RefreshView));
		}

		// Token: 0x06038EF7 RID: 233207 RVA: 0x00D887C8 File Offset: 0x00D869C8
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnRefreshKurotatoNormalRewardData, new Action(this.RefreshView));
		}

		// Token: 0x06038EF8 RID: 233208 RVA: 0x00D887E8 File Offset: 0x00D869E8
		protected override UniTask OnBeforeStartAsync()
		{
			KurotatoNormalRewardView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<KurotatoNormalRewardView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038EF9 RID: 233209 RVA: 0x00D8882B File Offset: 0x00D86A2B
		protected override void OnBeforeShow()
		{
			this.RefreshView();
		}

		// Token: 0x06038EFA RID: 233210 RVA: 0x00D88833 File Offset: 0x00D86A33
		private void InitQuestScroll()
		{
			this.QuestScroll = new GenericLayout<KurotatoRewardItem, KurotatoRewardItemData>(base.GetVerticalLayout(1), new Func<KurotatoRewardItem>(this.CreateQuestItem), null, false, true);
		}

		// Token: 0x06038EFB RID: 233211 RVA: 0x00D88858 File Offset: 0x00D86A58
		private void RefreshQuestScroll()
		{
			List<KurotatoNormalRewardItemData> normalRewardDataList = KurotatoActivityController.Instance.GetActivityData().GetNormalRewardDataList();
			normalRewardDataList.Sort((KurotatoNormalRewardItemData a, KurotatoNormalRewardItemData b) => Array.IndexOf<EKurotatoRewardStatus>(this.StatusOrder, a.Status) - Array.IndexOf<EKurotatoRewardStatus>(this.StatusOrder, b.Status));
			GenericLayout<KurotatoRewardItem, KurotatoRewardItemData> questScroll = this.QuestScroll;
			if (questScroll == null)
			{
				return;
			}
			questScroll.RefreshByData(normalRewardDataList.Cast<KurotatoRewardItemData>().ToList<KurotatoRewardItemData>(), null, true);
		}

		// Token: 0x06038EFC RID: 233212 RVA: 0x00D888A4 File Offset: 0x00D86AA4
		private KurotatoRewardItem CreateQuestItem()
		{
			KurotatoRewardItem kurotatoRewardItem = new KurotatoRewardItem();
			kurotatoRewardItem.SetReceiveClickCallback(new Action(this.OnClickTaskReceive));
			return kurotatoRewardItem;
		}

		// Token: 0x06038EFD RID: 233213 RVA: 0x00D888C0 File Offset: 0x00D86AC0
		private void OnClickTaskReceive()
		{
			List<int> normalRewardCanClaimableIdList = KurotatoActivityController.Instance.GetActivityData().GetNormalRewardCanClaimableIdList();
			if (normalRewardCanClaimableIdList.Count <= 0)
			{
				return;
			}
			KurotatoActivityController.Instance.RequestNormalReward(normalRewardCanClaimableIdList);
		}

		// Token: 0x06038EFE RID: 233214 RVA: 0x00D888F2 File Offset: 0x00D86AF2
		private void RefreshView()
		{
			this.RefreshQuestScroll();
		}

		// Token: 0x06038EFF RID: 233215 RVA: 0x00D888FA File Offset: 0x00D86AFA
		private void OnCloseClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0401DD82 RID: 122242
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401DD83 RID: 122243
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<KurotatoRewardItem, KurotatoRewardItemData> QuestScroll;

		// Token: 0x0401DD84 RID: 122244
		private readonly EKurotatoRewardStatus[] StatusOrder = new EKurotatoRewardStatus[]
		{
			EKurotatoRewardStatus.CanReceive,
			EKurotatoRewardStatus.Doing,
			EKurotatoRewardStatus.Taken
		};

		// Token: 0x0200B9B6 RID: 47542
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x0403826C RID: 229996
			Caption,
			// Token: 0x0403826D RID: 229997
			QuestScroll,
			// Token: 0x0403826E RID: 229998
			QuestItem
		}
	}
}
