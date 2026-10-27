using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013CB RID: 5067
	public class IOperation
	{
		// Token: 0x060073B5 RID: 29621 RVA: 0x001158D8 File Offset: 0x00113AD8
		[NullableContext(1)]
		public static IOperation Create(IOperation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOperation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170025F2 RID: 9714
		// (get) Token: 0x060073B6 RID: 29622 RVA: 0x001158F7 File Offset: 0x00113AF7
		public virtual EOperation Type
		{
			get
			{
				return (EOperation)this.Instance.Type;
			}
		}

		// Token: 0x040042FF RID: 17151
		private IOperation Instance;
	}
}
