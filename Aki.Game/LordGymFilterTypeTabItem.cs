using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200219E RID: 8606
[NullableContext(1)]
[Nullable(0)]
public class LordGymFilterTypeTabItem : GridProxyAbstract<LordGymFilterType>
{
	// Token: 0x06010BB1 RID: 68529 RVA: 0x0041075F File Offset: 0x0040E95F
	public LordGymFilterTypeTabItem(Action<int> onSelect)
	{
		this.OnSelect = onSelect;
	}

	// Token: 0x06010BB2 RID: 68530 RVA: 0x00410770 File Offset: 0x0040E970
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

	// Token: 0x06010BB3 RID: 68531 RVA: 0x00410803 File Offset: 0x0040EA03
	public override void Refresh(LordGymFilterType data, bool isSelected, int gridIndex)
	{
		this.FilterTypeId = data.Id;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), data.Name, Array.Empty<object>());
	}

	// Token: 0x06010BB4 RID: 68532 RVA: 0x0041082F File Offset: 0x0040EA2F
	public int GetFilterTypeId()
	{
		return this.FilterTypeId;
	}

	// Token: 0x06010BB5 RID: 68533 RVA: 0x00410837 File Offset: 0x0040EA37
	public void SetToggleActive(bool selected)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(selected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06010BB6 RID: 68534 RVA: 0x00410855 File Offset: 0x0040EA55
	public override object GetKey(LordGymFilterType data, int gridIndex)
	{
		return data.Id;
	}

	// Token: 0x06010BB7 RID: 68535 RVA: 0x00410863 File Offset: 0x0040EA63
	private void OnToggleClick(EToggleState toggleState)
	{
		this.OnSelect(this.FilterTypeId);
	}

	// Token: 0x04007F69 RID: 32617
	private int FilterTypeId;

	// Token: 0x04007F6A RID: 32618
	private readonly Action<int> OnSelect;

	// Token: 0x020086C9 RID: 34505
	[NullableContext(0)]
	private class ETabComponents
	{
		// Token: 0x0402BDAD RID: 179629
		public const int Toggle = 0;

		// Token: 0x0402BDAE RID: 179630
		public const int SprIcon = 1;

		// Token: 0x0402BDAF RID: 179631
		public const int TxtTitle = 2;

		// Token: 0x0402BDB0 RID: 179632
		public const int SprIconR = 3;
	}
}
