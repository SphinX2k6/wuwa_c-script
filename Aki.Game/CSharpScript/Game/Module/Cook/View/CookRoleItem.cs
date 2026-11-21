using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Cook.View
{
	// Token: 0x02004B01 RID: 19201
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class CookRoleItem : GridProxyAbstract<ICookRoleItemData>
	{
		// Token: 0x06030047 RID: 196679 RVA: 0x00D65138 File Offset: 0x00D63338
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06030048 RID: 196680 RVA: 0x00D65220 File Offset: 0x00D63420
		protected override void OnStart()
		{
			this.ItemGrid = new SmallItemGrid();
			this.ItemGrid.Initialize(base.GetItem(3).GetOwner());
		}

		// Token: 0x06030049 RID: 196681 RVA: 0x00D65244 File Offset: 0x00D63444
		[NullableContext(1)]
		public override void Refresh(ICookRoleItemData data, bool isSelected, int gridIndex)
		{
			this.ItemData = data;
			CharacterSmallItemGrid parameters = new CharacterSmallItemGrid
			{
				Data = data,
				ItemConfigId = new int?(data.RoleId),
				IsCookUp = new bool?(data.IsBuff)
			};
			this.ItemGrid.Apply<CharacterSmallItemGrid>(parameters);
			this.SetName();
			this.SetCookInfoText();
			this.Selected(isSelected, false);
			base.GetText(2).OnSelfLanguageChange.Bind(new Action(this.OnLanguageChange));
		}

		// Token: 0x0603004A RID: 196682 RVA: 0x00D652C4 File Offset: 0x00D634C4
		public override void Clear()
		{
			base.GetText(2).OnSelfLanguageChange.Unbind();
		}

		// Token: 0x0603004B RID: 196683 RVA: 0x00D652D7 File Offset: 0x00D634D7
		protected override void OnBeforeDestroy()
		{
			this.ItemGrid.Destroy(null);
			this.ItemGrid = null;
		}

		// Token: 0x0603004C RID: 196684 RVA: 0x00D652EC File Offset: 0x00D634EC
		private void SetCookInfoText()
		{
			if (CookController.Instance.CheckIsBuff(this.ItemData.RoleId, this.ItemData.ItemId))
			{
				string cookInfoText = CookController.Instance.GetCookInfoText(this.ItemData.RoleId);
				base.GetText(2).SetText(cookInfoText, true);
				return;
			}
			string textById = TextConfig.Instance.GetTextById("DefaultHelperText");
			base.GetText(2).SetText(textById, true);
		}

		// Token: 0x0603004D RID: 196685 RVA: 0x00D6535E File Offset: 0x00D6355E
		private void SetName()
		{
			base.GetText(1).SetText(this.ItemData.RoleName, true);
		}

		// Token: 0x0603004E RID: 196686 RVA: 0x00D65378 File Offset: 0x00D63578
		private void OnLanguageChange()
		{
			this.SetCookInfoText();
		}

		// Token: 0x0603004F RID: 196687 RVA: 0x00D65380 File Offset: 0x00D63580
		[NullableContext(1)]
		public void BindOnClickedCallback(Action<int> onItemButtonClicked)
		{
			this.OnClickedCallback = onItemButtonClicked;
		}

		// Token: 0x06030050 RID: 196688 RVA: 0x00D65389 File Offset: 0x00D63589
		public override void OnSelected(bool fireEvent)
		{
			this.Selected(true, true);
		}

		// Token: 0x06030051 RID: 196689 RVA: 0x00D65393 File Offset: 0x00D63593
		public override void OnDeselected(bool fireEvent)
		{
			this.Selected(false, true);
		}

		// Token: 0x06030052 RID: 196690 RVA: 0x00D653A0 File Offset: 0x00D635A0
		private void Selected(bool bSelected, bool fire = true)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (bSelected)
			{
				extendToggle.SetToggleState(EToggleState.ETT_Checked, fire, false, false);
				return;
			}
			extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x06030053 RID: 196691 RVA: 0x00D653CF File Offset: 0x00D635CF
		private void OnClick(EToggleState state)
		{
			if (this.OnClickedCallback != null)
			{
				this.OnClickedCallback(this.ItemData.RoleId);
			}
		}

		// Token: 0x04019782 RID: 104322
		private ICookRoleItemData ItemData;

		// Token: 0x04019783 RID: 104323
		private Action<int> OnClickedCallback;

		// Token: 0x04019784 RID: 104324
		private SmallItemGrid ItemGrid;

		// Token: 0x0200A761 RID: 42849
		[NullableContext(0)]
		public enum ECookRoleItemDefine
		{
			// Token: 0x04033B89 RID: 211849
			CookRoleExtendToggle,
			// Token: 0x04033B8A RID: 211850
			RoleNameText,
			// Token: 0x04033B8B RID: 211851
			CookInfoText,
			// Token: 0x04033B8C RID: 211852
			ItemGridItem
		}
	}
}
