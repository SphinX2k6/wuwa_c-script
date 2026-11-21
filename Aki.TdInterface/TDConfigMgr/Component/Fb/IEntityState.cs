using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B99 RID: 2969
	public class IEntityState
	{
		// Token: 0x060043EC RID: 17388 RVA: 0x000AC63A File Offset: 0x000AA83A
		public static IEntityState Create(IEntityState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170010B5 RID: 4277
		// (get) Token: 0x060043ED RID: 17389 RVA: 0x000AC659 File Offset: 0x000AA859
		public virtual string Type
		{
			get
			{
				return this.Instance.Type;
			}
		}

		// Token: 0x170010B6 RID: 4278
		// (get) Token: 0x060043EE RID: 17390 RVA: 0x000AC666 File Offset: 0x000AA866
		public virtual string State
		{
			get
			{
				return this.Instance.State;
			}
		}

		// Token: 0x04002598 RID: 9624
		private IEntityState Instance;
	}
}
