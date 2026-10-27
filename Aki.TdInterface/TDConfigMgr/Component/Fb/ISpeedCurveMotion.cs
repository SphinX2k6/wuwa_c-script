using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B46 RID: 2886
	[NullableContext(2)]
	[Nullable(0)]
	public class ISpeedCurveMotion
	{
		// Token: 0x0600427E RID: 17022 RVA: 0x000AA00A File Offset: 0x000A820A
		[NullableContext(1)]
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

		// Token: 0x170011AF RID: 4527
		// (get) Token: 0x0600427F RID: 17023 RVA: 0x000AA029 File Offset: 0x000A8229
		public virtual string SpeedCurve
		{
			get
			{
				return this.Instance.SpeedCurve;
			}
		}

		// Token: 0x04002575 RID: 9589
		private ISpeedCurveMotion Instance;
	}
}
