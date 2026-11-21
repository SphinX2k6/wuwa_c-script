using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUiSet.View
{
	// Token: 0x02004E4C RID: 20044
	[NullableContext(2)]
	[Nullable(0)]
	public class EditMobileBattleViewPanelItem : UiPanelBase
	{
		// Token: 0x060326A0 RID: 206496 RVA: 0x00E23CE0 File Offset: 0x00E21EE0
		protected override void OnStart()
		{
			PanelItemParams panelItemParams = this.OpenParam as PanelItemParams;
			if (panelItemParams == null)
			{
				throw new InvalidCastException();
			}
			this.Initialize(panelItemParams.PanelItemData, panelItemParams.PanelItem, panelItemParams.BattleViewBaseActor);
		}

		// Token: 0x060326A1 RID: 206497 RVA: 0x00E23D1C File Offset: 0x00E21F1C
		[NullableContext(1)]
		private void Initialize(BattleUiSetPanelItemData panelItemData, UUIItem panelItem, AUIBaseActor battleViewBaseActor)
		{
			this.PanelItemData = panelItemData;
			this.PanelItem = panelItem;
			this.BattleViewBaseActor = battleViewBaseActor;
			this.Draggable = (this.RootActor.GetComponentByClass(UUIDraggableComponent.StaticClass()) as UUIDraggableComponent);
			this.Button = (this.RootActor.GetComponentByClass(UUIButtonComponent.StaticClass()) as UUIButtonComponent);
			this.ExtendToggle = (this.RootActor.GetComponentByClass(UUIExtendToggle.StaticClass()) as UUIExtendToggle);
			this.AddEvents();
			if (this.PanelItemData != null)
			{
				this.Refresh();
			}
		}

		// Token: 0x060326A2 RID: 206498 RVA: 0x00E23DB2 File Offset: 0x00E21FB2
		protected override void OnBeforeDestroy()
		{
			this.RemoveEvents();
			this.PanelItemData = null;
			this.Draggable = null;
			this.Button = null;
			this.ExtendToggle = null;
			this.BattleViewBaseActor = null;
			this.PanelItem = null;
		}

		// Token: 0x060326A3 RID: 206499 RVA: 0x00E23DE4 File Offset: 0x00E21FE4
		private void AddEvents()
		{
			if (this.Draggable != null)
			{
				this.Draggable.OnPointerDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnDrag));
				this.Draggable.OnPointerBeginDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnDragBegin));
				this.Draggable.OnPointerEndDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnDragEnded));
			}
			if (this.Button != null)
			{
				this.Button.OnPointDownCallBack.Bind(new Action(this.OnButtonPress));
				this.Button.OnPointUpCallBack.Bind(new Action(this.OnButtonRelease));
			}
			if (this.ExtendToggle != null)
			{
				this.ExtendToggle.OnStateChange.Add(new Action<EToggleState>(this.OnExtendToggleStateChanged));
				this.ExtendToggle.CanExecuteChange.Bind(new Func<bool>(this.OnCheckCanExecuteChange));
			}
		}

		// Token: 0x060326A4 RID: 206500 RVA: 0x00E23ED0 File Offset: 0x00E220D0
		private void RemoveEvents()
		{
			if (this.Draggable != null)
			{
				this.Draggable.OnPointerDragCallBack.Unbind();
			}
			if (this.Button != null)
			{
				this.Button.OnPointDownCallBack.Unbind();
				this.Button.OnPointUpCallBack.Unbind();
			}
			if (this.ExtendToggle != null)
			{
				this.ExtendToggle.OnStateChange.Remove(new Action<EToggleState>(this.OnExtendToggleStateChanged));
				this.ExtendToggle.CanExecuteChange.Unbind();
			}
		}

		// Token: 0x060326A5 RID: 206501 RVA: 0x00E23F54 File Offset: 0x00E22154
		private void OnDrag(ULGUIPointerEventData eventData)
		{
			if (this.PanelItemData == null)
			{
				return;
			}
			if (this.LocalOffsetVector == null)
			{
				return;
			}
			if (BattleUiSetModel.Instance.GetTouchFingerDataCount() >= 2)
			{
				return;
			}
			FVector localPointInPlane = eventData.GetLocalPointInPlane();
			FVectorDouble fvectorDouble = (eventData.dragComponent.GetOwner() as AUIBaseActor).D_GetActorScale3D();
			double num = (double)(localPointInPlane.X - this.LocalOffsetVector.Value.X) * fvectorDouble.X;
			double num2 = (double)(localPointInPlane.Y - this.LocalOffsetVector.Value.Y) * fvectorDouble.Z;
			if (num == 0.0 && num2 == 0.0)
			{
				return;
			}
			FVectorDouble fvectorDouble2 = new FVectorDouble(num, num2, 0.0);
			this.ResultLocation = this.ResultLocation + fvectorDouble2;
			this.SetRelativeLocation(this.ResultLocation);
			this.LocalOffsetVector = new FVector?(localPointInPlane);
		}

		// Token: 0x060326A6 RID: 206502 RVA: 0x00E2403C File Offset: 0x00E2223C
		public void RefreshRelativeLocation()
		{
			FVectorDouble relativeLocation = this.GetRelativeLocation();
			this.SetRelativeLocation(relativeLocation);
		}

		// Token: 0x060326A7 RID: 206503 RVA: 0x00E24058 File Offset: 0x00E22258
		public void SetRelativeLocation(in FVectorDouble relativeLocation)
		{
			FVectorDouble fvectorDouble = this.ClampBound(relativeLocation);
			this.ResultLocation = fvectorDouble;
			this.PanelItemData.EditOffsetX = this.RootItem.GetAnchorOffsetX();
			this.PanelItemData.EditOffsetY = this.RootItem.GetAnchorOffsetY();
			FHitResult fhitResult = null;
			this.RootItem.D_K2_SetRelativeLocation(fvectorDouble, false, ref fhitResult, false);
		}

		// Token: 0x060326A8 RID: 206504 RVA: 0x00E240B7 File Offset: 0x00E222B7
		public FVectorDouble GetRelativeLocation()
		{
			return this.ResultLocation;
		}

		// Token: 0x060326A9 RID: 206505 RVA: 0x00E240BF File Offset: 0x00E222BF
		public void OnSave()
		{
			if (this.PanelItemData == null)
			{
				return;
			}
			this.PanelItemData.EditOffsetX = this.RootItem.GetAnchorOffsetX();
			this.PanelItemData.EditOffsetY = this.RootItem.GetAnchorOffsetY();
		}

		// Token: 0x060326AA RID: 206506 RVA: 0x00E240F8 File Offset: 0x00E222F8
		private FVectorDouble ClampBound(FVectorDouble relativeLocation)
		{
			double x = this.RootActor.D_GetActorScale3D().X;
			FVector2D pivot = this.RootItem.GetPivot();
			float y = pivot.Y;
			float x2 = pivot.X;
			UUIItem uiitem = this.BattleViewBaseActor.GetUIItem();
			float width = uiitem.Width;
			float height = uiitem.Height;
			float num = width / 2f;
			float num2 = height / 2f;
			double num3 = (double)this.RootItem.Width * x;
			double num4 = (double)this.RootItem.Height * x;
			double min = (double)(-(double)num) + num3 * (double)x2;
			double max = (double)num - num3 * (double)(1f - x2);
			double min2 = (double)(-(double)num2) + num4 * (double)y;
			double max2 = (double)num2 - num4 * (double)(1f - y);
			relativeLocation.X = MathCommon.Clamp(relativeLocation.X, min, max);
			relativeLocation.Y = MathCommon.Clamp(relativeLocation.Y, min2, max2);
			return relativeLocation;
		}

		// Token: 0x060326AB RID: 206507 RVA: 0x00E241D8 File Offset: 0x00E223D8
		private void OnDragBegin(ULGUIPointerEventData eventData)
		{
			if (this.PanelItemData == null)
			{
				return;
			}
			if (!this.PanelItemData.CanEdit)
			{
				return;
			}
			this.LocalOffsetVector = new FVector?(eventData.GetLocalPointInPlane());
			FVector relativeLocation = this.RootItem.RelativeLocation;
			this.ResultLocation = new FVectorDouble(ref relativeLocation);
			BattleUiSetModel.Instance.SetPanelItemSelected(this.PanelItemData);
		}

		// Token: 0x060326AC RID: 206508 RVA: 0x00E24236 File Offset: 0x00E22436
		private void OnDragEnded(ULGUIPointerEventData ulguiPointerEventData)
		{
			this.LocalOffsetVector = null;
		}

		// Token: 0x060326AD RID: 206509 RVA: 0x00E24244 File Offset: 0x00E22444
		private void OnButtonPress()
		{
			if (this.PanelItemData == null)
			{
				GenericPromptController.Instance.ShowPromptByCode("NotEdit", Array.Empty<object>());
				return;
			}
			if (!this.PanelItemData.CanEdit)
			{
				GenericPromptController.Instance.ShowPromptByCode("NotEdit", Array.Empty<object>());
				return;
			}
			this.LocalOffsetVector = null;
			BattleUiSetModel.Instance.SetPanelItemSelected(this.PanelItemData);
		}

		// Token: 0x060326AE RID: 206510 RVA: 0x00E242AC File Offset: 0x00E224AC
		private void OnButtonRelease()
		{
			this.LocalOffsetVector = null;
		}

		// Token: 0x060326AF RID: 206511 RVA: 0x00E242BA File Offset: 0x00E224BA
		private void OnExtendToggleStateChanged(EToggleState state)
		{
			if (this.PanelItemData == null)
			{
				return;
			}
			if (!this.PanelItemData.CanEdit)
			{
				return;
			}
			if (state != EToggleState.ETT_Checked)
			{
				return;
			}
			BattleUiSetModel.Instance.SetPanelItemSelected(this.PanelItemData);
		}

		// Token: 0x060326B0 RID: 206512 RVA: 0x00E242E8 File Offset: 0x00E224E8
		private bool OnCheckCanExecuteChange()
		{
			if (this.PanelItemData == null)
			{
				GenericPromptController.Instance.ShowPromptByCode("NotEdit", Array.Empty<object>());
				return false;
			}
			if (!this.PanelItemData.CanEdit)
			{
				GenericPromptController.Instance.ShowPromptByCode("NotEdit", Array.Empty<object>());
				return false;
			}
			BattleUiSetPanelItemData selectedPanelItemData = BattleUiSetModel.Instance.SelectedPanelItemData;
			return selectedPanelItemData == null || selectedPanelItemData.ConfigId != this.PanelItemData.ConfigId;
		}

		// Token: 0x060326B1 RID: 206513 RVA: 0x00E2435C File Offset: 0x00E2255C
		public void Refresh()
		{
			if (this.PanelItemData == null)
			{
				return;
			}
			float size = this.PanelItemData.Size;
			this.RootItem.SetUIItemScale(new FVector(size));
			this.RootItem.SetAnchorOffsetX(this.PanelItemData.OffsetX);
			this.RootItem.SetAnchorOffsetY(this.PanelItemData.OffsetY);
			this.RootItem.SetUIItemAlpha(this.PanelItemData.Alpha);
			this.RootItem.SetHierarchyIndex(this.PanelItemData.HierarchyIndex);
			FVector relativeLocation = this.RootItem.RelativeLocation;
			this.ResultLocation = new FVectorDouble(ref relativeLocation);
		}

		// Token: 0x060326B2 RID: 206514 RVA: 0x00E24400 File Offset: 0x00E22600
		public void Reset()
		{
			if (this.PanelItemData == null)
			{
				return;
			}
			float sourceSize = this.PanelItemData.SourceSize;
			this.RootItem.SetUIItemScale(new FVector(sourceSize));
			this.RootItem.SetAnchorOffsetX(this.PanelItemData.SourceOffsetX);
			this.RootItem.SetAnchorOffsetY(this.PanelItemData.SourceOffsetY);
			this.RootItem.SetUIItemAlpha(this.PanelItemData.SourceAlpha);
			this.RootItem.SetHierarchyIndex(this.PanelItemData.SourceHierarchyIndex);
			FVector relativeLocation = this.RootItem.RelativeLocation;
			this.ResultLocation = new FVectorDouble(ref relativeLocation);
		}

		// Token: 0x060326B3 RID: 206515 RVA: 0x00E244A4 File Offset: 0x00E226A4
		public void SetSelected(bool bSelected)
		{
			if (this.ExtendToggle == null)
			{
				return;
			}
			if (bSelected)
			{
				this.ExtendToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
				return;
			}
			this.ExtendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x060326B4 RID: 206516 RVA: 0x00E244D3 File Offset: 0x00E226D3
		public void ApplyTopIndex()
		{
			base.GetRootItem().SetHierarchyIndex(30);
		}

		// Token: 0x0401ABC5 RID: 109509
		public BattleUiSetPanelItemData PanelItemData;

		// Token: 0x0401ABC6 RID: 109510
		private AUIBaseActor BattleViewBaseActor;

		// Token: 0x0401ABC7 RID: 109511
		protected UUIItem PanelItem;

		// Token: 0x0401ABC8 RID: 109512
		private FVectorDouble ResultLocation;

		// Token: 0x0401ABC9 RID: 109513
		private FVector? LocalOffsetVector;

		// Token: 0x0401ABCA RID: 109514
		private UUIDraggableComponent Draggable;

		// Token: 0x0401ABCB RID: 109515
		private UUIButtonComponent Button;

		// Token: 0x0401ABCC RID: 109516
		private UUIExtendToggle ExtendToggle;
	}
}
