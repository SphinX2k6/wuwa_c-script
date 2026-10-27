using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000245 RID: 581
	[NullableContext(1)]
	[Nullable(0)]
	public class IClientHookActionConfig
	{
		// Token: 0x06000A70 RID: 2672 RVA: 0x0002B720 File Offset: 0x00029920
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

		// Token: 0x06000A71 RID: 2673 RVA: 0x0002B758 File Offset: 0x00029958
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

		// Token: 0x06000A72 RID: 2674 RVA: 0x0002B76B File Offset: 0x0002996B
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

		// Token: 0x06000A73 RID: 2675 RVA: 0x0002B77E File Offset: 0x0002997E
		public IClientHookActionConfig_SetValue ToSetValue()
		{
			return new IClientHookActionConfig_SetValue
			{
				HookActions = this.HookActions,
				ExitHookActions = this.ExitHookActions,
				FinishActions = this.FinishActions
			};
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06000A74 RID: 2676 RVA: 0x0002B7AC File Offset: 0x000299AC
		// (set) Token: 0x06000A75 RID: 2677 RVA: 0x0002B83F File Offset: 0x00029A3F
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> HookActions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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
				1
			})]
			set
			{
				this.GetOrCreatePoco().HookActions = value;
				this._HookActionsInited = false;
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000A76 RID: 2678 RVA: 0x0002B854 File Offset: 0x00029A54
		// (set) Token: 0x06000A77 RID: 2679 RVA: 0x0002B8E7 File Offset: 0x00029AE7
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> ExitHookActions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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
				1
			})]
			set
			{
				this.GetOrCreatePoco().ExitHookActions = value;
				this._ExitHookActionsInited = false;
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06000A78 RID: 2680 RVA: 0x0002B8FC File Offset: 0x00029AFC
		// (set) Token: 0x06000A79 RID: 2681 RVA: 0x0002B98F File Offset: 0x00029B8F
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> FinishActions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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
				1
			})]
			set
			{
				this.GetOrCreatePoco().FinishActions = value;
				this._FinishActionsInited = false;
			}
		}

		// Token: 0x04000A68 RID: 2664
		[Nullable(2)]
		protected IClientHookActionConfig FbInstance;

		// Token: 0x04000A69 RID: 2665
		[Nullable(2)]
		protected IClientHookActionConfig_SetValue PocoInterface;

		// Token: 0x04000A6A RID: 2666
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _HookActionsCache;

		// Token: 0x04000A6B RID: 2667
		private bool _HookActionsInited;

		// Token: 0x04000A6C RID: 2668
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ExitHookActionsCache;

		// Token: 0x04000A6D RID: 2669
		private bool _ExitHookActionsInited;

		// Token: 0x04000A6E RID: 2670
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _FinishActionsCache;

		// Token: 0x04000A6F RID: 2671
		private bool _FinishActionsInited;
	}
}
