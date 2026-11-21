using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C3A RID: 3130
	public class IDurabilityState
	{
		// Token: 0x060047B2 RID: 18354 RVA: 0x000B5C23 File Offset: 0x000B3E23
		public static IDurabilityState Create(IDurabilityState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDurabilityState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001339 RID: 4921
		// (get) Token: 0x060047B3 RID: 18355 RVA: 0x000B5C42 File Offset: 0x000B3E42
		public virtual int Durability
		{
			get
			{
				return this.Instance.Durability;
			}
		}

		// Token: 0x1700133A RID: 4922
		// (get) Token: 0x060047B4 RID: 18356 RVA: 0x000B5C4F File Offset: 0x000B3E4F
		public virtual string State
		{
			get
			{
				return this.Instance.State;
			}
		}

		// Token: 0x04002841 RID: 10305
		private IDurabilityState Instance;
	}
}
