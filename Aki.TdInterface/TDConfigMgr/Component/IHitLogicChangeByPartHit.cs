using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000479 RID: 1145
	public class IHitLogicChangeByPartHit : IHitLogicType
	{
		// Token: 0x060016E9 RID: 5865 RVA: 0x00046CA0 File Offset: 0x00044EA0
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

		// Token: 0x060016EA RID: 5866 RVA: 0x00046CD8 File Offset: 0x00044ED8
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

		// Token: 0x060016EB RID: 5867 RVA: 0x00046CEB File Offset: 0x00044EEB
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

		// Token: 0x060016EC RID: 5868 RVA: 0x00046CFE File Offset: 0x00044EFE
		public new IHitLogicChangeByPartHit_SetValue ToSetValue()
		{
			return new IHitLogicChangeByPartHit_SetValue
			{
				Type = this.Type,
				PartHitConfig = this.PartHitConfig
			};
		}

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x060016ED RID: 5869 RVA: 0x00046D1D File Offset: 0x00044F1D
		// (set) Token: 0x060016EE RID: 5870 RVA: 0x00046D48 File Offset: 0x00044F48
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

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x060016EF RID: 5871 RVA: 0x00046D58 File Offset: 0x00044F58
		// (set) Token: 0x060016F0 RID: 5872 RVA: 0x00046DEB File Offset: 0x00044FEB
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

		// Token: 0x040011A6 RID: 4518
		[Nullable(2)]
		protected new IHitLogicChangeByPartHit FbInstance;

		// Token: 0x040011A7 RID: 4519
		[Nullable(2)]
		protected new IHitLogicChangeByPartHit_SetValue PocoInterface;

		// Token: 0x040011A8 RID: 4520
		private List<IPartHitConfig> _PartHitConfigCache;

		// Token: 0x040011A9 RID: 4521
		private bool _PartHitConfigInited;
	}
}
