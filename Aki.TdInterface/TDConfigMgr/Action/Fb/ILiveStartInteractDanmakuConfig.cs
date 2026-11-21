using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002E1F RID: 11807
	public class ILiveStartInteractDanmakuConfig : ILiveDanmakuOperation
	{
		// Token: 0x06010074 RID: 65652 RVA: 0x0024E4E1 File Offset: 0x0024C6E1
		public static ILiveStartInteractDanmakuConfig Create(ILiveStartInteractDanmakuConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiveStartInteractDanmakuConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170050E4 RID: 20708
		// (get) Token: 0x06010075 RID: 65653 RVA: 0x0024E500 File Offset: 0x0024C700
		public override ELiveDanmakuOperationType Type
		{
			get
			{
				return (ELiveDanmakuOperationType)this.Instance.Type;
			}
		}

		// Token: 0x170050E5 RID: 20709
		// (get) Token: 0x06010076 RID: 65654 RVA: 0x0024E510 File Offset: 0x0024C710
		public virtual List<ILiveInteractDanmakuListenerGroup> ListenerGroups
		{
			get
			{
				if (this._ListenerGroupsInited)
				{
					return this._ListenerGroupsCache;
				}
				this._ListenerGroupsInited = true;
				int listenerGroupsLength = this.Instance.ListenerGroupsLength;
				this._ListenerGroupsCache = new List<ILiveInteractDanmakuListenerGroup>(listenerGroupsLength);
				for (int i = 0; i < listenerGroupsLength; i++)
				{
					this._ListenerGroupsCache.Add(ILiveInteractDanmakuListenerGroup.Create(this.Instance.ListenerGroups(i)));
				}
				return this._ListenerGroupsCache;
			}
		}

		// Token: 0x04008BE9 RID: 35817
		private ILiveStartInteractDanmakuConfig Instance;

		// Token: 0x04008BEA RID: 35818
		private List<ILiveInteractDanmakuListenerGroup> _ListenerGroupsCache;

		// Token: 0x04008BEB RID: 35819
		private bool _ListenerGroupsInited;
	}
}
