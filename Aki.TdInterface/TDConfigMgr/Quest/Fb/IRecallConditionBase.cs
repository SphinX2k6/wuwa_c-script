using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020015B2 RID: 5554
	public class IRecallConditionBase
	{
		// Token: 0x06007D30 RID: 32048 RVA: 0x001297D8 File Offset: 0x001279D8
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

		// Token: 0x1700296E RID: 10606
		// (get) Token: 0x06007D31 RID: 32049 RVA: 0x001297F7 File Offset: 0x001279F7
		public virtual ERecallConditionType Type
		{
			get
			{
				return (ERecallConditionType)this.Instance.Type;
			}
		}

		// Token: 0x1700296F RID: 10607
		// (get) Token: 0x06007D32 RID: 32050 RVA: 0x00129804 File Offset: 0x00127A04
		public virtual ERecallOperation Operation
		{
			get
			{
				return (ERecallOperation)this.Instance.Operation;
			}
		}

		// Token: 0x04004856 RID: 18518
		private IRecallConditionBase Instance;
	}
}
