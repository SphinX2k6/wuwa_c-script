using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000EC1 RID: 3777
	public class ISnapAngleConfig
	{
		// Token: 0x06005521 RID: 21793 RVA: 0x000D14BA File Offset: 0x000CF6BA
		public static ISnapAngleConfig Create(ISnapAngleConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISnapAngleConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001B9A RID: 7066
		// (get) Token: 0x06005522 RID: 21794 RVA: 0x000D14D9 File Offset: 0x000CF6D9
		public virtual float Angle
		{
			get
			{
				return this.Instance.Angle;
			}
		}

		// Token: 0x17001B9B RID: 7067
		// (get) Token: 0x06005523 RID: 21795 RVA: 0x000D14E6 File Offset: 0x000CF6E6
		public virtual float Range
		{
			get
			{
				return this.Instance.Range;
			}
		}

		// Token: 0x040030A2 RID: 12450
		private ISnapAngleConfig Instance;
	}
}
