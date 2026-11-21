using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.WuwaGo.Model.Role;

namespace CSharpScript.Game.Module.WuwaGo.Controller.GameplayEntity
{
	// Token: 0x02003698 RID: 13976
	[NullableContext(2)]
	public interface IArrowShootResult
	{
		// Token: 0x17004A13 RID: 18963
		// (get) Token: 0x06024454 RID: 148564
		// (set) Token: 0x06024455 RID: 148565
		WuWaGoRole HitRole { get; set; }

		// Token: 0x17004A14 RID: 18964
		// (get) Token: 0x06024456 RID: 148566
		// (set) Token: 0x06024457 RID: 148567
		bool HitWall { get; set; }

		// Token: 0x17004A15 RID: 18965
		// (get) Token: 0x06024458 RID: 148568
		// (set) Token: 0x06024459 RID: 148569
		float TargetDistanceMeter { get; set; }
	}
}
