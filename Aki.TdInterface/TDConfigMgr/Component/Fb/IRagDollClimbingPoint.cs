using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000AFC RID: 2812
	[NullableContext(2)]
	[Nullable(0)]
	public class IRagDollClimbingPoint : IHookInteractType
	{
		// Token: 0x060040BE RID: 16574 RVA: 0x000A5A9A File Offset: 0x000A3C9A
		[NullableContext(1)]
		public static IRagDollClimbingPoint Create(IRagDollClimbingPoint? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRagDollClimbingPoint
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001083 RID: 4227
		// (get) Token: 0x060040BF RID: 16575 RVA: 0x000A5AB9 File Offset: 0x000A3CB9
		public override EHookInteractType Type
		{
			get
			{
				return (EHookInteractType)this.Instance.Type;
			}
		}

		// Token: 0x17001084 RID: 4228
		// (get) Token: 0x060040C0 RID: 16576 RVA: 0x000A5AC8 File Offset: 0x000A3CC8
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

		// Token: 0x17001085 RID: 4229
		// (get) Token: 0x060040C1 RID: 16577 RVA: 0x000A5B44 File Offset: 0x000A3D44
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

		// Token: 0x17001086 RID: 4230
		// (get) Token: 0x060040C2 RID: 16578 RVA: 0x000A5BC0 File Offset: 0x000A3DC0
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

		// Token: 0x17001087 RID: 4231
		// (get) Token: 0x060040C3 RID: 16579 RVA: 0x000A5C3A File Offset: 0x000A3E3A
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

		// Token: 0x17001088 RID: 4232
		// (get) Token: 0x060040C4 RID: 16580 RVA: 0x000A5C70 File Offset: 0x000A3E70
		public virtual bool? IsSummitPoint
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsSummitPoint);
			}
		}

		// Token: 0x04002445 RID: 9285
		private IRagDollClimbingPoint Instance;

		// Token: 0x04002446 RID: 9286
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _HookActionsCache;

		// Token: 0x04002447 RID: 9287
		private bool _HookActionsInited;

		// Token: 0x04002448 RID: 9288
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _ExitHookActionsCache;

		// Token: 0x04002449 RID: 9289
		private bool _ExitHookActionsInited;

		// Token: 0x0400244A RID: 9290
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _FinishActionsCache;

		// Token: 0x0400244B RID: 9291
		private bool _FinishActionsInited;

		// Token: 0x0400244C RID: 9292
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x0400244D RID: 9293
		private bool _ClientHookActionConfigInited;
	}
}
