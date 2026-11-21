using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000629 RID: 1577
	public class IPartHitConfig
	{
		// Token: 0x06002130 RID: 8496 RVA: 0x0005CA4C File Offset: 0x0005AC4C
		private IPartHitConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPartHitConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPartHitConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPartHitConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06002131 RID: 8497 RVA: 0x0005CA84 File Offset: 0x0005AC84
		public static IPartHitConfig Create([Nullable(2)] IPartHitConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPartHitConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002132 RID: 8498 RVA: 0x0005CA97 File Offset: 0x0005AC97
		public static IPartHitConfig CreateFromSetValue([Nullable(2)] IPartHitConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPartHitConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002133 RID: 8499 RVA: 0x0005CAAA File Offset: 0x0005ACAA
		public IPartHitConfig_SetValue ToSetValue()
		{
			return new IPartHitConfig_SetValue
			{
				PartName = this.PartName,
				HitBullets = this.HitBullets,
				Actions = this.Actions
			};
		}

		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x06002134 RID: 8500 RVA: 0x0005CAD5 File Offset: 0x0005ACD5
		// (set) Token: 0x06002135 RID: 8501 RVA: 0x0005CB00 File Offset: 0x0005AD00
		public virtual string PartName
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PartName;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.PartName;
			}
			set
			{
				this.GetOrCreatePoco().PartName = value;
			}
		}

		// Token: 0x170008DA RID: 2266
		// (get) Token: 0x06002136 RID: 8502 RVA: 0x0005CB0E File Offset: 0x0005AD0E
		// (set) Token: 0x06002137 RID: 8503 RVA: 0x0005CB35 File Offset: 0x0005AD35
		[Nullable(2)]
		public virtual IHitBulletType HitBullets
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HitBullets;
				}
				IPartHitConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.HitBullets;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().HitBullets = value;
			}
		}

		// Token: 0x170008DB RID: 2267
		// (get) Token: 0x06002138 RID: 8504 RVA: 0x0005CB44 File Offset: 0x0005AD44
		// (set) Token: 0x06002139 RID: 8505 RVA: 0x0005CBD7 File Offset: 0x0005ADD7
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> Actions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._ActionsInited)
				{
					return this._ActionsCache;
				}
				this._ActionsInited = true;
				if (this.FbInstance != null)
				{
					List<Aki.TDConfigMgr.Action.Fb.ActionInfo> actions = this.FbInstance.Actions;
					if (actions != null)
					{
						this._ActionsCache = new List<Aki.TDConfigMgr.Action.ActionInfo>(actions.Count);
						for (int i = 0; i < actions.Count; i++)
						{
							this._ActionsCache.Add(Aki.TDConfigMgr.Action.ActionInfo.Create(actions[i]));
						}
					}
				}
				else
				{
					IPartHitConfig_SetValue pocoInterface = this.PocoInterface;
					this._ActionsCache = ((pocoInterface != null) ? pocoInterface.Actions : null);
				}
				return this._ActionsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().Actions = value;
				this._ActionsInited = false;
			}
		}

		// Token: 0x04001786 RID: 6022
		[Nullable(2)]
		protected IPartHitConfig FbInstance;

		// Token: 0x04001787 RID: 6023
		[Nullable(2)]
		protected IPartHitConfig_SetValue PocoInterface;

		// Token: 0x04001788 RID: 6024
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ActionsCache;

		// Token: 0x04001789 RID: 6025
		private bool _ActionsInited;
	}
}
