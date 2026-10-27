using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001770 RID: 6000
	[NullableContext(1)]
	[Nullable(0)]
	public class IActorFxEmoteStopSockets : IActorFxEmoteStopSubType
	{
		// Token: 0x06007F0D RID: 32525 RVA: 0x0012FF50 File Offset: 0x0012E150
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

		// Token: 0x06007F0E RID: 32526 RVA: 0x0012FF88 File Offset: 0x0012E188
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

		// Token: 0x06007F0F RID: 32527 RVA: 0x0012FF9B File Offset: 0x0012E19B
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

		// Token: 0x06007F10 RID: 32528 RVA: 0x0012FFAE File Offset: 0x0012E1AE
		public new IActorFxEmoteStopSockets_SetValue ToSetValue()
		{
			return new IActorFxEmoteStopSockets_SetValue
			{
				Type = this.Type,
				Sockets = this.Sockets
			};
		}

		// Token: 0x170029B3 RID: 10675
		// (get) Token: 0x06007F11 RID: 32529 RVA: 0x0012FFCD File Offset: 0x0012E1CD
		// (set) Token: 0x06007F12 RID: 32530 RVA: 0x0012FFF8 File Offset: 0x0012E1F8
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

		// Token: 0x170029B4 RID: 10676
		// (get) Token: 0x06007F13 RID: 32531 RVA: 0x00130006 File Offset: 0x0012E206
		// (set) Token: 0x06007F14 RID: 32532 RVA: 0x0013002D File Offset: 0x0012E22D
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

		// Token: 0x040050D4 RID: 20692
		[Nullable(2)]
		protected new IActorFxEmoteStopSockets FbInstance;

		// Token: 0x040050D5 RID: 20693
		[Nullable(2)]
		protected new IActorFxEmoteStopSockets_SetValue PocoInterface;
	}
}
