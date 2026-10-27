using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B6C RID: 2924
	[NullableContext(1)]
	[Nullable(0)]
	public class IDurabilityState
	{
		// Token: 0x06004359 RID: 17241 RVA: 0x000ABB5F File Offset: 0x000A9D5F
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

		// Token: 0x1700123E RID: 4670
		// (get) Token: 0x0600435A RID: 17242 RVA: 0x000ABB7E File Offset: 0x000A9D7E
		public virtual int Durability
		{
			get
			{
				return this.Instance.Durability;
			}
		}

		// Token: 0x1700123F RID: 4671
		// (get) Token: 0x0600435B RID: 17243 RVA: 0x000ABB8B File Offset: 0x000A9D8B
		public virtual string State
		{
			get
			{
				return this.Instance.State;
			}
		}

		// Token: 0x040025F9 RID: 9721
		private IDurabilityState Instance;
	}
}
