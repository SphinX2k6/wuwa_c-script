using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012F6 RID: 4854
	public struct DicStringString : IFlatbufferObject
	{
		// Token: 0x17004240 RID: 16960
		// (get) Token: 0x0600F7BE RID: 63422 RVA: 0x003729CC File Offset: 0x00370BCC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F7BF RID: 63423 RVA: 0x003729D9 File Offset: 0x00370BD9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F7C0 RID: 63424 RVA: 0x003729E0 File Offset: 0x00370BE0
		public static DicStringString GetRootAsDicStringString(ByteBuffer _bb)
		{
			return DicStringString.GetRootAsDicStringString(_bb, default(DicStringString));
		}

		// Token: 0x0600F7C1 RID: 63425 RVA: 0x003729FC File Offset: 0x00370BFC
		public static DicStringString GetRootAsDicStringString(ByteBuffer _bb, DicStringString obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F7C2 RID: 63426 RVA: 0x00372A19 File Offset: 0x00370C19
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F7C3 RID: 63427 RVA: 0x00372A28 File Offset: 0x00370C28
		public DicStringString __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17004241 RID: 16961
		// (get) Token: 0x0600F7C4 RID: 63428 RVA: 0x00372A38 File Offset: 0x00370C38
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

		// Token: 0x0600F7C5 RID: 63429 RVA: 0x00372A6F File Offset: 0x00370C6F
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600F7C6 RID: 63430 RVA: 0x00372A7E File Offset: 0x00370C7E
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17004242 RID: 16962
		// (get) Token: 0x0600F7C7 RID: 63431 RVA: 0x00372A98 File Offset: 0x00370C98
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

		// Token: 0x0600F7C8 RID: 63432 RVA: 0x00372ACF File Offset: 0x00370CCF
		public Span<byte> GetValueBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600F7C9 RID: 63433 RVA: 0x00372ADE File Offset: 0x00370CDE
		public byte[] GetValueArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04005954 RID: 22868
		private Table __p;
	}
}
