using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BC8 RID: 3016
	[NullableContext(2)]
	[Nullable(0)]
	public class IFoxJumpingPoint : IHookInteractType
	{
		// Token: 0x06004501 RID: 17665 RVA: 0x000AF7E2 File Offset: 0x000AD9E2
		[NullableContext(0)]
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

		// Token: 0x1700116C RID: 4460
		// (get) Token: 0x06004502 RID: 17666 RVA: 0x000AF801 File Offset: 0x000ADA01
		public override EHookInteractType Type
		{
			get
			{
				return (EHookInteractType)this.Instance.Type;
			}
		}

		// Token: 0x1700116D RID: 4461
		// (get) Token: 0x06004503 RID: 17667 RVA: 0x000AF810 File Offset: 0x000ADA10
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

		// Token: 0x1700116E RID: 4462
		// (get) Token: 0x06004504 RID: 17668 RVA: 0x000AF88C File Offset: 0x000ADA8C
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

		// Token: 0x1700116F RID: 4463
		// (get) Token: 0x06004505 RID: 17669 RVA: 0x000AF908 File Offset: 0x000ADB08
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

		// Token: 0x17001170 RID: 4464
		// (get) Token: 0x06004506 RID: 17670 RVA: 0x000AF982 File Offset: 0x000ADB82
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

		// Token: 0x04002681 RID: 9857
		private IFoxJumpingPoint Instance;

		// Token: 0x04002682 RID: 9858
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _HookActionsCache;

		// Token: 0x04002683 RID: 9859
		private bool _HookActionsInited;

		// Token: 0x04002684 RID: 9860
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _ExitHookActionsCache;

		// Token: 0x04002685 RID: 9861
		private bool _ExitHookActionsInited;

		// Token: 0x04002686 RID: 9862
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _FinishActionsCache;

		// Token: 0x04002687 RID: 9863
		private bool _FinishActionsInited;

		// Token: 0x04002688 RID: 9864
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x04002689 RID: 9865
		private bool _ClientHookActionConfigInited;
	}
}
