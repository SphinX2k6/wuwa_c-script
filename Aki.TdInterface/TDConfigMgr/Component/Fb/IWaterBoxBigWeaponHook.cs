using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000AF5 RID: 2805
	[NullableContext(2)]
	[Nullable(0)]
	public class IWaterBoxBigWeaponHook : IHookInteractType
	{
		// Token: 0x06004093 RID: 16531 RVA: 0x000A517A File Offset: 0x000A337A
		[NullableContext(1)]
		public static IWaterBoxBigWeaponHook Create(IWaterBoxBigWeaponHook? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWaterBoxBigWeaponHook
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001066 RID: 4198
		// (get) Token: 0x06004094 RID: 16532 RVA: 0x000A5199 File Offset: 0x000A3399
		public override EHookInteractType Type
		{
			get
			{
				return (EHookInteractType)this.Instance.Type;
			}
		}

		// Token: 0x17001067 RID: 4199
		// (get) Token: 0x06004095 RID: 16533 RVA: 0x000A51A8 File Offset: 0x000A33A8
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

		// Token: 0x17001068 RID: 4200
		// (get) Token: 0x06004096 RID: 16534 RVA: 0x000A5224 File Offset: 0x000A3424
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

		// Token: 0x17001069 RID: 4201
		// (get) Token: 0x06004097 RID: 16535 RVA: 0x000A52A0 File Offset: 0x000A34A0
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

		// Token: 0x1700106A RID: 4202
		// (get) Token: 0x06004098 RID: 16536 RVA: 0x000A531A File Offset: 0x000A351A
		public override IClientHookActionConfig ClientHookActionConfig
		{
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

		// Token: 0x04002418 RID: 9240
		private IWaterBoxBigWeaponHook Instance;

		// Token: 0x04002419 RID: 9241
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _HookActionsCache;

		// Token: 0x0400241A RID: 9242
		private bool _HookActionsInited;

		// Token: 0x0400241B RID: 9243
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _ExitHookActionsCache;

		// Token: 0x0400241C RID: 9244
		private bool _ExitHookActionsInited;

		// Token: 0x0400241D RID: 9245
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _FinishActionsCache;

		// Token: 0x0400241E RID: 9246
		private bool _FinishActionsInited;

		// Token: 0x0400241F RID: 9247
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x04002420 RID: 9248
		private bool _ClientHookActionConfigInited;
	}
}
