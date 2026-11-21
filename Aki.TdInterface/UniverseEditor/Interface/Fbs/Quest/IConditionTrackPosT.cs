using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041D3 RID: 16851
	public class IConditionTrackPosT
	{
		// Token: 0x170072D2 RID: 29394
		// (get) Token: 0x06017606 RID: 95750 RVA: 0x0035798B File Offset: 0x00355B8B
		// (set) Token: 0x06017607 RID: 95751 RVA: 0x00357993 File Offset: 0x00355B93
		public IConditionGroupT Condition { get; set; }

		// Token: 0x170072D3 RID: 29395
		// (get) Token: 0x06017608 RID: 95752 RVA: 0x0035799C File Offset: 0x00355B9C
		// (set) Token: 0x06017609 RID: 95753 RVA: 0x003579A4 File Offset: 0x00355BA4
		public IVectorInfoT TrackPos { get; set; }

		// Token: 0x0601760A RID: 95754 RVA: 0x003579AD File Offset: 0x00355BAD
		public IConditionTrackPosT()
		{
			this.Condition = null;
			this.TrackPos = null;
		}
	}
}
