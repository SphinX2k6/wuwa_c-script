using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.View.InstanceEntrance
{
	// Token: 0x02004F00 RID: 20224
	[NullableContext(1)]
	[Nullable(0)]
	internal class MainContentItem : UiPanelBase
	{
		// Token: 0x06032D2F RID: 208175 RVA: 0x00E44A80 File Offset: 0x00E42C80
		protected unsafe override void OnRegisterComponent()
		{
			int num = 10;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickExtendToggle));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06032D30 RID: 208176 RVA: 0x00E44C30 File Offset: 0x00E42E30
		public void RefreshView(ActivityEntranceItemData data)
		{
			this.ItemData = data;
			this.RefreshToggleState(data);
			this.RefreshPointItem(data);
			this.RefreshLockItem(data);
			this.RefreshFinishItem(data);
			this.RefreshOffsetItem(data);
			this.RefreshDifficultIcon(data);
			this.RefreshTitle(data);
			this.RefreshSubTitle(data);
			this.RefreshDisplayGrid(data);
			this.RefreshRedDotState(data);
		}

		// Token: 0x06032D31 RID: 208177 RVA: 0x00E44C8C File Offset: 0x00E42E8C
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

		// Token: 0x06032D32 RID: 208178 RVA: 0x00E44CBC File Offset: 0x00E42EBC
		private void OnClickExtendToggle(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked)
			{
				bool flag = this.ItemData.HaveChildData();
				Action<int> selectCallBack = this.ItemData.GetSelectCallBack();
				if (selectCallBack != null)
				{
					selectCallBack(this.ItemData.GetSelectDataIndex());
				}
				if (flag)
				{
					EventSystem.Instance.Emit<int>(EEventName.RefreshActivityEntranceScroller, this.ItemData.GetSelectUiLogicIndex());
					return;
				}
				EventSystem.Instance.Emit<int>(EEventName.RefreshActivityEntranceItemContent, this.ItemData.GetSelectUiLogicIndex());
			}
		}

		// Token: 0x06032D33 RID: 208179 RVA: 0x00E44D34 File Offset: 0x00E42F34
		private void RefreshPointItem(ActivityEntranceItemData data)
		{
			bool selectState = data.GetSelectState();
			UUIItem item = base.GetItem(5);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(selectState);
		}

		// Token: 0x06032D34 RID: 208180 RVA: 0x00E44D5C File Offset: 0x00E42F5C
		private void RefreshLockItem(ActivityEntranceItemData data)
		{
			bool lockState = data.GetLockState();
			base.GetItem(7).SetUIActive(lockState);
		}

		// Token: 0x06032D35 RID: 208181 RVA: 0x00E44D80 File Offset: 0x00E42F80
		private void RefreshFinishItem(ActivityEntranceItemData data)
		{
			bool finishState = data.GetFinishState();
			base.GetItem(6).SetUIActive(finishState);
		}

		// Token: 0x06032D36 RID: 208182 RVA: 0x00E44DA4 File Offset: 0x00E42FA4
		private void RefreshOffsetItem(ActivityEntranceItemData data)
		{
			bool flag = data.HaveChildData();
			bool selectState = data.GetSelectState();
			UUIItem item = base.GetItem(1);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(flag && selectState);
		}

		// Token: 0x06032D37 RID: 208183 RVA: 0x00E44DD4 File Offset: 0x00E42FD4
		private void RefreshDifficultIcon(ActivityEntranceItemData data)
		{
			UUITexture texture = base.GetTexture(2);
			if (texture != null)
			{
				texture.SetUIActive(false);
			}
			string instanceDifficultIconPath = data.GetInstanceDifficultIconPath();
			if (instanceDifficultIconPath == null)
			{
				return;
			}
			base.SetTextureByPath(instanceDifficultIconPath, base.GetTexture(2), null, null);
		}

		// Token: 0x06032D38 RID: 208184 RVA: 0x00E44E18 File Offset: 0x00E43018
		private void RefreshTitle(ActivityEntranceItemData data)
		{
			UUIText text = base.GetText(3);
			if (text != null)
			{
				text.SetText("", true);
			}
			string instanceName = data.GetInstanceName();
			if (instanceName == "")
			{
				return;
			}
			UUIText text2 = base.GetText(3);
			if (text2 == null)
			{
				return;
			}
			text2.SetText(instanceName, true);
		}

		// Token: 0x06032D39 RID: 208185 RVA: 0x00E44E68 File Offset: 0x00E43068
		private void RefreshSubTitle(ActivityEntranceItemData data)
		{
			if (data.GetLockState())
			{
				string unLockDesc = data.GetUnLockDesc();
				UUIText text = base.GetText(8);
				if (text == null)
				{
					return;
				}
				text.SetText(unLockDesc, true);
				return;
			}
			else
			{
				string subTitle = data.GetSubTitle();
				UUIText text2 = base.GetText(8);
				if (text2 == null)
				{
					return;
				}
				text2.SetText(subTitle, true);
				return;
			}
		}

		// Token: 0x06032D3A RID: 208186 RVA: 0x00E44EB4 File Offset: 0x00E430B4
		private void RefreshDisplayGrid(ActivityEntranceItemData data)
		{
			bool uiactive = data.HaveChildData();
			base.GetItem(4).SetUIActive(uiactive);
		}

		// Token: 0x06032D3B RID: 208187 RVA: 0x00E44ED8 File Offset: 0x00E430D8
		private void RefreshRedDotState(ActivityEntranceItemData data)
		{
			bool redDotState = data.GetRedDotState();
			base.GetItem(9).SetUIActive(redDotState);
		}

		// Token: 0x0401AFAC RID: 110508
		[Nullable(2)]
		private ActivityEntranceItemData ItemData;

		// Token: 0x0200AC5D RID: 44125
		[NullableContext(0)]
		private enum EMainContentComponent
		{
			// Token: 0x0403552B RID: 218411
			Toggle,
			// Token: 0x0403552C RID: 218412
			OffsetItem,
			// Token: 0x0403552D RID: 218413
			IconTexture,
			// Token: 0x0403552E RID: 218414
			Title,
			// Token: 0x0403552F RID: 218415
			DisplayGridItem,
			// Token: 0x04035530 RID: 218416
			PointItem,
			// Token: 0x04035531 RID: 218417
			FinishItem,
			// Token: 0x04035532 RID: 218418
			LockItem,
			// Token: 0x04035533 RID: 218419
			SubTitle,
			// Token: 0x04035534 RID: 218420
			RedDotItem
		}
	}
}
