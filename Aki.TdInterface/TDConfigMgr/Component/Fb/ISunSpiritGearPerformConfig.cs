using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000EB6 RID: 3766
	public class ISunSpiritGearPerformConfig
	{
		// Token: 0x060054EC RID: 21740 RVA: 0x000D0F09 File Offset: 0x000CF109
		public static ISunSpiritGearPerformConfig Create(ISunSpiritGearPerformConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISunSpiritGearPerformConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001B7B RID: 7035
		// (get) Token: 0x060054ED RID: 21741 RVA: 0x000D0F28 File Offset: 0x000CF128
		public virtual ESunSpiritGearPerformType Type
		{
			get
			{
				return (ESunSpiritGearPerformType)this.Instance.Type;
			}
		}

		// Token: 0x0400308B RID: 12427
		private ISunSpiritGearPerformConfig Instance;
	}
}
