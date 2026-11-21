using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000589 RID: 1417
	[NullableContext(2)]
	[Nullable(0)]
	public class IMotorEjectHook : IHookInteractType
	{
		// Token: 0x06001C98 RID: 7320 RVA: 0x000522AC File Offset: 0x000504AC
		[NullableContext(0)]
		private IMotorEjectHook_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMotorEjectHook 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMotorEjectHook_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMotorEjectHook_SetValue());
			}
			return result;
		}

		// Token: 0x06001C99 RID: 7321 RVA: 0x000522E4 File Offset: 0x000504E4
		[NullableContext(0)]
		public static IMotorEjectHook Create([Nullable(2)] IMotorEjectHook instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMotorEjectHook
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001C9A RID: 7322 RVA: 0x000522F7 File Offset: 0x000504F7
		[NullableContext(0)]
		public static IMotorEjectHook CreateFromSetValue([Nullable(2)] IMotorEjectHook_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMotorEjectHook
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001C9B RID: 7323 RVA: 0x0005230C File Offset: 0x0005050C
		[NullableContext(0)]
		public new IMotorEjectHook_SetValue ToSetValue()
		{
			return new IMotorEjectHook_SetValue
			{
				Type = this.Type,
				HookActions = this.HookActions,
				ExitHookActions = this.ExitHookActions,
				FinishActions = this.FinishActions,
				ClientHookActionConfig = this.ClientHookActionConfig,
				MinPitchAngle = this.MinPitchAngle,
				DefaultPitchAngle = this.DefaultPitchAngle,
				MaxPitchAngle = this.MaxPitchAngle,
				MaxYawAngleDelta = this.MaxYawAngleDelta,
				MaxEjectDistance = this.MaxEjectDistance,
				InterpSpeed = this.InterpSpeed,
				AutoEjectConfig = this.AutoEjectConfig
			};
		}

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x06001C9C RID: 7324 RVA: 0x000523AE File Offset: 0x000505AE
		// (set) Token: 0x06001C9D RID: 7325 RVA: 0x000523D9 File Offset: 0x000505D9
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

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x06001C9E RID: 7326 RVA: 0x000523E8 File Offset: 0x000505E8
		// (set) Token: 0x06001C9F RID: 7327 RVA: 0x0005247B File Offset: 0x0005067B
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
					IMotorEjectHook_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x06001CA0 RID: 7328 RVA: 0x00052490 File Offset: 0x00050690
		// (set) Token: 0x06001CA1 RID: 7329 RVA: 0x00052523 File Offset: 0x00050723
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
					IMotorEjectHook_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x06001CA2 RID: 7330 RVA: 0x00052538 File Offset: 0x00050738
		// (set) Token: 0x06001CA3 RID: 7331 RVA: 0x000525CB File Offset: 0x000507CB
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
					IMotorEjectHook_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x06001CA4 RID: 7332 RVA: 0x000525E0 File Offset: 0x000507E0
		// (set) Token: 0x06001CA5 RID: 7333 RVA: 0x00052641 File Offset: 0x00050841
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
					IMotorEjectHook_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x06001CA6 RID: 7334 RVA: 0x00052656 File Offset: 0x00050856
		// (set) Token: 0x06001CA7 RID: 7335 RVA: 0x00052685 File Offset: 0x00050885
		public virtual float MinPitchAngle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MinPitchAngle;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.MinPitchAngle;
			}
			set
			{
				this.GetOrCreatePoco().MinPitchAngle = value;
			}
		}

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x06001CA8 RID: 7336 RVA: 0x00052693 File Offset: 0x00050893
		// (set) Token: 0x06001CA9 RID: 7337 RVA: 0x000526C2 File Offset: 0x000508C2
		public virtual float DefaultPitchAngle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DefaultPitchAngle;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.DefaultPitchAngle;
			}
			set
			{
				this.GetOrCreatePoco().DefaultPitchAngle = value;
			}
		}

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x06001CAA RID: 7338 RVA: 0x000526D0 File Offset: 0x000508D0
		// (set) Token: 0x06001CAB RID: 7339 RVA: 0x000526FF File Offset: 0x000508FF
		public virtual float MaxPitchAngle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaxPitchAngle;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.MaxPitchAngle;
			}
			set
			{
				this.GetOrCreatePoco().MaxPitchAngle = value;
			}
		}

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x06001CAC RID: 7340 RVA: 0x0005270D File Offset: 0x0005090D
		// (set) Token: 0x06001CAD RID: 7341 RVA: 0x0005273C File Offset: 0x0005093C
		public virtual float MaxYawAngleDelta
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaxYawAngleDelta;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.MaxYawAngleDelta;
			}
			set
			{
				this.GetOrCreatePoco().MaxYawAngleDelta = value;
			}
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x06001CAE RID: 7342 RVA: 0x0005274A File Offset: 0x0005094A
		// (set) Token: 0x06001CAF RID: 7343 RVA: 0x00052779 File Offset: 0x00050979
		public virtual float MaxEjectDistance
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaxEjectDistance;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.MaxEjectDistance;
			}
			set
			{
				this.GetOrCreatePoco().MaxEjectDistance = value;
			}
		}

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x06001CB0 RID: 7344 RVA: 0x00052787 File Offset: 0x00050987
		// (set) Token: 0x06001CB1 RID: 7345 RVA: 0x000527B6 File Offset: 0x000509B6
		public virtual float InterpSpeed
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.InterpSpeed;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.InterpSpeed;
			}
			set
			{
				this.GetOrCreatePoco().InterpSpeed = value;
			}
		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x06001CB2 RID: 7346 RVA: 0x000527C4 File Offset: 0x000509C4
		// (set) Token: 0x06001CB3 RID: 7347 RVA: 0x000527EB File Offset: 0x000509EB
		public virtual IMotorAutoEjectConfigBase AutoEjectConfig
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AutoEjectConfig;
				}
				IMotorEjectHook_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.AutoEjectConfig;
			}
			set
			{
				this.GetOrCreatePoco().AutoEjectConfig = value;
			}
		}

		// Token: 0x040014A2 RID: 5282
		protected new IMotorEjectHook FbInstance;

		// Token: 0x040014A3 RID: 5283
		protected new IMotorEjectHook_SetValue PocoInterface;

		// Token: 0x040014A4 RID: 5284
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _HookActionsCache;

		// Token: 0x040014A5 RID: 5285
		private bool _HookActionsInited;

		// Token: 0x040014A6 RID: 5286
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ExitHookActionsCache;

		// Token: 0x040014A7 RID: 5287
		private bool _ExitHookActionsInited;

		// Token: 0x040014A8 RID: 5288
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _FinishActionsCache;

		// Token: 0x040014A9 RID: 5289
		private bool _FinishActionsInited;

		// Token: 0x040014AA RID: 5290
		[Nullable(0)]
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x040014AB RID: 5291
		private bool _ClientHookActionConfigInited;
	}
}
