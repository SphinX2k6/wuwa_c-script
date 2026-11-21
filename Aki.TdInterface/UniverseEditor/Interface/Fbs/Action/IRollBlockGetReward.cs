using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007687 RID: 30343
	public struct IRollBlockGetReward : IFlatbufferObject
	{
		// Token: 0x1700DEB1 RID: 57009
		// (get) Token: 0x060353AA RID: 218026 RVA: 0x00724A1D File Offset: 0x00722C1D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060353AB RID: 218027 RVA: 0x00724A2A File Offset: 0x00722C2A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060353AC RID: 218028 RVA: 0x00724A34 File Offset: 0x00722C34
		public static IRollBlockGetReward GetRootAsIRollBlockGetReward(ByteBuffer _bb)
		{
			return IRollBlockGetReward.GetRootAsIRollBlockGetReward(_bb, default(IRollBlockGetReward));
		}

		// Token: 0x060353AD RID: 218029 RVA: 0x00724A50 File Offset: 0x00722C50
		public static IRollBlockGetReward GetRootAsIRollBlockGetReward(ByteBuffer _bb, IRollBlockGetReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060353AE RID: 218030 RVA: 0x00724A6D File Offset: 0x00722C6D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060353AF RID: 218031 RVA: 0x00724A7C File Offset: 0x00722C7C
		public IRollBlockGetReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x060353B0 RID: 218032 RVA: 0x00724A8C File Offset: 0x00722C8C
		public static void StartIRollBlockGetReward(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x060353B1 RID: 218033 RVA: 0x00724A95 File Offset: 0x00722C95
		public static Offset<IRollBlockGetReward> EndIRollBlockGetReward(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlockGetReward>(builder.EndTable());
		}

		// Token: 0x060353B2 RID: 218034 RVA: 0x00724AA4 File Offset: 0x00722CA4
		public IRollBlockGetRewardT UnPack()
		{
			IRollBlockGetRewardT rollBlockGetRewardT = new IRollBlockGetRewardT();
			this.UnPackTo(rollBlockGetRewardT);
			return rollBlockGetRewardT;
		}

		// Token: 0x060353B3 RID: 218035 RVA: 0x00724ABF File Offset: 0x00722CBF
		public void UnPackTo(IRollBlockGetRewardT _o)
		{
		}

		// Token: 0x060353B4 RID: 218036 RVA: 0x00724AC4 File Offset: 0x00722CC4
		public static Offset<IRollBlockGetReward> Pack(FlatBufferBuilder builder, IRollBlockGetRewardT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRollBlockGetReward>);
			}
			IRollBlockGetReward.StartIRollBlockGetReward(builder);
			return IRollBlockGetReward.EndIRollBlockGetReward(builder);
		}

		// Token: 0x0401287A RID: 75898
		private Table __p;
	}
}
