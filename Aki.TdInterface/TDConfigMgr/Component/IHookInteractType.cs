using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000495 RID: 1173
	public class IHookInteractType
	{
		// Token: 0x0600177D RID: 6013 RVA: 0x00047E3C File Offset: 0x0004603C
		private IHookInteractType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHookInteractType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHookInteractType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHookInteractType_SetValue());
			}
			return result;
		}

		// Token: 0x0600177E RID: 6014 RVA: 0x00047E74 File Offset: 0x00046074
		public static IHookInteractType Create([Nullable(2)] IHookInteractType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHookInteractType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600177F RID: 6015 RVA: 0x00047E87 File Offset: 0x00046087
		public static IHookInteractType CreateFromSetValue([Nullable(2)] IHookInteractType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHookInteractType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001780 RID: 6016 RVA: 0x00047E9C File Offset: 0x0004609C
		public IHookInteractType_SetValue ToSetValue()
		{
			return new IHookInteractType_SetValue
			{
				Type = this.Type,
				HookActions = this.HookActions,
				ExitHookActions = this.ExitHookActions,
				FinishActions = this.FinishActions,
				ClientHookActionConfig = this.ClientHookActionConfig
			};
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x06001781 RID: 6017 RVA: 0x00047EEA File Offset: 0x000460EA
		// (set) Token: 0x06001782 RID: 6018 RVA: 0x00047F15 File Offset: 0x00046115
		public virtual EHookInteractType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EHookInteractType.FixedPointHook;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x06001783 RID: 6019 RVA: 0x00047F24 File Offset: 0x00046124
		// (set) Token: 0x06001784 RID: 6020 RVA: 0x00047FB7 File Offset: 0x000461B7
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
					IHookInteractType_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x06001785 RID: 6021 RVA: 0x00047FCC File Offset: 0x000461CC
		// (set) Token: 0x06001786 RID: 6022 RVA: 0x0004805F File Offset: 0x0004625F
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
					IHookInteractType_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x06001787 RID: 6023 RVA: 0x00048074 File Offset: 0x00046274
		// (set) Token: 0x06001788 RID: 6024 RVA: 0x00048107 File Offset: 0x00046307
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
					IHookInteractType_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x06001789 RID: 6025 RVA: 0x0004811C File Offset: 0x0004631C
		// (set) Token: 0x0600178A RID: 6026 RVA: 0x0004817D File Offset: 0x0004637D
		[Nullable(2)]
		public virtual IClientHookActionConfig ClientHookActionConfig
		{
			[NullableContext(2)]
			get
			{
				if (this._ClientHookActionConfigInited)
				{
					return this._ClientHookActionConfigCache;
				}
				this._ClientHookActionConfigInited = true;
				if (this.FbInstance != null)
				{
					this._ClientHookActionConfigCache = IClientHookActionConfig.Create(this.FbInstance.ClientHookActionConfig);
				}
				else
				{
					IHookInteractType_SetValue pocoInterface = this.PocoInterface;
					this._ClientHookActionConfigCache = ((pocoInterface != null) ? pocoInterface.ClientHookActionConfig : null);
				}
				return this._ClientHookActionConfigCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().ClientHookActionConfig = value;
				this._ClientHookActionConfigInited = false;
			}
		}

		// Token: 0x040011F0 RID: 4592
		[Nullable(2)]
		protected IHookInteractType FbInstance;

		// Token: 0x040011F1 RID: 4593
		[Nullable(2)]
		protected IHookInteractType_SetValue PocoInterface;

		// Token: 0x040011F2 RID: 4594
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _HookActionsCache;

		// Token: 0x040011F3 RID: 4595
		private bool _HookActionsInited;

		// Token: 0x040011F4 RID: 4596
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ExitHookActionsCache;

		// Token: 0x040011F5 RID: 4597
		private bool _ExitHookActionsInited;

		// Token: 0x040011F6 RID: 4598
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _FinishActionsCache;

		// Token: 0x040011F7 RID: 4599
		private bool _FinishActionsInited;

		// Token: 0x040011F8 RID: 4600
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x040011F9 RID: 4601
		private bool _ClientHookActionConfigInited;
	}
}
