using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Cook.View
{
	// Token: 0x02005B20 RID: 23328
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class CookRoleItem : GridProxyAbstract<ICookRoleItemData>
	{
		// Token: 0x0603B0D5 RID: 241877 RVA: 0x00E14420 File Offset: 0x00E12620
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

		// Token: 0x0603B0D6 RID: 241878 RVA: 0x00E14508 File Offset: 0x00E12708
		protected override void OnStart()
		{
			this.ItemGrid = new SmallItemGrid();
			this.ItemGrid.Initialize(base.GetItem(3).GetOwner());
		}

		// Token: 0x0603B0D7 RID: 241879 RVA: 0x00E1452C File Offset: 0x00E1272C
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

		// Token: 0x0603B0D8 RID: 241880 RVA: 0x00E145AC File Offset: 0x00E127AC
		public override void Clear()
		{
			base.GetText(2).OnSelfLanguageChange.Unbind();
		}

		// Token: 0x0603B0D9 RID: 241881 RVA: 0x00E145BF File Offset: 0x00E127BF
		protected override void OnBeforeDestroy()
		{
			this.ItemGrid.Destroy(null);
			this.ItemGrid = null;
		}

		// Token: 0x0603B0DA RID: 241882 RVA: 0x00E145D4 File Offset: 0x00E127D4
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

		// Token: 0x0603B0DB RID: 241883 RVA: 0x00E14646 File Offset: 0x00E12846
		private void SetName()
		{
			base.GetText(1).SetText(this.ItemData.RoleName, true);
		}

		// Token: 0x0603B0DC RID: 241884 RVA: 0x00E14660 File Offset: 0x00E12860
		private void OnLanguageChange()
		{
			this.SetCookInfoText();
		}

		// Token: 0x0603B0DD RID: 241885 RVA: 0x00E14668 File Offset: 0x00E12868
		[NullableContext(1)]
		public void BindOnClickedCallback(Action<int> onItemButtonClicked)
		{
			this.OnClickedCallback = onItemButtonClicked;
		}

		// Token: 0x0603B0DE RID: 241886 RVA: 0x00E14671 File Offset: 0x00E12871
		public override void OnSelected(bool fireEvent)
		{
			this.Selected(true, true);
		}

		// Token: 0x0603B0DF RID: 241887 RVA: 0x00E1467B File Offset: 0x00E1287B
		public override void OnDeselected(bool fireEvent)
		{
			this.Selected(false, true);
		}

		// Token: 0x0603B0E0 RID: 241888 RVA: 0x00E14688 File Offset: 0x00E12888
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

		// Token: 0x0603B0E1 RID: 241889 RVA: 0x00E146B7 File Offset: 0x00E128B7
		private void OnClick(EToggleState state)
		{
			if (this.OnClickedCallback != null)
			{
				this.OnClickedCallback(this.ItemData.RoleId);
			}
		}

		// Token: 0x0401ECC6 RID: 126150
		private ICookRoleItemData ItemData;

		// Token: 0x0401ECC7 RID: 126151
		private Action<int> OnClickedCallback;

		// Token: 0x0401ECC8 RID: 126152
		private SmallItemGrid ItemGrid;

		// Token: 0x0200BD58 RID: 48472
		[NullableContext(0)]
		public enum ECookRoleItemDefine
		{
			// Token: 0x040391BD RID: 233917
			CookRoleExtendToggle,
			// Token: 0x040391BE RID: 233918
			RoleNameText,
			// Token: 0x040391BF RID: 233919
			CookInfoText,
			// Token: 0x040391C0 RID: 233920
			ItemGridItem
		}
	}
}
