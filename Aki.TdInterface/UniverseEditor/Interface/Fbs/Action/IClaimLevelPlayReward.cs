using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069F0 RID: 27120
	public struct IClaimLevelPlayReward : IFlatbufferObject
	{
		// Token: 0x1700C777 RID: 51063
		// (get) Token: 0x0602E850 RID: 190544 RVA: 0x00658675 File Offset: 0x00656875
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E851 RID: 190545 RVA: 0x00658682 File Offset: 0x00656882
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E852 RID: 190546 RVA: 0x0065868C File Offset: 0x0065688C
		public static IClaimLevelPlayReward GetRootAsIClaimLevelPlayReward(ByteBuffer _bb)
		{
			return IClaimLevelPlayReward.GetRootAsIClaimLevelPlayReward(_bb, default(IClaimLevelPlayReward));
		}

		// Token: 0x0602E853 RID: 190547 RVA: 0x006586A8 File Offset: 0x006568A8
		public static IClaimLevelPlayReward GetRootAsIClaimLevelPlayReward(ByteBuffer _bb, IClaimLevelPlayReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E854 RID: 190548 RVA: 0x006586C5 File Offset: 0x006568C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E855 RID: 190549 RVA: 0x006586D4 File Offset: 0x006568D4
		public IClaimLevelPlayReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602E856 RID: 190550 RVA: 0x006586E4 File Offset: 0x006568E4
		public static void StartIClaimLevelPlayReward(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x0602E857 RID: 190551 RVA: 0x006586ED File Offset: 0x006568ED
		public static Offset<IClaimLevelPlayReward> EndIClaimLevelPlayReward(FlatBufferBuilder builder)
		{
			return new Offset<IClaimLevelPlayReward>(builder.EndTable());
		}

		// Token: 0x0602E858 RID: 190552 RVA: 0x006586FC File Offset: 0x006568FC
		public IClaimLevelPlayRewardT UnPack()
		{
			IClaimLevelPlayRewardT claimLevelPlayRewardT = new IClaimLevelPlayRewardT();
			this.UnPackTo(claimLevelPlayRewardT);
			return claimLevelPlayRewardT;
		}

		// Token: 0x0602E859 RID: 190553 RVA: 0x00658717 File Offset: 0x00656917
		public void UnPackTo(IClaimLevelPlayRewardT _o)
		{
		}

		// Token: 0x0602E85A RID: 190554 RVA: 0x0065871C File Offset: 0x0065691C
		public static Offset<IClaimLevelPlayReward> Pack(FlatBufferBuilder builder, IClaimLevelPlayRewardT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClaimLevelPlayReward>);
			}
			IClaimLevelPlayReward.StartIClaimLevelPlayReward(builder);
			return IClaimLevelPlayReward.EndIClaimLevelPlayReward(builder);
		}

		// Token: 0x04011762 RID: 71522
		private Table __p;
	}
}
