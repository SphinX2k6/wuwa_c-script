using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BC0 RID: 3008
	[NullableContext(2)]
	[Nullable(0)]
	public class ISuiGuangHook : IHookInteractType
	{
		// Token: 0x060044C3 RID: 17603 RVA: 0x000AE7E6 File Offset: 0x000AC9E6
		[NullableContext(0)]
		public static ISuiGuangHook Create(ISuiGuangHook? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISuiGuangHook
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700113E RID: 4414
		// (get) Token: 0x060044C4 RID: 17604 RVA: 0x000AE805 File Offset: 0x000ACA05
		public override EHookInteractType Type
		{
			get
			{
				return (EHookInteractType)this.Instance.Type;
			}
		}

		// Token: 0x1700113F RID: 4415
		// (get) Token: 0x060044C5 RID: 17605 RVA: 0x000AE814 File Offset: 0x000ACA14
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

		// Token: 0x17001140 RID: 4416
		// (get) Token: 0x060044C6 RID: 17606 RVA: 0x000AE890 File Offset: 0x000ACA90
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

		// Token: 0x17001141 RID: 4417
		// (get) Token: 0x060044C7 RID: 17607 RVA: 0x000AE90C File Offset: 0x000ACB0C
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

		// Token: 0x17001142 RID: 4418
		// (get) Token: 0x060044C8 RID: 17608 RVA: 0x000AE986 File Offset: 0x000ACB86
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

		// Token: 0x04002635 RID: 9781
		private ISuiGuangHook Instance;

		// Token: 0x04002636 RID: 9782
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _HookActionsCache;

		// Token: 0x04002637 RID: 9783
		private bool _HookActionsInited;

		// Token: 0x04002638 RID: 9784
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _ExitHookActionsCache;

		// Token: 0x04002639 RID: 9785
		private bool _ExitHookActionsInited;

		// Token: 0x0400263A RID: 9786
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _FinishActionsCache;

		// Token: 0x0400263B RID: 9787
		private bool _FinishActionsInited;

		// Token: 0x0400263C RID: 9788
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x0400263D RID: 9789
		private bool _ClientHookActionConfigInited;
	}
}
