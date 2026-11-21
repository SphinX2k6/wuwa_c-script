using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D38 RID: 3384
	public struct ExploreSkillInteract : IFlatbufferObject
	{
		// Token: 0x17001060 RID: 4192
		// (get) Token: 0x060071ED RID: 29165 RVA: 0x00248854 File Offset: 0x00246A54
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060071EE RID: 29166 RVA: 0x00248861 File Offset: 0x00246A61
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060071EF RID: 29167 RVA: 0x00248868 File Offset: 0x00246A68
		public static ExploreSkillInteract GetRootAsExploreSkillInteract(ByteBuffer _bb)
		{
			return ExploreSkillInteract.GetRootAsExploreSkillInteract(_bb, default(ExploreSkillInteract));
		}

		// Token: 0x060071F0 RID: 29168 RVA: 0x00248884 File Offset: 0x00246A84
		public static ExploreSkillInteract GetRootAsExploreSkillInteract(ByteBuffer _bb, ExploreSkillInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060071F1 RID: 29169 RVA: 0x002488A1 File Offset: 0x00246AA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060071F2 RID: 29170 RVA: 0x002488B0 File Offset: 0x00246AB0
		public ExploreSkillInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001061 RID: 4193
		// (get) Token: 0x060071F3 RID: 29171 RVA: 0x002488C0 File Offset: 0x00246AC0
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

		// Token: 0x17001062 RID: 4194
		// (get) Token: 0x060071F4 RID: 29172 RVA: 0x002488FC File Offset: 0x00246AFC
		public string Tag
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

		// Token: 0x060071F5 RID: 29173 RVA: 0x00248933 File Offset: 0x00246B33
		public Span<byte> GetTagBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060071F6 RID: 29174 RVA: 0x00248942 File Offset: 0x00246B42
		public byte[] GetTagArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001063 RID: 4195
		// (get) Token: 0x060071F7 RID: 29175 RVA: 0x0024895C File Offset: 0x00246B5C
		public string Desc
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

		// Token: 0x060071F8 RID: 29176 RVA: 0x00248993 File Offset: 0x00246B93
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060071F9 RID: 29177 RVA: 0x002489A2 File Offset: 0x00246BA2
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04005280 RID: 21120
		private Table __p;
	}
}
