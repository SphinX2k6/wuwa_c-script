using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003E1 RID: 993
	public class IFixedPointHook : IHookInteractType
	{
		// Token: 0x06001391 RID: 5009 RVA: 0x0003FB38 File Offset: 0x0003DD38
		private IFixedPointHook_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFixedPointHook 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFixedPointHook_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFixedPointHook_SetValue());
			}
			return result;
		}

		// Token: 0x06001392 RID: 5010 RVA: 0x0003FB70 File Offset: 0x0003DD70
		public static IFixedPointHook Create([Nullable(2)] IFixedPointHook instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFixedPointHook
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001393 RID: 5011 RVA: 0x0003FB83 File Offset: 0x0003DD83
		public static IFixedPointHook CreateFromSetValue([Nullable(2)] IFixedPointHook_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFixedPointHook
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001394 RID: 5012 RVA: 0x0003FB98 File Offset: 0x0003DD98
		public new IFixedPointHook_SetValue ToSetValue()
		{
			return new IFixedPointHook_SetValue
			{
				Type = this.Type,
				HookActions = this.HookActions,
				ExitHookActions = this.ExitHookActions,
				FinishActions = this.FinishActions,
				ClientHookActionConfig = this.ClientHookActionConfig,
				ExitDistance = this.ExitDistance
			};
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x06001395 RID: 5013 RVA: 0x0003FBF2 File Offset: 0x0003DDF2
		// (set) Token: 0x06001396 RID: 5014 RVA: 0x0003FC1D File Offset: 0x0003DE1D
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

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x06001397 RID: 5015 RVA: 0x0003FC2C File Offset: 0x0003DE2C
		// (set) Token: 0x06001398 RID: 5016 RVA: 0x0003FCBF File Offset: 0x0003DEBF
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
					IFixedPointHook_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x06001399 RID: 5017 RVA: 0x0003FCD4 File Offset: 0x0003DED4
		// (set) Token: 0x0600139A RID: 5018 RVA: 0x0003FD67 File Offset: 0x0003DF67
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
					IFixedPointHook_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x0600139B RID: 5019 RVA: 0x0003FD7C File Offset: 0x0003DF7C
		// (set) Token: 0x0600139C RID: 5020 RVA: 0x0003FE0F File Offset: 0x0003E00F
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
					IFixedPointHook_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x0600139D RID: 5021 RVA: 0x0003FE24 File Offset: 0x0003E024
		// (set) Token: 0x0600139E RID: 5022 RVA: 0x0003FE85 File Offset: 0x0003E085
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
					IFixedPointHook_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x0600139F RID: 5023 RVA: 0x0003FE9C File Offset: 0x0003E09C
		// (set) Token: 0x060013A0 RID: 5024 RVA: 0x0003FED6 File Offset: 0x0003E0D6
		public virtual float? ExitDistance
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ExitDistance;
				}
				IFixedPointHook_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ExitDistance;
			}
			set
			{
				this.GetOrCreatePoco().ExitDistance = value;
			}
		}

		// Token: 0x04000FB8 RID: 4024
		[Nullable(2)]
		protected new IFixedPointHook FbInstance;

		// Token: 0x04000FB9 RID: 4025
		[Nullable(2)]
		protected new IFixedPointHook_SetValue PocoInterface;

		// Token: 0x04000FBA RID: 4026
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _HookActionsCache;

		// Token: 0x04000FBB RID: 4027
		private bool _HookActionsInited;

		// Token: 0x04000FBC RID: 4028
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ExitHookActionsCache;

		// Token: 0x04000FBD RID: 4029
		private bool _ExitHookActionsInited;

		// Token: 0x04000FBE RID: 4030
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _FinishActionsCache;

		// Token: 0x04000FBF RID: 4031
		private bool _FinishActionsInited;

		// Token: 0x04000FC0 RID: 4032
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x04000FC1 RID: 4033
		private bool _ClientHookActionConfigInited;
	}
}
