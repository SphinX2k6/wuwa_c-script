using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C5E RID: 3166
	public struct CipherGameplay : IFlatbufferObject
	{
		// Token: 0x1700086D RID: 2157
		// (get) Token: 0x06005B7D RID: 23421 RVA: 0x002162F5 File Offset: 0x002144F5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005B7E RID: 23422 RVA: 0x00216302 File Offset: 0x00214502
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005B7F RID: 23423 RVA: 0x0021630C File Offset: 0x0021450C
		public static CipherGameplay GetRootAsCipherGameplay(ByteBuffer _bb)
		{
			return CipherGameplay.GetRootAsCipherGameplay(_bb, default(CipherGameplay));
		}

		// Token: 0x06005B80 RID: 23424 RVA: 0x00216328 File Offset: 0x00214528
		public static CipherGameplay GetRootAsCipherGameplay(ByteBuffer _bb, CipherGameplay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005B81 RID: 23425 RVA: 0x00216345 File Offset: 0x00214545
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005B82 RID: 23426 RVA: 0x00216354 File Offset: 0x00214554
		public CipherGameplay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700086E RID: 2158
		// (get) Token: 0x06005B83 RID: 23427 RVA: 0x00216364 File Offset: 0x00214564
		public string Id
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

		// Token: 0x06005B84 RID: 23428 RVA: 0x0021639B File Offset: 0x0021459B
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06005B85 RID: 23429 RVA: 0x002163AA File Offset: 0x002145AA
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x1700086F RID: 2159
		// (get) Token: 0x06005B86 RID: 23430 RVA: 0x002163C4 File Offset: 0x002145C4
		public int Password
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

		// Token: 0x04005162 RID: 20834
		private Table __p;
	}
}
