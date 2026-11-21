using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.View.InstanceEntrance
{
	// Token: 0x02004EFF RID: 20223
	[NullableContext(1)]
	[Nullable(0)]
	internal class SubContentItem : UiPanelBase
	{
		// Token: 0x06032D25 RID: 208165 RVA: 0x00E447FC File Offset: 0x00E429FC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickExtendToggle));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06032D26 RID: 208166 RVA: 0x00E44908 File Offset: 0x00E42B08
		public void RefreshView(ActivityEntranceItemData data)
		{
			this.ItemData = data;
			this.RefreshToggleState(this.ItemData);
			this.RefreshLockItem(this.ItemData);
			this.RefreshFinishItem(this.ItemData);
			this.RefreshDifficultIcon(this.ItemData);
			this.RefreshDescText(this.ItemData);
		}

		// Token: 0x06032D27 RID: 208167 RVA: 0x00E44958 File Offset: 0x00E42B58
		private void RefreshToggleState(ActivityEntranceItemData data)
		{
			bool selectState = data.GetSelectState();
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(selectState ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x06032D28 RID: 208168 RVA: 0x00E44988 File Offset: 0x00E42B88
		private void RefreshLockItem(ActivityEntranceItemData data)
		{
			bool lockState = data.GetLockState();
			base.GetItem(3).SetUIActive(lockState);
		}

		// Token: 0x06032D29 RID: 208169 RVA: 0x00E449AC File Offset: 0x00E42BAC
		private void RefreshFinishItem(ActivityEntranceItemData data)
		{
			bool finishState = data.GetFinishState();
			base.GetItem(4).SetUIActive(finishState);
		}

		// Token: 0x06032D2A RID: 208170 RVA: 0x00E449D0 File Offset: 0x00E42BD0
		private void RefreshDifficultIcon(ActivityEntranceItemData data)
		{
			string instanceDifficultIconPath = data.GetInstanceDifficultIconPath();
			if (instanceDifficultIconPath == null)
			{
				return;
			}
			base.SetTextureByPath(instanceDifficultIconPath, base.GetTexture(1), null, null);
		}

		// Token: 0x06032D2B RID: 208171 RVA: 0x00E44A00 File Offset: 0x00E42C00
		private void RefreshDescText(ActivityEntranceItemData data)
		{
			if (data.GetLockState())
			{
				string unLockDesc = data.GetUnLockDesc();
				UUIText text = base.GetText(2);
				if (text == null)
				{
					return;
				}
				text.SetText(unLockDesc, true);
				return;
			}
			else
			{
				string desc = data.GetDesc();
				UUIText text2 = base.GetText(2);
				if (text2 == null)
				{
					return;
				}
				text2.SetText(desc, true);
				return;
			}
		}

		// Token: 0x06032D2C RID: 208172 RVA: 0x00E44A4A File Offset: 0x00E42C4A
		public void OnClickExtendToggle(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked)
			{
				Action<int> selectCallBack = this.ItemData.GetSelectCallBack();
				if (selectCallBack == null)
				{
					return;
				}
				selectCallBack(this.ItemData.GetSelectDataIndex());
			}
		}

		// Token: 0x0401AFAB RID: 110507
		[Nullable(2)]
		private ActivityEntranceItemData ItemData;

		// Token: 0x0200AC5C RID: 44124
		[NullableContext(0)]
		private enum ESubContentComponent
		{
			// Token: 0x04035525 RID: 218405
			Toggle,
			// Token: 0x04035526 RID: 218406
			IconTexture,
			// Token: 0x04035527 RID: 218407
			DescText,
			// Token: 0x04035528 RID: 218408
			LockItem,
			// Token: 0x04035529 RID: 218409
			FinishItem
		}
	}
}
