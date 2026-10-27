using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000ACD RID: 2765
	public class ISetRangeActorCollisionResponseToChannels
	{
		// Token: 0x06003FAF RID: 16303 RVA: 0x000A2CF3 File Offset: 0x000A0EF3
		[NullableContext(1)]
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

		// Token: 0x17000FD2 RID: 4050
		// (get) Token: 0x06003FB0 RID: 16304 RVA: 0x000A2D12 File Offset: 0x000A0F12
		public virtual ECollisionChannelType CollisionChannelType
		{
			get
			{
				return (ECollisionChannelType)this.Instance.CollisionChannelType;
			}
		}

		// Token: 0x17000FD3 RID: 4051
		// (get) Token: 0x06003FB1 RID: 16305 RVA: 0x000A2D1F File Offset: 0x000A0F1F
		public virtual ECollisionResponseType CollisionResponseType
		{
			get
			{
				return (ECollisionResponseType)this.Instance.CollisionResponseType;
			}
		}

		// Token: 0x04002370 RID: 9072
		private ISetRangeActorCollisionResponseToChannels Instance;
	}
}
