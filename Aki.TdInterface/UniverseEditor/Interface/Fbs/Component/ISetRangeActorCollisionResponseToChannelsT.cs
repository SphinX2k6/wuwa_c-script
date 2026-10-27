using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005904 RID: 22788
	public class ISetRangeActorCollisionResponseToChannelsT
	{
		// Token: 0x1700AACD RID: 43725
		// (get) Token: 0x06026827 RID: 157735 RVA: 0x0054E480 File Offset: 0x0054C680
		// (set) Token: 0x06026828 RID: 157736 RVA: 0x0054E488 File Offset: 0x0054C688
		public ECollisionChannelType CollisionChannelType { get; set; }

		// Token: 0x1700AACE RID: 43726
		// (get) Token: 0x06026829 RID: 157737 RVA: 0x0054E491 File Offset: 0x0054C691
		// (set) Token: 0x0602682A RID: 157738 RVA: 0x0054E499 File Offset: 0x0054C699
		public ECollisionResponseType CollisionResponseType { get; set; }

		// Token: 0x0602682B RID: 157739 RVA: 0x0054E4A2 File Offset: 0x0054C6A2
		public ISetRangeActorCollisionResponseToChannelsT()
		{
			this.CollisionChannelType = ECollisionChannelType.WorldStatic;
			this.CollisionResponseType = ECollisionResponseType.Ignore;
		}
	}
}
