using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D13 RID: 3347
	public struct EncircleMapItem : IFlatbufferObject
	{
		// Token: 0x17000F5E RID: 3934
		// (get) Token: 0x06006F26 RID: 28454 RVA: 0x0024267B File Offset: 0x0024087B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006F27 RID: 28455 RVA: 0x00242688 File Offset: 0x00240888
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006F28 RID: 28456 RVA: 0x00242690 File Offset: 0x00240890
		public static EncircleMapItem GetRootAsEncircleMapItem(ByteBuffer _bb)
		{
			return EncircleMapItem.GetRootAsEncircleMapItem(_bb, default(EncircleMapItem));
		}

		// Token: 0x06006F29 RID: 28457 RVA: 0x002426AC File Offset: 0x002408AC
		public static EncircleMapItem GetRootAsEncircleMapItem(ByteBuffer _bb, EncircleMapItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006F2A RID: 28458 RVA: 0x002426C9 File Offset: 0x002408C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006F2B RID: 28459 RVA: 0x002426D8 File Offset: 0x002408D8
		public EncircleMapItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000F5F RID: 3935
		// (get) Token: 0x06006F2C RID: 28460 RVA: 0x002426E8 File Offset: 0x002408E8
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

		// Token: 0x17000F60 RID: 3936
		// (get) Token: 0x06006F2D RID: 28461 RVA: 0x00242724 File Offset: 0x00240924
		public EncircleHexType Type
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EncircleHexType.Plain;
				}
				return (EncircleHexType)this.__p.bb.GetSbyte(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000F61 RID: 3937
		// (get) Token: 0x06006F2E RID: 28462 RVA: 0x00242760 File Offset: 0x00240960
		public string Memo
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

		// Token: 0x06006F2F RID: 28463 RVA: 0x00242797 File Offset: 0x00240997
		public Span<byte> GetMemoBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06006F30 RID: 28464 RVA: 0x002427A6 File Offset: 0x002409A6
		public byte[] GetMemoArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F62 RID: 3938
		// (get) Token: 0x06006F31 RID: 28465 RVA: 0x002427C0 File Offset: 0x002409C0
		public string ResourcePath
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

		// Token: 0x06006F32 RID: 28466 RVA: 0x002427F8 File Offset: 0x002409F8
		public Span<byte> GetResourcePathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06006F33 RID: 28467 RVA: 0x00242808 File Offset: 0x00240A08
		public byte[] GetResourcePathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F63 RID: 3939
		// (get) Token: 0x06006F34 RID: 28468 RVA: 0x00242820 File Offset: 0x00240A20
		public string SpinePath
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

		// Token: 0x06006F35 RID: 28469 RVA: 0x00242858 File Offset: 0x00240A58
		public Span<byte> GetSpinePathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06006F36 RID: 28470 RVA: 0x00242868 File Offset: 0x00240A68
		public byte[] GetSpinePathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04005253 RID: 21075
		private Table __p;
	}
}
