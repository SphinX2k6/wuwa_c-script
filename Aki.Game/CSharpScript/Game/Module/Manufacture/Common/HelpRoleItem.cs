using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Cook;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Manufacture.Common
{
	// Token: 0x02004669 RID: 18025
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class HelpRoleItem : GridProxyAbstract<ICommonRoleItemData>
	{
		// Token: 0x0602D547 RID: 185671 RVA: 0x00CB0F64 File Offset: 0x00CAF164
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

		// Token: 0x0602D548 RID: 185672 RVA: 0x00CB104C File Offset: 0x00CAF24C
		protected override void OnStart()
		{
			this.ItemGrid = new SmallItemGrid();
			this.ItemGrid.Initialize(base.GetItem(3).GetOwner());
		}

		// Token: 0x0602D549 RID: 185673 RVA: 0x00CB1070 File Offset: 0x00CAF270
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

		// Token: 0x0602D54A RID: 185674 RVA: 0x00CB112B File Offset: 0x00CAF32B
		public override void Clear()
		{
			base.GetText(2).OnSelfLanguageChange.Unbind();
		}

		// Token: 0x0602D54B RID: 185675 RVA: 0x00CB113E File Offset: 0x00CAF33E
		protected override void OnBeforeDestroy()
		{
			this.ItemGrid.Destroy(null);
			this.ItemGrid = null;
		}

		// Token: 0x0602D54C RID: 185676 RVA: 0x00CB1153 File Offset: 0x00CAF353
		private void SetName()
		{
			base.GetText(1).SetText(this.ItemData.RoleName, true);
		}

		// Token: 0x0602D54D RID: 185677 RVA: 0x00CB1170 File Offset: 0x00CAF370
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

		// Token: 0x0602D54E RID: 185678 RVA: 0x00CB11E7 File Offset: 0x00CAF3E7
		[NullableContext(1)]
		public void BindOnClickedCallback(Action<int> onItemButtonClicked)
		{
			this.OnClickedCallback = onItemButtonClicked;
		}

		// Token: 0x0602D54F RID: 185679 RVA: 0x00CB11F0 File Offset: 0x00CAF3F0
		public override void OnSelected(bool fireEvent)
		{
			this.Selected(true, true);
		}

		// Token: 0x0602D550 RID: 185680 RVA: 0x00CB11FA File Offset: 0x00CAF3FA
		public override void OnDeselected(bool fireEvent)
		{
			this.Selected(false, true);
		}

		// Token: 0x0602D551 RID: 185681 RVA: 0x00CB1204 File Offset: 0x00CAF404
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

		// Token: 0x0602D552 RID: 185682 RVA: 0x00CB1233 File Offset: 0x00CAF433
		private void OnClick(EToggleState state)
		{
			if (this.OnClickedCallback != null)
			{
				this.OnClickedCallback(this.ItemData.RoleId);
			}
		}

		// Token: 0x0401849E RID: 99486
		private ICommonRoleItemData ItemData;

		// Token: 0x0401849F RID: 99487
		private SmallItemGrid ItemGrid;

		// Token: 0x040184A0 RID: 99488
		private Action<int> OnClickedCallback;

		// Token: 0x0200A27D RID: 41597
		[NullableContext(0)]
		private class EHelpRoleItemDefine
		{
			// Token: 0x040326CB RID: 206539
			public const int HelpRoleExtendToggle = 0;

			// Token: 0x040326CC RID: 206540
			public const int RoleNameText = 1;

			// Token: 0x040326CD RID: 206541
			public const int CommonInfoText = 2;

			// Token: 0x040326CE RID: 206542
			public const int ItemGridItem = 3;
		}
	}
}
