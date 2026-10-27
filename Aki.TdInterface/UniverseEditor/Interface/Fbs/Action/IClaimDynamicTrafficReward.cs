using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200637C RID: 25468
	public struct IClaimDynamicTrafficReward : IFlatbufferObject
	{
		// Token: 0x1700BDEC RID: 48620
		// (get) Token: 0x0602C0D4 RID: 180436 RVA: 0x0060D3AA File Offset: 0x0060B5AA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C0D5 RID: 180437 RVA: 0x0060D3B7 File Offset: 0x0060B5B7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C0D6 RID: 180438 RVA: 0x0060D3C0 File Offset: 0x0060B5C0
		public static IClaimDynamicTrafficReward GetRootAsIClaimDynamicTrafficReward(ByteBuffer _bb)
		{
			return IClaimDynamicTrafficReward.GetRootAsIClaimDynamicTrafficReward(_bb, default(IClaimDynamicTrafficReward));
		}

		// Token: 0x0602C0D7 RID: 180439 RVA: 0x0060D3DC File Offset: 0x0060B5DC
		public static IClaimDynamicTrafficReward GetRootAsIClaimDynamicTrafficReward(ByteBuffer _bb, IClaimDynamicTrafficReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C0D8 RID: 180440 RVA: 0x0060D3F9 File Offset: 0x0060B5F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C0D9 RID: 180441 RVA: 0x0060D408 File Offset: 0x0060B608
		public IClaimDynamicTrafficReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BDED RID: 48621
		// (get) Token: 0x0602C0DA RID: 180442 RVA: 0x0060D418 File Offset: 0x0060B618
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

		// Token: 0x0602C0DB RID: 180443 RVA: 0x0060D454 File Offset: 0x0060B654
		public static Offset<IClaimDynamicTrafficReward> CreateIClaimDynamicTrafficReward(FlatBufferBuilder builder, EDynamicEntityRewardType Type = EDynamicEntityRewardType.Traffic)
		{
			builder.StartTable(1);
			IClaimDynamicTrafficReward.AddType(builder, Type);
			return IClaimDynamicTrafficReward.EndIClaimDynamicTrafficReward(builder);
		}

		// Token: 0x0602C0DC RID: 180444 RVA: 0x0060D46A File Offset: 0x0060B66A
		public static void StartIClaimDynamicTrafficReward(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602C0DD RID: 180445 RVA: 0x0060D473 File Offset: 0x0060B673
		public static void AddType(FlatBufferBuilder builder, EDynamicEntityRewardType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602C0DE RID: 180446 RVA: 0x0060D47E File Offset: 0x0060B67E
		public static Offset<IClaimDynamicTrafficReward> EndIClaimDynamicTrafficReward(FlatBufferBuilder builder)
		{
			return new Offset<IClaimDynamicTrafficReward>(builder.EndTable());
		}

		// Token: 0x0602C0DF RID: 180447 RVA: 0x0060D48C File Offset: 0x0060B68C
		public IClaimDynamicTrafficRewardT UnPack()
		{
			IClaimDynamicTrafficRewardT claimDynamicTrafficRewardT = new IClaimDynamicTrafficRewardT();
			this.UnPackTo(claimDynamicTrafficRewardT);
			return claimDynamicTrafficRewardT;
		}

		// Token: 0x0602C0E0 RID: 180448 RVA: 0x0060D4A7 File Offset: 0x0060B6A7
		public void UnPackTo(IClaimDynamicTrafficRewardT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602C0E1 RID: 180449 RVA: 0x0060D4B8 File Offset: 0x0060B6B8
		public static Offset<IClaimDynamicTrafficReward> Pack(FlatBufferBuilder builder, IClaimDynamicTrafficRewardT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClaimDynamicTrafficReward>);
			}
			return IClaimDynamicTrafficReward.CreateIClaimDynamicTrafficReward(builder, _o.Type);
		}

		// Token: 0x0401094B RID: 67915
		private Table __p;
	}
}
