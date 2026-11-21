using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020015A7 RID: 5543
	[NullableContext(2)]
	[Nullable(0)]
	public class ISaveConfig
	{
		// Token: 0x06007CFD RID: 31997 RVA: 0x001290F6 File Offset: 0x001272F6
		[NullableContext(0)]
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

		// Token: 0x17002951 RID: 10577
		// (get) Token: 0x06007CFE RID: 31998 RVA: 0x00129118 File Offset: 0x00127318
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

		// Token: 0x17002952 RID: 10578
		// (get) Token: 0x06007CFF RID: 31999 RVA: 0x00129150 File Offset: 0x00127350
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

		// Token: 0x17002953 RID: 10579
		// (get) Token: 0x06007D00 RID: 32000 RVA: 0x00129188 File Offset: 0x00127388
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

		// Token: 0x17002954 RID: 10580
		// (get) Token: 0x06007D01 RID: 32001 RVA: 0x001291BE File Offset: 0x001273BE
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

		// Token: 0x17002955 RID: 10581
		// (get) Token: 0x06007D02 RID: 32002 RVA: 0x001291F4 File Offset: 0x001273F4
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<ActionInfo> EnterActions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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

		// Token: 0x17002956 RID: 10582
		// (get) Token: 0x06007D03 RID: 32003 RVA: 0x00129270 File Offset: 0x00127470
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IInitConditionActions> InitConditionActions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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

		// Token: 0x0400483B RID: 18491
		private ISaveConfig Instance;

		// Token: 0x0400483C RID: 18492
		private IPosRollbackConfig _PosRollbackCfgCache;

		// Token: 0x0400483D RID: 18493
		private bool _PosRollbackCfgInited;

		// Token: 0x0400483E RID: 18494
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _EnterActionsCache;

		// Token: 0x0400483F RID: 18495
		private bool _EnterActionsInited;

		// Token: 0x04004840 RID: 18496
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IInitConditionActions> _InitConditionActionsCache;

		// Token: 0x04004841 RID: 18497
		private bool _InitConditionActionsInited;
	}
}
