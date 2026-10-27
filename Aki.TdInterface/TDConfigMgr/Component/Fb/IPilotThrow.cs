using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B04 RID: 2820
	[NullableContext(1)]
	[Nullable(0)]
	public class IPilotThrow : IHookInteractType
	{
		// Token: 0x06004108 RID: 16648 RVA: 0x000A6B31 File Offset: 0x000A4D31
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

		// Token: 0x170010BD RID: 4285
		// (get) Token: 0x06004109 RID: 16649 RVA: 0x000A6B50 File Offset: 0x000A4D50
		public override EHookInteractType Type
		{
			get
			{
				return (EHookInteractType)this.Instance.Type;
			}
		}

		// Token: 0x170010BE RID: 4286
		// (get) Token: 0x0600410A RID: 16650 RVA: 0x000A6B60 File Offset: 0x000A4D60
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public override List<ActionInfo> HookActions
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

		// Token: 0x170010BF RID: 4287
		// (get) Token: 0x0600410B RID: 16651 RVA: 0x000A6BDC File Offset: 0x000A4DDC
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public override List<ActionInfo> ExitHookActions
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

		// Token: 0x170010C0 RID: 4288
		// (get) Token: 0x0600410C RID: 16652 RVA: 0x000A6C58 File Offset: 0x000A4E58
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public override List<ActionInfo> FinishActions
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

		// Token: 0x170010C1 RID: 4289
		// (get) Token: 0x0600410D RID: 16653 RVA: 0x000A6CD2 File Offset: 0x000A4ED2
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

		// Token: 0x170010C2 RID: 4290
		// (get) Token: 0x0600410E RID: 16654 RVA: 0x000A6D06 File Offset: 0x000A4F06
		public virtual int TitanEntityId
		{
			get
			{
				return this.Instance.TitanEntityId;
			}
		}

		// Token: 0x170010C3 RID: 4291
		// (get) Token: 0x0600410F RID: 16655 RVA: 0x000A6D13 File Offset: 0x000A4F13
		public virtual float MinPitchAngle
		{
			get
			{
				return this.Instance.MinPitchAngle;
			}
		}

		// Token: 0x170010C4 RID: 4292
		// (get) Token: 0x06004110 RID: 16656 RVA: 0x000A6D20 File Offset: 0x000A4F20
		public virtual float DefaultPitchAngle
		{
			get
			{
				return this.Instance.DefaultPitchAngle;
			}
		}

		// Token: 0x170010C5 RID: 4293
		// (get) Token: 0x06004111 RID: 16657 RVA: 0x000A6D2D File Offset: 0x000A4F2D
		public virtual float MaxPitchAngle
		{
			get
			{
				return this.Instance.MaxPitchAngle;
			}
		}

		// Token: 0x170010C6 RID: 4294
		// (get) Token: 0x06004112 RID: 16658 RVA: 0x000A6D3A File Offset: 0x000A4F3A
		public virtual float MaxYawAngleDelta
		{
			get
			{
				return this.Instance.MaxYawAngleDelta;
			}
		}

		// Token: 0x170010C7 RID: 4295
		// (get) Token: 0x06004113 RID: 16659 RVA: 0x000A6D47 File Offset: 0x000A4F47
		public virtual float FlySpeed
		{
			get
			{
				return this.Instance.FlySpeed;
			}
		}

		// Token: 0x170010C8 RID: 4296
		// (get) Token: 0x06004114 RID: 16660 RVA: 0x000A6D54 File Offset: 0x000A4F54
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

		// Token: 0x170010C9 RID: 4297
		// (get) Token: 0x06004115 RID: 16661 RVA: 0x000A6D8C File Offset: 0x000A4F8C
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

		// Token: 0x170010CA RID: 4298
		// (get) Token: 0x06004116 RID: 16662 RVA: 0x000A6DF8 File Offset: 0x000A4FF8
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

		// Token: 0x170010CB RID: 4299
		// (get) Token: 0x06004117 RID: 16663 RVA: 0x000A6E30 File Offset: 0x000A5030
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

		// Token: 0x170010CC RID: 4300
		// (get) Token: 0x06004118 RID: 16664 RVA: 0x000A6E68 File Offset: 0x000A5068
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

		// Token: 0x0400248B RID: 9355
		private IPilotThrow Instance;

		// Token: 0x0400248C RID: 9356
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _HookActionsCache;

		// Token: 0x0400248D RID: 9357
		private bool _HookActionsInited;

		// Token: 0x0400248E RID: 9358
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _ExitHookActionsCache;

		// Token: 0x0400248F RID: 9359
		private bool _ExitHookActionsInited;

		// Token: 0x04002490 RID: 9360
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _FinishActionsCache;

		// Token: 0x04002491 RID: 9361
		private bool _FinishActionsInited;

		// Token: 0x04002492 RID: 9362
		[Nullable(2)]
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x04002493 RID: 9363
		private bool _ClientHookActionConfigInited;

		// Token: 0x04002494 RID: 9364
		private List<IPilotThrowTarget> _TargetListCache;

		// Token: 0x04002495 RID: 9365
		private bool _TargetListInited;
	}
}
