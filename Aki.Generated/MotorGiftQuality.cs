using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E57 RID: 3671
	public struct MotorGiftQuality : IFlatbufferObject
	{
		// Token: 0x17002188 RID: 8584
		// (get) Token: 0x06009A57 RID: 39511 RVA: 0x002934FD File Offset: 0x002916FD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009A58 RID: 39512 RVA: 0x0029350A File Offset: 0x0029170A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009A59 RID: 39513 RVA: 0x00293514 File Offset: 0x00291714
		public static MotorGiftQuality GetRootAsMotorGiftQuality(ByteBuffer _bb)
		{
			return MotorGiftQuality.GetRootAsMotorGiftQuality(_bb, default(MotorGiftQuality));
		}

		// Token: 0x06009A5A RID: 39514 RVA: 0x00293530 File Offset: 0x00291730
		public static MotorGiftQuality GetRootAsMotorGiftQuality(ByteBuffer _bb, MotorGiftQuality obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009A5B RID: 39515 RVA: 0x0029354D File Offset: 0x0029174D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009A5C RID: 39516 RVA: 0x0029355C File Offset: 0x0029175C
		public MotorGiftQuality __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002189 RID: 8585
		// (get) Token: 0x06009A5D RID: 39517 RVA: 0x0029356C File Offset: 0x0029176C
		public int QualityId
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

		// Token: 0x1700218A RID: 8586
		// (get) Token: 0x06009A5E RID: 39518 RVA: 0x002935A8 File Offset: 0x002917A8
		public string Path
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

		// Token: 0x06009A5F RID: 39519 RVA: 0x002935DF File Offset: 0x002917DF
		public Span<byte> GetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06009A60 RID: 39520 RVA: 0x002935EE File Offset: 0x002917EE
		public byte[] GetPathArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700218B RID: 8587
		// (get) Token: 0x06009A61 RID: 39521 RVA: 0x00293608 File Offset: 0x00291808
		public string BgA
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

		// Token: 0x06009A62 RID: 39522 RVA: 0x0029363F File Offset: 0x0029183F
		public Span<byte> GetBgABytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06009A63 RID: 39523 RVA: 0x0029364E File Offset: 0x0029184E
		public byte[] GetBgAArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700218C RID: 8588
		// (get) Token: 0x06009A64 RID: 39524 RVA: 0x00293668 File Offset: 0x00291868
		public string BgType
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

		// Token: 0x06009A65 RID: 39525 RVA: 0x002936A0 File Offset: 0x002918A0
		public Span<byte> GetBgTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06009A66 RID: 39526 RVA: 0x002936B0 File Offset: 0x002918B0
		public byte[] GetBgTypeArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700218D RID: 8589
		// (get) Token: 0x06009A67 RID: 39527 RVA: 0x002936C8 File Offset: 0x002918C8
		public string BgC
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

		// Token: 0x06009A68 RID: 39528 RVA: 0x00293700 File Offset: 0x00291900
		public Span<byte> GetBgCBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06009A69 RID: 39529 RVA: 0x00293710 File Offset: 0x00291910
		public byte[] GetBgCArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700218E RID: 8590
		// (get) Token: 0x06009A6A RID: 39530 RVA: 0x00293728 File Offset: 0x00291928
		public string BgBar
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009A6B RID: 39531 RVA: 0x00293760 File Offset: 0x00291960
		public Span<byte> GetBgBarBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06009A6C RID: 39532 RVA: 0x00293770 File Offset: 0x00291970
		public byte[] GetBgBarArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x04004F00 RID: 20224
		private Table __p;
	}
}
