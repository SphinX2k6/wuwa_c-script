using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027D8 RID: 10200
	public class IActorFxEmoteStopSockets : IActorFxEmoteStopSubType
	{
		// Token: 0x0600E19A RID: 57754 RVA: 0x00212675 File Offset: 0x00210875
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

		// Token: 0x17003E98 RID: 16024
		// (get) Token: 0x0600E19B RID: 57755 RVA: 0x00212694 File Offset: 0x00210894
		public override EActorFxEmoteStopSubType Type
		{
			get
			{
				return (EActorFxEmoteStopSubType)this.Instance.Type;
			}
		}

		// Token: 0x17003E99 RID: 16025
		// (get) Token: 0x0600E19C RID: 57756 RVA: 0x002126A4 File Offset: 0x002108A4
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

		// Token: 0x04007A98 RID: 31384
		private IActorFxEmoteStopSockets Instance;

		// Token: 0x04007A99 RID: 31385
		private List<string> _SocketsCache;

		// Token: 0x04007A9A RID: 31386
		private bool _SocketsInited;
	}
}
