using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069ED RID: 27117
	public struct IClaimDynamicTrafficReward : IFlatbufferObject
	{
		// Token: 0x1700C774 RID: 51060
		// (get) Token: 0x0602E83E RID: 190526 RVA: 0x006584FE File Offset: 0x006566FE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E83F RID: 190527 RVA: 0x0065850B File Offset: 0x0065670B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E840 RID: 190528 RVA: 0x00658514 File Offset: 0x00656714
		public static IClaimDynamicTrafficReward GetRootAsIClaimDynamicTrafficReward(ByteBuffer _bb)
		{
			return IClaimDynamicTrafficReward.GetRootAsIClaimDynamicTrafficReward(_bb, default(IClaimDynamicTrafficReward));
		}

		// Token: 0x0602E841 RID: 190529 RVA: 0x00658530 File Offset: 0x00656730
		public static IClaimDynamicTrafficReward GetRootAsIClaimDynamicTrafficReward(ByteBuffer _bb, IClaimDynamicTrafficReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E842 RID: 190530 RVA: 0x0065854D File Offset: 0x0065674D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E843 RID: 190531 RVA: 0x0065855C File Offset: 0x0065675C
		public IClaimDynamicTrafficReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C775 RID: 51061
		// (get) Token: 0x0602E844 RID: 190532 RVA: 0x0065856C File Offset: 0x0065676C
		public EDynamicEntityRewardType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDynamicEntityRewardType.Traffic;
				}
				return (EDynamicEntityRewardType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602E845 RID: 190533 RVA: 0x006585A8 File Offset: 0x006567A8
		public static Offset<IClaimDynamicTrafficReward> CreateIClaimDynamicTrafficReward(FlatBufferBuilder builder, EDynamicEntityRewardType Type = EDynamicEntityRewardType.Traffic)
		{
			builder.StartTable(1);
			IClaimDynamicTrafficReward.AddType(builder, Type);
			return IClaimDynamicTrafficReward.EndIClaimDynamicTrafficReward(builder);
		}

		// Token: 0x0602E846 RID: 190534 RVA: 0x006585BE File Offset: 0x006567BE
		public static void StartIClaimDynamicTrafficReward(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602E847 RID: 190535 RVA: 0x006585C7 File Offset: 0x006567C7
		public static void AddType(FlatBufferBuilder builder, EDynamicEntityRewardType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E848 RID: 190536 RVA: 0x006585D2 File Offset: 0x006567D2
		public static Offset<IClaimDynamicTrafficReward> EndIClaimDynamicTrafficReward(FlatBufferBuilder builder)
		{
			return new Offset<IClaimDynamicTrafficReward>(builder.EndTable());
		}

		// Token: 0x0602E849 RID: 190537 RVA: 0x006585E0 File Offset: 0x006567E0
		public IClaimDynamicTrafficRewardT UnPack()
		{
			IClaimDynamicTrafficRewardT claimDynamicTrafficRewardT = new IClaimDynamicTrafficRewardT();
			this.UnPackTo(claimDynamicTrafficRewardT);
			return claimDynamicTrafficRewardT;
		}

		// Token: 0x0602E84A RID: 190538 RVA: 0x006585FB File Offset: 0x006567FB
		public void UnPackTo(IClaimDynamicTrafficRewardT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602E84B RID: 190539 RVA: 0x0065860C File Offset: 0x0065680C
		public static Offset<IClaimDynamicTrafficReward> Pack(FlatBufferBuilder builder, IClaimDynamicTrafficRewardT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClaimDynamicTrafficReward>);
			}
			return IClaimDynamicTrafficReward.CreateIClaimDynamicTrafficReward(builder, _o.Type);
		}

		// Token: 0x04011760 RID: 71520
		private Table __p;
	}
}
