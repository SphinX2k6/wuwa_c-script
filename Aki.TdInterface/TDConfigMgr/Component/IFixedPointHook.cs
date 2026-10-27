using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000398 RID: 920
	[NullableContext(1)]
	[Nullable(0)]
	public class IFixedPointHook : IHookInteractType
	{
		// Token: 0x0600124D RID: 4685 RVA: 0x0003C854 File Offset: 0x0003AA54
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

		// Token: 0x0600124E RID: 4686 RVA: 0x0003C88C File Offset: 0x0003AA8C
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

		// Token: 0x0600124F RID: 4687 RVA: 0x0003C89F File Offset: 0x0003AA9F
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

		// Token: 0x06001250 RID: 4688 RVA: 0x0003C8B4 File Offset: 0x0003AAB4
		public new IFixedPointHook_SetValue ToSetValue()
		{
			return new IFixedPointHook_SetValue
			{
				Type = this.Type,
				HookActions = this.HookActions,
				ExitHookActions = this.ExitHookActions,
				FinishActions = this.FinishActions,
				ClientHookActionConfig = this.ClientHookActionConfig
			};
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06001251 RID: 4689 RVA: 0x0003C902 File Offset: 0x0003AB02
		// (set) Token: 0x06001252 RID: 4690 RVA: 0x0003C92D File Offset: 0x0003AB2D
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

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06001253 RID: 4691 RVA: 0x0003C93C File Offset: 0x0003AB3C
		// (set) Token: 0x06001254 RID: 4692 RVA: 0x0003C9CF File Offset: 0x0003ABCF
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
					IFixedPointHook_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06001255 RID: 4693 RVA: 0x0003C9E4 File Offset: 0x0003ABE4
		// (set) Token: 0x06001256 RID: 4694 RVA: 0x0003CA77 File Offset: 0x0003AC77
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
					IFixedPointHook_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06001257 RID: 4695 RVA: 0x0003CA8C File Offset: 0x0003AC8C
		// (set) Token: 0x06001258 RID: 4696 RVA: 0x0003CB1F File Offset: 0x0003AD1F
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
					IFixedPointHook_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06001259 RID: 4697 RVA: 0x0003CB34 File Offset: 0x0003AD34
		// (set) Token: 0x0600125A RID: 4698 RVA: 0x0003CB95 File Offset: 0x0003AD95
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

		// Token: 0x04000EC1 RID: 3777
		[Nullable(2)]
		protected new IFixedPointHook FbInstance;

		// Token: 0x04000EC2 RID: 3778
		[Nullable(2)]
		protected new IFixedPointHook_SetValue PocoInterface;

		// Token: 0x04000EC3 RID: 3779
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _HookActionsCache;

		// Token: 0x04000EC4 RID: 3780
		private bool _HookActionsInited;

		// Token: 0x04000EC5 RID: 3781
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ExitHookActionsCache;

		// Token: 0x04000EC6 RID: 3782
		private bool _ExitHookActionsInited;

		// Token: 0x04000EC7 RID: 3783
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _FinishActionsCache;

		// Token: 0x04000EC8 RID: 3784
		private bool _FinishActionsInited;

		// Token: 0x04000EC9 RID: 3785
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x04000ECA RID: 3786
		private bool _ClientHookActionConfigInited;
	}
}
