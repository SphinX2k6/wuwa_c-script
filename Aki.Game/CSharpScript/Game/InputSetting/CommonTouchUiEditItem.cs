using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.GenericPrompt;
using UnrealEngine;
using UnrealEngine.Extension;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x02006192 RID: 24978
	[NullableContext(2)]
	[Nullable(0)]
	public class CommonTouchUiEditItem : ITouchUiEditItem, IStaticVariableResetter
	{
		// Token: 0x0603BEAA RID: 245418 RVA: 0x011065E6 File Offset: 0x011047E6
		static CommonTouchUiEditItem()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CommonTouchUiEditItem.CreateStaticDefaultValue), new Action(CommonTouchUiEditItem.ResetStaticDefaultValue));
		}

		// Token: 0x170070E1 RID: 28897
		// (get) Token: 0x0603BEAB RID: 245419 RVA: 0x01106605 File Offset: 0x01104805
		// (set) Token: 0x0603BEAC RID: 245420 RVA: 0x0110660D File Offset: 0x0110480D
		public ITouchUiEditData Data { get; set; }

		// Token: 0x170070E2 RID: 28898
		// (get) Token: 0x0603BEAD RID: 245421 RVA: 0x01106616 File Offset: 0x01104816
		// (set) Token: 0x0603BEAE RID: 245422 RVA: 0x0110661E File Offset: 0x0110481E
		[Nullable(1)]
		public UUIItem RootItem { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x0603BEAF RID: 245423 RVA: 0x01106628 File Offset: 0x01104828
		[NullableContext(1)]
		public CommonTouchUiEditItem(UUIItem rootItem, [Nullable(2)] ITouchUiEditData data)
		{
			this.RootItem = rootItem;
			AActor owner = this.RootItem.GetOwner();
			UUIDraggableComponent uuidraggableComponent = owner.GetComponentByClass(UUIDraggableComponent.StaticClass()) as UUIDraggableComponent;
			UUIButtonComponent uuibuttonComponent = owner.GetComponentByClass(UUIButtonComponent.StaticClass()) as UUIButtonComponent;
			UUIExtendToggle uuiextendToggle = owner.GetComponentByClass(UUIExtendToggle.StaticClass()) as UUIExtendToggle;
			if (data != null && data.Editable)
			{
				this.RootItem.SetRaycastTarget(true);
				for (int i = 0; i < CommonTouchUiEditItem.disableChildCompClasses.Length; i++)
				{
					UClass classPtr = CommonTouchUiEditItem.disableChildCompClasses[i];
					TArray<UActorComponent> componentsInChildren = ULGUIBPLibrary.GetComponentsInChildren(owner, classPtr, false);
					for (int j = 0; j < componentsInChildren.Num(); j++)
					{
						UActorComponent uactorComponent = componentsInChildren.Get(j);
						AActor aactor = (uactorComponent != null) ? uactorComponent.GetOwner() : null;
						UUIItem uuiitem = ((aactor != null) ? aactor.GetComponentByClass(UUIItem.StaticClass()) : null) as UUIItem;
						if (uuiitem != null)
						{
							uuiitem.SetRaycastTarget(false);
						}
					}
				}
			}
			if (uuidraggableComponent == null && data != null && data.Editable)
			{
				uuidraggableComponent = (owner.AddComponentByClass(UUIDraggableComponent.StaticClass(), false, MathUtils.Instance.DefaultTransform, false, default(FName)) as UUIDraggableComponent);
			}
			if (uuidraggableComponent != null)
			{
				uuidraggableComponent.OnPointerDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnDrag));
				uuidraggableComponent.OnPointerBeginDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnDragBegin));
				uuidraggableComponent.OnPointerEndDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnDragEnd));
			}
			if (uuibuttonComponent == null && data != null && data.Editable)
			{
				uuibuttonComponent = (owner.AddComponentByClass(UUIButtonComponent.StaticClass(), false, MathUtils.Instance.DefaultTransform, false, default(FName)) as UUIButtonComponent);
			}
			if (uuibuttonComponent != null)
			{
				uuibuttonComponent.OnPointDownCallBack.Bind(new Action(this.OnButtonPress));
				uuibuttonComponent.OnPointUpCallBack.Bind(new Action(this.OnButtonRelease));
			}
			if (uuiextendToggle != null)
			{
				uuiextendToggle.OnStateChange.Add(new Action<EToggleState>(this.OnExtendToggleStateChanged));
				uuiextendToggle.CanExecuteChange.Bind(new Func<bool>(this.OnCheckCanExecuteChange));
			}
			this.OriginalAnchorOffsetX = this.RootItem.GetAnchorOffsetX();
			this.OriginalAnchorOffsetY = this.RootItem.GetAnchorOffsetY();
		}

		// Token: 0x0603BEB0 RID: 245424 RVA: 0x0110689C File Offset: 0x01104A9C
		public void SetData(ITouchUiEditData data)
		{
			this.Data = data;
			FVector lguispaceAbsolutePosition = this.RootItem.GetLGUISpaceAbsolutePosition();
			this.ResultLocation = new FVector(lguispaceAbsolutePosition.X + ((data != null) ? data.OffsetX : 0f), lguispaceAbsolutePosition.Y + ((data != null) ? data.OffsetY : 0f), lguispaceAbsolutePosition.Z);
			this.ApplyDataChange();
			this.CacheData(data);
		}

		// Token: 0x0603BEB1 RID: 245425 RVA: 0x01106908 File Offset: 0x01104B08
		private void CacheData(ITouchUiEditData data)
		{
			this.Cache = new ItemDataCache();
			this.Cache.OffsetX = ((data != null) ? data.OffsetX : 0f);
			this.Cache.OffsetY = ((data != null) ? data.OffsetY : 0f);
			this.Cache.Scale = ((data != null) ? data.Scale : 1f);
			this.Cache.Alpha = ((data != null) ? data.Alpha : 1f);
			this.Cache.HierarchyIndex = ((data != null) ? data.HierarchyIndex : 0);
		}

		// Token: 0x0603BEB2 RID: 245426 RVA: 0x011069A4 File Offset: 0x01104BA4
		public bool IsEdited()
		{
			MathUtils instance = MathUtils.Instance;
			ITouchUiEditData data = this.Data;
			double a = (double)((data != null) ? data.OffsetX : 0f);
			ItemDataCache cache = this.Cache;
			if (instance.IsNearlyEqual(a, (double)((cache != null) ? cache.OffsetX : 0f), new double?(0.01)))
			{
				MathUtils instance2 = MathUtils.Instance;
				ITouchUiEditData data2 = this.Data;
				double a2 = (double)((data2 != null) ? data2.OffsetY : 0f);
				ItemDataCache cache2 = this.Cache;
				if (instance2.IsNearlyEqual(a2, (double)((cache2 != null) ? cache2.OffsetY : 0f), new double?(0.01)))
				{
					MathUtils instance3 = MathUtils.Instance;
					ITouchUiEditData data3 = this.Data;
					double a3 = (double)((data3 != null) ? data3.Scale : 1f);
					ItemDataCache cache3 = this.Cache;
					if (instance3.IsNearlyEqual(a3, (double)((cache3 != null) ? cache3.Scale : 1f), new double?(0.01)))
					{
						MathUtils instance4 = MathUtils.Instance;
						ITouchUiEditData data4 = this.Data;
						double a4 = (double)((data4 != null) ? data4.Alpha : 1f);
						ItemDataCache cache4 = this.Cache;
						if (instance4.IsNearlyEqual(a4, (double)((cache4 != null) ? cache4.Alpha : 1f), new double?(0.01)))
						{
							MathUtils instance5 = MathUtils.Instance;
							ITouchUiEditData data5 = this.Data;
							double a5 = (double)((data5 != null) ? data5.HierarchyIndex : 0);
							ItemDataCache cache5 = this.Cache;
							return !instance5.IsNearlyEqual(a5, (double)((cache5 != null) ? cache5.HierarchyIndex : 0), new double?(0.01));
						}
					}
				}
			}
			return true;
		}

		// Token: 0x0603BEB3 RID: 245427 RVA: 0x01106B20 File Offset: 0x01104D20
		public void SetOffset(float x, float y)
		{
			float num = x - this.Data.OffsetX;
			float num2 = y - this.Data.OffsetY;
			if (num == 0f && num2 == 0f)
			{
				return;
			}
			this.ResultLocation.X = this.ResultLocation.X + num;
			this.ResultLocation.Y = this.ResultLocation.Y + num2;
			this.ResultLocation.Z = 0f;
			this.FixLocation(this.ResultLocation);
		}

		// Token: 0x0603BEB4 RID: 245428 RVA: 0x01106B96 File Offset: 0x01104D96
		public void SetScale(float scale)
		{
			this.ScaleVector.X = scale;
			this.ScaleVector.Y = scale;
			this.ScaleVector.Z = scale;
			this.SetDataProperty("Scale", scale);
		}

		// Token: 0x0603BEB5 RID: 245429 RVA: 0x01106BD0 File Offset: 0x01104DD0
		public void SetAlpha(float alpha)
		{
			if (MathUtils.Instance.IsNearlyEqual((double)alpha, (double)this.Data.Alpha, null))
			{
				return;
			}
			this.SetDataProperty("Alpha", alpha);
		}

		// Token: 0x0603BEB6 RID: 245430 RVA: 0x01106C12 File Offset: 0x01104E12
		public void SetHierarchyIndex(int index)
		{
			this.SetDataProperty("HierarchyIndex", index);
		}

		// Token: 0x0603BEB7 RID: 245431 RVA: 0x01106C28 File Offset: 0x01104E28
		public void OnViewDestroy()
		{
			AActor owner = this.RootItem.GetOwner();
			if (owner != null)
			{
				UUIDraggableComponent uuidraggableComponent = owner.GetComponentByClass(UUIDraggableComponent.StaticClass()) as UUIDraggableComponent;
				if (uuidraggableComponent != null)
				{
					uuidraggableComponent.OnPointerDragCallBack.Unbind();
					uuidraggableComponent.OnPointerBeginDragCallBack.Unbind();
					uuidraggableComponent.OnPointerEndDragCallBack.Unbind();
				}
				UUIButtonComponent uuibuttonComponent = owner.GetComponentByClass(UUIButtonComponent.StaticClass()) as UUIButtonComponent;
				if (uuibuttonComponent != null)
				{
					uuibuttonComponent.OnPointDownCallBack.Unbind();
					uuibuttonComponent.OnPointUpCallBack.Unbind();
				}
				UUIExtendToggle uuiextendToggle = owner.GetComponentByClass(UUIExtendToggle.StaticClass()) as UUIExtendToggle;
				if (uuiextendToggle != null)
				{
					uuiextendToggle.OnStateChange.Remove(new Action<EToggleState>(this.OnExtendToggleStateChanged));
					uuiextendToggle.CanExecuteChange.Unbind();
				}
			}
		}

		// Token: 0x0603BEB8 RID: 245432 RVA: 0x01106CEC File Offset: 0x01104EEC
		[NullableContext(1)]
		private void SetDataProperty(string property, object value)
		{
			if (this.Data != null)
			{
				if (property == "Scale")
				{
					this.Data.Scale = (float)value;
				}
				else if (property == "Alpha")
				{
					this.Data.Alpha = (float)value;
				}
				else if (property == "HierarchyIndex")
				{
					this.Data.HierarchyIndex = (int)value;
				}
			}
			this.ApplyDataChange();
		}

		// Token: 0x0603BEB9 RID: 245433 RVA: 0x01106D68 File Offset: 0x01104F68
		private void ApplyDataChange()
		{
			if (this.RootItem != null && this.Data != null)
			{
				this.RootItem.SetAnchorOffsetX(this.OriginalAnchorOffsetX + this.Data.OffsetX);
				this.RootItem.SetAnchorOffsetY(this.OriginalAnchorOffsetY + this.Data.OffsetY);
				this.ScaleVector.X = this.Data.Scale;
				this.ScaleVector.Y = this.Data.Scale;
				this.RootItem.SetUIItemScale(this.ScaleVector);
				this.RootItem.SetUIItemAlpha(this.Data.Alpha);
				this.RootItem.SetHierarchyIndex(this.Data.HierarchyIndex);
				TouchUiEditViewModel.NotifySelectedItemChange(this);
			}
		}

		// Token: 0x0603BEBA RID: 245434 RVA: 0x01106E34 File Offset: 0x01105034
		public void OnDrag(ULGUIPointerEventData eventData)
		{
			if (this.Data == null)
			{
				return;
			}
			FVector localOffsetVector = this.LocalOffsetVector;
			if (TouchUiEditViewModel.GetTouchFingerDataCount() >= 2)
			{
				return;
			}
			FVector localPointInPlane = eventData.GetLocalPointInPlane();
			FVectorDouble fvectorDouble = (eventData.dragComponent.GetOwner() as AUIBaseActor).D_GetActorScale3D();
			FVector fvector = fvectorDouble;
			float num = (localPointInPlane.X - this.LocalOffsetVector.X) * fvector.X;
			float num2 = (localPointInPlane.Y - this.LocalOffsetVector.Y) * fvector.Z;
			if (num == 0f || num2 == 0f)
			{
				return;
			}
			this.ResultLocation.X = this.ResultLocation.X + num;
			this.ResultLocation.Y = this.ResultLocation.Y + num2;
			this.ResultLocation.Z = 0f;
			this.FixLocation(this.ResultLocation);
			this.LocalOffsetVector = localPointInPlane;
		}

		// Token: 0x0603BEBB RID: 245435 RVA: 0x01106F08 File Offset: 0x01105108
		public void OnDragBegin(ULGUIPointerEventData eventData)
		{
			this.LocalOffsetVector = eventData.GetLocalPointInPlane();
			FVector lguispaceAbsolutePosition = this.RootItem.GetLGUISpaceAbsolutePosition();
			this.ResultLocation = new FVector(lguispaceAbsolutePosition.X, lguispaceAbsolutePosition.Y, lguispaceAbsolutePosition.Z);
		}

		// Token: 0x0603BEBC RID: 245436 RVA: 0x01106F4A File Offset: 0x0110514A
		public void OnDragEnd(ULGUIPointerEventData eventData)
		{
			this.LocalOffsetVector = default(FVector);
		}

		// Token: 0x0603BEBD RID: 245437 RVA: 0x01106F58 File Offset: 0x01105158
		private void OnButtonPress()
		{
			this.OnButtonPress(null);
		}

		// Token: 0x0603BEBE RID: 245438 RVA: 0x01106F64 File Offset: 0x01105164
		public void OnButtonPress(ULGUIPointerEventData eventData)
		{
			if (this.Data == null)
			{
				GenericPromptController.Instance.ShowPromptByCode("NotEdit", Array.Empty<object>());
				return;
			}
			this.LocalOffsetVector = default(FVector);
			FVector lguispaceAbsolutePosition = this.RootItem.GetLGUISpaceAbsolutePosition();
			this.ResultLocation = new FVector(lguispaceAbsolutePosition.X, lguispaceAbsolutePosition.Y, lguispaceAbsolutePosition.Z);
			TouchUiEditViewModel.SetCurrentSelectedItem(this);
		}

		// Token: 0x0603BEBF RID: 245439 RVA: 0x01106FC9 File Offset: 0x011051C9
		private void OnButtonRelease()
		{
			this.OnButtonRelease(null);
		}

		// Token: 0x0603BEC0 RID: 245440 RVA: 0x01106FD2 File Offset: 0x011051D2
		public void OnButtonRelease(ULGUIPointerEventData eventData)
		{
			this.LocalOffsetVector = default(FVector);
		}

		// Token: 0x0603BEC1 RID: 245441 RVA: 0x01106FE0 File Offset: 0x011051E0
		public void OnExtendToggleStateChanged(EToggleState state)
		{
			if (this.Data == null)
			{
				return;
			}
			if (state != EToggleState.ETT_Checked)
			{
				return;
			}
			TouchUiEditViewModel.SetCurrentSelectedItem(this);
		}

		// Token: 0x0603BEC2 RID: 245442 RVA: 0x01106FF8 File Offset: 0x011051F8
		public bool OnCheckCanExecuteChange()
		{
			if (this.Data == null)
			{
				GenericPromptController.Instance.ShowPromptByCode("NotEdit", Array.Empty<object>());
				return false;
			}
			ITouchUiEditItem currentSelectedItem = TouchUiEditViewModel.GetCurrentSelectedItem();
			return currentSelectedItem == null || currentSelectedItem != this;
		}

		// Token: 0x0603BEC3 RID: 245443 RVA: 0x01107038 File Offset: 0x01105238
		private FVector ClampBound(FVector location)
		{
			double x = (this.RootItem.GetOwner() as AUIBaseActor).D_GetActorScale3D().X;
			FVector2D pivot = this.RootItem.GetPivot();
			float y = pivot.Y;
			float x2 = pivot.X;
			UUIItem rootItem = TouchUiEditViewModel.GetRootItem();
			float width = rootItem.Width;
			double height = (double)rootItem.Height;
			double num = (double)this.RootItem.Width * x;
			double num2 = (double)this.RootItem.Height * x;
			double min = 0.0 + num * (double)x2;
			double max = (double)width - num * (double)(1f - x2);
			double min2 = 0.0 + num2 * (double)y;
			double max2 = height - num2 * (double)(1f - y);
			location.X = (float)MathUtils.Instance.Clamp((double)location.X, min, max);
			location.Y = (float)MathUtils.Instance.Clamp((double)location.Y, min2, max2);
			return location;
		}

		// Token: 0x0603BEC4 RID: 245444 RVA: 0x01107128 File Offset: 0x01105328
		private void FixLocation(FVector location)
		{
			FVector fvector = this.ClampBound(location);
			float anchorOffsetX = this.RootItem.GetAnchorOffsetX();
			float anchorOffsetY = this.RootItem.GetAnchorOffsetY();
			this.RootItem.SetLGUISpaceAbsolutePosition(fvector);
			float anchorOffsetX2 = this.RootItem.GetAnchorOffsetX();
			float anchorOffsetY2 = this.RootItem.GetAnchorOffsetY();
			this.Data.OffsetX += anchorOffsetX2 - anchorOffsetX;
			this.Data.OffsetY += anchorOffsetY2 - anchorOffsetY;
		}

		// Token: 0x0603BEC5 RID: 245445 RVA: 0x011071A6 File Offset: 0x011053A6
		public static void CreateStaticDefaultValue()
		{
			CommonTouchUiEditItem.disableChildCompClasses = new TWeakObjectPtr<UClass>[]
			{
				UUIDraggableComponent.StaticClass().ToWeakClass(),
				UUISelectableComponent.StaticClass().ToWeakClass()
			};
		}

		// Token: 0x0603BEC6 RID: 245446 RVA: 0x011071D5 File Offset: 0x011053D5
		public static void ResetStaticDefaultValue()
		{
			CommonTouchUiEditItem.disableChildCompClasses = null;
		}

		// Token: 0x0401FACC RID: 129740
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		private static TWeakObjectPtr<UClass>[] disableChildCompClasses;

		// Token: 0x0401FACE RID: 129742
		private ItemDataCache Cache;

		// Token: 0x0401FACF RID: 129743
		private FVector ScaleVector = new FVector(1f, 1f, 1f);

		// Token: 0x0401FAD0 RID: 129744
		private FVector LocalOffsetVector;

		// Token: 0x0401FAD1 RID: 129745
		private FVector ResultLocation;

		// Token: 0x0401FAD2 RID: 129746
		private readonly float OriginalAnchorOffsetX;

		// Token: 0x0401FAD3 RID: 129747
		private readonly float OriginalAnchorOffsetY;
	}
}
