using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E70 RID: 3696
	public struct KeyType : IFlatbufferObject
	{
		// Token: 0x17001ADD RID: 6877
		// (get) Token: 0x06008DA8 RID: 36264 RVA: 0x00286CE1 File Offset: 0x00284EE1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008DA9 RID: 36265 RVA: 0x00286CEE File Offset: 0x00284EEE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008DAA RID: 36266 RVA: 0x00286CF8 File Offset: 0x00284EF8
		public static KeyType GetRootAsKeyType(ByteBuffer _bb)
		{
			return KeyType.GetRootAsKeyType(_bb, default(KeyType));
		}

		// Token: 0x06008DAB RID: 36267 RVA: 0x00286D14 File Offset: 0x00284F14
		public static KeyType GetRootAsKeyType(ByteBuffer _bb, KeyType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008DAC RID: 36268 RVA: 0x00286D31 File Offset: 0x00284F31
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008DAD RID: 36269 RVA: 0x00286D40 File Offset: 0x00284F40
		public KeyType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001ADE RID: 6878
		// (get) Token: 0x06008DAE RID: 36270 RVA: 0x00286D50 File Offset: 0x00284F50
		public int TypeId
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

		// Token: 0x17001ADF RID: 6879
		// (get) Token: 0x06008DAF RID: 36271 RVA: 0x00286D8C File Offset: 0x00284F8C
		public string Name
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

		// Token: 0x06008DB0 RID: 36272 RVA: 0x00286DC3 File Offset: 0x00284FC3
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06008DB1 RID: 36273 RVA: 0x00286DD2 File Offset: 0x00284FD2
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001AE0 RID: 6880
		// (get) Token: 0x06008DB2 RID: 36274 RVA: 0x00286DEC File Offset: 0x00284FEC
		public string IconSpritePath
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

		// Token: 0x06008DB3 RID: 36275 RVA: 0x00286E23 File Offset: 0x00285023
		public Span<byte> GetIconSpritePathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06008DB4 RID: 36276 RVA: 0x00286E32 File Offset: 0x00285032
		public byte[] GetIconSpritePathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x040053FC RID: 21500
		private Table __p;
	}
}
