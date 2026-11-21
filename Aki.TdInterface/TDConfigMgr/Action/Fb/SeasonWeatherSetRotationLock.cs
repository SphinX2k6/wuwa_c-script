using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002E04 RID: 11780
	public class SeasonWeatherSetRotationLock : ActionParams
	{
		// Token: 0x0601000D RID: 65549 RVA: 0x0024DC09 File Offset: 0x0024BE09
		public static SeasonWeatherSetRotationLock Create(ISeasonWeatherSetRotationLock? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SeasonWeatherSetRotationLock
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170050B3 RID: 20659
		// (get) Token: 0x0601000E RID: 65550 RVA: 0x0024DC28 File Offset: 0x0024BE28
		public virtual bool IsLocked
		{
			get
			{
				return this.Instance.IsLocked;
			}
		}

		// Token: 0x04008BBE RID: 35774
		private ISeasonWeatherSetRotationLock Instance;
	}
}
