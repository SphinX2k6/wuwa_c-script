using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001100 RID: 4352
	public struct SurvivorsMonsterType : IFlatbufferObject
	{
		// Token: 0x170038E8 RID: 14568
		// (get) Token: 0x0600DADD RID: 56029 RVA: 0x00324BF9 File Offset: 0x00322DF9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DADE RID: 56030 RVA: 0x00324C06 File Offset: 0x00322E06
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DADF RID: 56031 RVA: 0x00324C10 File Offset: 0x00322E10
		public static SurvivorsMonsterType GetRootAsSurvivorsMonsterType(ByteBuffer _bb)
		{
			return SurvivorsMonsterType.GetRootAsSurvivorsMonsterType(_bb, default(SurvivorsMonsterType));
		}

		// Token: 0x0600DAE0 RID: 56032 RVA: 0x00324C2C File Offset: 0x00322E2C
		public static SurvivorsMonsterType GetRootAsSurvivorsMonsterType(ByteBuffer _bb, SurvivorsMonsterType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DAE1 RID: 56033 RVA: 0x00324C49 File Offset: 0x00322E49
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DAE2 RID: 56034 RVA: 0x00324C58 File Offset: 0x00322E58
		public SurvivorsMonsterType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170038E9 RID: 14569
		// (get) Token: 0x0600DAE3 RID: 56035 RVA: 0x00324C68 File Offset: 0x00322E68
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

		// Token: 0x170038EA RID: 14570
		// (get) Token: 0x0600DAE4 RID: 56036 RVA: 0x00324CA4 File Offset: 0x00322EA4
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

		// Token: 0x170038EB RID: 14571
		// (get) Token: 0x0600DAE5 RID: 56037 RVA: 0x00324CE0 File Offset: 0x00322EE0
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

		// Token: 0x0600DAE6 RID: 56038 RVA: 0x00324D17 File Offset: 0x00322F17
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600DAE7 RID: 56039 RVA: 0x00324D26 File Offset: 0x00322F26
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170038EC RID: 14572
		// (get) Token: 0x0600DAE8 RID: 56040 RVA: 0x00324D40 File Offset: 0x00322F40
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

		// Token: 0x170038ED RID: 14573
		// (get) Token: 0x0600DAE9 RID: 56041 RVA: 0x00324D80 File Offset: 0x00322F80
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

		// Token: 0x170038EE RID: 14574
		// (get) Token: 0x0600DAEA RID: 56042 RVA: 0x00324DC0 File Offset: 0x00322FC0
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

		// Token: 0x0600DAEB RID: 56043 RVA: 0x00324DF8 File Offset: 0x00322FF8
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600DAEC RID: 56044 RVA: 0x00324E08 File Offset: 0x00323008
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x04005238 RID: 21048
		private Table __p;
	}
}
