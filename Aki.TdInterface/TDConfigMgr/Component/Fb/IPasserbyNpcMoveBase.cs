using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CD3 RID: 3283
	public class IPasserbyNpcMoveBase
	{
		// Token: 0x06004B13 RID: 19219 RVA: 0x000BBBD6 File Offset: 0x000B9DD6
		[NullableContext(1)]
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

		// Token: 0x1700172A RID: 5930
		// (get) Token: 0x06004B14 RID: 19220 RVA: 0x000BBBF5 File Offset: 0x000B9DF5
		public virtual EPasserbyNpcMoveType Type
		{
			get
			{
				return (EPasserbyNpcMoveType)this.Instance.Type;
			}
		}

		// Token: 0x04002AF4 RID: 10996
		private IPasserbyNpcMoveBase Instance;
	}
}
