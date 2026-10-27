using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002486 RID: 9350
[NullableContext(1)]
[Nullable(0)]
public class PhantomInteractListPanel : UiPanelBase
{
	// Token: 0x1700189C RID: 6300
	// (get) Token: 0x06012C2D RID: 76845 RVA: 0x004A0517 File Offset: 0x0049E717
	// (set) Token: 0x06012C2E RID: 76846 RVA: 0x004A051F File Offset: 0x0049E71F
	public bool UseLongPress { get; set; }

	// Token: 0x06012C2F RID: 76847 RVA: 0x004A0528 File Offset: 0x0049E728
	public PhantomInteractListPanel(bool useLongPress)
	{
		this.UseLongPress = useLongPress;
	}

	// Token: 0x06012C30 RID: 76848 RVA: 0x004A0568 File Offset: 0x0049E768
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem))
		};
	}

	// Token: 0x06012C31 RID: 76849 RVA: 0x004A0648 File Offset: 0x0049E848
	protected override UniTask OnBeforeStartAsync()
	{
		PhantomInteractListPanel.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomInteractListPanel.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012C32 RID: 76850 RVA: 0x004A068C File Offset: 0x0049E88C
	private void RefreshLongPressItemPosition()
	{
		FVector? pointerEventDataPosition = LguiEventSystemManager.Instance.GetPointerEventDataPosition(0);
		Vector2D vector2D = Vector2D.Create((double)pointerEventDataPosition.Value.X, (double)pointerEventDataPosition.Value.Y);
		Vector2D vector2D2 = vector2D;
		ULGUICanvasScaler canvasScaler = UiLayer.Instance.UiRootItem.GetCanvasScaler();
		FVector2D fvector2D = vector2D.ToUeVector2D(false);
		vector2D2.FromUeVector2D(canvasScaler.ConvertPositionFromViewportToLGUICanvas(fvector2D));
		float offsetX = this.LongPressParam.OffsetX;
		float offsetY = this.LongPressParam.OffsetY;
		float inX = (float)vector2D.X + offsetX;
		float inY = (float)vector2D.Y + offsetY;
		UUIItem item = base.GetItem(8);
		FVector fvector = new FVector(inX, inY, 0f);
		item.SetLGUISpaceAbsolutePosition(fvector);
	}

	// Token: 0x06012C33 RID: 76851 RVA: 0x004A073B File Offset: 0x0049E93B
	private void ClearDragClickTick()
	{
		if (this.LongPressTick != -1)
		{
			TickSystem.Instance.Remove(this.LongPressTick);
			this.LongPressTick = -1;
		}
	}

	// Token: 0x06012C34 RID: 76852 RVA: 0x004A075E File Offset: 0x0049E95E
	protected override void OnBeforeDestroy()
	{
		this.ClearDragClickTick();
	}

	// Token: 0x06012C35 RID: 76853 RVA: 0x004A0768 File Offset: 0x0049E968
	private void OnLongPressTick(float _)
	{
		ValueTuple<bool, bool> valueTuple = this.LongPressContext.Update(Time.Instance.DeltaTime);
		bool item = valueTuple.Item1;
		bool item2 = valueTuple.Item2;
		if (this.LongPressContext.IsBeforeLongPressThreshold())
		{
			return;
		}
		if (this.LongPressContext.CheckIsMoved())
		{
			this.OnListItemPointerUp(this.LongPressItemData);
			return;
		}
		if (item)
		{
			this.RefreshLongPressItemPosition();
		}
		if (this.LongPressContext.LongPressProgress < 1f)
		{
			PhantomInteractListLongPressPanel longPressPanel = this.LongPressPanel;
			if (longPressPanel != null)
			{
				longPressPanel.SetUiActive(true);
			}
			PhantomInteractListLongPressPanel longPressPanel2 = this.LongPressPanel;
			if (longPressPanel2 != null)
			{
				longPressPanel2.SetFillProgress(this.LongPressContext.LongPressProgress);
			}
		}
		else
		{
			PhantomInteractListLongPressPanel longPressPanel3 = this.LongPressPanel;
			if (longPressPanel3 != null)
			{
				longPressPanel3.SetUiActive(false);
			}
		}
		if (item2 && this.OnHoverCb != null && this.LongPressItemData != null)
		{
			this.OnHoverCb(this.LongPressItemData, true);
		}
	}

	// Token: 0x06012C36 RID: 76854 RVA: 0x004A0841 File Offset: 0x0049EA41
	private void OnListItemClick(IPhantomInteractItemData itemData)
	{
		if (this.OnClickCb != null)
		{
			this.OnClickCb(itemData);
		}
	}

	// Token: 0x06012C37 RID: 76855 RVA: 0x004A0857 File Offset: 0x0049EA57
	private void OnListItemHover(IPhantomInteractItemData itemData, bool isHover)
	{
		if (this.OnHoverCb != null)
		{
			this.OnHoverCb(itemData, isHover);
		}
	}

	// Token: 0x06012C38 RID: 76856 RVA: 0x004A0870 File Offset: 0x0049EA70
	private void OnListItemPointerDown(IPhantomInteractItemData itemData)
	{
		if (itemData.MonsterId <= 0)
		{
			return;
		}
		this.ClearDragClickTick();
		this.LongPressItemData = itemData;
		Ticker ticker = TickSystem.Instance.Add(new Action<float>(this.OnLongPressTick), "PhantomInteractDetailPressTick", ETickingGroup.TG_PrePhysics, true, 0, true);
		if (ticker != null)
		{
			this.LongPressTick = ticker.Id;
		}
		LongPressContext longPressContext = this.LongPressContext;
		if (longPressContext != null)
		{
			longPressContext.Reset();
		}
		LongPressContext longPressContext2 = this.LongPressContext;
		if (longPressContext2 != null)
		{
			longPressContext2.Start();
		}
		PhantomInteractListLongPressPanel longPressPanel = this.LongPressPanel;
		if (longPressPanel == null)
		{
			return;
		}
		longPressPanel.SetFillProgress(0f);
	}

	// Token: 0x06012C39 RID: 76857 RVA: 0x004A08FC File Offset: 0x0049EAFC
	private void OnListItemPointerUp(IPhantomInteractItemData itemData)
	{
		if (this.LongPressContext.IsBeforeLongPressThreshold())
		{
			if (this.OnClickCb != null)
			{
				this.OnClickCb(itemData);
			}
		}
		else if (this.OnHoverCb != null)
		{
			this.OnHoverCb(itemData, false);
		}
		this.ClearDragClickTick();
		this.LongPressItemData = null;
		PhantomInteractListLongPressPanel longPressPanel = this.LongPressPanel;
		if (longPressPanel != null)
		{
			longPressPanel.SetUiActive(false);
		}
		this.LongPressContext.Reset();
	}

	// Token: 0x06012C3A RID: 76858 RVA: 0x004A096C File Offset: 0x0049EB6C
	private void OnListItemToggleChange(PhantomInteractListItem item, IPhantomInteractItemData itemData, bool isOn)
	{
		bool flag = itemData.ItemIndex == this.SelectIndex;
		if (isOn != flag)
		{
			item.SetSelected(flag);
		}
	}

	// Token: 0x06012C3B RID: 76859 RVA: 0x004A0994 File Offset: 0x0049EB94
	public void Refresh(List<IPhantomInteractItemData> itemDataList, bool showIndex, bool needAnim = true)
	{
		for (int i = 0; i < this.TogItems.Count; i++)
		{
			IPhantomInteractItemData itemData = null;
			if (i < itemDataList.Count)
			{
				itemData = itemDataList[i];
			}
			this.TogItems[i].Refresh(itemData, showIndex, needAnim);
		}
	}

	// Token: 0x06012C3C RID: 76860 RVA: 0x004A09E0 File Offset: 0x0049EBE0
	public void SetSelectedItem(int index)
	{
		this.SelectIndex = index;
		foreach (PhantomInteractListItem phantomInteractListItem in this.TogItems)
		{
			phantomInteractListItem.SetSelected(index == phantomInteractListItem.ItemIndex);
		}
	}

	// Token: 0x06012C3D RID: 76861 RVA: 0x004A0A44 File Offset: 0x0049EC44
	private static ILongPressParam LoadLongPressParam()
	{
		return new LongPressParam
		{
			BeforeLongPressThreshold = (float)ConfigCommonParamById.GetIntConfig("PhantomInteractBeforeLongPressTime").GetValueOrDefault(),
			LongPressThreshold = (float)ConfigCommonParamById.GetIntConfig("PhantomInteractLongPressTime").GetValueOrDefault(),
			InvalidMoveDistance = (float)ConfigCommonParamById.GetIntConfig("PhantomInteractLongPressMoveDistance").GetValueOrDefault(),
			OffsetX = ConfigCommonParamById.GetFloatConfig("VisionScrollerOffsetX").GetValueOrDefault(),
			OffsetY = ConfigCommonParamById.GetFloatConfig("VisionScrollerOffsetY").GetValueOrDefault()
		};
	}

	// Token: 0x04008D4B RID: 36171
	private PhantomInteractListPanel.EComponent[] allTogItems = new PhantomInteractListPanel.EComponent[]
	{
		PhantomInteractListPanel.EComponent.TogItemT1,
		PhantomInteractListPanel.EComponent.TogItemT2,
		PhantomInteractListPanel.EComponent.TogItemT3,
		PhantomInteractListPanel.EComponent.TogItemT4,
		PhantomInteractListPanel.EComponent.TogItemB1,
		PhantomInteractListPanel.EComponent.TogItemB2,
		PhantomInteractListPanel.EComponent.TogItemB3,
		PhantomInteractListPanel.EComponent.TogItemB4
	};

	// Token: 0x04008D4C RID: 36172
	private readonly List<PhantomInteractListItem> TogItems = new List<PhantomInteractListItem>();

	// Token: 0x04008D4D RID: 36173
	[Nullable(2)]
	private PhantomInteractListLongPressPanel LongPressPanel;

	// Token: 0x04008D4E RID: 36174
	[Nullable(2)]
	private ILongPressParam LongPressParam;

	// Token: 0x04008D4F RID: 36175
	[Nullable(2)]
	private LongPressContext LongPressContext;

	// Token: 0x04008D50 RID: 36176
	private int LongPressTick = -1;

	// Token: 0x04008D51 RID: 36177
	[Nullable(2)]
	private IPhantomInteractItemData LongPressItemData;

	// Token: 0x04008D52 RID: 36178
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<IPhantomInteractItemData> OnClickCb;

	// Token: 0x04008D53 RID: 36179
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<IPhantomInteractItemData, bool> OnHoverCb;

	// Token: 0x04008D54 RID: 36180
	private int SelectIndex = -1;

	// Token: 0x020089F9 RID: 35321
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402CCE5 RID: 183525
		TogItemT1,
		// Token: 0x0402CCE6 RID: 183526
		TogItemT2,
		// Token: 0x0402CCE7 RID: 183527
		TogItemT3,
		// Token: 0x0402CCE8 RID: 183528
		TogItemT4,
		// Token: 0x0402CCE9 RID: 183529
		TogItemB1,
		// Token: 0x0402CCEA RID: 183530
		TogItemB2,
		// Token: 0x0402CCEB RID: 183531
		TogItemB3,
		// Token: 0x0402CCEC RID: 183532
		TogItemB4,
		// Token: 0x0402CCED RID: 183533
		ItemLongPress
	}
}
