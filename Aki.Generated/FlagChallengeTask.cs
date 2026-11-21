using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D7D RID: 3453
	public struct FlagChallengeTask : IFlatbufferObject
	{
		// Token: 0x1700129D RID: 4765
		// (get) Token: 0x060077A2 RID: 30626 RVA: 0x002557F4 File Offset: 0x002539F4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060077A3 RID: 30627 RVA: 0x00255801 File Offset: 0x00253A01
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060077A4 RID: 30628 RVA: 0x00255808 File Offset: 0x00253A08
		public static FlagChallengeTask GetRootAsFlagChallengeTask(ByteBuffer _bb)
		{
			return FlagChallengeTask.GetRootAsFlagChallengeTask(_bb, default(FlagChallengeTask));
		}

		// Token: 0x060077A5 RID: 30629 RVA: 0x00255824 File Offset: 0x00253A24
		public static FlagChallengeTask GetRootAsFlagChallengeTask(ByteBuffer _bb, FlagChallengeTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060077A6 RID: 30630 RVA: 0x00255841 File Offset: 0x00253A41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060077A7 RID: 30631 RVA: 0x00255850 File Offset: 0x00253A50
		public FlagChallengeTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700129E RID: 4766
		// (get) Token: 0x060077A8 RID: 30632 RVA: 0x00255860 File Offset: 0x00253A60
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700129F RID: 4767
		// (get) Token: 0x060077A9 RID: 30633 RVA: 0x0025589C File Offset: 0x00253A9C
		public int ActivityId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170012A0 RID: 4768
		// (get) Token: 0x060077AA RID: 30634 RVA: 0x002558D8 File Offset: 0x00253AD8
		public int DropId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170012A1 RID: 4769
		// (get) Token: 0x060077AB RID: 30635 RVA: 0x00255914 File Offset: 0x00253B14
		public string RewardName
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060077AC RID: 30636 RVA: 0x0025594C File Offset: 0x00253B4C
		public Span<byte> GetRewardNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060077AD RID: 30637 RVA: 0x0025595C File Offset: 0x00253B5C
		public byte[] GetRewardNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x040052D4 RID: 21204
		private Table __p;
	}
}
