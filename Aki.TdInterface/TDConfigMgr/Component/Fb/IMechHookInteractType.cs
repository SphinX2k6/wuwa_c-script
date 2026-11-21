using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BBD RID: 3005
	[NullableContext(2)]
	[Nullable(0)]
	public class IMechHookInteractType
	{
		// Token: 0x060044AD RID: 17581 RVA: 0x000AE21A File Offset: 0x000AC41A
		[NullableContext(0)]
		public static IMechHookInteractType Create(IMechHookInteractType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechHookInteractType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700112E RID: 4398
		// (get) Token: 0x060044AE RID: 17582 RVA: 0x000AE239 File Offset: 0x000AC439
		public virtual EMechHookInteractType Type
		{
			get
			{
				return (EMechHookInteractType)this.Instance.Type;
			}
		}

		// Token: 0x1700112F RID: 4399
		// (get) Token: 0x060044AF RID: 17583 RVA: 0x000AE248 File Offset: 0x000AC448
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<ActionInfo> HookActions
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

		// Token: 0x17001130 RID: 4400
		// (get) Token: 0x060044B0 RID: 17584 RVA: 0x000AE2C4 File Offset: 0x000AC4C4
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<ActionInfo> ExitHookActions
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

		// Token: 0x17001131 RID: 4401
		// (get) Token: 0x060044B1 RID: 17585 RVA: 0x000AE340 File Offset: 0x000AC540
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<ActionInfo> FinishActions
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

		// Token: 0x17001132 RID: 4402
		// (get) Token: 0x060044B2 RID: 17586 RVA: 0x000AE3BA File Offset: 0x000AC5BA
		public virtual IClientHookActionConfig ClientHookActionConfig
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

		// Token: 0x0400261A RID: 9754
		private IMechHookInteractType Instance;

		// Token: 0x0400261B RID: 9755
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _HookActionsCache;

		// Token: 0x0400261C RID: 9756
		private bool _HookActionsInited;

		// Token: 0x0400261D RID: 9757
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _ExitHookActionsCache;

		// Token: 0x0400261E RID: 9758
		private bool _ExitHookActionsInited;

		// Token: 0x0400261F RID: 9759
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _FinishActionsCache;

		// Token: 0x04002620 RID: 9760
		private bool _FinishActionsInited;

		// Token: 0x04002621 RID: 9761
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x04002622 RID: 9762
		private bool _ClientHookActionConfigInited;
	}
}
