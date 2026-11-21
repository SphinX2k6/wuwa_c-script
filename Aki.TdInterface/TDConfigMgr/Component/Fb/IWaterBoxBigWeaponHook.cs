using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BC1 RID: 3009
	[NullableContext(2)]
	[Nullable(0)]
	public class IWaterBoxBigWeaponHook : IHookInteractType
	{
		// Token: 0x060044CA RID: 17610 RVA: 0x000AE9C2 File Offset: 0x000ACBC2
		[NullableContext(0)]
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

		// Token: 0x17001143 RID: 4419
		// (get) Token: 0x060044CB RID: 17611 RVA: 0x000AE9E1 File Offset: 0x000ACBE1
		public override EHookInteractType Type
		{
			get
			{
				return (EHookInteractType)this.Instance.Type;
			}
		}

		// Token: 0x17001144 RID: 4420
		// (get) Token: 0x060044CC RID: 17612 RVA: 0x000AE9F0 File Offset: 0x000ACBF0
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

		// Token: 0x17001145 RID: 4421
		// (get) Token: 0x060044CD RID: 17613 RVA: 0x000AEA6C File Offset: 0x000ACC6C
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

		// Token: 0x17001146 RID: 4422
		// (get) Token: 0x060044CE RID: 17614 RVA: 0x000AEAE8 File Offset: 0x000ACCE8
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

		// Token: 0x17001147 RID: 4423
		// (get) Token: 0x060044CF RID: 17615 RVA: 0x000AEB62 File Offset: 0x000ACD62
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

		// Token: 0x0400263E RID: 9790
		private IWaterBoxBigWeaponHook Instance;

		// Token: 0x0400263F RID: 9791
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _HookActionsCache;

		// Token: 0x04002640 RID: 9792
		private bool _HookActionsInited;

		// Token: 0x04002641 RID: 9793
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _ExitHookActionsCache;

		// Token: 0x04002642 RID: 9794
		private bool _ExitHookActionsInited;

		// Token: 0x04002643 RID: 9795
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _FinishActionsCache;

		// Token: 0x04002644 RID: 9796
		private bool _FinishActionsInited;

		// Token: 0x04002645 RID: 9797
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x04002646 RID: 9798
		private bool _ClientHookActionConfigInited;
	}
}
