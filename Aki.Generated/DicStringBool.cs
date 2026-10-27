using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011BD RID: 4541
	public struct DicStringBool : IFlatbufferObject
	{
		// Token: 0x17003ED2 RID: 16082
		// (get) Token: 0x0600EA2F RID: 59951 RVA: 0x00347A1D File Offset: 0x00345C1D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EA30 RID: 59952 RVA: 0x00347A2A File Offset: 0x00345C2A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EA31 RID: 59953 RVA: 0x00347A34 File Offset: 0x00345C34
		public static DicStringBool GetRootAsDicStringBool(ByteBuffer _bb)
		{
			return DicStringBool.GetRootAsDicStringBool(_bb, default(DicStringBool));
		}

		// Token: 0x0600EA32 RID: 59954 RVA: 0x00347A50 File Offset: 0x00345C50
		public static DicStringBool GetRootAsDicStringBool(ByteBuffer _bb, DicStringBool obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EA33 RID: 59955 RVA: 0x00347A6D File Offset: 0x00345C6D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EA34 RID: 59956 RVA: 0x00347A7C File Offset: 0x00345C7C
		public DicStringBool __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003ED3 RID: 16083
		// (get) Token: 0x0600EA35 RID: 59957 RVA: 0x00347A8C File Offset: 0x00345C8C
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

		// Token: 0x0600EA36 RID: 59958 RVA: 0x00347AC3 File Offset: 0x00345CC3
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600EA37 RID: 59959 RVA: 0x00347AD2 File Offset: 0x00345CD2
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17003ED4 RID: 16084
		// (get) Token: 0x0600EA38 RID: 59960 RVA: 0x00347AEC File Offset: 0x00345CEC
		public bool Value
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0400530E RID: 21262
		private Table __p;
	}
}
