using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorFight
{
	// Token: 0x0200641E RID: 25630
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorFightTaskTabItem : GridProxyAbstract<MotorFightTaskTab>
	{
		// Token: 0x0604073C RID: 263996 RVA: 0x00F98978 File Offset: 0x00F96B78
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0604073D RID: 263997 RVA: 0x00F98A40 File Offset: 0x00F96C40
		public override void Refresh(MotorFightTaskTab data, bool isSelected, int gridIndex)
		{
			this.Data = new MotorFightTaskTab?(data);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.TabTitle, Array.Empty<object>());
			bool uiactive = this.ActivityData.IsTaskHasRedDotByTab(data.Id);
			UUIItem item = base.GetItem(2);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(uiactive);
		}

		// Token: 0x0604073E RID: 263998 RVA: 0x00F98A9C File Offset: 0x00F96C9C
		private void OnToggleClick(EToggleState _)
		{
			this.OnToggleClickCallBack(this.Data.Value.Id);
		}

		// Token: 0x0604073F RID: 263999 RVA: 0x00F98AC7 File Offset: 0x00F96CC7
		public override object GetKey(MotorFightTaskTab data, int displayIndex)
		{
			return data.Id;
		}

		// Token: 0x06040740 RID: 264000 RVA: 0x00F98AD8 File Offset: 0x00F96CD8
		public void SetToggleState(bool state)
		{
			EToggleState state2 = state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(0).SetToggleState(state2, false, false, false);
		}

		// Token: 0x06040741 RID: 264001 RVA: 0x00F98AFE File Offset: 0x00F96CFE
		public override void OnSelected(bool fireEvent)
		{
			this.SetToggleState(true);
		}

		// Token: 0x06040742 RID: 264002 RVA: 0x00F98B07 File Offset: 0x00F96D07
		public override void OnDeselected(bool fireEvent)
		{
			this.SetToggleState(false);
		}

		// Token: 0x04021826 RID: 137254
		private MotorFightTaskTab? Data;

		// Token: 0x04021827 RID: 137255
		public MotorFightActivityData ActivityData;

		// Token: 0x04021828 RID: 137256
		public Action<int> OnToggleClickCallBack = delegate(int tabId)
		{
		};

		// Token: 0x0200C649 RID: 50761
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403BDD7 RID: 245207
			public const int ToggleRoot = 0;

			// Token: 0x0403BDD8 RID: 245208
			public const int TextTabName = 1;

			// Token: 0x0403BDD9 RID: 245209
			public const int ItemRedDot = 2;
		}
	}
}
