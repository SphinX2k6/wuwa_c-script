using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011BB RID: 4539
	public struct DicIntString : IFlatbufferObject
	{
		// Token: 0x17003ECC RID: 16076
		// (get) Token: 0x0600EA1D RID: 59933 RVA: 0x0034780E File Offset: 0x00345A0E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EA1E RID: 59934 RVA: 0x0034781B File Offset: 0x00345A1B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EA1F RID: 59935 RVA: 0x00347824 File Offset: 0x00345A24
		public static DicIntString GetRootAsDicIntString(ByteBuffer _bb)
		{
			return DicIntString.GetRootAsDicIntString(_bb, default(DicIntString));
		}

		// Token: 0x0600EA20 RID: 59936 RVA: 0x00347840 File Offset: 0x00345A40
		public static DicIntString GetRootAsDicIntString(ByteBuffer _bb, DicIntString obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EA21 RID: 59937 RVA: 0x0034785D File Offset: 0x00345A5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EA22 RID: 59938 RVA: 0x0034786C File Offset: 0x00345A6C
		public DicIntString __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003ECD RID: 16077
		// (get) Token: 0x0600EA23 RID: 59939 RVA: 0x0034787C File Offset: 0x00345A7C
		public int Key
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

		// Token: 0x17003ECE RID: 16078
		// (get) Token: 0x0600EA24 RID: 59940 RVA: 0x003478B8 File Offset: 0x00345AB8
		public string Value
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

		// Token: 0x0600EA25 RID: 59941 RVA: 0x003478EF File Offset: 0x00345AEF
		public Span<byte> GetValueBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600EA26 RID: 59942 RVA: 0x003478FE File Offset: 0x00345AFE
		public byte[] GetValueArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0400530C RID: 21260
		private Table __p;
	}
}
