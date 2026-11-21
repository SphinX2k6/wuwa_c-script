using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001236 RID: 4662
	public struct SurvivorsMonsterType : IFlatbufferObject
	{
		// Token: 0x17003C3E RID: 15422
		// (get) Token: 0x0600E828 RID: 59432 RVA: 0x0034FF31 File Offset: 0x0034E131
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E829 RID: 59433 RVA: 0x0034FF3E File Offset: 0x0034E13E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E82A RID: 59434 RVA: 0x0034FF48 File Offset: 0x0034E148
		public static SurvivorsMonsterType GetRootAsSurvivorsMonsterType(ByteBuffer _bb)
		{
			return SurvivorsMonsterType.GetRootAsSurvivorsMonsterType(_bb, default(SurvivorsMonsterType));
		}

		// Token: 0x0600E82B RID: 59435 RVA: 0x0034FF64 File Offset: 0x0034E164
		public static SurvivorsMonsterType GetRootAsSurvivorsMonsterType(ByteBuffer _bb, SurvivorsMonsterType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E82C RID: 59436 RVA: 0x0034FF81 File Offset: 0x0034E181
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E82D RID: 59437 RVA: 0x0034FF90 File Offset: 0x0034E190
		public SurvivorsMonsterType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003C3F RID: 15423
		// (get) Token: 0x0600E82E RID: 59438 RVA: 0x0034FFA0 File Offset: 0x0034E1A0
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

		// Token: 0x17003C40 RID: 15424
		// (get) Token: 0x0600E82F RID: 59439 RVA: 0x0034FFDC File Offset: 0x0034E1DC
		public int TemplateId
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

		// Token: 0x17003C41 RID: 15425
		// (get) Token: 0x0600E830 RID: 59440 RVA: 0x00350018 File Offset: 0x0034E218
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

		// Token: 0x0600E831 RID: 59441 RVA: 0x0035004F File Offset: 0x0034E24F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600E832 RID: 59442 RVA: 0x0035005E File Offset: 0x0034E25E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003C42 RID: 15426
		// (get) Token: 0x0600E833 RID: 59443 RVA: 0x00350078 File Offset: 0x0034E278
		public int RiskType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003C43 RID: 15427
		// (get) Token: 0x0600E834 RID: 59444 RVA: 0x003500B8 File Offset: 0x0034E2B8
		public int BodyType
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003C44 RID: 15428
		// (get) Token: 0x0600E835 RID: 59445 RVA: 0x003500F8 File Offset: 0x0034E2F8
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E836 RID: 59446 RVA: 0x00350130 File Offset: 0x0034E330
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600E837 RID: 59447 RVA: 0x00350140 File Offset: 0x0034E340
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x0400587B RID: 22651
		private Table __p;
	}
}
