using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002573 RID: 9587
	public class IVisualNovelPerformanceBase
	{
		// Token: 0x0600D723 RID: 55075 RVA: 0x00200CF6 File Offset: 0x001FEEF6
		[NullableContext(1)]
		public static IVisualNovelPerformanceBase Create(IVisualNovelPerformanceBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelPerformanceBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003DFF RID: 15871
		// (get) Token: 0x0600D724 RID: 55076 RVA: 0x00200D15 File Offset: 0x001FEF15
		public virtual EVisualNovelPerformanceType Type
		{
			get
			{
				return (EVisualNovelPerformanceType)this.Instance.Type;
			}
		}

		// Token: 0x17003E00 RID: 15872
		// (get) Token: 0x0600D725 RID: 55077 RVA: 0x00200D24 File Offset: 0x001FEF24
		public virtual float? StartTime
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.StartTime);
			}
		}

		// Token: 0x04007715 RID: 30485
		private IVisualNovelPerformanceBase Instance;
	}
}
