using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000268 RID: 616
	public class IChongLouHook : IHookInteractType
	{
		// Token: 0x06000AC0 RID: 2752 RVA: 0x0002C9A8 File Offset: 0x0002ABA8
		private IChongLouHook_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IChongLouHook 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IChongLouHook_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IChongLouHook_SetValue());
			}
			return result;
		}

		// Token: 0x06000AC1 RID: 2753 RVA: 0x0002C9E0 File Offset: 0x0002ABE0
		public static IChongLouHook Create([Nullable(2)] IChongLouHook instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IChongLouHook
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000AC2 RID: 2754 RVA: 0x0002C9F3 File Offset: 0x0002ABF3
		public static IChongLouHook CreateFromSetValue([Nullable(2)] IChongLouHook_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IChongLouHook
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000AC3 RID: 2755 RVA: 0x0002CA08 File Offset: 0x0002AC08
		public new IChongLouHook_SetValue ToSetValue()
		{
			return new IChongLouHook_SetValue
			{
				Type = this.Type,
				HookActions = this.HookActions,
				ExitHookActions = this.ExitHookActions,
				FinishActions = this.FinishActions,
				ClientHookActionConfig = this.ClientHookActionConfig,
				HookMoveSpeed = this.HookMoveSpeed,
				Acceleration = this.Acceleration,
				LateralMoveSpeed = this.LateralMoveSpeed,
				LateralAccelerateTime = this.LateralAccelerateTime,
				LateralDecelerateTime = this.LateralDecelerateTime,
				MaxLateralOffset = this.MaxLateralOffset,
				VerticalMoveSpeed = this.VerticalMoveSpeed,
				VerticalAccelerateTime = this.VerticalAccelerateTime,
				VerticalDecelerateTime = this.VerticalDecelerateTime
			};
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06000AC4 RID: 2756 RVA: 0x0002CAC2 File Offset: 0x0002ACC2
		// (set) Token: 0x06000AC5 RID: 2757 RVA: 0x0002CAED File Offset: 0x0002ACED
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

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06000AC6 RID: 2758 RVA: 0x0002CAFC File Offset: 0x0002ACFC
		// (set) Token: 0x06000AC7 RID: 2759 RVA: 0x0002CB8F File Offset: 0x0002AD8F
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
					IChongLouHook_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06000AC8 RID: 2760 RVA: 0x0002CBA4 File Offset: 0x0002ADA4
		// (set) Token: 0x06000AC9 RID: 2761 RVA: 0x0002CC37 File Offset: 0x0002AE37
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
					IChongLouHook_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06000ACA RID: 2762 RVA: 0x0002CC4C File Offset: 0x0002AE4C
		// (set) Token: 0x06000ACB RID: 2763 RVA: 0x0002CCDF File Offset: 0x0002AEDF
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
					IChongLouHook_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06000ACC RID: 2764 RVA: 0x0002CCF4 File Offset: 0x0002AEF4
		// (set) Token: 0x06000ACD RID: 2765 RVA: 0x0002CD55 File Offset: 0x0002AF55
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
					IChongLouHook_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06000ACE RID: 2766 RVA: 0x0002CD6A File Offset: 0x0002AF6A
		// (set) Token: 0x06000ACF RID: 2767 RVA: 0x0002CD99 File Offset: 0x0002AF99
		public virtual float HookMoveSpeed
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HookMoveSpeed;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.HookMoveSpeed;
			}
			set
			{
				this.GetOrCreatePoco().HookMoveSpeed = value;
			}
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06000AD0 RID: 2768 RVA: 0x0002CDA7 File Offset: 0x0002AFA7
		// (set) Token: 0x06000AD1 RID: 2769 RVA: 0x0002CDD6 File Offset: 0x0002AFD6
		public virtual float Acceleration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Acceleration;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Acceleration;
			}
			set
			{
				this.GetOrCreatePoco().Acceleration = value;
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06000AD2 RID: 2770 RVA: 0x0002CDE4 File Offset: 0x0002AFE4
		// (set) Token: 0x06000AD3 RID: 2771 RVA: 0x0002CE1E File Offset: 0x0002B01E
		public virtual float? LateralMoveSpeed
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LateralMoveSpeed;
				}
				IChongLouHook_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.LateralMoveSpeed;
			}
			set
			{
				this.GetOrCreatePoco().LateralMoveSpeed = value;
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06000AD4 RID: 2772 RVA: 0x0002CE2C File Offset: 0x0002B02C
		// (set) Token: 0x06000AD5 RID: 2773 RVA: 0x0002CE66 File Offset: 0x0002B066
		public virtual float? LateralAccelerateTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LateralAccelerateTime;
				}
				IChongLouHook_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.LateralAccelerateTime;
			}
			set
			{
				this.GetOrCreatePoco().LateralAccelerateTime = value;
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06000AD6 RID: 2774 RVA: 0x0002CE74 File Offset: 0x0002B074
		// (set) Token: 0x06000AD7 RID: 2775 RVA: 0x0002CEAE File Offset: 0x0002B0AE
		public virtual float? LateralDecelerateTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LateralDecelerateTime;
				}
				IChongLouHook_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.LateralDecelerateTime;
			}
			set
			{
				this.GetOrCreatePoco().LateralDecelerateTime = value;
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06000AD8 RID: 2776 RVA: 0x0002CEBC File Offset: 0x0002B0BC
		// (set) Token: 0x06000AD9 RID: 2777 RVA: 0x0002CEF6 File Offset: 0x0002B0F6
		public virtual float? MaxLateralOffset
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaxLateralOffset;
				}
				IChongLouHook_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MaxLateralOffset;
			}
			set
			{
				this.GetOrCreatePoco().MaxLateralOffset = value;
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06000ADA RID: 2778 RVA: 0x0002CF04 File Offset: 0x0002B104
		// (set) Token: 0x06000ADB RID: 2779 RVA: 0x0002CF3E File Offset: 0x0002B13E
		public virtual float? VerticalMoveSpeed
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.VerticalMoveSpeed;
				}
				IChongLouHook_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.VerticalMoveSpeed;
			}
			set
			{
				this.GetOrCreatePoco().VerticalMoveSpeed = value;
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06000ADC RID: 2780 RVA: 0x0002CF4C File Offset: 0x0002B14C
		// (set) Token: 0x06000ADD RID: 2781 RVA: 0x0002CF86 File Offset: 0x0002B186
		public virtual float? VerticalAccelerateTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.VerticalAccelerateTime;
				}
				IChongLouHook_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.VerticalAccelerateTime;
			}
			set
			{
				this.GetOrCreatePoco().VerticalAccelerateTime = value;
			}
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06000ADE RID: 2782 RVA: 0x0002CF94 File Offset: 0x0002B194
		// (set) Token: 0x06000ADF RID: 2783 RVA: 0x0002CFCE File Offset: 0x0002B1CE
		public virtual float? VerticalDecelerateTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.VerticalDecelerateTime;
				}
				IChongLouHook_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.VerticalDecelerateTime;
			}
			set
			{
				this.GetOrCreatePoco().VerticalDecelerateTime = value;
			}
		}

		// Token: 0x04000ADC RID: 2780
		[Nullable(2)]
		protected new IChongLouHook FbInstance;

		// Token: 0x04000ADD RID: 2781
		[Nullable(2)]
		protected new IChongLouHook_SetValue PocoInterface;

		// Token: 0x04000ADE RID: 2782
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _HookActionsCache;

		// Token: 0x04000ADF RID: 2783
		private bool _HookActionsInited;

		// Token: 0x04000AE0 RID: 2784
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ExitHookActionsCache;

		// Token: 0x04000AE1 RID: 2785
		private bool _ExitHookActionsInited;

		// Token: 0x04000AE2 RID: 2786
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _FinishActionsCache;

		// Token: 0x04000AE3 RID: 2787
		private bool _FinishActionsInited;

		// Token: 0x04000AE4 RID: 2788
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x04000AE5 RID: 2789
		private bool _ClientHookActionConfigInited;
	}
}
