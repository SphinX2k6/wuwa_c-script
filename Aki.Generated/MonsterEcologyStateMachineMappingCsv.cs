using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E14 RID: 3604
	public struct MonsterEcologyStateMachineMappingCsv : IFlatbufferObject
	{
		// Token: 0x17001F5E RID: 8030
		// (get) Token: 0x060094E2 RID: 38114 RVA: 0x0028734C File Offset: 0x0028554C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060094E3 RID: 38115 RVA: 0x00287359 File Offset: 0x00285559
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060094E4 RID: 38116 RVA: 0x00287360 File Offset: 0x00285560
		public static MonsterEcologyStateMachineMappingCsv GetRootAsMonsterEcologyStateMachineMappingCsv(ByteBuffer _bb)
		{
			return MonsterEcologyStateMachineMappingCsv.GetRootAsMonsterEcologyStateMachineMappingCsv(_bb, default(MonsterEcologyStateMachineMappingCsv));
		}

		// Token: 0x060094E5 RID: 38117 RVA: 0x0028737C File Offset: 0x0028557C
		public static MonsterEcologyStateMachineMappingCsv GetRootAsMonsterEcologyStateMachineMappingCsv(ByteBuffer _bb, MonsterEcologyStateMachineMappingCsv obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060094E6 RID: 38118 RVA: 0x00287399 File Offset: 0x00285599
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060094E7 RID: 38119 RVA: 0x002873A8 File Offset: 0x002855A8
		public MonsterEcologyStateMachineMappingCsv __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001F5F RID: 8031
		// (get) Token: 0x060094E8 RID: 38120 RVA: 0x002873B8 File Offset: 0x002855B8
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

		// Token: 0x17001F60 RID: 8032
		// (get) Token: 0x060094E9 RID: 38121 RVA: 0x002873F4 File Offset: 0x002855F4
		public string ActionTag
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

		// Token: 0x060094EA RID: 38122 RVA: 0x0028742B File Offset: 0x0028562B
		public Span<byte> GetActionTagBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060094EB RID: 38123 RVA: 0x0028743A File Offset: 0x0028563A
		public byte[] GetActionTagArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001F61 RID: 8033
		// (get) Token: 0x060094EC RID: 38124 RVA: 0x00287454 File Offset: 0x00285654
		public string StateTag
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

		// Token: 0x060094ED RID: 38125 RVA: 0x0028748B File Offset: 0x0028568B
		public Span<byte> GetStateTagBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060094EE RID: 38126 RVA: 0x0028749A File Offset: 0x0028569A
		public byte[] GetStateTagArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001F62 RID: 8034
		// (get) Token: 0x060094EF RID: 38127 RVA: 0x002874B4 File Offset: 0x002856B4
		public string Remark
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

		// Token: 0x060094F0 RID: 38128 RVA: 0x002874EC File Offset: 0x002856EC
		public Span<byte> GetRemarkBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060094F1 RID: 38129 RVA: 0x002874FC File Offset: 0x002856FC
		public byte[] GetRemarkArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04004EB9 RID: 20153
		private Table __p;
	}
}
