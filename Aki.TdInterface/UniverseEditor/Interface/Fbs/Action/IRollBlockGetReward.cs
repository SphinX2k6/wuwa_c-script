using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F00 RID: 28416
	public struct IRollBlockGetReward : IFlatbufferObject
	{
		// Token: 0x1700D355 RID: 54101
		// (get) Token: 0x06032352 RID: 205650 RVA: 0x006C8AB5 File Offset: 0x006C6CB5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032353 RID: 205651 RVA: 0x006C8AC2 File Offset: 0x006C6CC2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032354 RID: 205652 RVA: 0x006C8ACC File Offset: 0x006C6CCC
		public static IRollBlockGetReward GetRootAsIRollBlockGetReward(ByteBuffer _bb)
		{
			return IRollBlockGetReward.GetRootAsIRollBlockGetReward(_bb, default(IRollBlockGetReward));
		}

		// Token: 0x06032355 RID: 205653 RVA: 0x006C8AE8 File Offset: 0x006C6CE8
		public static IRollBlockGetReward GetRootAsIRollBlockGetReward(ByteBuffer _bb, IRollBlockGetReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032356 RID: 205654 RVA: 0x006C8B05 File Offset: 0x006C6D05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032357 RID: 205655 RVA: 0x006C8B14 File Offset: 0x006C6D14
		public IRollBlockGetReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06032358 RID: 205656 RVA: 0x006C8B24 File Offset: 0x006C6D24
		public static void StartIRollBlockGetReward(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x06032359 RID: 205657 RVA: 0x006C8B2D File Offset: 0x006C6D2D
		public static Offset<IRollBlockGetReward> EndIRollBlockGetReward(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlockGetReward>(builder.EndTable());
		}

		// Token: 0x0603235A RID: 205658 RVA: 0x006C8B3C File Offset: 0x006C6D3C
		public IRollBlockGetRewardT UnPack()
		{
			IRollBlockGetRewardT rollBlockGetRewardT = new IRollBlockGetRewardT();
			this.UnPackTo(rollBlockGetRewardT);
			return rollBlockGetRewardT;
		}

		// Token: 0x0603235B RID: 205659 RVA: 0x006C8B57 File Offset: 0x006C6D57
		public void UnPackTo(IRollBlockGetRewardT _o)
		{
		}

		// Token: 0x0603235C RID: 205660 RVA: 0x006C8B5C File Offset: 0x006C6D5C
		public static Offset<IRollBlockGetReward> Pack(FlatBufferBuilder builder, IRollBlockGetRewardT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRollBlockGetReward>);
			}
			IRollBlockGetReward.StartIRollBlockGetReward(builder);
			return IRollBlockGetReward.EndIRollBlockGetReward(builder);
		}

		// Token: 0x040118F2 RID: 71922
		private Table __p;
	}
}
