using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200124E RID: 4686
	public class ISaveConfig
	{
		// Token: 0x060068ED RID: 26861 RVA: 0x000FAFA0 File Offset: 0x000F91A0
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

		// Token: 0x060068EE RID: 26862 RVA: 0x000FAFD8 File Offset: 0x000F91D8
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

		// Token: 0x060068EF RID: 26863 RVA: 0x000FAFEB File Offset: 0x000F91EB
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

		// Token: 0x060068F0 RID: 26864 RVA: 0x000FB000 File Offset: 0x000F9200
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

		// Token: 0x17002200 RID: 8704
		// (get) Token: 0x060068F1 RID: 26865 RVA: 0x000FB05C File Offset: 0x000F925C
		// (set) Token: 0x060068F2 RID: 26866 RVA: 0x000FB096 File Offset: 0x000F9296
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

		// Token: 0x17002201 RID: 8705
		// (get) Token: 0x060068F3 RID: 26867 RVA: 0x000FB0A4 File Offset: 0x000F92A4
		// (set) Token: 0x060068F4 RID: 26868 RVA: 0x000FB0DE File Offset: 0x000F92DE
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

		// Token: 0x17002202 RID: 8706
		// (get) Token: 0x060068F5 RID: 26869 RVA: 0x000FB0EC File Offset: 0x000F92EC
		// (set) Token: 0x060068F6 RID: 26870 RVA: 0x000FB126 File Offset: 0x000F9326
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

		// Token: 0x17002203 RID: 8707
		// (get) Token: 0x060068F7 RID: 26871 RVA: 0x000FB134 File Offset: 0x000F9334
		// (set) Token: 0x060068F8 RID: 26872 RVA: 0x000FB195 File Offset: 0x000F9395
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

		// Token: 0x17002204 RID: 8708
		// (get) Token: 0x060068F9 RID: 26873 RVA: 0x000FB1AC File Offset: 0x000F93AC
		// (set) Token: 0x060068FA RID: 26874 RVA: 0x000FB23F File Offset: 0x000F943F
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> EnterActions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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
				0
			})]
			set
			{
				this.GetOrCreatePoco().EnterActions = value;
				this._EnterActionsInited = false;
			}
		}

		// Token: 0x17002205 RID: 8709
		// (get) Token: 0x060068FB RID: 26875 RVA: 0x000FB254 File Offset: 0x000F9454
		// (set) Token: 0x060068FC RID: 26876 RVA: 0x000FB2E7 File Offset: 0x000F94E7
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IInitConditionActions> InitConditionActions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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
				0
			})]
			set
			{
				this.GetOrCreatePoco().InitConditionActions = value;
				this._InitConditionActionsInited = false;
			}
		}

		// Token: 0x04003EA0 RID: 16032
		[Nullable(2)]
		protected ISaveConfig FbInstance;

		// Token: 0x04003EA1 RID: 16033
		[Nullable(2)]
		protected ISaveConfig_SetValue PocoInterface;

		// Token: 0x04003EA2 RID: 16034
		private IPosRollbackConfig _PosRollbackCfgCache;

		// Token: 0x04003EA3 RID: 16035
		private bool _PosRollbackCfgInited;

		// Token: 0x04003EA4 RID: 16036
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _EnterActionsCache;

		// Token: 0x04003EA5 RID: 16037
		private bool _EnterActionsInited;

		// Token: 0x04003EA6 RID: 16038
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IInitConditionActions> _InitConditionActionsCache;

		// Token: 0x04003EA7 RID: 16039
		private bool _InitConditionActionsInited;
	}
}
