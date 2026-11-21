using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F0A RID: 3850
	public struct MoraleKeepLevel : IFlatbufferObject
	{
		// Token: 0x17002037 RID: 8247
		// (get) Token: 0x06009C3A RID: 39994 RVA: 0x002A78B4 File Offset: 0x002A5AB4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009C3B RID: 39995 RVA: 0x002A78C1 File Offset: 0x002A5AC1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009C3C RID: 39996 RVA: 0x002A78C8 File Offset: 0x002A5AC8
		public static MoraleKeepLevel GetRootAsMoraleKeepLevel(ByteBuffer _bb)
		{
			return MoraleKeepLevel.GetRootAsMoraleKeepLevel(_bb, default(MoraleKeepLevel));
		}

		// Token: 0x06009C3D RID: 39997 RVA: 0x002A78E4 File Offset: 0x002A5AE4
		public static MoraleKeepLevel GetRootAsMoraleKeepLevel(ByteBuffer _bb, MoraleKeepLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009C3E RID: 39998 RVA: 0x002A7901 File Offset: 0x002A5B01
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009C3F RID: 39999 RVA: 0x002A7910 File Offset: 0x002A5B10
		public MoraleKeepLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002038 RID: 8248
		// (get) Token: 0x06009C40 RID: 40000 RVA: 0x002A7920 File Offset: 0x002A5B20
		public int Level
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

		// Token: 0x17002039 RID: 8249
		// (get) Token: 0x06009C41 RID: 40001 RVA: 0x002A795C File Offset: 0x002A5B5C
		public int Experience
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

		// Token: 0x1700203A RID: 8250
		// (get) Token: 0x06009C42 RID: 40002 RVA: 0x002A7998 File Offset: 0x002A5B98
		public string LvAddDesc
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

		// Token: 0x06009C43 RID: 40003 RVA: 0x002A79CF File Offset: 0x002A5BCF
		public Span<byte> GetLvAddDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06009C44 RID: 40004 RVA: 0x002A79DE File Offset: 0x002A5BDE
		public byte[] GetLvAddDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x040054AF RID: 21679
		private Table __p;
	}
}
