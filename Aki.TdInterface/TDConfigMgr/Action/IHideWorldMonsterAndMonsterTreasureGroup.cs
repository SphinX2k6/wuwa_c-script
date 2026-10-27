using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B11 RID: 6929
	[NullableContext(1)]
	[Nullable(0)]
	public class IHideWorldMonsterAndMonsterTreasureGroup : IHideGroupType
	{
		// Token: 0x06009460 RID: 37984 RVA: 0x00157A5C File Offset: 0x00155C5C
		private IHideWorldMonsterAndMonsterTreasureGroup_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHideWorldMonsterAndMonsterTreasureGroup 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHideWorldMonsterAndMonsterTreasureGroup_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHideWorldMonsterAndMonsterTreasureGroup_SetValue());
			}
			return result;
		}

		// Token: 0x06009461 RID: 37985 RVA: 0x00157A94 File Offset: 0x00155C94
		public static IHideWorldMonsterAndMonsterTreasureGroup Create([Nullable(2)] IHideWorldMonsterAndMonsterTreasureGroup instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHideWorldMonsterAndMonsterTreasureGroup
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009462 RID: 37986 RVA: 0x00157AA7 File Offset: 0x00155CA7
		public static IHideWorldMonsterAndMonsterTreasureGroup CreateFromSetValue([Nullable(2)] IHideWorldMonsterAndMonsterTreasureGroup_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHideWorldMonsterAndMonsterTreasureGroup
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009463 RID: 37987 RVA: 0x00157ABA File Offset: 0x00155CBA
		public new IHideWorldMonsterAndMonsterTreasureGroup_SetValue ToSetValue()
		{
			return new IHideWorldMonsterAndMonsterTreasureGroup_SetValue
			{
				Type = this.Type,
				HideRangeEntities = this.HideRangeEntities
			};
		}

		// Token: 0x17002EEC RID: 12012
		// (get) Token: 0x06009464 RID: 37988 RVA: 0x00157AD9 File Offset: 0x00155CD9
		// (set) Token: 0x06009465 RID: 37989 RVA: 0x00157B04 File Offset: 0x00155D04
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

		// Token: 0x17002EED RID: 12013
		// (get) Token: 0x06009466 RID: 37990 RVA: 0x00157B12 File Offset: 0x00155D12
		// (set) Token: 0x06009467 RID: 37991 RVA: 0x00157B39 File Offset: 0x00155D39
		public virtual List<int> HideRangeEntities
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HideRangeEntities;
				}
				IHideWorldMonsterAndMonsterTreasureGroup_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.HideRangeEntities;
			}
			set
			{
				this.GetOrCreatePoco().HideRangeEntities = value;
			}
		}

		// Token: 0x04005AFB RID: 23291
		[Nullable(2)]
		protected new IHideWorldMonsterAndMonsterTreasureGroup FbInstance;

		// Token: 0x04005AFC RID: 23292
		[Nullable(2)]
		protected new IHideWorldMonsterAndMonsterTreasureGroup_SetValue PocoInterface;
	}
}
