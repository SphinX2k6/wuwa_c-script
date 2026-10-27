using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005809 RID: 22537
	public class IRangeSplineT
	{
		// Token: 0x1700A85C RID: 43100
		// (get) Token: 0x06025E3F RID: 155199 RVA: 0x00539B9D File Offset: 0x00537D9D
		// (set) Token: 0x06025E40 RID: 155200 RVA: 0x00539BA5 File Offset: 0x00537DA5
		public ESplineType Type { get; set; }

		// Token: 0x1700A85D RID: 43101
		// (get) Token: 0x06025E41 RID: 155201 RVA: 0x00539BAE File Offset: 0x00537DAE
		// (set) Token: 0x06025E42 RID: 155202 RVA: 0x00539BB6 File Offset: 0x00537DB6
		public float Height { get; set; }

		// Token: 0x1700A85E RID: 43102
		// (get) Token: 0x06025E43 RID: 155203 RVA: 0x00539BBF File Offset: 0x00537DBF
		// (set) Token: 0x06025E44 RID: 155204 RVA: 0x00539BC7 File Offset: 0x00537DC7
		public List<ICommonSplinePointT> Points { get; set; }

		// Token: 0x06025E45 RID: 155205 RVA: 0x00539BD0 File Offset: 0x00537DD0
		public IRangeSplineT()
		{
			this.Type = ESplineType.Common;
			this.Height = 0f;
			this.Points = null;
		}
	}
}
