using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B8E RID: 2958
	[NullableContext(1)]
	[Nullable(0)]
	public class IHitLogicChangeByPartHit : IHitLogicType
	{
		// Token: 0x06004401 RID: 17409 RVA: 0x000ACF6E File Offset: 0x000AB16E
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

		// Token: 0x170012A2 RID: 4770
		// (get) Token: 0x06004402 RID: 17410 RVA: 0x000ACF8D File Offset: 0x000AB18D
		public override EHitLogicType Type
		{
			get
			{
				return (EHitLogicType)this.Instance.Type;
			}
		}

		// Token: 0x170012A3 RID: 4771
		// (get) Token: 0x06004403 RID: 17411 RVA: 0x000ACF9C File Offset: 0x000AB19C
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

		// Token: 0x0400265D RID: 9821
		private IHitLogicChangeByPartHit Instance;

		// Token: 0x0400265E RID: 9822
		private List<IPartHitConfig> _PartHitConfigCache;

		// Token: 0x0400265F RID: 9823
		private bool _PartHitConfigInited;
	}
}
