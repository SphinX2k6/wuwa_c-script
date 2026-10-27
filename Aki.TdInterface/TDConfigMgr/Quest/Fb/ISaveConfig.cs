using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200144F RID: 5199
	[NullableContext(2)]
	[Nullable(0)]
	public class ISaveConfig
	{
		// Token: 0x06007633 RID: 30259 RVA: 0x0011A572 File Offset: 0x00118772
		[NullableContext(1)]
		public static ISaveConfig Create(ISaveConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISaveConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002768 RID: 10088
		// (get) Token: 0x06007634 RID: 30260 RVA: 0x0011A594 File Offset: 0x00118794
		public virtual bool? IsTemp
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsTemp);
			}
		}

		// Token: 0x17002769 RID: 10089
		// (get) Token: 0x06007635 RID: 30261 RVA: 0x0011A5CC File Offset: 0x001187CC
		public virtual bool? EnableRollbackWhileSwitchOnlineMode
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.EnableRollbackWhileSwitchOnlineMode);
			}
		}

		// Token: 0x1700276A RID: 10090
		// (get) Token: 0x06007636 RID: 30262 RVA: 0x0011A604 File Offset: 0x00118804
		public virtual bool? DisableRollbackWhileReconnect
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.DisableRollbackWhileReconnect);
			}
		}

		// Token: 0x1700276B RID: 10091
		// (get) Token: 0x06007637 RID: 30263 RVA: 0x0011A63A File Offset: 0x0011883A
		public virtual IPosRollbackConfig PosRollbackCfg
		{
			get
			{
				if (this._PosRollbackCfgInited)
				{
					return this._PosRollbackCfgCache;
				}
				this._PosRollbackCfgInited = true;
				this._PosRollbackCfgCache = IPosRollbackConfig.Create(this.Instance.PosRollbackCfg);
				return this._PosRollbackCfgCache;
			}
		}

		// Token: 0x1700276C RID: 10092
		// (get) Token: 0x06007638 RID: 30264 RVA: 0x0011A670 File Offset: 0x00118870
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<ActionInfo> EnterActions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._EnterActionsInited)
				{
					return this._EnterActionsCache;
				}
				this._EnterActionsInited = true;
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				int enterActionsLength = this.Instance.EnterActionsLength;
				this._EnterActionsCache = new List<ActionInfo>(enterActionsLength);
				for (int i = 0; i < enterActionsLength; i++)
				{
					this._EnterActionsCache.Add(ActionInfo.Create(this.Instance.EnterActions(i)));
				}
				return this._EnterActionsCache;
			}
		}

		// Token: 0x1700276D RID: 10093
		// (get) Token: 0x06007639 RID: 30265 RVA: 0x0011A6EC File Offset: 0x001188EC
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IInitConditionActions> InitConditionActions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._InitConditionActionsInited)
				{
					return this._InitConditionActionsCache;
				}
				this._InitConditionActionsInited = true;
				if ((this.Instance.NullMask & 16) == 0)
				{
					return null;
				}
				int initConditionActionsLength = this.Instance.InitConditionActionsLength;
				this._InitConditionActionsCache = new List<IInitConditionActions>(initConditionActionsLength);
				for (int i = 0; i < initConditionActionsLength; i++)
				{
					this._InitConditionActionsCache.Add(IInitConditionActions.Create(this.Instance.InitConditionActions(i)));
				}
				return this._InitConditionActionsCache;
			}
		}

		// Token: 0x040044A3 RID: 17571
		private ISaveConfig Instance;

		// Token: 0x040044A4 RID: 17572
		private IPosRollbackConfig _PosRollbackCfgCache;

		// Token: 0x040044A5 RID: 17573
		private bool _PosRollbackCfgInited;

		// Token: 0x040044A6 RID: 17574
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _EnterActionsCache;

		// Token: 0x040044A7 RID: 17575
		private bool _EnterActionsInited;

		// Token: 0x040044A8 RID: 17576
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IInitConditionActions> _InitConditionActionsCache;

		// Token: 0x040044A9 RID: 17577
		private bool _InitConditionActionsInited;
	}
}
