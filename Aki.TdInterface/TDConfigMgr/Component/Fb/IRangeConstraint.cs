using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000EAD RID: 3757
	public class IRangeConstraint
	{
		// Token: 0x060054BC RID: 21692 RVA: 0x000D08E9 File Offset: 0x000CEAE9
		public static IRangeConstraint Create(IRangeConstraint? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRangeConstraint
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001B5D RID: 7005
		// (get) Token: 0x060054BD RID: 21693 RVA: 0x000D0908 File Offset: 0x000CEB08
		public virtual ERangeConstraint Type
		{
			get
			{
				return (ERangeConstraint)this.Instance.Type;
			}
		}

		// Token: 0x0400306E RID: 12398
		private IRangeConstraint Instance;
	}
}
