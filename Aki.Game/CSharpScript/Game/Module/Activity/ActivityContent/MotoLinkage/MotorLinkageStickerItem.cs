using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotoLinkage
{
	// Token: 0x02006455 RID: 25685
	public class MotorLinkageStickerItem : UiPanelBase
	{
		// Token: 0x060408D9 RID: 264409 RVA: 0x00FA00B4 File Offset: 0x00F9E2B4
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle))
			};
		}

		// Token: 0x060408DA RID: 264410 RVA: 0x00FA011C File Offset: 0x00F9E31C
		public void Refresh(int stickerId)
		{
			this.StickerId = stickerId;
			bool uiactive = this.IsReceived();
			UUIItem item = base.GetItem(1);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(uiactive);
		}

		// Token: 0x060408DB RID: 264411 RVA: 0x00FA0149 File Offset: 0x00F9E349
		public bool IsReceived()
		{
			return ActivityMotorLinkageController.Instance.ActivityData.IsStickerReceived(this.StickerId);
		}

		// Token: 0x060408DC RID: 264412 RVA: 0x00FA0160 File Offset: 0x00F9E360
		public void SetToggleSelect(bool isSelected, bool? fireEvent = null)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, fireEvent.GetValueOrDefault(), false, false);
		}

		// Token: 0x060408DD RID: 264413 RVA: 0x00FA0183 File Offset: 0x00F9E383
		private void OnClickToggle(EToggleState state)
		{
			if (this.StickerId == 0)
			{
				return;
			}
			Action clickToggleCallback = this.ClickToggleCallback;
			if (clickToggleCallback == null)
			{
				return;
			}
			clickToggleCallback();
		}

		// Token: 0x04021923 RID: 137507
		private int StickerId;

		// Token: 0x04021924 RID: 137508
		[Nullable(2)]
		public Action ClickToggleCallback;
	}
}
