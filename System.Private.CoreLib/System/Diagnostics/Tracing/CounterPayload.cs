using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Diagnostics.Tracing
{
	// Token: 0x020008CD RID: 2253
	[EventData]
	internal sealed class CounterPayload : IEnumerable<KeyValuePair<string, object>>, IEnumerable
	{
		// Token: 0x1700126D RID: 4717
		// (get) Token: 0x06008B22 RID: 35618 RVA: 0x001501BE File Offset: 0x0014E3BE
		// (set) Token: 0x06008B23 RID: 35619 RVA: 0x001501C6 File Offset: 0x0014E3C6
		public string Name { get; set; }

		// Token: 0x1700126E RID: 4718
		// (get) Token: 0x06008B24 RID: 35620 RVA: 0x001501CF File Offset: 0x0014E3CF
		// (set) Token: 0x06008B25 RID: 35621 RVA: 0x001501D7 File Offset: 0x0014E3D7
		public string DisplayName { get; set; }

		// Token: 0x1700126F RID: 4719
		// (get) Token: 0x06008B26 RID: 35622 RVA: 0x001501E0 File Offset: 0x0014E3E0
		// (set) Token: 0x06008B27 RID: 35623 RVA: 0x001501E8 File Offset: 0x0014E3E8
		public double Mean { get; set; }

		// Token: 0x17001270 RID: 4720
		// (get) Token: 0x06008B28 RID: 35624 RVA: 0x001501F1 File Offset: 0x0014E3F1
		// (set) Token: 0x06008B29 RID: 35625 RVA: 0x001501F9 File Offset: 0x0014E3F9
		public double StandardDeviation { get; set; }

		// Token: 0x17001271 RID: 4721
		// (get) Token: 0x06008B2A RID: 35626 RVA: 0x00150202 File Offset: 0x0014E402
		// (set) Token: 0x06008B2B RID: 35627 RVA: 0x0015020A File Offset: 0x0014E40A
		public int Count { get; set; }

		// Token: 0x17001272 RID: 4722
		// (get) Token: 0x06008B2C RID: 35628 RVA: 0x00150213 File Offset: 0x0014E413
		// (set) Token: 0x06008B2D RID: 35629 RVA: 0x0015021B File Offset: 0x0014E41B
		public double Min { get; set; }

		// Token: 0x17001273 RID: 4723
		// (get) Token: 0x06008B2E RID: 35630 RVA: 0x00150224 File Offset: 0x0014E424
		// (set) Token: 0x06008B2F RID: 35631 RVA: 0x0015022C File Offset: 0x0014E42C
		public double Max { get; set; }

		// Token: 0x17001274 RID: 4724
		// (get) Token: 0x06008B30 RID: 35632 RVA: 0x00150235 File Offset: 0x0014E435
		// (set) Token: 0x06008B31 RID: 35633 RVA: 0x0015023D File Offset: 0x0014E43D
		public float IntervalSec { get; internal set; }

		// Token: 0x17001275 RID: 4725
		// (get) Token: 0x06008B32 RID: 35634 RVA: 0x00150246 File Offset: 0x0014E446
		// (set) Token: 0x06008B33 RID: 35635 RVA: 0x0015024E File Offset: 0x0014E44E
		public string Series { get; set; }

		// Token: 0x17001276 RID: 4726
		// (get) Token: 0x06008B34 RID: 35636 RVA: 0x00150257 File Offset: 0x0014E457
		// (set) Token: 0x06008B35 RID: 35637 RVA: 0x0015025F File Offset: 0x0014E45F
		public string CounterType { get; set; }

		// Token: 0x17001277 RID: 4727
		// (get) Token: 0x06008B36 RID: 35638 RVA: 0x00150268 File Offset: 0x0014E468
		// (set) Token: 0x06008B37 RID: 35639 RVA: 0x00150270 File Offset: 0x0014E470
		public string Metadata { get; set; }

		// Token: 0x17001278 RID: 4728
		// (get) Token: 0x06008B38 RID: 35640 RVA: 0x00150279 File Offset: 0x0014E479
		// (set) Token: 0x06008B39 RID: 35641 RVA: 0x00150281 File Offset: 0x0014E481
		public string DisplayUnits { get; set; }

		// Token: 0x06008B3A RID: 35642 RVA: 0x0015028A File Offset: 0x0014E48A
		public IEnumerator<KeyValuePair<string, object>> GetEnumerator()
		{
			return this.ForEnumeration.GetEnumerator();
		}

		// Token: 0x06008B3B RID: 35643 RVA: 0x0015028A File Offset: 0x0014E48A
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.ForEnumeration.GetEnumerator();
		}

		// Token: 0x17001279 RID: 4729
		// (get) Token: 0x06008B3C RID: 35644 RVA: 0x00150297 File Offset: 0x0014E497
		private IEnumerable<KeyValuePair<string, object>> ForEnumeration
		{
			get
			{
				yield return new KeyValuePair<string, object>("Name", this.Name);
				yield return new KeyValuePair<string, object>("DisplayName", this.DisplayName);
				yield return new KeyValuePair<string, object>("DisplayUnits", this.DisplayUnits);
				yield return new KeyValuePair<string, object>("Mean", this.Mean);
				yield return new KeyValuePair<string, object>("StandardDeviation", this.StandardDeviation);
				yield return new KeyValuePair<string, object>("Count", this.Count);
				yield return new KeyValuePair<string, object>("Min", this.Min);
				yield return new KeyValuePair<string, object>("Max", this.Max);
				yield return new KeyValuePair<string, object>("IntervalSec", this.IntervalSec);
				string key = "Series";
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Interval=");
				defaultInterpolatedStringHandler.AppendFormatted<float>(this.IntervalSec);
				yield return new KeyValuePair<string, object>(key, defaultInterpolatedStringHandler.ToStringAndClear());
				yield return new KeyValuePair<string, object>("CounterType", "Mean");
				yield return new KeyValuePair<string, object>("Metadata", this.Metadata);
				yield break;
			}
		}
	}
}
