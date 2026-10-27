using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B0D RID: 6925
	[NullableContext(2)]
	[Nullable(0)]
	public class IHideWorldEntityAndLevelPlayGroup : IHideGroupType
	{
		// Token: 0x06009446 RID: 37958 RVA: 0x00157794 File Offset: 0x00155994
		[NullableContext(1)]
		private IHideWorldEntityAndLevelPlayGroup_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHideWorldEntityAndLevelPlayGroup 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHideWorldEntityAndLevelPlayGroup_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHideWorldEntityAndLevelPlayGroup_SetValue());
			}
			return result;
		}

		// Token: 0x06009447 RID: 37959 RVA: 0x001577CC File Offset: 0x001559CC
		[NullableContext(1)]
		public static IHideWorldEntityAndLevelPlayGroup Create([Nullable(2)] IHideWorldEntityAndLevelPlayGroup instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHideWorldEntityAndLevelPlayGroup
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009448 RID: 37960 RVA: 0x001577DF File Offset: 0x001559DF
		[NullableContext(1)]
		public static IHideWorldEntityAndLevelPlayGroup CreateFromSetValue([Nullable(2)] IHideWorldEntityAndLevelPlayGroup_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHideWorldEntityAndLevelPlayGroup
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009449 RID: 37961 RVA: 0x001577F4 File Offset: 0x001559F4
		[NullableContext(1)]
		public new IHideWorldEntityAndLevelPlayGroup_SetValue ToSetValue()
		{
			return new IHideWorldEntityAndLevelPlayGroup_SetValue
			{
				Type = this.Type,
				HideRangeEntities = this.HideRangeEntities,
				ExcludeEntities = this.ExcludeEntities,
				ExcludeLevelPlays = this.ExcludeLevelPlays,
				AppendEntities = this.AppendEntities,
				AppendLevelPlays = this.AppendLevelPlays
			};
		}

		// Token: 0x17002EE5 RID: 12005
		// (get) Token: 0x0600944A RID: 37962 RVA: 0x0015784E File Offset: 0x00155A4E
		// (set) Token: 0x0600944B RID: 37963 RVA: 0x00157879 File Offset: 0x00155A79
		public override EHideType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EHideType.WorldMonsterAndMonsterTreasure;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002EE6 RID: 12006
		// (get) Token: 0x0600944C RID: 37964 RVA: 0x00157887 File Offset: 0x00155A87
		// (set) Token: 0x0600944D RID: 37965 RVA: 0x001578AE File Offset: 0x00155AAE
		[Nullable(1)]
		public virtual List<int> HideRangeEntities
		{
			[NullableContext(1)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HideRangeEntities;
				}
				IHideWorldEntityAndLevelPlayGroup_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.HideRangeEntities;
			}
			[NullableContext(1)]
			set
			{
				this.GetOrCreatePoco().HideRangeEntities = value;
			}
		}

		// Token: 0x17002EE7 RID: 12007
		// (get) Token: 0x0600944E RID: 37966 RVA: 0x001578BC File Offset: 0x00155ABC
		// (set) Token: 0x0600944F RID: 37967 RVA: 0x001578E3 File Offset: 0x00155AE3
		public virtual List<int> ExcludeEntities
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ExcludeEntities;
				}
				IHideWorldEntityAndLevelPlayGroup_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ExcludeEntities;
			}
			set
			{
				this.GetOrCreatePoco().ExcludeEntities = value;
			}
		}

		// Token: 0x17002EE8 RID: 12008
		// (get) Token: 0x06009450 RID: 37968 RVA: 0x001578F1 File Offset: 0x00155AF1
		// (set) Token: 0x06009451 RID: 37969 RVA: 0x00157918 File Offset: 0x00155B18
		public virtual List<int> ExcludeLevelPlays
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ExcludeLevelPlays;
				}
				IHideWorldEntityAndLevelPlayGroup_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ExcludeLevelPlays;
			}
			set
			{
				this.GetOrCreatePoco().ExcludeLevelPlays = value;
			}
		}

		// Token: 0x17002EE9 RID: 12009
		// (get) Token: 0x06009452 RID: 37970 RVA: 0x00157926 File Offset: 0x00155B26
		// (set) Token: 0x06009453 RID: 37971 RVA: 0x0015794D File Offset: 0x00155B4D
		public virtual List<int> AppendEntities
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AppendEntities;
				}
				IHideWorldEntityAndLevelPlayGroup_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.AppendEntities;
			}
			set
			{
				this.GetOrCreatePoco().AppendEntities = value;
			}
		}

		// Token: 0x17002EEA RID: 12010
		// (get) Token: 0x06009454 RID: 37972 RVA: 0x0015795B File Offset: 0x00155B5B
		// (set) Token: 0x06009455 RID: 37973 RVA: 0x00157982 File Offset: 0x00155B82
		public virtual List<int> AppendLevelPlays
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AppendLevelPlays;
				}
				IHideWorldEntityAndLevelPlayGroup_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.AppendLevelPlays;
			}
			set
			{
				this.GetOrCreatePoco().AppendLevelPlays = value;
			}
		}

		// Token: 0x04005AF0 RID: 23280
		protected new IHideWorldEntityAndLevelPlayGroup FbInstance;

		// Token: 0x04005AF1 RID: 23281
		protected new IHideWorldEntityAndLevelPlayGroup_SetValue PocoInterface;
	}
}
