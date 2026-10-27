using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005115 RID: 20757
	public class IEffectSplineT
	{
		// Token: 0x1700973D RID: 38717
		// (get) Token: 0x06021734 RID: 137012 RVA: 0x004A4E95 File Offset: 0x004A3095
		// (set) Token: 0x06021735 RID: 137013 RVA: 0x004A4E9D File Offset: 0x004A309D
		public ESplineType Type { get; set; }

		// Token: 0x1700973E RID: 38718
		// (get) Token: 0x06021736 RID: 137014 RVA: 0x004A4EA6 File Offset: 0x004A30A6
		// (set) Token: 0x06021737 RID: 137015 RVA: 0x004A4EAE File Offset: 0x004A30AE
		public string Effect { get; set; }

		// Token: 0x1700973F RID: 38719
		// (get) Token: 0x06021738 RID: 137016 RVA: 0x004A4EB7 File Offset: 0x004A30B7
		// (set) Token: 0x06021739 RID: 137017 RVA: 0x004A4EBF File Offset: 0x004A30BF
		public TEffectSplineCreateOptionUnion CreateOption { get; set; }

		// Token: 0x17009740 RID: 38720
		// (get) Token: 0x0602173A RID: 137018 RVA: 0x004A4EC8 File Offset: 0x004A30C8
		// (set) Token: 0x0602173B RID: 137019 RVA: 0x004A4ED0 File Offset: 0x004A30D0
		public List<ICommonSplinePointT> Points { get; set; }

		// Token: 0x0602173C RID: 137020 RVA: 0x004A4ED9 File Offset: 0x004A30D9
		public IEffectSplineT()
		{
			this.Type = ESplineType.Common;
			this.Effect = null;
			this.CreateOption = null;
			this.Points = null;
		}
	}
}
