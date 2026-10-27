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
	// Token: 0x02005F1A RID: 24346
	[NullableContext(2)]
	[Nullable(0)]
	public class ActivityInstanceEntranceView : UiTickViewBase
	{
		// Token: 0x0603DDA1 RID: 253345 RVA: 0x00EF31F2 File Offset: 0x00EF13F2
		[NullableContext(1)]
		public ActivityInstanceEntranceView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603DDA2 RID: 253346 RVA: 0x00EF31FC File Offset: 0x00EF13FC
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

		// Token: 0x0603DDA3 RID: 253347 RVA: 0x00EF3350 File Offset: 0x00EF1550
		protected override UniTask OnBeforeStartAsync()
		{
			ActivityInstanceEntranceView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityInstanceEntranceView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603DDA4 RID: 253348 RVA: 0x00EF3393 File Offset: 0x00EF1593
		[NullableContext(1)]
		private ActivityInstanceEntranceScrollItem CreateInstanceGrid(ActivityEntranceItemData data, UUIItem uiItem, int index)
		{
			return new ActivityInstanceEntranceScrollItem();
		}

		// Token: 0x0603DDA5 RID: 253349 RVA: 0x00EF339A File Offset: 0x00EF159A
		protected override void OnStart()
		{
			this.UiViewSequence.AddSequenceFinishEvent("Close01", new Action<string>(this.FinishCloseSequenceEvent), false);
		}

		// Token: 0x0603DDA6 RID: 253350 RVA: 0x00EF33B9 File Offset: 0x00EF15B9
		[NullableContext(1)]
		private void FinishCloseSequenceEvent(string _)
		{
			UiManager.Instance.CloseView(this.ViewInfo.Name, null);
		}

		// Token: 0x0603DDA7 RID: 253351 RVA: 0x00EF33D4 File Offset: 0x00EF15D4
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.RefreshActivityEntranceScroller, new Action<int>(this.OnSelectActivityEntranceScrollItem));
			EventSystem.Instance.Add<int>(EEventName.RefreshActivityEntranceItemContent, new Action<int>(this.OnRefreshActivityEntranceItemContent));
			EventSystem.Instance.Add(EEventName.OnRefreshInstancedRecommendLevel, new Action(this.OnRefreshInstancedRecommendLevel));
		}

		// Token: 0x0603DDA8 RID: 253352 RVA: 0x00EF3438 File Offset: 0x00EF1638
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<int>(EEventName.RefreshActivityEntranceScroller, new Action<int>(this.OnSelectActivityEntranceScrollItem));
			EventSystem.Instance.Remove<int>(EEventName.RefreshActivityEntranceItemContent, new Action<int>(this.OnRefreshActivityEntranceItemContent));
			EventSystem.Instance.Remove(EEventName.OnRefreshInstancedRecommendLevel, new Action(this.OnRefreshInstancedRecommendLevel));
		}

		// Token: 0x0603DDA9 RID: 253353 RVA: 0x00EF3499 File Offset: 0x00EF1699
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

		// Token: 0x0603DDAA RID: 253354 RVA: 0x00EF34D4 File Offset: 0x00EF16D4
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

		// Token: 0x0603DDAB RID: 253355 RVA: 0x00EF3528 File Offset: 0x00EF1728
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

		// Token: 0x0603DDAC RID: 253356 RVA: 0x00EF357F File Offset: 0x00EF177F
		private void OnClickCaptionStateBtn()
		{
			HelpController.Instance.OpenHelpById(242);
		}

		// Token: 0x0603DDAD RID: 253357 RVA: 0x00EF3590 File Offset: 0x00EF1790
		protected override void OnBeforeShow()
		{
			this.RefreshScrollView();
		}

		// Token: 0x0603DDAE RID: 253358 RVA: 0x00EF3598 File Offset: 0x00EF1798
		protected override void OnAfterShow()
		{
			this.CheckAndShowDungeonArchiveExpireTips();
		}

		// Token: 0x0603DDAF RID: 253359 RVA: 0x00EF35A0 File Offset: 0x00EF17A0
		private void CheckAndShowDungeonArchiveExpireTips()
		{
			ActivityEntranceSelectItemData activityEntranceSelectItemData = this.ViewData.GetActivityEntranceSelectItemData();
			ActivityEntranceItemData activityEntranceItemData = (activityEntranceSelectItemData != null) ? activityEntranceSelectItemData.GetCurrentSelectData() : null;
			int dungeonId = (activityEntranceItemData != null) ? activityEntranceItemData.GetInstanceDungeonId() : 0;
			InstanceDungeonController.Instance.CheckAndShowDungeonArchiveExpireTips(dungeonId);
		}

		// Token: 0x0603DDB0 RID: 253360 RVA: 0x00EF35DC File Offset: 0x00EF17DC
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

		// Token: 0x0603DDB1 RID: 253361 RVA: 0x00EF36A8 File Offset: 0x00EF18A8
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

		// Token: 0x0603DDB2 RID: 253362 RVA: 0x00EF373C File Offset: 0x00EF193C
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

		// Token: 0x0603DDB3 RID: 253363 RVA: 0x00EF37B2 File Offset: 0x00EF19B2
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

		// Token: 0x0603DDB4 RID: 253364 RVA: 0x00EF37DB File Offset: 0x00EF19DB
		private void OnClickBtnClose()
		{
			this.UiViewSequence.PlaySequencePurely("Close01", true, false);
		}

		// Token: 0x0603DDB5 RID: 253365 RVA: 0x00EF37F0 File Offset: 0x00EF19F0
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

		// Token: 0x0603DDB6 RID: 253366 RVA: 0x00EF3878 File Offset: 0x00EF1A78
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

		// Token: 0x0603DDB7 RID: 253367 RVA: 0x00EF38D9 File Offset: 0x00EF1AD9
		protected override void OnBeforeDestroy()
		{
			if (this.InstanceLoopScroll != null)
			{
				this.InstanceLoopScroll.ClearChildren();
				this.InstanceLoopScroll = null;
			}
		}

		// Token: 0x040204DB RID: 132315
		private ActivityInstanceEntranceData ViewData;

		// Token: 0x040204DC RID: 132316
		private ActivityInstanceEntranceInfoItem ActivityInstanceEntranceInfoItem;

		// Token: 0x040204DD RID: 132317
		private PopupCaptionItem InstanceDungeonCaptionItem;

		// Token: 0x040204DE RID: 132318
		private ActivityInstanceEntranceScoreItem ActivityInstanceEntranceScoreItem;

		// Token: 0x040204DF RID: 132319
		private int CurrentSelectMainUiIndex;

		// Token: 0x040204E0 RID: 132320
		private ActivityInstanceEntranceDynItem InstanceDetectDynamicItem;

		// Token: 0x040204E1 RID: 132321
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private DynamicScrollView<ActivityInstanceEntranceScrollItem, ActivityInstanceEntranceDynItem, ActivityEntranceItemData> InstanceLoopScroll;

		// Token: 0x0200C251 RID: 49745
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0403AB44 RID: 240452
			DynScrollView,
			// Token: 0x0403AB45 RID: 240453
			ScrollItem,
			// Token: 0x0403AB46 RID: 240454
			UiItemEntrance,
			// Token: 0x0403AB47 RID: 240455
			TextureInstanceBG,
			// Token: 0x0403AB48 RID: 240456
			TopItem,
			// Token: 0x0403AB49 RID: 240457
			ContentItem,
			// Token: 0x0403AB4A RID: 240458
			CaptionItem,
			// Token: 0x0403AB4B RID: 240459
			TimeAndCountItem,
			// Token: 0x0403AB4C RID: 240460
			LeftRewardItem
		}
	}
}
