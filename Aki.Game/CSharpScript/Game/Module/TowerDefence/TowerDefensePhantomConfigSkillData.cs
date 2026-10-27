using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02004B36 RID: 19254
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefensePhantomConfigSkillData : ITowerDefensePhantomConfigSkillData
	{
		// Token: 0x17007B86 RID: 31622
		// (get) Token: 0x06031DCA RID: 204234 RVA: 0x00B927B5 File Offset: 0x00B909B5
		// (set) Token: 0x06031DCB RID: 204235 RVA: 0x00B927BD File Offset: 0x00B909BD
		public string Name { get; set; }

		// Token: 0x17007B87 RID: 31623
		// (get) Token: 0x06031DCC RID: 204236 RVA: 0x00B927C6 File Offset: 0x00B909C6
		// (set) Token: 0x06031DCD RID: 204237 RVA: 0x00B927CE File Offset: 0x00B909CE
		public string Description { get; set; }

		// Token: 0x17007B88 RID: 31624
		// (get) Token: 0x06031DCE RID: 204238 RVA: 0x00B927D7 File Offset: 0x00B909D7
		// (set) Token: 0x06031DCF RID: 204239 RVA: 0x00B927DF File Offset: 0x00B909DF
		public string UnlockDescription { get; set; }

		// Token: 0x17007B89 RID: 31625
		// (get) Token: 0x06031DD0 RID: 204240 RVA: 0x00B927E8 File Offset: 0x00B909E8
		// (set) Token: 0x06031DD1 RID: 204241 RVA: 0x00B927F0 File Offset: 0x00B909F0
		public double? ExpThreshold { get; set; }

		// Token: 0x17007B8A RID: 31626
		// (get) Token: 0x06031DD2 RID: 204242 RVA: 0x00B927F9 File Offset: 0x00B909F9
		// (set) Token: 0x06031DD3 RID: 204243 RVA: 0x00B92801 File Offset: 0x00B90A01
		public int PhantomSkill { get; set; }
	}
}
