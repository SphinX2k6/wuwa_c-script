using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AB7 RID: 10935
	public class IDeadeyeEnergyConfig
	{
		// Token: 0x0600F001 RID: 61441 RVA: 0x0022DE07 File Offset: 0x0022C007
		[NullableContext(1)]
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

		// Token: 0x17004C55 RID: 19541
		// (get) Token: 0x0600F002 RID: 61442 RVA: 0x0022DE26 File Offset: 0x0022C026
		public virtual int MaxEnergy
		{
			get
			{
				return this.Instance.MaxEnergy;
			}
		}

		// Token: 0x17004C56 RID: 19542
		// (get) Token: 0x0600F003 RID: 61443 RVA: 0x0022DE33 File Offset: 0x0022C033
		public virtual int BulletConsumption
		{
			get
			{
				return this.Instance.BulletConsumption;
			}
		}

		// Token: 0x17004C57 RID: 19543
		// (get) Token: 0x0600F004 RID: 61444 RVA: 0x0022DE40 File Offset: 0x0022C040
		public virtual int TimeConsumption
		{
			get
			{
				return this.Instance.TimeConsumption;
			}
		}

		// Token: 0x04008405 RID: 33797
		private IDeadeyeEnergyConfig Instance;
	}
}
