using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F8E RID: 24462
	public class ISplineComponentT
	{
		// Token: 0x1700B524 RID: 46372
		// (get) Token: 0x06029220 RID: 168480 RVA: 0x0059DF3D File Offset: 0x0059C13D
		// (set) Token: 0x06029221 RID: 168481 RVA: 0x0059DF45 File Offset: 0x0059C145
		public bool Disabled { get; set; }

		// Token: 0x1700B525 RID: 46373
		// (get) Token: 0x06029222 RID: 168482 RVA: 0x0059DF4E File Offset: 0x0059C14E
		// (set) Token: 0x06029223 RID: 168483 RVA: 0x0059DF56 File Offset: 0x0059C156
		public TSplineOptionUnion Option { get; set; }

		// Token: 0x1700B526 RID: 46374
		// (get) Token: 0x06029224 RID: 168484 RVA: 0x0059DF5F File Offset: 0x0059C15F
		// (set) Token: 0x06029225 RID: 168485 RVA: 0x0059DF67 File Offset: 0x0059C167
		public byte NullMask { get; set; }

		// Token: 0x06029226 RID: 168486 RVA: 0x0059DF70 File Offset: 0x0059C170
		public ISplineComponentT()
		{
			this.Disabled = false;
			this.Option = null;
			this.NullMask = 0;
		}
	}
}
