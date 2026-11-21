using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Module.QuestMultiLine.QuestMultiLineData;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.QuestMultiLine.View.Items
{
	// Token: 0x02003F83 RID: 16259
	[NullableContext(1)]
	[Nullable(0)]
	public class QuestMultiLineMapPanel : UiPanelBase
	{
		// Token: 0x06029239 RID: 168505 RVA: 0x00B8CBA4 File Offset: 0x00B8ADA4
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUITexture)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIItem)),
				new ValueTuple<int, Type>(9, typeof(UUINiagara)),
				new ValueTuple<int, Type>(10, typeof(UUIItem))
			};
		}

		// Token: 0x0602923A RID: 168506 RVA: 0x00B8CCB0 File Offset: 0x00B8AEB0
		protected override void OnStart()
		{
			this.PathItem = base.GetItem(10);
			this.PathItem.SetUIActive(false);
			this.PathItemParent = base.GetItem(0);
			this.InitMapMove();
		}

		// Token: 0x0602923B RID: 168507 RVA: 0x00B8CCDF File Offset: 0x00B8AEDF
		protected override void OnBeforeDestroy()
		{
			this.StopComponentMoveAlongPath();
			this.StopAllPathDraw();
			this.DestroyMapMove();
		}

		// Token: 0x0602923C RID: 168508 RVA: 0x00B8CCF4 File Offset: 0x00B8AEF4
		public void RefreshFightArea(Dictionary<int, bool> fightAreaMap)
		{
			int num = 3;
			for (int i = 0; i < 6; i++)
			{
				int name = num + i;
				UUIItem item = base.GetItem(name);
				if (item != null)
				{
					item.SetUIActive(fightAreaMap.GetValueOrDefault(i + 1, false));
				}
			}
		}

		// Token: 0x0602923D RID: 168509 RVA: 0x00B8CD30 File Offset: 0x00B8AF30
		private void InitMapMove()
		{
			this.MapDraggableItem = base.GetItem(0);
			if (this.MapDraggableItem == null)
			{
				return;
			}
			AActor owner = this.MapDraggableItem.GetOwner();
			UUIDraggableComponent uuidraggableComponent = ((owner != null) ? owner.GetComponentByClass(UUIDraggableComponent.StaticClass()) : null) as UUIDraggableComponent;
			if (uuidraggableComponent == null)
			{
				return;
			}
			UUITexture texture = base.GetTexture(1);
			if (texture != null)
			{
				UUIItem uuiitem = texture;
				FVector fvector = new FVector(1f, 1f, 1f);
				uuiitem.SetUIRelativeScale3D(fvector);
			}
			this.ComputeCenterBounds();
			this.MoveComponent = new QuestMultiLineMapMoveComponent(uuidraggableComponent);
			this.MoveComponent.PointerUpExtraCallBack = new Action<ULGUIPointerEventData>(this.OnMapMoveEnd);
			this.RefreshMoveSpeed();
			this.CenterDelegate = DelegateUtils.ToManualReleaseDelegate<FLTweenVector2SetterDynamic>(new Action<FVector2D>(this.OnCenterTweenUpdate));
			FVector2D anchorOffset = this.MapDraggableItem.GetAnchorOffset();
			this.LastAnchorOffsetX = anchorOffset.X;
			this.LastAnchorOffsetY = anchorOffset.Y;
		}

		// Token: 0x0602923E RID: 168510 RVA: 0x00B8CE10 File Offset: 0x00B8B010
		private void ComputeCenterBounds()
		{
			int num = Math.Max(0, ConfigCommonParamById.GetIntConfig("QuestMultiLineDragOffsetX").GetValueOrDefault(100));
			int num2 = Math.Max(0, ConfigCommonParamById.GetIntConfig("QuestMultiLineDragOffsetY").GetValueOrDefault(100));
			this.CenterSafeArea.MinX = (float)(-(float)num);
			this.CenterSafeArea.MaxX = (float)num;
			this.CenterSafeArea.MinY = (float)(-(float)num2);
			this.CenterSafeArea.MaxY = (float)num2;
		}

		// Token: 0x0602923F RID: 168511 RVA: 0x00B8CE8C File Offset: 0x00B8B08C
		public void MapShow()
		{
			if (this.MoveComponent == null || this.IsMapInputBound)
			{
				return;
			}
			this.MoveComponent.AddGamepadEvent();
			this.MoveComponent.AddMoveListener(true, false);
			EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
			this.IsMapInputBound = true;
		}

		// Token: 0x06029240 RID: 168512 RVA: 0x00B8CEE8 File Offset: 0x00B8B0E8
		public void OnTick(float delta)
		{
			if (this.MoveComponent == null || this.MapDraggableItem == null)
			{
				return;
			}
			this.MoveComponent.TickMove();
			FVector2D anchorOffset = this.MapDraggableItem.GetAnchorOffset();
			if (anchorOffset.X != this.LastAnchorOffsetX || anchorOffset.Y != this.LastAnchorOffsetY)
			{
				this.LastAnchorOffsetX = anchorOffset.X;
				this.LastAnchorOffsetY = anchorOffset.Y;
				this.RefreshAllDialogueSides();
			}
		}

		// Token: 0x06029241 RID: 168513 RVA: 0x00B8CF58 File Offset: 0x00B8B158
		public void MapHide()
		{
			if (this.MoveComponent == null || !this.IsMapInputBound)
			{
				return;
			}
			this.MoveComponent.RemoveGamepadEvent();
			this.MoveComponent.RemoveMoveListener();
			EventSystem.Instance.Remove(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
			this.IsMapInputBound = false;
		}

		// Token: 0x06029242 RID: 168514 RVA: 0x00B8CFB0 File Offset: 0x00B8B1B0
		private void RefreshMoveSpeed()
		{
			if (this.MoveComponent == null)
			{
				return;
			}
			if (Info.Instance.IsInGamepad())
			{
				this.MoveComponent.MoveSpeed = ConfigCommonParamById.GetFloatConfig("QuestMultiLineMapMoveSpeedGamepad").GetValueOrDefault(1f);
				return;
			}
			if (Info.Instance.IsInKeyBoard())
			{
				this.MoveComponent.MoveSpeed = ConfigCommonParamById.GetFloatConfig("QuestMultiLineMapMoveSpeedKeyboard").GetValueOrDefault(1f);
			}
		}

		// Token: 0x06029243 RID: 168515 RVA: 0x00B8D023 File Offset: 0x00B8B223
		private void OnInputControllerChange(EInputControllerType last, EInputControllerType now)
		{
			this.RefreshMoveSpeed();
		}

		// Token: 0x06029244 RID: 168516 RVA: 0x00B8D02B File Offset: 0x00B8B22B
		private void OnMapMoveEnd(ULGUIPointerEventData eventData)
		{
			this.RefreshAllDialogueSides();
		}

		// Token: 0x06029245 RID: 168517 RVA: 0x00B8D033 File Offset: 0x00B8B233
		private void OnCenterTweenUpdate(FVector2D value)
		{
			UUIItem mapDraggableItem = this.MapDraggableItem;
			if (mapDraggableItem != null)
			{
				mapDraggableItem.SetAnchorOffset(value);
			}
			this.RefreshAllDialogueSides();
		}

		// Token: 0x06029246 RID: 168518 RVA: 0x00B8D04D File Offset: 0x00B8B24D
		private void KillCenterTweener()
		{
			if (this.CenterTweener != null)
			{
				this.CenterTweener.Kill(false);
				this.CenterTweener = null;
			}
		}

		// Token: 0x06029247 RID: 168519 RVA: 0x00B8D06C File Offset: 0x00B8B26C
		private void RefreshAllDialogueSides()
		{
			if (this.ComponentItems == null)
			{
				return;
			}
			foreach (QuestMultiLineComponentItem questMultiLineComponentItem in this.ComponentItems)
			{
				questMultiLineComponentItem.RefreshDialogueSide();
			}
		}

		// Token: 0x06029248 RID: 168520 RVA: 0x00B8D0C8 File Offset: 0x00B8B2C8
		private void DestroyMapMove()
		{
			this.KillCenterTweener();
			this.MapHide();
			QuestMultiLineMapMoveComponent moveComponent = this.MoveComponent;
			if (moveComponent != null)
			{
				moveComponent.Destroy();
			}
			this.MoveComponent = null;
			if (this.CenterDelegate != null)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(new Action<FVector2D>(this.OnCenterTweenUpdate));
				this.CenterDelegate = null;
			}
		}

		// Token: 0x06029249 RID: 168521 RVA: 0x00B8D11C File Offset: 0x00B8B31C
		private UniTask ClearComponents()
		{
			QuestMultiLineMapPanel.<ClearComponents>d__34 <ClearComponents>d__;
			<ClearComponents>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ClearComponents>d__.<>4__this = this;
			<ClearComponents>d__.<>1__state = -1;
			<ClearComponents>d__.<>t__builder.Start<QuestMultiLineMapPanel.<ClearComponents>d__34>(ref <ClearComponents>d__);
			return <ClearComponents>d__.<>t__builder.Task;
		}

		// Token: 0x0602924A RID: 168522 RVA: 0x00B8D160 File Offset: 0x00B8B360
		private UniTask ClearPathItems()
		{
			QuestMultiLineMapPanel.<ClearPathItems>d__35 <ClearPathItems>d__;
			<ClearPathItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ClearPathItems>d__.<>4__this = this;
			<ClearPathItems>d__.<>1__state = -1;
			<ClearPathItems>d__.<>t__builder.Start<QuestMultiLineMapPanel.<ClearPathItems>d__35>(ref <ClearPathItems>d__);
			return <ClearPathItems>d__.<>t__builder.Task;
		}

		// Token: 0x0602924B RID: 168523 RVA: 0x00B8D1A4 File Offset: 0x00B8B3A4
		public UniTask RefreshComponents(List<QuestMultiLineComponentData> components)
		{
			QuestMultiLineMapPanel.<RefreshComponents>d__36 <RefreshComponents>d__;
			<RefreshComponents>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshComponents>d__.<>4__this = this;
			<RefreshComponents>d__.components = components;
			<RefreshComponents>d__.<>1__state = -1;
			<RefreshComponents>d__.<>t__builder.Start<QuestMultiLineMapPanel.<RefreshComponents>d__36>(ref <RefreshComponents>d__);
			return <RefreshComponents>d__.<>t__builder.Task;
		}

		// Token: 0x0602924C RID: 168524 RVA: 0x00B8D1F0 File Offset: 0x00B8B3F0
		public UniTask DrawComponentMovePath(List<QuestMultiLineComponentData> components)
		{
			QuestMultiLineMapPanel.<DrawComponentMovePath>d__37 <DrawComponentMovePath>d__;
			<DrawComponentMovePath>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<DrawComponentMovePath>d__.<>4__this = this;
			<DrawComponentMovePath>d__.components = components;
			<DrawComponentMovePath>d__.<>1__state = -1;
			<DrawComponentMovePath>d__.<>t__builder.Start<QuestMultiLineMapPanel.<DrawComponentMovePath>d__37>(ref <DrawComponentMovePath>d__);
			return <DrawComponentMovePath>d__.<>t__builder.Task;
		}

		// Token: 0x0602924D RID: 168525 RVA: 0x00B8D23C File Offset: 0x00B8B43C
		public void StopComponentMoveAlongPath()
		{
			foreach (TimerHandle timerHandle in this.ComponentMoveTimerHandles.Values)
			{
				timerHandle.Remove();
			}
			this.ComponentMoveTimerHandles.Clear();
			foreach (Action action in this.ComponentMoveAbortCallbackMap.Values)
			{
				action();
			}
			this.ComponentMoveAbortCallbackMap.Clear();
		}

		// Token: 0x0602924E RID: 168526 RVA: 0x00B8D2EC File Offset: 0x00B8B4EC
		public void PlayComponentMoveAlongPath(QuestMultiLineComponentData componentData, float? speedUiPxPerSec = null, [Nullable(2)] Action onComplete = null)
		{
			QuestMultiLineMapPanel.<>c__DisplayClass39_0 CS$<>8__locals1 = new QuestMultiLineMapPanel.<>c__DisplayClass39_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.onComplete = onComplete;
			CS$<>8__locals1.componentId = componentData.Id;
			TimerHandle timerHandle;
			if (this.ComponentMoveTimerHandles.TryGetValue(CS$<>8__locals1.componentId, out timerHandle))
			{
				timerHandle.Remove();
				this.ComponentMoveTimerHandles.Remove(CS$<>8__locals1.componentId);
			}
			float num = speedUiPxPerSec ?? ((float)componentData.MoveSpeed);
			List<QuestMultiLineComponentData> components = this.Components;
			int num2 = (components != null) ? components.FindIndex((QuestMultiLineComponentData c) => c.Id == CS$<>8__locals1.componentId) : -1;
			if (num2 < 0 || this.ComponentItems == null || num2 >= this.ComponentItems.Count)
			{
				return;
			}
			IntVector2D[] animMovePoint = componentData.AnimMovePoint;
			if (animMovePoint == null || animMovePoint.Length < 2)
			{
				return;
			}
			CS$<>8__locals1.curve = new CatmullRomCurve(animMovePoint);
			CS$<>8__locals1.arcLengthLookup = CatmullRomCurve.CreateArcLengthLookup(CS$<>8__locals1.curve, 100);
			CS$<>8__locals1.rootItem = this.ComponentItems[num2].GetRootItem();
			if (num <= 0f)
			{
				CS$<>8__locals1.<PlayComponentMoveAlongPath>g__ApplyPoint|1(1f);
				Action onComplete2 = CS$<>8__locals1.onComplete;
				if (onComplete2 == null)
				{
					return;
				}
				onComplete2();
				return;
			}
			else
			{
				CS$<>8__locals1.<PlayComponentMoveAlongPath>g__ApplyPoint|1(0f);
				CS$<>8__locals1.totalArcLength = CS$<>8__locals1.arcLengthLookup.TotalLength;
				if (CS$<>8__locals1.totalArcLength > 0.0)
				{
					CS$<>8__locals1.speedAlongCurvePxPerMs = num / 1000f;
					CS$<>8__locals1.traveledArcLength = 0.0;
					TimerHandle timerHandle2 = TimerSystem.Instance.Forever(delegate(float delta)
					{
						CS$<>8__locals1.traveledArcLength = Math.Min(CS$<>8__locals1.totalArcLength, CS$<>8__locals1.traveledArcLength + (double)(CS$<>8__locals1.speedAlongCurvePxPerMs * delta));
						double parameterByArcLength = CatmullRomCurve.GetParameterByArcLength(CS$<>8__locals1.arcLengthLookup, CS$<>8__locals1.traveledArcLength);
						base.<PlayComponentMoveAlongPath>g__ApplyPoint|1((float)parameterByArcLength);
						if (CS$<>8__locals1.traveledArcLength >= CS$<>8__locals1.totalArcLength)
						{
							TimerHandle timerHandle3;
							if (CS$<>8__locals1.<>4__this.ComponentMoveTimerHandles.TryGetValue(CS$<>8__locals1.componentId, out timerHandle3))
							{
								timerHandle3.Remove();
							}
							CS$<>8__locals1.<>4__this.ComponentMoveTimerHandles.Remove(CS$<>8__locals1.componentId);
							Action onComplete4 = CS$<>8__locals1.onComplete;
							if (onComplete4 == null)
							{
								return;
							}
							onComplete4();
						}
					}, 20f, 1f, null, "QuestMultiLineMapPanel.ComponentMoveCatmullRom", true);
					if (timerHandle2 != null)
					{
						this.ComponentMoveTimerHandles[CS$<>8__locals1.componentId] = timerHandle2;
					}
					return;
				}
				CS$<>8__locals1.<PlayComponentMoveAlongPath>g__ApplyPoint|1(1f);
				Action onComplete3 = CS$<>8__locals1.onComplete;
				if (onComplete3 == null)
				{
					return;
				}
				onComplete3();
				return;
			}
		}

		// Token: 0x0602924F RID: 168527 RVA: 0x00B8D4B4 File Offset: 0x00B8B6B4
		public UniTask DrawDebugPath(IReadOnlyList<global::Vector> points)
		{
			QuestMultiLineMapPanel.<DrawDebugPath>d__40 <DrawDebugPath>d__;
			<DrawDebugPath>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<DrawDebugPath>d__.<>4__this = this;
			<DrawDebugPath>d__.points = points;
			<DrawDebugPath>d__.<>1__state = -1;
			<DrawDebugPath>d__.<>t__builder.Start<QuestMultiLineMapPanel.<DrawDebugPath>d__40>(ref <DrawDebugPath>d__);
			return <DrawDebugPath>d__.<>t__builder.Task;
		}

		// Token: 0x06029250 RID: 168528 RVA: 0x00B8D500 File Offset: 0x00B8B700
		public void HideComponentsPath()
		{
			foreach (QuestMultiLinePathItem questMultiLinePathItem in this.PathItems)
			{
				questMultiLinePathItem.SetUiActive(false);
			}
		}

		// Token: 0x06029251 RID: 168529 RVA: 0x00B8D554 File Offset: 0x00B8B754
		public void ClearAllComponentSelection()
		{
			if (this.ComponentItems == null)
			{
				return;
			}
			foreach (QuestMultiLineComponentItem questMultiLineComponentItem in this.ComponentItems)
			{
				questMultiLineComponentItem.RefreshSelected(false);
			}
		}

		// Token: 0x06029252 RID: 168530 RVA: 0x00B8D5B0 File Offset: 0x00B8B7B0
		public void RefreshFullScreenNiagara(bool isActive, string path)
		{
			UUINiagara uiNiagara = base.GetUiNiagara(9);
			if (uiNiagara != null)
			{
				uiNiagara.SetUIActive(isActive);
			}
			if (isActive)
			{
				base.SetNiagaraSystemByPath(path, uiNiagara, null);
			}
		}

		// Token: 0x06029253 RID: 168531 RVA: 0x00B8D5DC File Offset: 0x00B8B7DC
		public void HideAllForSequencer()
		{
			if (this.ComponentItems != null)
			{
				foreach (QuestMultiLineComponentItem questMultiLineComponentItem in this.ComponentItems)
				{
					questMultiLineComponentItem.SetVisibleForAnim(false);
				}
			}
			foreach (QuestMultiLinePathItem questMultiLinePathItem in this.PathItems)
			{
				questMultiLinePathItem.SetVisibleForAnim(false);
			}
			int num = 3;
			for (int i = 0; i < 6; i++)
			{
				UUIItem item = base.GetItem(num + i);
				if (item != null)
				{
					item.SetUIActive(false);
				}
			}
			UUINiagara uiNiagara = base.GetUiNiagara(9);
			if (uiNiagara == null)
			{
				return;
			}
			uiNiagara.SetUIActive(false);
		}

		// Token: 0x06029254 RID: 168532 RVA: 0x00B8D6AC File Offset: 0x00B8B8AC
		public UniTask PlayComponentAppearAsync(QuestMultiLineComponentData componentData)
		{
			QuestMultiLineMapPanel.<PlayComponentAppearAsync>d__45 <PlayComponentAppearAsync>d__;
			<PlayComponentAppearAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayComponentAppearAsync>d__.<>4__this = this;
			<PlayComponentAppearAsync>d__.componentData = componentData;
			<PlayComponentAppearAsync>d__.<>1__state = -1;
			<PlayComponentAppearAsync>d__.<>t__builder.Start<QuestMultiLineMapPanel.<PlayComponentAppearAsync>d__45>(ref <PlayComponentAppearAsync>d__);
			return <PlayComponentAppearAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06029255 RID: 168533 RVA: 0x00B8D6F8 File Offset: 0x00B8B8F8
		public UniTask PlayPathAppearAsync(QuestMultiLineComponentData componentData)
		{
			QuestMultiLineMapPanel.<PlayPathAppearAsync>d__46 <PlayPathAppearAsync>d__;
			<PlayPathAppearAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayPathAppearAsync>d__.<>4__this = this;
			<PlayPathAppearAsync>d__.componentData = componentData;
			<PlayPathAppearAsync>d__.<>1__state = -1;
			<PlayPathAppearAsync>d__.<>t__builder.Start<QuestMultiLineMapPanel.<PlayPathAppearAsync>d__46>(ref <PlayPathAppearAsync>d__);
			return <PlayPathAppearAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06029256 RID: 168534 RVA: 0x00B8D744 File Offset: 0x00B8B944
		public void StopAllPathDraw()
		{
			foreach (QuestMultiLinePathItem questMultiLinePathItem in this.PathItemMap.Values)
			{
				questMultiLinePathItem.StopDraw();
			}
			foreach (Action action in this.PathDrawAbortCallbackMap.Values)
			{
				action();
			}
			this.PathDrawAbortCallbackMap.Clear();
		}

		// Token: 0x06029257 RID: 168535 RVA: 0x00B8D7E8 File Offset: 0x00B8B9E8
		public UniTask PlayComponentMoveAlongPathAsync(QuestMultiLineComponentData componentData, float? speedUiPxPerSec = null)
		{
			QuestMultiLineMapPanel.<PlayComponentMoveAlongPathAsync>d__48 <PlayComponentMoveAlongPathAsync>d__;
			<PlayComponentMoveAlongPathAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayComponentMoveAlongPathAsync>d__.<>4__this = this;
			<PlayComponentMoveAlongPathAsync>d__.componentData = componentData;
			<PlayComponentMoveAlongPathAsync>d__.speedUiPxPerSec = speedUiPxPerSec;
			<PlayComponentMoveAlongPathAsync>d__.<>1__state = -1;
			<PlayComponentMoveAlongPathAsync>d__.<>t__builder.Start<QuestMultiLineMapPanel.<PlayComponentMoveAlongPathAsync>d__48>(ref <PlayComponentMoveAlongPathAsync>d__);
			return <PlayComponentMoveAlongPathAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06029258 RID: 168536 RVA: 0x00B8D83C File Offset: 0x00B8BA3C
		public void ShowFightArea(int areaId)
		{
			if (areaId < 1 || areaId > 6)
			{
				return;
			}
			int num = 3;
			UUIItem item = base.GetItem(num + (areaId - 1));
			if (item == null)
			{
				return;
			}
			item.SetUIActive(true);
		}

		// Token: 0x06029259 RID: 168537 RVA: 0x00B8D86A File Offset: 0x00B8BA6A
		public void ShowScreenEffectInstant(string screenEffectPath)
		{
			this.RefreshFullScreenNiagara(!string.IsNullOrEmpty(screenEffectPath), screenEffectPath);
		}

		// Token: 0x0602925A RID: 168538 RVA: 0x00B8D87C File Offset: 0x00B8BA7C
		public Action ApplyZoomPivotOnComponent(QuestMultiLineComponentData componentData)
		{
			Action result = delegate()
			{
			};
			if (this.MapDraggableItem == null)
			{
				return result;
			}
			List<QuestMultiLineComponentData> components = this.Components;
			int num = (components != null) ? components.FindIndex((QuestMultiLineComponentData c) => c.Id == componentData.Id) : -1;
			if (num < 0 || this.ComponentItems == null || num >= this.ComponentItems.Count)
			{
				return result;
			}
			UUIItem draggable = this.MapDraggableItem;
			FVector2D oldPivot = draggable.GetPivot();
			UUIItem draggable3 = draggable;
			FVector2D fvector2D = new FVector2D(0f, 0f);
			FVector lguispaceAbsolutePositionByPivot = draggable3.GetLGUISpaceAbsolutePositionByPivot(fvector2D);
			UUIItem draggable2 = draggable;
			fvector2D = new FVector2D(1f, 1f);
			FVector lguispaceAbsolutePositionByPivot2 = draggable2.GetLGUISpaceAbsolutePositionByPivot(fvector2D);
			FVector lguispaceCenterAbsolutePosition = this.ComponentItems[num].GetRootItem().GetLGUISpaceCenterAbsolutePosition();
			float num2 = lguispaceAbsolutePositionByPivot2.X - lguispaceAbsolutePositionByPivot.X;
			float num3 = lguispaceAbsolutePositionByPivot2.Y - lguispaceAbsolutePositionByPivot.Y;
			if ((double)Math.Abs(num2) < 0.001 || (double)Math.Abs(num3) < 0.001)
			{
				return result;
			}
			FVector2D pivot = new FVector2D(QuestMultiLineUtils.ClampValue((lguispaceCenterAbsolutePosition.X - lguispaceAbsolutePositionByPivot.X) / num2, 0f, 1f), QuestMultiLineUtils.ClampValue((lguispaceCenterAbsolutePosition.Y - lguispaceAbsolutePositionByPivot.Y) / num3, 0f, 1f));
			draggable.SetPivot(pivot);
			return delegate()
			{
				if (this.MapDraggableItem == draggable)
				{
					draggable.SetPivot(oldPivot);
				}
			};
		}

		// Token: 0x0602925B RID: 168539 RVA: 0x00B8DA1C File Offset: 0x00B8BC1C
		public UniTask PanMapToCenterOnComponentAsync(QuestMultiLineComponentData componentData, bool clampToSafeArea = true)
		{
			QuestMultiLineMapPanel.<PanMapToCenterOnComponentAsync>d__52 <PanMapToCenterOnComponentAsync>d__;
			<PanMapToCenterOnComponentAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PanMapToCenterOnComponentAsync>d__.<>4__this = this;
			<PanMapToCenterOnComponentAsync>d__.componentData = componentData;
			<PanMapToCenterOnComponentAsync>d__.clampToSafeArea = clampToSafeArea;
			<PanMapToCenterOnComponentAsync>d__.<>1__state = -1;
			<PanMapToCenterOnComponentAsync>d__.<>t__builder.Start<QuestMultiLineMapPanel.<PanMapToCenterOnComponentAsync>d__52>(ref <PanMapToCenterOnComponentAsync>d__);
			return <PanMapToCenterOnComponentAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602925C RID: 168540 RVA: 0x00B8DA70 File Offset: 0x00B8BC70
		public void PlayAllComponentsAppearStart()
		{
			if (this.ComponentItems == null)
			{
				return;
			}
			foreach (QuestMultiLineComponentItem questMultiLineComponentItem in this.ComponentItems)
			{
				questMultiLineComponentItem.PlayAppearAsync();
			}
		}

		// Token: 0x0602925D RID: 168541 RVA: 0x00B8DACC File Offset: 0x00B8BCCC
		[NullableContext(2)]
		private QuestMultiLineComponentItem FindComponentItem(int componentId)
		{
			if (this.Components == null || this.ComponentItems == null)
			{
				return null;
			}
			int num = this.Components.FindIndex((QuestMultiLineComponentData c) => c.Id == componentId);
			if (num < 0)
			{
				return null;
			}
			return this.ComponentItems[num];
		}

		// Token: 0x0602925E RID: 168542 RVA: 0x00B8DB22 File Offset: 0x00B8BD22
		public void SetComponentFunction(Action<QuestMultiLineComponentData> componentFunction)
		{
			this.ComponentFunction = componentFunction;
		}

		// Token: 0x0602925F RID: 168543 RVA: 0x00B8DB2C File Offset: 0x00B8BD2C
		public void SetComponentsClickable(bool clickable)
		{
			if (this.ComponentItems == null)
			{
				return;
			}
			foreach (QuestMultiLineComponentItem questMultiLineComponentItem in this.ComponentItems)
			{
				questMultiLineComponentItem.SetClickable(clickable);
			}
		}

		// Token: 0x06029260 RID: 168544 RVA: 0x00B8DB88 File Offset: 0x00B8BD88
		public void RefreshComponentsClickable()
		{
			if (this.ComponentItems == null || this.Components == null)
			{
				return;
			}
			int num = 0;
			while (num < this.ComponentItems.Count && num < this.Components.Count)
			{
				QuestMultiLineComponentData questMultiLineComponentData = this.Components[num];
				if (questMultiLineComponentData != null)
				{
					this.ComponentItems[num].SetClickable(QuestMultiLineUtils.IsComponentClickable(questMultiLineComponentData));
				}
				num++;
			}
		}

		// Token: 0x06029261 RID: 168545 RVA: 0x00B8DBF4 File Offset: 0x00B8BDF4
		public void PanMapToCenterOnComponent(QuestMultiLineComponentData componentData, bool clampToSafeArea = true)
		{
			if (this.MapDraggableItem == null || UiLayer.Instance.UiRootItem == null)
			{
				return;
			}
			List<QuestMultiLineComponentData> components = this.Components;
			int num = (components != null) ? components.FindIndex((QuestMultiLineComponentData c) => c.Id == componentData.Id) : -1;
			if (num < 0 || this.ComponentItems == null || num >= this.ComponentItems.Count)
			{
				return;
			}
			FVector lguispaceCenterAbsolutePosition = this.ComponentItems[num].GetRootItem().GetLGUISpaceCenterAbsolutePosition();
			FVector lguispaceCenterAbsolutePosition2 = UiLayer.Instance.UiRootItem.GetLGUISpaceCenterAbsolutePosition();
			float num2 = lguispaceCenterAbsolutePosition2.X - lguispaceCenterAbsolutePosition.X;
			float num3 = lguispaceCenterAbsolutePosition2.Y - lguispaceCenterAbsolutePosition.Y;
			if (num2 == 0f && num3 == 0f)
			{
				return;
			}
			this.KillCenterTweener();
			FVector2D anchorOffset = this.MapDraggableItem.GetAnchorOffset();
			float num4 = anchorOffset.X + num2;
			float num5 = anchorOffset.Y + num3;
			if (clampToSafeArea)
			{
				num4 = QuestMultiLineUtils.ClampValue(num4, this.CenterSafeArea.MinX, this.CenterSafeArea.MaxX);
				num5 = QuestMultiLineUtils.ClampValue(num5, this.CenterSafeArea.MinY, this.CenterSafeArea.MaxY);
			}
			if (anchorOffset.X == num4 && anchorOffset.Y == num5)
			{
				return;
			}
			if (this.CenterDelegate != null)
			{
				ULTweener ultweener = ULTweenBPLibrary.Vector2To(GlobalData.World, this.CenterDelegate, anchorOffset, new FVector2D(num4, num5), 0.35f, 0f, LTweenEase.OutCubic);
				if (ultweener != null)
				{
					this.CenterTweener = ultweener;
					return;
				}
			}
			else
			{
				this.MapDraggableItem.SetAnchorOffset(new FVector2D(num4, num5));
			}
		}

		// Token: 0x06029262 RID: 168546 RVA: 0x00B8DD84 File Offset: 0x00B8BF84
		[NullableContext(2)]
		public UUIItem GetGuideComponentUiItem(int componentId)
		{
			if (this.Components == null || this.ComponentItems == null)
			{
				return null;
			}
			int num = this.Components.FindIndex((QuestMultiLineComponentData c) => c.Id == componentId);
			if (num < 0 || num >= this.ComponentItems.Count)
			{
				return null;
			}
			this.PanMapToCenterOnComponent(this.Components[num], true);
			return this.ComponentItems[num].GetRootItem();
		}

		// Token: 0x06029263 RID: 168547 RVA: 0x00B8DE00 File Offset: 0x00B8C000
		private void OnClickComponent(QuestMultiLineComponentData timePoint)
		{
			for (int i = 0; i < this.Components.Count; i++)
			{
				this.ComponentItems[i].RefreshSelected(this.Components[i] == timePoint);
			}
			this.PanMapToCenterOnComponent(timePoint, true);
			Action<QuestMultiLineComponentData> componentFunction = this.ComponentFunction;
			if (componentFunction == null)
			{
				return;
			}
			componentFunction(timePoint);
		}

		// Token: 0x06029264 RID: 168548 RVA: 0x00B8DE5C File Offset: 0x00B8C05C
		public bool TryClickComponentAtMousePosition()
		{
			if (this.ComponentItems == null || this.Components == null)
			{
				return false;
			}
			TsCharacterController characterController = Global.CharacterController;
			if (characterController == null)
			{
				return false;
			}
			FKey key = new FKey
			{
				KeyName = new FName(EKey.LeftMouseButton)
			};
			if (!Info.Instance.IsInTouch() && !characterController.IsInputKeyDown(key) && !characterController.WasInputKeyJustReleased(key))
			{
				return false;
			}
			float num = 0f;
			float num2 = 0f;
			if (!characterController.GetMousePosition(ref num, ref num2))
			{
				return false;
			}
			for (int i = this.ComponentItems.Count - 1; i >= 0; i--)
			{
				UUIItem rootItem = this.ComponentItems[i].GetRootItem();
				if (rootItem != null && rootItem.IsUIActiveInHierarchy())
				{
					ULGUIBPLibrary.GetUIWorldPosForceUpdate(rootItem);
					UUIItem uuiitem = rootItem;
					bool bIsScaledByDPI = true;
					FVector2D fvector2D = new FVector2D(0f, 0f);
					FVector2D positionInViewportWithPivot = uuiitem.GetPositionInViewportWithPivot(bIsScaledByDPI, fvector2D);
					UUIItem uuiitem2 = rootItem;
					bool bIsScaledByDPI2 = true;
					fvector2D = new FVector2D(1f, 1f);
					FVector2D positionInViewportWithPivot2 = uuiitem2.GetPositionInViewportWithPivot(bIsScaledByDPI2, fvector2D);
					float num3 = Math.Min(positionInViewportWithPivot.X, positionInViewportWithPivot2.X);
					float num4 = Math.Max(positionInViewportWithPivot.X, positionInViewportWithPivot2.X);
					float num5 = Math.Min(positionInViewportWithPivot.Y, positionInViewportWithPivot2.Y);
					float num6 = Math.Max(positionInViewportWithPivot.Y, positionInViewportWithPivot2.Y);
					if (num >= num3 && num <= num4 && num2 >= num5 && num2 <= num6)
					{
						QuestMultiLineComponentData questMultiLineComponentData = this.Components[i];
						if (questMultiLineComponentData != null && QuestMultiLineUtils.IsComponentClickable(questMultiLineComponentData))
						{
							this.OnClickComponent(questMultiLineComponentData);
							return true;
						}
					}
				}
			}
			return false;
		}

		// Token: 0x04016649 RID: 91721
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<QuestMultiLineComponentData> Components;

		// Token: 0x0401664A RID: 91722
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<QuestMultiLineComponentItem> ComponentItems;

		// Token: 0x0401664B RID: 91723
		private List<QuestMultiLinePathItem> PathItems = new List<QuestMultiLinePathItem>();

		// Token: 0x0401664C RID: 91724
		private readonly Dictionary<int, QuestMultiLinePathItem> PathItemMap = new Dictionary<int, QuestMultiLinePathItem>();

		// Token: 0x0401664D RID: 91725
		[Nullable(2)]
		private UUIItem PathItem;

		// Token: 0x0401664E RID: 91726
		[Nullable(2)]
		private UUIItem PathItemParent;

		// Token: 0x0401664F RID: 91727
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<QuestMultiLineComponentData> ComponentFunction;

		// Token: 0x04016650 RID: 91728
		private readonly Dictionary<int, TimerHandle> ComponentMoveTimerHandles = new Dictionary<int, TimerHandle>();

		// Token: 0x04016651 RID: 91729
		private readonly Dictionary<int, Action> ComponentMoveAbortCallbackMap = new Dictionary<int, Action>();

		// Token: 0x04016652 RID: 91730
		private readonly Dictionary<int, Action> PathDrawAbortCallbackMap = new Dictionary<int, Action>();

		// Token: 0x04016653 RID: 91731
		[Nullable(2)]
		private QuestMultiLineMapMoveComponent MoveComponent;

		// Token: 0x04016654 RID: 91732
		[Nullable(2)]
		private UUIItem MapDraggableItem;

		// Token: 0x04016655 RID: 91733
		private bool IsMapInputBound;

		// Token: 0x04016656 RID: 91734
		private float LastAnchorOffsetX;

		// Token: 0x04016657 RID: 91735
		private float LastAnchorOffsetY;

		// Token: 0x04016658 RID: 91736
		[Nullable(2)]
		private ULTweener CenterTweener;

		// Token: 0x04016659 RID: 91737
		[Nullable(2)]
		private FLTweenVector2SetterDynamic CenterDelegate;

		// Token: 0x0401665A RID: 91738
		private IDragArea CenterSafeArea;
	}
}
