using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011BF RID: 4543
	public struct DicStringInt : IFlatbufferObject
	{
		// Token: 0x17003ED8 RID: 16088
		// (get) Token: 0x0600EA43 RID: 59971 RVA: 0x00347C38 File Offset: 0x00345E38
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EA44 RID: 59972 RVA: 0x00347C45 File Offset: 0x00345E45
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EA45 RID: 59973 RVA: 0x00347C4C File Offset: 0x00345E4C
		public static DicStringInt GetRootAsDicStringInt(ByteBuffer _bb)
		{
			return DicStringInt.GetRootAsDicStringInt(_bb, default(DicStringInt));
		}

		// Token: 0x0600EA46 RID: 59974 RVA: 0x00347C68 File Offset: 0x00345E68
		public static DicStringInt GetRootAsDicStringInt(ByteBuffer _bb, DicStringInt obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EA47 RID: 59975 RVA: 0x00347C85 File Offset: 0x00345E85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EA48 RID: 59976 RVA: 0x00347C94 File Offset: 0x00345E94
		public DicStringInt __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003ED9 RID: 16089
		// (get) Token: 0x0600EA49 RID: 59977 RVA: 0x00347CA4 File Offset: 0x00345EA4
		public string Key
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600EA4A RID: 59978 RVA: 0x00347CDB File Offset: 0x00345EDB
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600EA4B RID: 59979 RVA: 0x00347CEA File Offset: 0x00345EEA
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17003EDA RID: 16090
		// (get) Token: 0x0600EA4C RID: 59980 RVA: 0x00347D04 File Offset: 0x00345F04
		public int Value
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

		// Token: 0x04005310 RID: 21264
		private Table __p;
	}
}
