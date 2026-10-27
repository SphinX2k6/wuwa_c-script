using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BD7 RID: 3031
	[NullableContext(1)]
	[Nullable(0)]
	public class ILiftMoveCurve
	{
		// Token: 0x060045AC RID: 17836 RVA: 0x000B05C5 File Offset: 0x000AE7C5
		public static ILiftMoveCurve Create(ILiftMoveCurve? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiftMoveCurve
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170013BB RID: 5051
		// (get) Token: 0x060045AD RID: 17837 RVA: 0x000B05E4 File Offset: 0x000AE7E4
		public virtual string Curve
		{
			get
			{
				return this.Instance.Curve;
			}
		}

		// Token: 0x170013BC RID: 5052
		// (get) Token: 0x060045AE RID: 17838 RVA: 0x000B05F1 File Offset: 0x000AE7F1
		public virtual float Time
		{
			get
			{
				return this.Instance.Time;
			}
		}

		// Token: 0x040027B0 RID: 10160
		private ILiftMoveCurve Instance;
	}
}
