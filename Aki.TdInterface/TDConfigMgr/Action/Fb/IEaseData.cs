using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A42 RID: 10818
	public class IEaseData
	{
		// Token: 0x0600EEF1 RID: 61169 RVA: 0x00230696 File Offset: 0x0022E896
		public static IEaseData Create(IEaseData? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEaseData
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700471B RID: 18203
		// (get) Token: 0x0600EEF2 RID: 61170 RVA: 0x002306B5 File Offset: 0x0022E8B5
		public virtual EEaseType Type
		{
			get
			{
				return (EEaseType)this.Instance.Type;
			}
		}

		// Token: 0x1700471C RID: 18204
		// (get) Token: 0x0600EEF3 RID: 61171 RVA: 0x002306C2 File Offset: 0x0022E8C2
		public virtual float Duration
		{
			get
			{
				return this.Instance.Duration;
			}
		}

		// Token: 0x04008334 RID: 33588
		private IEaseData Instance;
	}
}
