using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200637F RID: 25471
	public struct IClaimLevelPlayReward : IFlatbufferObject
	{
		// Token: 0x1700BDEF RID: 48623
		// (get) Token: 0x0602C0E6 RID: 180454 RVA: 0x0060D521 File Offset: 0x0060B721
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C0E7 RID: 180455 RVA: 0x0060D52E File Offset: 0x0060B72E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C0E8 RID: 180456 RVA: 0x0060D538 File Offset: 0x0060B738
		public static IClaimLevelPlayReward GetRootAsIClaimLevelPlayReward(ByteBuffer _bb)
		{
			return IClaimLevelPlayReward.GetRootAsIClaimLevelPlayReward(_bb, default(IClaimLevelPlayReward));
		}

		// Token: 0x0602C0E9 RID: 180457 RVA: 0x0060D554 File Offset: 0x0060B754
		public static IClaimLevelPlayReward GetRootAsIClaimLevelPlayReward(ByteBuffer _bb, IClaimLevelPlayReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C0EA RID: 180458 RVA: 0x0060D571 File Offset: 0x0060B771
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C0EB RID: 180459 RVA: 0x0060D580 File Offset: 0x0060B780
		public IClaimLevelPlayReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602C0EC RID: 180460 RVA: 0x0060D590 File Offset: 0x0060B790
		public static void StartIClaimLevelPlayReward(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x0602C0ED RID: 180461 RVA: 0x0060D599 File Offset: 0x0060B799
		public static Offset<IClaimLevelPlayReward> EndIClaimLevelPlayReward(FlatBufferBuilder builder)
		{
			return new Offset<IClaimLevelPlayReward>(builder.EndTable());
		}

		// Token: 0x0602C0EE RID: 180462 RVA: 0x0060D5A8 File Offset: 0x0060B7A8
		public IClaimLevelPlayRewardT UnPack()
		{
			IClaimLevelPlayRewardT claimLevelPlayRewardT = new IClaimLevelPlayRewardT();
			this.UnPackTo(claimLevelPlayRewardT);
			return claimLevelPlayRewardT;
		}

		// Token: 0x0602C0EF RID: 180463 RVA: 0x0060D5C3 File Offset: 0x0060B7C3
		public void UnPackTo(IClaimLevelPlayRewardT _o)
		{
		}

		// Token: 0x0602C0F0 RID: 180464 RVA: 0x0060D5C8 File Offset: 0x0060B7C8
		public static Offset<IClaimLevelPlayReward> Pack(FlatBufferBuilder builder, IClaimLevelPlayRewardT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClaimLevelPlayReward>);
			}
			IClaimLevelPlayReward.StartIClaimLevelPlayReward(builder);
			return IClaimLevelPlayReward.EndIClaimLevelPlayReward(builder);
		}

		// Token: 0x0401094D RID: 67917
		private Table __p;
	}
}
