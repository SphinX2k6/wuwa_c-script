using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Monster
{
	// Token: 0x020052AA RID: 21162
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PinballMonsterSkillTabItem : GridProxyAbstract<IPinballMonsterSkillTabItemData>
	{
		// Token: 0x06034AB8 RID: 215736 RVA: 0x00EBB200 File Offset: 0x00EB9400
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

		// Token: 0x06034AB9 RID: 215737 RVA: 0x00EBB2A6 File Offset: 0x00EB94A6
		[NullableContext(1)]
		public override void Refresh(IPinballMonsterSkillTabItemData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			this.RefreshToggle(true);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.Name, Array.Empty<object>());
		}

		// Token: 0x06034ABA RID: 215738 RVA: 0x00EBB2D4 File Offset: 0x00EB94D4
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

		// Token: 0x06034ABB RID: 215739 RVA: 0x00EBB312 File Offset: 0x00EB9512
		private void OnItemToggleStateChange(EToggleState state)
		{
			if (this.Data == null)
			{
				return;
			}
			this.Data.OnSelected(base.GridIndex);
		}

		// Token: 0x0401BE54 RID: 114260
		[Nullable(2)]
		private IPinballMonsterSkillTabItemData Data;

		// Token: 0x0200AF10 RID: 44816
		private enum EComponents
		{
			// Token: 0x04036180 RID: 221568
			ItemToggle,
			// Token: 0x04036181 RID: 221569
			NameText
		}
	}
}
