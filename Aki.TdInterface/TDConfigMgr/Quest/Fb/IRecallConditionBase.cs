using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001459 RID: 5209
	public class IRecallConditionBase
	{
		// Token: 0x06007663 RID: 30307 RVA: 0x0011ABF4 File Offset: 0x00118DF4
		[NullableContext(1)]
		public static IRecallConditionBase Create(IRecallConditionBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRecallConditionBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002784 RID: 10116
		// (get) Token: 0x06007664 RID: 30308 RVA: 0x0011AC13 File Offset: 0x00118E13
		public virtual ERecallConditionType Type
		{
			get
			{
				return (ERecallConditionType)this.Instance.Type;
			}
		}

		// Token: 0x17002785 RID: 10117
		// (get) Token: 0x06007665 RID: 30309 RVA: 0x0011AC20 File Offset: 0x00118E20
		public virtual ERecallOperation Operation
		{
			get
			{
				return (ERecallOperation)this.Instance.Operation;
			}
		}

		// Token: 0x040044BD RID: 17597
		private IRecallConditionBase Instance;
	}
}
