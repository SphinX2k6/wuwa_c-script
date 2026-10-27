using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005BE RID: 1470
	[NullableContext(1)]
	[Nullable(0)]
	public class IPartHitConfig
	{
		// Token: 0x06001F20 RID: 7968 RVA: 0x00057A20 File Offset: 0x00055C20
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

		// Token: 0x06001F21 RID: 7969 RVA: 0x00057A58 File Offset: 0x00055C58
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

		// Token: 0x06001F22 RID: 7970 RVA: 0x00057A6B File Offset: 0x00055C6B
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

		// Token: 0x06001F23 RID: 7971 RVA: 0x00057A7E File Offset: 0x00055C7E
		public IPartHitConfig_SetValue ToSetValue()
		{
			return new IPartHitConfig_SetValue
			{
				PartName = this.PartName,
				HitBullets = this.HitBullets,
				Actions = this.Actions
			};
		}

		// Token: 0x17000852 RID: 2130
		// (get) Token: 0x06001F24 RID: 7972 RVA: 0x00057AA9 File Offset: 0x00055CA9
		// (set) Token: 0x06001F25 RID: 7973 RVA: 0x00057AD4 File Offset: 0x00055CD4
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

		// Token: 0x17000853 RID: 2131
		// (get) Token: 0x06001F26 RID: 7974 RVA: 0x00057AE2 File Offset: 0x00055CE2
		// (set) Token: 0x06001F27 RID: 7975 RVA: 0x00057B09 File Offset: 0x00055D09
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

		// Token: 0x17000854 RID: 2132
		// (get) Token: 0x06001F28 RID: 7976 RVA: 0x00057B18 File Offset: 0x00055D18
		// (set) Token: 0x06001F29 RID: 7977 RVA: 0x00057BAB File Offset: 0x00055DAB
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> Actions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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
				1
			})]
			set
			{
				this.GetOrCreatePoco().Actions = value;
				this._ActionsInited = false;
			}
		}

		// Token: 0x04001612 RID: 5650
		[Nullable(2)]
		protected IPartHitConfig FbInstance;

		// Token: 0x04001613 RID: 5651
		[Nullable(2)]
		protected IPartHitConfig_SetValue PocoInterface;

		// Token: 0x04001614 RID: 5652
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ActionsCache;

		// Token: 0x04001615 RID: 5653
		private bool _ActionsInited;
	}
}
