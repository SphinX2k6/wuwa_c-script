using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B0E RID: 2830
	[NullableContext(1)]
	[Nullable(0)]
	public class IMotorEjectHook : IHookInteractType
	{
		// Token: 0x0600415B RID: 16731 RVA: 0x000A7D00 File Offset: 0x000A5F00
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

		// Token: 0x170010FC RID: 4348
		// (get) Token: 0x0600415C RID: 16732 RVA: 0x000A7D1F File Offset: 0x000A5F1F
		public override EHookInteractType Type
		{
			get
			{
				return (EHookInteractType)this.Instance.Type;
			}
		}

		// Token: 0x170010FD RID: 4349
		// (get) Token: 0x0600415D RID: 16733 RVA: 0x000A7D2C File Offset: 0x000A5F2C
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

		// Token: 0x170010FE RID: 4350
		// (get) Token: 0x0600415E RID: 16734 RVA: 0x000A7DA8 File Offset: 0x000A5FA8
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

		// Token: 0x170010FF RID: 4351
		// (get) Token: 0x0600415F RID: 16735 RVA: 0x000A7E24 File Offset: 0x000A6024
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

		// Token: 0x17001100 RID: 4352
		// (get) Token: 0x06004160 RID: 16736 RVA: 0x000A7E9E File Offset: 0x000A609E
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

		// Token: 0x17001101 RID: 4353
		// (get) Token: 0x06004161 RID: 16737 RVA: 0x000A7ED2 File Offset: 0x000A60D2
		public virtual float MinPitchAngle
		{
			get
			{
				return this.Instance.MinPitchAngle;
			}
		}

		// Token: 0x17001102 RID: 4354
		// (get) Token: 0x06004162 RID: 16738 RVA: 0x000A7EDF File Offset: 0x000A60DF
		public virtual float DefaultPitchAngle
		{
			get
			{
				return this.Instance.DefaultPitchAngle;
			}
		}

		// Token: 0x17001103 RID: 4355
		// (get) Token: 0x06004163 RID: 16739 RVA: 0x000A7EEC File Offset: 0x000A60EC
		public virtual float MaxPitchAngle
		{
			get
			{
				return this.Instance.MaxPitchAngle;
			}
		}

		// Token: 0x17001104 RID: 4356
		// (get) Token: 0x06004164 RID: 16740 RVA: 0x000A7EF9 File Offset: 0x000A60F9
		public virtual float MaxYawAngleDelta
		{
			get
			{
				return this.Instance.MaxYawAngleDelta;
			}
		}

		// Token: 0x17001105 RID: 4357
		// (get) Token: 0x06004165 RID: 16741 RVA: 0x000A7F06 File Offset: 0x000A6106
		public virtual float MaxEjectDistance
		{
			get
			{
				return this.Instance.MaxEjectDistance;
			}
		}

		// Token: 0x17001106 RID: 4358
		// (get) Token: 0x06004166 RID: 16742 RVA: 0x000A7F13 File Offset: 0x000A6113
		public virtual float InterpSpeed
		{
			get
			{
				return this.Instance.InterpSpeed;
			}
		}

		// Token: 0x17001107 RID: 4359
		// (get) Token: 0x06004167 RID: 16743 RVA: 0x000A7F20 File Offset: 0x000A6120
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

		// Token: 0x040024CF RID: 9423
		private IMotorEjectHook Instance;

		// Token: 0x040024D0 RID: 9424
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _HookActionsCache;

		// Token: 0x040024D1 RID: 9425
		private bool _HookActionsInited;

		// Token: 0x040024D2 RID: 9426
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _ExitHookActionsCache;

		// Token: 0x040024D3 RID: 9427
		private bool _ExitHookActionsInited;

		// Token: 0x040024D4 RID: 9428
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _FinishActionsCache;

		// Token: 0x040024D5 RID: 9429
		private bool _FinishActionsInited;

		// Token: 0x040024D6 RID: 9430
		[Nullable(2)]
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x040024D7 RID: 9431
		private bool _ClientHookActionConfigInited;

		// Token: 0x040024D8 RID: 9432
		private IMotorAutoEjectConfigBase _AutoEjectConfigCache;

		// Token: 0x040024D9 RID: 9433
		private bool _AutoEjectConfigInited;
	}
}
