using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001523 RID: 5411
	public class IDisableHLOD : IOperation
	{
		// Token: 0x06007A79 RID: 31353 RVA: 0x001242F0 File Offset: 0x001224F0
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

		// Token: 0x170027D5 RID: 10197
		// (get) Token: 0x06007A7A RID: 31354 RVA: 0x0012430F File Offset: 0x0012250F
		public override EOperation Type
		{
			get
			{
				return (EOperation)this.Instance.Type;
			}
		}

		// Token: 0x170027D6 RID: 10198
		// (get) Token: 0x06007A7B RID: 31355 RVA: 0x0012431C File Offset: 0x0012251C
		public virtual bool IsDisable
		{
			get
			{
				return this.Instance.IsDisable;
			}
		}

		// Token: 0x04004691 RID: 18065
		private IDisableHLOD Instance;
	}
}
