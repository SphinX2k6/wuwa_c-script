using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002E05 RID: 11781
	public class SeasonWeatherChangeTo : ActionParams
	{
		// Token: 0x06010010 RID: 65552 RVA: 0x0024DC3D File Offset: 0x0024BE3D
		public static SeasonWeatherChangeTo Create(ISeasonWeatherChangeTo? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SeasonWeatherChangeTo
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170050B4 RID: 20660
		// (get) Token: 0x06010011 RID: 65553 RVA: 0x0024DC5C File Offset: 0x0024BE5C
		public virtual int Season
		{
			get
			{
				return this.Instance.Season;
			}
		}

		// Token: 0x170050B5 RID: 20661
		// (get) Token: 0x06010012 RID: 65554 RVA: 0x0024DC6C File Offset: 0x0024BE6C
		public virtual int? Weather
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.Weather);
			}
		}

		// Token: 0x04008BBF RID: 35775
		private ISeasonWeatherChangeTo Instance;
	}
}
