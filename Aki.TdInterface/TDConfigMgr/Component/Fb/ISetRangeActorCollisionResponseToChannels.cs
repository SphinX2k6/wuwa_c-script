using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B97 RID: 2967
	public class ISetRangeActorCollisionResponseToChannels
	{
		// Token: 0x060043D9 RID: 17369 RVA: 0x000AC2E7 File Offset: 0x000AA4E7
		public static ISetRangeActorCollisionResponseToChannels Create(ISetRangeActorCollisionResponseToChannels? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetRangeActorCollisionResponseToChannels
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170010A6 RID: 4262
		// (get) Token: 0x060043DA RID: 17370 RVA: 0x000AC306 File Offset: 0x000AA506
		public virtual ECollisionChannelType CollisionChannelType
		{
			get
			{
				return (ECollisionChannelType)this.Instance.CollisionChannelType;
			}
		}

		// Token: 0x170010A7 RID: 4263
		// (get) Token: 0x060043DB RID: 17371 RVA: 0x000AC313 File Offset: 0x000AA513
		public virtual ECollisionResponseType CollisionResponseType
		{
			get
			{
				return (ECollisionResponseType)this.Instance.CollisionResponseType;
			}
		}

		// Token: 0x0400258C RID: 9612
		private ISetRangeActorCollisionResponseToChannels Instance;
	}
}
