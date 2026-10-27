using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200142E RID: 5166
	public class IEntityDistanceLimitingCondition
	{
		// Token: 0x06007584 RID: 30084 RVA: 0x00118C0E File Offset: 0x00116E0E
		[NullableContext(1)]
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

		// Token: 0x170026FB RID: 9979
		// (get) Token: 0x06007585 RID: 30085 RVA: 0x00118C2D File Offset: 0x00116E2D
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x170026FC RID: 9980
		// (get) Token: 0x06007586 RID: 30086 RVA: 0x00118C3A File Offset: 0x00116E3A
		public virtual float MaxDistance
		{
			get
			{
				return this.Instance.MaxDistance;
			}
		}

		// Token: 0x170026FD RID: 9981
		// (get) Token: 0x06007587 RID: 30087 RVA: 0x00118C47 File Offset: 0x00116E47
		public virtual float OverMaxCountdown
		{
			get
			{
				return this.Instance.OverMaxCountdown;
			}
		}

		// Token: 0x04004416 RID: 17430
		private IEntityDistanceLimitingCondition Instance;
	}
}
