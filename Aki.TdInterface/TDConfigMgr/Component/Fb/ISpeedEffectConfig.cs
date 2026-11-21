using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E3E RID: 3646
	public class ISpeedEffectConfig
	{
		// Token: 0x06005290 RID: 21136 RVA: 0x000CC1A1 File Offset: 0x000CA3A1
		public static ISpeedEffectConfig Create(ISpeedEffectConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISpeedEffectConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001A0F RID: 6671
		// (get) Token: 0x06005291 RID: 21137 RVA: 0x000CC1C0 File Offset: 0x000CA3C0
		public virtual float MinVehicleSpeed
		{
			get
			{
				return this.Instance.MinVehicleSpeed;
			}
		}

		// Token: 0x17001A10 RID: 6672
		// (get) Token: 0x06005292 RID: 21138 RVA: 0x000CC1CD File Offset: 0x000CA3CD
		public virtual float MaxVehicleSpeed
		{
			get
			{
				return this.Instance.MaxVehicleSpeed;
			}
		}

		// Token: 0x17001A11 RID: 6673
		// (get) Token: 0x06005293 RID: 21139 RVA: 0x000CC1DC File Offset: 0x000CA3DC
		public virtual List<long> GameplayCueIds
		{
			get
			{
				if (this._GameplayCueIdsInited)
				{
					return this._GameplayCueIdsCache;
				}
				this._GameplayCueIdsInited = true;
				int gameplayCueIdsLength = this.Instance.GameplayCueIdsLength;
				this._GameplayCueIdsCache = new List<long>(gameplayCueIdsLength);
				for (int i = 0; i < gameplayCueIdsLength; i++)
				{
					this._GameplayCueIdsCache.Add(this.Instance.GameplayCueIds(i));
				}
				return this._GameplayCueIdsCache;
			}
		}

		// Token: 0x04002F25 RID: 12069
		private ISpeedEffectConfig Instance;

		// Token: 0x04002F26 RID: 12070
		private List<long> _GameplayCueIdsCache;

		// Token: 0x04002F27 RID: 12071
		private bool _GameplayCueIdsInited;
	}
}
