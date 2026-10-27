using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001C02 RID: 7170
[NullableContext(2)]
[Nullable(0)]
public class FormationEditItem : GridProxyAbstract<int>
{
	// Token: 0x0600D62F RID: 54831 RVA: 0x0031835C File Offset: 0x0031655C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 12;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIDraggableComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickEditName));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600D630 RID: 54832 RVA: 0x00318550 File Offset: 0x00316750
	protected override void OnStart()
	{
		UUILayoutBase horizontalLayout = base.GetHorizontalLayout(7);
		Func<FormationEditHeadItem> gridProxyCreateFunction;
		if ((gridProxyCreateFunction = FormationEditItem.<>O.<0>__CreateHeadItem) == null)
		{
			gridProxyCreateFunction = (FormationEditItem.<>O.<0>__CreateHeadItem = new Func<FormationEditHeadItem>(FormationEditItem.CreateHeadItem));
		}
		this.HeadLayout = new GenericLayout<FormationEditHeadItem, int>(horizontalLayout, gridProxyCreateFunction, base.GetItem(8).GetOwner() as AUIBaseActor, false, true);
		UUIItem item = base.GetItem(4);
		if (item != null)
		{
			item.SetUIActive(this.IsDragOverlay);
		}
		UUIItem item2 = base.GetItem(5);
		if (item2 != null)
		{
			item2.SetUIActive(this.IsDragOverlay);
		}
		if (this.IsDragOverlay)
		{
			return;
		}
		base.GetExtendToggle(0).OnStateChange.Add(new Action<EToggleState>(this.OnToggleStateChange));
		UUIDraggableComponent draggable = base.GetDraggable(9);
		if (draggable != null)
		{
			draggable.NeedInterruptDelegate.Bind(new Func<ULGUIBaseEventData, bool>(this.OnDragNeedInterrupt));
			draggable.OnPointerDownCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnHandlePointerDown));
			draggable.OnPointerUpCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnHandlePointerUp));
			draggable.OnPointerBeginDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnHandleBeginDrag));
			draggable.OnPointerDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnHandleDrag));
			draggable.OnPointerEndDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnHandleDragFinish));
			draggable.OnPointerCancelCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnHandleDragFinish));
		}
	}

	// Token: 0x0600D631 RID: 54833 RVA: 0x003186A4 File Offset: 0x003168A4
	protected override void OnBeforeDestroy()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.OnStateChange.Remove(new Action<EToggleState>(this.OnToggleStateChange));
		}
		UUIDraggableComponent draggable = base.GetDraggable(9);
		if (draggable != null)
		{
			draggable.NeedInterruptDelegate.Unbind();
			draggable.OnPointerDownCallBack.Unbind();
			draggable.OnPointerUpCallBack.Unbind();
			draggable.OnPointerBeginDragCallBack.Unbind();
			draggable.OnPointerDragCallBack.Unbind();
			draggable.OnPointerEndDragCallBack.Unbind();
			draggable.OnPointerCancelCallBack.Unbind();
		}
	}

	// Token: 0x0600D632 RID: 54834 RVA: 0x00318730 File Offset: 0x00316930
	public override void Refresh(int formationId, bool isSelected, int gridIndex)
	{
		base.GridIndex = gridIndex;
		this.FormationId = formationId;
		FormationModel instance = FormationModel.Instance;
		this.RefreshFormationName();
		string resourceId = FormationDefine.FormationIndexSprites[formationId - 1];
		UUISprite spriteNum = base.GetSprite(3);
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
		this.SetSpriteByPath(resourcePath, spriteNum, false, null, delegate(bool _)
		{
			UUIExtendToggleSpriteTransition uuiextendToggleSpriteTransition = spriteNum.GetOwner().GetComponentByClass(UUIExtendToggleSpriteTransition.StaticClass()) as UUIExtendToggleSpriteTransition;
			if (uuiextendToggleSpriteTransition == null)
			{
				return;
			}
			uuiextendToggleSpriteTransition.SetAllStateSprite(spriteNum.GetSprite());
		});
		UUISprite sprite = base.GetSprite(6);
		if (sprite != null)
		{
			int? currentFormationId = instance.CurrentFormationId;
			sprite.SetUIActive(formationId == currentFormationId.GetValueOrDefault() & currentFormationId != null);
		}
		List<int> list = new List<int>();
		for (int i = 1; i <= 3; i++)
		{
			list.Add(instance.GetEditingRoleId(formationId, i));
		}
		GenericLayout<FormationEditHeadItem, int> headLayout = this.HeadLayout;
		if (headLayout != null)
		{
			headLayout.RefreshByData(list, null, false);
		}
		this.SetToggleChecked(isSelected);
	}

	// Token: 0x0600D633 RID: 54835 RVA: 0x00318813 File Offset: 0x00316A13
	public override void OnSelected(bool fireEvent)
	{
		this.SetToggleChecked(true);
	}

	// Token: 0x0600D634 RID: 54836 RVA: 0x0031881C File Offset: 0x00316A1C
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleChecked(false);
	}

	// Token: 0x0600D635 RID: 54837 RVA: 0x00318825 File Offset: 0x00316A25
	[NullableContext(1)]
	public override object GetKey(int data, int displayIndex)
	{
		return data;
	}

	// Token: 0x0600D636 RID: 54838 RVA: 0x0031882D File Offset: 0x00316A2D
	public void SetArrowVisible(bool canMoveUp, bool canMoveDown)
	{
		UUIItem item = base.GetItem(11);
		if (item != null)
		{
			item.SetUIActive(canMoveUp);
		}
		UUIItem item2 = base.GetItem(10);
		if (item2 == null)
		{
			return;
		}
		item2.SetUIActive(canMoveDown);
	}

	// Token: 0x0600D637 RID: 54839 RVA: 0x00318856 File Offset: 0x00316A56
	[NullableContext(1)]
	private static FormationEditHeadItem CreateHeadItem()
	{
		return new FormationEditHeadItem();
	}

	// Token: 0x0600D638 RID: 54840 RVA: 0x00318860 File Offset: 0x00316A60
	private void RefreshFormationName()
	{
		FormationData formationData = FormationModel.Instance.GetFormationData(this.FormationId);
		string text = (formationData != null) ? formationData.Name : null;
		if (string.IsNullOrEmpty(text))
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "PrefabTextItem_3608949261_Text", Array.Empty<object>());
			return;
		}
		UUIText text2 = base.GetText(1);
		if (text2 == null)
		{
			return;
		}
		text2.SetText(text, true);
	}

	// Token: 0x0600D639 RID: 54841 RVA: 0x003188C4 File Offset: 0x00316AC4
	private void OnClickEditName()
	{
		int formationId = this.FormationId;
		FormationController.Instance.OpenRenameFormationInputView(formationId, delegate
		{
			if (this.FormationId == formationId)
			{
				this.RefreshFormationName();
			}
			Action<int> onRenameSuccess = this.OnRenameSuccess;
			if (onRenameSuccess == null)
			{
				return;
			}
			onRenameSuccess(formationId);
		});
	}

	// Token: 0x0600D63A RID: 54842 RVA: 0x00318906 File Offset: 0x00316B06
	private bool OnDragNeedInterrupt(ULGUIBaseEventData eventData)
	{
		return false;
	}

	// Token: 0x0600D63B RID: 54843 RVA: 0x0031890C File Offset: 0x00316B0C
	private void OnHandlePointerDown(ULGUIPointerEventData eventData)
	{
		int maxFormationId = FormationConfig.Instance.GetMaxFormationId();
		this.SetArrowVisible(base.GridIndex > 0, base.GridIndex < maxFormationId - 1);
		UUIItem item = base.GetItem(5);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(true);
	}

	// Token: 0x0600D63C RID: 54844 RVA: 0x00318950 File Offset: 0x00316B50
	private void OnHandlePointerUp(ULGUIPointerEventData eventData)
	{
		UUIItem item = base.GetItem(5);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(false);
	}

	// Token: 0x0600D63D RID: 54845 RVA: 0x00318964 File Offset: 0x00316B64
	private void OnHandleBeginDrag(ULGUIPointerEventData eventData)
	{
		Action<FormationEditItem, ULGUIPointerEventData> onDragHandleBegin = this.OnDragHandleBegin;
		if (onDragHandleBegin == null)
		{
			return;
		}
		onDragHandleBegin(this, eventData);
	}

	// Token: 0x0600D63E RID: 54846 RVA: 0x00318978 File Offset: 0x00316B78
	private void OnHandleDrag(ULGUIPointerEventData eventData)
	{
		Action<ULGUIPointerEventData> onDragHandleMove = this.OnDragHandleMove;
		if (onDragHandleMove == null)
		{
			return;
		}
		onDragHandleMove(eventData);
	}

	// Token: 0x0600D63F RID: 54847 RVA: 0x0031898B File Offset: 0x00316B8B
	private void OnHandleDragFinish(ULGUIPointerEventData eventData)
	{
		UUIItem item = base.GetItem(5);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		Action onDragHandleEnd = this.OnDragHandleEnd;
		if (onDragHandleEnd == null)
		{
			return;
		}
		onDragHandleEnd();
	}

	// Token: 0x0600D640 RID: 54848 RVA: 0x003189B0 File Offset: 0x00316BB0
	private void SetToggleChecked(bool isChecked)
	{
		this.IsSelectedItem = isChecked;
		EToggleState state = isChecked ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.SetToggleState(state, false, false, false);
		}
		if (!this.IsDragOverlay)
		{
			UUIItem item = base.GetItem(4);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(isChecked);
		}
	}

	// Token: 0x0600D641 RID: 54849 RVA: 0x00318A00 File Offset: 0x00316C00
	private void OnToggleStateChange(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			if (!this.IsSelectedItem)
			{
				Func<int, int, bool> onToggleSelect = this.OnToggleSelect;
				if (onToggleSelect == null || !onToggleSelect(this.FormationId, base.GridIndex))
				{
					this.SetToggleChecked(false);
				}
			}
			return;
		}
		if (this.IsSelectedItem)
		{
			this.SetToggleChecked(true);
		}
	}

	// Token: 0x04006206 RID: 25094
	public bool IsDragOverlay;

	// Token: 0x04006207 RID: 25095
	public Func<int, int, bool> OnToggleSelect;

	// Token: 0x04006208 RID: 25096
	public Action<int> OnRenameSuccess;

	// Token: 0x04006209 RID: 25097
	[Nullable(new byte[]
	{
		2,
		1,
		2
	})]
	public Action<FormationEditItem, ULGUIPointerEventData> OnDragHandleBegin;

	// Token: 0x0400620A RID: 25098
	public Action<ULGUIPointerEventData> OnDragHandleMove;

	// Token: 0x0400620B RID: 25099
	public Action OnDragHandleEnd;

	// Token: 0x0400620C RID: 25100
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<FormationEditHeadItem, int> HeadLayout;

	// Token: 0x0400620D RID: 25101
	private int FormationId;

	// Token: 0x0400620E RID: 25102
	private bool IsSelectedItem;

	// Token: 0x020081AB RID: 33195
	[NullableContext(0)]
	private enum EItemChildType
	{
		// Token: 0x0402A501 RID: 173313
		TogItem,
		// Token: 0x0402A502 RID: 173314
		TxtName,
		// Token: 0x0402A503 RID: 173315
		BtnEditName,
		// Token: 0x0402A504 RID: 173316
		SpriteNum,
		// Token: 0x0402A505 RID: 173317
		BtnState,
		// Token: 0x0402A506 RID: 173318
		PanelArrowState,
		// Token: 0x0402A507 RID: 173319
		SpriteTeam,
		// Token: 0x0402A508 RID: 173320
		PanelHead,
		// Token: 0x0402A509 RID: 173321
		PanelHeadItem,
		// Token: 0x0402A50A RID: 173322
		DragItem,
		// Token: 0x0402A50B RID: 173323
		SpriteArrowDown,
		// Token: 0x0402A50C RID: 173324
		SpriteArrowUp
	}

	// Token: 0x020081AC RID: 33196
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0402A50D RID: 173325
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Func<FormationEditHeadItem> <0>__CreateHeadItem;
	}
}
