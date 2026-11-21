using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007D8 RID: 2008
	public class ISuiGuangHook : IHookInteractType
	{
		// Token: 0x06002AFB RID: 11003 RVA: 0x00070D68 File Offset: 0x0006EF68
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

		// Token: 0x06002AFC RID: 11004 RVA: 0x00070DA0 File Offset: 0x0006EFA0
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

		// Token: 0x06002AFD RID: 11005 RVA: 0x00070DB3 File Offset: 0x0006EFB3
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

		// Token: 0x06002AFE RID: 11006 RVA: 0x00070DC8 File Offset: 0x0006EFC8
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

		// Token: 0x17000B39 RID: 2873
		// (get) Token: 0x06002AFF RID: 11007 RVA: 0x00070E16 File Offset: 0x0006F016
		// (set) Token: 0x06002B00 RID: 11008 RVA: 0x00070E41 File Offset: 0x0006F041
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

		// Token: 0x17000B3A RID: 2874
		// (get) Token: 0x06002B01 RID: 11009 RVA: 0x00070E50 File Offset: 0x0006F050
		// (set) Token: 0x06002B02 RID: 11010 RVA: 0x00070EE3 File Offset: 0x0006F0E3
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
					ISuiGuangHook_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000B3B RID: 2875
		// (get) Token: 0x06002B03 RID: 11011 RVA: 0x00070EF8 File Offset: 0x0006F0F8
		// (set) Token: 0x06002B04 RID: 11012 RVA: 0x00070F8B File Offset: 0x0006F18B
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
					ISuiGuangHook_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000B3C RID: 2876
		// (get) Token: 0x06002B05 RID: 11013 RVA: 0x00070FA0 File Offset: 0x0006F1A0
		// (set) Token: 0x06002B06 RID: 11014 RVA: 0x00071033 File Offset: 0x0006F233
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
					ISuiGuangHook_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000B3D RID: 2877
		// (get) Token: 0x06002B07 RID: 11015 RVA: 0x00071048 File Offset: 0x0006F248
		// (set) Token: 0x06002B08 RID: 11016 RVA: 0x000710A9 File Offset: 0x0006F2A9
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

		// Token: 0x04001CD8 RID: 7384
		[Nullable(2)]
		protected new ISuiGuangHook FbInstance;

		// Token: 0x04001CD9 RID: 7385
		[Nullable(2)]
		protected new ISuiGuangHook_SetValue PocoInterface;

		// Token: 0x04001CDA RID: 7386
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _HookActionsCache;

		// Token: 0x04001CDB RID: 7387
		private bool _HookActionsInited;

		// Token: 0x04001CDC RID: 7388
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ExitHookActionsCache;

		// Token: 0x04001CDD RID: 7389
		private bool _ExitHookActionsInited;

		// Token: 0x04001CDE RID: 7390
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _FinishActionsCache;

		// Token: 0x04001CDF RID: 7391
		private bool _FinishActionsInited;

		// Token: 0x04001CE0 RID: 7392
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x04001CE1 RID: 7393
		private bool _ClientHookActionConfigInited;
	}
}
