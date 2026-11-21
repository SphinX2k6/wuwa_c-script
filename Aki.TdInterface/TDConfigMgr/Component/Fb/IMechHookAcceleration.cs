using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BD5 RID: 3029
	public class IMechHookAcceleration
	{
		// Token: 0x06004583 RID: 17795 RVA: 0x000B156A File Offset: 0x000AF76A
		public static IMechHookAcceleration Create(IMechHookAcceleration? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechHookAcceleration
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170011D4 RID: 4564
		// (get) Token: 0x06004584 RID: 17796 RVA: 0x000B1589 File Offset: 0x000AF789
		public virtual int MaxSpeed
		{
			get
			{
				return this.Instance.MaxSpeed;
			}
		}

		// Token: 0x170011D5 RID: 4565
		// (get) Token: 0x06004585 RID: 17797 RVA: 0x000B1596 File Offset: 0x000AF796
		public virtual string SpeedSampleCurve
		{
			get
			{
				return this.Instance.SpeedSampleCurve;
			}
		}

		// Token: 0x040026F6 RID: 9974
		private IMechHookAcceleration Instance;
	}
}
