using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DD1 RID: 3537
	public class IPasserbyNpcPerformance
	{
		// Token: 0x06005036 RID: 20534 RVA: 0x000C72D1 File Offset: 0x000C54D1
		public static IPasserbyNpcPerformance Create(IPasserbyNpcPerformance? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPasserbyNpcPerformance
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700188F RID: 6287
		// (get) Token: 0x06005037 RID: 20535 RVA: 0x000C72F0 File Offset: 0x000C54F0
		[Nullable(2)]
		public virtual string EffectGroupDa
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.EffectGroupDa;
			}
		}

		// Token: 0x04002DB2 RID: 11698
		private IPasserbyNpcPerformance Instance;
	}
}
