using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D44 RID: 3396
	[NullableContext(1)]
	[Nullable(0)]
	public class ISpeedEffectConfig
	{
		// Token: 0x06004D74 RID: 19828 RVA: 0x000C0A5D File Offset: 0x000BEC5D
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

		// Token: 0x170018A9 RID: 6313
		// (get) Token: 0x06004D75 RID: 19829 RVA: 0x000C0A7C File Offset: 0x000BEC7C
		public virtual float MinVehicleSpeed
		{
			get
			{
				return this.Instance.MinVehicleSpeed;
			}
		}

		// Token: 0x170018AA RID: 6314
		// (get) Token: 0x06004D76 RID: 19830 RVA: 0x000C0A89 File Offset: 0x000BEC89
		public virtual float MaxVehicleSpeed
		{
			get
			{
				return this.Instance.MaxVehicleSpeed;
			}
		}

		// Token: 0x170018AB RID: 6315
		// (get) Token: 0x06004D77 RID: 19831 RVA: 0x000C0A98 File Offset: 0x000BEC98
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

		// Token: 0x04002C65 RID: 11365
		private ISpeedEffectConfig Instance;

		// Token: 0x04002C66 RID: 11366
		private List<long> _GameplayCueIdsCache;

		// Token: 0x04002C67 RID: 11367
		private bool _GameplayCueIdsInited;
	}
}
