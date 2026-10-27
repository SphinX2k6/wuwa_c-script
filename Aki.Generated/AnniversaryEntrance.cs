using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AFF RID: 2815
	public struct AnniversaryEntrance : IFlatbufferObject
	{
		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06004818 RID: 18456 RVA: 0x001D6800 File Offset: 0x001D4A00
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004819 RID: 18457 RVA: 0x001D680D File Offset: 0x001D4A0D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600481A RID: 18458 RVA: 0x001D6814 File Offset: 0x001D4A14
		public static AnniversaryEntrance GetRootAsAnniversaryEntrance(ByteBuffer _bb)
		{
			return AnniversaryEntrance.GetRootAsAnniversaryEntrance(_bb, default(AnniversaryEntrance));
		}

		// Token: 0x0600481B RID: 18459 RVA: 0x001D6830 File Offset: 0x001D4A30
		public static AnniversaryEntrance GetRootAsAnniversaryEntrance(ByteBuffer _bb, AnniversaryEntrance obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600481C RID: 18460 RVA: 0x001D684D File Offset: 0x001D4A4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600481D RID: 18461 RVA: 0x001D685C File Offset: 0x001D4A5C
		public AnniversaryEntrance __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x0600481E RID: 18462 RVA: 0x001D686C File Offset: 0x001D4A6C
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

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x0600481F RID: 18463 RVA: 0x001D68A8 File Offset: 0x001D4AA8
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

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06004820 RID: 18464 RVA: 0x001D68E4 File Offset: 0x001D4AE4
		public string IconPath
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004821 RID: 18465 RVA: 0x001D691B File Offset: 0x001D4B1B
		public Span<byte> GetIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004822 RID: 18466 RVA: 0x001D692A File Offset: 0x001D4B2A
		public byte[] GetIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04004AE0 RID: 19168
		private Table __p;
	}
}
