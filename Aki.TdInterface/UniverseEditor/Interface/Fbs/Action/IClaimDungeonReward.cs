using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069E1 RID: 27105
	public struct IClaimDungeonReward : IFlatbufferObject
	{
		// Token: 0x1700C76B RID: 51051
		// (get) Token: 0x0602E801 RID: 190465 RVA: 0x00657FA5 File Offset: 0x006561A5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E802 RID: 190466 RVA: 0x00657FB2 File Offset: 0x006561B2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E803 RID: 190467 RVA: 0x00657FBC File Offset: 0x006561BC
		public static IClaimDungeonReward GetRootAsIClaimDungeonReward(ByteBuffer _bb)
		{
			return IClaimDungeonReward.GetRootAsIClaimDungeonReward(_bb, default(IClaimDungeonReward));
		}

		// Token: 0x0602E804 RID: 190468 RVA: 0x00657FD8 File Offset: 0x006561D8
		public static IClaimDungeonReward GetRootAsIClaimDungeonReward(ByteBuffer _bb, IClaimDungeonReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E805 RID: 190469 RVA: 0x00657FF5 File Offset: 0x006561F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E806 RID: 190470 RVA: 0x00658004 File Offset: 0x00656204
		public IClaimDungeonReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602E807 RID: 190471 RVA: 0x00658014 File Offset: 0x00656214
		public static void StartIClaimDungeonReward(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x0602E808 RID: 190472 RVA: 0x0065801D File Offset: 0x0065621D
		public static Offset<IClaimDungeonReward> EndIClaimDungeonReward(FlatBufferBuilder builder)
		{
			return new Offset<IClaimDungeonReward>(builder.EndTable());
		}

		// Token: 0x0602E809 RID: 190473 RVA: 0x0065802C File Offset: 0x0065622C
		public IClaimDungeonRewardT UnPack()
		{
			IClaimDungeonRewardT claimDungeonRewardT = new IClaimDungeonRewardT();
			this.UnPackTo(claimDungeonRewardT);
			return claimDungeonRewardT;
		}

		// Token: 0x0602E80A RID: 190474 RVA: 0x00658047 File Offset: 0x00656247
		public void UnPackTo(IClaimDungeonRewardT _o)
		{
		}

		// Token: 0x0602E80B RID: 190475 RVA: 0x0065804C File Offset: 0x0065624C
		public static Offset<IClaimDungeonReward> Pack(FlatBufferBuilder builder, IClaimDungeonRewardT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClaimDungeonReward>);
			}
			IClaimDungeonReward.StartIClaimDungeonReward(builder);
			return IClaimDungeonReward.EndIClaimDungeonReward(builder);
		}

		// Token: 0x04011755 RID: 71509
		private Table __p;
	}
}
