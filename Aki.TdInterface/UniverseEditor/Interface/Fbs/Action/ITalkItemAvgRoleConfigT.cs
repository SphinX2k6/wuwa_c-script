using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007AA7 RID: 31399
	public class ITalkItemAvgRoleConfigT
	{
		// Token: 0x1700E787 RID: 59271
		// (get) Token: 0x06037B01 RID: 228097 RVA: 0x00776778 File Offset: 0x00774978
		// (set) Token: 0x06037B02 RID: 228098 RVA: 0x00776780 File Offset: 0x00774980
		public EAvgVisualEffect VisualEffect { get; set; }

		// Token: 0x1700E788 RID: 59272
		// (get) Token: 0x06037B03 RID: 228099 RVA: 0x00776789 File Offset: 0x00774989
		// (set) Token: 0x06037B04 RID: 228100 RVA: 0x00776791 File Offset: 0x00774991
		public EAvgRoleAnimationType AnimationType { get; set; }

		// Token: 0x1700E789 RID: 59273
		// (get) Token: 0x06037B05 RID: 228101 RVA: 0x0077679A File Offset: 0x0077499A
		// (set) Token: 0x06037B06 RID: 228102 RVA: 0x007767A2 File Offset: 0x007749A2
		public bool IsAnimationLoop { get; set; }

		// Token: 0x1700E78A RID: 59274
		// (get) Token: 0x06037B07 RID: 228103 RVA: 0x007767AB File Offset: 0x007749AB
		// (set) Token: 0x06037B08 RID: 228104 RVA: 0x007767B3 File Offset: 0x007749B3
		public byte NullMask { get; set; }

		// Token: 0x06037B09 RID: 228105 RVA: 0x007767BC File Offset: 0x007749BC
		public ITalkItemAvgRoleConfigT()
		{
			this.VisualEffect = EAvgVisualEffect.Default;
			this.AnimationType = EAvgRoleAnimationType.Idle;
			this.IsAnimationLoop = false;
			this.NullMask = 0;
		}
	}
}
