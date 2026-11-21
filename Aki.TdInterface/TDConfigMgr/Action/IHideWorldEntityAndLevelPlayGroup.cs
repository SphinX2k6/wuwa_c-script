using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CBC RID: 7356
	[NullableContext(2)]
	[Nullable(0)]
	public class IHideWorldEntityAndLevelPlayGroup : IHideGroupType
	{
		// Token: 0x06009C30 RID: 39984 RVA: 0x00168470 File Offset: 0x00166670
		[NullableContext(0)]
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

		// Token: 0x06009C31 RID: 39985 RVA: 0x001684A8 File Offset: 0x001666A8
		[NullableContext(0)]
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

		// Token: 0x06009C32 RID: 39986 RVA: 0x001684BB File Offset: 0x001666BB
		[NullableContext(0)]
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

		// Token: 0x06009C33 RID: 39987 RVA: 0x001684D0 File Offset: 0x001666D0
		[NullableContext(0)]
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

		// Token: 0x1700310B RID: 12555
		// (get) Token: 0x06009C34 RID: 39988 RVA: 0x0016852A File Offset: 0x0016672A
		// (set) Token: 0x06009C35 RID: 39989 RVA: 0x00168555 File Offset: 0x00166755
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

		// Token: 0x1700310C RID: 12556
		// (get) Token: 0x06009C36 RID: 39990 RVA: 0x00168563 File Offset: 0x00166763
		// (set) Token: 0x06009C37 RID: 39991 RVA: 0x0016858A File Offset: 0x0016678A
		[Nullable(0)]
		public virtual List<int> HideRangeEntities
		{
			[NullableContext(0)]
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
			[NullableContext(0)]
			set
			{
				this.GetOrCreatePoco().HideRangeEntities = value;
			}
		}

		// Token: 0x1700310D RID: 12557
		// (get) Token: 0x06009C38 RID: 39992 RVA: 0x00168598 File Offset: 0x00166798
		// (set) Token: 0x06009C39 RID: 39993 RVA: 0x001685BF File Offset: 0x001667BF
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

		// Token: 0x1700310E RID: 12558
		// (get) Token: 0x06009C3A RID: 39994 RVA: 0x001685CD File Offset: 0x001667CD
		// (set) Token: 0x06009C3B RID: 39995 RVA: 0x001685F4 File Offset: 0x001667F4
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

		// Token: 0x1700310F RID: 12559
		// (get) Token: 0x06009C3C RID: 39996 RVA: 0x00168602 File Offset: 0x00166802
		// (set) Token: 0x06009C3D RID: 39997 RVA: 0x00168629 File Offset: 0x00166829
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

		// Token: 0x17003110 RID: 12560
		// (get) Token: 0x06009C3E RID: 39998 RVA: 0x00168637 File Offset: 0x00166837
		// (set) Token: 0x06009C3F RID: 39999 RVA: 0x0016865E File Offset: 0x0016685E
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

		// Token: 0x04005F8E RID: 24462
		protected new IHideWorldEntityAndLevelPlayGroup FbInstance;

		// Token: 0x04005F8F RID: 24463
		protected new IHideWorldEntityAndLevelPlayGroup_SetValue PocoInterface;
	}
}
