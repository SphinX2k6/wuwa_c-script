using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010FF RID: 4351
	public struct SurvivorsMonsterBody : IFlatbufferObject
	{
		// Token: 0x170038E5 RID: 14565
		// (get) Token: 0x0600DAD3 RID: 56019 RVA: 0x00324AF4 File Offset: 0x00322CF4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DAD4 RID: 56020 RVA: 0x00324B01 File Offset: 0x00322D01
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DAD5 RID: 56021 RVA: 0x00324B08 File Offset: 0x00322D08
		public static SurvivorsMonsterBody GetRootAsSurvivorsMonsterBody(ByteBuffer _bb)
		{
			return SurvivorsMonsterBody.GetRootAsSurvivorsMonsterBody(_bb, default(SurvivorsMonsterBody));
		}

		// Token: 0x0600DAD6 RID: 56022 RVA: 0x00324B24 File Offset: 0x00322D24
		public static SurvivorsMonsterBody GetRootAsSurvivorsMonsterBody(ByteBuffer _bb, SurvivorsMonsterBody obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DAD7 RID: 56023 RVA: 0x00324B41 File Offset: 0x00322D41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DAD8 RID: 56024 RVA: 0x00324B50 File Offset: 0x00322D50
		public SurvivorsMonsterBody __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170038E6 RID: 14566
		// (get) Token: 0x0600DAD9 RID: 56025 RVA: 0x00324B60 File Offset: 0x00322D60
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

		// Token: 0x170038E7 RID: 14567
		// (get) Token: 0x0600DADA RID: 56026 RVA: 0x00324B9C File Offset: 0x00322D9C
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

		// Token: 0x0600DADB RID: 56027 RVA: 0x00324BD3 File Offset: 0x00322DD3
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600DADC RID: 56028 RVA: 0x00324BE2 File Offset: 0x00322DE2
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04005237 RID: 21047
		private Table __p;
	}
}
