using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001164 RID: 4452
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class BabelTowerTeamTabItem : GridProxyAbstract<string>
{
	// Token: 0x0600758A RID: 30090 RVA: 0x0018477C File Offset: 0x0018297C
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

	// Token: 0x0600758B RID: 30091 RVA: 0x00184843 File Offset: 0x00182A43
	protected override void OnStart()
	{
		UUIItem item = base.GetItem(2);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(false);
	}

	// Token: 0x0600758C RID: 30092 RVA: 0x00184857 File Offset: 0x00182A57
	public override void Refresh(string data, bool isSelected, int gridIndex)
	{
		UUIText text = base.GetText(1);
		if (text != null)
		{
			text.ShowTextNew(data);
		}
		this.SetSelected(isSelected);
	}

	// Token: 0x0600758D RID: 30093 RVA: 0x00184873 File Offset: 0x00182A73
	public void SetToggleClickCallback(Action<EBabelTowerTeamTabType> callback)
	{
		this.ToggleClickCallback = callback;
	}

	// Token: 0x0600758E RID: 30094 RVA: 0x0018487C File Offset: 0x00182A7C
	private void OnToggleClick(EToggleState state)
	{
		if (state != EToggleState.ETT_Checked)
		{
			return;
		}
		Action<EBabelTowerTeamTabType> toggleClickCallback = this.ToggleClickCallback;
		if (toggleClickCallback == null)
		{
			return;
		}
		toggleClickCallback((EBabelTowerTeamTabType)base.GridIndex);
	}

	// Token: 0x0600758F RID: 30095 RVA: 0x0018489B File Offset: 0x00182A9B
	public override void OnSelected(bool fireEvent)
	{
		this.SetSelected(true);
		if (fireEvent)
		{
			Action<EBabelTowerTeamTabType> toggleClickCallback = this.ToggleClickCallback;
			if (toggleClickCallback == null)
			{
				return;
			}
			toggleClickCallback((EBabelTowerTeamTabType)base.GridIndex);
		}
	}

	// Token: 0x06007590 RID: 30096 RVA: 0x001848BD File Offset: 0x00182ABD
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false);
	}

	// Token: 0x06007591 RID: 30097 RVA: 0x001848C6 File Offset: 0x00182AC6
	private void SetSelected(bool selected)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(selected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x040035F7 RID: 13815
	[Nullable(2)]
	private Action<EBabelTowerTeamTabType> ToggleClickCallback;

	// Token: 0x02007736 RID: 30518
	[NullableContext(0)]
	private class ETabItem
	{
		// Token: 0x04027539 RID: 161081
		public const int Toggle = 0;

		// Token: 0x0402753A RID: 161082
		public const int Name = 1;

		// Token: 0x0402753B RID: 161083
		public const int RedDot = 2;
	}
}
