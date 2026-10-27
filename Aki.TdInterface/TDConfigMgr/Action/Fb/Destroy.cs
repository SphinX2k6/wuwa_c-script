using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002678 RID: 9848
	public class Destroy : ActionParams
	{
		// Token: 0x0600DCB0 RID: 56496 RVA: 0x0020D2AE File Offset: 0x0020B4AE
		[NullableContext(1)]
		public static Destroy Create(IDestroy? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new Destroy
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004182 RID: 16770
		// (get) Token: 0x0600DCB1 RID: 56497 RVA: 0x0020D2D0 File Offset: 0x0020B4D0
		public virtual bool? DelayDestroy
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.DelayDestroy);
			}
		}

		// Token: 0x04007AA8 RID: 31400
		private IDestroy Instance;
	}
}
