using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E25 RID: 3621
	public struct MoraleKeepLevel : IFlatbufferObject
	{
		// Token: 0x17001FD2 RID: 8146
		// (get) Token: 0x0600961A RID: 38426 RVA: 0x00289B80 File Offset: 0x00287D80
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600961B RID: 38427 RVA: 0x00289B8D File Offset: 0x00287D8D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600961C RID: 38428 RVA: 0x00289B94 File Offset: 0x00287D94
		public static MoraleKeepLevel GetRootAsMoraleKeepLevel(ByteBuffer _bb)
		{
			return MoraleKeepLevel.GetRootAsMoraleKeepLevel(_bb, default(MoraleKeepLevel));
		}

		// Token: 0x0600961D RID: 38429 RVA: 0x00289BB0 File Offset: 0x00287DB0
		public static MoraleKeepLevel GetRootAsMoraleKeepLevel(ByteBuffer _bb, MoraleKeepLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600961E RID: 38430 RVA: 0x00289BCD File Offset: 0x00287DCD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600961F RID: 38431 RVA: 0x00289BDC File Offset: 0x00287DDC
		public MoraleKeepLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001FD3 RID: 8147
		// (get) Token: 0x06009620 RID: 38432 RVA: 0x00289BEC File Offset: 0x00287DEC
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

		// Token: 0x17001FD4 RID: 8148
		// (get) Token: 0x06009621 RID: 38433 RVA: 0x00289C28 File Offset: 0x00287E28
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

		// Token: 0x17001FD5 RID: 8149
		// (get) Token: 0x06009622 RID: 38434 RVA: 0x00289C64 File Offset: 0x00287E64
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

		// Token: 0x06009623 RID: 38435 RVA: 0x00289C9B File Offset: 0x00287E9B
		public Span<byte> GetLvAddDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06009624 RID: 38436 RVA: 0x00289CAA File Offset: 0x00287EAA
		public byte[] GetLvAddDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04004ECA RID: 20170
		private Table __p;
	}
}
