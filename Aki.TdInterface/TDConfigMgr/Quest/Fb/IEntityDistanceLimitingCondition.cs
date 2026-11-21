using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001586 RID: 5510
	public class IEntityDistanceLimitingCondition
	{
		// Token: 0x06007C49 RID: 31817 RVA: 0x0012765A File Offset: 0x0012585A
		public static IEntityDistanceLimitingCondition Create(IEntityDistanceLimitingCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityDistanceLimitingCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170028DF RID: 10463
		// (get) Token: 0x06007C4A RID: 31818 RVA: 0x00127679 File Offset: 0x00125879
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x170028E0 RID: 10464
		// (get) Token: 0x06007C4B RID: 31819 RVA: 0x00127686 File Offset: 0x00125886
		public virtual float MaxDistance
		{
			get
			{
				return this.Instance.MaxDistance;
			}
		}

		// Token: 0x170028E1 RID: 10465
		// (get) Token: 0x06007C4C RID: 31820 RVA: 0x00127693 File Offset: 0x00125893
		public virtual float OverMaxCountdown
		{
			get
			{
				return this.Instance.OverMaxCountdown;
			}
		}

		// Token: 0x040047AA RID: 18346
		private IEntityDistanceLimitingCondition Instance;
	}
}
