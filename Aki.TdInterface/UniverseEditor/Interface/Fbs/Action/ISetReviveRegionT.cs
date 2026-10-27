using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200706B RID: 28779
	public class ISetReviveRegionT
	{
		// Token: 0x1700D5E9 RID: 54761
		// (get) Token: 0x06032F54 RID: 208724 RVA: 0x006DFCF4 File Offset: 0x006DDEF4
		// (set) Token: 0x06032F55 RID: 208725 RVA: 0x006DFCFC File Offset: 0x006DDEFC
		public ESetReviveType SetReviveType { get; set; }

		// Token: 0x1700D5EA RID: 54762
		// (get) Token: 0x06032F56 RID: 208726 RVA: 0x006DFD05 File Offset: 0x006DDF05
		// (set) Token: 0x06032F57 RID: 208727 RVA: 0x006DFD0D File Offset: 0x006DDF0D
		public int ReviveId { get; set; }

		// Token: 0x06032F58 RID: 208728 RVA: 0x006DFD16 File Offset: 0x006DDF16
		public ISetReviveRegionT()
		{
			this.SetReviveType = ESetReviveType.Add;
			this.ReviveId = 0;
		}
	}
}
