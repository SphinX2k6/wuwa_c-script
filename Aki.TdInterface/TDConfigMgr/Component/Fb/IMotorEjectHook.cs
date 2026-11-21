using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BDB RID: 3035
	public class IMotorEjectHook : IHookInteractType
	{
		// Token: 0x060045A1 RID: 17825 RVA: 0x000B19A4 File Offset: 0x000AFBA4
		public static IMotorEjectHook Create(IMotorEjectHook? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMotorEjectHook
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170011E6 RID: 4582
		// (get) Token: 0x060045A2 RID: 17826 RVA: 0x000B19C3 File Offset: 0x000AFBC3
		public override EHookInteractType Type
		{
			get
			{
				return (EHookInteractType)this.Instance.Type;
			}
		}

		// Token: 0x170011E7 RID: 4583
		// (get) Token: 0x060045A3 RID: 17827 RVA: 0x000B19D0 File Offset: 0x000AFBD0
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

		// Token: 0x170011E8 RID: 4584
		// (get) Token: 0x060045A4 RID: 17828 RVA: 0x000B1A4C File Offset: 0x000AFC4C
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

		// Token: 0x170011E9 RID: 4585
		// (get) Token: 0x060045A5 RID: 17829 RVA: 0x000B1AC8 File Offset: 0x000AFCC8
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

		// Token: 0x170011EA RID: 4586
		// (get) Token: 0x060045A6 RID: 17830 RVA: 0x000B1B42 File Offset: 0x000AFD42
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

		// Token: 0x170011EB RID: 4587
		// (get) Token: 0x060045A7 RID: 17831 RVA: 0x000B1B76 File Offset: 0x000AFD76
		public virtual float MinPitchAngle
		{
			get
			{
				return this.Instance.MinPitchAngle;
			}
		}

		// Token: 0x170011EC RID: 4588
		// (get) Token: 0x060045A8 RID: 17832 RVA: 0x000B1B83 File Offset: 0x000AFD83
		public virtual float DefaultPitchAngle
		{
			get
			{
				return this.Instance.DefaultPitchAngle;
			}
		}

		// Token: 0x170011ED RID: 4589
		// (get) Token: 0x060045A9 RID: 17833 RVA: 0x000B1B90 File Offset: 0x000AFD90
		public virtual float MaxPitchAngle
		{
			get
			{
				return this.Instance.MaxPitchAngle;
			}
		}

		// Token: 0x170011EE RID: 4590
		// (get) Token: 0x060045AA RID: 17834 RVA: 0x000B1B9D File Offset: 0x000AFD9D
		public virtual float MaxYawAngleDelta
		{
			get
			{
				return this.Instance.MaxYawAngleDelta;
			}
		}

		// Token: 0x170011EF RID: 4591
		// (get) Token: 0x060045AB RID: 17835 RVA: 0x000B1BAA File Offset: 0x000AFDAA
		public virtual float MaxEjectDistance
		{
			get
			{
				return this.Instance.MaxEjectDistance;
			}
		}

		// Token: 0x170011F0 RID: 4592
		// (get) Token: 0x060045AC RID: 17836 RVA: 0x000B1BB7 File Offset: 0x000AFDB7
		public virtual float InterpSpeed
		{
			get
			{
				return this.Instance.InterpSpeed;
			}
		}

		// Token: 0x170011F1 RID: 4593
		// (get) Token: 0x060045AD RID: 17837 RVA: 0x000B1BC4 File Offset: 0x000AFDC4
		public virtual IMotorAutoEjectConfigBase AutoEjectConfig
		{
			get
			{
				if (this._AutoEjectConfigInited)
				{
					return this._AutoEjectConfigCache;
				}
				this._AutoEjectConfigInited = true;
				this._AutoEjectConfigCache = ComponentReadHelper.ReadIMotorEjectHook_AutoEjectConfig(this.Instance);
				return this._AutoEjectConfigCache;
			}
		}

		// Token: 0x0400270A RID: 9994
		private IMotorEjectHook Instance;

		// Token: 0x0400270B RID: 9995
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _HookActionsCache;

		// Token: 0x0400270C RID: 9996
		private bool _HookActionsInited;

		// Token: 0x0400270D RID: 9997
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _ExitHookActionsCache;

		// Token: 0x0400270E RID: 9998
		private bool _ExitHookActionsInited;

		// Token: 0x0400270F RID: 9999
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _FinishActionsCache;

		// Token: 0x04002710 RID: 10000
		private bool _FinishActionsInited;

		// Token: 0x04002711 RID: 10001
		[Nullable(2)]
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x04002712 RID: 10002
		private bool _ClientHookActionConfigInited;

		// Token: 0x04002713 RID: 10003
		private IMotorAutoEjectConfigBase _AutoEjectConfigCache;

		// Token: 0x04002714 RID: 10004
		private bool _AutoEjectConfigInited;
	}
}
