using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041E2 RID: 16866
	public class IDarkTideBossEventT
	{
		// Token: 0x170072EA RID: 29418
		// (get) Token: 0x06017674 RID: 95860 RVA: 0x003584B2 File Offset: 0x003566B2
		// (set) Token: 0x06017675 RID: 95861 RVA: 0x003584BA File Offset: 0x003566BA
		public EDarkTideBossEventType Type { get; set; }

		// Token: 0x06017676 RID: 95862 RVA: 0x003584C3 File Offset: 0x003566C3
		public IDarkTideBossEventT()
		{
			this.Type = EDarkTideBossEventType.XinjilemuChase;
		}
	}
}
