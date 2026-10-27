using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003BA RID: 954
	[NullableContext(1)]
	[Nullable(0)]
	public class IFoxJumpingPoint : IHookInteractType
	{
		// Token: 0x06001305 RID: 4869 RVA: 0x0003E188 File Offset: 0x0003C388
		private IFoxJumpingPoint_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFoxJumpingPoint 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFoxJumpingPoint_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFoxJumpingPoint_SetValue());
			}
			return result;
		}

		// Token: 0x06001306 RID: 4870 RVA: 0x0003E1C0 File Offset: 0x0003C3C0
		public static IFoxJumpingPoint Create([Nullable(2)] IFoxJumpingPoint instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFoxJumpingPoint
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001307 RID: 4871 RVA: 0x0003E1D3 File Offset: 0x0003C3D3
		public static IFoxJumpingPoint CreateFromSetValue([Nullable(2)] IFoxJumpingPoint_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFoxJumpingPoint
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001308 RID: 4872 RVA: 0x0003E1E8 File Offset: 0x0003C3E8
		public new IFoxJumpingPoint_SetValue ToSetValue()
		{
			return new IFoxJumpingPoint_SetValue
			{
				Type = this.Type,
				HookActions = this.HookActions,
				ExitHookActions = this.ExitHookActions,
				FinishActions = this.FinishActions,
				ClientHookActionConfig = this.ClientHookActionConfig
			};
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06001309 RID: 4873 RVA: 0x0003E236 File Offset: 0x0003C436
		// (set) Token: 0x0600130A RID: 4874 RVA: 0x0003E261 File Offset: 0x0003C461
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

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x0600130B RID: 4875 RVA: 0x0003E270 File Offset: 0x0003C470
		// (set) Token: 0x0600130C RID: 4876 RVA: 0x0003E303 File Offset: 0x0003C503
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
					IFoxJumpingPoint_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x0600130D RID: 4877 RVA: 0x0003E318 File Offset: 0x0003C518
		// (set) Token: 0x0600130E RID: 4878 RVA: 0x0003E3AB File Offset: 0x0003C5AB
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
					IFoxJumpingPoint_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x0600130F RID: 4879 RVA: 0x0003E3C0 File Offset: 0x0003C5C0
		// (set) Token: 0x06001310 RID: 4880 RVA: 0x0003E453 File Offset: 0x0003C653
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
					IFoxJumpingPoint_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06001311 RID: 4881 RVA: 0x0003E468 File Offset: 0x0003C668
		// (set) Token: 0x06001312 RID: 4882 RVA: 0x0003E4C9 File Offset: 0x0003C6C9
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
					IFoxJumpingPoint_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04000F2E RID: 3886
		[Nullable(2)]
		protected new IFoxJumpingPoint FbInstance;

		// Token: 0x04000F2F RID: 3887
		[Nullable(2)]
		protected new IFoxJumpingPoint_SetValue PocoInterface;

		// Token: 0x04000F30 RID: 3888
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _HookActionsCache;

		// Token: 0x04000F31 RID: 3889
		private bool _HookActionsInited;

		// Token: 0x04000F32 RID: 3890
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ExitHookActionsCache;

		// Token: 0x04000F33 RID: 3891
		private bool _ExitHookActionsInited;

		// Token: 0x04000F34 RID: 3892
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _FinishActionsCache;

		// Token: 0x04000F35 RID: 3893
		private bool _FinishActionsInited;

		// Token: 0x04000F36 RID: 3894
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x04000F37 RID: 3895
		private bool _ClientHookActionConfigInited;
	}
}
