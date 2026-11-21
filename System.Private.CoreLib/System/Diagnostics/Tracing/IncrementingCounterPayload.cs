using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Diagnostics.Tracing
{
	// Token: 0x020008CF RID: 2255
	[EventData]
	internal sealed class IncrementingCounterPayload : IEnumerable<KeyValuePair<string, object>>, IEnumerable
	{
		// Token: 0x1700127C RID: 4732
		// (get) Token: 0x06008B46 RID: 35654 RVA: 0x00150593 File Offset: 0x0014E793
		// (set) Token: 0x06008B47 RID: 35655 RVA: 0x0015059B File Offset: 0x0014E79B
		public string Name { get; set; }

		// Token: 0x1700127D RID: 4733
		// (get) Token: 0x06008B48 RID: 35656 RVA: 0x001505A4 File Offset: 0x0014E7A4
		// (set) Token: 0x06008B49 RID: 35657 RVA: 0x001505AC File Offset: 0x0014E7AC
		public string DisplayName { get; set; }

		// Token: 0x1700127E RID: 4734
		// (get) Token: 0x06008B4A RID: 35658 RVA: 0x001505B5 File Offset: 0x0014E7B5
		// (set) Token: 0x06008B4B RID: 35659 RVA: 0x001505BD File Offset: 0x0014E7BD
		public string DisplayRateTimeScale { get; set; }

		// Token: 0x1700127F RID: 4735
		// (get) Token: 0x06008B4C RID: 35660 RVA: 0x001505C6 File Offset: 0x0014E7C6
		// (set) Token: 0x06008B4D RID: 35661 RVA: 0x001505CE File Offset: 0x0014E7CE
		public double Increment { get; set; }

		// Token: 0x17001280 RID: 4736
		// (get) Token: 0x06008B4E RID: 35662 RVA: 0x001505D7 File Offset: 0x0014E7D7
		// (set) Token: 0x06008B4F RID: 35663 RVA: 0x001505DF File Offset: 0x0014E7DF
		public float IntervalSec { get; internal set; }

		// Token: 0x17001281 RID: 4737
		// (get) Token: 0x06008B50 RID: 35664 RVA: 0x001505E8 File Offset: 0x0014E7E8
		// (set) Token: 0x06008B51 RID: 35665 RVA: 0x001505F0 File Offset: 0x0014E7F0
		public string Metadata { get; set; }

		// Token: 0x17001282 RID: 4738
		// (get) Token: 0x06008B52 RID: 35666 RVA: 0x001505F9 File Offset: 0x0014E7F9
		// (set) Token: 0x06008B53 RID: 35667 RVA: 0x00150601 File Offset: 0x0014E801
		public string Series { get; set; }

		// Token: 0x17001283 RID: 4739
		// (get) Token: 0x06008B54 RID: 35668 RVA: 0x0015060A File Offset: 0x0014E80A
		// (set) Token: 0x06008B55 RID: 35669 RVA: 0x00150612 File Offset: 0x0014E812
		public string CounterType { get; set; }

		// Token: 0x17001284 RID: 4740
		// (get) Token: 0x06008B56 RID: 35670 RVA: 0x0015061B File Offset: 0x0014E81B
		// (set) Token: 0x06008B57 RID: 35671 RVA: 0x00150623 File Offset: 0x0014E823
		public string DisplayUnits { get; set; }

		// Token: 0x06008B58 RID: 35672 RVA: 0x0015062C File Offset: 0x0014E82C
		public IEnumerator<KeyValuePair<string, object>> GetEnumerator()
		{
			return this.ForEnumeration.GetEnumerator();
		}

		// Token: 0x06008B59 RID: 35673 RVA: 0x0015062C File Offset: 0x0014E82C
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.ForEnumeration.GetEnumerator();
		}

		// Token: 0x17001285 RID: 4741
		// (get) Token: 0x06008B5A RID: 35674 RVA: 0x00150639 File Offset: 0x0014E839
		private IEnumerable<KeyValuePair<string, object>> ForEnumeration
		{
			get
			{
				yield return new KeyValuePair<string, object>("Name", this.Name);
				yield return new KeyValuePair<string, object>("DisplayName", this.DisplayName);
				yield return new KeyValuePair<string, object>("DisplayRateTimeScale", this.DisplayRateTimeScale);
				yield return new KeyValuePair<string, object>("Increment", this.Increment);
				yield return new KeyValuePair<string, object>("IntervalSec", this.IntervalSec);
				string key = "Series";
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Interval=");
				defaultInterpolatedStringHandler.AppendFormatted<float>(this.IntervalSec);
				yield return new KeyValuePair<string, object>(key, defaultInterpolatedStringHandler.ToStringAndClear());
				yield return new KeyValuePair<string, object>("CounterType", "Sum");
				yield return new KeyValuePair<string, object>("Metadata", this.Metadata);
				yield return new KeyValuePair<string, object>("DisplayUnits", this.DisplayUnits);
				yield break;
			}
		}
	}
}
