using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012F3 RID: 4851
	public struct DicStringBool : IFlatbufferObject
	{
		// Token: 0x17004237 RID: 16951
		// (get) Token: 0x0600F7A0 RID: 63392 RVA: 0x003726A9 File Offset: 0x003708A9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F7A1 RID: 63393 RVA: 0x003726B6 File Offset: 0x003708B6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F7A2 RID: 63394 RVA: 0x003726C0 File Offset: 0x003708C0
		public static DicStringBool GetRootAsDicStringBool(ByteBuffer _bb)
		{
			return DicStringBool.GetRootAsDicStringBool(_bb, default(DicStringBool));
		}

		// Token: 0x0600F7A3 RID: 63395 RVA: 0x003726DC File Offset: 0x003708DC
		public static DicStringBool GetRootAsDicStringBool(ByteBuffer _bb, DicStringBool obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F7A4 RID: 63396 RVA: 0x003726F9 File Offset: 0x003708F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F7A5 RID: 63397 RVA: 0x00372708 File Offset: 0x00370908
		public DicStringBool __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17004238 RID: 16952
		// (get) Token: 0x0600F7A6 RID: 63398 RVA: 0x00372718 File Offset: 0x00370918
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

		// Token: 0x0600F7A7 RID: 63399 RVA: 0x0037274F File Offset: 0x0037094F
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600F7A8 RID: 63400 RVA: 0x0037275E File Offset: 0x0037095E
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17004239 RID: 16953
		// (get) Token: 0x0600F7A9 RID: 63401 RVA: 0x00372778 File Offset: 0x00370978
		public bool Value
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x04005951 RID: 22865
		private Table __p;
	}
}
