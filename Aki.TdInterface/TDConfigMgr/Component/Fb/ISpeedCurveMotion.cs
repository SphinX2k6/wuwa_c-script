using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C14 RID: 3092
	public class ISpeedCurveMotion
	{
		// Token: 0x060046D7 RID: 18135 RVA: 0x000B40CE File Offset: 0x000B22CE
		public static ISpeedCurveMotion Create(ISpeedCurveMotion? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISpeedCurveMotion
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170012AA RID: 4778
		// (get) Token: 0x060046D8 RID: 18136 RVA: 0x000B40ED File Offset: 0x000B22ED
		[Nullable(2)]
		public virtual string SpeedCurve
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.SpeedCurve;
			}
		}

		// Token: 0x040027BD RID: 10173
		private ISpeedCurveMotion Instance;
	}
}
