using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058E4 RID: 22756
	public sealed class SolarSchoolSummaryData
	{
		// Token: 0x17006B9C RID: 27548
		// (get) Token: 0x0603817F RID: 229759 RVA: 0x00FADFBD File Offset: 0x00FAC1BD
		// (set) Token: 0x06038180 RID: 229760 RVA: 0x00FADFC5 File Offset: 0x00FAC1C5
		public int CompletedNoticeCount { get; private set; }

		// Token: 0x17006B9D RID: 27549
		// (get) Token: 0x06038181 RID: 229761 RVA: 0x00FADFCE File Offset: 0x00FAC1CE
		// (set) Token: 0x06038182 RID: 229762 RVA: 0x00FADFD6 File Offset: 0x00FAC1D6
		public int ManualPurchaseCount { get; private set; }

		// Token: 0x17006B9E RID: 27550
		// (get) Token: 0x06038183 RID: 229763 RVA: 0x00FADFDF File Offset: 0x00FAC1DF
		// (set) Token: 0x06038184 RID: 229764 RVA: 0x00FADFE7 File Offset: 0x00FAC1E7
		public int GainedMoney { get; private set; }

		// Token: 0x06038185 RID: 229765 RVA: 0x00FADFF0 File Offset: 0x00FAC1F0
		public int GetAttrChange(ESolarSchoolSecondAttr attr)
		{
			return this.AttrChanges.GetValueOrDefault(attr, 0);
		}

		// Token: 0x06038186 RID: 229766 RVA: 0x00FAE000 File Offset: 0x00FAC200
		public void AddAttrChange(ESolarSchoolSecondAttr attr, int value)
		{
			long value2 = (long)this.GetAttrChange(attr) + (long)value;
			this.SetAttrChange(attr, (int)Math.Clamp(value2, -2147483648L, 2147483647L));
		}

		// Token: 0x06038187 RID: 229767 RVA: 0x00FAE033 File Offset: 0x00FAC233
		public void AddCompletedNoticeCount(int count)
		{
			this.CompletedNoticeCount = (int)Math.Clamp((long)this.CompletedNoticeCount + (long)count, 0L, 2147483647L);
		}

		// Token: 0x06038188 RID: 229768 RVA: 0x00FAE053 File Offset: 0x00FAC253
		public void AddManualPurchaseCount(int count)
		{
			this.ManualPurchaseCount = (int)Math.Clamp((long)this.ManualPurchaseCount + (long)count, 0L, 2147483647L);
		}

		// Token: 0x06038189 RID: 229769 RVA: 0x00FAE073 File Offset: 0x00FAC273
		public void AddGainedMoney(int value)
		{
			this.GainedMoney = (int)Math.Clamp((long)this.GainedMoney + (long)value, 0L, 2147483647L);
		}

		// Token: 0x0603818A RID: 229770 RVA: 0x00FAE093 File Offset: 0x00FAC293
		public void Clear()
		{
			this.AttrChanges.Clear();
			this.CompletedNoticeCount = 0;
			this.ManualPurchaseCount = 0;
			this.GainedMoney = 0;
		}

		// Token: 0x0603818B RID: 229771 RVA: 0x00FAE0B5 File Offset: 0x00FAC2B5
		private void SetAttrChange(ESolarSchoolSecondAttr attr, int value)
		{
			if (value == 0)
			{
				this.AttrChanges.Remove(attr);
				return;
			}
			this.AttrChanges[attr] = value;
		}

		// Token: 0x0401D8D8 RID: 121048
		[Nullable(1)]
		private readonly Dictionary<ESolarSchoolSecondAttr, int> AttrChanges = new Dictionary<ESolarSchoolSecondAttr, int>();
	}
}
