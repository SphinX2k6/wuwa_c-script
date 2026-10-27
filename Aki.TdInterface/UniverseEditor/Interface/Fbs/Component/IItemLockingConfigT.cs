using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200549E RID: 21662
	public class IItemLockingConfigT
	{
		// Token: 0x17009F82 RID: 40834
		// (get) Token: 0x06023A7E RID: 146046 RVA: 0x004EDF55 File Offset: 0x004EC155
		// (set) Token: 0x06023A7F RID: 146047 RVA: 0x004EDF5D File Offset: 0x004EC15D
		public string EffectPath { get; set; }

		// Token: 0x17009F83 RID: 40835
		// (get) Token: 0x06023A80 RID: 146048 RVA: 0x004EDF66 File Offset: 0x004EC166
		// (set) Token: 0x06023A81 RID: 146049 RVA: 0x004EDF6E File Offset: 0x004EC16E
		public ETeleControlLockingPerform TeleControlPerform { get; set; }

		// Token: 0x17009F84 RID: 40836
		// (get) Token: 0x06023A82 RID: 146050 RVA: 0x004EDF77 File Offset: 0x004EC177
		// (set) Token: 0x06023A83 RID: 146051 RVA: 0x004EDF7F File Offset: 0x004EC17F
		public byte NullMask { get; set; }

		// Token: 0x06023A84 RID: 146052 RVA: 0x004EDF88 File Offset: 0x004EC188
		public IItemLockingConfigT()
		{
			this.EffectPath = null;
			this.TeleControlPerform = ETeleControlLockingPerform.RightMatch;
			this.NullMask = 0;
		}
	}
}
