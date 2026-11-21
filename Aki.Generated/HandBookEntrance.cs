using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E08 RID: 3592
	public struct HandBookEntrance : IFlatbufferObject
	{
		// Token: 0x17001740 RID: 5952
		// (get) Token: 0x0600840A RID: 33802 RVA: 0x00271724 File Offset: 0x0026F924
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600840B RID: 33803 RVA: 0x00271731 File Offset: 0x0026F931
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600840C RID: 33804 RVA: 0x00271738 File Offset: 0x0026F938
		public static HandBookEntrance GetRootAsHandBookEntrance(ByteBuffer _bb)
		{
			return HandBookEntrance.GetRootAsHandBookEntrance(_bb, default(HandBookEntrance));
		}

		// Token: 0x0600840D RID: 33805 RVA: 0x00271754 File Offset: 0x0026F954
		public static HandBookEntrance GetRootAsHandBookEntrance(ByteBuffer _bb, HandBookEntrance obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600840E RID: 33806 RVA: 0x00271771 File Offset: 0x0026F971
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600840F RID: 33807 RVA: 0x00271780 File Offset: 0x0026F980
		public HandBookEntrance __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001741 RID: 5953
		// (get) Token: 0x06008410 RID: 33808 RVA: 0x00271790 File Offset: 0x0026F990
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

		// Token: 0x17001742 RID: 5954
		// (get) Token: 0x06008411 RID: 33809 RVA: 0x002717CC File Offset: 0x0026F9CC
		public int SortId
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

		// Token: 0x17001743 RID: 5955
		// (get) Token: 0x06008412 RID: 33810 RVA: 0x00271808 File Offset: 0x0026FA08
		public string Name
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

		// Token: 0x06008413 RID: 33811 RVA: 0x0027183F File Offset: 0x0026FA3F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06008414 RID: 33812 RVA: 0x0027184E File Offset: 0x0026FA4E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001744 RID: 5956
		// (get) Token: 0x06008415 RID: 33813 RVA: 0x00271868 File Offset: 0x0026FA68
		public string TitleIcon
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

		// Token: 0x06008416 RID: 33814 RVA: 0x002718A0 File Offset: 0x0026FAA0
		public Span<byte> GetTitleIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06008417 RID: 33815 RVA: 0x002718B0 File Offset: 0x0026FAB0
		public byte[] GetTitleIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001745 RID: 5957
		// (get) Token: 0x06008418 RID: 33816 RVA: 0x002718C8 File Offset: 0x0026FAC8
		public string Texture
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

		// Token: 0x06008419 RID: 33817 RVA: 0x00271900 File Offset: 0x0026FB00
		public Span<byte> GetTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600841A RID: 33818 RVA: 0x00271910 File Offset: 0x0026FB10
		public byte[] GetTextureArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04005380 RID: 21376
		private Table __p;
	}
}
