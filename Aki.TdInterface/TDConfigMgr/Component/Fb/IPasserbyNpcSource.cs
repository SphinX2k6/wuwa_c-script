using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CD7 RID: 3287
	public class IPasserbyNpcSource
	{
		// Token: 0x06004B25 RID: 19237 RVA: 0x000BBDA7 File Offset: 0x000B9FA7
		[NullableContext(1)]
		public static IPasserbyNpcSource Create(IPasserbyNpcSource? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPasserbyNpcSource
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001734 RID: 5940
		// (get) Token: 0x06004B26 RID: 19238 RVA: 0x000BBDC6 File Offset: 0x000B9FC6
		public virtual EPasserbyNpcSource Type
		{
			get
			{
				return (EPasserbyNpcSource)this.Instance.Type;
			}
		}

		// Token: 0x04002AFA RID: 11002
		private IPasserbyNpcSource Instance;
	}
}
