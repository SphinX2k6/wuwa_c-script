using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000737 RID: 1847
	[NullableContext(1)]
	[Nullable(0)]
	public class ISuiGuangHook : IHookInteractType
	{
		// Token: 0x060027D7 RID: 10199 RVA: 0x00069BC0 File Offset: 0x00067DC0
		private ISuiGuangHook_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISuiGuangHook 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISuiGuangHook_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISuiGuangHook_SetValue());
			}
			return result;
		}

		// Token: 0x060027D8 RID: 10200 RVA: 0x00069BF8 File Offset: 0x00067DF8
		public static ISuiGuangHook Create([Nullable(2)] ISuiGuangHook instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISuiGuangHook
			{
				FbInstance = instance
			};
		}

		// Token: 0x060027D9 RID: 10201 RVA: 0x00069C0B File Offset: 0x00067E0B
		public static ISuiGuangHook CreateFromSetValue([Nullable(2)] ISuiGuangHook_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISuiGuangHook
			{
				PocoInterface = value
			};
		}

		// Token: 0x060027DA RID: 10202 RVA: 0x00069C20 File Offset: 0x00067E20
		public new ISuiGuangHook_SetValue ToSetValue()
		{
			return new ISuiGuangHook_SetValue
			{
				Type = this.Type,
				HookActions = this.HookActions,
				ExitHookActions = this.ExitHookActions,
				FinishActions = this.FinishActions,
				ClientHookActionConfig = this.ClientHookActionConfig
			};
		}

		// Token: 0x17000A79 RID: 2681
		// (get) Token: 0x060027DB RID: 10203 RVA: 0x00069C6E File Offset: 0x00067E6E
		// (set) Token: 0x060027DC RID: 10204 RVA: 0x00069C99 File Offset: 0x00067E99
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

		// Token: 0x17000A7A RID: 2682
		// (get) Token: 0x060027DD RID: 10205 RVA: 0x00069CA8 File Offset: 0x00067EA8
		// (set) Token: 0x060027DE RID: 10206 RVA: 0x00069D3B File Offset: 0x00067F3B
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
					ISuiGuangHook_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000A7B RID: 2683
		// (get) Token: 0x060027DF RID: 10207 RVA: 0x00069D50 File Offset: 0x00067F50
		// (set) Token: 0x060027E0 RID: 10208 RVA: 0x00069DE3 File Offset: 0x00067FE3
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
					ISuiGuangHook_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000A7C RID: 2684
		// (get) Token: 0x060027E1 RID: 10209 RVA: 0x00069DF8 File Offset: 0x00067FF8
		// (set) Token: 0x060027E2 RID: 10210 RVA: 0x00069E8B File Offset: 0x0006808B
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
					ISuiGuangHook_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000A7D RID: 2685
		// (get) Token: 0x060027E3 RID: 10211 RVA: 0x00069EA0 File Offset: 0x000680A0
		// (set) Token: 0x060027E4 RID: 10212 RVA: 0x00069F01 File Offset: 0x00068101
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
					ISuiGuangHook_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04001AD3 RID: 6867
		[Nullable(2)]
		protected new ISuiGuangHook FbInstance;

		// Token: 0x04001AD4 RID: 6868
		[Nullable(2)]
		protected new ISuiGuangHook_SetValue PocoInterface;

		// Token: 0x04001AD5 RID: 6869
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _HookActionsCache;

		// Token: 0x04001AD6 RID: 6870
		private bool _HookActionsInited;

		// Token: 0x04001AD7 RID: 6871
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ExitHookActionsCache;

		// Token: 0x04001AD8 RID: 6872
		private bool _ExitHookActionsInited;

		// Token: 0x04001AD9 RID: 6873
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _FinishActionsCache;

		// Token: 0x04001ADA RID: 6874
		private bool _FinishActionsInited;

		// Token: 0x04001ADB RID: 6875
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x04001ADC RID: 6876
		private bool _ClientHookActionConfigInited;
	}
}
