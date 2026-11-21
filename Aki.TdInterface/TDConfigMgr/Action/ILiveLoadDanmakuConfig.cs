using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D65 RID: 7525
	public class ILiveLoadDanmakuConfig : ILiveDanmakuOperation
	{
		// Token: 0x06009FC9 RID: 40905 RVA: 0x0016EBE0 File Offset: 0x0016CDE0
		private ILiveLoadDanmakuConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILiveLoadDanmakuConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILiveLoadDanmakuConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILiveLoadDanmakuConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06009FCA RID: 40906 RVA: 0x0016EC18 File Offset: 0x0016CE18
		public static ILiveLoadDanmakuConfig Create([Nullable(2)] ILiveLoadDanmakuConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiveLoadDanmakuConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009FCB RID: 40907 RVA: 0x0016EC2B File Offset: 0x0016CE2B
		public static ILiveLoadDanmakuConfig CreateFromSetValue([Nullable(2)] ILiveLoadDanmakuConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILiveLoadDanmakuConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009FCC RID: 40908 RVA: 0x0016EC40 File Offset: 0x0016CE40
		public new ILiveLoadDanmakuConfig_SetValue ToSetValue()
		{
			return new ILiveLoadDanmakuConfig_SetValue
			{
				Type = this.Type,
				DanmakuPools = this.DanmakuPools,
				SendInterval = this.SendInterval,
				TrackCount = this.TrackCount,
				LinkType = this.LinkType
			};
		}

		// Token: 0x170031DB RID: 12763
		// (get) Token: 0x06009FCD RID: 40909 RVA: 0x0016EC8E File Offset: 0x0016CE8E
		// (set) Token: 0x06009FCE RID: 40910 RVA: 0x0016ECB9 File Offset: 0x0016CEB9
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

		// Token: 0x170031DC RID: 12764
		// (get) Token: 0x06009FCF RID: 40911 RVA: 0x0016ECC8 File Offset: 0x0016CEC8
		// (set) Token: 0x06009FD0 RID: 40912 RVA: 0x0016ED5B File Offset: 0x0016CF5B
		public virtual List<ILiveDanmakuPool> DanmakuPools
		{
			get
			{
				if (this._DanmakuPoolsInited)
				{
					return this._DanmakuPoolsCache;
				}
				this._DanmakuPoolsInited = true;
				if (this.FbInstance != null)
				{
					List<ILiveDanmakuPool> danmakuPools = this.FbInstance.DanmakuPools;
					if (danmakuPools != null)
					{
						this._DanmakuPoolsCache = new List<ILiveDanmakuPool>(danmakuPools.Count);
						for (int i = 0; i < danmakuPools.Count; i++)
						{
							this._DanmakuPoolsCache.Add(ILiveDanmakuPool.Create(danmakuPools[i]));
						}
					}
				}
				else
				{
					ILiveLoadDanmakuConfig_SetValue pocoInterface = this.PocoInterface;
					this._DanmakuPoolsCache = ((pocoInterface != null) ? pocoInterface.DanmakuPools : null);
				}
				return this._DanmakuPoolsCache;
			}
			set
			{
				this.GetOrCreatePoco().DanmakuPools = value;
				this._DanmakuPoolsInited = false;
			}
		}

		// Token: 0x170031DD RID: 12765
		// (get) Token: 0x06009FD1 RID: 40913 RVA: 0x0016ED70 File Offset: 0x0016CF70
		// (set) Token: 0x06009FD2 RID: 40914 RVA: 0x0016EDAA File Offset: 0x0016CFAA
		public virtual float? SendInterval
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SendInterval;
				}
				ILiveLoadDanmakuConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SendInterval;
			}
			set
			{
				this.GetOrCreatePoco().SendInterval = value;
			}
		}

		// Token: 0x170031DE RID: 12766
		// (get) Token: 0x06009FD3 RID: 40915 RVA: 0x0016EDB8 File Offset: 0x0016CFB8
		// (set) Token: 0x06009FD4 RID: 40916 RVA: 0x0016EDF2 File Offset: 0x0016CFF2
		public virtual int? TrackCount
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TrackCount;
				}
				ILiveLoadDanmakuConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TrackCount;
			}
			set
			{
				this.GetOrCreatePoco().TrackCount = value;
			}
		}

		// Token: 0x170031DF RID: 12767
		// (get) Token: 0x06009FD5 RID: 40917 RVA: 0x0016EE00 File Offset: 0x0016D000
		// (set) Token: 0x06009FD6 RID: 40918 RVA: 0x0016EE2B File Offset: 0x0016D02B
		public virtual ELiveDanmakuLinkType LinkType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LinkType;
				}
				if (this.PocoInterface == null)
				{
					return ELiveDanmakuLinkType.KeepCurrent;
				}
				return this.PocoInterface.LinkType;
			}
			set
			{
				this.GetOrCreatePoco().LinkType = value;
			}
		}

		// Token: 0x04006134 RID: 24884
		[Nullable(2)]
		protected new ILiveLoadDanmakuConfig FbInstance;

		// Token: 0x04006135 RID: 24885
		[Nullable(2)]
		protected new ILiveLoadDanmakuConfig_SetValue PocoInterface;

		// Token: 0x04006136 RID: 24886
		private List<ILiveDanmakuPool> _DanmakuPoolsCache;

		// Token: 0x04006137 RID: 24887
		private bool _DanmakuPoolsInited;
	}
}
