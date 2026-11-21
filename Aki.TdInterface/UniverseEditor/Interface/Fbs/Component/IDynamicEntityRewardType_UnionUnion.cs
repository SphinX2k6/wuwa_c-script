using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005647 RID: 22087
	public class IDynamicEntityRewardType_UnionUnion
	{
		// Token: 0x17009EA9 RID: 40617
		// (get) Token: 0x0602349B RID: 144539 RVA: 0x004DAF55 File Offset: 0x004D9155
		// (set) Token: 0x0602349C RID: 144540 RVA: 0x004DAF5D File Offset: 0x004D915D
		public IDynamicEntityRewardType_Union Type { get; set; }

		// Token: 0x17009EAA RID: 40618
		// (get) Token: 0x0602349D RID: 144541 RVA: 0x004DAF66 File Offset: 0x004D9166
		// (set) Token: 0x0602349E RID: 144542 RVA: 0x004DAF6E File Offset: 0x004D916E
		public object Value { get; set; }

		// Token: 0x0602349F RID: 144543 RVA: 0x004DAF77 File Offset: 0x004D9177
		public IDynamicEntityRewardType_UnionUnion()
		{
			this.Type = IDynamicEntityRewardType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060234A0 RID: 144544 RVA: 0x004DAF8D File Offset: 0x004D918D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060234A1 RID: 144545 RVA: 0x004DAF9F File Offset: 0x004D919F
		public IDynamicEntityRewardTypeT AsIDynamicEntityRewardType()
		{
			return this.As<IDynamicEntityRewardTypeT>();
		}

		// Token: 0x060234A2 RID: 144546 RVA: 0x004DAFA7 File Offset: 0x004D91A7
		public static IDynamicEntityRewardType_UnionUnion FromIDynamicEntityRewardType(IDynamicEntityRewardTypeT _idynamicentityrewardtype)
		{
			return new IDynamicEntityRewardType_UnionUnion
			{
				Type = IDynamicEntityRewardType_Union.IDynamicEntityRewardType,
				Value = _idynamicentityrewardtype
			};
		}

		// Token: 0x060234A3 RID: 144547 RVA: 0x004DAFBC File Offset: 0x004D91BC
		public IDynamicTrafficRewardT AsIDynamicTrafficReward()
		{
			return this.As<IDynamicTrafficRewardT>();
		}

		// Token: 0x060234A4 RID: 144548 RVA: 0x004DAFC4 File Offset: 0x004D91C4
		public static IDynamicEntityRewardType_UnionUnion FromIDynamicTrafficReward(IDynamicTrafficRewardT _idynamictrafficreward)
		{
			return new IDynamicEntityRewardType_UnionUnion
			{
				Type = IDynamicEntityRewardType_Union.IDynamicTrafficReward,
				Value = _idynamictrafficreward
			};
		}

		// Token: 0x060234A5 RID: 144549 RVA: 0x004DAFDC File Offset: 0x004D91DC
		public static int Pack(FlatBufferBuilder builder, IDynamicEntityRewardType_UnionUnion _o)
		{
			IDynamicEntityRewardType_Union type = _o.Type;
			if (type == IDynamicEntityRewardType_Union.IDynamicEntityRewardType)
			{
				return IDynamicEntityRewardType.Pack(builder, _o.AsIDynamicEntityRewardType()).Value;
			}
			if (type != IDynamicEntityRewardType_Union.IDynamicTrafficReward)
			{
				return 0;
			}
			return IDynamicTrafficReward.Pack(builder, _o.AsIDynamicTrafficReward()).Value;
		}
	}
}
