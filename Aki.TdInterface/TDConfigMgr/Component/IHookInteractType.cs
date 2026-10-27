using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200043C RID: 1084
	[NullableContext(1)]
	[Nullable(0)]
	public class IHookInteractType
	{
		// Token: 0x060015E3 RID: 5603 RVA: 0x000440F4 File Offset: 0x000422F4
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

		// Token: 0x060015E4 RID: 5604 RVA: 0x0004412C File Offset: 0x0004232C
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

		// Token: 0x060015E5 RID: 5605 RVA: 0x0004413F File Offset: 0x0004233F
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

		// Token: 0x060015E6 RID: 5606 RVA: 0x00044154 File Offset: 0x00042354
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

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x060015E7 RID: 5607 RVA: 0x000441A2 File Offset: 0x000423A2
		// (set) Token: 0x060015E8 RID: 5608 RVA: 0x000441CD File Offset: 0x000423CD
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

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x060015E9 RID: 5609 RVA: 0x000441DC File Offset: 0x000423DC
		// (set) Token: 0x060015EA RID: 5610 RVA: 0x0004426F File Offset: 0x0004246F
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
					IHookInteractType_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x060015EB RID: 5611 RVA: 0x00044284 File Offset: 0x00042484
		// (set) Token: 0x060015EC RID: 5612 RVA: 0x00044317 File Offset: 0x00042517
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
					IHookInteractType_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x060015ED RID: 5613 RVA: 0x0004432C File Offset: 0x0004252C
		// (set) Token: 0x060015EE RID: 5614 RVA: 0x000443BF File Offset: 0x000425BF
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
					IHookInteractType_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x060015EF RID: 5615 RVA: 0x000443D4 File Offset: 0x000425D4
		// (set) Token: 0x060015F0 RID: 5616 RVA: 0x00044435 File Offset: 0x00042635
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

		// Token: 0x040010CE RID: 4302
		[Nullable(2)]
		protected IHookInteractType FbInstance;

		// Token: 0x040010CF RID: 4303
		[Nullable(2)]
		protected IHookInteractType_SetValue PocoInterface;

		// Token: 0x040010D0 RID: 4304
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _HookActionsCache;

		// Token: 0x040010D1 RID: 4305
		private bool _HookActionsInited;

		// Token: 0x040010D2 RID: 4306
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ExitHookActionsCache;

		// Token: 0x040010D3 RID: 4307
		private bool _ExitHookActionsInited;

		// Token: 0x040010D4 RID: 4308
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _FinishActionsCache;

		// Token: 0x040010D5 RID: 4309
		private bool _FinishActionsInited;

		// Token: 0x040010D6 RID: 4310
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x040010D7 RID: 4311
		private bool _ClientHookActionConfigInited;
	}
}
