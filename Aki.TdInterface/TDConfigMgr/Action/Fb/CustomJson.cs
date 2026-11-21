using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C84 RID: 11396
	public class CustomJson : ActionParams
	{
		// Token: 0x0600FA41 RID: 64065 RVA: 0x00244F0B File Offset: 0x0024310B
		public static CustomJson Create(ICustomJson? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new CustomJson
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004DE7 RID: 19943
		// (get) Token: 0x0600FA42 RID: 64066 RVA: 0x00244F2A File Offset: 0x0024312A
		public virtual string Name
		{
			get
			{
				return this.Instance.Name;
			}
		}

		// Token: 0x17004DE8 RID: 19944
		// (get) Token: 0x0600FA43 RID: 64067 RVA: 0x00244F37 File Offset: 0x00243137
		public virtual string JsonString
		{
			get
			{
				return this.Instance.JsonString;
			}
		}

		// Token: 0x040088B8 RID: 35000
		private ICustomJson Instance;
	}
}
