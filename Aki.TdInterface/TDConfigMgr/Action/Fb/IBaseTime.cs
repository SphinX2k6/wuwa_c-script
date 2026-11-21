using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200289C RID: 10396
	public class IBaseTime
	{
		// Token: 0x0600E7AB RID: 59307 RVA: 0x002244B2 File Offset: 0x002226B2
		public static IBaseTime Create(IBaseTime? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBaseTime
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004321 RID: 17185
		// (get) Token: 0x0600E7AC RID: 59308 RVA: 0x002244D1 File Offset: 0x002226D1
		public virtual int Hour
		{
			get
			{
				return this.Instance.Hour;
			}
		}

		// Token: 0x17004322 RID: 17186
		// (get) Token: 0x0600E7AD RID: 59309 RVA: 0x002244DE File Offset: 0x002226DE
		public virtual int Minute
		{
			get
			{
				return this.Instance.Minute;
			}
		}

		// Token: 0x04007F9A RID: 32666
		private IBaseTime Instance;
	}
}
