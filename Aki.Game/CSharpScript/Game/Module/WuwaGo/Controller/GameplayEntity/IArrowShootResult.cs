using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.WuwaGo.Model.Role;

namespace CSharpScript.Game.Module.WuwaGo.Controller.GameplayEntity
{
	// Token: 0x02004767 RID: 18279
	[NullableContext(2)]
	public interface IArrowShootResult
	{
		// Token: 0x17007757 RID: 30551
		// (get) Token: 0x0602FC8A RID: 195722
		// (set) Token: 0x0602FC8B RID: 195723
		WuWaGoRole HitRole { get; set; }

		// Token: 0x17007758 RID: 30552
		// (get) Token: 0x0602FC8C RID: 195724
		// (set) Token: 0x0602FC8D RID: 195725
		bool HitWall { get; set; }

		// Token: 0x17007759 RID: 30553
		// (get) Token: 0x0602FC8E RID: 195726
		// (set) Token: 0x0602FC8F RID: 195727
		float TargetDistanceMeter { get; set; }
	}
}
