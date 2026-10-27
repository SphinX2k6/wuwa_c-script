using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Actor;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005773 RID: 22387
	public class IPortalRenderConfigT
	{
		// Token: 0x1700A6FA RID: 42746
		// (get) Token: 0x06025863 RID: 153699 RVA: 0x0052D4A4 File Offset: 0x0052B6A4
		// (set) Token: 0x06025864 RID: 153700 RVA: 0x0052D4AC File Offset: 0x0052B6AC
		public TPortalViewDistanceConfigUnion ViewDistance { get; set; }

		// Token: 0x1700A6FB RID: 42747
		// (get) Token: 0x06025865 RID: 153701 RVA: 0x0052D4B5 File Offset: 0x0052B6B5
		// (set) Token: 0x06025866 RID: 153702 RVA: 0x0052D4BD File Offset: 0x0052B6BD
		public List<IActorRefT> ForceRenderActors { get; set; }

		// Token: 0x1700A6FC RID: 42748
		// (get) Token: 0x06025867 RID: 153703 RVA: 0x0052D4C6 File Offset: 0x0052B6C6
		// (set) Token: 0x06025868 RID: 153704 RVA: 0x0052D4CE File Offset: 0x0052B6CE
		public List<IRenderFlagT> SetRenderFlags { get; set; }

		// Token: 0x1700A6FD RID: 42749
		// (get) Token: 0x06025869 RID: 153705 RVA: 0x0052D4D7 File Offset: 0x0052B6D7
		// (set) Token: 0x0602586A RID: 153706 RVA: 0x0052D4DF File Offset: 0x0052B6DF
		public byte NullMask { get; set; }

		// Token: 0x0602586B RID: 153707 RVA: 0x0052D4E8 File Offset: 0x0052B6E8
		public IPortalRenderConfigT()
		{
			this.ViewDistance = null;
			this.ForceRenderActors = null;
			this.SetRenderFlags = null;
			this.NullMask = 0;
		}
	}
}
