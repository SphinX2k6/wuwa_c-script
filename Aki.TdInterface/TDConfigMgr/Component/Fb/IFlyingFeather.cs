using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BCD RID: 3021
	[NullableContext(2)]
	[Nullable(0)]
	public class IFlyingFeather : IHookInteractType
	{
		// Token: 0x06004532 RID: 17714 RVA: 0x000B0336 File Offset: 0x000AE536
		[NullableContext(0)]
		public static IFlyingFeather Create(IFlyingFeather? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlyingFeather
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001193 RID: 4499
		// (get) Token: 0x06004533 RID: 17715 RVA: 0x000B0355 File Offset: 0x000AE555
		public override EHookInteractType Type
		{
			get
			{
				return (EHookInteractType)this.Instance.Type;
			}
		}

		// Token: 0x17001194 RID: 4500
		// (get) Token: 0x06004534 RID: 17716 RVA: 0x000B0364 File Offset: 0x000AE564
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

		// Token: 0x17001195 RID: 4501
		// (get) Token: 0x06004535 RID: 17717 RVA: 0x000B03E0 File Offset: 0x000AE5E0
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

		// Token: 0x17001196 RID: 4502
		// (get) Token: 0x06004536 RID: 17718 RVA: 0x000B045C File Offset: 0x000AE65C
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

		// Token: 0x17001197 RID: 4503
		// (get) Token: 0x06004537 RID: 17719 RVA: 0x000B04D6 File Offset: 0x000AE6D6
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

		// Token: 0x17001198 RID: 4504
		// (get) Token: 0x06004538 RID: 17720 RVA: 0x000B050C File Offset: 0x000AE70C
		public virtual int? EntityId
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new int?(this.Instance.EntityId);
			}
		}

		// Token: 0x040026B0 RID: 9904
		private IFlyingFeather Instance;

		// Token: 0x040026B1 RID: 9905
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _HookActionsCache;

		// Token: 0x040026B2 RID: 9906
		private bool _HookActionsInited;

		// Token: 0x040026B3 RID: 9907
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _ExitHookActionsCache;

		// Token: 0x040026B4 RID: 9908
		private bool _ExitHookActionsInited;

		// Token: 0x040026B5 RID: 9909
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _FinishActionsCache;

		// Token: 0x040026B6 RID: 9910
		private bool _FinishActionsInited;

		// Token: 0x040026B7 RID: 9911
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x040026B8 RID: 9912
		private bool _ClientHookActionConfigInited;
	}
}
