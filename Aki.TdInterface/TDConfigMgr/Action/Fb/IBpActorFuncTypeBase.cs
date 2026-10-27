using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002ADF RID: 10975
	public class IBpActorFuncTypeBase
	{
		// Token: 0x0600F09C RID: 61596 RVA: 0x0022EE64 File Offset: 0x0022D064
		[NullableContext(1)]
		public static IBpActorFuncTypeBase Create(IBpActorFuncTypeBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBpActorFuncTypeBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004CA0 RID: 19616
		// (get) Token: 0x0600F09D RID: 61597 RVA: 0x0022EE83 File Offset: 0x0022D083
		public virtual EBpActorFuncType Type
		{
			get
			{
				return (EBpActorFuncType)this.Instance.Type;
			}
		}

		// Token: 0x0400845F RID: 33887
		private IBpActorFuncTypeBase Instance;
	}
}
