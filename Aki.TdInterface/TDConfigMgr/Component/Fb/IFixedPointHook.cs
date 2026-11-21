using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BBE RID: 3006
	[NullableContext(2)]
	[Nullable(0)]
	public class IFixedPointHook : IHookInteractType
	{
		// Token: 0x060044B4 RID: 17588 RVA: 0x000AE3F6 File Offset: 0x000AC5F6
		[NullableContext(0)]
		public static IFixedPointHook Create(IFixedPointHook? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFixedPointHook
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001133 RID: 4403
		// (get) Token: 0x060044B5 RID: 17589 RVA: 0x000AE415 File Offset: 0x000AC615
		public override EHookInteractType Type
		{
			get
			{
				return (EHookInteractType)this.Instance.Type;
			}
		}

		// Token: 0x17001134 RID: 4404
		// (get) Token: 0x060044B6 RID: 17590 RVA: 0x000AE424 File Offset: 0x000AC624
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

		// Token: 0x17001135 RID: 4405
		// (get) Token: 0x060044B7 RID: 17591 RVA: 0x000AE4A0 File Offset: 0x000AC6A0
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

		// Token: 0x17001136 RID: 4406
		// (get) Token: 0x060044B8 RID: 17592 RVA: 0x000AE51C File Offset: 0x000AC71C
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

		// Token: 0x17001137 RID: 4407
		// (get) Token: 0x060044B9 RID: 17593 RVA: 0x000AE596 File Offset: 0x000AC796
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

		// Token: 0x17001138 RID: 4408
		// (get) Token: 0x060044BA RID: 17594 RVA: 0x000AE5CC File Offset: 0x000AC7CC
		public virtual float? ExitDistance
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new float?(this.Instance.ExitDistance);
			}
		}

		// Token: 0x04002623 RID: 9763
		private IFixedPointHook Instance;

		// Token: 0x04002624 RID: 9764
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _HookActionsCache;

		// Token: 0x04002625 RID: 9765
		private bool _HookActionsInited;

		// Token: 0x04002626 RID: 9766
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _ExitHookActionsCache;

		// Token: 0x04002627 RID: 9767
		private bool _ExitHookActionsInited;

		// Token: 0x04002628 RID: 9768
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _FinishActionsCache;

		// Token: 0x04002629 RID: 9769
		private bool _FinishActionsInited;

		// Token: 0x0400262A RID: 9770
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x0400262B RID: 9771
		private bool _ClientHookActionConfigInited;
	}
}
