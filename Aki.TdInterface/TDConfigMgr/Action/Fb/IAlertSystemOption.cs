using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CDA RID: 11482
	public class IAlertSystemOption
	{
		// Token: 0x0600FB95 RID: 64405 RVA: 0x00246ED8 File Offset: 0x002450D8
		public static IAlertSystemOption Create(IAlertSystemOption? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAlertSystemOption
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004E8F RID: 20111
		// (get) Token: 0x0600FB96 RID: 64406 RVA: 0x00246EF7 File Offset: 0x002450F7
		public virtual EAlertSystemOption Type
		{
			get
			{
				return (EAlertSystemOption)this.Instance.Type;
			}
		}

		// Token: 0x17004E90 RID: 20112
		// (get) Token: 0x0600FB97 RID: 64407 RVA: 0x00246F04 File Offset: 0x00245104
		public virtual int AreaId
		{
			get
			{
				return this.Instance.AreaId;
			}
		}

		// Token: 0x04008976 RID: 35190
		private IAlertSystemOption Instance;
	}
}
