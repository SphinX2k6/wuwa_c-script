using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BC2 RID: 3010
	[NullableContext(2)]
	[Nullable(0)]
	public class IMechTransformHook : IHookInteractType
	{
		// Token: 0x060044D1 RID: 17617 RVA: 0x000AEB9E File Offset: 0x000ACD9E
		[NullableContext(0)]
		public static IMechTransformHook Create(IMechTransformHook? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechTransformHook
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001148 RID: 4424
		// (get) Token: 0x060044D2 RID: 17618 RVA: 0x000AEBBD File Offset: 0x000ACDBD
		public override EHookInteractType Type
		{
			get
			{
				return (EHookInteractType)this.Instance.Type;
			}
		}

		// Token: 0x17001149 RID: 4425
		// (get) Token: 0x060044D3 RID: 17619 RVA: 0x000AEBCC File Offset: 0x000ACDCC
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

		// Token: 0x1700114A RID: 4426
		// (get) Token: 0x060044D4 RID: 17620 RVA: 0x000AEC48 File Offset: 0x000ACE48
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

		// Token: 0x1700114B RID: 4427
		// (get) Token: 0x060044D5 RID: 17621 RVA: 0x000AECC4 File Offset: 0x000ACEC4
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

		// Token: 0x1700114C RID: 4428
		// (get) Token: 0x060044D6 RID: 17622 RVA: 0x000AED3E File Offset: 0x000ACF3E
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

		// Token: 0x04002647 RID: 9799
		private IMechTransformHook Instance;

		// Token: 0x04002648 RID: 9800
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _HookActionsCache;

		// Token: 0x04002649 RID: 9801
		private bool _HookActionsInited;

		// Token: 0x0400264A RID: 9802
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _ExitHookActionsCache;

		// Token: 0x0400264B RID: 9803
		private bool _ExitHookActionsInited;

		// Token: 0x0400264C RID: 9804
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _FinishActionsCache;

		// Token: 0x0400264D RID: 9805
		private bool _FinishActionsInited;

		// Token: 0x0400264E RID: 9806
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x0400264F RID: 9807
		private bool _ClientHookActionConfigInited;
	}
}
