using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000286 RID: 646
	public class IClientHookActionConfig
	{
		// Token: 0x06000B7E RID: 2942 RVA: 0x0002E2D0 File Offset: 0x0002C4D0
		private IClientHookActionConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IClientHookActionConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IClientHookActionConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IClientHookActionConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06000B7F RID: 2943 RVA: 0x0002E308 File Offset: 0x0002C508
		public static IClientHookActionConfig Create([Nullable(2)] IClientHookActionConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientHookActionConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x0002E31B File Offset: 0x0002C51B
		public static IClientHookActionConfig CreateFromSetValue([Nullable(2)] IClientHookActionConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IClientHookActionConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000B81 RID: 2945 RVA: 0x0002E32E File Offset: 0x0002C52E
		public IClientHookActionConfig_SetValue ToSetValue()
		{
			return new IClientHookActionConfig_SetValue
			{
				HookActions = this.HookActions,
				ExitHookActions = this.ExitHookActions,
				FinishActions = this.FinishActions
			};
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06000B82 RID: 2946 RVA: 0x0002E35C File Offset: 0x0002C55C
		// (set) Token: 0x06000B83 RID: 2947 RVA: 0x0002E3EF File Offset: 0x0002C5EF
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> HookActions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._HookActionsInited)
				{
					return this._HookActionsCache;
				}
				this._HookActionsInited = true;
				if (this.FbInstance != null)
				{
					List<Aki.TDConfigMgr.Action.Fb.ActionInfo> hookActions = this.FbInstance.HookActions;
					if (hookActions != null)
					{
						this._HookActionsCache = new List<Aki.TDConfigMgr.Action.ActionInfo>(hookActions.Count);
						for (int i = 0; i < hookActions.Count; i++)
						{
							this._HookActionsCache.Add(Aki.TDConfigMgr.Action.ActionInfo.Create(hookActions[i]));
						}
					}
				}
				else
				{
					IClientHookActionConfig_SetValue pocoInterface = this.PocoInterface;
					this._HookActionsCache = ((pocoInterface != null) ? pocoInterface.HookActions : null);
				}
				return this._HookActionsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().HookActions = value;
				this._HookActionsInited = false;
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06000B84 RID: 2948 RVA: 0x0002E404 File Offset: 0x0002C604
		// (set) Token: 0x06000B85 RID: 2949 RVA: 0x0002E497 File Offset: 0x0002C697
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> ExitHookActions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._ExitHookActionsInited)
				{
					return this._ExitHookActionsCache;
				}
				this._ExitHookActionsInited = true;
				if (this.FbInstance != null)
				{
					List<Aki.TDConfigMgr.Action.Fb.ActionInfo> exitHookActions = this.FbInstance.ExitHookActions;
					if (exitHookActions != null)
					{
						this._ExitHookActionsCache = new List<Aki.TDConfigMgr.Action.ActionInfo>(exitHookActions.Count);
						for (int i = 0; i < exitHookActions.Count; i++)
						{
							this._ExitHookActionsCache.Add(Aki.TDConfigMgr.Action.ActionInfo.Create(exitHookActions[i]));
						}
					}
				}
				else
				{
					IClientHookActionConfig_SetValue pocoInterface = this.PocoInterface;
					this._ExitHookActionsCache = ((pocoInterface != null) ? pocoInterface.ExitHookActions : null);
				}
				return this._ExitHookActionsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().ExitHookActions = value;
				this._ExitHookActionsInited = false;
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06000B86 RID: 2950 RVA: 0x0002E4AC File Offset: 0x0002C6AC
		// (set) Token: 0x06000B87 RID: 2951 RVA: 0x0002E53F File Offset: 0x0002C73F
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> FinishActions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._FinishActionsInited)
				{
					return this._FinishActionsCache;
				}
				this._FinishActionsInited = true;
				if (this.FbInstance != null)
				{
					List<Aki.TDConfigMgr.Action.Fb.ActionInfo> finishActions = this.FbInstance.FinishActions;
					if (finishActions != null)
					{
						this._FinishActionsCache = new List<Aki.TDConfigMgr.Action.ActionInfo>(finishActions.Count);
						for (int i = 0; i < finishActions.Count; i++)
						{
							this._FinishActionsCache.Add(Aki.TDConfigMgr.Action.ActionInfo.Create(finishActions[i]));
						}
					}
				}
				else
				{
					IClientHookActionConfig_SetValue pocoInterface = this.PocoInterface;
					this._FinishActionsCache = ((pocoInterface != null) ? pocoInterface.FinishActions : null);
				}
				return this._FinishActionsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().FinishActions = value;
				this._FinishActionsInited = false;
			}
		}

		// Token: 0x04000B44 RID: 2884
		[Nullable(2)]
		protected IClientHookActionConfig FbInstance;

		// Token: 0x04000B45 RID: 2885
		[Nullable(2)]
		protected IClientHookActionConfig_SetValue PocoInterface;

		// Token: 0x04000B46 RID: 2886
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _HookActionsCache;

		// Token: 0x04000B47 RID: 2887
		private bool _HookActionsInited;

		// Token: 0x04000B48 RID: 2888
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ExitHookActionsCache;

		// Token: 0x04000B49 RID: 2889
		private bool _ExitHookActionsInited;

		// Token: 0x04000B4A RID: 2890
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _FinishActionsCache;

		// Token: 0x04000B4B RID: 2891
		private bool _FinishActionsInited;
	}
}
