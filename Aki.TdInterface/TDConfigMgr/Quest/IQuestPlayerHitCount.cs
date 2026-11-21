using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020011BB RID: 4539
	public class IQuestPlayerHitCount : IQuestPlayerHitStatisticsType
	{
		// Token: 0x06006585 RID: 25989 RVA: 0x000F47B0 File Offset: 0x000F29B0
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

		// Token: 0x06006586 RID: 25990 RVA: 0x000F47E8 File Offset: 0x000F29E8
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

		// Token: 0x06006587 RID: 25991 RVA: 0x000F47FB File Offset: 0x000F29FB
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

		// Token: 0x06006588 RID: 25992 RVA: 0x000F480E File Offset: 0x000F2A0E
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

		// Token: 0x17002128 RID: 8488
		// (get) Token: 0x06006589 RID: 25993 RVA: 0x000F4845 File Offset: 0x000F2A45
		// (set) Token: 0x0600658A RID: 25994 RVA: 0x000F4870 File Offset: 0x000F2A70
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

		// Token: 0x17002129 RID: 8489
		// (get) Token: 0x0600658B RID: 25995 RVA: 0x000F4880 File Offset: 0x000F2A80
		// (set) Token: 0x0600658C RID: 25996 RVA: 0x000F48BA File Offset: 0x000F2ABA
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

		// Token: 0x1700212A RID: 8490
		// (get) Token: 0x0600658D RID: 25997 RVA: 0x000F48C8 File Offset: 0x000F2AC8
		// (set) Token: 0x0600658E RID: 25998 RVA: 0x000F48EF File Offset: 0x000F2AEF
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

		// Token: 0x1700212B RID: 8491
		// (get) Token: 0x0600658F RID: 25999 RVA: 0x000F48FD File Offset: 0x000F2AFD
		// (set) Token: 0x06006590 RID: 26000 RVA: 0x000F4924 File Offset: 0x000F2B24
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

		// Token: 0x04003CF2 RID: 15602
		[Nullable(2)]
		protected new IQuestPlayerHitCount FbInstance;

		// Token: 0x04003CF3 RID: 15603
		[Nullable(2)]
		protected new IQuestPlayerHitCount_SetValue PocoInterface;
	}
}
