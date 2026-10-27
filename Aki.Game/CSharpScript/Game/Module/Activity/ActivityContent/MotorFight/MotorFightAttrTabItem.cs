using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorFight
{
	// Token: 0x02006424 RID: 25636
	public class MotorFightAttrTabItem : GridProxyAbstract<EMotorFightAttrShowType>
	{
		// Token: 0x0604075F RID: 264031 RVA: 0x00F993E3 File Offset: 0x00F975E3
		protected override void OnStart()
		{
			base.GetExtendToggle(1).bLockStateOnSelect = true;
			this.SetToggleState(false);
		}

		// Token: 0x06040760 RID: 264032 RVA: 0x00F993FC File Offset: 0x00F975FC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnToggleClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06040761 RID: 264033 RVA: 0x00F994C3 File Offset: 0x00F976C3
		public override void Refresh(EMotorFightAttrShowType type, bool isSelected, int gridIndex)
		{
			this.Type = type;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), MotorFightDefine.motorFightAttrShowTypeToName[type], Array.Empty<object>());
			UUIItem item = base.GetItem(2);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		}

		// Token: 0x06040762 RID: 264034 RVA: 0x00F994FF File Offset: 0x00F976FF
		private void OnToggleClick(EToggleState _)
		{
			this.OnToggleClickCallBack(this.Type);
		}

		// Token: 0x06040763 RID: 264035 RVA: 0x00F99512 File Offset: 0x00F97712
		[NullableContext(1)]
		public override object GetKey(EMotorFightAttrShowType data, int displayIndex)
		{
			return data;
		}

		// Token: 0x06040764 RID: 264036 RVA: 0x00F9951C File Offset: 0x00F9771C
		public void SetToggleState(bool state)
		{
			EToggleState state2 = state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(1).SetToggleState(state2, false, false, false);
		}

		// Token: 0x06040765 RID: 264037 RVA: 0x00F99542 File Offset: 0x00F97742
		public override void OnSelected(bool fireEvent)
		{
			this.SetToggleState(true);
		}

		// Token: 0x06040766 RID: 264038 RVA: 0x00F9954B File Offset: 0x00F9774B
		public override void OnDeselected(bool fireEvent)
		{
			this.SetToggleState(false);
		}

		// Token: 0x04021835 RID: 137269
		private EMotorFightAttrShowType Type;

		// Token: 0x04021836 RID: 137270
		[Nullable(1)]
		public Action<EMotorFightAttrShowType> OnToggleClickCallBack = delegate(EMotorFightAttrShowType type)
		{
		};

		// Token: 0x0200C653 RID: 50771
		private class ETabComponent
		{
			// Token: 0x0403BDF6 RID: 245238
			public const int TextName = 0;

			// Token: 0x0403BDF7 RID: 245239
			public const int ToggleRoot = 1;

			// Token: 0x0403BDF8 RID: 245240
			public const int ItemRedDot = 2;
		}
	}
}
