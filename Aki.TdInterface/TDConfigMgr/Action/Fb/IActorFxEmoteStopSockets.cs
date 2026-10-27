using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002531 RID: 9521
	[NullableContext(1)]
	[Nullable(0)]
	public class IActorFxEmoteStopSockets : IActorFxEmoteStopSubType
	{
		// Token: 0x0600D43A RID: 54330 RVA: 0x001F6C15 File Offset: 0x001F4E15
		public static IActorFxEmoteStopSockets Create(IActorFxEmoteStopSockets? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorFxEmoteStopSockets
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003B9A RID: 15258
		// (get) Token: 0x0600D43B RID: 54331 RVA: 0x001F6C34 File Offset: 0x001F4E34
		public override EActorFxEmoteStopSubType Type
		{
			get
			{
				return (EActorFxEmoteStopSubType)this.Instance.Type;
			}
		}

		// Token: 0x17003B9B RID: 15259
		// (get) Token: 0x0600D43C RID: 54332 RVA: 0x001F6C44 File Offset: 0x001F4E44
		public virtual List<string> Sockets
		{
			get
			{
				if (this._SocketsInited)
				{
					return this._SocketsCache;
				}
				this._SocketsInited = true;
				int socketsLength = this.Instance.SocketsLength;
				this._SocketsCache = new List<string>(socketsLength);
				for (int i = 0; i < socketsLength; i++)
				{
					this._SocketsCache.Add(this.Instance.Sockets(i));
				}
				return this._SocketsCache;
			}
		}

		// Token: 0x04007443 RID: 29763
		private IActorFxEmoteStopSockets Instance;

		// Token: 0x04007444 RID: 29764
		private List<string> _SocketsCache;

		// Token: 0x04007445 RID: 29765
		private bool _SocketsInited;
	}
}
