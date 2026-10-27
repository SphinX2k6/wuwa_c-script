using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B06 RID: 2822
	[NullableContext(2)]
	[Nullable(0)]
	public class ICableWay : IHookInteractType
	{
		// Token: 0x06004121 RID: 16673 RVA: 0x000A7082 File Offset: 0x000A5282
		[NullableContext(1)]
		public static ICableWay Create(ICableWay? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICableWay
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170010D2 RID: 4306
		// (get) Token: 0x06004122 RID: 16674 RVA: 0x000A70A1 File Offset: 0x000A52A1
		public override EHookInteractType Type
		{
			get
			{
				return (EHookInteractType)this.Instance.Type;
			}
		}

		// Token: 0x170010D3 RID: 4307
		// (get) Token: 0x06004123 RID: 16675 RVA: 0x000A70B0 File Offset: 0x000A52B0
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

		// Token: 0x170010D4 RID: 4308
		// (get) Token: 0x06004124 RID: 16676 RVA: 0x000A712C File Offset: 0x000A532C
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

		// Token: 0x170010D5 RID: 4309
		// (get) Token: 0x06004125 RID: 16677 RVA: 0x000A71A8 File Offset: 0x000A53A8
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

		// Token: 0x170010D6 RID: 4310
		// (get) Token: 0x06004126 RID: 16678 RVA: 0x000A7222 File Offset: 0x000A5422
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

		// Token: 0x170010D7 RID: 4311
		// (get) Token: 0x06004127 RID: 16679 RVA: 0x000A7256 File Offset: 0x000A5456
		public virtual int SplineEntityId
		{
			get
			{
				return this.Instance.SplineEntityId;
			}
		}

		// Token: 0x0400249F RID: 9375
		private ICableWay Instance;

		// Token: 0x040024A0 RID: 9376
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _HookActionsCache;

		// Token: 0x040024A1 RID: 9377
		private bool _HookActionsInited;

		// Token: 0x040024A2 RID: 9378
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _ExitHookActionsCache;

		// Token: 0x040024A3 RID: 9379
		private bool _ExitHookActionsInited;

		// Token: 0x040024A4 RID: 9380
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _FinishActionsCache;

		// Token: 0x040024A5 RID: 9381
		private bool _FinishActionsInited;

		// Token: 0x040024A6 RID: 9382
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x040024A7 RID: 9383
		private bool _ClientHookActionConfigInited;
	}
}
