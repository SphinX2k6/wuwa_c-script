using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BC6 RID: 3014
	[NullableContext(2)]
	[Nullable(0)]
	public class IRagDollJumpingPoint : IHookInteractType
	{
		// Token: 0x060044F2 RID: 17650 RVA: 0x000AF3F2 File Offset: 0x000AD5F2
		[NullableContext(0)]
		public static IRagDollJumpingPoint Create(IRagDollJumpingPoint? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRagDollJumpingPoint
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001161 RID: 4449
		// (get) Token: 0x060044F3 RID: 17651 RVA: 0x000AF411 File Offset: 0x000AD611
		public override EHookInteractType Type
		{
			get
			{
				return (EHookInteractType)this.Instance.Type;
			}
		}

		// Token: 0x17001162 RID: 4450
		// (get) Token: 0x060044F4 RID: 17652 RVA: 0x000AF420 File Offset: 0x000AD620
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

		// Token: 0x17001163 RID: 4451
		// (get) Token: 0x060044F5 RID: 17653 RVA: 0x000AF49C File Offset: 0x000AD69C
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

		// Token: 0x17001164 RID: 4452
		// (get) Token: 0x060044F6 RID: 17654 RVA: 0x000AF518 File Offset: 0x000AD718
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

		// Token: 0x17001165 RID: 4453
		// (get) Token: 0x060044F7 RID: 17655 RVA: 0x000AF592 File Offset: 0x000AD792
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

		// Token: 0x0400266F RID: 9839
		private IRagDollJumpingPoint Instance;

		// Token: 0x04002670 RID: 9840
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _HookActionsCache;

		// Token: 0x04002671 RID: 9841
		private bool _HookActionsInited;

		// Token: 0x04002672 RID: 9842
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _ExitHookActionsCache;

		// Token: 0x04002673 RID: 9843
		private bool _ExitHookActionsInited;

		// Token: 0x04002674 RID: 9844
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _FinishActionsCache;

		// Token: 0x04002675 RID: 9845
		private bool _FinishActionsInited;

		// Token: 0x04002676 RID: 9846
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x04002677 RID: 9847
		private bool _ClientHookActionConfigInited;
	}
}
