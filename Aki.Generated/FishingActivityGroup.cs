using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D59 RID: 3417
	public struct FishingActivityGroup : IFlatbufferObject
	{
		// Token: 0x1700117B RID: 4475
		// (get) Token: 0x060074BC RID: 29884 RVA: 0x0024EA55 File Offset: 0x0024CC55
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060074BD RID: 29885 RVA: 0x0024EA62 File Offset: 0x0024CC62
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060074BE RID: 29886 RVA: 0x0024EA6C File Offset: 0x0024CC6C
		public static FishingActivityGroup GetRootAsFishingActivityGroup(ByteBuffer _bb)
		{
			return FishingActivityGroup.GetRootAsFishingActivityGroup(_bb, default(FishingActivityGroup));
		}

		// Token: 0x060074BF RID: 29887 RVA: 0x0024EA88 File Offset: 0x0024CC88
		public static FishingActivityGroup GetRootAsFishingActivityGroup(ByteBuffer _bb, FishingActivityGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060074C0 RID: 29888 RVA: 0x0024EAA5 File Offset: 0x0024CCA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060074C1 RID: 29889 RVA: 0x0024EAB4 File Offset: 0x0024CCB4
		public FishingActivityGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700117C RID: 4476
		// (get) Token: 0x060074C2 RID: 29890 RVA: 0x0024EAC4 File Offset: 0x0024CCC4
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

		// Token: 0x1700117D RID: 4477
		// (get) Token: 0x060074C3 RID: 29891 RVA: 0x0024EB00 File Offset: 0x0024CD00
		public string GroupName
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060074C4 RID: 29892 RVA: 0x0024EB37 File Offset: 0x0024CD37
		public Span<byte> GetGroupNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060074C5 RID: 29893 RVA: 0x0024EB46 File Offset: 0x0024CD46
		public byte[] GetGroupNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x040052A4 RID: 21156
		private Table __p;
	}
}
