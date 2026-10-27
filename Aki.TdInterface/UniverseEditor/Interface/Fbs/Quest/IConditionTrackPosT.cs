using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DBC RID: 15804
	public class IConditionTrackPosT
	{
		// Token: 0x17006D18 RID: 27928
		// (get) Token: 0x060160CD RID: 90317 RVA: 0x00330603 File Offset: 0x0032E803
		// (set) Token: 0x060160CE RID: 90318 RVA: 0x0033060B File Offset: 0x0032E80B
		public IConditionGroupT Condition { get; set; }

		// Token: 0x17006D19 RID: 27929
		// (get) Token: 0x060160CF RID: 90319 RVA: 0x00330614 File Offset: 0x0032E814
		// (set) Token: 0x060160D0 RID: 90320 RVA: 0x0033061C File Offset: 0x0032E81C
		public IVectorInfoT TrackPos { get; set; }

		// Token: 0x060160D1 RID: 90321 RVA: 0x00330625 File Offset: 0x0032E825
		public IConditionTrackPosT()
		{
			this.Condition = null;
			this.TrackPos = null;
		}
	}
}
