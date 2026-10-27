using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011BE RID: 4542
	public struct DicStringFloat : IFlatbufferObject
	{
		// Token: 0x17003ED5 RID: 16085
		// (get) Token: 0x0600EA39 RID: 59961 RVA: 0x00347B2B File Offset: 0x00345D2B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EA3A RID: 59962 RVA: 0x00347B38 File Offset: 0x00345D38
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EA3B RID: 59963 RVA: 0x00347B40 File Offset: 0x00345D40
		public static DicStringFloat GetRootAsDicStringFloat(ByteBuffer _bb)
		{
			return DicStringFloat.GetRootAsDicStringFloat(_bb, default(DicStringFloat));
		}

		// Token: 0x0600EA3C RID: 59964 RVA: 0x00347B5C File Offset: 0x00345D5C
		public static DicStringFloat GetRootAsDicStringFloat(ByteBuffer _bb, DicStringFloat obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EA3D RID: 59965 RVA: 0x00347B79 File Offset: 0x00345D79
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EA3E RID: 59966 RVA: 0x00347B88 File Offset: 0x00345D88
		public DicStringFloat __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003ED6 RID: 16086
		// (get) Token: 0x0600EA3F RID: 59967 RVA: 0x00347B98 File Offset: 0x00345D98
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

		// Token: 0x0600EA40 RID: 59968 RVA: 0x00347BCF File Offset: 0x00345DCF
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600EA41 RID: 59969 RVA: 0x00347BDE File Offset: 0x00345DDE
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17003ED7 RID: 16087
		// (get) Token: 0x0600EA42 RID: 59970 RVA: 0x00347BF8 File Offset: 0x00345DF8
		public float Value
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0400530F RID: 21263
		private Table __p;
	}
}
