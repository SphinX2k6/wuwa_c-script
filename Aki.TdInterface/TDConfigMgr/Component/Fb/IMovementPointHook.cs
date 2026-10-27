using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000AF3 RID: 2803
	[NullableContext(2)]
	[Nullable(0)]
	public class IMovementPointHook : IHookInteractType
	{
		// Token: 0x06004085 RID: 16517 RVA: 0x000A4DC2 File Offset: 0x000A2FC2
		[NullableContext(1)]
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

		// Token: 0x1700105C RID: 4188
		// (get) Token: 0x06004086 RID: 16518 RVA: 0x000A4DE1 File Offset: 0x000A2FE1
		public override EHookInteractType Type
		{
			get
			{
				return (EHookInteractType)this.Instance.Type;
			}
		}

		// Token: 0x1700105D RID: 4189
		// (get) Token: 0x06004087 RID: 16519 RVA: 0x000A4DF0 File Offset: 0x000A2FF0
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

		// Token: 0x1700105E RID: 4190
		// (get) Token: 0x06004088 RID: 16520 RVA: 0x000A4E6C File Offset: 0x000A306C
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

		// Token: 0x1700105F RID: 4191
		// (get) Token: 0x06004089 RID: 16521 RVA: 0x000A4EE8 File Offset: 0x000A30E8
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

		// Token: 0x17001060 RID: 4192
		// (get) Token: 0x0600408A RID: 16522 RVA: 0x000A4F62 File Offset: 0x000A3162
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

		// Token: 0x04002406 RID: 9222
		private IMovementPointHook Instance;

		// Token: 0x04002407 RID: 9223
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _HookActionsCache;

		// Token: 0x04002408 RID: 9224
		private bool _HookActionsInited;

		// Token: 0x04002409 RID: 9225
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _ExitHookActionsCache;

		// Token: 0x0400240A RID: 9226
		private bool _ExitHookActionsInited;

		// Token: 0x0400240B RID: 9227
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _FinishActionsCache;

		// Token: 0x0400240C RID: 9228
		private bool _FinishActionsInited;

		// Token: 0x0400240D RID: 9229
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x0400240E RID: 9230
		private bool _ClientHookActionConfigInited;
	}
}
