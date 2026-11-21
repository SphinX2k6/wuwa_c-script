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

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A33 RID: 23091
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolQuestView : SolarSchoolChildViewBase
	{
		// Token: 0x17006C78 RID: 27768
		// (get) Token: 0x06038E29 RID: 233001 RVA: 0x00FEDDEA File Offset: 0x00FEBFEA
		public override bool BackgroundVisible
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17006C79 RID: 27769
		// (get) Token: 0x06038E2A RID: 233002 RVA: 0x00FEDDED File Offset: 0x00FEBFED
		public override bool SeasonFxVisible
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06038E2B RID: 233003 RVA: 0x00FEDDF0 File Offset: 0x00FEBFF0
		protected override SolarSchoolRootUiParams CreateRootUiParams()
		{
			return new SolarSchoolRootUiParams
			{
				Caption = new SolarSchoolCaptionParams
				{
					BackVisible = true,
					SetVisible = true,
					TipCostVisible = true,
					HelpGroupId = 701
				}
			};
		}

		// Token: 0x17006C7A RID: 27770
		// (get) Token: 0x06038E2C RID: 233004 RVA: 0x00FEDE22 File Offset: 0x00FEC022
		private bool IsInMultiTouch
		{
			get
			{
				return this.TouchMap.Count > 1;
			}
		}

		// Token: 0x06038E2D RID: 233005 RVA: 0x00FEDE34 File Offset: 0x00FEC034
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIDraggableComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06038E2E RID: 233006 RVA: 0x00FEDF24 File Offset: 0x00FEC124
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSchoolQuestView.<OnBeforeStartAsync>d__34 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSchoolQuestView.<OnBeforeStartAsync>d__34>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038E2F RID: 233007 RVA: 0x00FEDF68 File Offset: 0x00FEC168
		protected override void OnStart()
		{
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(1);
			this.Elasticity = scrollViewWithScrollbar.Elasticity;
		}

		// Token: 0x06038E30 RID: 233008 RVA: 0x00FEDF8C File Offset: 0x00FEC18C
		protected override UniTask OnShowAsyncImplementImplement()
		{
			SolarSchoolQuestView.<OnShowAsyncImplementImplement>d__36 <OnShowAsyncImplementImplement>d__;
			<OnShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnShowAsyncImplementImplement>d__.<>4__this = this;
			<OnShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnShowAsyncImplementImplement>d__.<>t__builder.Start<SolarSchoolQuestView.<OnShowAsyncImplementImplement>d__36>(ref <OnShowAsyncImplementImplement>d__);
			return <OnShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06038E31 RID: 233009 RVA: 0x00FEDFD0 File Offset: 0x00FEC1D0
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.SolarSchoolQuestUnlocked, new Action<int>(this.RefreshQuest));
			EventSystem.Instance.Add<int>(EEventName.SolarSchoolQuestProgressChanged, new Action<int>(this.RefreshQuest));
			EventSystem.Instance.Add<int>(EEventName.SolarSchoolQuestRewardClaimed, new Action<int>(this.RefreshQuest));
		}

		// Token: 0x06038E32 RID: 233010 RVA: 0x00FEE034 File Offset: 0x00FEC234
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<int>(EEventName.SolarSchoolQuestUnlocked, new Action<int>(this.RefreshQuest));
			EventSystem.Instance.Remove<int>(EEventName.SolarSchoolQuestProgressChanged, new Action<int>(this.RefreshQuest));
			EventSystem.Instance.Remove<int>(EEventName.SolarSchoolQuestRewardClaimed, new Action<int>(this.RefreshQuest));
		}

		// Token: 0x06038E33 RID: 233011 RVA: 0x00FEE095 File Offset: 0x00FEC295
		protected override void OnBeforeDestroy()
		{
			AUIBaseActor rootActor = this.RootActor;
			if (rootActor != null)
			{
				rootActor.OnSequencePlayEvent.Unbind();
			}
			this.ContentItem = null;
			this.TouchMap.Clear();
		}

		// Token: 0x06038E34 RID: 233012 RVA: 0x00FEE0BF File Offset: 0x00FEC2BF
		public override void OnTick(float delta)
		{
			this.TickRebuildLayout();
			this.TickScaling();
		}

		// Token: 0x06038E35 RID: 233013 RVA: 0x00FEE0CD File Offset: 0x00FEC2CD
		private SolarSchoolQuestColumnItem CreateQuestColumnItem()
		{
			return new SolarSchoolQuestColumnItem
			{
				ClickCallback = new Action<int>(this.OnQuestClick)
			};
		}

		// Token: 0x06038E36 RID: 233014 RVA: 0x00FEE0E8 File Offset: 0x00FEC2E8
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			int num;
			int num2;
			if (configParams.Length < 3 || configParams[0] != "QuestNode" || !int.TryParse(configParams[1], out num) || num < 0 || !int.TryParse(configParams[2], out num2) || num2 < 0 || num >= this.ColumnList.Count)
			{
				return null;
			}
			SolarSchoolQuestColumnData solarSchoolQuestColumnData = this.ColumnList[num];
			if (num2 >= solarSchoolQuestColumnData.ArrowList.Count)
			{
				return null;
			}
			int questId = solarSchoolQuestColumnData.ArrowList[num2].QuestId;
			SolarSchoolQuestArrowItem valueOrDefault = this.Arrows.GetValueOrDefault(questId);
			UUIItem uuiitem = (valueOrDefault != null) ? valueOrDefault.GetLocateItem() : null;
			if (uuiitem == null)
			{
				return null;
			}
			SolarSchoolQuestLocatingHelper locatingHelper = this.LocatingHelper;
			if (locatingHelper != null)
			{
				locatingHelper.SnapToQuest(uuiitem);
			}
			return new UUIItem[]
			{
				uuiitem,
				uuiitem
			};
		}

		// Token: 0x06038E37 RID: 233015 RVA: 0x00FEE1AC File Offset: 0x00FEC3AC
		private void OnQuestClick(int questId)
		{
			UiManager.Instance.OpenView(EUiViewName.SolarSchoolQuestDetailView, new SolarSchoolQuestDetailViewParam
			{
				QuestId = questId
			}, null);
		}

		// Token: 0x06038E38 RID: 233016 RVA: 0x00FEE1CC File Offset: 0x00FEC3CC
		private void RefreshQuest(int questId)
		{
			if (questId == 0 || this.QuestScroll == null)
			{
				return;
			}
			using (List<SolarSchoolQuestColumnItem>.Enumerator enumerator = this.QuestScroll.GetScrollItemList().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.TryRefreshQuest(questId))
					{
						break;
					}
				}
			}
		}

		// Token: 0x06038E39 RID: 233017 RVA: 0x00FEE234 File Offset: 0x00FEC434
		private UniTask PreparePresentationAsync()
		{
			SolarSchoolQuestView.<PreparePresentationAsync>d__45 <PreparePresentationAsync>d__;
			<PreparePresentationAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PreparePresentationAsync>d__.<>4__this = this;
			<PreparePresentationAsync>d__.<>1__state = -1;
			<PreparePresentationAsync>d__.<>t__builder.Start<SolarSchoolQuestView.<PreparePresentationAsync>d__45>(ref <PreparePresentationAsync>d__);
			return <PreparePresentationAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038E3A RID: 233018 RVA: 0x00FEE278 File Offset: 0x00FEC478
		private void RefreshQuestWidthFix()
		{
			UUIItem uiitem = base.GetScrollViewWithScrollbar(1).GetViewport().GetUIItem();
			UUIItem item = base.GetItem(5);
			float width = uiitem.GetWidth() / this.ContentItem.RelativeScale3D.X * 0.5f;
			item.SetWidth(width);
		}

		// Token: 0x06038E3B RID: 233019 RVA: 0x00FEE2C4 File Offset: 0x00FEC4C4
		[NullableContext(0)]
		private UniTask<bool> WaitForPresentationDelayAsync(float milliseconds)
		{
			SolarSchoolQuestView.<WaitForPresentationDelayAsync>d__47 <WaitForPresentationDelayAsync>d__;
			<WaitForPresentationDelayAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<WaitForPresentationDelayAsync>d__.milliseconds = milliseconds;
			<WaitForPresentationDelayAsync>d__.<>1__state = -1;
			<WaitForPresentationDelayAsync>d__.<>t__builder.Start<SolarSchoolQuestView.<WaitForPresentationDelayAsync>d__47>(ref <WaitForPresentationDelayAsync>d__);
			return <WaitForPresentationDelayAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038E3C RID: 233020 RVA: 0x00FEE308 File Offset: 0x00FEC508
		private UniTask WaitForOpeningLinesAsync()
		{
			SolarSchoolQuestView.<WaitForOpeningLinesAsync>d__48 <WaitForOpeningLinesAsync>d__;
			<WaitForOpeningLinesAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitForOpeningLinesAsync>d__.<>4__this = this;
			<WaitForOpeningLinesAsync>d__.<>1__state = -1;
			<WaitForOpeningLinesAsync>d__.<>t__builder.Start<SolarSchoolQuestView.<WaitForOpeningLinesAsync>d__48>(ref <WaitForOpeningLinesAsync>d__);
			return <WaitForOpeningLinesAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038E3D RID: 233021 RVA: 0x00FEE34C File Offset: 0x00FEC54C
		private int FindInitialLocateQuestId()
		{
			SolarSchoolQuestPresentationPlan presentationPlan = this.PresentationPlan;
			if (presentationPlan == null || !presentationPlan.HasChanges)
			{
				return this.FindDefaultLocateQuestId();
			}
			foreach (SolarSchoolQuestColumnData solarSchoolQuestColumnData in this.ColumnList)
			{
				foreach (SolarSchoolQuestArrowItemData solarSchoolQuestArrowItemData in solarSchoolQuestColumnData.ArrowList)
				{
					if (SolarSchoolGamePlayModel.Instance.QuestData.GetQuestData(solarSchoolQuestArrowItemData.QuestId).QuestFirstShow)
					{
						return solarSchoolQuestArrowItemData.QuestId;
					}
				}
			}
			if (this.ColumnList.Count <= 0 || this.ColumnList[0].ArrowList.Count <= 0)
			{
				return 0;
			}
			return this.ColumnList[0].ArrowList[0].QuestId;
		}

		// Token: 0x06038E3E RID: 233022 RVA: 0x00FEE45C File Offset: 0x00FEC65C
		private void OnQuestSequenceEvent(string sequenceName, string eventName)
		{
			if (eventName != "Sequence_Iine_In")
			{
				return;
			}
			this.RootActor.OnSequencePlayEvent.Unbind();
			List<UniTask> list = new List<UniTask>();
			foreach (SolarSchoolQuestLinePlan solarSchoolQuestLinePlan in this.PresentationPlan.Lines)
			{
				if (solarSchoolQuestLinePlan.Existing != ESolarSchoolQuestLineMask.None)
				{
					list.Add(this.Arrows[solarSchoolQuestLinePlan.QuestId].PlayExistingLinesAsync());
				}
			}
			this.OpeningLinesTask = new UniTask?(UniTask.WhenAll(list));
		}

		// Token: 0x06038E3F RID: 233023 RVA: 0x00FEE504 File Offset: 0x00FEC704
		[NullableContext(0)]
		private UniTask<bool> PlayNewNodesAndLinesAsync([Nullable(1)] SolarSchoolQuestPresentationPlan plan)
		{
			SolarSchoolQuestView.<PlayNewNodesAndLinesAsync>d__51 <PlayNewNodesAndLinesAsync>d__;
			<PlayNewNodesAndLinesAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<PlayNewNodesAndLinesAsync>d__.<>4__this = this;
			<PlayNewNodesAndLinesAsync>d__.plan = plan;
			<PlayNewNodesAndLinesAsync>d__.<>1__state = -1;
			<PlayNewNodesAndLinesAsync>d__.<>t__builder.Start<SolarSchoolQuestView.<PlayNewNodesAndLinesAsync>d__51>(ref <PlayNewNodesAndLinesAsync>d__);
			return <PlayNewNodesAndLinesAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038E40 RID: 233024 RVA: 0x00FEE550 File Offset: 0x00FEC750
		[NullableContext(0)]
		private UniTask<bool> CompleteNewPresentationAsync([Nullable(1)] SolarSchoolQuestPresentationPlan plan)
		{
			SolarSchoolQuestView.<CompleteNewPresentationAsync>d__52 <CompleteNewPresentationAsync>d__;
			<CompleteNewPresentationAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<CompleteNewPresentationAsync>d__.<>4__this = this;
			<CompleteNewPresentationAsync>d__.plan = plan;
			<CompleteNewPresentationAsync>d__.<>1__state = -1;
			<CompleteNewPresentationAsync>d__.<>t__builder.Start<SolarSchoolQuestView.<CompleteNewPresentationAsync>d__52>(ref <CompleteNewPresentationAsync>d__);
			return <CompleteNewPresentationAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038E41 RID: 233025 RVA: 0x00FEE59C File Offset: 0x00FEC79C
		[NullableContext(0)]
		private UniTask<bool> PlayAndMarkUnlockAsync(int questId)
		{
			SolarSchoolQuestView.<PlayAndMarkUnlockAsync>d__53 <PlayAndMarkUnlockAsync>d__;
			<PlayAndMarkUnlockAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<PlayAndMarkUnlockAsync>d__.<>4__this = this;
			<PlayAndMarkUnlockAsync>d__.questId = questId;
			<PlayAndMarkUnlockAsync>d__.<>1__state = -1;
			<PlayAndMarkUnlockAsync>d__.<>t__builder.Start<SolarSchoolQuestView.<PlayAndMarkUnlockAsync>d__53>(ref <PlayAndMarkUnlockAsync>d__);
			return <PlayAndMarkUnlockAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038E42 RID: 233026 RVA: 0x00FEE5E8 File Offset: 0x00FEC7E8
		private int FindDefaultLocateQuestId()
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			SolarSchoolQuestData questData = SolarSchoolGamePlayModel.Instance.QuestData;
			foreach (SolarSchoolQuestColumnData solarSchoolQuestColumnData in this.ColumnList)
			{
				foreach (SolarSchoolQuestArrowItemData solarSchoolQuestArrowItemData in solarSchoolQuestColumnData.ArrowList)
				{
					if (num == 0)
					{
						num = solarSchoolQuestArrowItemData.QuestId;
					}
					SolarSchoolSingleQuestData questData2 = questData.GetQuestData(solarSchoolQuestArrowItemData.QuestId);
					if (questData2 != null && questData2.InShowTime)
					{
						if (questData2.CanClaimProgressReward())
						{
							return solarSchoolQuestArrowItemData.QuestId;
						}
						if (num2 == 0)
						{
							num2 = solarSchoolQuestArrowItemData.QuestId;
						}
						if (num3 == 0 && questData2.IsUnlocked)
						{
							num3 = solarSchoolQuestArrowItemData.QuestId;
						}
					}
				}
			}
			if (num3 != 0)
			{
				return num3;
			}
			if (num2 == 0)
			{
				return num;
			}
			return num2;
		}

		// Token: 0x06038E43 RID: 233027 RVA: 0x00FEE6F0 File Offset: 0x00FEC8F0
		private void TickRebuildLayout()
		{
			if (!this.ScaleDirty)
			{
				return;
			}
			UUIItem contentItem = this.ContentItem;
			if (contentItem != null)
			{
				contentItem.SetUIActive(false);
			}
			UUIItem contentItem2 = this.ContentItem;
			if (contentItem2 != null)
			{
				contentItem2.SetUIActive(true);
			}
			this.ScaleDirty = false;
		}

		// Token: 0x06038E44 RID: 233028 RVA: 0x00FEE726 File Offset: 0x00FEC926
		private void TickScaling()
		{
			if (this.IsScaling)
			{
				this.IsScaling = false;
				return;
			}
			if (!this.HasScaled)
			{
				return;
			}
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(1);
			scrollViewWithScrollbar.SetHorizontal(true);
			scrollViewWithScrollbar.SetVertical(true);
		}

		// Token: 0x06038E45 RID: 233029 RVA: 0x00FEE755 File Offset: 0x00FEC955
		private void OnScaleChanged(float value)
		{
			this.BeginScaling();
			this.ApplyZoomAnchor(value);
			this.ApplyScaleToContent(value);
			this.CurScale = value;
		}

		// Token: 0x06038E46 RID: 233030 RVA: 0x00FEE772 File Offset: 0x00FEC972
		private void InitScale(float value)
		{
			this.ApplyScaleToContent(value);
			this.CurScale = value;
		}

		// Token: 0x06038E47 RID: 233031 RVA: 0x00FEE784 File Offset: 0x00FEC984
		private void ApplyScaleToContent(float value)
		{
			this.ScaleVector.X = value;
			this.ScaleVector.Y = value;
			this.ScaleVector.Z = value;
			UUIItem contentItem = this.ContentItem;
			if (contentItem != null)
			{
				contentItem.SetUIRelativeScale3D(this.ScaleVector);
			}
			this.ScaleDirty = true;
		}

		// Token: 0x06038E48 RID: 233032 RVA: 0x00FEE7D4 File Offset: 0x00FEC9D4
		private void ApplyZoomAnchor(float newScale)
		{
			if (this.ContentItem == null || this.CurScale <= 0f || MathUtils.Instance.IsNearlyEqual((double)newScale, (double)this.CurScale, null))
			{
				return;
			}
			if (!this.HasZoomCenter && !this.TryUseViewportCenterAsZoomCenter())
			{
				return;
			}
			FVector lguispaceAbsolutePosition = this.ContentItem.GetLGUISpaceAbsolutePosition();
			double num = this.ZoomCenter.X - (double)lguispaceAbsolutePosition.X;
			double num2 = this.ZoomCenter.Y - (double)lguispaceAbsolutePosition.Y;
			double num3 = (double)newScale / (double)this.CurScale;
			FVector2D anchorOffset = this.ContentItem.GetAnchorOffset();
			this.ContentItem.SetAnchorOffsetX((float)((double)anchorOffset.X + num * (1.0 - num3)));
			this.ContentItem.SetAnchorOffsetY((float)((double)anchorOffset.Y + num2 * (1.0 - num3)));
		}

		// Token: 0x06038E49 RID: 233033 RVA: 0x00FEE8B8 File Offset: 0x00FECAB8
		private bool TryUseViewportCenterAsZoomCenter()
		{
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(1);
			UUIItem uuiitem;
			if (scrollViewWithScrollbar == null)
			{
				uuiitem = null;
			}
			else
			{
				AUIBaseActor viewport = scrollViewWithScrollbar.GetViewport();
				uuiitem = ((viewport != null) ? viewport.GetUIItem() : null);
			}
			UUIItem uuiitem2 = uuiitem;
			if (uuiitem2 == null)
			{
				return false;
			}
			FVector lguispaceAbsolutePosition = uuiitem2.GetLGUISpaceAbsolutePosition();
			FVector2D pivot = uuiitem2.GetPivot();
			this.ZoomCenter.Set((double)(lguispaceAbsolutePosition.X + (0.5f - pivot.X) * uuiitem2.GetWidth()), (double)(lguispaceAbsolutePosition.Y + (0.5f - pivot.Y) * uuiitem2.GetHeight()));
			return true;
		}

		// Token: 0x06038E4A RID: 233034 RVA: 0x00FEE93C File Offset: 0x00FECB3C
		private void SetScaleByAnchor(float newScale, double centerX, double centerY)
		{
			this.TempViewportPos.Set(centerX, centerY);
			ULGUICanvasScaler canvasScaler = UiLayer.Instance.UiRootItem.GetCanvasScaler();
			FVector2D fvector2D = this.TempViewportPos.ToUeVector2D(false);
			FVector2D fvector2D2 = canvasScaler.ConvertPositionFromViewportToLGUICanvas(fvector2D);
			this.ZoomCenter.Set((double)fvector2D2.X, (double)fvector2D2.Y);
			this.HasZoomCenter = true;
			SolarSchoolMapControlItem mapControl = this.MapControl;
			if (mapControl != null)
			{
				mapControl.SetValue(newScale);
			}
			this.HasZoomCenter = false;
		}

		// Token: 0x06038E4B RID: 233035 RVA: 0x00FEE9B3 File Offset: 0x00FECBB3
		[NullableContext(2)]
		private bool OnPointerBeginDrag(ULGUIPointerEventData _)
		{
			base.GetScrollViewWithScrollbar(1).Elasticity = this.Elasticity;
			return true;
		}

		// Token: 0x06038E4C RID: 233036 RVA: 0x00FEE9C8 File Offset: 0x00FECBC8
		[NullableContext(2)]
		private void OnPointerScroll(ULGUIPointerEventData eventData)
		{
			if (eventData == null || this.MapControl == null)
			{
				return;
			}
			this.BeginScaling();
			this.SetScaleByAnchor(this.MapControl.GetValue() + eventData.scrollAxisValue * 0.1f, (double)eventData.pointerPosition.X, (double)eventData.pointerPosition.Y);
		}

		// Token: 0x06038E4D RID: 233037 RVA: 0x00FEEA1D File Offset: 0x00FECC1D
		private void BeginScaling()
		{
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(1);
			scrollViewWithScrollbar.SetHorizontal(false);
			scrollViewWithScrollbar.SetVertical(false);
			scrollViewWithScrollbar.Elasticity = 0f;
			this.IsScaling = true;
			this.HasScaled = true;
		}

		// Token: 0x06038E4E RID: 233038 RVA: 0x00FEEA4C File Offset: 0x00FECC4C
		private void OnTouch(string touchIdName, InputDistributeDefine.ITouchData touchData, InputIdentification _)
		{
			if (touchData.TouchType == InputDistributeDefine.ETouchType.TouchBegin)
			{
				this.OnTouchBegin(touchData);
				return;
			}
			if (touchData.TouchType == InputDistributeDefine.ETouchType.TouchEnd)
			{
				this.OnTouchEnd(touchData);
				return;
			}
			if (touchData.TouchType == InputDistributeDefine.ETouchType.TouchMove)
			{
				this.OnTouchMove(touchData);
			}
		}

		// Token: 0x06038E4F RID: 233039 RVA: 0x00FEEA7F File Offset: 0x00FECC7F
		private void OnTouchBegin(InputDistributeDefine.ITouchData touchData)
		{
			if (LguiEventSystemManager.Instance.IsPressComponentIsValid(touchData.TouchId))
			{
				this.TouchMap[touchData.TouchId] = touchData;
			}
			this.RefreshTouchCenter();
		}

		// Token: 0x06038E50 RID: 233040 RVA: 0x00FEEAAB File Offset: 0x00FECCAB
		private void OnTouchEnd(InputDistributeDefine.ITouchData touchData)
		{
			this.TouchMap.Remove(touchData.TouchId);
			this.RefreshTouchCenter();
		}

		// Token: 0x06038E51 RID: 233041 RVA: 0x00FEEAC8 File Offset: 0x00FECCC8
		private void OnTouchMove(InputDistributeDefine.ITouchData touchData)
		{
			if (this.TouchMap.ContainsKey(touchData.TouchId))
			{
				this.TouchMap[touchData.TouchId] = touchData;
				this.RefreshTouchCenter();
			}
			if (!this.IsInMultiTouch || this.MapControl == null)
			{
				return;
			}
			ValueTuple<EFingerExpandCloseType, float> fingerExpandCloseType = TouchFingerManager.Instance.GetFingerExpandCloseType(EFingerIndex.One, EFingerIndex.Two);
			EFingerExpandCloseType item = fingerExpandCloseType.Item1;
			float item2 = fingerExpandCloseType.Item2;
			if (item == EFingerExpandCloseType.None)
			{
				return;
			}
			this.BeginScaling();
			this.SetScaleByAnchor(this.MapControl.GetValue() + item2, this.TouchCenter.X, this.TouchCenter.Y);
		}

		// Token: 0x06038E52 RID: 233042 RVA: 0x00FEEB60 File Offset: 0x00FECD60
		private void RefreshTouchCenter()
		{
			this.TouchCenter.Reset();
			foreach (InputDistributeDefine.ITouchData touchData in this.TouchMap.Values)
			{
				this.TempTouchVector.Set(touchData.TouchPosition.X, touchData.TouchPosition.Y, 0.0);
				this.TouchCenter.AdditionEqual(this.TempTouchVector);
			}
			if (this.TouchMap.Count > 0)
			{
				this.TouchCenter.DivisionEqual((double)this.TouchMap.Count);
			}
		}

		// Token: 0x0401DEEA RID: 122602
		private const float TickInterval = 100f;

		// Token: 0x0401DEEB RID: 122603
		[Nullable(2)]
		private SolarSchoolMapControlItem MapControl;

		// Token: 0x0401DEEC RID: 122604
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<SolarSchoolQuestColumnItem, SolarSchoolQuestColumnData> QuestScroll;

		// Token: 0x0401DEED RID: 122605
		private List<SolarSchoolQuestColumnData> ColumnList = new List<SolarSchoolQuestColumnData>();

		// Token: 0x0401DEEE RID: 122606
		private readonly Dictionary<int, SolarSchoolQuestArrowItem> Arrows = new Dictionary<int, SolarSchoolQuestArrowItem>();

		// Token: 0x0401DEEF RID: 122607
		[Nullable(2)]
		private SolarSchoolQuestPresentationPlan PresentationPlan;

		// Token: 0x0401DEF0 RID: 122608
		[Nullable(2)]
		private SolarSchoolQuestLocatingHelper LocatingHelper;

		// Token: 0x0401DEF1 RID: 122609
		private UniTask? OpeningLinesTask;

		// Token: 0x0401DEF2 RID: 122610
		private bool HasOpened;

		// Token: 0x0401DEF3 RID: 122611
		private const string LineEventName = "Sequence_Iine_In";

		// Token: 0x0401DEF4 RID: 122612
		private const string PresentationMask = "SolarSchoolQuestPresentation";

		// Token: 0x0401DEF5 RID: 122613
		private const bool EnableScale = false;

		// Token: 0x0401DEF6 RID: 122614
		[Nullable(2)]
		private UUIItem ContentItem;

		// Token: 0x0401DEF7 RID: 122615
		private FVector ScaleVector = new FVector(1f, 1f, 1f);

		// Token: 0x0401DEF8 RID: 122616
		private float CurScale = 1f;

		// Token: 0x0401DEF9 RID: 122617
		private readonly Vector2D ZoomCenter = Vector2D.Create();

		// Token: 0x0401DEFA RID: 122618
		private bool HasZoomCenter;

		// Token: 0x0401DEFB RID: 122619
		private readonly Vector2D TempViewportPos = Vector2D.Create();

		// Token: 0x0401DEFC RID: 122620
		private bool ScaleDirty;

		// Token: 0x0401DEFD RID: 122621
		private float Elasticity;

		// Token: 0x0401DEFE RID: 122622
		private bool IsScaling;

		// Token: 0x0401DEFF RID: 122623
		private bool HasScaled;

		// Token: 0x0401DF00 RID: 122624
		private readonly Dictionary<int, InputDistributeDefine.ITouchData> TouchMap = new Dictionary<int, InputDistributeDefine.ITouchData>();

		// Token: 0x0401DF01 RID: 122625
		private readonly Vector TouchCenter = Vector.Create();

		// Token: 0x0401DF02 RID: 122626
		private readonly Vector TempTouchVector = Vector.Create();

		// Token: 0x0200B612 RID: 46610
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x040384D9 RID: 230617
			public const int Root = 0;

			// Token: 0x040384DA RID: 230618
			public const int ScrollTask = 1;

			// Token: 0x040384DB RID: 230619
			public const int QuestList = 2;

			// Token: 0x040384DC RID: 230620
			public const int MapControl = 3;

			// Token: 0x040384DD RID: 230621
			public const int DraggableComponent = 4;

			// Token: 0x040384DE RID: 230622
			public const int WidthFix = 5;
		}
	}
}
