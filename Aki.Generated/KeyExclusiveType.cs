using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E6D RID: 3693
	public struct KeyExclusiveType : IFlatbufferObject
	{
		// Token: 0x17001AB7 RID: 6839
		// (get) Token: 0x06008D4B RID: 36171 RVA: 0x00285FBF File Offset: 0x002841BF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008D4C RID: 36172 RVA: 0x00285FCC File Offset: 0x002841CC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008D4D RID: 36173 RVA: 0x00285FD4 File Offset: 0x002841D4
		public static KeyExclusiveType GetRootAsKeyExclusiveType(ByteBuffer _bb)
		{
			return KeyExclusiveType.GetRootAsKeyExclusiveType(_bb, default(KeyExclusiveType));
		}

		// Token: 0x06008D4E RID: 36174 RVA: 0x00285FF0 File Offset: 0x002841F0
		public static KeyExclusiveType GetRootAsKeyExclusiveType(ByteBuffer _bb, KeyExclusiveType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008D4F RID: 36175 RVA: 0x0028600D File Offset: 0x0028420D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008D50 RID: 36176 RVA: 0x0028601C File Offset: 0x0028421C
		public KeyExclusiveType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001AB8 RID: 6840
		// (get) Token: 0x06008D51 RID: 36177 RVA: 0x0028602C File Offset: 0x0028422C
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

		// Token: 0x17001AB9 RID: 6841
		// (get) Token: 0x06008D52 RID: 36178 RVA: 0x00286068 File Offset: 0x00284268
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

		// Token: 0x06008D53 RID: 36179 RVA: 0x0028609F File Offset: 0x0028429F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06008D54 RID: 36180 RVA: 0x002860AE File Offset: 0x002842AE
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001ABA RID: 6842
		// (get) Token: 0x06008D55 RID: 36181 RVA: 0x002860C8 File Offset: 0x002842C8
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

		// Token: 0x06008D56 RID: 36182 RVA: 0x002860FF File Offset: 0x002842FF
		public Span<byte> GetIconSpritePathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06008D57 RID: 36183 RVA: 0x0028610E File Offset: 0x0028430E
		public byte[] GetIconSpritePathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x040053F9 RID: 21497
		private Table __p;
	}
}
