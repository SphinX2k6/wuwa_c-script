using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DD3 RID: 11731
	public class IBpActorFuncTypeBase
	{
		// Token: 0x0600FF52 RID: 65362 RVA: 0x0024CB70 File Offset: 0x0024AD70
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

		// Token: 0x1700505A RID: 20570
		// (get) Token: 0x0600FF53 RID: 65363 RVA: 0x0024CB8F File Offset: 0x0024AD8F
		public virtual EBpActorFuncType Type
		{
			get
			{
				return (EBpActorFuncType)this.Instance.Type;
			}
		}

		// Token: 0x04008B63 RID: 35683
		private IBpActorFuncTypeBase Instance;
	}
}
