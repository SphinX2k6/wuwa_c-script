using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D46 RID: 3398
	public struct HonamiStoryPluginTag : IFlatbufferObject
	{
		// Token: 0x1700180B RID: 6155
		// (get) Token: 0x060080D6 RID: 32982 RVA: 0x002595C0 File Offset: 0x002577C0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060080D7 RID: 32983 RVA: 0x002595CD File Offset: 0x002577CD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060080D8 RID: 32984 RVA: 0x002595D4 File Offset: 0x002577D4
		public static HonamiStoryPluginTag GetRootAsHonamiStoryPluginTag(ByteBuffer _bb)
		{
			return HonamiStoryPluginTag.GetRootAsHonamiStoryPluginTag(_bb, default(HonamiStoryPluginTag));
		}

		// Token: 0x060080D9 RID: 32985 RVA: 0x002595F0 File Offset: 0x002577F0
		public static HonamiStoryPluginTag GetRootAsHonamiStoryPluginTag(ByteBuffer _bb, HonamiStoryPluginTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060080DA RID: 32986 RVA: 0x0025960D File Offset: 0x0025780D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060080DB RID: 32987 RVA: 0x0025961C File Offset: 0x0025781C
		public HonamiStoryPluginTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700180C RID: 6156
		// (get) Token: 0x060080DC RID: 32988 RVA: 0x0025962C File Offset: 0x0025782C
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

		// Token: 0x1700180D RID: 6157
		// (get) Token: 0x060080DD RID: 32989 RVA: 0x00259668 File Offset: 0x00257868
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

		// Token: 0x060080DE RID: 32990 RVA: 0x0025969F File Offset: 0x0025789F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060080DF RID: 32991 RVA: 0x002596AE File Offset: 0x002578AE
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700180E RID: 6158
		// (get) Token: 0x060080E0 RID: 32992 RVA: 0x002596C8 File Offset: 0x002578C8
		public string Color
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

		// Token: 0x060080E1 RID: 32993 RVA: 0x002596FF File Offset: 0x002578FF
		public Span<byte> GetColorBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060080E2 RID: 32994 RVA: 0x0025970E File Offset: 0x0025790E
		public byte[] GetColorArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04004DC2 RID: 19906
		private Table __p;
	}
}
