using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001120 RID: 4384
	[NullableContext(1)]
	[Nullable(0)]
	public class ISaveConfig
	{
		// Token: 0x060062F2 RID: 25330 RVA: 0x000EDE2C File Offset: 0x000EC02C
		private ISaveConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISaveConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISaveConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISaveConfig_SetValue());
			}
			return result;
		}

		// Token: 0x060062F3 RID: 25331 RVA: 0x000EDE64 File Offset: 0x000EC064
		public static ISaveConfig Create([Nullable(2)] ISaveConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISaveConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x060062F4 RID: 25332 RVA: 0x000EDE77 File Offset: 0x000EC077
		public static ISaveConfig CreateFromSetValue([Nullable(2)] ISaveConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISaveConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x060062F5 RID: 25333 RVA: 0x000EDE8C File Offset: 0x000EC08C
		public ISaveConfig_SetValue ToSetValue()
		{
			return new ISaveConfig_SetValue
			{
				IsTemp = this.IsTemp,
				EnableRollbackWhileSwitchOnlineMode = this.EnableRollbackWhileSwitchOnlineMode,
				DisableRollbackWhileReconnect = this.DisableRollbackWhileReconnect,
				PosRollbackCfg = this.PosRollbackCfg,
				EnterActions = this.EnterActions,
				InitConditionActions = this.InitConditionActions
			};
		}

		// Token: 0x1700204D RID: 8269
		// (get) Token: 0x060062F6 RID: 25334 RVA: 0x000EDEE8 File Offset: 0x000EC0E8
		// (set) Token: 0x060062F7 RID: 25335 RVA: 0x000EDF22 File Offset: 0x000EC122
		public virtual bool? IsTemp
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsTemp;
				}
				ISaveConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsTemp;
			}
			set
			{
				this.GetOrCreatePoco().IsTemp = value;
			}
		}

		// Token: 0x1700204E RID: 8270
		// (get) Token: 0x060062F8 RID: 25336 RVA: 0x000EDF30 File Offset: 0x000EC130
		// (set) Token: 0x060062F9 RID: 25337 RVA: 0x000EDF6A File Offset: 0x000EC16A
		public virtual bool? EnableRollbackWhileSwitchOnlineMode
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EnableRollbackWhileSwitchOnlineMode;
				}
				ISaveConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EnableRollbackWhileSwitchOnlineMode;
			}
			set
			{
				this.GetOrCreatePoco().EnableRollbackWhileSwitchOnlineMode = value;
			}
		}

		// Token: 0x1700204F RID: 8271
		// (get) Token: 0x060062FA RID: 25338 RVA: 0x000EDF78 File Offset: 0x000EC178
		// (set) Token: 0x060062FB RID: 25339 RVA: 0x000EDFB2 File Offset: 0x000EC1B2
		public virtual bool? DisableRollbackWhileReconnect
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DisableRollbackWhileReconnect;
				}
				ISaveConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DisableRollbackWhileReconnect;
			}
			set
			{
				this.GetOrCreatePoco().DisableRollbackWhileReconnect = value;
			}
		}

		// Token: 0x17002050 RID: 8272
		// (get) Token: 0x060062FC RID: 25340 RVA: 0x000EDFC0 File Offset: 0x000EC1C0
		// (set) Token: 0x060062FD RID: 25341 RVA: 0x000EE021 File Offset: 0x000EC221
		[Nullable(2)]
		public virtual IPosRollbackConfig PosRollbackCfg
		{
			[NullableContext(2)]
			get
			{
				if (this._PosRollbackCfgInited)
				{
					return this._PosRollbackCfgCache;
				}
				this._PosRollbackCfgInited = true;
				if (this.FbInstance != null)
				{
					this._PosRollbackCfgCache = IPosRollbackConfig.Create(this.FbInstance.PosRollbackCfg);
				}
				else
				{
					ISaveConfig_SetValue pocoInterface = this.PocoInterface;
					this._PosRollbackCfgCache = ((pocoInterface != null) ? pocoInterface.PosRollbackCfg : null);
				}
				return this._PosRollbackCfgCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().PosRollbackCfg = value;
				this._PosRollbackCfgInited = false;
			}
		}

		// Token: 0x17002051 RID: 8273
		// (get) Token: 0x060062FE RID: 25342 RVA: 0x000EE038 File Offset: 0x000EC238
		// (set) Token: 0x060062FF RID: 25343 RVA: 0x000EE0CB File Offset: 0x000EC2CB
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> EnterActions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._EnterActionsInited)
				{
					return this._EnterActionsCache;
				}
				this._EnterActionsInited = true;
				if (this.FbInstance != null)
				{
					List<Aki.TDConfigMgr.Action.Fb.ActionInfo> enterActions = this.FbInstance.EnterActions;
					if (enterActions != null)
					{
						this._EnterActionsCache = new List<Aki.TDConfigMgr.Action.ActionInfo>(enterActions.Count);
						for (int i = 0; i < enterActions.Count; i++)
						{
							this._EnterActionsCache.Add(Aki.TDConfigMgr.Action.ActionInfo.Create(enterActions[i]));
						}
					}
				}
				else
				{
					ISaveConfig_SetValue pocoInterface = this.PocoInterface;
					this._EnterActionsCache = ((pocoInterface != null) ? pocoInterface.EnterActions : null);
				}
				return this._EnterActionsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.GetOrCreatePoco().EnterActions = value;
				this._EnterActionsInited = false;
			}
		}

		// Token: 0x17002052 RID: 8274
		// (get) Token: 0x06006300 RID: 25344 RVA: 0x000EE0E0 File Offset: 0x000EC2E0
		// (set) Token: 0x06006301 RID: 25345 RVA: 0x000EE173 File Offset: 0x000EC373
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IInitConditionActions> InitConditionActions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._InitConditionActionsInited)
				{
					return this._InitConditionActionsCache;
				}
				this._InitConditionActionsInited = true;
				if (this.FbInstance != null)
				{
					List<IInitConditionActions> initConditionActions = this.FbInstance.InitConditionActions;
					if (initConditionActions != null)
					{
						this._InitConditionActionsCache = new List<IInitConditionActions>(initConditionActions.Count);
						for (int i = 0; i < initConditionActions.Count; i++)
						{
							this._InitConditionActionsCache.Add(IInitConditionActions.Create(initConditionActions[i]));
						}
					}
				}
				else
				{
					ISaveConfig_SetValue pocoInterface = this.PocoInterface;
					this._InitConditionActionsCache = ((pocoInterface != null) ? pocoInterface.InitConditionActions : null);
				}
				return this._InitConditionActionsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.GetOrCreatePoco().InitConditionActions = value;
				this._InitConditionActionsInited = false;
			}
		}

		// Token: 0x04003B52 RID: 15186
		[Nullable(2)]
		protected ISaveConfig FbInstance;

		// Token: 0x04003B53 RID: 15187
		[Nullable(2)]
		protected ISaveConfig_SetValue PocoInterface;

		// Token: 0x04003B54 RID: 15188
		private IPosRollbackConfig _PosRollbackCfgCache;

		// Token: 0x04003B55 RID: 15189
		private bool _PosRollbackCfgInited;

		// Token: 0x04003B56 RID: 15190
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _EnterActionsCache;

		// Token: 0x04003B57 RID: 15191
		private bool _EnterActionsInited;

		// Token: 0x04003B58 RID: 15192
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IInitConditionActions> _InitConditionActionsCache;

		// Token: 0x04003B59 RID: 15193
		private bool _InitConditionActionsInited;
	}
}
