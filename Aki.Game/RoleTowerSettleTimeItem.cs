using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001CD0 RID: 7376
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleTowerSettleTimeItem : GridProxyAbstract<RoleTowerWaveRecordData>
{
	// Token: 0x0601243C RID: 74812 RVA: 0x00562540 File Offset: 0x00560740
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x0601243D RID: 74813 RVA: 0x0056257C File Offset: 0x0056077C
	public override void Refresh(RoleTowerWaveRecordData data, bool isSelected, int gridIndex)
	{
		RoleTowerFloor? floorById = RoleTowerConfig.Instance.GetFloorById(data.FloorId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), (floorById != null) ? floorById.GetValueOrDefault().FloorShortName : null, Array.Empty<object>());
		UUIText text = base.GetText(1);
		if (text != null)
		{
			UUIItem uuiitem = text;
			bool bUseChangeColor = data.CostTime > 0L;
			FColor? fcolor = new FColor?(text.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			text.SetText(RoleTowerTimeUtil.FormatDeltaHud(data.CostTime), true);
		}
	}

	// Token: 0x0601243E RID: 74814 RVA: 0x00562606 File Offset: 0x00560806
	public override object GetKey(RoleTowerWaveRecordData data, int displayIndex)
	{
		return displayIndex;
	}

	// Token: 0x02007FC2 RID: 32706
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402954D RID: 169293
		public const int TxtName = 0;

		// Token: 0x0402954E RID: 169294
		public const int TxtValue = 1;
	}
}
