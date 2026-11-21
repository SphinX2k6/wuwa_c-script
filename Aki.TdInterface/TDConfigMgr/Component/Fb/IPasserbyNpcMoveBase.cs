using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DB7 RID: 3511
	public class IPasserbyNpcMoveBase
	{
		// Token: 0x06004FCE RID: 20430 RVA: 0x000C680E File Offset: 0x000C4A0E
		public static IPasserbyNpcMoveBase Create(IPasserbyNpcMoveBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPasserbyNpcMoveBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700185B RID: 6235
		// (get) Token: 0x06004FCF RID: 20431 RVA: 0x000C682D File Offset: 0x000C4A2D
		public virtual EPasserbyNpcMoveType Type
		{
			get
			{
				return (EPasserbyNpcMoveType)this.Instance.Type;
			}
		}

		// Token: 0x04002D7A RID: 11642
		private IPasserbyNpcMoveBase Instance;
	}
}
