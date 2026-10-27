using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E22 RID: 15906
	public class IFastReturnMapPosT
	{
		// Token: 0x17006DFD RID: 28157
		// (get) Token: 0x0601649F RID: 91295 RVA: 0x00337FDA File Offset: 0x003361DA
		// (set) Token: 0x060164A0 RID: 91296 RVA: 0x00337FE2 File Offset: 0x003361E2
		public string TidTip { get; set; }

		// Token: 0x17006DFE RID: 28158
		// (get) Token: 0x060164A1 RID: 91297 RVA: 0x00337FEB File Offset: 0x003361EB
		// (set) Token: 0x060164A2 RID: 91298 RVA: 0x00337FF3 File Offset: 0x003361F3
		public List<IConditionGroupT> ShowButtonConditionGroup { get; set; }

		// Token: 0x17006DFF RID: 28159
		// (get) Token: 0x060164A3 RID: 91299 RVA: 0x00337FFC File Offset: 0x003361FC
		// (set) Token: 0x060164A4 RID: 91300 RVA: 0x00338004 File Offset: 0x00336204
		public TFastReturnPosUnion DefaultPos { get; set; }

		// Token: 0x17006E00 RID: 28160
		// (get) Token: 0x060164A5 RID: 91301 RVA: 0x0033800D File Offset: 0x0033620D
		// (set) Token: 0x060164A6 RID: 91302 RVA: 0x00338015 File Offset: 0x00336215
		public List<IConditionReturnPosT> ConditionPositionGroup { get; set; }

		// Token: 0x17006E01 RID: 28161
		// (get) Token: 0x060164A7 RID: 91303 RVA: 0x0033801E File Offset: 0x0033621E
		// (set) Token: 0x060164A8 RID: 91304 RVA: 0x00338026 File Offset: 0x00336226
		public byte NullMask { get; set; }

		// Token: 0x060164A9 RID: 91305 RVA: 0x0033802F File Offset: 0x0033622F
		public IFastReturnMapPosT()
		{
			this.TidTip = null;
			this.ShowButtonConditionGroup = null;
			this.DefaultPos = null;
			this.ConditionPositionGroup = null;
			this.NullMask = 0;
		}
	}
}
