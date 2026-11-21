using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002E18 RID: 11800
	public class ILiveLoadDanmakuConfig : ILiveDanmakuOperation
	{
		// Token: 0x06010053 RID: 65619 RVA: 0x0024E204 File Offset: 0x0024C404
		public static ILiveLoadDanmakuConfig Create(ILiveLoadDanmakuConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiveLoadDanmakuConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170050D1 RID: 20689
		// (get) Token: 0x06010054 RID: 65620 RVA: 0x0024E223 File Offset: 0x0024C423
		public override ELiveDanmakuOperationType Type
		{
			get
			{
				return (ELiveDanmakuOperationType)this.Instance.Type;
			}
		}

		// Token: 0x170050D2 RID: 20690
		// (get) Token: 0x06010055 RID: 65621 RVA: 0x0024E230 File Offset: 0x0024C430
		public virtual List<ILiveDanmakuPool> DanmakuPools
		{
			get
			{
				if (this._DanmakuPoolsInited)
				{
					return this._DanmakuPoolsCache;
				}
				this._DanmakuPoolsInited = true;
				int danmakuPoolsLength = this.Instance.DanmakuPoolsLength;
				this._DanmakuPoolsCache = new List<ILiveDanmakuPool>(danmakuPoolsLength);
				for (int i = 0; i < danmakuPoolsLength; i++)
				{
					this._DanmakuPoolsCache.Add(ILiveDanmakuPool.Create(this.Instance.DanmakuPools(i)));
				}
				return this._DanmakuPoolsCache;
			}
		}

		// Token: 0x170050D3 RID: 20691
		// (get) Token: 0x06010056 RID: 65622 RVA: 0x0024E29C File Offset: 0x0024C49C
		public virtual float? SendInterval
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.SendInterval);
			}
		}

		// Token: 0x170050D4 RID: 20692
		// (get) Token: 0x06010057 RID: 65623 RVA: 0x0024E2D4 File Offset: 0x0024C4D4
		public virtual int? TrackCount
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new int?(this.Instance.TrackCount);
			}
		}

		// Token: 0x170050D5 RID: 20693
		// (get) Token: 0x06010058 RID: 65624 RVA: 0x0024E30A File Offset: 0x0024C50A
		public virtual ELiveDanmakuLinkType LinkType
		{
			get
			{
				return (ELiveDanmakuLinkType)this.Instance.LinkType;
			}
		}

		// Token: 0x04008BDE RID: 35806
		private ILiveLoadDanmakuConfig Instance;

		// Token: 0x04008BDF RID: 35807
		private List<ILiveDanmakuPool> _DanmakuPoolsCache;

		// Token: 0x04008BE0 RID: 35808
		private bool _DanmakuPoolsInited;
	}
}
