using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Monster
{
	// Token: 0x0200632C RID: 25388
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PinballMonsterSkillTabItem : GridProxyAbstract<IPinballMonsterSkillTabItemData>
	{
		// Token: 0x0603FDF7 RID: 261623 RVA: 0x00F742A4 File Offset: 0x00F724A4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnItemToggleStateChange));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603FDF8 RID: 261624 RVA: 0x00F7434A File Offset: 0x00F7254A
		[NullableContext(1)]
		public override void Refresh(IPinballMonsterSkillTabItemData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			this.RefreshToggle(true);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.Name, Array.Empty<object>());
		}

		// Token: 0x0603FDF9 RID: 261625 RVA: 0x00F74378 File Offset: 0x00F72578
		public void RefreshToggle(bool bJumpToEnd)
		{
			if (this.Data == null)
			{
				return;
			}
			EToggleState state = this.Data.IsSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(state, false, false, bJumpToEnd);
		}

		// Token: 0x0603FDFA RID: 261626 RVA: 0x00F743B6 File Offset: 0x00F725B6
		private void OnItemToggleStateChange(EToggleState state)
		{
			if (this.Data == null)
			{
				return;
			}
			this.Data.OnSelected(base.GridIndex);
		}

		// Token: 0x04021525 RID: 136485
		[Nullable(2)]
		private IPinballMonsterSkillTabItemData Data;

		// Token: 0x0200C529 RID: 50473
		private enum EComponents
		{
			// Token: 0x0403B81E RID: 243742
			ItemToggle,
			// Token: 0x0403B81F RID: 243743
			NameText
		}
	}
}
