using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003A8 RID: 936
	[NullableContext(1)]
	[Nullable(0)]
	public class IFollowerShoot : IHookInteractType
	{
		// Token: 0x060012A9 RID: 4777 RVA: 0x0003D5D8 File Offset: 0x0003B7D8
		private IFollowerShoot_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFollowerShoot 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFollowerShoot_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFollowerShoot_SetValue());
			}
			return result;
		}

		// Token: 0x060012AA RID: 4778 RVA: 0x0003D610 File Offset: 0x0003B810
		public static IFollowerShoot Create([Nullable(2)] IFollowerShoot instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFollowerShoot
			{
				FbInstance = instance
			};
		}

		// Token: 0x060012AB RID: 4779 RVA: 0x0003D623 File Offset: 0x0003B823
		public static IFollowerShoot CreateFromSetValue([Nullable(2)] IFollowerShoot_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFollowerShoot
			{
				PocoInterface = value
			};
		}

		// Token: 0x060012AC RID: 4780 RVA: 0x0003D638 File Offset: 0x0003B838
		public new IFollowerShoot_SetValue ToSetValue()
		{
			return new IFollowerShoot_SetValue
			{
				Type = this.Type,
				HookActions = this.HookActions,
				ExitHookActions = this.ExitHookActions,
				FinishActions = this.FinishActions,
				ClientHookActionConfig = this.ClientHookActionConfig
			};
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x060012AD RID: 4781 RVA: 0x0003D686 File Offset: 0x0003B886
		// (set) Token: 0x060012AE RID: 4782 RVA: 0x0003D6B1 File Offset: 0x0003B8B1
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

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x060012AF RID: 4783 RVA: 0x0003D6C0 File Offset: 0x0003B8C0
		// (set) Token: 0x060012B0 RID: 4784 RVA: 0x0003D753 File Offset: 0x0003B953
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
					IFollowerShoot_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x060012B1 RID: 4785 RVA: 0x0003D768 File Offset: 0x0003B968
		// (set) Token: 0x060012B2 RID: 4786 RVA: 0x0003D7FB File Offset: 0x0003B9FB
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
					IFollowerShoot_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x060012B3 RID: 4787 RVA: 0x0003D810 File Offset: 0x0003BA10
		// (set) Token: 0x060012B4 RID: 4788 RVA: 0x0003D8A3 File Offset: 0x0003BAA3
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
					IFollowerShoot_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x060012B5 RID: 4789 RVA: 0x0003D8B8 File Offset: 0x0003BAB8
		// (set) Token: 0x060012B6 RID: 4790 RVA: 0x0003D919 File Offset: 0x0003BB19
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
					IFollowerShoot_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04000EFB RID: 3835
		[Nullable(2)]
		protected new IFollowerShoot FbInstance;

		// Token: 0x04000EFC RID: 3836
		[Nullable(2)]
		protected new IFollowerShoot_SetValue PocoInterface;

		// Token: 0x04000EFD RID: 3837
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _HookActionsCache;

		// Token: 0x04000EFE RID: 3838
		private bool _HookActionsInited;

		// Token: 0x04000EFF RID: 3839
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ExitHookActionsCache;

		// Token: 0x04000F00 RID: 3840
		private bool _ExitHookActionsInited;

		// Token: 0x04000F01 RID: 3841
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _FinishActionsCache;

		// Token: 0x04000F02 RID: 3842
		private bool _FinishActionsInited;

		// Token: 0x04000F03 RID: 3843
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x04000F04 RID: 3844
		private bool _ClientHookActionConfigInited;
	}
}
