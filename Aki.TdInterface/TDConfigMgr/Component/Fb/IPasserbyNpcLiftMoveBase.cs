using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DBA RID: 3514
	public class IPasserbyNpcLiftMoveBase
	{
		// Token: 0x06004FDA RID: 20442 RVA: 0x000C6956 File Offset: 0x000C4B56
		public static IPasserbyNpcLiftMoveBase Create(IPasserbyNpcLiftMoveBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPasserbyNpcLiftMoveBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001861 RID: 6241
		// (get) Token: 0x06004FDB RID: 20443 RVA: 0x000C6975 File Offset: 0x000C4B75
		public virtual EPasserbyNpcLiftMoveType Type
		{
			get
			{
				return (EPasserbyNpcLiftMoveType)this.Instance.Type;
			}
		}

		// Token: 0x04002D81 RID: 11649
		private IPasserbyNpcLiftMoveBase Instance;
	}
}
