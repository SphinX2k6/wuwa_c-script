using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200069B RID: 1691
	public class IPilotThrow : IHookInteractType
	{
		// Token: 0x060023A6 RID: 9126 RVA: 0x000618CC File Offset: 0x0005FACC
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

		// Token: 0x060023A7 RID: 9127 RVA: 0x00061904 File Offset: 0x0005FB04
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

		// Token: 0x060023A8 RID: 9128 RVA: 0x00061917 File Offset: 0x0005FB17
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

		// Token: 0x060023A9 RID: 9129 RVA: 0x0006192C File Offset: 0x0005FB2C
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

		// Token: 0x17000969 RID: 2409
		// (get) Token: 0x060023AA RID: 9130 RVA: 0x000619FE File Offset: 0x0005FBFE
		// (set) Token: 0x060023AB RID: 9131 RVA: 0x00061A29 File Offset: 0x0005FC29
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

		// Token: 0x1700096A RID: 2410
		// (get) Token: 0x060023AC RID: 9132 RVA: 0x00061A38 File Offset: 0x0005FC38
		// (set) Token: 0x060023AD RID: 9133 RVA: 0x00061ACB File Offset: 0x0005FCCB
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
					IPilotThrow_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700096B RID: 2411
		// (get) Token: 0x060023AE RID: 9134 RVA: 0x00061AE0 File Offset: 0x0005FCE0
		// (set) Token: 0x060023AF RID: 9135 RVA: 0x00061B73 File Offset: 0x0005FD73
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
					IPilotThrow_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700096C RID: 2412
		// (get) Token: 0x060023B0 RID: 9136 RVA: 0x00061B88 File Offset: 0x0005FD88
		// (set) Token: 0x060023B1 RID: 9137 RVA: 0x00061C1B File Offset: 0x0005FE1B
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
					IPilotThrow_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700096D RID: 2413
		// (get) Token: 0x060023B2 RID: 9138 RVA: 0x00061C30 File Offset: 0x0005FE30
		// (set) Token: 0x060023B3 RID: 9139 RVA: 0x00061C91 File Offset: 0x0005FE91
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

		// Token: 0x1700096E RID: 2414
		// (get) Token: 0x060023B4 RID: 9140 RVA: 0x00061CA6 File Offset: 0x0005FEA6
		// (set) Token: 0x060023B5 RID: 9141 RVA: 0x00061CD1 File Offset: 0x0005FED1
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

		// Token: 0x1700096F RID: 2415
		// (get) Token: 0x060023B6 RID: 9142 RVA: 0x00061CDF File Offset: 0x0005FEDF
		// (set) Token: 0x060023B7 RID: 9143 RVA: 0x00061D0E File Offset: 0x0005FF0E
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

		// Token: 0x17000970 RID: 2416
		// (get) Token: 0x060023B8 RID: 9144 RVA: 0x00061D1C File Offset: 0x0005FF1C
		// (set) Token: 0x060023B9 RID: 9145 RVA: 0x00061D4B File Offset: 0x0005FF4B
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

		// Token: 0x17000971 RID: 2417
		// (get) Token: 0x060023BA RID: 9146 RVA: 0x00061D59 File Offset: 0x0005FF59
		// (set) Token: 0x060023BB RID: 9147 RVA: 0x00061D88 File Offset: 0x0005FF88
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

		// Token: 0x17000972 RID: 2418
		// (get) Token: 0x060023BC RID: 9148 RVA: 0x00061D96 File Offset: 0x0005FF96
		// (set) Token: 0x060023BD RID: 9149 RVA: 0x00061DC5 File Offset: 0x0005FFC5
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

		// Token: 0x17000973 RID: 2419
		// (get) Token: 0x060023BE RID: 9150 RVA: 0x00061DD3 File Offset: 0x0005FFD3
		// (set) Token: 0x060023BF RID: 9151 RVA: 0x00061E02 File Offset: 0x00060002
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

		// Token: 0x17000974 RID: 2420
		// (get) Token: 0x060023C0 RID: 9152 RVA: 0x00061E10 File Offset: 0x00060010
		// (set) Token: 0x060023C1 RID: 9153 RVA: 0x00061E4A File Offset: 0x0006004A
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

		// Token: 0x17000975 RID: 2421
		// (get) Token: 0x060023C2 RID: 9154 RVA: 0x00061E58 File Offset: 0x00060058
		// (set) Token: 0x060023C3 RID: 9155 RVA: 0x00061EEB File Offset: 0x000600EB
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

		// Token: 0x17000976 RID: 2422
		// (get) Token: 0x060023C4 RID: 9156 RVA: 0x00061F00 File Offset: 0x00060100
		// (set) Token: 0x060023C5 RID: 9157 RVA: 0x00061F3A File Offset: 0x0006013A
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

		// Token: 0x17000977 RID: 2423
		// (get) Token: 0x060023C6 RID: 9158 RVA: 0x00061F48 File Offset: 0x00060148
		// (set) Token: 0x060023C7 RID: 9159 RVA: 0x00061F82 File Offset: 0x00060182
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

		// Token: 0x17000978 RID: 2424
		// (get) Token: 0x060023C8 RID: 9160 RVA: 0x00061F90 File Offset: 0x00060190
		// (set) Token: 0x060023C9 RID: 9161 RVA: 0x00061FCA File Offset: 0x000601CA
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

		// Token: 0x040018D0 RID: 6352
		[Nullable(2)]
		protected new IPilotThrow FbInstance;

		// Token: 0x040018D1 RID: 6353
		[Nullable(2)]
		protected new IPilotThrow_SetValue PocoInterface;

		// Token: 0x040018D2 RID: 6354
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _HookActionsCache;

		// Token: 0x040018D3 RID: 6355
		private bool _HookActionsInited;

		// Token: 0x040018D4 RID: 6356
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ExitHookActionsCache;

		// Token: 0x040018D5 RID: 6357
		private bool _ExitHookActionsInited;

		// Token: 0x040018D6 RID: 6358
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _FinishActionsCache;

		// Token: 0x040018D7 RID: 6359
		private bool _FinishActionsInited;

		// Token: 0x040018D8 RID: 6360
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x040018D9 RID: 6361
		private bool _ClientHookActionConfigInited;

		// Token: 0x040018DA RID: 6362
		private List<IPilotThrowTarget> _TargetListCache;

		// Token: 0x040018DB RID: 6363
		private bool _TargetListInited;
	}
}
