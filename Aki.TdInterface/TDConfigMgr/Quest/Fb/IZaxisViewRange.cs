using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001467 RID: 5223
	public class IZaxisViewRange
	{
		// Token: 0x060076D5 RID: 30421 RVA: 0x0011D710 File Offset: 0x0011B910
		public static IZaxisViewRange Create(IZaxisViewRange? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IZaxisViewRange
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170025A9 RID: 9641
		// (get) Token: 0x060076D6 RID: 30422 RVA: 0x0011D730 File Offset: 0x0011B930
		public virtual int? Up
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.Up);
			}
		}

		// Token: 0x170025AA RID: 9642
		// (get) Token: 0x060076D7 RID: 30423 RVA: 0x0011D768 File Offset: 0x0011B968
		public virtual int? Down
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new int?(this.Instance.Down);
			}
		}

		// Token: 0x04004439 RID: 17465
		private IZaxisViewRange Instance;
	}
}
