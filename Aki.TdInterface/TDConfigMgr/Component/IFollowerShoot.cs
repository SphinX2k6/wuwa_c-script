using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003F1 RID: 1009
	public class IFollowerShoot : IHookInteractType
	{
		// Token: 0x060013EF RID: 5103 RVA: 0x00040910 File Offset: 0x0003EB10
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

		// Token: 0x060013F0 RID: 5104 RVA: 0x00040948 File Offset: 0x0003EB48
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

		// Token: 0x060013F1 RID: 5105 RVA: 0x0004095B File Offset: 0x0003EB5B
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

		// Token: 0x060013F2 RID: 5106 RVA: 0x00040970 File Offset: 0x0003EB70
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

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x060013F3 RID: 5107 RVA: 0x000409BE File Offset: 0x0003EBBE
		// (set) Token: 0x060013F4 RID: 5108 RVA: 0x000409E9 File Offset: 0x0003EBE9
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

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x060013F5 RID: 5109 RVA: 0x000409F8 File Offset: 0x0003EBF8
		// (set) Token: 0x060013F6 RID: 5110 RVA: 0x00040A8B File Offset: 0x0003EC8B
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
					IFollowerShoot_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x060013F7 RID: 5111 RVA: 0x00040AA0 File Offset: 0x0003ECA0
		// (set) Token: 0x060013F8 RID: 5112 RVA: 0x00040B33 File Offset: 0x0003ED33
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
					IFollowerShoot_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x060013F9 RID: 5113 RVA: 0x00040B48 File Offset: 0x0003ED48
		// (set) Token: 0x060013FA RID: 5114 RVA: 0x00040BDB File Offset: 0x0003EDDB
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
					IFollowerShoot_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x060013FB RID: 5115 RVA: 0x00040BF0 File Offset: 0x0003EDF0
		// (set) Token: 0x060013FC RID: 5116 RVA: 0x00040C51 File Offset: 0x0003EE51
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

		// Token: 0x04000FF3 RID: 4083
		[Nullable(2)]
		protected new IFollowerShoot FbInstance;

		// Token: 0x04000FF4 RID: 4084
		[Nullable(2)]
		protected new IFollowerShoot_SetValue PocoInterface;

		// Token: 0x04000FF5 RID: 4085
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _HookActionsCache;

		// Token: 0x04000FF6 RID: 4086
		private bool _HookActionsInited;

		// Token: 0x04000FF7 RID: 4087
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ExitHookActionsCache;

		// Token: 0x04000FF8 RID: 4088
		private bool _ExitHookActionsInited;

		// Token: 0x04000FF9 RID: 4089
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _FinishActionsCache;

		// Token: 0x04000FFA RID: 4090
		private bool _FinishActionsInited;

		// Token: 0x04000FFB RID: 4091
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x04000FFC RID: 4092
		private bool _ClientHookActionConfigInited;
	}
}
