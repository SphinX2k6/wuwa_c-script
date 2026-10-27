using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000AFD RID: 2813
	[NullableContext(2)]
	[Nullable(0)]
	public class IFoxJumpingPoint : IHookInteractType
	{
		// Token: 0x060040C6 RID: 16582 RVA: 0x000A5CAE File Offset: 0x000A3EAE
		[NullableContext(1)]
		public static IFoxJumpingPoint Create(IFoxJumpingPoint? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFoxJumpingPoint
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001089 RID: 4233
		// (get) Token: 0x060040C7 RID: 16583 RVA: 0x000A5CCD File Offset: 0x000A3ECD
		public override EHookInteractType Type
		{
			get
			{
				return (EHookInteractType)this.Instance.Type;
			}
		}

		// Token: 0x1700108A RID: 4234
		// (get) Token: 0x060040C8 RID: 16584 RVA: 0x000A5CDC File Offset: 0x000A3EDC
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

		// Token: 0x1700108B RID: 4235
		// (get) Token: 0x060040C9 RID: 16585 RVA: 0x000A5D58 File Offset: 0x000A3F58
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

		// Token: 0x1700108C RID: 4236
		// (get) Token: 0x060040CA RID: 16586 RVA: 0x000A5DD4 File Offset: 0x000A3FD4
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

		// Token: 0x1700108D RID: 4237
		// (get) Token: 0x060040CB RID: 16587 RVA: 0x000A5E4E File Offset: 0x000A404E
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

		// Token: 0x0400244E RID: 9294
		private IFoxJumpingPoint Instance;

		// Token: 0x0400244F RID: 9295
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _HookActionsCache;

		// Token: 0x04002450 RID: 9296
		private bool _HookActionsInited;

		// Token: 0x04002451 RID: 9297
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _ExitHookActionsCache;

		// Token: 0x04002452 RID: 9298
		private bool _ExitHookActionsInited;

		// Token: 0x04002453 RID: 9299
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _FinishActionsCache;

		// Token: 0x04002454 RID: 9300
		private bool _FinishActionsInited;

		// Token: 0x04002455 RID: 9301
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x04002456 RID: 9302
		private bool _ClientHookActionConfigInited;
	}
}
