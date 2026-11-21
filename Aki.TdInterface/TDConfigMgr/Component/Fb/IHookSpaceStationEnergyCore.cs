using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BD7 RID: 3031
	[NullableContext(2)]
	[Nullable(0)]
	public class IHookSpaceStationEnergyCore : IHookInteractType
	{
		// Token: 0x0600458E RID: 17806 RVA: 0x000B16DA File Offset: 0x000AF8DA
		[NullableContext(0)]
		public static IHookSpaceStationEnergyCore Create(IHookSpaceStationEnergyCore? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHookSpaceStationEnergyCore
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170011DB RID: 4571
		// (get) Token: 0x0600458F RID: 17807 RVA: 0x000B16F9 File Offset: 0x000AF8F9
		public override EHookInteractType Type
		{
			get
			{
				return (EHookInteractType)this.Instance.Type;
			}
		}

		// Token: 0x170011DC RID: 4572
		// (get) Token: 0x06004590 RID: 17808 RVA: 0x000B1708 File Offset: 0x000AF908
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

		// Token: 0x170011DD RID: 4573
		// (get) Token: 0x06004591 RID: 17809 RVA: 0x000B1784 File Offset: 0x000AF984
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

		// Token: 0x170011DE RID: 4574
		// (get) Token: 0x06004592 RID: 17810 RVA: 0x000B1800 File Offset: 0x000AFA00
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

		// Token: 0x170011DF RID: 4575
		// (get) Token: 0x06004593 RID: 17811 RVA: 0x000B187A File Offset: 0x000AFA7A
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

		// Token: 0x170011E0 RID: 4576
		// (get) Token: 0x06004594 RID: 17812 RVA: 0x000B18B0 File Offset: 0x000AFAB0
		public virtual int? HookSpeed
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new int?(this.Instance.HookSpeed);
			}
		}

		// Token: 0x040026FE RID: 9982
		private IHookSpaceStationEnergyCore Instance;

		// Token: 0x040026FF RID: 9983
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _HookActionsCache;

		// Token: 0x04002700 RID: 9984
		private bool _HookActionsInited;

		// Token: 0x04002701 RID: 9985
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _ExitHookActionsCache;

		// Token: 0x04002702 RID: 9986
		private bool _ExitHookActionsInited;

		// Token: 0x04002703 RID: 9987
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _FinishActionsCache;

		// Token: 0x04002704 RID: 9988
		private bool _FinishActionsInited;

		// Token: 0x04002705 RID: 9989
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x04002706 RID: 9990
		private bool _ClientHookActionConfigInited;
	}
}
