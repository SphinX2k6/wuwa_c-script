using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005904 RID: 22788
	public class SolarSchoolEventChoiceItem : GridProxyAbstract<int>
	{
		// Token: 0x060382D7 RID: 230103 RVA: 0x00FB4374 File Offset: 0x00FB2574
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
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnTogChoiceStateChanged));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060382D8 RID: 230104 RVA: 0x00FB4480 File Offset: 0x00FB2680
		protected override void OnStart()
		{
			this.IconLayout = new GenericLayout<SolarSchoolEventChoiceAttrIconItem, int>(base.GetHorizontalLayout(3), new Func<SolarSchoolEventChoiceAttrIconItem>(this.CreateIconItem), base.GetItem(4).GetOwner() as AUIBaseActor, false, true);
			base.GetExtendToggle(0).CanExecuteChange.Bind(new Func<bool>(this.OnCanChoiceChange));
		}

		// Token: 0x060382D9 RID: 230105 RVA: 0x00FB44DB File Offset: 0x00FB26DB
		private bool OnCanChoiceChange()
		{
			Func<bool> canSelectFunc = this.CanSelectFunc;
			return canSelectFunc == null || canSelectFunc();
		}

		// Token: 0x060382DA RID: 230106 RVA: 0x00FB44F0 File Offset: 0x00FB26F0
		public override void Refresh(int optionId, bool isSelected, int gridIndex)
		{
			this.OptionId = optionId;
			SolarSchoolEventCheckOpt? eventCheckOpt = SolarSchoolConfig.Instance.GetEventCheckOpt(this.OptionId);
			if (eventCheckOpt == null)
			{
				this.SetToggleState(isSelected);
				return;
			}
			SolarSchoolEventCheckOpt value = eventCheckOpt.Value;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), value.DescKey, Array.Empty<object>());
			this.RefreshIconLayout(value.GetFocusAttrArray() ?? Array.Empty<int>());
			this.SetToggleState(isSelected);
		}

		// Token: 0x060382DB RID: 230107 RVA: 0x00FB4568 File Offset: 0x00FB2768
		public override void OnSelected(bool fireEvent)
		{
			this.SetToggleState(true);
		}

		// Token: 0x060382DC RID: 230108 RVA: 0x00FB4571 File Offset: 0x00FB2771
		public override void OnDeselected(bool fireEvent)
		{
			this.SetToggleState(false);
		}

		// Token: 0x060382DD RID: 230109 RVA: 0x00FB457C File Offset: 0x00FB277C
		private void SetToggleState(bool state)
		{
			EToggleState state2 = state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(state2, false, false, false);
		}

		// Token: 0x060382DE RID: 230110 RVA: 0x00FB45A7 File Offset: 0x00FB27A7
		[NullableContext(1)]
		private SolarSchoolEventChoiceAttrIconItem CreateIconItem()
		{
			return new SolarSchoolEventChoiceAttrIconItem();
		}

		// Token: 0x060382DF RID: 230111 RVA: 0x00FB45B0 File Offset: 0x00FB27B0
		[NullableContext(1)]
		private void RefreshIconLayout(int[] focusAttr)
		{
			List<int> list = new List<int>(focusAttr);
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(list.Count > 0);
			}
			this.IconLayout.RefreshByData(list, null, false);
		}

		// Token: 0x060382E0 RID: 230112 RVA: 0x00FB45ED File Offset: 0x00FB27ED
		private void OnTogChoiceStateChanged(EToggleState state)
		{
			Action<int, int> onClickChoiceBack = this.OnClickChoiceBack;
			if (onClickChoiceBack == null)
			{
				return;
			}
			onClickChoiceBack(base.GridIndex, this.OptionId);
		}

		// Token: 0x0401D93E RID: 121150
		[Nullable(2)]
		public Action<int, int> OnClickChoiceBack;

		// Token: 0x0401D93F RID: 121151
		[Nullable(2)]
		public Func<bool> CanSelectFunc;

		// Token: 0x0401D940 RID: 121152
		private int OptionId;

		// Token: 0x0401D941 RID: 121153
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<SolarSchoolEventChoiceAttrIconItem, int> IconLayout;

		// Token: 0x0200B4C1 RID: 46273
		private class EComponents
		{
			// Token: 0x04037E41 RID: 228929
			public const int TogChoice = 0;

			// Token: 0x04037E42 RID: 228930
			public const int TxtChoice = 1;

			// Token: 0x04037E43 RID: 228931
			public const int PnlTips = 2;

			// Token: 0x04037E44 RID: 228932
			public const int IconLayout = 3;

			// Token: 0x04037E45 RID: 228933
			public const int IconItem = 4;
		}
	}
}
