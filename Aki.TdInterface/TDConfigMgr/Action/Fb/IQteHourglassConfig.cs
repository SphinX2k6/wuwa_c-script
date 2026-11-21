using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B42 RID: 11074
	public class IQteHourglassConfig
	{
		// Token: 0x0600F37E RID: 62334 RVA: 0x00238733 File Offset: 0x00236933
		public static IQteHourglassConfig Create(IQteHourglassConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQteHourglassConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170049A8 RID: 18856
		// (get) Token: 0x0600F37F RID: 62335 RVA: 0x00238752 File Offset: 0x00236952
		public virtual int QteId
		{
			get
			{
				return this.Instance.QteId;
			}
		}

		// Token: 0x170049A9 RID: 18857
		// (get) Token: 0x0600F380 RID: 62336 RVA: 0x0023875F File Offset: 0x0023695F
		public virtual float TrailTime
		{
			get
			{
				return this.Instance.TrailTime;
			}
		}

		// Token: 0x170049AA RID: 18858
		// (get) Token: 0x0600F381 RID: 62337 RVA: 0x0023876C File Offset: 0x0023696C
		public virtual string TrailCurveX
		{
			get
			{
				return this.Instance.TrailCurveX;
			}
		}

		// Token: 0x170049AB RID: 18859
		// (get) Token: 0x0600F382 RID: 62338 RVA: 0x00238779 File Offset: 0x00236979
		public virtual string TrailCurveY
		{
			get
			{
				return this.Instance.TrailCurveY;
			}
		}

		// Token: 0x0400858E RID: 34190
		private IQteHourglassConfig Instance;
	}
}
