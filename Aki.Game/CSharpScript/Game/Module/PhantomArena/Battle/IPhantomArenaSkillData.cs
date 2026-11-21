using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle
{
	// Token: 0x0200420A RID: 16906
	[NullableContext(1)]
	public interface IPhantomArenaSkillData
	{
		// Token: 0x170055FD RID: 22013
		// (get) Token: 0x0602AB60 RID: 174944
		// (set) Token: 0x0602AB61 RID: 174945
		bool IsOwn { get; set; }

		// Token: 0x170055FE RID: 22014
		// (get) Token: 0x0602AB62 RID: 174946
		// (set) Token: 0x0602AB63 RID: 174947
		int SkillId { get; set; }

		// Token: 0x170055FF RID: 22015
		// (get) Token: 0x0602AB64 RID: 174948
		// (set) Token: 0x0602AB65 RID: 174949
		bool IsPassive { get; set; }

		// Token: 0x17005600 RID: 22016
		// (get) Token: 0x0602AB66 RID: 174950
		// (set) Token: 0x0602AB67 RID: 174951
		string Icon { get; set; }

		// Token: 0x17005601 RID: 22017
		// (get) Token: 0x0602AB68 RID: 174952
		// (set) Token: 0x0602AB69 RID: 174953
		string SkillName { get; set; }

		// Token: 0x17005602 RID: 22018
		// (get) Token: 0x0602AB6A RID: 174954
		// (set) Token: 0x0602AB6B RID: 174955
		string SkillDesc { get; set; }

		// Token: 0x17005603 RID: 22019
		// (get) Token: 0x0602AB6C RID: 174956
		// (set) Token: 0x0602AB6D RID: 174957
		List<string> SkillDescParams { get; set; }

		// Token: 0x17005604 RID: 22020
		// (get) Token: 0x0602AB6E RID: 174958
		// (set) Token: 0x0602AB6F RID: 174959
		int CostConsume { get; set; }
	}
}
