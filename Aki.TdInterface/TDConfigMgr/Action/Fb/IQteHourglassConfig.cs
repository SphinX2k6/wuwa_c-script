using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200286C RID: 10348
	[NullableContext(1)]
	[Nullable(0)]
	public class IQteHourglassConfig
	{
		// Token: 0x0600E54E RID: 58702 RVA: 0x0021B819 File Offset: 0x00219A19
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

		// Token: 0x17004638 RID: 17976
		// (get) Token: 0x0600E54F RID: 58703 RVA: 0x0021B838 File Offset: 0x00219A38
		public virtual int QteId
		{
			get
			{
				return this.Instance.QteId;
			}
		}

		// Token: 0x17004639 RID: 17977
		// (get) Token: 0x0600E550 RID: 58704 RVA: 0x0021B845 File Offset: 0x00219A45
		public virtual float TrailTime
		{
			get
			{
				return this.Instance.TrailTime;
			}
		}

		// Token: 0x1700463A RID: 17978
		// (get) Token: 0x0600E551 RID: 58705 RVA: 0x0021B852 File Offset: 0x00219A52
		public virtual string TrailCurveX
		{
			get
			{
				return this.Instance.TrailCurveX;
			}
		}

		// Token: 0x1700463B RID: 17979
		// (get) Token: 0x0600E552 RID: 58706 RVA: 0x0021B85F File Offset: 0x00219A5F
		public virtual string TrailCurveY
		{
			get
			{
				return this.Instance.TrailCurveY;
			}
		}

		// Token: 0x04007ECE RID: 32462
		private IQteHourglassConfig Instance;
	}
}
