using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A7A RID: 10874
	public class IToggleDragActorPlayType
	{
		// Token: 0x0600EFFE RID: 61438 RVA: 0x00232BE2 File Offset: 0x00230DE2
		public static IToggleDragActorPlayType Create(IToggleDragActorPlayType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IToggleDragActorPlayType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170047B8 RID: 18360
		// (get) Token: 0x0600EFFF RID: 61439 RVA: 0x00232C01 File Offset: 0x00230E01
		public virtual EToggleDragActorPlayType Type
		{
			get
			{
				return (EToggleDragActorPlayType)this.Instance.Type;
			}
		}

		// Token: 0x040083FA RID: 33786
		private IToggleDragActorPlayType Instance;
	}
}
