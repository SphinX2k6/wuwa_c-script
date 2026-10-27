using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B0A RID: 2826
	[NullableContext(2)]
	[Nullable(0)]
	public class IHookSpaceStationEnergyCore : IHookInteractType
	{
		// Token: 0x06004148 RID: 16712 RVA: 0x000A7A36 File Offset: 0x000A5C36
		[NullableContext(1)]
		public static IHookSpaceStationEnergyCore Create(IHookSpaceStationEnergyCore? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHookSpaceStationEnergyCore
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170010F1 RID: 4337
		// (get) Token: 0x06004149 RID: 16713 RVA: 0x000A7A55 File Offset: 0x000A5C55
		public override EHookInteractType Type
		{
			get
			{
				return (EHookInteractType)this.Instance.Type;
			}
		}

		// Token: 0x170010F2 RID: 4338
		// (get) Token: 0x0600414A RID: 16714 RVA: 0x000A7A64 File Offset: 0x000A5C64
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

		// Token: 0x170010F3 RID: 4339
		// (get) Token: 0x0600414B RID: 16715 RVA: 0x000A7AE0 File Offset: 0x000A5CE0
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

		// Token: 0x170010F4 RID: 4340
		// (get) Token: 0x0600414C RID: 16716 RVA: 0x000A7B5C File Offset: 0x000A5D5C
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

		// Token: 0x170010F5 RID: 4341
		// (get) Token: 0x0600414D RID: 16717 RVA: 0x000A7BD6 File Offset: 0x000A5DD6
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

		// Token: 0x170010F6 RID: 4342
		// (get) Token: 0x0600414E RID: 16718 RVA: 0x000A7C0C File Offset: 0x000A5E0C
		public virtual int? HookSpeed
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new int?(this.Instance.HookSpeed);
			}
		}

		// Token: 0x040024C3 RID: 9411
		private IHookSpaceStationEnergyCore Instance;

		// Token: 0x040024C4 RID: 9412
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _HookActionsCache;

		// Token: 0x040024C5 RID: 9413
		private bool _HookActionsInited;

		// Token: 0x040024C6 RID: 9414
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _ExitHookActionsCache;

		// Token: 0x040024C7 RID: 9415
		private bool _ExitHookActionsInited;

		// Token: 0x040024C8 RID: 9416
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _FinishActionsCache;

		// Token: 0x040024C9 RID: 9417
		private bool _FinishActionsInited;

		// Token: 0x040024CA RID: 9418
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x040024CB RID: 9419
		private bool _ClientHookActionConfigInited;
	}
}
