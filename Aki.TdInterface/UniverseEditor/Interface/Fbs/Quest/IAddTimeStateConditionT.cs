using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004110 RID: 16656
	public class IAddTimeStateConditionT
	{
		// Token: 0x170070BF RID: 28863
		// (get) Token: 0x06016D55 RID: 93525 RVA: 0x003427C7 File Offset: 0x003409C7
		// (set) Token: 0x06016D56 RID: 93526 RVA: 0x003427CF File Offset: 0x003409CF
		public IEntityStateConditionT Condition { get; set; }

		// Token: 0x170070C0 RID: 28864
		// (get) Token: 0x06016D57 RID: 93527 RVA: 0x003427D8 File Offset: 0x003409D8
		// (set) Token: 0x06016D58 RID: 93528 RVA: 0x003427E0 File Offset: 0x003409E0
		public int AddTime { get; set; }

		// Token: 0x06016D59 RID: 93529 RVA: 0x003427E9 File Offset: 0x003409E9
		public IAddTimeStateConditionT()
		{
			this.Condition = null;
			this.AddTime = 0;
		}
	}
}
