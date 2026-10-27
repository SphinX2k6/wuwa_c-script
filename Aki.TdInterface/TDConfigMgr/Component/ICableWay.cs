using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000211 RID: 529
	[NullableContext(1)]
	[Nullable(0)]
	public class ICableWay : IHookInteractType
	{
		// Token: 0x060008D8 RID: 2264 RVA: 0x00027AC8 File Offset: 0x00025CC8
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

		// Token: 0x060008D9 RID: 2265 RVA: 0x00027B00 File Offset: 0x00025D00
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

		// Token: 0x060008DA RID: 2266 RVA: 0x00027B13 File Offset: 0x00025D13
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

		// Token: 0x060008DB RID: 2267 RVA: 0x00027B28 File Offset: 0x00025D28
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

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x060008DC RID: 2268 RVA: 0x00027B82 File Offset: 0x00025D82
		// (set) Token: 0x060008DD RID: 2269 RVA: 0x00027BAD File Offset: 0x00025DAD
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

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x060008DE RID: 2270 RVA: 0x00027BBC File Offset: 0x00025DBC
		// (set) Token: 0x060008DF RID: 2271 RVA: 0x00027C4F File Offset: 0x00025E4F
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
					ICableWay_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x060008E0 RID: 2272 RVA: 0x00027C64 File Offset: 0x00025E64
		// (set) Token: 0x060008E1 RID: 2273 RVA: 0x00027CF7 File Offset: 0x00025EF7
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
					ICableWay_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x060008E2 RID: 2274 RVA: 0x00027D0C File Offset: 0x00025F0C
		// (set) Token: 0x060008E3 RID: 2275 RVA: 0x00027D9F File Offset: 0x00025F9F
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
					ICableWay_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x060008E4 RID: 2276 RVA: 0x00027DB4 File Offset: 0x00025FB4
		// (set) Token: 0x060008E5 RID: 2277 RVA: 0x00027E15 File Offset: 0x00026015
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

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x060008E6 RID: 2278 RVA: 0x00027E2A File Offset: 0x0002602A
		// (set) Token: 0x060008E7 RID: 2279 RVA: 0x00027E55 File Offset: 0x00026055
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

		// Token: 0x04000962 RID: 2402
		[Nullable(2)]
		protected new ICableWay FbInstance;

		// Token: 0x04000963 RID: 2403
		[Nullable(2)]
		protected new ICableWay_SetValue PocoInterface;

		// Token: 0x04000964 RID: 2404
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _HookActionsCache;

		// Token: 0x04000965 RID: 2405
		private bool _HookActionsInited;

		// Token: 0x04000966 RID: 2406
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ExitHookActionsCache;

		// Token: 0x04000967 RID: 2407
		private bool _ExitHookActionsInited;

		// Token: 0x04000968 RID: 2408
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _FinishActionsCache;

		// Token: 0x04000969 RID: 2409
		private bool _FinishActionsInited;

		// Token: 0x0400096A RID: 2410
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x0400096B RID: 2411
		private bool _ClientHookActionConfigInited;
	}
}
