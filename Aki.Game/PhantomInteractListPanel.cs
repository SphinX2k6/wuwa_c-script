using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200196B RID: 6507
[NullableContext(1)]
[Nullable(0)]
public class PhantomInteractListPanel : UiPanelBase
{
	// Token: 0x170018D6 RID: 6358
	// (get) Token: 0x060100E4 RID: 65764 RVA: 0x004ADC6F File Offset: 0x004ABE6F
	// (set) Token: 0x060100E5 RID: 65765 RVA: 0x004ADC77 File Offset: 0x004ABE77
	public bool UseLongPress { get; set; }

	// Token: 0x060100E6 RID: 65766 RVA: 0x004ADC80 File Offset: 0x004ABE80
	public PhantomInteractListPanel(bool useLongPress)
	{
		this.UseLongPress = useLongPress;
	}

	// Token: 0x060100E7 RID: 65767 RVA: 0x004ADCC0 File Offset: 0x004ABEC0
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

	// Token: 0x060100E8 RID: 65768 RVA: 0x004ADDA0 File Offset: 0x004ABFA0
	protected override UniTask OnBeforeStartAsync()
	{
		PhantomInteractListPanel.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomInteractListPanel.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060100E9 RID: 65769 RVA: 0x004ADDE4 File Offset: 0x004ABFE4
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

	// Token: 0x060100EA RID: 65770 RVA: 0x004ADE93 File Offset: 0x004AC093
	private void ClearDragClickTick()
	{
		if (this.LongPressTick != -1)
		{
			TickSystem.Instance.Remove(this.LongPressTick);
			this.LongPressTick = -1;
		}
	}

	// Token: 0x060100EB RID: 65771 RVA: 0x004ADEB6 File Offset: 0x004AC0B6
	protected override void OnBeforeDestroy()
	{
		this.ClearDragClickTick();
	}

	// Token: 0x060100EC RID: 65772 RVA: 0x004ADEC0 File Offset: 0x004AC0C0
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

	// Token: 0x060100ED RID: 65773 RVA: 0x004ADF99 File Offset: 0x004AC199
	private void OnListItemClick(IPhantomInteractItemData itemData)
	{
		if (this.OnClickCb != null)
		{
			this.OnClickCb(itemData);
		}
	}

	// Token: 0x060100EE RID: 65774 RVA: 0x004ADFAF File Offset: 0x004AC1AF
	private void OnListItemHover(IPhantomInteractItemData itemData, bool isHover)
	{
		if (this.OnHoverCb != null)
		{
			this.OnHoverCb(itemData, isHover);
		}
	}

	// Token: 0x060100EF RID: 65775 RVA: 0x004ADFC8 File Offset: 0x004AC1C8
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

	// Token: 0x060100F0 RID: 65776 RVA: 0x004AE054 File Offset: 0x004AC254
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

	// Token: 0x060100F1 RID: 65777 RVA: 0x004AE0C4 File Offset: 0x004AC2C4
	private void OnListItemToggleChange(PhantomInteractListItem item, IPhantomInteractItemData itemData, bool isOn)
	{
		bool flag = itemData.ItemIndex == this.SelectIndex;
		if (isOn != flag)
		{
			item.SetSelected(flag);
		}
	}

	// Token: 0x060100F2 RID: 65778 RVA: 0x004AE0EC File Offset: 0x004AC2EC
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

	// Token: 0x060100F3 RID: 65779 RVA: 0x004AE138 File Offset: 0x004AC338
	public void SetSelectedItem(int index)
	{
		this.SelectIndex = index;
		foreach (PhantomInteractListItem phantomInteractListItem in this.TogItems)
		{
			phantomInteractListItem.SetSelected(index == phantomInteractListItem.ItemIndex);
		}
	}

	// Token: 0x060100F4 RID: 65780 RVA: 0x004AE19C File Offset: 0x004AC39C
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

	// Token: 0x04008E92 RID: 36498
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

	// Token: 0x04008E93 RID: 36499
	private readonly List<PhantomInteractListItem> TogItems = new List<PhantomInteractListItem>();

	// Token: 0x04008E94 RID: 36500
	[Nullable(2)]
	private PhantomInteractListLongPressPanel LongPressPanel;

	// Token: 0x04008E95 RID: 36501
	[Nullable(2)]
	private ILongPressParam LongPressParam;

	// Token: 0x04008E96 RID: 36502
	[Nullable(2)]
	private LongPressContext LongPressContext;

	// Token: 0x04008E97 RID: 36503
	private int LongPressTick = -1;

	// Token: 0x04008E98 RID: 36504
	[Nullable(2)]
	private IPhantomInteractItemData LongPressItemData;

	// Token: 0x04008E99 RID: 36505
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<IPhantomInteractItemData> OnClickCb;

	// Token: 0x04008E9A RID: 36506
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<IPhantomInteractItemData, bool> OnHoverCb;

	// Token: 0x04008E9B RID: 36507
	private int SelectIndex = -1;

	// Token: 0x02007B80 RID: 31616
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04027FFB RID: 163835
		TogItemT1,
		// Token: 0x04027FFC RID: 163836
		TogItemT2,
		// Token: 0x04027FFD RID: 163837
		TogItemT3,
		// Token: 0x04027FFE RID: 163838
		TogItemT4,
		// Token: 0x04027FFF RID: 163839
		TogItemB1,
		// Token: 0x04028000 RID: 163840
		TogItemB2,
		// Token: 0x04028001 RID: 163841
		TogItemB3,
		// Token: 0x04028002 RID: 163842
		TogItemB4,
		// Token: 0x04028003 RID: 163843
		ItemLongPress
	}
}
