using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001235 RID: 4661
	public struct SurvivorsMonsterBody : IFlatbufferObject
	{
		// Token: 0x17003C3B RID: 15419
		// (get) Token: 0x0600E81E RID: 59422 RVA: 0x0034FE2C File Offset: 0x0034E02C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E81F RID: 59423 RVA: 0x0034FE39 File Offset: 0x0034E039
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E820 RID: 59424 RVA: 0x0034FE40 File Offset: 0x0034E040
		public static SurvivorsMonsterBody GetRootAsSurvivorsMonsterBody(ByteBuffer _bb)
		{
			return SurvivorsMonsterBody.GetRootAsSurvivorsMonsterBody(_bb, default(SurvivorsMonsterBody));
		}

		// Token: 0x0600E821 RID: 59425 RVA: 0x0034FE5C File Offset: 0x0034E05C
		public static SurvivorsMonsterBody GetRootAsSurvivorsMonsterBody(ByteBuffer _bb, SurvivorsMonsterBody obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E822 RID: 59426 RVA: 0x0034FE79 File Offset: 0x0034E079
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E823 RID: 59427 RVA: 0x0034FE88 File Offset: 0x0034E088
		public SurvivorsMonsterBody __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003C3C RID: 15420
		// (get) Token: 0x0600E824 RID: 59428 RVA: 0x0034FE98 File Offset: 0x0034E098
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

		// Token: 0x17003C3D RID: 15421
		// (get) Token: 0x0600E825 RID: 59429 RVA: 0x0034FED4 File Offset: 0x0034E0D4
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

		// Token: 0x0600E826 RID: 59430 RVA: 0x0034FF0B File Offset: 0x0034E10B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600E827 RID: 59431 RVA: 0x0034FF1A File Offset: 0x0034E11A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0400587A RID: 22650
		private Table __p;
	}
}
