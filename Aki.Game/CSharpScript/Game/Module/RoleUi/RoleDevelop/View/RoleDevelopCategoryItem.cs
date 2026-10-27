using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.View
{
	// Token: 0x02004D35 RID: 19765
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoleDevelopCategoryItem : GridProxyAbstract<RoleDevelopCategoryData>
	{
		// Token: 0x17007E47 RID: 32327
		// (get) Token: 0x0603311E RID: 209182 RVA: 0x00BE6460 File Offset: 0x00BE4660
		public ERoleDevelopCategoryType CategoryType
		{
			get
			{
				return this.Data.CategoryType;
			}
		}

		// Token: 0x0603311F RID: 209183 RVA: 0x00BE6470 File Offset: 0x00BE4670
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
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
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

		// Token: 0x06033120 RID: 209184 RVA: 0x00BE6558 File Offset: 0x00BE4758
		protected override void OnStart()
		{
			base.GetExtendToggle(0).CanExecuteChange.Bind(new Func<bool>(this.OnCanExecuteChange));
		}

		// Token: 0x06033121 RID: 209185 RVA: 0x00BE6577 File Offset: 0x00BE4777
		public override void OnSelected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_Checked, fireEvent, false, false);
		}

		// Token: 0x06033122 RID: 209186 RVA: 0x00BE6589 File Offset: 0x00BE4789
		public override void OnDeselected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_UnChecked, fireEvent, false, false);
		}

		// Token: 0x06033123 RID: 209187 RVA: 0x00BE659B File Offset: 0x00BE479B
		public override void Refresh(RoleDevelopCategoryData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.CategoryName, Array.Empty<object>());
		}

		// Token: 0x06033124 RID: 209188 RVA: 0x00BE65C0 File Offset: 0x00BE47C0
		public void RefreshHint(bool isShowUpgrade, bool isShowFinish)
		{
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(isShowUpgrade);
			}
			UUIItem item2 = base.GetItem(3);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(isShowFinish);
		}

		// Token: 0x06033125 RID: 209189 RVA: 0x00BE65E7 File Offset: 0x00BE47E7
		public override object GetKey(RoleDevelopCategoryData data, int gridIndex)
		{
			return data.CategoryType;
		}

		// Token: 0x06033126 RID: 209190 RVA: 0x00BE65F4 File Offset: 0x00BE47F4
		public void SetToggleCallback(Action<RoleDevelopCategoryData> callback)
		{
			this.ToggleCallback = callback;
		}

		// Token: 0x06033127 RID: 209191 RVA: 0x00BE65FD File Offset: 0x00BE47FD
		public void SetCanExecuteCallback(Func<RoleDevelopCategoryData, bool> callback)
		{
			this.CanExecuteCallback = callback;
		}

		// Token: 0x06033128 RID: 209192 RVA: 0x00BE6606 File Offset: 0x00BE4806
		private bool OnCanExecuteChange()
		{
			Func<RoleDevelopCategoryData, bool> canExecuteCallback = this.CanExecuteCallback;
			return canExecuteCallback == null || canExecuteCallback(this.Data);
		}

		// Token: 0x06033129 RID: 209193 RVA: 0x00BE661F File Offset: 0x00BE481F
		private void OnClickToggle(EToggleState state)
		{
			Action<RoleDevelopCategoryData> toggleCallback = this.ToggleCallback;
			if (toggleCallback == null)
			{
				return;
			}
			toggleCallback(this.Data);
		}

		// Token: 0x0401B285 RID: 111237
		private RoleDevelopCategoryData Data;

		// Token: 0x0401B286 RID: 111238
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<RoleDevelopCategoryData> ToggleCallback;

		// Token: 0x0401B287 RID: 111239
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Func<RoleDevelopCategoryData, bool> CanExecuteCallback;

		// Token: 0x0200AE96 RID: 44694
		[NullableContext(0)]
		public static class EComponentType
		{
			// Token: 0x04035039 RID: 217145
			public const int Toggle = 0;

			// Token: 0x0403503A RID: 217146
			public const int NameTxt = 1;

			// Token: 0x0403503B RID: 217147
			public const int UpItem = 2;

			// Token: 0x0403503C RID: 217148
			public const int FinishItem = 3;
		}
	}
}
