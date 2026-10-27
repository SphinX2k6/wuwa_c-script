using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050E2 RID: 20706
	public class IDynamicEntityRewardType_UnionUnion
	{
		// Token: 0x170096BC RID: 38588
		// (get) Token: 0x06021547 RID: 136519 RVA: 0x004A0FC9 File Offset: 0x0049F1C9
		// (set) Token: 0x06021548 RID: 136520 RVA: 0x004A0FD1 File Offset: 0x0049F1D1
		public IDynamicEntityRewardType_Union Type { get; set; }

		// Token: 0x170096BD RID: 38589
		// (get) Token: 0x06021549 RID: 136521 RVA: 0x004A0FDA File Offset: 0x0049F1DA
		// (set) Token: 0x0602154A RID: 136522 RVA: 0x004A0FE2 File Offset: 0x0049F1E2
		public object Value { get; set; }

		// Token: 0x0602154B RID: 136523 RVA: 0x004A0FEB File Offset: 0x0049F1EB
		public IDynamicEntityRewardType_UnionUnion()
		{
			this.Type = IDynamicEntityRewardType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602154C RID: 136524 RVA: 0x004A1001 File Offset: 0x0049F201
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602154D RID: 136525 RVA: 0x004A1013 File Offset: 0x0049F213
		public IDynamicEntityRewardTypeT AsIDynamicEntityRewardType()
		{
			return this.As<IDynamicEntityRewardTypeT>();
		}

		// Token: 0x0602154E RID: 136526 RVA: 0x004A101B File Offset: 0x0049F21B
		public static IDynamicEntityRewardType_UnionUnion FromIDynamicEntityRewardType(IDynamicEntityRewardTypeT _idynamicentityrewardtype)
		{
			return new IDynamicEntityRewardType_UnionUnion
			{
				Type = IDynamicEntityRewardType_Union.IDynamicEntityRewardType,
				Value = _idynamicentityrewardtype
			};
		}

		// Token: 0x0602154F RID: 136527 RVA: 0x004A1030 File Offset: 0x0049F230
		public IDynamicTrafficRewardT AsIDynamicTrafficReward()
		{
			return this.As<IDynamicTrafficRewardT>();
		}

		// Token: 0x06021550 RID: 136528 RVA: 0x004A1038 File Offset: 0x0049F238
		public static IDynamicEntityRewardType_UnionUnion FromIDynamicTrafficReward(IDynamicTrafficRewardT _idynamictrafficreward)
		{
			return new IDynamicEntityRewardType_UnionUnion
			{
				Type = IDynamicEntityRewardType_Union.IDynamicTrafficReward,
				Value = _idynamictrafficreward
			};
		}

		// Token: 0x06021551 RID: 136529 RVA: 0x004A1050 File Offset: 0x0049F250
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
