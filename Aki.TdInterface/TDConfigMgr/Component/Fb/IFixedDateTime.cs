using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B81 RID: 2945
	public class IFixedDateTime
	{
		// Token: 0x06004363 RID: 17251 RVA: 0x000AAFB2 File Offset: 0x000A91B2
		public static IFixedDateTime Create(IFixedDateTime? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFixedDateTime
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700105C RID: 4188
		// (get) Token: 0x06004364 RID: 17252 RVA: 0x000AAFD1 File Offset: 0x000A91D1
		public virtual int Hours
		{
			get
			{
				return this.Instance.Hours;
			}
		}

		// Token: 0x1700105D RID: 4189
		// (get) Token: 0x06004365 RID: 17253 RVA: 0x000AAFDE File Offset: 0x000A91DE
		public virtual int Minutes
		{
			get
			{
				return this.Instance.Minutes;
			}
		}

		// Token: 0x1700105E RID: 4190
		// (get) Token: 0x06004366 RID: 17254 RVA: 0x000AAFEB File Offset: 0x000A91EB
		public virtual int Seconds
		{
			get
			{
				return this.Instance.Seconds;
			}
		}

		// Token: 0x04002538 RID: 9528
		private IFixedDateTime Instance;
	}
}
