using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001724 RID: 5924
[Nullable(new byte[]
{
	0,
	1
})]
public class MotorcycleTechTreeLevelItem : GridProxyAbstract<IMotorTechLevelPoint>
{
	// Token: 0x0600E64E RID: 58958 RVA: 0x004393C9 File Offset: 0x004375C9
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite))
		};
	}

	// Token: 0x0600E64F RID: 58959 RVA: 0x004393EC File Offset: 0x004375EC
	[NullableContext(1)]
	public override void Refresh(IMotorTechLevelPoint data, bool isSelected, int gridIndex)
	{
		int targetLevel = data.TargetLevel;
		bool uiactive = data.CurLevel >= targetLevel;
		base.GetSprite(0).SetUIActive(uiactive);
	}

	// Token: 0x02007905 RID: 30981
	private class EMotorTechLevelItemComponent
	{
		// Token: 0x040273B6 RID: 160694
		public const int SprLevel = 0;
	}
}
