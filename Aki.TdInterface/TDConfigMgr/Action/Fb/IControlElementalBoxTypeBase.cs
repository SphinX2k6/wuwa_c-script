using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B04 RID: 11012
	public class IControlElementalBoxTypeBase
	{
		// Token: 0x0600F12A RID: 61738 RVA: 0x0022FB69 File Offset: 0x0022DD69
		[NullableContext(1)]
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

		// Token: 0x17004CE4 RID: 19684
		// (get) Token: 0x0600F12B RID: 61739 RVA: 0x0022FB88 File Offset: 0x0022DD88
		public virtual EControlElementalBoxType Type
		{
			get
			{
				return (EControlElementalBoxType)this.Instance.Type;
			}
		}

		// Token: 0x040084A4 RID: 33956
		private IControlElementalBoxTypeBase Instance;
	}
}
