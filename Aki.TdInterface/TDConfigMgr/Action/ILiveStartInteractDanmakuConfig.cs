using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D6F RID: 7535
	public class ILiveStartInteractDanmakuConfig : ILiveDanmakuOperation
	{
		// Token: 0x06009FFD RID: 40957 RVA: 0x0016F238 File Offset: 0x0016D438
		private ILiveStartInteractDanmakuConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILiveStartInteractDanmakuConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILiveStartInteractDanmakuConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILiveStartInteractDanmakuConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06009FFE RID: 40958 RVA: 0x0016F270 File Offset: 0x0016D470
		public static ILiveStartInteractDanmakuConfig Create([Nullable(2)] ILiveStartInteractDanmakuConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiveStartInteractDanmakuConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009FFF RID: 40959 RVA: 0x0016F283 File Offset: 0x0016D483
		public static ILiveStartInteractDanmakuConfig CreateFromSetValue([Nullable(2)] ILiveStartInteractDanmakuConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILiveStartInteractDanmakuConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A000 RID: 40960 RVA: 0x0016F296 File Offset: 0x0016D496
		public new ILiveStartInteractDanmakuConfig_SetValue ToSetValue()
		{
			return new ILiveStartInteractDanmakuConfig_SetValue
			{
				Type = this.Type,
				ListenerGroups = this.ListenerGroups
			};
		}

		// Token: 0x170031E6 RID: 12774
		// (get) Token: 0x0600A001 RID: 40961 RVA: 0x0016F2B5 File Offset: 0x0016D4B5
		// (set) Token: 0x0600A002 RID: 40962 RVA: 0x0016F2E0 File Offset: 0x0016D4E0
		public override ELiveDanmakuOperationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELiveDanmakuOperationType.Load;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170031E7 RID: 12775
		// (get) Token: 0x0600A003 RID: 40963 RVA: 0x0016F2F0 File Offset: 0x0016D4F0
		// (set) Token: 0x0600A004 RID: 40964 RVA: 0x0016F383 File Offset: 0x0016D583
		public virtual List<ILiveInteractDanmakuListenerGroup> ListenerGroups
		{
			get
			{
				if (this._ListenerGroupsInited)
				{
					return this._ListenerGroupsCache;
				}
				this._ListenerGroupsInited = true;
				if (this.FbInstance != null)
				{
					List<ILiveInteractDanmakuListenerGroup> listenerGroups = this.FbInstance.ListenerGroups;
					if (listenerGroups != null)
					{
						this._ListenerGroupsCache = new List<ILiveInteractDanmakuListenerGroup>(listenerGroups.Count);
						for (int i = 0; i < listenerGroups.Count; i++)
						{
							this._ListenerGroupsCache.Add(ILiveInteractDanmakuListenerGroup.Create(listenerGroups[i]));
						}
					}
				}
				else
				{
					ILiveStartInteractDanmakuConfig_SetValue pocoInterface = this.PocoInterface;
					this._ListenerGroupsCache = ((pocoInterface != null) ? pocoInterface.ListenerGroups : null);
				}
				return this._ListenerGroupsCache;
			}
			set
			{
				this.GetOrCreatePoco().ListenerGroups = value;
				this._ListenerGroupsInited = false;
			}
		}

		// Token: 0x0400614D RID: 24909
		[Nullable(2)]
		protected new ILiveStartInteractDanmakuConfig FbInstance;

		// Token: 0x0400614E RID: 24910
		[Nullable(2)]
		protected new ILiveStartInteractDanmakuConfig_SetValue PocoInterface;

		// Token: 0x0400614F RID: 24911
		private List<ILiveInteractDanmakuListenerGroup> _ListenerGroupsCache;

		// Token: 0x04006150 RID: 24912
		private bool _ListenerGroupsInited;
	}
}
