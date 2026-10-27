using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C3E RID: 3134
	public struct EntrustType : IFlatbufferObject
	{
		// Token: 0x17000F68 RID: 3944
		// (get) Token: 0x06006A3A RID: 27194 RVA: 0x00225608 File Offset: 0x00223808
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006A3B RID: 27195 RVA: 0x00225615 File Offset: 0x00223815
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006A3C RID: 27196 RVA: 0x0022561C File Offset: 0x0022381C
		public static EntrustType GetRootAsEntrustType(ByteBuffer _bb)
		{
			return EntrustType.GetRootAsEntrustType(_bb, default(EntrustType));
		}

		// Token: 0x06006A3D RID: 27197 RVA: 0x00225638 File Offset: 0x00223838
		public static EntrustType GetRootAsEntrustType(ByteBuffer _bb, EntrustType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006A3E RID: 27198 RVA: 0x00225655 File Offset: 0x00223855
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006A3F RID: 27199 RVA: 0x00225664 File Offset: 0x00223864
		public EntrustType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000F69 RID: 3945
		// (get) Token: 0x06006A40 RID: 27200 RVA: 0x00225674 File Offset: 0x00223874
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

		// Token: 0x17000F6A RID: 3946
		// (get) Token: 0x06006A41 RID: 27201 RVA: 0x002256B0 File Offset: 0x002238B0
		public string Icon
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

		// Token: 0x06006A42 RID: 27202 RVA: 0x002256E7 File Offset: 0x002238E7
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06006A43 RID: 27203 RVA: 0x002256F6 File Offset: 0x002238F6
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04004C7E RID: 19582
		private Table __p;
	}
}
