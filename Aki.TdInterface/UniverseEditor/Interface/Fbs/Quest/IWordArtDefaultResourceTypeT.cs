using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046FE RID: 18174
	public class IWordArtDefaultResourceTypeT
	{
		// Token: 0x17007F4A RID: 32586
		// (get) Token: 0x0601ABDB RID: 109531 RVA: 0x003CCB76 File Offset: 0x003CAD76
		// (set) Token: 0x0601ABDC RID: 109532 RVA: 0x003CCB7E File Offset: 0x003CAD7E
		public EWordArtResourceType Type { get; set; }

		// Token: 0x17007F4B RID: 32587
		// (get) Token: 0x0601ABDD RID: 109533 RVA: 0x003CCB87 File Offset: 0x003CAD87
		// (set) Token: 0x0601ABDE RID: 109534 RVA: 0x003CCB8F File Offset: 0x003CAD8F
		public float Scale { get; set; }

		// Token: 0x17007F4C RID: 32588
		// (get) Token: 0x0601ABDF RID: 109535 RVA: 0x003CCB98 File Offset: 0x003CAD98
		// (set) Token: 0x0601ABE0 RID: 109536 RVA: 0x003CCBA0 File Offset: 0x003CADA0
		public byte NullMask { get; set; }

		// Token: 0x0601ABE1 RID: 109537 RVA: 0x003CCBA9 File Offset: 0x003CADA9
		public IWordArtDefaultResourceTypeT()
		{
			this.Type = EWordArtResourceType.Default;
			this.Scale = 0f;
			this.NullMask = 0;
		}
	}
}
