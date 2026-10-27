using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000420 RID: 1056
	[NullableContext(1)]
	[Nullable(0)]
	public class IHitLogicChangeByPartHit : IHitLogicType
	{
		// Token: 0x0600154F RID: 5455 RVA: 0x00042F58 File Offset: 0x00041158
		private IHitLogicChangeByPartHit_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHitLogicChangeByPartHit 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHitLogicChangeByPartHit_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHitLogicChangeByPartHit_SetValue());
			}
			return result;
		}

		// Token: 0x06001550 RID: 5456 RVA: 0x00042F90 File Offset: 0x00041190
		public static IHitLogicChangeByPartHit Create([Nullable(2)] IHitLogicChangeByPartHit instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHitLogicChangeByPartHit
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001551 RID: 5457 RVA: 0x00042FA3 File Offset: 0x000411A3
		public static IHitLogicChangeByPartHit CreateFromSetValue([Nullable(2)] IHitLogicChangeByPartHit_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHitLogicChangeByPartHit
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001552 RID: 5458 RVA: 0x00042FB6 File Offset: 0x000411B6
		public new IHitLogicChangeByPartHit_SetValue ToSetValue()
		{
			return new IHitLogicChangeByPartHit_SetValue
			{
				Type = this.Type,
				PartHitConfig = this.PartHitConfig
			};
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x06001553 RID: 5459 RVA: 0x00042FD5 File Offset: 0x000411D5
		// (set) Token: 0x06001554 RID: 5460 RVA: 0x00043000 File Offset: 0x00041200
		public override EHitLogicType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EHitLogicType.ChangeNextState;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x06001555 RID: 5461 RVA: 0x00043010 File Offset: 0x00041210
		// (set) Token: 0x06001556 RID: 5462 RVA: 0x000430A3 File Offset: 0x000412A3
		public virtual List<IPartHitConfig> PartHitConfig
		{
			get
			{
				if (this._PartHitConfigInited)
				{
					return this._PartHitConfigCache;
				}
				this._PartHitConfigInited = true;
				if (this.FbInstance != null)
				{
					List<IPartHitConfig> partHitConfig = this.FbInstance.PartHitConfig;
					if (partHitConfig != null)
					{
						this._PartHitConfigCache = new List<IPartHitConfig>(partHitConfig.Count);
						for (int i = 0; i < partHitConfig.Count; i++)
						{
							this._PartHitConfigCache.Add(IPartHitConfig.Create(partHitConfig[i]));
						}
					}
				}
				else
				{
					IHitLogicChangeByPartHit_SetValue pocoInterface = this.PocoInterface;
					this._PartHitConfigCache = ((pocoInterface != null) ? pocoInterface.PartHitConfig : null);
				}
				return this._PartHitConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().PartHitConfig = value;
				this._PartHitConfigInited = false;
			}
		}

		// Token: 0x04001084 RID: 4228
		[Nullable(2)]
		protected new IHitLogicChangeByPartHit FbInstance;

		// Token: 0x04001085 RID: 4229
		[Nullable(2)]
		protected new IHitLogicChangeByPartHit_SetValue PocoInterface;

		// Token: 0x04001086 RID: 4230
		private List<IPartHitConfig> _PartHitConfigCache;

		// Token: 0x04001087 RID: 4231
		private bool _PartHitConfigInited;
	}
}
