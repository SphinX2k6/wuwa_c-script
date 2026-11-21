using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BD0 RID: 3024
	[NullableContext(2)]
	[Nullable(0)]
	public class ISunSpiritLauncher : IHookInteractType
	{
		// Token: 0x06004555 RID: 17749 RVA: 0x000B09DB File Offset: 0x000AEBDB
		[NullableContext(0)]
		public static ISunSpiritLauncher Create(ISunSpiritLauncher? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISunSpiritLauncher
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170011B0 RID: 4528
		// (get) Token: 0x06004556 RID: 17750 RVA: 0x000B09FA File Offset: 0x000AEBFA
		public override EHookInteractType Type
		{
			get
			{
				return (EHookInteractType)this.Instance.Type;
			}
		}

		// Token: 0x170011B1 RID: 4529
		// (get) Token: 0x06004557 RID: 17751 RVA: 0x000B0A08 File Offset: 0x000AEC08
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

		// Token: 0x170011B2 RID: 4530
		// (get) Token: 0x06004558 RID: 17752 RVA: 0x000B0A84 File Offset: 0x000AEC84
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

		// Token: 0x170011B3 RID: 4531
		// (get) Token: 0x06004559 RID: 17753 RVA: 0x000B0B00 File Offset: 0x000AED00
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

		// Token: 0x170011B4 RID: 4532
		// (get) Token: 0x0600455A RID: 17754 RVA: 0x000B0B7A File Offset: 0x000AED7A
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

		// Token: 0x040026C9 RID: 9929
		private ISunSpiritLauncher Instance;

		// Token: 0x040026CA RID: 9930
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _HookActionsCache;

		// Token: 0x040026CB RID: 9931
		private bool _HookActionsInited;

		// Token: 0x040026CC RID: 9932
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _ExitHookActionsCache;

		// Token: 0x040026CD RID: 9933
		private bool _ExitHookActionsInited;

		// Token: 0x040026CE RID: 9934
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _FinishActionsCache;

		// Token: 0x040026CF RID: 9935
		private bool _FinishActionsInited;

		// Token: 0x040026D0 RID: 9936
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x040026D1 RID: 9937
		private bool _ClientHookActionConfigInited;
	}
}
