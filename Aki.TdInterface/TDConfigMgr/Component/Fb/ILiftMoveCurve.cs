using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CA6 RID: 3238
	public class ILiftMoveCurve
	{
		// Token: 0x06004A0A RID: 18954 RVA: 0x000BA741 File Offset: 0x000B8941
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

		// Token: 0x170014B9 RID: 5305
		// (get) Token: 0x06004A0B RID: 18955 RVA: 0x000BA760 File Offset: 0x000B8960
		public virtual string Curve
		{
			get
			{
				return this.Instance.Curve;
			}
		}

		// Token: 0x170014BA RID: 5306
		// (get) Token: 0x06004A0C RID: 18956 RVA: 0x000BA76D File Offset: 0x000B896D
		public virtual float Time
		{
			get
			{
				return this.Instance.Time;
			}
		}

		// Token: 0x040029FB RID: 10747
		private ILiftMoveCurve Instance;
	}
}
