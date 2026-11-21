using System;
using System.Reflection;

namespace System.Diagnostics.Tracing
{
	// Token: 0x020008FE RID: 2302
	[DefaultMember("Item")]
	internal struct SessionMask
	{
		// Token: 0x06008CEB RID: 36075 RVA: 0x00159824 File Offset: 0x00157A24
		public SessionMask(uint mask = 0U)
		{
			this.m_mask = (mask & 15U);
		}

		// Token: 0x170012D4 RID: 4820
		// (get) Token: 0x06008CEC RID: 36076 RVA: 0x00159830 File Offset: 0x00157A30
		public static SessionMask All
		{
			get
			{
				return new SessionMask(15U);
			}
		}

		// Token: 0x06008CED RID: 36077 RVA: 0x00159839 File Offset: 0x00157A39
		public ulong ToEventKeywords()
		{
			return (ulong)this.m_mask << 44;
		}

		// Token: 0x06008CEE RID: 36078 RVA: 0x00159845 File Offset: 0x00157A45
		public static SessionMask FromEventKeywords(ulong m)
		{
			return new SessionMask((uint)(m >> 44));
		}

		// Token: 0x06008CEF RID: 36079 RVA: 0x00159851 File Offset: 0x00157A51
		public static explicit operator uint(SessionMask m)
		{
			return m.m_mask;
		}

		// Token: 0x0400202F RID: 8239
		private uint m_mask;
	}
}
