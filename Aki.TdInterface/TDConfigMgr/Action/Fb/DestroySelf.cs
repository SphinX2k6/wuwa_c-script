using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002679 RID: 9849
	public class DestroySelf : ActionParams
	{
		// Token: 0x0600DCB3 RID: 56499 RVA: 0x0020D30E File Offset: 0x0020B50E
		[NullableContext(1)]
		public static DestroySelf Create(IDestroySelf? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DestroySelf
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004183 RID: 16771
		// (get) Token: 0x0600DCB4 RID: 56500 RVA: 0x0020D330 File Offset: 0x0020B530
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

		// Token: 0x04007AA9 RID: 31401
		private IDestroySelf Instance;
	}
}
