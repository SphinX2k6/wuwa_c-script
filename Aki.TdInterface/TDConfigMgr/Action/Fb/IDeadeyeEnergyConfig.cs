using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DAB RID: 11691
	public class IDeadeyeEnergyConfig
	{
		// Token: 0x0600FEB7 RID: 65207 RVA: 0x0024BB13 File Offset: 0x00249D13
		public static IDeadeyeEnergyConfig Create(IDeadeyeEnergyConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDeadeyeEnergyConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700500F RID: 20495
		// (get) Token: 0x0600FEB8 RID: 65208 RVA: 0x0024BB32 File Offset: 0x00249D32
		public virtual int MaxEnergy
		{
			get
			{
				return this.Instance.MaxEnergy;
			}
		}

		// Token: 0x17005010 RID: 20496
		// (get) Token: 0x0600FEB9 RID: 65209 RVA: 0x0024BB3F File Offset: 0x00249D3F
		public virtual int BulletConsumption
		{
			get
			{
				return this.Instance.BulletConsumption;
			}
		}

		// Token: 0x17005011 RID: 20497
		// (get) Token: 0x0600FEBA RID: 65210 RVA: 0x0024BB4C File Offset: 0x00249D4C
		public virtual int TimeConsumption
		{
			get
			{
				return this.Instance.TimeConsumption;
			}
		}

		// Token: 0x04008B09 RID: 35593
		private IDeadeyeEnergyConfig Instance;
	}
}
