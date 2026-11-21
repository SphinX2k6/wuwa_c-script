using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027C2 RID: 10178
	public class IActionMontage
	{
		// Token: 0x0600E140 RID: 57664 RVA: 0x00211E19 File Offset: 0x00210019
		public static IActionMontage Create(IActionMontage? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActionMontage
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003E6A RID: 15978
		// (get) Token: 0x0600E141 RID: 57665 RVA: 0x00211E38 File Offset: 0x00210038
		public virtual EActionMontageType MontageType
		{
			get
			{
				return (EActionMontageType)this.Instance.MontageType;
			}
		}

		// Token: 0x17003E6B RID: 15979
		// (get) Token: 0x0600E142 RID: 57666 RVA: 0x00211E45 File Offset: 0x00210045
		public virtual string Path
		{
			get
			{
				return this.Instance.Path;
			}
		}

		// Token: 0x04007A70 RID: 31344
		private IActionMontage Instance;
	}
}
