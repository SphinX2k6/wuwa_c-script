using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004EC RID: 1260
	[NullableContext(1)]
	[Nullable(0)]
	public class IMechHook : IHookInteractType
	{
		// Token: 0x06001996 RID: 6550 RVA: 0x0004B620 File Offset: 0x00049820
		private IMechHook_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMechHook 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMechHook_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMechHook_SetValue());
			}
			return result;
		}

		// Token: 0x06001997 RID: 6551 RVA: 0x0004B658 File Offset: 0x00049858
		public static IMechHook Create([Nullable(2)] IMechHook instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechHook
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001998 RID: 6552 RVA: 0x0004B66B File Offset: 0x0004986B
		public static IMechHook CreateFromSetValue([Nullable(2)] IMechHook_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMechHook
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001999 RID: 6553 RVA: 0x0004B680 File Offset: 0x00049880
		public new IMechHook_SetValue ToSetValue()
		{
			return new IMechHook_SetValue
			{
				Type = this.Type,
				HookActions = this.HookActions,
				ExitHookActions = this.ExitHookActions,
				FinishActions = this.FinishActions,
				ClientHookActionConfig = this.ClientHookActionConfig,
				HookConfig = this.HookConfig
			};
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x0600199A RID: 6554 RVA: 0x0004B6DA File Offset: 0x000498DA
		// (set) Token: 0x0600199B RID: 6555 RVA: 0x0004B705 File Offset: 0x00049905
		public override EHookInteractType Type
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

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x0600199C RID: 6556 RVA: 0x0004B714 File Offset: 0x00049914
		// (set) Token: 0x0600199D RID: 6557 RVA: 0x0004B7A7 File Offset: 0x000499A7
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public override List<Aki.TDConfigMgr.Action.ActionInfo> HookActions
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
					IMechHook_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x0600199E RID: 6558 RVA: 0x0004B7BC File Offset: 0x000499BC
		// (set) Token: 0x0600199F RID: 6559 RVA: 0x0004B84F File Offset: 0x00049A4F
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public override List<Aki.TDConfigMgr.Action.ActionInfo> ExitHookActions
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
					IMechHook_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x060019A0 RID: 6560 RVA: 0x0004B864 File Offset: 0x00049A64
		// (set) Token: 0x060019A1 RID: 6561 RVA: 0x0004B8F7 File Offset: 0x00049AF7
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public override List<Aki.TDConfigMgr.Action.ActionInfo> FinishActions
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
					IMechHook_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x060019A2 RID: 6562 RVA: 0x0004B90C File Offset: 0x00049B0C
		// (set) Token: 0x060019A3 RID: 6563 RVA: 0x0004B96D File Offset: 0x00049B6D
		[Nullable(2)]
		public override IClientHookActionConfig ClientHookActionConfig
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
					IMechHook_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x060019A4 RID: 6564 RVA: 0x0004B982 File Offset: 0x00049B82
		// (set) Token: 0x060019A5 RID: 6565 RVA: 0x0004B9A9 File Offset: 0x00049BA9
		public virtual IMechHookConfigType HookConfig
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HookConfig;
				}
				IMechHook_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.HookConfig;
			}
			set
			{
				this.GetOrCreatePoco().HookConfig = value;
			}
		}

		// Token: 0x040012B8 RID: 4792
		[Nullable(2)]
		protected new IMechHook FbInstance;

		// Token: 0x040012B9 RID: 4793
		[Nullable(2)]
		protected new IMechHook_SetValue PocoInterface;

		// Token: 0x040012BA RID: 4794
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _HookActionsCache;

		// Token: 0x040012BB RID: 4795
		private bool _HookActionsInited;

		// Token: 0x040012BC RID: 4796
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ExitHookActionsCache;

		// Token: 0x040012BD RID: 4797
		private bool _ExitHookActionsInited;

		// Token: 0x040012BE RID: 4798
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _FinishActionsCache;

		// Token: 0x040012BF RID: 4799
		private bool _FinishActionsInited;

		// Token: 0x040012C0 RID: 4800
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x040012C1 RID: 4801
		private bool _ClientHookActionConfigInited;
	}
}
