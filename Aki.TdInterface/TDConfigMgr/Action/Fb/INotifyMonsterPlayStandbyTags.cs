using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026E2 RID: 9954
	public class INotifyMonsterPlayStandbyTags : ISendBattleStateType
	{
		// Token: 0x0600DE63 RID: 56931 RVA: 0x0020FEB2 File Offset: 0x0020E0B2
		[NullableContext(1)]
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

		// Token: 0x17004261 RID: 16993
		// (get) Token: 0x0600DE64 RID: 56932 RVA: 0x0020FED1 File Offset: 0x0020E0D1
		public override ESetBattleStateType Type
		{
			get
			{
				return (ESetBattleStateType)this.Instance.Type;
			}
		}

		// Token: 0x17004262 RID: 16994
		// (get) Token: 0x0600DE65 RID: 56933 RVA: 0x0020FEE0 File Offset: 0x0020E0E0
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IMonsterStandByConfig> StandbyConfigs
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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

		// Token: 0x04007B70 RID: 31600
		private INotifyMonsterPlayStandbyTags Instance;

		// Token: 0x04007B71 RID: 31601
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IMonsterStandByConfig> _StandbyConfigsCache;

		// Token: 0x04007B72 RID: 31602
		private bool _StandbyConfigsInited;
	}
}
