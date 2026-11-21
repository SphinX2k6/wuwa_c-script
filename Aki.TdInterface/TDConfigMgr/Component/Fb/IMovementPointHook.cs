using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BBF RID: 3007
	[NullableContext(2)]
	[Nullable(0)]
	public class IMovementPointHook : IHookInteractType
	{
		// Token: 0x060044BC RID: 17596 RVA: 0x000AE60A File Offset: 0x000AC80A
		[NullableContext(0)]
		public static IMovementPointHook Create(IMovementPointHook? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMovementPointHook
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001139 RID: 4409
		// (get) Token: 0x060044BD RID: 17597 RVA: 0x000AE629 File Offset: 0x000AC829
		public override EHookInteractType Type
		{
			get
			{
				return (EHookInteractType)this.Instance.Type;
			}
		}

		// Token: 0x1700113A RID: 4410
		// (get) Token: 0x060044BE RID: 17598 RVA: 0x000AE638 File Offset: 0x000AC838
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

		// Token: 0x1700113B RID: 4411
		// (get) Token: 0x060044BF RID: 17599 RVA: 0x000AE6B4 File Offset: 0x000AC8B4
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

		// Token: 0x1700113C RID: 4412
		// (get) Token: 0x060044C0 RID: 17600 RVA: 0x000AE730 File Offset: 0x000AC930
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

		// Token: 0x1700113D RID: 4413
		// (get) Token: 0x060044C1 RID: 17601 RVA: 0x000AE7AA File Offset: 0x000AC9AA
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

		// Token: 0x0400262C RID: 9772
		private IMovementPointHook Instance;

		// Token: 0x0400262D RID: 9773
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _HookActionsCache;

		// Token: 0x0400262E RID: 9774
		private bool _HookActionsInited;

		// Token: 0x0400262F RID: 9775
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _ExitHookActionsCache;

		// Token: 0x04002630 RID: 9776
		private bool _ExitHookActionsInited;

		// Token: 0x04002631 RID: 9777
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _FinishActionsCache;

		// Token: 0x04002632 RID: 9778
		private bool _FinishActionsInited;

		// Token: 0x04002633 RID: 9779
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x04002634 RID: 9780
		private bool _ClientHookActionConfigInited;
	}
}
