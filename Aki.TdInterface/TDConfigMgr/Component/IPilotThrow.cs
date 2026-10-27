using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005FE RID: 1534
	[NullableContext(1)]
	[Nullable(0)]
	public class IPilotThrow : IHookInteractType
	{
		// Token: 0x060020A0 RID: 8352 RVA: 0x0005ABB8 File Offset: 0x00058DB8
		private IPilotThrow_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPilotThrow 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPilotThrow_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPilotThrow_SetValue());
			}
			return result;
		}

		// Token: 0x060020A1 RID: 8353 RVA: 0x0005ABF0 File Offset: 0x00058DF0
		public static IPilotThrow Create([Nullable(2)] IPilotThrow instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPilotThrow
			{
				FbInstance = instance
			};
		}

		// Token: 0x060020A2 RID: 8354 RVA: 0x0005AC03 File Offset: 0x00058E03
		public static IPilotThrow CreateFromSetValue([Nullable(2)] IPilotThrow_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPilotThrow
			{
				PocoInterface = value
			};
		}

		// Token: 0x060020A3 RID: 8355 RVA: 0x0005AC18 File Offset: 0x00058E18
		public new IPilotThrow_SetValue ToSetValue()
		{
			return new IPilotThrow_SetValue
			{
				Type = this.Type,
				HookActions = this.HookActions,
				ExitHookActions = this.ExitHookActions,
				FinishActions = this.FinishActions,
				ClientHookActionConfig = this.ClientHookActionConfig,
				TitanEntityId = this.TitanEntityId,
				MinPitchAngle = this.MinPitchAngle,
				DefaultPitchAngle = this.DefaultPitchAngle,
				MaxPitchAngle = this.MaxPitchAngle,
				MaxYawAngleDelta = this.MaxYawAngleDelta,
				FlySpeed = this.FlySpeed,
				Gravity = this.Gravity,
				TargetList = this.TargetList,
				AutoThrowType = this.AutoThrowType,
				IsAutoRide = this.IsAutoRide,
				DisableInterrupt = this.DisableInterrupt
			};
		}

		// Token: 0x170008B2 RID: 2226
		// (get) Token: 0x060020A4 RID: 8356 RVA: 0x0005ACEA File Offset: 0x00058EEA
		// (set) Token: 0x060020A5 RID: 8357 RVA: 0x0005AD15 File Offset: 0x00058F15
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

		// Token: 0x170008B3 RID: 2227
		// (get) Token: 0x060020A6 RID: 8358 RVA: 0x0005AD24 File Offset: 0x00058F24
		// (set) Token: 0x060020A7 RID: 8359 RVA: 0x0005ADB7 File Offset: 0x00058FB7
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
					IPilotThrow_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x060020A8 RID: 8360 RVA: 0x0005ADCC File Offset: 0x00058FCC
		// (set) Token: 0x060020A9 RID: 8361 RVA: 0x0005AE5F File Offset: 0x0005905F
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
					IPilotThrow_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x060020AA RID: 8362 RVA: 0x0005AE74 File Offset: 0x00059074
		// (set) Token: 0x060020AB RID: 8363 RVA: 0x0005AF07 File Offset: 0x00059107
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
					IPilotThrow_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170008B6 RID: 2230
		// (get) Token: 0x060020AC RID: 8364 RVA: 0x0005AF1C File Offset: 0x0005911C
		// (set) Token: 0x060020AD RID: 8365 RVA: 0x0005AF7D File Offset: 0x0005917D
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
					IPilotThrow_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x060020AE RID: 8366 RVA: 0x0005AF92 File Offset: 0x00059192
		// (set) Token: 0x060020AF RID: 8367 RVA: 0x0005AFBD File Offset: 0x000591BD
		public virtual int TitanEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TitanEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TitanEntityId;
			}
			set
			{
				this.GetOrCreatePoco().TitanEntityId = value;
			}
		}

		// Token: 0x170008B8 RID: 2232
		// (get) Token: 0x060020B0 RID: 8368 RVA: 0x0005AFCB File Offset: 0x000591CB
		// (set) Token: 0x060020B1 RID: 8369 RVA: 0x0005AFFA File Offset: 0x000591FA
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

		// Token: 0x170008B9 RID: 2233
		// (get) Token: 0x060020B2 RID: 8370 RVA: 0x0005B008 File Offset: 0x00059208
		// (set) Token: 0x060020B3 RID: 8371 RVA: 0x0005B037 File Offset: 0x00059237
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

		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x060020B4 RID: 8372 RVA: 0x0005B045 File Offset: 0x00059245
		// (set) Token: 0x060020B5 RID: 8373 RVA: 0x0005B074 File Offset: 0x00059274
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

		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x060020B6 RID: 8374 RVA: 0x0005B082 File Offset: 0x00059282
		// (set) Token: 0x060020B7 RID: 8375 RVA: 0x0005B0B1 File Offset: 0x000592B1
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

		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x060020B8 RID: 8376 RVA: 0x0005B0BF File Offset: 0x000592BF
		// (set) Token: 0x060020B9 RID: 8377 RVA: 0x0005B0EE File Offset: 0x000592EE
		public virtual float FlySpeed
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FlySpeed;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.FlySpeed;
			}
			set
			{
				this.GetOrCreatePoco().FlySpeed = value;
			}
		}

		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x060020BA RID: 8378 RVA: 0x0005B0FC File Offset: 0x000592FC
		// (set) Token: 0x060020BB RID: 8379 RVA: 0x0005B136 File Offset: 0x00059336
		public virtual float? Gravity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Gravity;
				}
				IPilotThrow_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Gravity;
			}
			set
			{
				this.GetOrCreatePoco().Gravity = value;
			}
		}

		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x060020BC RID: 8380 RVA: 0x0005B144 File Offset: 0x00059344
		// (set) Token: 0x060020BD RID: 8381 RVA: 0x0005B1D7 File Offset: 0x000593D7
		public virtual List<IPilotThrowTarget> TargetList
		{
			get
			{
				if (this._TargetListInited)
				{
					return this._TargetListCache;
				}
				this._TargetListInited = true;
				if (this.FbInstance != null)
				{
					List<IPilotThrowTarget> targetList = this.FbInstance.TargetList;
					if (targetList != null)
					{
						this._TargetListCache = new List<IPilotThrowTarget>(targetList.Count);
						for (int i = 0; i < targetList.Count; i++)
						{
							this._TargetListCache.Add(IPilotThrowTarget.Create(targetList[i]));
						}
					}
				}
				else
				{
					IPilotThrow_SetValue pocoInterface = this.PocoInterface;
					this._TargetListCache = ((pocoInterface != null) ? pocoInterface.TargetList : null);
				}
				return this._TargetListCache;
			}
			set
			{
				this.GetOrCreatePoco().TargetList = value;
				this._TargetListInited = false;
			}
		}

		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x060020BE RID: 8382 RVA: 0x0005B1EC File Offset: 0x000593EC
		// (set) Token: 0x060020BF RID: 8383 RVA: 0x0005B226 File Offset: 0x00059426
		public virtual EPilotThrowAutoThrowType? AutoThrowType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AutoThrowType;
				}
				IPilotThrow_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.AutoThrowType;
			}
			set
			{
				this.GetOrCreatePoco().AutoThrowType = value;
			}
		}

		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x060020C0 RID: 8384 RVA: 0x0005B234 File Offset: 0x00059434
		// (set) Token: 0x060020C1 RID: 8385 RVA: 0x0005B26E File Offset: 0x0005946E
		public virtual bool? IsAutoRide
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsAutoRide;
				}
				IPilotThrow_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsAutoRide;
			}
			set
			{
				this.GetOrCreatePoco().IsAutoRide = value;
			}
		}

		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x060020C2 RID: 8386 RVA: 0x0005B27C File Offset: 0x0005947C
		// (set) Token: 0x060020C3 RID: 8387 RVA: 0x0005B2B6 File Offset: 0x000594B6
		public virtual bool? DisableInterrupt
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DisableInterrupt;
				}
				IPilotThrow_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DisableInterrupt;
			}
			set
			{
				this.GetOrCreatePoco().DisableInterrupt = value;
			}
		}

		// Token: 0x040016DE RID: 5854
		[Nullable(2)]
		protected new IPilotThrow FbInstance;

		// Token: 0x040016DF RID: 5855
		[Nullable(2)]
		protected new IPilotThrow_SetValue PocoInterface;

		// Token: 0x040016E0 RID: 5856
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _HookActionsCache;

		// Token: 0x040016E1 RID: 5857
		private bool _HookActionsInited;

		// Token: 0x040016E2 RID: 5858
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ExitHookActionsCache;

		// Token: 0x040016E3 RID: 5859
		private bool _ExitHookActionsInited;

		// Token: 0x040016E4 RID: 5860
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _FinishActionsCache;

		// Token: 0x040016E5 RID: 5861
		private bool _FinishActionsInited;

		// Token: 0x040016E6 RID: 5862
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x040016E7 RID: 5863
		private bool _ClientHookActionConfigInited;

		// Token: 0x040016E8 RID: 5864
		private List<IPilotThrowTarget> _TargetListCache;

		// Token: 0x040016E9 RID: 5865
		private bool _TargetListInited;
	}
}
