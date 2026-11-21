using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001682 RID: 5762
[NullableContext(1)]
[Nullable(0)]
public class LordGymFilterTypeTabItem : GridProxyAbstract<LordGymFilterType>
{
	// Token: 0x0600E042 RID: 57410 RVA: 0x0041D047 File Offset: 0x0041B247
	public LordGymFilterTypeTabItem(Action<int> onSelect)
	{
		this.OnSelect = onSelect;
	}

	// Token: 0x0600E043 RID: 57411 RVA: 0x0041D058 File Offset: 0x0041B258
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUISprite))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleClick))
		};
	}

	// Token: 0x0600E044 RID: 57412 RVA: 0x0041D0EB File Offset: 0x0041B2EB
	public override void Refresh(LordGymFilterType data, bool isSelected, int gridIndex)
	{
		this.FilterTypeId = data.Id;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), data.Name, Array.Empty<object>());
	}

	// Token: 0x0600E045 RID: 57413 RVA: 0x0041D117 File Offset: 0x0041B317
	public int GetFilterTypeId()
	{
		return this.FilterTypeId;
	}

	// Token: 0x0600E046 RID: 57414 RVA: 0x0041D11F File Offset: 0x0041B31F
	public void SetToggleActive(bool selected)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(selected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0600E047 RID: 57415 RVA: 0x0041D13D File Offset: 0x0041B33D
	public override object GetKey(LordGymFilterType data, int gridIndex)
	{
		return data.Id;
	}

	// Token: 0x0600E048 RID: 57416 RVA: 0x0041D14B File Offset: 0x0041B34B
	private void OnToggleClick(EToggleState toggleState)
	{
		this.OnSelect(this.FilterTypeId);
	}

	// Token: 0x040080B0 RID: 32944
	private int FilterTypeId;

	// Token: 0x040080B1 RID: 32945
	private readonly Action<int> OnSelect;

	// Token: 0x02007854 RID: 30804
	[NullableContext(0)]
	private class ETabComponents
	{
		// Token: 0x040270CE RID: 159950
		public const int Toggle = 0;

		// Token: 0x040270CF RID: 159951
		public const int SprIcon = 1;

		// Token: 0x040270D0 RID: 159952
		public const int TxtTitle = 2;

		// Token: 0x040270D1 RID: 159953
		public const int SprIconR = 3;
	}
}
