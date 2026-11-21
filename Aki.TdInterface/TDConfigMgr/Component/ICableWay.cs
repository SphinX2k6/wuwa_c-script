using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000238 RID: 568
	public class ICableWay : IHookInteractType
	{
		// Token: 0x0600094C RID: 2380 RVA: 0x00029288 File Offset: 0x00027488
		private ICableWay_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICableWay 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICableWay_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICableWay_SetValue());
			}
			return result;
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x000292C0 File Offset: 0x000274C0
		public static ICableWay Create([Nullable(2)] ICableWay instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICableWay
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x000292D3 File Offset: 0x000274D3
		public static ICableWay CreateFromSetValue([Nullable(2)] ICableWay_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICableWay
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x000292E8 File Offset: 0x000274E8
		public new ICableWay_SetValue ToSetValue()
		{
			return new ICableWay_SetValue
			{
				Type = this.Type,
				HookActions = this.HookActions,
				ExitHookActions = this.ExitHookActions,
				FinishActions = this.FinishActions,
				ClientHookActionConfig = this.ClientHookActionConfig,
				SplineEntityId = this.SplineEntityId
			};
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06000950 RID: 2384 RVA: 0x00029342 File Offset: 0x00027542
		// (set) Token: 0x06000951 RID: 2385 RVA: 0x0002936D File Offset: 0x0002756D
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

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06000952 RID: 2386 RVA: 0x0002937C File Offset: 0x0002757C
		// (set) Token: 0x06000953 RID: 2387 RVA: 0x0002940F File Offset: 0x0002760F
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public override List<Aki.TDConfigMgr.Action.ActionInfo> HookActions
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
					ICableWay_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06000954 RID: 2388 RVA: 0x00029424 File Offset: 0x00027624
		// (set) Token: 0x06000955 RID: 2389 RVA: 0x000294B7 File Offset: 0x000276B7
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public override List<Aki.TDConfigMgr.Action.ActionInfo> ExitHookActions
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
					ICableWay_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06000956 RID: 2390 RVA: 0x000294CC File Offset: 0x000276CC
		// (set) Token: 0x06000957 RID: 2391 RVA: 0x0002955F File Offset: 0x0002775F
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public override List<Aki.TDConfigMgr.Action.ActionInfo> FinishActions
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
					ICableWay_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06000958 RID: 2392 RVA: 0x00029574 File Offset: 0x00027774
		// (set) Token: 0x06000959 RID: 2393 RVA: 0x000295D5 File Offset: 0x000277D5
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
					ICableWay_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x0600095A RID: 2394 RVA: 0x000295EA File Offset: 0x000277EA
		// (set) Token: 0x0600095B RID: 2395 RVA: 0x00029615 File Offset: 0x00027815
		public virtual int SplineEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SplineEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.SplineEntityId;
			}
			set
			{
				this.GetOrCreatePoco().SplineEntityId = value;
			}
		}

		// Token: 0x040009EC RID: 2540
		[Nullable(2)]
		protected new ICableWay FbInstance;

		// Token: 0x040009ED RID: 2541
		[Nullable(2)]
		protected new ICableWay_SetValue PocoInterface;

		// Token: 0x040009EE RID: 2542
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _HookActionsCache;

		// Token: 0x040009EF RID: 2543
		private bool _HookActionsInited;

		// Token: 0x040009F0 RID: 2544
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ExitHookActionsCache;

		// Token: 0x040009F1 RID: 2545
		private bool _ExitHookActionsInited;

		// Token: 0x040009F2 RID: 2546
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _FinishActionsCache;

		// Token: 0x040009F3 RID: 2547
		private bool _FinishActionsInited;

		// Token: 0x040009F4 RID: 2548
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x040009F5 RID: 2549
		private bool _ClientHookActionConfigInited;
	}
}
