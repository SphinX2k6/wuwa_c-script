using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B07 RID: 2823
	[NullableContext(2)]
	[Nullable(0)]
	public class IFollowerShoot : IHookInteractType
	{
		// Token: 0x06004129 RID: 16681 RVA: 0x000A726B File Offset: 0x000A546B
		[NullableContext(1)]
		public static IFollowerShoot Create(IFollowerShoot? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFollowerShoot
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170010D8 RID: 4312
		// (get) Token: 0x0600412A RID: 16682 RVA: 0x000A728A File Offset: 0x000A548A
		public override EHookInteractType Type
		{
			get
			{
				return (EHookInteractType)this.Instance.Type;
			}
		}

		// Token: 0x170010D9 RID: 4313
		// (get) Token: 0x0600412B RID: 16683 RVA: 0x000A7298 File Offset: 0x000A5498
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

		// Token: 0x170010DA RID: 4314
		// (get) Token: 0x0600412C RID: 16684 RVA: 0x000A7314 File Offset: 0x000A5514
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

		// Token: 0x170010DB RID: 4315
		// (get) Token: 0x0600412D RID: 16685 RVA: 0x000A7390 File Offset: 0x000A5590
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

		// Token: 0x170010DC RID: 4316
		// (get) Token: 0x0600412E RID: 16686 RVA: 0x000A740A File Offset: 0x000A560A
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

		// Token: 0x040024A8 RID: 9384
		private IFollowerShoot Instance;

		// Token: 0x040024A9 RID: 9385
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _HookActionsCache;

		// Token: 0x040024AA RID: 9386
		private bool _HookActionsInited;

		// Token: 0x040024AB RID: 9387
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _ExitHookActionsCache;

		// Token: 0x040024AC RID: 9388
		private bool _ExitHookActionsInited;

		// Token: 0x040024AD RID: 9389
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _FinishActionsCache;

		// Token: 0x040024AE RID: 9390
		private bool _FinishActionsInited;

		// Token: 0x040024AF RID: 9391
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x040024B0 RID: 9392
		private bool _ClientHookActionConfigInited;
	}
}
