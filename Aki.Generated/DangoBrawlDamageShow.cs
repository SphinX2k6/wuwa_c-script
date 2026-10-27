using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BBF RID: 3007
	public struct DangoBrawlDamageShow : IFlatbufferObject
	{
		// Token: 0x17000AD2 RID: 2770
		// (get) Token: 0x06005D63 RID: 23907 RVA: 0x00208DD6 File Offset: 0x00206FD6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005D64 RID: 23908 RVA: 0x00208DE3 File Offset: 0x00206FE3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005D65 RID: 23909 RVA: 0x00208DEC File Offset: 0x00206FEC
		public static DangoBrawlDamageShow GetRootAsDangoBrawlDamageShow(ByteBuffer _bb)
		{
			return DangoBrawlDamageShow.GetRootAsDangoBrawlDamageShow(_bb, default(DangoBrawlDamageShow));
		}

		// Token: 0x06005D66 RID: 23910 RVA: 0x00208E08 File Offset: 0x00207008
		public static DangoBrawlDamageShow GetRootAsDangoBrawlDamageShow(ByteBuffer _bb, DangoBrawlDamageShow obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005D67 RID: 23911 RVA: 0x00208E25 File Offset: 0x00207025
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005D68 RID: 23912 RVA: 0x00208E34 File Offset: 0x00207034
		public DangoBrawlDamageShow __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000AD3 RID: 2771
		// (get) Token: 0x06005D69 RID: 23913 RVA: 0x00208E44 File Offset: 0x00207044
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

		// Token: 0x17000AD4 RID: 2772
		// (get) Token: 0x06005D6A RID: 23914 RVA: 0x00208E80 File Offset: 0x00207080
		public int SceneDamageConfig
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

		// Token: 0x17000AD5 RID: 2773
		// (get) Token: 0x06005D6B RID: 23915 RVA: 0x00208EBC File Offset: 0x002070BC
		public int UIDamageConfig
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

		// Token: 0x17000AD6 RID: 2774
		// (get) Token: 0x06005D6C RID: 23916 RVA: 0x00208EF8 File Offset: 0x002070F8
		public string TargetDA
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

		// Token: 0x06005D6D RID: 23917 RVA: 0x00208F30 File Offset: 0x00207130
		public Span<byte> GetTargetDABytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06005D6E RID: 23918 RVA: 0x00208F40 File Offset: 0x00207140
		public byte[] GetTargetDAArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000AD7 RID: 2775
		// (get) Token: 0x06005D6F RID: 23919 RVA: 0x00208F58 File Offset: 0x00207158
		public string OppositeDA
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005D70 RID: 23920 RVA: 0x00208F90 File Offset: 0x00207190
		public Span<byte> GetOppositeDABytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06005D71 RID: 23921 RVA: 0x00208FA0 File Offset: 0x002071A0
		public byte[] GetOppositeDAArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000AD8 RID: 2776
		// (get) Token: 0x06005D72 RID: 23922 RVA: 0x00208FB8 File Offset: 0x002071B8
		public int DAInternal
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004BE8 RID: 19432
		private Table __p;
	}
}
