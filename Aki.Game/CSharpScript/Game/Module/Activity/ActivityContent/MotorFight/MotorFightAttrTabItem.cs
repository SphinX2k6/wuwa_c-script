using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorFight
{
	// Token: 0x020053A2 RID: 21410
	public class MotorFightAttrTabItem : GridProxyAbstract<EMotorFightAttrShowType>
	{
		// Token: 0x06035420 RID: 218144 RVA: 0x00EE0383 File Offset: 0x00EDE583
		protected override void OnStart()
		{
			base.GetExtendToggle(1).bLockStateOnSelect = true;
			this.SetToggleState(false);
		}

		// Token: 0x06035421 RID: 218145 RVA: 0x00EE039C File Offset: 0x00EDE59C
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

		// Token: 0x06035422 RID: 218146 RVA: 0x00EE0463 File Offset: 0x00EDE663
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

		// Token: 0x06035423 RID: 218147 RVA: 0x00EE049F File Offset: 0x00EDE69F
		private void OnToggleClick(EToggleState _)
		{
			this.OnToggleClickCallBack(this.Type);
		}

		// Token: 0x06035424 RID: 218148 RVA: 0x00EE04B2 File Offset: 0x00EDE6B2
		[NullableContext(1)]
		public override object GetKey(EMotorFightAttrShowType data, int displayIndex)
		{
			return data;
		}

		// Token: 0x06035425 RID: 218149 RVA: 0x00EE04BC File Offset: 0x00EDE6BC
		public void SetToggleState(bool state)
		{
			EToggleState state2 = state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(1).SetToggleState(state2, false, false, false);
		}

		// Token: 0x06035426 RID: 218150 RVA: 0x00EE04E2 File Offset: 0x00EDE6E2
		public override void OnSelected(bool fireEvent)
		{
			this.SetToggleState(true);
		}

		// Token: 0x06035427 RID: 218151 RVA: 0x00EE04EB File Offset: 0x00EDE6EB
		public override void OnDeselected(bool fireEvent)
		{
			this.SetToggleState(false);
		}

		// Token: 0x0401C164 RID: 115044
		private EMotorFightAttrShowType Type;

		// Token: 0x0401C165 RID: 115045
		[Nullable(1)]
		public Action<EMotorFightAttrShowType> OnToggleClickCallBack = delegate(EMotorFightAttrShowType type)
		{
		};

		// Token: 0x0200B03A RID: 45114
		private class ETabComponent
		{
			// Token: 0x04036753 RID: 223059
			public const int TextName = 0;

			// Token: 0x04036754 RID: 223060
			public const int ToggleRoot = 1;

			// Token: 0x04036755 RID: 223061
			public const int ItemRedDot = 2;
		}
	}
}
