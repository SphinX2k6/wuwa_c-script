using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200125E RID: 4702
	public struct TetrisShape : IFlatbufferObject
	{
		// Token: 0x17003DB5 RID: 15797
		// (get) Token: 0x0600EBDD RID: 60381 RVA: 0x00358634 File Offset: 0x00356834
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EBDE RID: 60382 RVA: 0x00358641 File Offset: 0x00356841
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EBDF RID: 60383 RVA: 0x00358648 File Offset: 0x00356848
		public static TetrisShape GetRootAsTetrisShape(ByteBuffer _bb)
		{
			return TetrisShape.GetRootAsTetrisShape(_bb, default(TetrisShape));
		}

		// Token: 0x0600EBE0 RID: 60384 RVA: 0x00358664 File Offset: 0x00356864
		public static TetrisShape GetRootAsTetrisShape(ByteBuffer _bb, TetrisShape obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EBE1 RID: 60385 RVA: 0x00358681 File Offset: 0x00356881
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EBE2 RID: 60386 RVA: 0x00358690 File Offset: 0x00356890
		public TetrisShape __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003DB6 RID: 15798
		// (get) Token: 0x0600EBE3 RID: 60387 RVA: 0x003586A0 File Offset: 0x003568A0
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

		// Token: 0x17003DB7 RID: 15799
		// (get) Token: 0x0600EBE4 RID: 60388 RVA: 0x003586DC File Offset: 0x003568DC
		public string Column1
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

		// Token: 0x0600EBE5 RID: 60389 RVA: 0x00358713 File Offset: 0x00356913
		public Span<byte> GetColumn1Bytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600EBE6 RID: 60390 RVA: 0x00358722 File Offset: 0x00356922
		public byte[] GetColumn1Array()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003DB8 RID: 15800
		// (get) Token: 0x0600EBE7 RID: 60391 RVA: 0x0035873C File Offset: 0x0035693C
		public string Column2
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

		// Token: 0x0600EBE8 RID: 60392 RVA: 0x00358773 File Offset: 0x00356973
		public Span<byte> GetColumn2Bytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600EBE9 RID: 60393 RVA: 0x00358782 File Offset: 0x00356982
		public byte[] GetColumn2Array()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003DB9 RID: 15801
		// (get) Token: 0x0600EBEA RID: 60394 RVA: 0x0035879C File Offset: 0x0035699C
		public string Column3
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

		// Token: 0x0600EBEB RID: 60395 RVA: 0x003587D4 File Offset: 0x003569D4
		public Span<byte> GetColumn3Bytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600EBEC RID: 60396 RVA: 0x003587E4 File Offset: 0x003569E4
		public byte[] GetColumn3Array()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003DBA RID: 15802
		// (get) Token: 0x0600EBED RID: 60397 RVA: 0x003587FC File Offset: 0x003569FC
		public string Column4
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

		// Token: 0x0600EBEE RID: 60398 RVA: 0x00358834 File Offset: 0x00356A34
		public Span<byte> GetColumn4Bytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600EBEF RID: 60399 RVA: 0x00358844 File Offset: 0x00356A44
		public byte[] GetColumn4Array()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17003DBB RID: 15803
		// (get) Token: 0x0600EBF0 RID: 60400 RVA: 0x0035885C File Offset: 0x00356A5C
		public string Column5
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

		// Token: 0x0600EBF1 RID: 60401 RVA: 0x00358894 File Offset: 0x00356A94
		public Span<byte> GetColumn5Bytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600EBF2 RID: 60402 RVA: 0x003588A4 File Offset: 0x00356AA4
		public byte[] GetColumn5Array()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17003DBC RID: 15804
		// (get) Token: 0x0600EBF3 RID: 60403 RVA: 0x003588BC File Offset: 0x00356ABC
		public int Weight
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040058A9 RID: 22697
		private Table __p;
	}
}
