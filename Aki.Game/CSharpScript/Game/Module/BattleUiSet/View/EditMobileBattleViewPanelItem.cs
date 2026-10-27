using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUiSet.View
{
	// Token: 0x02005E67 RID: 24167
	[NullableContext(2)]
	[Nullable(0)]
	public class EditMobileBattleViewPanelItem : UiPanelBase
	{
		// Token: 0x0603D710 RID: 251664 RVA: 0x00ED2770 File Offset: 0x00ED0970
		protected override void OnStart()
		{
			PanelItemParams panelItemParams = this.OpenParam as PanelItemParams;
			if (panelItemParams == null)
			{
				throw new InvalidCastException();
			}
			this.Initialize(panelItemParams.PanelItemData, panelItemParams.PanelItem, panelItemParams.BattleViewBaseActor);
		}

		// Token: 0x0603D711 RID: 251665 RVA: 0x00ED27AC File Offset: 0x00ED09AC
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

		// Token: 0x0603D712 RID: 251666 RVA: 0x00ED2842 File Offset: 0x00ED0A42
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

		// Token: 0x0603D713 RID: 251667 RVA: 0x00ED2874 File Offset: 0x00ED0A74
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

		// Token: 0x0603D714 RID: 251668 RVA: 0x00ED2960 File Offset: 0x00ED0B60
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

		// Token: 0x0603D715 RID: 251669 RVA: 0x00ED29E4 File Offset: 0x00ED0BE4
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

		// Token: 0x0603D716 RID: 251670 RVA: 0x00ED2ACC File Offset: 0x00ED0CCC
		public void RefreshRelativeLocation()
		{
			FVectorDouble relativeLocation = this.GetRelativeLocation();
			this.SetRelativeLocation(relativeLocation);
		}

		// Token: 0x0603D717 RID: 251671 RVA: 0x00ED2AE8 File Offset: 0x00ED0CE8
		public void SetRelativeLocation(in FVectorDouble relativeLocation)
		{
			FVectorDouble fvectorDouble = this.ClampBound(relativeLocation);
			this.ResultLocation = fvectorDouble;
			this.PanelItemData.EditOffsetX = this.RootItem.GetAnchorOffsetX();
			this.PanelItemData.EditOffsetY = this.RootItem.GetAnchorOffsetY();
			FHitResult fhitResult = null;
			this.RootItem.D_K2_SetRelativeLocation(fvectorDouble, false, ref fhitResult, false);
		}

		// Token: 0x0603D718 RID: 251672 RVA: 0x00ED2B47 File Offset: 0x00ED0D47
		public FVectorDouble GetRelativeLocation()
		{
			return this.ResultLocation;
		}

		// Token: 0x0603D719 RID: 251673 RVA: 0x00ED2B4F File Offset: 0x00ED0D4F
		public void OnSave()
		{
			if (this.PanelItemData == null)
			{
				return;
			}
			this.PanelItemData.EditOffsetX = this.RootItem.GetAnchorOffsetX();
			this.PanelItemData.EditOffsetY = this.RootItem.GetAnchorOffsetY();
		}

		// Token: 0x0603D71A RID: 251674 RVA: 0x00ED2B88 File Offset: 0x00ED0D88
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

		// Token: 0x0603D71B RID: 251675 RVA: 0x00ED2C68 File Offset: 0x00ED0E68
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

		// Token: 0x0603D71C RID: 251676 RVA: 0x00ED2CC6 File Offset: 0x00ED0EC6
		private void OnDragEnded(ULGUIPointerEventData ulguiPointerEventData)
		{
			this.LocalOffsetVector = null;
		}

		// Token: 0x0603D71D RID: 251677 RVA: 0x00ED2CD4 File Offset: 0x00ED0ED4
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

		// Token: 0x0603D71E RID: 251678 RVA: 0x00ED2D3C File Offset: 0x00ED0F3C
		private void OnButtonRelease()
		{
			this.LocalOffsetVector = null;
		}

		// Token: 0x0603D71F RID: 251679 RVA: 0x00ED2D4A File Offset: 0x00ED0F4A
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

		// Token: 0x0603D720 RID: 251680 RVA: 0x00ED2D78 File Offset: 0x00ED0F78
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

		// Token: 0x0603D721 RID: 251681 RVA: 0x00ED2DEC File Offset: 0x00ED0FEC
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

		// Token: 0x0603D722 RID: 251682 RVA: 0x00ED2E90 File Offset: 0x00ED1090
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

		// Token: 0x0603D723 RID: 251683 RVA: 0x00ED2F34 File Offset: 0x00ED1134
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

		// Token: 0x0603D724 RID: 251684 RVA: 0x00ED2F63 File Offset: 0x00ED1163
		public void ApplyTopIndex()
		{
			base.GetRootItem().SetHierarchyIndex(30);
		}

		// Token: 0x040200FE RID: 131326
		public BattleUiSetPanelItemData PanelItemData;

		// Token: 0x040200FF RID: 131327
		private AUIBaseActor BattleViewBaseActor;

		// Token: 0x04020100 RID: 131328
		protected UUIItem PanelItem;

		// Token: 0x04020101 RID: 131329
		private FVectorDouble ResultLocation;

		// Token: 0x04020102 RID: 131330
		private FVector? LocalOffsetVector;

		// Token: 0x04020103 RID: 131331
		private UUIDraggableComponent Draggable;

		// Token: 0x04020104 RID: 131332
		private UUIButtonComponent Button;

		// Token: 0x04020105 RID: 131333
		private UUIExtendToggle ExtendToggle;
	}
}
