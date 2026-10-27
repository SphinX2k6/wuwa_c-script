using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200108D RID: 4237
	[NullableContext(1)]
	[Nullable(0)]
	public class IQuestPlayerHitCount : IQuestPlayerHitStatisticsType
	{
		// Token: 0x06005F8C RID: 24460 RVA: 0x000E7690 File Offset: 0x000E5890
		private IQuestPlayerHitCount_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IQuestPlayerHitCount 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IQuestPlayerHitCount_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IQuestPlayerHitCount_SetValue());
			}
			return result;
		}

		// Token: 0x06005F8D RID: 24461 RVA: 0x000E76C8 File Offset: 0x000E58C8
		public static IQuestPlayerHitCount Create([Nullable(2)] IQuestPlayerHitCount instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQuestPlayerHitCount
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005F8E RID: 24462 RVA: 0x000E76DB File Offset: 0x000E58DB
		public static IQuestPlayerHitCount CreateFromSetValue([Nullable(2)] IQuestPlayerHitCount_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IQuestPlayerHitCount
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005F8F RID: 24463 RVA: 0x000E76EE File Offset: 0x000E58EE
		public new IQuestPlayerHitCount_SetValue ToSetValue()
		{
			return new IQuestPlayerHitCount_SetValue
			{
				Type = this.Type,
				Cd = this.Cd,
				EntityIds = this.EntityIds,
				SkillIds = this.SkillIds
			};
		}

		// Token: 0x17001F76 RID: 8054
		// (get) Token: 0x06005F90 RID: 24464 RVA: 0x000E7725 File Offset: 0x000E5925
		// (set) Token: 0x06005F91 RID: 24465 RVA: 0x000E7750 File Offset: 0x000E5950
		public override EPlayerHitStatisticsType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPlayerHitStatisticsType.HitCount;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17001F77 RID: 8055
		// (get) Token: 0x06005F92 RID: 24466 RVA: 0x000E7760 File Offset: 0x000E5960
		// (set) Token: 0x06005F93 RID: 24467 RVA: 0x000E779A File Offset: 0x000E599A
		public virtual float? Cd
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Cd;
				}
				IQuestPlayerHitCount_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Cd;
			}
			set
			{
				this.GetOrCreatePoco().Cd = value;
			}
		}

		// Token: 0x17001F78 RID: 8056
		// (get) Token: 0x06005F94 RID: 24468 RVA: 0x000E77A8 File Offset: 0x000E59A8
		// (set) Token: 0x06005F95 RID: 24469 RVA: 0x000E77CF File Offset: 0x000E59CF
		public virtual List<int> EntityIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityIds;
				}
				IQuestPlayerHitCount_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EntityIds;
			}
			set
			{
				this.GetOrCreatePoco().EntityIds = value;
			}
		}

		// Token: 0x17001F79 RID: 8057
		// (get) Token: 0x06005F96 RID: 24470 RVA: 0x000E77DD File Offset: 0x000E59DD
		// (set) Token: 0x06005F97 RID: 24471 RVA: 0x000E7804 File Offset: 0x000E5A04
		public virtual List<int> SkillIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SkillIds;
				}
				IQuestPlayerHitCount_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SkillIds;
			}
			set
			{
				this.GetOrCreatePoco().SkillIds = value;
			}
		}

		// Token: 0x040039A5 RID: 14757
		[Nullable(2)]
		protected new IQuestPlayerHitCount FbInstance;

		// Token: 0x040039A6 RID: 14758
		[Nullable(2)]
		protected new IQuestPlayerHitCount_SetValue PocoInterface;
	}
}
