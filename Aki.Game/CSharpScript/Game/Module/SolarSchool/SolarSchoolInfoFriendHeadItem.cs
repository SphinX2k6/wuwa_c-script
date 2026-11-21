using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059B2 RID: 22962
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class SolarSchoolInfoFriendHeadItem : GridProxyAbstract<SolarSchoolRoleData>
	{
		// Token: 0x17006C32 RID: 27698
		// (get) Token: 0x060389AA RID: 231850 RVA: 0x00FD6B15 File Offset: 0x00FD4D15
		// (set) Token: 0x060389AB RID: 231851 RVA: 0x00FD6B1D File Offset: 0x00FD4D1D
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<SolarSchoolRoleData> ClickCallback { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x060389AC RID: 231852 RVA: 0x00FD6B28 File Offset: 0x00FD4D28
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060389AD RID: 231853 RVA: 0x00FD6C10 File Offset: 0x00FD4E10
		[NullableContext(1)]
		public override void Refresh(SolarSchoolRoleData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			UUIItem item = base.GetItem(3);
			if (item != null)
			{
				item.SetUIActive(SolarSchoolGamePlayModel.Instance.IsFavorLevelUpPending(data.RoleId));
			}
			UUITexture texture = base.GetTexture(2);
			string text = (data.FavorLevel > 0) ? SolarSchoolPopupData.GetFavorLevelIcon(data.FavorLevel, ESolarSchoolFavorIconSize.Small) : string.Empty;
			bool flag = !string.IsNullOrEmpty(text);
			if (texture != null)
			{
				texture.SetUIActive(flag);
			}
			if (flag && texture != null)
			{
				base.SetTextureByPath(text, texture, null, null);
			}
			bool flag2 = (data.IsUnlocked || data.Config.IsSpecial) && !string.IsNullOrEmpty(data.Config.HeadIcon);
			UUITexture texture2 = base.GetTexture(1);
			if (texture2 != null)
			{
				texture2.SetUIActive(flag2);
			}
			if (flag2)
			{
				base.SetTextureByPath(data.Config.HeadIcon, base.GetTexture(1), null, null);
			}
			this.SetSelectedState(isSelected);
		}

		// Token: 0x060389AE RID: 231854 RVA: 0x00FD6D13 File Offset: 0x00FD4F13
		public override void Clear()
		{
			this.Data = null;
		}

		// Token: 0x060389AF RID: 231855 RVA: 0x00FD6D1C File Offset: 0x00FD4F1C
		public override void OnSelected(bool fireEvent)
		{
			this.SetSelectedState(true);
		}

		// Token: 0x060389B0 RID: 231856 RVA: 0x00FD6D25 File Offset: 0x00FD4F25
		public override void OnDeselected(bool fireEvent)
		{
			this.SetSelectedState(false);
		}

		// Token: 0x060389B1 RID: 231857 RVA: 0x00FD6D30 File Offset: 0x00FD4F30
		private void OnClickToggle(EToggleState state)
		{
			SolarSchoolRoleData data = this.Data;
			if (state != EToggleState.ETT_Checked || data == null)
			{
				return;
			}
			IScrollViewDelegate<IGridProxy<SolarSchoolRoleData>, SolarSchoolRoleData> scrollViewDelegate = base.ScrollViewDelegate;
			if (scrollViewDelegate != null)
			{
				scrollViewDelegate.SelectGridProxy(base.GridIndex, base.DisplayIndex, false);
			}
			Action<SolarSchoolRoleData> clickCallback = this.ClickCallback;
			if (clickCallback == null)
			{
				return;
			}
			clickCallback(data);
		}

		// Token: 0x060389B2 RID: 231858 RVA: 0x00FD6D7B File Offset: 0x00FD4F7B
		private void SetSelectedState(bool selected)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(selected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0401DCFA RID: 122106
		[Nullable(2)]
		private SolarSchoolRoleData Data;

		// Token: 0x0200B55D RID: 46429
		private class EComponent
		{
			// Token: 0x0403813A RID: 229690
			public const int Toggle = 0;

			// Token: 0x0403813B RID: 229691
			public const int RoleHead = 1;

			// Token: 0x0403813C RID: 229692
			public const int FavorState = 2;

			// Token: 0x0403813D RID: 229693
			public const int RedDot = 3;
		}
	}
}
