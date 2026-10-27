using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.View.InstanceEntrance
{
	// Token: 0x02005F19 RID: 24345
	[NullableContext(1)]
	[Nullable(0)]
	internal class MainContentItem : UiPanelBase
	{
		// Token: 0x0603DD94 RID: 253332 RVA: 0x00EF2D78 File Offset: 0x00EF0F78
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

		// Token: 0x0603DD95 RID: 253333 RVA: 0x00EF2F28 File Offset: 0x00EF1128
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

		// Token: 0x0603DD96 RID: 253334 RVA: 0x00EF2F84 File Offset: 0x00EF1184
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

		// Token: 0x0603DD97 RID: 253335 RVA: 0x00EF2FB4 File Offset: 0x00EF11B4
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

		// Token: 0x0603DD98 RID: 253336 RVA: 0x00EF302C File Offset: 0x00EF122C
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

		// Token: 0x0603DD99 RID: 253337 RVA: 0x00EF3054 File Offset: 0x00EF1254
		private void RefreshLockItem(ActivityEntranceItemData data)
		{
			bool lockState = data.GetLockState();
			base.GetItem(7).SetUIActive(lockState);
		}

		// Token: 0x0603DD9A RID: 253338 RVA: 0x00EF3078 File Offset: 0x00EF1278
		private void RefreshFinishItem(ActivityEntranceItemData data)
		{
			bool finishState = data.GetFinishState();
			base.GetItem(6).SetUIActive(finishState);
		}

		// Token: 0x0603DD9B RID: 253339 RVA: 0x00EF309C File Offset: 0x00EF129C
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

		// Token: 0x0603DD9C RID: 253340 RVA: 0x00EF30CC File Offset: 0x00EF12CC
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

		// Token: 0x0603DD9D RID: 253341 RVA: 0x00EF3110 File Offset: 0x00EF1310
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

		// Token: 0x0603DD9E RID: 253342 RVA: 0x00EF3160 File Offset: 0x00EF1360
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

		// Token: 0x0603DD9F RID: 253343 RVA: 0x00EF31AC File Offset: 0x00EF13AC
		private void RefreshDisplayGrid(ActivityEntranceItemData data)
		{
			bool uiactive = data.HaveChildData();
			base.GetItem(4).SetUIActive(uiactive);
		}

		// Token: 0x0603DDA0 RID: 253344 RVA: 0x00EF31D0 File Offset: 0x00EF13D0
		private void RefreshRedDotState(ActivityEntranceItemData data)
		{
			bool redDotState = data.GetRedDotState();
			base.GetItem(9).SetUIActive(redDotState);
		}

		// Token: 0x040204DA RID: 132314
		[Nullable(2)]
		private ActivityEntranceItemData ItemData;

		// Token: 0x0200C250 RID: 49744
		[NullableContext(0)]
		private enum EMainContentComponent
		{
			// Token: 0x0403AB39 RID: 240441
			Toggle,
			// Token: 0x0403AB3A RID: 240442
			OffsetItem,
			// Token: 0x0403AB3B RID: 240443
			IconTexture,
			// Token: 0x0403AB3C RID: 240444
			Title,
			// Token: 0x0403AB3D RID: 240445
			DisplayGridItem,
			// Token: 0x0403AB3E RID: 240446
			PointItem,
			// Token: 0x0403AB3F RID: 240447
			FinishItem,
			// Token: 0x0403AB40 RID: 240448
			LockItem,
			// Token: 0x0403AB41 RID: 240449
			SubTitle,
			// Token: 0x0403AB42 RID: 240450
			RedDotItem
		}
	}
}
