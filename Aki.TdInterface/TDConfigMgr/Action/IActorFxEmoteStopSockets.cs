using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018F1 RID: 6385
	public class IActorFxEmoteStopSockets : IActorFxEmoteStopSubType
	{
		// Token: 0x060085FD RID: 34301 RVA: 0x0013F1B0 File Offset: 0x0013D3B0
		private IActorFxEmoteStopSockets_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IActorFxEmoteStopSockets 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IActorFxEmoteStopSockets_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IActorFxEmoteStopSockets_SetValue());
			}
			return result;
		}

		// Token: 0x060085FE RID: 34302 RVA: 0x0013F1E8 File Offset: 0x0013D3E8
		public static IActorFxEmoteStopSockets Create([Nullable(2)] IActorFxEmoteStopSockets instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorFxEmoteStopSockets
			{
				FbInstance = instance
			};
		}

		// Token: 0x060085FF RID: 34303 RVA: 0x0013F1FB File Offset: 0x0013D3FB
		public static IActorFxEmoteStopSockets CreateFromSetValue([Nullable(2)] IActorFxEmoteStopSockets_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IActorFxEmoteStopSockets
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008600 RID: 34304 RVA: 0x0013F20E File Offset: 0x0013D40E
		public new IActorFxEmoteStopSockets_SetValue ToSetValue()
		{
			return new IActorFxEmoteStopSockets_SetValue
			{
				Type = this.Type,
				Sockets = this.Sockets
			};
		}

		// Token: 0x17002BA1 RID: 11169
		// (get) Token: 0x06008601 RID: 34305 RVA: 0x0013F22D File Offset: 0x0013D42D
		// (set) Token: 0x06008602 RID: 34306 RVA: 0x0013F258 File Offset: 0x0013D458
		public override EActorFxEmoteStopSubType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EActorFxEmoteStopSubType.StopAll;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002BA2 RID: 11170
		// (get) Token: 0x06008603 RID: 34307 RVA: 0x0013F266 File Offset: 0x0013D466
		// (set) Token: 0x06008604 RID: 34308 RVA: 0x0013F28D File Offset: 0x0013D48D
		public virtual List<string> Sockets
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Sockets;
				}
				IActorFxEmoteStopSockets_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Sockets;
			}
			set
			{
				this.GetOrCreatePoco().Sockets = value;
			}
		}

		// Token: 0x0400550A RID: 21770
		[Nullable(2)]
		protected new IActorFxEmoteStopSockets FbInstance;

		// Token: 0x0400550B RID: 21771
		[Nullable(2)]
		protected new IActorFxEmoteStopSockets_SetValue PocoInterface;
	}
}
