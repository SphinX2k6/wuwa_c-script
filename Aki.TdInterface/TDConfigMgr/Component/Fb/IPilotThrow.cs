using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BCF RID: 3023
	public class IPilotThrow : IHookInteractType
	{
		// Token: 0x06004543 RID: 17731 RVA: 0x000B0665 File Offset: 0x000AE865
		public static IPilotThrow Create(IPilotThrow? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPilotThrow
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170011A0 RID: 4512
		// (get) Token: 0x06004544 RID: 17732 RVA: 0x000B0684 File Offset: 0x000AE884
		public override EHookInteractType Type
		{
			get
			{
				return (EHookInteractType)this.Instance.Type;
			}
		}

		// Token: 0x170011A1 RID: 4513
		// (get) Token: 0x06004545 RID: 17733 RVA: 0x000B0694 File Offset: 0x000AE894
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public override List<ActionInfo> HookActions
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
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int hookActionsLength = this.Instance.HookActionsLength;
				this._HookActionsCache = new List<ActionInfo>(hookActionsLength);
				for (int i = 0; i < hookActionsLength; i++)
				{
					this._HookActionsCache.Add(ActionInfo.Create(this.Instance.HookActions(i)));
				}
				return this._HookActionsCache;
			}
		}

		// Token: 0x170011A2 RID: 4514
		// (get) Token: 0x06004546 RID: 17734 RVA: 0x000B0710 File Offset: 0x000AE910
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public override List<ActionInfo> ExitHookActions
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
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				int exitHookActionsLength = this.Instance.ExitHookActionsLength;
				this._ExitHookActionsCache = new List<ActionInfo>(exitHookActionsLength);
				for (int i = 0; i < exitHookActionsLength; i++)
				{
					this._ExitHookActionsCache.Add(ActionInfo.Create(this.Instance.ExitHookActions(i)));
				}
				return this._ExitHookActionsCache;
			}
		}

		// Token: 0x170011A3 RID: 4515
		// (get) Token: 0x06004547 RID: 17735 RVA: 0x000B078C File Offset: 0x000AE98C
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public override List<ActionInfo> FinishActions
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
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				int finishActionsLength = this.Instance.FinishActionsLength;
				this._FinishActionsCache = new List<ActionInfo>(finishActionsLength);
				for (int i = 0; i < finishActionsLength; i++)
				{
					this._FinishActionsCache.Add(ActionInfo.Create(this.Instance.FinishActions(i)));
				}
				return this._FinishActionsCache;
			}
		}

		// Token: 0x170011A4 RID: 4516
		// (get) Token: 0x06004548 RID: 17736 RVA: 0x000B0806 File Offset: 0x000AEA06
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
				this._ClientHookActionConfigCache = IClientHookActionConfig.Create(this.Instance.ClientHookActionConfig);
				return this._ClientHookActionConfigCache;
			}
		}

		// Token: 0x170011A5 RID: 4517
		// (get) Token: 0x06004549 RID: 17737 RVA: 0x000B083A File Offset: 0x000AEA3A
		public virtual int TitanEntityId
		{
			get
			{
				return this.Instance.TitanEntityId;
			}
		}

		// Token: 0x170011A6 RID: 4518
		// (get) Token: 0x0600454A RID: 17738 RVA: 0x000B0847 File Offset: 0x000AEA47
		public virtual float MinPitchAngle
		{
			get
			{
				return this.Instance.MinPitchAngle;
			}
		}

		// Token: 0x170011A7 RID: 4519
		// (get) Token: 0x0600454B RID: 17739 RVA: 0x000B0854 File Offset: 0x000AEA54
		public virtual float DefaultPitchAngle
		{
			get
			{
				return this.Instance.DefaultPitchAngle;
			}
		}

		// Token: 0x170011A8 RID: 4520
		// (get) Token: 0x0600454C RID: 17740 RVA: 0x000B0861 File Offset: 0x000AEA61
		public virtual float MaxPitchAngle
		{
			get
			{
				return this.Instance.MaxPitchAngle;
			}
		}

		// Token: 0x170011A9 RID: 4521
		// (get) Token: 0x0600454D RID: 17741 RVA: 0x000B086E File Offset: 0x000AEA6E
		public virtual float MaxYawAngleDelta
		{
			get
			{
				return this.Instance.MaxYawAngleDelta;
			}
		}

		// Token: 0x170011AA RID: 4522
		// (get) Token: 0x0600454E RID: 17742 RVA: 0x000B087B File Offset: 0x000AEA7B
		public virtual float FlySpeed
		{
			get
			{
				return this.Instance.FlySpeed;
			}
		}

		// Token: 0x170011AB RID: 4523
		// (get) Token: 0x0600454F RID: 17743 RVA: 0x000B0888 File Offset: 0x000AEA88
		public virtual float? Gravity
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new float?(this.Instance.Gravity);
			}
		}

		// Token: 0x170011AC RID: 4524
		// (get) Token: 0x06004550 RID: 17744 RVA: 0x000B08C0 File Offset: 0x000AEAC0
		public virtual List<IPilotThrowTarget> TargetList
		{
			get
			{
				if (this._TargetListInited)
				{
					return this._TargetListCache;
				}
				this._TargetListInited = true;
				int targetListLength = this.Instance.TargetListLength;
				this._TargetListCache = new List<IPilotThrowTarget>(targetListLength);
				for (int i = 0; i < targetListLength; i++)
				{
					this._TargetListCache.Add(IPilotThrowTarget.Create(this.Instance.TargetList(i)));
				}
				return this._TargetListCache;
			}
		}

		// Token: 0x170011AD RID: 4525
		// (get) Token: 0x06004551 RID: 17745 RVA: 0x000B092C File Offset: 0x000AEB2C
		public virtual EPilotThrowAutoThrowType? AutoThrowType
		{
			get
			{
				if ((this.Instance.NullMask & 16) == 0)
				{
					return null;
				}
				return new EPilotThrowAutoThrowType?((EPilotThrowAutoThrowType)this.Instance.AutoThrowType);
			}
		}

		// Token: 0x170011AE RID: 4526
		// (get) Token: 0x06004552 RID: 17746 RVA: 0x000B0964 File Offset: 0x000AEB64
		public virtual bool? IsAutoRide
		{
			get
			{
				if ((this.Instance.NullMask & 32) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsAutoRide);
			}
		}

		// Token: 0x170011AF RID: 4527
		// (get) Token: 0x06004553 RID: 17747 RVA: 0x000B099C File Offset: 0x000AEB9C
		public virtual bool? DisableInterrupt
		{
			get
			{
				if ((this.Instance.NullMask & 64) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.DisableInterrupt);
			}
		}

		// Token: 0x040026BE RID: 9918
		private IPilotThrow Instance;

		// Token: 0x040026BF RID: 9919
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _HookActionsCache;

		// Token: 0x040026C0 RID: 9920
		private bool _HookActionsInited;

		// Token: 0x040026C1 RID: 9921
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _ExitHookActionsCache;

		// Token: 0x040026C2 RID: 9922
		private bool _ExitHookActionsInited;

		// Token: 0x040026C3 RID: 9923
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _FinishActionsCache;

		// Token: 0x040026C4 RID: 9924
		private bool _FinishActionsInited;

		// Token: 0x040026C5 RID: 9925
		[Nullable(2)]
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x040026C6 RID: 9926
		private bool _ClientHookActionConfigInited;

		// Token: 0x040026C7 RID: 9927
		private List<IPilotThrowTarget> _TargetListCache;

		// Token: 0x040026C8 RID: 9928
		private bool _TargetListInited;
	}
}
