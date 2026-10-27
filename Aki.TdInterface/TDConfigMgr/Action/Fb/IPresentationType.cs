using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AE3 RID: 10979
	public class IPresentationType
	{
		// Token: 0x0600F0AA RID: 61610 RVA: 0x0022EFBE File Offset: 0x0022D1BE
		[NullableContext(1)]
		public static IPresentationType Create(IPresentationType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPresentationType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004CA6 RID: 19622
		// (get) Token: 0x0600F0AB RID: 61611 RVA: 0x0022EFDD File Offset: 0x0022D1DD
		public virtual EResetPresentationType Type
		{
			get
			{
				return (EResetPresentationType)this.Instance.Type;
			}
		}

		// Token: 0x04008469 RID: 33897
		private IPresentationType Instance;
	}
}
