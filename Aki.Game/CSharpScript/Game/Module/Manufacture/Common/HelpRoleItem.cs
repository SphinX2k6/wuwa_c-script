using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Cook;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Manufacture.Common
{
	// Token: 0x02005693 RID: 22163
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class HelpRoleItem : GridProxyAbstract<ICommonRoleItemData>
	{
		// Token: 0x0603864A RID: 230986 RVA: 0x00D62E14 File Offset: 0x00D61014
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

		// Token: 0x0603864B RID: 230987 RVA: 0x00D62EFC File Offset: 0x00D610FC
		protected override void OnStart()
		{
			this.ItemGrid = new SmallItemGrid();
			this.ItemGrid.Initialize(base.GetItem(3).GetOwner());
		}

		// Token: 0x0603864C RID: 230988 RVA: 0x00D62F20 File Offset: 0x00D61120
		[NullableContext(1)]
		public override void Refresh(ICommonRoleItemData data, bool isSelected, int gridIndex)
		{
			this.ItemData = data;
			CharacterSmallItemGrid characterSmallItemGrid = new CharacterSmallItemGrid();
			characterSmallItemGrid.Data = data;
			characterSmallItemGrid.ItemConfigId = new int?(data.RoleId);
			characterSmallItemGrid.BottomText = data.RoleName;
			characterSmallItemGrid.IsCookUp = new bool?(data.IsBuff);
			int? currentCookRoleId = CookModel.Instance.CurrentCookRoleId;
			int roleId = data.RoleId;
			characterSmallItemGrid.IsReceivedVisible = new bool?(currentCookRoleId.GetValueOrDefault() == roleId & currentCookRoleId != null);
			CharacterSmallItemGrid parameters = characterSmallItemGrid;
			this.ItemGrid.Apply<CharacterSmallItemGrid>(parameters);
			this.SetName();
			this.SetInfoText();
			this.Selected(isSelected, false);
			base.GetText(2).OnSelfLanguageChange.Bind(new Action(this.SetInfoText));
		}

		// Token: 0x0603864D RID: 230989 RVA: 0x00D62FDB File Offset: 0x00D611DB
		public override void Clear()
		{
			base.GetText(2).OnSelfLanguageChange.Unbind();
		}

		// Token: 0x0603864E RID: 230990 RVA: 0x00D62FEE File Offset: 0x00D611EE
		protected override void OnBeforeDestroy()
		{
			this.ItemGrid.Destroy(null);
			this.ItemGrid = null;
		}

		// Token: 0x0603864F RID: 230991 RVA: 0x00D63003 File Offset: 0x00D61203
		private void SetName()
		{
			base.GetText(1).SetText(this.ItemData.RoleName, true);
		}

		// Token: 0x06038650 RID: 230992 RVA: 0x00D63020 File Offset: 0x00D61220
		private void SetInfoText()
		{
			if (CommonManager.Instance.CheckIsBuff(this.ItemData.RoleId, this.ItemData.ItemId))
			{
				string infoText = CommonManager.Instance.GetInfoText(this.ItemData.RoleId);
				base.GetText(2).SetText(infoText, true);
				return;
			}
			string textById = TextConfig.Instance.GetTextById(CommonManager.Instance.GetDefaultRoleText());
			base.GetText(2).SetText(textById, true);
		}

		// Token: 0x06038651 RID: 230993 RVA: 0x00D63097 File Offset: 0x00D61297
		[NullableContext(1)]
		public void BindOnClickedCallback(Action<int> onItemButtonClicked)
		{
			this.OnClickedCallback = onItemButtonClicked;
		}

		// Token: 0x06038652 RID: 230994 RVA: 0x00D630A0 File Offset: 0x00D612A0
		public override void OnSelected(bool fireEvent)
		{
			this.Selected(true, true);
		}

		// Token: 0x06038653 RID: 230995 RVA: 0x00D630AA File Offset: 0x00D612AA
		public override void OnDeselected(bool fireEvent)
		{
			this.Selected(false, true);
		}

		// Token: 0x06038654 RID: 230996 RVA: 0x00D630B4 File Offset: 0x00D612B4
		private void Selected(bool bSelected, bool fireEvent = true)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (bSelected)
			{
				extendToggle.SetToggleState(EToggleState.ETT_Checked, fireEvent, false, false);
				return;
			}
			extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x06038655 RID: 230997 RVA: 0x00D630E3 File Offset: 0x00D612E3
		private void OnClick(EToggleState state)
		{
			if (this.OnClickedCallback != null)
			{
				this.OnClickedCallback(this.ItemData.RoleId);
			}
		}

		// Token: 0x0401DA13 RID: 121363
		private ICommonRoleItemData ItemData;

		// Token: 0x0401DA14 RID: 121364
		private SmallItemGrid ItemGrid;

		// Token: 0x0401DA15 RID: 121365
		private Action<int> OnClickedCallback;

		// Token: 0x0200B855 RID: 47189
		[NullableContext(0)]
		private class EHelpRoleItemDefine
		{
			// Token: 0x04037CAE RID: 228526
			public const int HelpRoleExtendToggle = 0;

			// Token: 0x04037CAF RID: 228527
			public const int RoleNameText = 1;

			// Token: 0x04037CB0 RID: 228528
			public const int CommonInfoText = 2;

			// Token: 0x04037CB1 RID: 228529
			public const int ItemGridItem = 3;
		}
	}
}
