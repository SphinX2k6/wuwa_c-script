using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000648 RID: 1608
	[NullableContext(1)]
	[Nullable(0)]
	public class IRagDollJumpingPoint : IHookInteractType
	{
		// Token: 0x06002262 RID: 8802 RVA: 0x0005E900 File Offset: 0x0005CB00
		private IRagDollJumpingPoint_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRagDollJumpingPoint 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRagDollJumpingPoint_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRagDollJumpingPoint_SetValue());
			}
			return result;
		}

		// Token: 0x06002263 RID: 8803 RVA: 0x0005E938 File Offset: 0x0005CB38
		public static IRagDollJumpingPoint Create([Nullable(2)] IRagDollJumpingPoint instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRagDollJumpingPoint
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002264 RID: 8804 RVA: 0x0005E94B File Offset: 0x0005CB4B
		public static IRagDollJumpingPoint CreateFromSetValue([Nullable(2)] IRagDollJumpingPoint_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRagDollJumpingPoint
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002265 RID: 8805 RVA: 0x0005E960 File Offset: 0x0005CB60
		public new IRagDollJumpingPoint_SetValue ToSetValue()
		{
			return new IRagDollJumpingPoint_SetValue
			{
				Type = this.Type,
				HookActions = this.HookActions,
				ExitHookActions = this.ExitHookActions,
				FinishActions = this.FinishActions,
				ClientHookActionConfig = this.ClientHookActionConfig
			};
		}

		// Token: 0x17000924 RID: 2340
		// (get) Token: 0x06002266 RID: 8806 RVA: 0x0005E9AE File Offset: 0x0005CBAE
		// (set) Token: 0x06002267 RID: 8807 RVA: 0x0005E9D9 File Offset: 0x0005CBD9
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

		// Token: 0x17000925 RID: 2341
		// (get) Token: 0x06002268 RID: 8808 RVA: 0x0005E9E8 File Offset: 0x0005CBE8
		// (set) Token: 0x06002269 RID: 8809 RVA: 0x0005EA7B File Offset: 0x0005CC7B
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
					IRagDollJumpingPoint_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x0600226A RID: 8810 RVA: 0x0005EA90 File Offset: 0x0005CC90
		// (set) Token: 0x0600226B RID: 8811 RVA: 0x0005EB23 File Offset: 0x0005CD23
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
					IRagDollJumpingPoint_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000927 RID: 2343
		// (get) Token: 0x0600226C RID: 8812 RVA: 0x0005EB38 File Offset: 0x0005CD38
		// (set) Token: 0x0600226D RID: 8813 RVA: 0x0005EBCB File Offset: 0x0005CDCB
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
					IRagDollJumpingPoint_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x0600226E RID: 8814 RVA: 0x0005EBE0 File Offset: 0x0005CDE0
		// (set) Token: 0x0600226F RID: 8815 RVA: 0x0005EC41 File Offset: 0x0005CE41
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
					IRagDollJumpingPoint_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x040017E4 RID: 6116
		[Nullable(2)]
		protected new IRagDollJumpingPoint FbInstance;

		// Token: 0x040017E5 RID: 6117
		[Nullable(2)]
		protected new IRagDollJumpingPoint_SetValue PocoInterface;

		// Token: 0x040017E6 RID: 6118
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _HookActionsCache;

		// Token: 0x040017E7 RID: 6119
		private bool _HookActionsInited;

		// Token: 0x040017E8 RID: 6120
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ExitHookActionsCache;

		// Token: 0x040017E9 RID: 6121
		private bool _ExitHookActionsInited;

		// Token: 0x040017EA RID: 6122
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _FinishActionsCache;

		// Token: 0x040017EB RID: 6123
		private bool _FinishActionsInited;

		// Token: 0x040017EC RID: 6124
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x040017ED RID: 6125
		private bool _ClientHookActionConfigInited;
	}
}
