using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013CC RID: 5068
	public class IDisableHLOD : IOperation
	{
		// Token: 0x060073B8 RID: 29624 RVA: 0x0011590C File Offset: 0x00113B0C
		[NullableContext(1)]
		public static IDisableHLOD Create(IDisableHLOD? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDisableHLOD
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170025F3 RID: 9715
		// (get) Token: 0x060073B9 RID: 29625 RVA: 0x0011592B File Offset: 0x00113B2B
		public override EOperation Type
		{
			get
			{
				return (EOperation)this.Instance.Type;
			}
		}

		// Token: 0x170025F4 RID: 9716
		// (get) Token: 0x060073BA RID: 29626 RVA: 0x00115938 File Offset: 0x00113B38
		public virtual bool IsDisable
		{
			get
			{
				return this.Instance.IsDisable;
			}
		}

		// Token: 0x04004300 RID: 17152
		private IDisableHLOD Instance;
	}
}
