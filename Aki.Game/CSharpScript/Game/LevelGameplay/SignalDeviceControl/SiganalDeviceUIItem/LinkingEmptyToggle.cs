using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.SignalDeviceControl.SiganalDeviceUIItem
{
	// Token: 0x02005BB0 RID: 23472
	[NullableContext(1)]
	[Nullable(0)]
	public class LinkingEmptyToggle : UiPanelBase
	{
		// Token: 0x06039B5F RID: 236383 RVA: 0x01034C6B File Offset: 0x01032E6B
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle))
			};
		}

		// Token: 0x06039B60 RID: 236384 RVA: 0x01034C8E File Offset: 0x01032E8E
		protected override void OnStart()
		{
			EventSystem.Instance.Add<bool, IReadOnlyList<int>>(EEventName.OnSignalDeviceLinkingCheck, new Action<bool, IReadOnlyList<int>>(this.OnSignalDeviceLinkingCheck));
			EventSystem.Instance.Add(EEventName.OnSignalDeviceReset, new Action(this.OnSignalDeviceReset));
		}

		// Token: 0x06039B61 RID: 236385 RVA: 0x01034CC8 File Offset: 0x01032EC8
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.OnSignalDeviceLinkingCheck, new Action<bool, IReadOnlyList<int>>(this.OnSignalDeviceLinkingCheck));
			EventSystem.Instance.Remove(EEventName.OnSignalDeviceReset, new Action(this.OnSignalDeviceReset));
		}

		// Token: 0x06039B62 RID: 236386 RVA: 0x01034D02 File Offset: 0x01032F02
		public void InitData(int index)
		{
			this.Index = index;
			base.GetExtendToggle(0).OnHover.Add(new Action(this.OnToggleHover));
		}

		// Token: 0x06039B63 RID: 236387 RVA: 0x01034D28 File Offset: 0x01032F28
		public void SetDotData(UUIItem item, EPieceColorType color)
		{
			this.LinkingDotItem = new LinkingDotItem();
			this.LinkingDotItem.CreateThenShowByActor(item.GetOwner(), null);
			this.LinkingDotItem.InitIcon(color);
			this.Color = color;
			this.LongPress = new LongPressButtonItem(null, new LongPressButtonItem.ELongPressConfigId?(LongPressButtonItem.ELongPressConfigId.LongPressOne), null);
			this.LongPress.Initialize(base.GetExtendToggle(0), null, new Action(this.OnTogglePress), new Action(this.OnToggleRelease), new Action(this.OnToggleCancel));
		}

		// Token: 0x06039B64 RID: 236388 RVA: 0x01034DBC File Offset: 0x01032FBC
		public void SetLineData(UUIItem item, LinkingLineItem itemClass, ENeighborType neighborType, int from, bool isFromDot)
		{
			this.LinkingLineItem = itemClass;
			this.LinkingLineItem.CreateThenShowByActor(item.GetOwner(), null);
			this.LinkingLineItem.InitIcon(neighborType, true);
			this.FromIndex = from;
			this.IsFromDot = isFromDot;
		}

		// Token: 0x06039B65 RID: 236389 RVA: 0x01034DF4 File Offset: 0x01032FF4
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

		// Token: 0x06039B66 RID: 236390 RVA: 0x01034EED File Offset: 0x010330ED
		public void ClearLineData()
		{
			this.LinkingLineItem.Destroy(null);
			this.LinkingLineItem = null;
		}

		// Token: 0x06039B67 RID: 236391 RVA: 0x01034F04 File Offset: 0x01033104
		public void SetLineHalf()
		{
			ENeighborType lineHalf = SignalDeviceModel.Instance.NeighboringType(this.FromIndex, this.Index);
			this.LinkingLineItem.SetLineHalf(lineHalf);
		}

		// Token: 0x06039B68 RID: 236392 RVA: 0x01034F34 File Offset: 0x01033134
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

		// Token: 0x06039B69 RID: 236393 RVA: 0x01035024 File Offset: 0x01033224
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

		// Token: 0x06039B6A RID: 236394 RVA: 0x01035074 File Offset: 0x01033274
		private void OnTogglePress()
		{
			this.LinkingDotItem.OnPressed(true);
			SignalDeviceController.Instance.OnDotPressed(this.Index, this.Color);
			if (SignalDeviceModel.Instance.CurrentColor > EPieceColorType.White)
			{
				AudioSystem.Instance.PostEvent("play_amb_interact_signal_ui_choose");
			}
		}

		// Token: 0x06039B6B RID: 236395 RVA: 0x010350C3 File Offset: 0x010332C3
		private void OnToggleRelease()
		{
			SignalDeviceController.Instance.CheckLinking(this.Index);
		}

		// Token: 0x06039B6C RID: 236396 RVA: 0x010350D5 File Offset: 0x010332D5
		private void OnToggleCancel()
		{
			SignalDeviceController.Instance.CheckLinking(this.Index);
		}

		// Token: 0x06039B6D RID: 236397 RVA: 0x010350E8 File Offset: 0x010332E8
		private void OnSignalDeviceLinkingCheck(bool isSuccess, IReadOnlyList<int> indexArray)
		{
			bool flag = false;
			for (int i = 0; i < indexArray.Count; i++)
			{
				if (indexArray[i] == this.Index)
				{
					flag = true;
					break;
				}
			}
			if (isSuccess && flag)
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
			if (!isSuccess && flag)
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

		// Token: 0x06039B6E RID: 236398 RVA: 0x01035190 File Offset: 0x01033390
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

		// Token: 0x06039B6F RID: 236399 RVA: 0x010351E0 File Offset: 0x010333E0
		public void SetDotRay(bool isActive, ENeighborType neighborType = ENeighborType.None)
		{
			LinkingDotItem linkingDotItem = this.LinkingDotItem;
			if (linkingDotItem == null)
			{
				return;
			}
			linkingDotItem.RotateLine(isActive, neighborType);
		}

		// Token: 0x0401E77B RID: 124795
		private int Index = -1;

		// Token: 0x0401E77C RID: 124796
		public int FromIndex = -1;

		// Token: 0x0401E77D RID: 124797
		public bool IsFromDot;

		// Token: 0x0401E77E RID: 124798
		private EPieceColorType Color;

		// Token: 0x0401E77F RID: 124799
		[Nullable(2)]
		private LongPressButtonItem LongPress;

		// Token: 0x0401E780 RID: 124800
		[Nullable(2)]
		private LinkingDotItem LinkingDotItem;

		// Token: 0x0401E781 RID: 124801
		[Nullable(2)]
		private LinkingLineItem LinkingLineItem;

		// Token: 0x0200B75C RID: 46940
		[NullableContext(0)]
		public enum EComponents
		{
			// Token: 0x04038AD1 RID: 232145
			UiItem_LinkEmpty
		}
	}
}
