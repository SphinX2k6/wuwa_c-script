using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000AF0 RID: 2800
	public class IClientHookActionConfig
	{
		// Token: 0x06004072 RID: 16498 RVA: 0x000A4871 File Offset: 0x000A2A71
		[NullableContext(1)]
		public static IClientHookActionConfig Create(IClientHookActionConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientHookActionConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700104F RID: 4175
		// (get) Token: 0x06004073 RID: 16499 RVA: 0x000A4890 File Offset: 0x000A2A90
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<ActionInfo> HookActions
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

		// Token: 0x17001050 RID: 4176
		// (get) Token: 0x06004074 RID: 16500 RVA: 0x000A490C File Offset: 0x000A2B0C
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<ActionInfo> ExitHookActions
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

		// Token: 0x17001051 RID: 4177
		// (get) Token: 0x06004075 RID: 16501 RVA: 0x000A4988 File Offset: 0x000A2B88
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<ActionInfo> FinishActions
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

		// Token: 0x040023ED RID: 9197
		private IClientHookActionConfig Instance;

		// Token: 0x040023EE RID: 9198
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _HookActionsCache;

		// Token: 0x040023EF RID: 9199
		private bool _HookActionsInited;

		// Token: 0x040023F0 RID: 9200
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _ExitHookActionsCache;

		// Token: 0x040023F1 RID: 9201
		private bool _ExitHookActionsInited;

		// Token: 0x040023F2 RID: 9202
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _FinishActionsCache;

		// Token: 0x040023F3 RID: 9203
		private bool _FinishActionsInited;
	}
}
