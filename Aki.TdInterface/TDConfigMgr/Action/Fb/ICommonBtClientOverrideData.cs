using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A7C RID: 10876
	[NullableContext(1)]
	[Nullable(0)]
	public class ICommonBtClientOverrideData
	{
		// Token: 0x0600EF15 RID: 61205 RVA: 0x0022C63C File Offset: 0x0022A83C
		public static ICommonBtClientOverrideData Create(ICommonBtClientOverrideData? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonBtClientOverrideData
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004BDF RID: 19423
		// (get) Token: 0x0600EF16 RID: 61206 RVA: 0x0022C65B File Offset: 0x0022A85B
		public virtual int TaskId
		{
			get
			{
				return this.Instance.TaskId;
			}
		}

		// Token: 0x17004BE0 RID: 19424
		// (get) Token: 0x0600EF17 RID: 61207 RVA: 0x0022C668 File Offset: 0x0022A868
		public virtual string Data
		{
			get
			{
				return this.Instance.Data;
			}
		}

		// Token: 0x0400838E RID: 33678
		private ICommonBtClientOverrideData Instance;
	}
}
