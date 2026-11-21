using System;

namespace System
{
	// Token: 0x020000DC RID: 220
	[AttributeUsage(AttributeTargets.Class, Inherited = true)]
	public sealed class AttributeUsageAttribute : Attribute
	{
		// Token: 0x06000A4E RID: 2638 RVA: 0x0001F054 File Offset: 0x0001D254
		public AttributeUsageAttribute(AttributeTargets validOn)
		{
			this._attributeTarget = validOn;
			this._inherited = true;
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000A4F RID: 2639 RVA: 0x0001F06A File Offset: 0x0001D26A
		public AttributeTargets ValidOn
		{
			get
			{
				return this._attributeTarget;
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000A50 RID: 2640 RVA: 0x0001F072 File Offset: 0x0001D272
		// (set) Token: 0x06000A51 RID: 2641 RVA: 0x0001F07A File Offset: 0x0001D27A
		public bool AllowMultiple
		{
			get
			{
				return this._allowMultiple;
			}
			set
			{
				this._allowMultiple = value;
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000A52 RID: 2642 RVA: 0x0001F083 File Offset: 0x0001D283
		// (set) Token: 0x06000A53 RID: 2643 RVA: 0x0001F08B File Offset: 0x0001D28B
		public bool Inherited
		{
			get
			{
				return this._inherited;
			}
			set
			{
				this._inherited = value;
			}
		}

		// Token: 0x040002FA RID: 762
		private readonly AttributeTargets _attributeTarget;

		// Token: 0x040002FB RID: 763
		private bool _allowMultiple;

		// Token: 0x040002FC RID: 764
		private bool _inherited;
	}
}
