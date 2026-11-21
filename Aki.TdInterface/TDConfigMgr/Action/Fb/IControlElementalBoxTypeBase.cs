using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DF8 RID: 11768
	public class IControlElementalBoxTypeBase
	{
		// Token: 0x0600FFE0 RID: 65504 RVA: 0x0024D875 File Offset: 0x0024BA75
		public static IControlElementalBoxTypeBase Create(IControlElementalBoxTypeBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IControlElementalBoxTypeBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700509E RID: 20638
		// (get) Token: 0x0600FFE1 RID: 65505 RVA: 0x0024D894 File Offset: 0x0024BA94
		public virtual EControlElementalBoxType Type
		{
			get
			{
				return (EControlElementalBoxType)this.Instance.Type;
			}
		}

		// Token: 0x04008BA8 RID: 35752
		private IControlElementalBoxTypeBase Instance;
	}
}
