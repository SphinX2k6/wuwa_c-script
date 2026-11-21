using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200410D RID: 16653
	public class IAddTimeConfigT
	{
		// Token: 0x170070B9 RID: 28857
		// (get) Token: 0x06016D3D RID: 93501 RVA: 0x003424F6 File Offset: 0x003406F6
		// (set) Token: 0x06016D3E RID: 93502 RVA: 0x003424FE File Offset: 0x003406FE
		public IKillMonsterT MonsterConfig { get; set; }

		// Token: 0x170070BA RID: 28858
		// (get) Token: 0x06016D3F RID: 93503 RVA: 0x00342507 File Offset: 0x00340707
		// (set) Token: 0x06016D40 RID: 93504 RVA: 0x0034250F File Offset: 0x0034070F
		public List<IAddTimeStateConditionT> StateConfig { get; set; }

		// Token: 0x170070BB RID: 28859
		// (get) Token: 0x06016D41 RID: 93505 RVA: 0x00342518 File Offset: 0x00340718
		// (set) Token: 0x06016D42 RID: 93506 RVA: 0x00342520 File Offset: 0x00340720
		public byte NullMask { get; set; }

		// Token: 0x06016D43 RID: 93507 RVA: 0x00342529 File Offset: 0x00340729
		public IAddTimeConfigT()
		{
			this.MonsterConfig = null;
			this.StateConfig = null;
			this.NullMask = 0;
		}
	}
}
