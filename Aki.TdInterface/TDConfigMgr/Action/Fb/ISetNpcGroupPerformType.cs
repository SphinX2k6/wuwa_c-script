using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D47 RID: 11591
	public class ISetNpcGroupPerformType
	{
		// Token: 0x0600FD1A RID: 64794 RVA: 0x0024905E File Offset: 0x0024725E
		public static ISetNpcGroupPerformType Create(ISetNpcGroupPerformType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetNpcGroupPerformType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004F3A RID: 20282
		// (get) Token: 0x0600FD1B RID: 64795 RVA: 0x0024907D File Offset: 0x0024727D
		public virtual ENpcGroupPerformType Type
		{
			get
			{
				return (ENpcGroupPerformType)this.Instance.Type;
			}
		}

		// Token: 0x04008A2B RID: 35371
		private ISetNpcGroupPerformType Instance;
	}
}
