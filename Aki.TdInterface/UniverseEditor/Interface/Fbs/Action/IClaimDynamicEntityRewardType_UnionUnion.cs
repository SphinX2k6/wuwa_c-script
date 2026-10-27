using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200637A RID: 25466
	public class IClaimDynamicEntityRewardType_UnionUnion
	{
		// Token: 0x1700BDEA RID: 48618
		// (get) Token: 0x0602C0C8 RID: 180424 RVA: 0x0060D2AD File Offset: 0x0060B4AD
		// (set) Token: 0x0602C0C9 RID: 180425 RVA: 0x0060D2B5 File Offset: 0x0060B4B5
		public IClaimDynamicEntityRewardType_Union Type { get; set; }

		// Token: 0x1700BDEB RID: 48619
		// (get) Token: 0x0602C0CA RID: 180426 RVA: 0x0060D2BE File Offset: 0x0060B4BE
		// (set) Token: 0x0602C0CB RID: 180427 RVA: 0x0060D2C6 File Offset: 0x0060B4C6
		public object Value { get; set; }

		// Token: 0x0602C0CC RID: 180428 RVA: 0x0060D2CF File Offset: 0x0060B4CF
		public IClaimDynamicEntityRewardType_UnionUnion()
		{
			this.Type = IClaimDynamicEntityRewardType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602C0CD RID: 180429 RVA: 0x0060D2E5 File Offset: 0x0060B4E5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602C0CE RID: 180430 RVA: 0x0060D2F7 File Offset: 0x0060B4F7
		public IClaimDynamicEntityRewardTypeT AsIClaimDynamicEntityRewardType()
		{
			return this.As<IClaimDynamicEntityRewardTypeT>();
		}

		// Token: 0x0602C0CF RID: 180431 RVA: 0x0060D2FF File Offset: 0x0060B4FF
		public static IClaimDynamicEntityRewardType_UnionUnion FromIClaimDynamicEntityRewardType(IClaimDynamicEntityRewardTypeT _iclaimdynamicentityrewardtype)
		{
			return new IClaimDynamicEntityRewardType_UnionUnion
			{
				Type = IClaimDynamicEntityRewardType_Union.IClaimDynamicEntityRewardType,
				Value = _iclaimdynamicentityrewardtype
			};
		}

		// Token: 0x0602C0D0 RID: 180432 RVA: 0x0060D314 File Offset: 0x0060B514
		public IClaimDynamicTrafficRewardT AsIClaimDynamicTrafficReward()
		{
			return this.As<IClaimDynamicTrafficRewardT>();
		}

		// Token: 0x0602C0D1 RID: 180433 RVA: 0x0060D31C File Offset: 0x0060B51C
		public static IClaimDynamicEntityRewardType_UnionUnion FromIClaimDynamicTrafficReward(IClaimDynamicTrafficRewardT _iclaimdynamictrafficreward)
		{
			return new IClaimDynamicEntityRewardType_UnionUnion
			{
				Type = IClaimDynamicEntityRewardType_Union.IClaimDynamicTrafficReward,
				Value = _iclaimdynamictrafficreward
			};
		}

		// Token: 0x0602C0D2 RID: 180434 RVA: 0x0060D334 File Offset: 0x0060B534
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
