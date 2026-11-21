using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029A6 RID: 10662
	public class INotifyMonsterPlayStandbyTags : ISendBattleStateType
	{
		// Token: 0x0600EC3F RID: 60479 RVA: 0x0022C6F2 File Offset: 0x0022A8F2
		public static INotifyMonsterPlayStandbyTags Create(INotifyMonsterPlayStandbyTags? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INotifyMonsterPlayStandbyTags
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170045A1 RID: 17825
		// (get) Token: 0x0600EC40 RID: 60480 RVA: 0x0022C711 File Offset: 0x0022A911
		public override ESetBattleStateType Type
		{
			get
			{
				return (ESetBattleStateType)this.Instance.Type;
			}
		}

		// Token: 0x170045A2 RID: 17826
		// (get) Token: 0x0600EC41 RID: 60481 RVA: 0x0022C720 File Offset: 0x0022A920
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IMonsterStandByConfig> StandbyConfigs
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._StandbyConfigsInited)
				{
					return this._StandbyConfigsCache;
				}
				this._StandbyConfigsInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int standbyConfigsLength = this.Instance.StandbyConfigsLength;
				this._StandbyConfigsCache = new List<IMonsterStandByConfig>(standbyConfigsLength);
				for (int i = 0; i < standbyConfigsLength; i++)
				{
					this._StandbyConfigsCache.Add(IMonsterStandByConfig.Create(this.Instance.StandbyConfigs(i)));
				}
				return this._StandbyConfigsCache;
			}
		}

		// Token: 0x04008210 RID: 33296
		private INotifyMonsterPlayStandbyTags Instance;

		// Token: 0x04008211 RID: 33297
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IMonsterStandByConfig> _StandbyConfigsCache;

		// Token: 0x04008212 RID: 33298
		private bool _StandbyConfigsInited;
	}
}
