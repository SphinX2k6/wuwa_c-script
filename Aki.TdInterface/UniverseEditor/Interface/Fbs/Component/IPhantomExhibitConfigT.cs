using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200572B RID: 22315
	public class IPhantomExhibitConfigT
	{
		// Token: 0x1700A648 RID: 42568
		// (get) Token: 0x06025582 RID: 152962 RVA: 0x00527193 File Offset: 0x00525393
		// (set) Token: 0x06025583 RID: 152963 RVA: 0x0052719B File Offset: 0x0052539B
		public EExhibitItemType Type { get; set; }

		// Token: 0x1700A649 RID: 42569
		// (get) Token: 0x06025584 RID: 152964 RVA: 0x005271A4 File Offset: 0x005253A4
		// (set) Token: 0x06025585 RID: 152965 RVA: 0x005271AC File Offset: 0x005253AC
		public EPhantomExhibitSizeType PhantomSize { get; set; }

		// Token: 0x1700A64A RID: 42570
		// (get) Token: 0x06025586 RID: 152966 RVA: 0x005271B5 File Offset: 0x005253B5
		// (set) Token: 0x06025587 RID: 152967 RVA: 0x005271BD File Offset: 0x005253BD
		public IVectorInfoT Offset { get; set; }

		// Token: 0x1700A64B RID: 42571
		// (get) Token: 0x06025588 RID: 152968 RVA: 0x005271C6 File Offset: 0x005253C6
		// (set) Token: 0x06025589 RID: 152969 RVA: 0x005271CE File Offset: 0x005253CE
		public IExhibitEffectT ActiveEffect { get; set; }

		// Token: 0x0602558A RID: 152970 RVA: 0x005271D7 File Offset: 0x005253D7
		public IPhantomExhibitConfigT()
		{
			this.Type = EExhibitItemType.Phantom;
			this.PhantomSize = EPhantomExhibitSizeType.Small;
			this.Offset = null;
			this.ActiveEffect = null;
		}
	}
}
