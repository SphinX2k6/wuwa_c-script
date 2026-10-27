using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.View.InstanceEntrance
{
	// Token: 0x02005F18 RID: 24344
	[NullableContext(1)]
	[Nullable(0)]
	internal class SubContentItem : UiPanelBase
	{
		// Token: 0x0603DD8A RID: 253322 RVA: 0x00EF2AF4 File Offset: 0x00EF0CF4
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

		// Token: 0x0603DD8B RID: 253323 RVA: 0x00EF2C00 File Offset: 0x00EF0E00
		public void RefreshView(ActivityEntranceItemData data)
		{
			this.ItemData = data;
			this.RefreshToggleState(this.ItemData);
			this.RefreshLockItem(this.ItemData);
			this.RefreshFinishItem(this.ItemData);
			this.RefreshDifficultIcon(this.ItemData);
			this.RefreshDescText(this.ItemData);
		}

		// Token: 0x0603DD8C RID: 253324 RVA: 0x00EF2C50 File Offset: 0x00EF0E50
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

		// Token: 0x0603DD8D RID: 253325 RVA: 0x00EF2C80 File Offset: 0x00EF0E80
		private void RefreshLockItem(ActivityEntranceItemData data)
		{
			bool lockState = data.GetLockState();
			base.GetItem(3).SetUIActive(lockState);
		}

		// Token: 0x0603DD8E RID: 253326 RVA: 0x00EF2CA4 File Offset: 0x00EF0EA4
		private void RefreshFinishItem(ActivityEntranceItemData data)
		{
			bool finishState = data.GetFinishState();
			base.GetItem(4).SetUIActive(finishState);
		}

		// Token: 0x0603DD8F RID: 253327 RVA: 0x00EF2CC8 File Offset: 0x00EF0EC8
		private void RefreshDifficultIcon(ActivityEntranceItemData data)
		{
			string instanceDifficultIconPath = data.GetInstanceDifficultIconPath();
			if (instanceDifficultIconPath == null)
			{
				return;
			}
			base.SetTextureByPath(instanceDifficultIconPath, base.GetTexture(1), null, null);
		}

		// Token: 0x0603DD90 RID: 253328 RVA: 0x00EF2CF8 File Offset: 0x00EF0EF8
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

		// Token: 0x0603DD91 RID: 253329 RVA: 0x00EF2D42 File Offset: 0x00EF0F42
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

		// Token: 0x040204D9 RID: 132313
		[Nullable(2)]
		private ActivityEntranceItemData ItemData;

		// Token: 0x0200C24F RID: 49743
		[NullableContext(0)]
		private enum ESubContentComponent
		{
			// Token: 0x0403AB33 RID: 240435
			Toggle,
			// Token: 0x0403AB34 RID: 240436
			IconTexture,
			// Token: 0x0403AB35 RID: 240437
			DescText,
			// Token: 0x0403AB36 RID: 240438
			LockItem,
			// Token: 0x0403AB37 RID: 240439
			FinishItem
		}
	}
}
