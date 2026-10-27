using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D23 RID: 3363
	public struct HandBookEntrance : IFlatbufferObject
	{
		// Token: 0x170016DD RID: 5853
		// (get) Token: 0x06007DF0 RID: 32240 RVA: 0x00252E14 File Offset: 0x00251014
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007DF1 RID: 32241 RVA: 0x00252E21 File Offset: 0x00251021
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007DF2 RID: 32242 RVA: 0x00252E28 File Offset: 0x00251028
		public static HandBookEntrance GetRootAsHandBookEntrance(ByteBuffer _bb)
		{
			return HandBookEntrance.GetRootAsHandBookEntrance(_bb, default(HandBookEntrance));
		}

		// Token: 0x06007DF3 RID: 32243 RVA: 0x00252E44 File Offset: 0x00251044
		public static HandBookEntrance GetRootAsHandBookEntrance(ByteBuffer _bb, HandBookEntrance obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007DF4 RID: 32244 RVA: 0x00252E61 File Offset: 0x00251061
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007DF5 RID: 32245 RVA: 0x00252E70 File Offset: 0x00251070
		public HandBookEntrance __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170016DE RID: 5854
		// (get) Token: 0x06007DF6 RID: 32246 RVA: 0x00252E80 File Offset: 0x00251080
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

		// Token: 0x170016DF RID: 5855
		// (get) Token: 0x06007DF7 RID: 32247 RVA: 0x00252EBC File Offset: 0x002510BC
		public int SortId
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

		// Token: 0x170016E0 RID: 5856
		// (get) Token: 0x06007DF8 RID: 32248 RVA: 0x00252EF8 File Offset: 0x002510F8
		public string Name
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

		// Token: 0x06007DF9 RID: 32249 RVA: 0x00252F2F File Offset: 0x0025112F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007DFA RID: 32250 RVA: 0x00252F3E File Offset: 0x0025113E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170016E1 RID: 5857
		// (get) Token: 0x06007DFB RID: 32251 RVA: 0x00252F58 File Offset: 0x00251158
		public string TitleIcon
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

		// Token: 0x06007DFC RID: 32252 RVA: 0x00252F90 File Offset: 0x00251190
		public Span<byte> GetTitleIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06007DFD RID: 32253 RVA: 0x00252FA0 File Offset: 0x002511A0
		public byte[] GetTitleIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170016E2 RID: 5858
		// (get) Token: 0x06007DFE RID: 32254 RVA: 0x00252FB8 File Offset: 0x002511B8
		public string Texture
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

		// Token: 0x06007DFF RID: 32255 RVA: 0x00252FF0 File Offset: 0x002511F0
		public Span<byte> GetTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06007E00 RID: 32256 RVA: 0x00253000 File Offset: 0x00251200
		public byte[] GetTextureArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04004D9B RID: 19867
		private Table __p;
	}
}
