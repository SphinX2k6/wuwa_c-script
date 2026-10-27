using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B63 RID: 2915
	public struct Character : IFlatbufferObject
	{
		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x06005287 RID: 21127 RVA: 0x001EFB41 File Offset: 0x001EDD41
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005288 RID: 21128 RVA: 0x001EFB4E File Offset: 0x001EDD4E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005289 RID: 21129 RVA: 0x001EFB58 File Offset: 0x001EDD58
		public static Character GetRootAsCharacter(ByteBuffer _bb)
		{
			return Character.GetRootAsCharacter(_bb, default(Character));
		}

		// Token: 0x0600528A RID: 21130 RVA: 0x001EFB74 File Offset: 0x001EDD74
		public static Character GetRootAsCharacter(ByteBuffer _bb, Character obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600528B RID: 21131 RVA: 0x001EFB91 File Offset: 0x001EDD91
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600528C RID: 21132 RVA: 0x001EFBA0 File Offset: 0x001EDDA0
		public Character __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x0600528D RID: 21133 RVA: 0x001EFBB0 File Offset: 0x001EDDB0
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

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x0600528E RID: 21134 RVA: 0x001EFBEC File Offset: 0x001EDDEC
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

		// Token: 0x0600528F RID: 21135 RVA: 0x001EFC23 File Offset: 0x001EDE23
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06005290 RID: 21136 RVA: 0x001EFC32 File Offset: 0x001EDE32
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x06005291 RID: 21137 RVA: 0x001EFC4C File Offset: 0x001EDE4C
		public string ScoreName
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

		// Token: 0x06005292 RID: 21138 RVA: 0x001EFC83 File Offset: 0x001EDE83
		public Span<byte> GetScoreNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06005293 RID: 21139 RVA: 0x001EFC92 File Offset: 0x001EDE92
		public byte[] GetScoreNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x06005294 RID: 21140 RVA: 0x001EFCAC File Offset: 0x001EDEAC
		public string Color
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005295 RID: 21141 RVA: 0x001EFCE4 File Offset: 0x001EDEE4
		public Span<byte> GetColorBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06005296 RID: 21142 RVA: 0x001EFCF4 File Offset: 0x001EDEF4
		public byte[] GetColorArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x06005297 RID: 21143 RVA: 0x001EFD0C File Offset: 0x001EDF0C
		public string BarSprite
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005298 RID: 21144 RVA: 0x001EFD44 File Offset: 0x001EDF44
		public Span<byte> GetBarSpriteBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06005299 RID: 21145 RVA: 0x001EFD54 File Offset: 0x001EDF54
		public byte[] GetBarSpriteArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04004B63 RID: 19299
		private Table __p;
	}
}
