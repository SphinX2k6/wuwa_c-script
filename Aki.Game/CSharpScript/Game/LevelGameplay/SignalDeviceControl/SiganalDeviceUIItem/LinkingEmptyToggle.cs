using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.SignalDeviceControl.SiganalDeviceUIItem
{
	// Token: 0x02006A53 RID: 27219
	[NullableContext(1)]
	[Nullable(0)]
	public class LinkingEmptyToggle : UiPanelBase
	{
		// Token: 0x06043B11 RID: 277265 RVA: 0x01090447 File Offset: 0x0108E647
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle))
			};
		}

		// Token: 0x06043B12 RID: 277266 RVA: 0x0109046A File Offset: 0x0108E66A
		protected override void OnStart()
		{
			EventSystem.Instance.Add<bool, IReadOnlyList<int>>(EEventName.OnSignalDeviceLinkingCheck, new Action<bool, IReadOnlyList<int>>(this.OnSignalDeviceLinkingCheck));
			EventSystem.Instance.Add(EEventName.OnSignalDeviceReset, new Action(this.OnSignalDeviceReset));
		}

		// Token: 0x06043B13 RID: 277267 RVA: 0x010904A4 File Offset: 0x0108E6A4
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.OnSignalDeviceLinkingCheck, new Action<bool, IReadOnlyList<int>>(this.OnSignalDeviceLinkingCheck));
			EventSystem.Instance.Remove(EEventName.OnSignalDeviceReset, new Action(this.OnSignalDeviceReset));
		}

		// Token: 0x06043B14 RID: 277268 RVA: 0x010904DE File Offset: 0x0108E6DE
		public void InitData(int index)
		{
			this.Index = index;
			base.GetExtendToggle(0).OnHover.Add(new Action(this.OnToggleHover));
		}

		// Token: 0x06043B15 RID: 277269 RVA: 0x01090504 File Offset: 0x0108E704
		public void SetDotData(UUIItem item, EPieceColorType color)
		{
			this.LinkingDotItem = new LinkingDotItem();
			this.LinkingDotItem.CreateThenShowByActor(item.GetOwner(), null);
			this.LinkingDotItem.InitIcon(color);
			this.Color = color;
			this.LongPress = new LongPressButtonItem(null, new LongPressButtonItem.ELongPressConfigId?(LongPressButtonItem.ELongPressConfigId.LongPressOne), null);
			this.LongPress.Initialize(base.GetExtendToggle(0), null, new Action(this.OnTogglePress), new Action(this.OnToggleRelease), new Action(this.OnToggleCancel));
		}

		// Token: 0x06043B16 RID: 277270 RVA: 0x01090598 File Offset: 0x0108E798
		public void SetLineData(UUIItem item, LinkingLineItem itemClass, ENeighborType neighborType, int from, bool isFromDot)
		{
			this.LinkingLineItem = itemClass;
			this.LinkingLineItem.CreateThenShowByActor(item.GetOwner(), null);
			this.LinkingLineItem.InitIcon(neighborType, true);
			this.FromIndex = from;
			this.IsFromDot = isFromDot;
		}

		// Token: 0x06043B17 RID: 277271 RVA: 0x010905D0 File Offset: 0x0108E7D0
		public void ResetStraightLineData(UUIItem item, LinkingLineItem itemClass, int to)
		{
			this.LinkingLineItem.Destroy(null);
			this.LinkingLineItem = itemClass;
			this.LinkingLineItem.CreateThenShowByActor(item.GetOwner(), null);
			if (itemClass.LineType == ELineType.LinkingLineStraight)
			{
				this.LinkingLineItem.InitIcon((Math.Abs(this.FromIndex - to) == 2) ? ENeighborType.ToLeft : ENeighborType.ToDown, false);
				return;
			}
			if (itemClass.LineType == ELineType.LinkingLineWithDotStraight)
			{
				if (this.FromIndex - to == -SignalDeviceModel.ROWNUM * 2)
				{
					this.LinkingLineItem.InitIcon(this.IsFromDot ? ENeighborType.ToDown : ENeighborType.ToUp, false);
					return;
				}
				if (this.FromIndex - to == SignalDeviceModel.ROWNUM * 2)
				{
					this.LinkingLineItem.InitIcon(this.IsFromDot ? ENeighborType.ToUp : ENeighborType.ToDown, false);
					return;
				}
				if (this.FromIndex - to == 2)
				{
					this.LinkingLineItem.InitIcon(this.IsFromDot ? ENeighborType.ToLeft : ENeighborType.ToRight, false);
					return;
				}
				this.LinkingLineItem.InitIcon(this.IsFromDot ? ENeighborType.ToRight : ENeighborType.ToLeft, false);
			}
		}

		// Token: 0x06043B18 RID: 277272 RVA: 0x010906C9 File Offset: 0x0108E8C9
		public void ClearLineData()
		{
			this.LinkingLineItem.Destroy(null);
			this.LinkingLineItem = null;
		}

		// Token: 0x06043B19 RID: 277273 RVA: 0x010906E0 File Offset: 0x0108E8E0
		public void SetLineHalf()
		{
			ENeighborType lineHalf = SignalDeviceModel.Instance.NeighboringType(this.FromIndex, this.Index);
			this.LinkingLineItem.SetLineHalf(lineHalf);
		}

		// Token: 0x06043B1A RID: 277274 RVA: 0x01090710 File Offset: 0x0108E910
		public void ResetCornerLineData(UUIItem item, LinkingLineItem itemClass, int from, int to, bool isToDot)
		{
			this.LinkingLineItem.Destroy(null);
			this.LinkingLineItem = itemClass;
			this.LinkingLineItem.CreateThenShowByActor(item.GetOwner(), null);
			int num = from - this.FromIndex;
			int num2 = to - from;
			if (itemClass.LineType == ELineType.LinkingLineCorner)
			{
				if (num * num2 == -SignalDeviceModel.ROWNUM)
				{
					this.LinkingLineItem.InitIcon((num < num2) ? ENeighborType.ToLeft : ENeighborType.ToRight, false);
					return;
				}
				this.LinkingLineItem.InitIcon((num < num2) ? ENeighborType.ToUp : ENeighborType.ToDown, false);
				return;
			}
			else if (itemClass.LineType == ELineType.LinkingLineWithDotCornerLeft)
			{
				if (num * num2 == -SignalDeviceModel.ROWNUM)
				{
					this.LinkingLineItem.InitIcon((num < num2) ? ENeighborType.ToLeft : ENeighborType.ToRight, false);
					return;
				}
				this.LinkingLineItem.InitIcon((num < num2) ? ENeighborType.ToUp : ENeighborType.ToDown, false);
				return;
			}
			else
			{
				if (num * num2 == SignalDeviceModel.ROWNUM)
				{
					this.LinkingLineItem.InitIcon((num < num2) ? ENeighborType.ToLeft : ENeighborType.ToRight, false);
					return;
				}
				this.LinkingLineItem.InitIcon((num < num2) ? ENeighborType.ToDown : ENeighborType.ToUp, false);
				return;
			}
		}

		// Token: 0x06043B1B RID: 277275 RVA: 0x01090800 File Offset: 0x0108EA00
		private void OnToggleHover()
		{
			if (SignalDeviceModel.Instance.CurrentColor > EPieceColorType.White)
			{
				AudioSystem.Instance.PostEvent("play_amb_interact_signal_ui_drag");
			}
			else
			{
				AudioSystem.Instance.PostEvent("play_amb_interact_signal_ui_move");
			}
			SignalDeviceController.Instance.OnHovering(this.Index);
		}

		// Token: 0x06043B1C RID: 277276 RVA: 0x01090850 File Offset: 0x0108EA50
		private void OnTogglePress()
		{
			this.LinkingDotItem.OnPressed(true);
			SignalDeviceController.Instance.OnDotPressed(this.Index, this.Color);
			if (SignalDeviceModel.Instance.CurrentColor > EPieceColorType.White)
			{
				AudioSystem.Instance.PostEvent("play_amb_interact_signal_ui_choose");
			}
		}

		// Token: 0x06043B1D RID: 277277 RVA: 0x0109089F File Offset: 0x0108EA9F
		private void OnToggleRelease()
		{
			SignalDeviceController.Instance.CheckLinking(this.Index);
		}

		// Token: 0x06043B1E RID: 277278 RVA: 0x010908B1 File Offset: 0x0108EAB1
		private void OnToggleCancel()
		{
			SignalDeviceController.Instance.CheckLinking(this.Index);
		}

		// Token: 0x06043B1F RID: 277279 RVA: 0x010908C4 File Offset: 0x0108EAC4
		private void OnSignalDeviceLinkingCheck(bool isSuccess, IReadOnlyList<int> indexArray)
		{
			if (isSuccess && indexArray.Contains(this.Index))
			{
				LinkingDotItem linkingDotItem = this.LinkingDotItem;
				if (linkingDotItem != null)
				{
					linkingDotItem.OnLinked();
				}
				LinkingDotItem linkingDotItem2 = this.LinkingDotItem;
				if (linkingDotItem2 != null)
				{
					linkingDotItem2.SetFxBoost(true);
				}
				base.GetExtendToggle(0).SetEnable(false);
			}
			if (!isSuccess && indexArray.Contains(this.Index))
			{
				LinkingDotItem linkingDotItem3 = this.LinkingDotItem;
				if (linkingDotItem3 != null)
				{
					linkingDotItem3.OnPressed(false);
				}
				LinkingDotItem linkingDotItem4 = this.LinkingDotItem;
				if (linkingDotItem4 != null)
				{
					linkingDotItem4.RotateLine(false, ENeighborType.None);
				}
				LinkingLineItem linkingLineItem = this.LinkingLineItem;
				if (linkingLineItem == null)
				{
					return;
				}
				linkingLineItem.Destroy(null);
			}
		}

		// Token: 0x06043B20 RID: 277280 RVA: 0x0109095C File Offset: 0x0108EB5C
		private void OnSignalDeviceReset()
		{
			base.GetExtendToggle(0).SetEnable(true);
			LinkingDotItem linkingDotItem = this.LinkingDotItem;
			if (linkingDotItem != null)
			{
				linkingDotItem.ResetIcon();
			}
			LinkingDotItem linkingDotItem2 = this.LinkingDotItem;
			if (linkingDotItem2 != null)
			{
				linkingDotItem2.RotateLine(false, ENeighborType.None);
			}
			LinkingLineItem linkingLineItem = this.LinkingLineItem;
			if (linkingLineItem == null)
			{
				return;
			}
			linkingLineItem.Destroy(null);
		}

		// Token: 0x06043B21 RID: 277281 RVA: 0x010909AC File Offset: 0x0108EBAC
		public void SetDotRay(bool isActive, ENeighborType neighborType = ENeighborType.None)
		{
			LinkingDotItem linkingDotItem = this.LinkingDotItem;
			if (linkingDotItem == null)
			{
				return;
			}
			linkingDotItem.RotateLine(isActive, neighborType);
		}

		// Token: 0x04023589 RID: 144777
		private int Index = -1;

		// Token: 0x0402358A RID: 144778
		public int FromIndex = -1;

		// Token: 0x0402358B RID: 144779
		public bool IsFromDot;

		// Token: 0x0402358C RID: 144780
		private EPieceColorType Color;

		// Token: 0x0402358D RID: 144781
		[Nullable(2)]
		private LongPressButtonItem LongPress;

		// Token: 0x0402358E RID: 144782
		[Nullable(2)]
		private LinkingDotItem LinkingDotItem;

		// Token: 0x0402358F RID: 144783
		[Nullable(2)]
		private LinkingLineItem LinkingLineItem;

		// Token: 0x0200CB7D RID: 52093
		[NullableContext(0)]
		public enum EComponents
		{
			// Token: 0x0403D6EF RID: 251631
			UiItem_LinkEmpty
		}
	}
}
