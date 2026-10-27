using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.GenericPrompt;
using UnrealEngine;
using UnrealEngine.Extension;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x02007011 RID: 28689
	[NullableContext(2)]
	[Nullable(0)]
	public class CommonTouchUiEditItem : ITouchUiEditItem, IStaticVariableResetter
	{
		// Token: 0x06045CF4 RID: 285940 RVA: 0x0115C1DA File Offset: 0x0115A3DA
		static CommonTouchUiEditItem()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CommonTouchUiEditItem.CreateStaticDefaultValue), new Action(CommonTouchUiEditItem.ResetStaticDefaultValue));
		}

		// Token: 0x17009BA1 RID: 39841
		// (get) Token: 0x06045CF5 RID: 285941 RVA: 0x0115C1F9 File Offset: 0x0115A3F9
		// (set) Token: 0x06045CF6 RID: 285942 RVA: 0x0115C201 File Offset: 0x0115A401
		public ITouchUiEditData Data { get; set; }

		// Token: 0x17009BA2 RID: 39842
		// (get) Token: 0x06045CF7 RID: 285943 RVA: 0x0115C20A File Offset: 0x0115A40A
		// (set) Token: 0x06045CF8 RID: 285944 RVA: 0x0115C212 File Offset: 0x0115A412
		[Nullable(1)]
		public UUIItem RootItem { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x06045CF9 RID: 285945 RVA: 0x0115C21C File Offset: 0x0115A41C
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

		// Token: 0x06045CFA RID: 285946 RVA: 0x0115C490 File Offset: 0x0115A690
		public void SetData(ITouchUiEditData data)
		{
			this.Data = data;
			FVector lguispaceAbsolutePosition = this.RootItem.GetLGUISpaceAbsolutePosition();
			this.ResultLocation = new FVector(lguispaceAbsolutePosition.X + ((data != null) ? data.OffsetX : 0f), lguispaceAbsolutePosition.Y + ((data != null) ? data.OffsetY : 0f), lguispaceAbsolutePosition.Z);
			this.ApplyDataChange();
			this.CacheData(data);
		}

		// Token: 0x06045CFB RID: 285947 RVA: 0x0115C4FC File Offset: 0x0115A6FC
		private void CacheData(ITouchUiEditData data)
		{
			this.Cache = new ItemDataCache();
			this.Cache.OffsetX = ((data != null) ? data.OffsetX : 0f);
			this.Cache.OffsetY = ((data != null) ? data.OffsetY : 0f);
			this.Cache.Scale = ((data != null) ? data.Scale : 1f);
			this.Cache.Alpha = ((data != null) ? data.Alpha : 1f);
			this.Cache.HierarchyIndex = ((data != null) ? data.HierarchyIndex : 0);
		}

		// Token: 0x06045CFC RID: 285948 RVA: 0x0115C598 File Offset: 0x0115A798
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

		// Token: 0x06045CFD RID: 285949 RVA: 0x0115C714 File Offset: 0x0115A914
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

		// Token: 0x06045CFE RID: 285950 RVA: 0x0115C78A File Offset: 0x0115A98A
		public void SetScale(float scale)
		{
			this.ScaleVector.X = scale;
			this.ScaleVector.Y = scale;
			this.ScaleVector.Z = scale;
			this.SetDataProperty("Scale", scale);
		}

		// Token: 0x06045CFF RID: 285951 RVA: 0x0115C7C4 File Offset: 0x0115A9C4
		public void SetAlpha(float alpha)
		{
			if (MathUtils.Instance.IsNearlyEqual((double)alpha, (double)this.Data.Alpha, null))
			{
				return;
			}
			this.SetDataProperty("Alpha", alpha);
		}

		// Token: 0x06045D00 RID: 285952 RVA: 0x0115C806 File Offset: 0x0115AA06
		public void SetHierarchyIndex(int index)
		{
			this.SetDataProperty("HierarchyIndex", index);
		}

		// Token: 0x06045D01 RID: 285953 RVA: 0x0115C81C File Offset: 0x0115AA1C
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

		// Token: 0x06045D02 RID: 285954 RVA: 0x0115C8E0 File Offset: 0x0115AAE0
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

		// Token: 0x06045D03 RID: 285955 RVA: 0x0115C95C File Offset: 0x0115AB5C
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

		// Token: 0x06045D04 RID: 285956 RVA: 0x0115CA28 File Offset: 0x0115AC28
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

		// Token: 0x06045D05 RID: 285957 RVA: 0x0115CAFC File Offset: 0x0115ACFC
		public void OnDragBegin(ULGUIPointerEventData eventData)
		{
			this.LocalOffsetVector = eventData.GetLocalPointInPlane();
			FVector lguispaceAbsolutePosition = this.RootItem.GetLGUISpaceAbsolutePosition();
			this.ResultLocation = new FVector(lguispaceAbsolutePosition.X, lguispaceAbsolutePosition.Y, lguispaceAbsolutePosition.Z);
		}

		// Token: 0x06045D06 RID: 285958 RVA: 0x0115CB3E File Offset: 0x0115AD3E
		public void OnDragEnd(ULGUIPointerEventData eventData)
		{
			this.LocalOffsetVector = default(FVector);
		}

		// Token: 0x06045D07 RID: 285959 RVA: 0x0115CB4C File Offset: 0x0115AD4C
		private void OnButtonPress()
		{
			this.OnButtonPress(null);
		}

		// Token: 0x06045D08 RID: 285960 RVA: 0x0115CB58 File Offset: 0x0115AD58
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

		// Token: 0x06045D09 RID: 285961 RVA: 0x0115CBBD File Offset: 0x0115ADBD
		private void OnButtonRelease()
		{
			this.OnButtonRelease(null);
		}

		// Token: 0x06045D0A RID: 285962 RVA: 0x0115CBC6 File Offset: 0x0115ADC6
		public void OnButtonRelease(ULGUIPointerEventData eventData)
		{
			this.LocalOffsetVector = default(FVector);
		}

		// Token: 0x06045D0B RID: 285963 RVA: 0x0115CBD4 File Offset: 0x0115ADD4
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

		// Token: 0x06045D0C RID: 285964 RVA: 0x0115CBEC File Offset: 0x0115ADEC
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

		// Token: 0x06045D0D RID: 285965 RVA: 0x0115CC2C File Offset: 0x0115AE2C
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

		// Token: 0x06045D0E RID: 285966 RVA: 0x0115CD1C File Offset: 0x0115AF1C
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

		// Token: 0x06045D0F RID: 285967 RVA: 0x0115CD9A File Offset: 0x0115AF9A
		public static void CreateStaticDefaultValue()
		{
			CommonTouchUiEditItem.disableChildCompClasses = new TWeakObjectPtr<UClass>[]
			{
				UUIDraggableComponent.StaticClass().ToWeakClass(),
				UUISelectableComponent.StaticClass().ToWeakClass()
			};
		}

		// Token: 0x06045D10 RID: 285968 RVA: 0x0115CDC9 File Offset: 0x0115AFC9
		public static void ResetStaticDefaultValue()
		{
			CommonTouchUiEditItem.disableChildCompClasses = null;
		}

		// Token: 0x04024816 RID: 149526
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		private static TWeakObjectPtr<UClass>[] disableChildCompClasses;

		// Token: 0x04024818 RID: 149528
		private ItemDataCache Cache;

		// Token: 0x04024819 RID: 149529
		private FVector ScaleVector = new FVector(1f, 1f, 1f);

		// Token: 0x0402481A RID: 149530
		private FVector LocalOffsetVector;

		// Token: 0x0402481B RID: 149531
		private FVector ResultLocation;

		// Token: 0x0402481C RID: 149532
		private readonly float OriginalAnchorOffsetX;

		// Token: 0x0402481D RID: 149533
		private readonly float OriginalAnchorOffsetY;
	}
}
