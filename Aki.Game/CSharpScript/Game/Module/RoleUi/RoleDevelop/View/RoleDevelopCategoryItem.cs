using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.View
{
	// Token: 0x02003CF4 RID: 15604
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoleDevelopCategoryItem : GridProxyAbstract<RoleDevelopCategoryData>
	{
		// Token: 0x170051F7 RID: 20983
		// (get) Token: 0x06027F19 RID: 163609 RVA: 0x00B2C638 File Offset: 0x00B2A838
		public ERoleDevelopCategoryType CategoryType
		{
			get
			{
				return this.Data.CategoryType;
			}
		}

		// Token: 0x06027F1A RID: 163610 RVA: 0x00B2C648 File Offset: 0x00B2A848
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
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
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06027F1B RID: 163611 RVA: 0x00B2C751 File Offset: 0x00B2A951
		protected override void OnStart()
		{
			base.GetExtendToggle(0).CanExecuteChange.Bind(new Func<bool>(this.OnCanExecuteChange));
		}

		// Token: 0x06027F1C RID: 163612 RVA: 0x00B2C770 File Offset: 0x00B2A970
		public override void OnSelected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_Checked, fireEvent, false, false);
		}

		// Token: 0x06027F1D RID: 163613 RVA: 0x00B2C782 File Offset: 0x00B2A982
		public override void OnDeselected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_UnChecked, fireEvent, false, false);
		}

		// Token: 0x06027F1E RID: 163614 RVA: 0x00B2C794 File Offset: 0x00B2A994
		public override void Refresh(RoleDevelopCategoryData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.CategoryName, Array.Empty<object>());
			this.RefreshHint(ERoleDevelopCategoryHintType.None);
			if (isSelected)
			{
				this.OnSelected(false);
				return;
			}
			this.OnDeselected(false);
		}

		// Token: 0x06027F1F RID: 163615 RVA: 0x00B2C7D4 File Offset: 0x00B2A9D4
		public void RefreshHint(ERoleDevelopCategoryHintType hintType)
		{
			UUIItem item = base.GetItem(3);
			if (item != null)
			{
				item.SetUIActive(hintType == ERoleDevelopCategoryHintType.Finish);
			}
			UUIItem item2 = base.GetItem(2);
			if (item2 != null)
			{
				item2.SetUIActive(hintType == ERoleDevelopCategoryHintType.Upgrade);
			}
			UUIItem item3 = base.GetItem(4);
			if (item3 == null)
			{
				return;
			}
			item3.SetUIActive(hintType == ERoleDevelopCategoryHintType.CanImprove);
		}

		// Token: 0x06027F20 RID: 163616 RVA: 0x00B2C822 File Offset: 0x00B2AA22
		public override object GetKey(RoleDevelopCategoryData data, int gridIndex)
		{
			return data.CategoryType;
		}

		// Token: 0x06027F21 RID: 163617 RVA: 0x00B2C82F File Offset: 0x00B2AA2F
		public void SetToggleCallback(Action<RoleDevelopCategoryData> callback)
		{
			this.ToggleCallback = callback;
		}

		// Token: 0x06027F22 RID: 163618 RVA: 0x00B2C838 File Offset: 0x00B2AA38
		public void SetCanExecuteCallback(Func<RoleDevelopCategoryData, bool> callback)
		{
			this.CanExecuteCallback = callback;
		}

		// Token: 0x06027F23 RID: 163619 RVA: 0x00B2C841 File Offset: 0x00B2AA41
		private bool OnCanExecuteChange()
		{
			Func<RoleDevelopCategoryData, bool> canExecuteCallback = this.CanExecuteCallback;
			return canExecuteCallback == null || canExecuteCallback(this.Data);
		}

		// Token: 0x06027F24 RID: 163620 RVA: 0x00B2C85A File Offset: 0x00B2AA5A
		private void OnClickToggle(EToggleState state)
		{
			Action<RoleDevelopCategoryData> toggleCallback = this.ToggleCallback;
			if (toggleCallback == null)
			{
				return;
			}
			toggleCallback(this.Data);
		}

		// Token: 0x04015C40 RID: 89152
		private RoleDevelopCategoryData Data;

		// Token: 0x04015C41 RID: 89153
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<RoleDevelopCategoryData> ToggleCallback;

		// Token: 0x04015C42 RID: 89154
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Func<RoleDevelopCategoryData, bool> CanExecuteCallback;

		// Token: 0x020098B5 RID: 39093
		[NullableContext(0)]
		private enum EComponentType
		{
			// Token: 0x0402F9E3 RID: 195043
			Toggle,
			// Token: 0x0402F9E4 RID: 195044
			NameTxt,
			// Token: 0x0402F9E5 RID: 195045
			UpItem,
			// Token: 0x0402F9E6 RID: 195046
			FinishItem,
			// Token: 0x0402F9E7 RID: 195047
			ImproveItem
		}
	}
}
