using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002762 RID: 10082
	public class ICommonTip2Type
	{
		// Token: 0x0600E09D RID: 57501 RVA: 0x00213367 File Offset: 0x00211567
		[NullableContext(1)]
		public static ICommonTip2Type Create(ICommonTip2Type? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonTip2Type
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700439B RID: 17307
		// (get) Token: 0x0600E09E RID: 57502 RVA: 0x00213386 File Offset: 0x00211586
		public virtual ECommonTip2Type Type
		{
			get
			{
				return (ECommonTip2Type)this.Instance.Type;
			}
		}

		// Token: 0x04007C64 RID: 31844
		private ICommonTip2Type Instance;
	}
}
