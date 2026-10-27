using System;
using Aki.Config;
using CSharpScript.Game.Module.Map.MapDefine;

namespace CSharpScript.Game.Module.Map.Mark
{
	// Token: 0x020054BF RID: 21695
	public interface ICreateMarkParam
	{
		// Token: 0x170084D1 RID: 34001
		// (get) Token: 0x06037650 RID: 226896
		// (set) Token: 0x06037651 RID: 226897
		int MarkId { get; set; }

		// Token: 0x170084D2 RID: 34002
		// (get) Token: 0x06037652 RID: 226898
		// (set) Token: 0x06037653 RID: 226899
		EMarkType MarkType { get; set; }

		// Token: 0x170084D3 RID: 34003
		// (get) Token: 0x06037654 RID: 226900
		// (set) Token: 0x06037655 RID: 226901
		EMapGravityDirection Gravity { get; set; }

		// Token: 0x170084D4 RID: 34004
		// (get) Token: 0x06037656 RID: 226902
		// (set) Token: 0x06037657 RID: 226903
		MapMark Config { get; set; }

		// Token: 0x170084D5 RID: 34005
		// (get) Token: 0x06037658 RID: 226904
		// (set) Token: 0x06037659 RID: 226905
		DynamicMapMark DynamicConfig { get; set; }

		// Token: 0x170084D6 RID: 34006
		// (get) Token: 0x0603765A RID: 226906
		// (set) Token: 0x0603765B RID: 226907
		int EntityId { get; set; }

		// Token: 0x170084D7 RID: 34007
		// (get) Token: 0x0603765C RID: 226908
		// (set) Token: 0x0603765D RID: 226909
		int MapId { get; set; }
	}
}
