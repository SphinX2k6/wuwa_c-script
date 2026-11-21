using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005A1 RID: 1441
	public class IMovementPointHook : IHookInteractType
	{
		// Token: 0x06001D52 RID: 7506 RVA: 0x00053F64 File Offset: 0x00052164
		private IMovementPointHook_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMovementPointHook 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMovementPointHook_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMovementPointHook_SetValue());
			}
			return result;
		}

		// Token: 0x06001D53 RID: 7507 RVA: 0x00053F9C File Offset: 0x0005219C
		public static IMovementPointHook Create([Nullable(2)] IMovementPointHook instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMovementPointHook
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001D54 RID: 7508 RVA: 0x00053FAF File Offset: 0x000521AF
		public static IMovementPointHook CreateFromSetValue([Nullable(2)] IMovementPointHook_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMovementPointHook
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001D55 RID: 7509 RVA: 0x00053FC4 File Offset: 0x000521C4
		public new IMovementPointHook_SetValue ToSetValue()
		{
			return new IMovementPointHook_SetValue
			{
				Type = this.Type,
				HookActions = this.HookActions,
				ExitHookActions = this.ExitHookActions,
				FinishActions = this.FinishActions,
				ClientHookActionConfig = this.ClientHookActionConfig
			};
		}

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x06001D56 RID: 7510 RVA: 0x00054012 File Offset: 0x00052212
		// (set) Token: 0x06001D57 RID: 7511 RVA: 0x0005403D File Offset: 0x0005223D
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

		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x06001D58 RID: 7512 RVA: 0x0005404C File Offset: 0x0005224C
		// (set) Token: 0x06001D59 RID: 7513 RVA: 0x000540DF File Offset: 0x000522DF
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
					IMovementPointHook_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x06001D5A RID: 7514 RVA: 0x000540F4 File Offset: 0x000522F4
		// (set) Token: 0x06001D5B RID: 7515 RVA: 0x00054187 File Offset: 0x00052387
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
					IMovementPointHook_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x06001D5C RID: 7516 RVA: 0x0005419C File Offset: 0x0005239C
		// (set) Token: 0x06001D5D RID: 7517 RVA: 0x0005422F File Offset: 0x0005242F
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
					IMovementPointHook_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x06001D5E RID: 7518 RVA: 0x00054244 File Offset: 0x00052444
		// (set) Token: 0x06001D5F RID: 7519 RVA: 0x000542A5 File Offset: 0x000524A5
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
					IMovementPointHook_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x0400151B RID: 5403
		[Nullable(2)]
		protected new IMovementPointHook FbInstance;

		// Token: 0x0400151C RID: 5404
		[Nullable(2)]
		protected new IMovementPointHook_SetValue PocoInterface;

		// Token: 0x0400151D RID: 5405
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _HookActionsCache;

		// Token: 0x0400151E RID: 5406
		private bool _HookActionsInited;

		// Token: 0x0400151F RID: 5407
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ExitHookActionsCache;

		// Token: 0x04001520 RID: 5408
		private bool _ExitHookActionsInited;

		// Token: 0x04001521 RID: 5409
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _FinishActionsCache;

		// Token: 0x04001522 RID: 5410
		private bool _FinishActionsInited;

		// Token: 0x04001523 RID: 5411
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x04001524 RID: 5412
		private bool _ClientHookActionConfigInited;
	}
}
