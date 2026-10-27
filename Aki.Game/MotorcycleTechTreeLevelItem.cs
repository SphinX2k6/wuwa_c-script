using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002240 RID: 8768
[Nullable(new byte[]
{
	0,
	1
})]
public class MotorcycleTechTreeLevelItem : GridProxyAbstract<IMotorTechLevelPoint>
{
	// Token: 0x060111B8 RID: 70072 RVA: 0x0042C825 File Offset: 0x0042AA25
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite))
		};
	}

	// Token: 0x060111B9 RID: 70073 RVA: 0x0042C848 File Offset: 0x0042AA48
	[NullableContext(1)]
	public override void Refresh(IMotorTechLevelPoint data, bool isSelected, int gridIndex)
	{
		int targetLevel = data.TargetLevel;
		bool uiactive = data.CurLevel >= targetLevel;
		base.GetSprite(0).SetUIActive(uiactive);
	}

	// Token: 0x0200877C RID: 34684
	private class EMotorTechLevelItemComponent
	{
		// Token: 0x0402C09E RID: 180382
		public const int SprLevel = 0;
	}
}
