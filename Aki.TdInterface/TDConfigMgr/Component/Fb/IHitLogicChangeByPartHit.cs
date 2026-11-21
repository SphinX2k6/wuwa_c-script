using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C5C RID: 3164
	public class IHitLogicChangeByPartHit : IHitLogicType
	{
		// Token: 0x0600485A RID: 18522 RVA: 0x000B7032 File Offset: 0x000B5232
		public static IHitLogicChangeByPartHit Create(IHitLogicChangeByPartHit? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHitLogicChangeByPartHit
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700139D RID: 5021
		// (get) Token: 0x0600485B RID: 18523 RVA: 0x000B7051 File Offset: 0x000B5251
		public override EHitLogicType Type
		{
			get
			{
				return (EHitLogicType)this.Instance.Type;
			}
		}

		// Token: 0x1700139E RID: 5022
		// (get) Token: 0x0600485C RID: 18524 RVA: 0x000B7060 File Offset: 0x000B5260
		public virtual List<IPartHitConfig> PartHitConfig
		{
			get
			{
				if (this._PartHitConfigInited)
				{
					return this._PartHitConfigCache;
				}
				this._PartHitConfigInited = true;
				int partHitConfigLength = this.Instance.PartHitConfigLength;
				this._PartHitConfigCache = new List<IPartHitConfig>(partHitConfigLength);
				for (int i = 0; i < partHitConfigLength; i++)
				{
					this._PartHitConfigCache.Add(IPartHitConfig.Create(this.Instance.PartHitConfig(i)));
				}
				return this._PartHitConfigCache;
			}
		}

		// Token: 0x040028A5 RID: 10405
		private IHitLogicChangeByPartHit Instance;

		// Token: 0x040028A6 RID: 10406
		private List<IPartHitConfig> _PartHitConfigCache;

		// Token: 0x040028A7 RID: 10407
		private bool _PartHitConfigInited;
	}
}
