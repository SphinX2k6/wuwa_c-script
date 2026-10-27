using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004AC RID: 1196
	[NullableContext(2)]
	[Nullable(0)]
	public class IKiteHook : IHookInteractType
	{
		// Token: 0x06001820 RID: 6176 RVA: 0x00048670 File Offset: 0x00046870
		[NullableContext(1)]
		private IKiteHook_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IKiteHook 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IKiteHook_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IKiteHook_SetValue());
			}
			return result;
		}

		// Token: 0x06001821 RID: 6177 RVA: 0x000486A8 File Offset: 0x000468A8
		[NullableContext(1)]
		public static IKiteHook Create([Nullable(2)] IKiteHook instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IKiteHook
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001822 RID: 6178 RVA: 0x000486BB File Offset: 0x000468BB
		[NullableContext(1)]
		public static IKiteHook CreateFromSetValue([Nullable(2)] IKiteHook_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IKiteHook
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001823 RID: 6179 RVA: 0x000486D0 File Offset: 0x000468D0
		[NullableContext(1)]
		public new IKiteHook_SetValue ToSetValue()
		{
			return new IKiteHook_SetValue
			{
				Type = this.Type,
				HookActions = this.HookActions,
				ExitHookActions = this.ExitHookActions,
				FinishActions = this.FinishActions,
				ClientHookActionConfig = this.ClientHookActionConfig,
				HookDataAssetOverride = this.HookDataAssetOverride,
				SupportSwitchHookMidway = this.SupportSwitchHookMidway
			};
		}

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x06001824 RID: 6180 RVA: 0x00048736 File Offset: 0x00046936
		// (set) Token: 0x06001825 RID: 6181 RVA: 0x00048761 File Offset: 0x00046961
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

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x06001826 RID: 6182 RVA: 0x00048770 File Offset: 0x00046970
		// (set) Token: 0x06001827 RID: 6183 RVA: 0x00048803 File Offset: 0x00046A03
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
					IKiteHook_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x06001828 RID: 6184 RVA: 0x00048818 File Offset: 0x00046A18
		// (set) Token: 0x06001829 RID: 6185 RVA: 0x000488AB File Offset: 0x00046AAB
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
					IKiteHook_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x0600182A RID: 6186 RVA: 0x000488C0 File Offset: 0x00046AC0
		// (set) Token: 0x0600182B RID: 6187 RVA: 0x00048953 File Offset: 0x00046B53
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
					IKiteHook_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x0600182C RID: 6188 RVA: 0x00048968 File Offset: 0x00046B68
		// (set) Token: 0x0600182D RID: 6189 RVA: 0x000489C9 File Offset: 0x00046BC9
		public override IClientHookActionConfig ClientHookActionConfig
		{
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
					IKiteHook_SetValue pocoInterface = this.PocoInterface;
					this._ClientHookActionConfigCache = ((pocoInterface != null) ? pocoInterface.ClientHookActionConfig : null);
				}
				return this._ClientHookActionConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().ClientHookActionConfig = value;
				this._ClientHookActionConfigInited = false;
			}
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x0600182E RID: 6190 RVA: 0x000489DE File Offset: 0x00046BDE
		// (set) Token: 0x0600182F RID: 6191 RVA: 0x00048A05 File Offset: 0x00046C05
		public virtual string HookDataAssetOverride
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HookDataAssetOverride;
				}
				IKiteHook_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.HookDataAssetOverride;
			}
			set
			{
				this.GetOrCreatePoco().HookDataAssetOverride = value;
			}
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x06001830 RID: 6192 RVA: 0x00048A14 File Offset: 0x00046C14
		// (set) Token: 0x06001831 RID: 6193 RVA: 0x00048A4E File Offset: 0x00046C4E
		public virtual bool? SupportSwitchHookMidway
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SupportSwitchHookMidway;
				}
				IKiteHook_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SupportSwitchHookMidway;
			}
			set
			{
				this.GetOrCreatePoco().SupportSwitchHookMidway = value;
			}
		}

		// Token: 0x040011EF RID: 4591
		protected new IKiteHook FbInstance;

		// Token: 0x040011F0 RID: 4592
		protected new IKiteHook_SetValue PocoInterface;

		// Token: 0x040011F1 RID: 4593
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _HookActionsCache;

		// Token: 0x040011F2 RID: 4594
		private bool _HookActionsInited;

		// Token: 0x040011F3 RID: 4595
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ExitHookActionsCache;

		// Token: 0x040011F4 RID: 4596
		private bool _ExitHookActionsInited;

		// Token: 0x040011F5 RID: 4597
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _FinishActionsCache;

		// Token: 0x040011F6 RID: 4598
		private bool _FinishActionsInited;

		// Token: 0x040011F7 RID: 4599
		[Nullable(1)]
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x040011F8 RID: 4600
		private bool _ClientHookActionConfigInited;
	}
}
