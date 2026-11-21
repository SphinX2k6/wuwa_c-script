using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BCE RID: 3022
	public struct AiTeamAreaNew : IFlatbufferObject
	{
		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06004C5F RID: 19551 RVA: 0x001F3DF1 File Offset: 0x001F1FF1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004C60 RID: 19552 RVA: 0x001F3DFE File Offset: 0x001F1FFE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004C61 RID: 19553 RVA: 0x001F3E08 File Offset: 0x001F2008
		public static AiTeamAreaNew GetRootAsAiTeamAreaNew(ByteBuffer _bb)
		{
			return AiTeamAreaNew.GetRootAsAiTeamAreaNew(_bb, default(AiTeamAreaNew));
		}

		// Token: 0x06004C62 RID: 19554 RVA: 0x001F3E24 File Offset: 0x001F2024
		public static AiTeamAreaNew GetRootAsAiTeamAreaNew(ByteBuffer _bb, AiTeamAreaNew obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004C63 RID: 19555 RVA: 0x001F3E41 File Offset: 0x001F2041
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004C64 RID: 19556 RVA: 0x001F3E50 File Offset: 0x001F2050
		public AiTeamAreaNew __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06004C65 RID: 19557 RVA: 0x001F3E60 File Offset: 0x001F2060
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

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06004C66 RID: 19558 RVA: 0x001F3E9C File Offset: 0x001F209C
		public int MaxCharacter
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

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06004C67 RID: 19559 RVA: 0x001F3ED8 File Offset: 0x001F20D8
		public FloatRange? ReactionTime
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new FloatRange?(default(FloatRange).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06004C68 RID: 19560 RVA: 0x001F3F38 File Offset: 0x001F2138
		public float CharTypes(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06004C69 RID: 19561 RVA: 0x001F3F7C File Offset: 0x001F217C
		public int CharTypesLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06004C6A RID: 19562 RVA: 0x001F3FA8 File Offset: 0x001F21A8
		public Span<float> GetCharTypesBytes()
		{
			return this.__p.__vector_as_span<float>(10, 4);
		}

		// Token: 0x06004C6B RID: 19563 RVA: 0x001F3FB8 File Offset: 0x001F21B8
		public float[] GetCharTypesArray()
		{
			return this.__p.__vector_as_array<float>(10) ?? Array.Empty<float>();
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06004C6C RID: 19564 RVA: 0x001F3FD0 File Offset: 0x001F21D0
		public float AreaAngle
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 75f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06004C6D RID: 19565 RVA: 0x001F4014 File Offset: 0x001F2214
		public FloatRange? AreaDistance
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new FloatRange?(default(FloatRange).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06004C6E RID: 19566 RVA: 0x001F4074 File Offset: 0x001F2274
		public int AttackWeightId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004C6F RID: 19567 RVA: 0x001F40B1 File Offset: 0x001F22B1
		[NullableContext(1)]
		public float[] CharTypes()
		{
			return this.GetCharTypesArray();
		}

		// Token: 0x06004C70 RID: 19568 RVA: 0x001F40B9 File Offset: 0x001F22B9
		[NullableContext(1)]
		public IEnumerable<float> CharTypesIter()
		{
			AiTeamAreaNew.<CharTypesIter>d__26 <CharTypesIter>d__ = new AiTeamAreaNew.<CharTypesIter>d__26(-2);
			<CharTypesIter>d__.<>3__<>4__this = this;
			return <CharTypesIter>d__;
		}

		// Token: 0x040050AF RID: 20655
		private Table __p;
	}
}
