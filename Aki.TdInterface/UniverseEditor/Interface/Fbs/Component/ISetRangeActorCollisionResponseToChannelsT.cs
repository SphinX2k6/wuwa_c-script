using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F11 RID: 24337
	public class ISetRangeActorCollisionResponseToChannelsT
	{
		// Token: 0x1700B401 RID: 46081
		// (get) Token: 0x06028D91 RID: 167313 RVA: 0x005950EC File Offset: 0x005932EC
		// (set) Token: 0x06028D92 RID: 167314 RVA: 0x005950F4 File Offset: 0x005932F4
		public ECollisionChannelType CollisionChannelType { get; set; }

		// Token: 0x1700B402 RID: 46082
		// (get) Token: 0x06028D93 RID: 167315 RVA: 0x005950FD File Offset: 0x005932FD
		// (set) Token: 0x06028D94 RID: 167316 RVA: 0x00595105 File Offset: 0x00593305
		public ECollisionResponseType CollisionResponseType { get; set; }

		// Token: 0x06028D95 RID: 167317 RVA: 0x0059510E File Offset: 0x0059330E
		public ISetRangeActorCollisionResponseToChannelsT()
		{
			this.CollisionChannelType = ECollisionChannelType.WorldStatic;
			this.CollisionResponseType = ECollisionResponseType.Ignore;
		}
	}
}
