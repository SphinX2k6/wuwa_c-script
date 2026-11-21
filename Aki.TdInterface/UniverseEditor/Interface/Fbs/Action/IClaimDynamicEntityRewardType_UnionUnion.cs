using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069EB RID: 27115
	public class IClaimDynamicEntityRewardType_UnionUnion
	{
		// Token: 0x1700C772 RID: 51058
		// (get) Token: 0x0602E832 RID: 190514 RVA: 0x00658401 File Offset: 0x00656601
		// (set) Token: 0x0602E833 RID: 190515 RVA: 0x00658409 File Offset: 0x00656609
		public IClaimDynamicEntityRewardType_Union Type { get; set; }

		// Token: 0x1700C773 RID: 51059
		// (get) Token: 0x0602E834 RID: 190516 RVA: 0x00658412 File Offset: 0x00656612
		// (set) Token: 0x0602E835 RID: 190517 RVA: 0x0065841A File Offset: 0x0065661A
		public object Value { get; set; }

		// Token: 0x0602E836 RID: 190518 RVA: 0x00658423 File Offset: 0x00656623
		public IClaimDynamicEntityRewardType_UnionUnion()
		{
			this.Type = IClaimDynamicEntityRewardType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602E837 RID: 190519 RVA: 0x00658439 File Offset: 0x00656639
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602E838 RID: 190520 RVA: 0x0065844B File Offset: 0x0065664B
		public IClaimDynamicEntityRewardTypeT AsIClaimDynamicEntityRewardType()
		{
			return this.As<IClaimDynamicEntityRewardTypeT>();
		}

		// Token: 0x0602E839 RID: 190521 RVA: 0x00658453 File Offset: 0x00656653
		public static IClaimDynamicEntityRewardType_UnionUnion FromIClaimDynamicEntityRewardType(IClaimDynamicEntityRewardTypeT _iclaimdynamicentityrewardtype)
		{
			return new IClaimDynamicEntityRewardType_UnionUnion
			{
				Type = IClaimDynamicEntityRewardType_Union.IClaimDynamicEntityRewardType,
				Value = _iclaimdynamicentityrewardtype
			};
		}

		// Token: 0x0602E83A RID: 190522 RVA: 0x00658468 File Offset: 0x00656668
		public IClaimDynamicTrafficRewardT AsIClaimDynamicTrafficReward()
		{
			return this.As<IClaimDynamicTrafficRewardT>();
		}

		// Token: 0x0602E83B RID: 190523 RVA: 0x00658470 File Offset: 0x00656670
		public static IClaimDynamicEntityRewardType_UnionUnion FromIClaimDynamicTrafficReward(IClaimDynamicTrafficRewardT _iclaimdynamictrafficreward)
		{
			return new IClaimDynamicEntityRewardType_UnionUnion
			{
				Type = IClaimDynamicEntityRewardType_Union.IClaimDynamicTrafficReward,
				Value = _iclaimdynamictrafficreward
			};
		}

		// Token: 0x0602E83C RID: 190524 RVA: 0x00658488 File Offset: 0x00656688
		public static int Pack(FlatBufferBuilder builder, IClaimDynamicEntityRewardType_UnionUnion _o)
		{
			IClaimDynamicEntityRewardType_Union type = _o.Type;
			if (type == IClaimDynamicEntityRewardType_Union.IClaimDynamicEntityRewardType)
			{
				return IClaimDynamicEntityRewardType.Pack(builder, _o.AsIClaimDynamicEntityRewardType()).Value;
			}
			if (type != IClaimDynamicEntityRewardType_Union.IClaimDynamicTrafficReward)
			{
				return 0;
			}
			return IClaimDynamicTrafficReward.Pack(builder, _o.AsIClaimDynamicTrafficReward()).Value;
		}
	}
}
