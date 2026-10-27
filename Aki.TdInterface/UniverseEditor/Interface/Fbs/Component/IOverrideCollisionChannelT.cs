using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056AE RID: 22190
	public class IOverrideCollisionChannelT
	{
		// Token: 0x1700A508 RID: 42248
		// (get) Token: 0x060250A8 RID: 151720 RVA: 0x0051D4B2 File Offset: 0x0051B6B2
		// (set) Token: 0x060250A9 RID: 151721 RVA: 0x0051D4BA File Offset: 0x0051B6BA
		public ECollisionChannelPreset CollisionChannelPreset { get; set; }

		// Token: 0x1700A509 RID: 42249
		// (get) Token: 0x060250AA RID: 151722 RVA: 0x0051D4C3 File Offset: 0x0051B6C3
		// (set) Token: 0x060250AB RID: 151723 RVA: 0x0051D4CB File Offset: 0x0051B6CB
		public float BlurResponseRadius { get; set; }

		// Token: 0x1700A50A RID: 42250
		// (get) Token: 0x060250AC RID: 151724 RVA: 0x0051D4D4 File Offset: 0x0051B6D4
		// (set) Token: 0x060250AD RID: 151725 RVA: 0x0051D4DC File Offset: 0x0051B6DC
		public byte NullMask { get; set; }

		// Token: 0x060250AE RID: 151726 RVA: 0x0051D4E5 File Offset: 0x0051B6E5
		public IOverrideCollisionChannelT()
		{
			this.CollisionChannelPreset = ECollisionChannelPreset.CanBePassedThrough;
			this.BlurResponseRadius = 0f;
			this.NullMask = 0;
		}
	}
}
