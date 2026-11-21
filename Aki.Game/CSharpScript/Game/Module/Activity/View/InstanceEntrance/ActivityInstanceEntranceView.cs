using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.View.InstanceEntrance
{
	// Token: 0x02004F01 RID: 20225
	[NullableContext(2)]
	[Nullable(0)]
	public class ActivityInstanceEntranceView : UiTickViewBase
	{
		// Token: 0x06032D3C RID: 208188 RVA: 0x00E44EFA File Offset: 0x00E430FA
		[NullableContext(1)]
		public ActivityInstanceEntranceView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06032D3D RID: 208189 RVA: 0x00E44F04 File Offset: 0x00E43104
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIDynScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06032D3E RID: 208190 RVA: 0x00E45058 File Offset: 0x00E43258
		protected override UniTask OnBeforeStartAsync()
		{
			ActivityInstanceEntranceView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityInstanceEntranceView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032D3F RID: 208191 RVA: 0x00E4509B File Offset: 0x00E4329B
		[NullableContext(1)]
		private ActivityInstanceEntranceScrollItem CreateInstanceGrid(ActivityEntranceItemData data, UUIItem uiItem, int index)
		{
			return new ActivityInstanceEntranceScrollItem();
		}

		// Token: 0x06032D40 RID: 208192 RVA: 0x00E450A2 File Offset: 0x00E432A2
		protected override void OnStart()
		{
			this.UiViewSequence.AddSequenceFinishEvent("Close01", new Action<string>(this.FinishCloseSequenceEvent), false);
		}

		// Token: 0x06032D41 RID: 208193 RVA: 0x00E450C1 File Offset: 0x00E432C1
		[NullableContext(1)]
		private void FinishCloseSequenceEvent(string _)
		{
			UiManager.Instance.CloseView(this.ViewInfo.Name, null);
		}

		// Token: 0x06032D42 RID: 208194 RVA: 0x00E450DC File Offset: 0x00E432DC
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.RefreshActivityEntranceScroller, new Action<int>(this.OnSelectActivityEntranceScrollItem));
			EventSystem.Instance.Add<int>(EEventName.RefreshActivityEntranceItemContent, new Action<int>(this.OnRefreshActivityEntranceItemContent));
			EventSystem.Instance.Add(EEventName.OnRefreshInstancedRecommendLevel, new Action(this.OnRefreshInstancedRecommendLevel));
		}

		// Token: 0x06032D43 RID: 208195 RVA: 0x00E45140 File Offset: 0x00E43340
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<int>(EEventName.RefreshActivityEntranceScroller, new Action<int>(this.OnSelectActivityEntranceScrollItem));
			EventSystem.Instance.Remove<int>(EEventName.RefreshActivityEntranceItemContent, new Action<int>(this.OnRefreshActivityEntranceItemContent));
			EventSystem.Instance.Remove(EEventName.OnRefreshInstancedRecommendLevel, new Action(this.OnRefreshInstancedRecommendLevel));
		}

		// Token: 0x06032D44 RID: 208196 RVA: 0x00E451A1 File Offset: 0x00E433A1
		private void OnRefreshInstancedRecommendLevel()
		{
			ActivityInstanceEntranceInfoItem activityInstanceEntranceInfoItem = this.ActivityInstanceEntranceInfoItem;
			if (activityInstanceEntranceInfoItem != null)
			{
				activityInstanceEntranceInfoItem.RefreshDropDownItem(this.ViewData).Forget();
			}
			ActivityInstanceEntranceInfoItem activityInstanceEntranceInfoItem2 = this.ActivityInstanceEntranceInfoItem;
			if (activityInstanceEntranceInfoItem2 == null)
			{
				return;
			}
			activityInstanceEntranceInfoItem2.RefreshRecommendLevelItem(this.ViewData).Forget();
		}

		// Token: 0x06032D45 RID: 208197 RVA: 0x00E451DC File Offset: 0x00E433DC
		private void OnRefreshActivityEntranceItemContent(int uiIndex)
		{
			this.CurrentSelectMainUiIndex = uiIndex;
			this.UpdateScrollView();
			this.CheckAndShowDungeonArchiveExpireTips();
			ActivityInstanceEntranceInfoItem activityInstanceEntranceInfoItem = this.ActivityInstanceEntranceInfoItem;
			if (activityInstanceEntranceInfoItem != null)
			{
				activityInstanceEntranceInfoItem.RefreshView(this.ViewData);
			}
			this.UiViewSequence.PlaySequence("Xz", false, null);
		}

		// Token: 0x06032D46 RID: 208198 RVA: 0x00E45230 File Offset: 0x00E43430
		private void OnSelectActivityEntranceScrollItem(int uiIndex)
		{
			this.CurrentSelectMainUiIndex = uiIndex;
			this.RefreshScrollView();
			ActivityInstanceEntranceInfoItem activityInstanceEntranceInfoItem = this.ActivityInstanceEntranceInfoItem;
			if (activityInstanceEntranceInfoItem != null)
			{
				activityInstanceEntranceInfoItem.RefreshView(this.ViewData);
			}
			this.UpdateInstanceBg(this.ViewData);
			this.UiViewSequence.PlaySequence("Xz", false, null);
		}

		// Token: 0x06032D47 RID: 208199 RVA: 0x00E45287 File Offset: 0x00E43487
		private void OnClickCaptionStateBtn()
		{
			HelpController.Instance.OpenHelpById(242);
		}

		// Token: 0x06032D48 RID: 208200 RVA: 0x00E45298 File Offset: 0x00E43498
		protected override void OnBeforeShow()
		{
			this.RefreshScrollView();
		}

		// Token: 0x06032D49 RID: 208201 RVA: 0x00E452A0 File Offset: 0x00E434A0
		protected override void OnAfterShow()
		{
			this.CheckAndShowDungeonArchiveExpireTips();
		}

		// Token: 0x06032D4A RID: 208202 RVA: 0x00E452A8 File Offset: 0x00E434A8
		private void CheckAndShowDungeonArchiveExpireTips()
		{
			ActivityEntranceSelectItemData activityEntranceSelectItemData = this.ViewData.GetActivityEntranceSelectItemData();
			ActivityEntranceItemData activityEntranceItemData = (activityEntranceSelectItemData != null) ? activityEntranceSelectItemData.GetCurrentSelectData() : null;
			int dungeonId = (activityEntranceItemData != null) ? activityEntranceItemData.GetInstanceDungeonId() : 0;
			InstanceDungeonController.Instance.CheckAndShowDungeonArchiveExpireTips(dungeonId);
		}

		// Token: 0x06032D4B RID: 208203 RVA: 0x00E452E4 File Offset: 0x00E434E4
		private void RefreshCaptionItemByData(ActivityEntranceCaptionItemData captionData)
		{
			this.InstanceDungeonCaptionItem.SetCloseCallBack(new Action(this.OnClickBtnClose));
			if (captionData != null)
			{
				PopupCaptionItem instanceDungeonCaptionItem = this.InstanceDungeonCaptionItem;
				if (instanceDungeonCaptionItem != null)
				{
					instanceDungeonCaptionItem.SetUiActive(true);
				}
				PopupCaptionItem instanceDungeonCaptionItem2 = this.InstanceDungeonCaptionItem;
				if (instanceDungeonCaptionItem2 != null)
				{
					instanceDungeonCaptionItem2.SetTitleByTextIdAndArgNew(captionData.GetName(), Array.Empty<object>());
				}
				string titleSpritePath = captionData.GetTitleSpritePath();
				if (!string.IsNullOrEmpty(titleSpritePath))
				{
					this.InstanceDungeonCaptionItem.SetTitleIconVisible(true);
					this.InstanceDungeonCaptionItem.SetTitleIcon(titleSpritePath);
				}
				else
				{
					this.InstanceDungeonCaptionItem.SetTitleIconVisible(false);
				}
				int helpId = captionData.GetHelpId();
				this.InstanceDungeonCaptionItem.SetHelpBtnActive(helpId != 0);
				this.InstanceDungeonCaptionItem.SetHelpCallBack(delegate
				{
					int helpId2 = this.ViewData.GetActivityEntranceCaptionItemData().GetHelpId();
					HelpController.Instance.OpenHelpById(helpId2);
				});
				return;
			}
			PopupCaptionItem instanceDungeonCaptionItem3 = this.InstanceDungeonCaptionItem;
			if (instanceDungeonCaptionItem3 == null)
			{
				return;
			}
			instanceDungeonCaptionItem3.SetUiActive(false);
		}

		// Token: 0x06032D4C RID: 208204 RVA: 0x00E453B0 File Offset: 0x00E435B0
		private void RefreshCaptionStateItemByData(ActivityEntranceItemData entranceItemData)
		{
			int dungeonId = (entranceItemData != null) ? entranceItemData.GetInstanceDungeonId() : 0;
			bool flag = InstanceDungeonEntranceModel.Instance.IsDungeonArchiveActivate(dungeonId);
			this.InstanceDungeonCaptionItem.SetCaptionStateActive(flag && entranceItemData != null);
			this.InstanceDungeonCaptionItem.SetCaptionChangeColor(false);
			if (flag)
			{
				if (InstanceDungeonEntranceModel.Instance.HasDungeonArchive(dungeonId))
				{
					this.InstanceDungeonCaptionItem.SetCaptionStateTip("instance_HaveRecord");
					this.InstanceDungeonCaptionItem.SetCaptionChangeColor(true);
					return;
				}
				if (InstanceDungeonEntranceModel.Instance.IsDungeonSupportAndWithoutArchive(dungeonId))
				{
					this.InstanceDungeonCaptionItem.SetCaptionStateTip("instance_Record_leave");
				}
			}
		}

		// Token: 0x06032D4D RID: 208205 RVA: 0x00E45444 File Offset: 0x00E43644
		private void UpdateInstanceBg(ActivityInstanceEntranceData data)
		{
			if (data == null || data.GetActivityEntranceSelectItemData() == null)
			{
				UUITexture texture = base.GetTexture(3);
				if (texture == null)
				{
					return;
				}
				texture.SetUIActive(false);
				return;
			}
			else
			{
				ActivityEntranceItemData currentSelectData = data.GetActivityEntranceSelectItemData().GetCurrentSelectData();
				string text = (currentSelectData != null) ? currentSelectData.GetBgPath() : null;
				if (!string.IsNullOrEmpty(text))
				{
					base.SetTextureByPath(text, base.GetTexture(3), null, null);
					return;
				}
				UUITexture texture2 = base.GetTexture(3);
				if (texture2 == null)
				{
					return;
				}
				texture2.SetUIActive(false);
				return;
			}
		}

		// Token: 0x06032D4E RID: 208206 RVA: 0x00E454BA File Offset: 0x00E436BA
		private void RefreshScoreItem(ActivityEntrancePointData data)
		{
			if (data == null)
			{
				return;
			}
			ActivityInstanceEntranceScoreItem activityInstanceEntranceScoreItem = this.ActivityInstanceEntranceScoreItem;
			if (activityInstanceEntranceScoreItem != null)
			{
				activityInstanceEntranceScoreItem.SetActive(true);
			}
			ActivityInstanceEntranceScoreItem activityInstanceEntranceScoreItem2 = this.ActivityInstanceEntranceScoreItem;
			if (activityInstanceEntranceScoreItem2 == null)
			{
				return;
			}
			activityInstanceEntranceScoreItem2.RefreshView(data);
		}

		// Token: 0x06032D4F RID: 208207 RVA: 0x00E454E3 File Offset: 0x00E436E3
		private void OnClickBtnClose()
		{
			this.UiViewSequence.PlaySequencePurely("Close01", true, false);
		}

		// Token: 0x06032D50 RID: 208208 RVA: 0x00E454F8 File Offset: 0x00E436F8
		private void RefreshScrollView()
		{
			IReadOnlyList<ActivityEntranceItemData> showDataBySelectElement = this.ViewData.GetActivityEntranceSelectItemData().GetShowDataBySelectElement(this.CurrentSelectMainUiIndex, 0);
			foreach (ActivityEntranceItemData activityEntranceItemData in showDataBySelectElement)
			{
				if (activityEntranceItemData.GetSelectState())
				{
					Action<int> selectCallBack = activityEntranceItemData.GetSelectCallBack();
					if (selectCallBack != null)
					{
						selectCallBack(activityEntranceItemData.GetSelectDataIndex());
					}
				}
			}
			this.InstanceLoopScroll.RefreshByData(showDataBySelectElement, false, false);
		}

		// Token: 0x06032D51 RID: 208209 RVA: 0x00E45580 File Offset: 0x00E43780
		private void UpdateScrollView()
		{
			IReadOnlyList<ActivityEntranceItemData> showDataBySelectElement = this.ViewData.GetActivityEntranceSelectItemData().GetShowDataBySelectElement(this.CurrentSelectMainUiIndex, 0);
			for (int i = 0; i < this.InstanceLoopScroll.GetScrollItemCount(); i++)
			{
				DynamicScrollView<ActivityInstanceEntranceScrollItem, ActivityInstanceEntranceDynItem, ActivityEntranceItemData> instanceLoopScroll = this.InstanceLoopScroll;
				ActivityInstanceEntranceScrollItem activityInstanceEntranceScrollItem = (instanceLoopScroll != null) ? instanceLoopScroll.GetScrollItemFromIndex(i) : null;
				if (activityInstanceEntranceScrollItem != null)
				{
					activityInstanceEntranceScrollItem.Update(showDataBySelectElement[i], i);
				}
			}
		}

		// Token: 0x06032D52 RID: 208210 RVA: 0x00E455E1 File Offset: 0x00E437E1
		protected override void OnBeforeDestroy()
		{
			if (this.InstanceLoopScroll != null)
			{
				this.InstanceLoopScroll.ClearChildren();
				this.InstanceLoopScroll = null;
			}
		}

		// Token: 0x0401AFAD RID: 110509
		private ActivityInstanceEntranceData ViewData;

		// Token: 0x0401AFAE RID: 110510
		private ActivityInstanceEntranceInfoItem ActivityInstanceEntranceInfoItem;

		// Token: 0x0401AFAF RID: 110511
		private PopupCaptionItem InstanceDungeonCaptionItem;

		// Token: 0x0401AFB0 RID: 110512
		private ActivityInstanceEntranceScoreItem ActivityInstanceEntranceScoreItem;

		// Token: 0x0401AFB1 RID: 110513
		private int CurrentSelectMainUiIndex;

		// Token: 0x0401AFB2 RID: 110514
		private ActivityInstanceEntranceDynItem InstanceDetectDynamicItem;

		// Token: 0x0401AFB3 RID: 110515
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private DynamicScrollView<ActivityInstanceEntranceScrollItem, ActivityInstanceEntranceDynItem, ActivityEntranceItemData> InstanceLoopScroll;

		// Token: 0x0200AC5E RID: 44126
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x04035536 RID: 218422
			DynScrollView,
			// Token: 0x04035537 RID: 218423
			ScrollItem,
			// Token: 0x04035538 RID: 218424
			UiItemEntrance,
			// Token: 0x04035539 RID: 218425
			TextureInstanceBG,
			// Token: 0x0403553A RID: 218426
			TopItem,
			// Token: 0x0403553B RID: 218427
			ContentItem,
			// Token: 0x0403553C RID: 218428
			CaptionItem,
			// Token: 0x0403553D RID: 218429
			TimeAndCountItem,
			// Token: 0x0403553E RID: 218430
			LeftRewardItem
		}
	}
}
