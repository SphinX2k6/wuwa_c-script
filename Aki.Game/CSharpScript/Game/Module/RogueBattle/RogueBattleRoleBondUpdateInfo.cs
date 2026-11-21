using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003E8F RID: 16015
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueBattleRoleBondUpdateInfo : IRogueBattleRoleBondUpdateInfo
	{
		// Token: 0x1700529E RID: 21150
		// (get) Token: 0x06028AD7 RID: 166615 RVA: 0x00B6A3B5 File Offset: 0x00B685B5
		// (set) Token: 0x06028AD8 RID: 166616 RVA: 0x00B6A3BD File Offset: 0x00B685BD
		public RoleBondInfo OldRoleBondInfo { get; set; }

		// Token: 0x1700529F RID: 21151
		// (get) Token: 0x06028AD9 RID: 166617 RVA: 0x00B6A3C6 File Offset: 0x00B685C6
		// (set) Token: 0x06028ADA RID: 166618 RVA: 0x00B6A3CE File Offset: 0x00B685CE
		public RoleBondInfo NewRoleBondInfo { get; set; }

		// Token: 0x170052A0 RID: 21152
		// (get) Token: 0x06028ADB RID: 166619 RVA: 0x00B6A3D7 File Offset: 0x00B685D7
		// (set) Token: 0x06028ADC RID: 166620 RVA: 0x00B6A3DF File Offset: 0x00B685DF
		public int AddStar { get; set; }
	}
}
