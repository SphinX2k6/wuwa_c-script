using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AF1 RID: 2801
	public struct AiSkillInfos : IFlatbufferObject
	{
		// Token: 0x17000294 RID: 660
		// (get) Token: 0x060046EF RID: 18159 RVA: 0x001D3E1D File Offset: 0x001D201D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060046F0 RID: 18160 RVA: 0x001D3E2A File Offset: 0x001D202A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060046F1 RID: 18161 RVA: 0x001D3E34 File Offset: 0x001D2034
		public static AiSkillInfos GetRootAsAiSkillInfos(ByteBuffer _bb)
		{
			return AiSkillInfos.GetRootAsAiSkillInfos(_bb, default(AiSkillInfos));
		}

		// Token: 0x060046F2 RID: 18162 RVA: 0x001D3E50 File Offset: 0x001D2050
		public static AiSkillInfos GetRootAsAiSkillInfos(ByteBuffer _bb, AiSkillInfos obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060046F3 RID: 18163 RVA: 0x001D3E6D File Offset: 0x001D206D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060046F4 RID: 18164 RVA: 0x001D3E7C File Offset: 0x001D207C
		public AiSkillInfos __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x060046F5 RID: 18165 RVA: 0x001D3E8C File Offset: 0x001D208C
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

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x060046F6 RID: 18166 RVA: 0x001D3EC8 File Offset: 0x001D20C8
		public int SkillWeight
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x060046F7 RID: 18167 RVA: 0x001D3F04 File Offset: 0x001D2104
		public int SkillPreconditionId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x060046F8 RID: 18168 RVA: 0x001D3F40 File Offset: 0x001D2140
		public string SkillId
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

		// Token: 0x060046F9 RID: 18169 RVA: 0x001D3F78 File Offset: 0x001D2178
		public Span<byte> GetSkillIdBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060046FA RID: 18170 RVA: 0x001D3F88 File Offset: 0x001D2188
		public byte[] GetSkillIdArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x060046FB RID: 18171 RVA: 0x001D3FA0 File Offset: 0x001D21A0
		public FloatRange? SkillCdRange
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new FloatRange?(default(FloatRange).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x060046FC RID: 18172 RVA: 0x001D4000 File Offset: 0x001D2200
		public int SkillType
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return -1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004AD2 RID: 19154
		private Table __p;
	}
}
