using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotoLinkage
{
	// Token: 0x020053D3 RID: 21459
	public class MotorLinkageStickerItem : UiPanelBase
	{
		// Token: 0x0603559A RID: 218522 RVA: 0x00EE7030 File Offset: 0x00EE5230
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

		// Token: 0x0603559B RID: 218523 RVA: 0x00EE7098 File Offset: 0x00EE5298
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

		// Token: 0x0603559C RID: 218524 RVA: 0x00EE70C5 File Offset: 0x00EE52C5
		public bool IsReceived()
		{
			return ActivityMotorLinkageController.Instance.ActivityData.IsStickerReceived(this.StickerId);
		}

		// Token: 0x0603559D RID: 218525 RVA: 0x00EE70DC File Offset: 0x00EE52DC
		public void SetToggleSelect(bool isSelected, bool? fireEvent = null)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, fireEvent.GetValueOrDefault(), false, false);
		}

		// Token: 0x0603559E RID: 218526 RVA: 0x00EE70FF File Offset: 0x00EE52FF
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

		// Token: 0x0401C252 RID: 115282
		private int StickerId;

		// Token: 0x0401C253 RID: 115283
		[Nullable(2)]
		public Action ClickToggleCallback;
	}
}
