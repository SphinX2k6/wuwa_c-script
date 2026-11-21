using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EF5 RID: 3829
	public struct MonsterCommunicationGroup : IFlatbufferObject
	{
		// Token: 0x17001FA1 RID: 8097
		// (get) Token: 0x06009AB3 RID: 39603 RVA: 0x002A4678 File Offset: 0x002A2878
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009AB4 RID: 39604 RVA: 0x002A4685 File Offset: 0x002A2885
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009AB5 RID: 39605 RVA: 0x002A468C File Offset: 0x002A288C
		public static MonsterCommunicationGroup GetRootAsMonsterCommunicationGroup(ByteBuffer _bb)
		{
			return MonsterCommunicationGroup.GetRootAsMonsterCommunicationGroup(_bb, default(MonsterCommunicationGroup));
		}

		// Token: 0x06009AB6 RID: 39606 RVA: 0x002A46A8 File Offset: 0x002A28A8
		public static MonsterCommunicationGroup GetRootAsMonsterCommunicationGroup(ByteBuffer _bb, MonsterCommunicationGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009AB7 RID: 39607 RVA: 0x002A46C5 File Offset: 0x002A28C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009AB8 RID: 39608 RVA: 0x002A46D4 File Offset: 0x002A28D4
		public MonsterCommunicationGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001FA2 RID: 8098
		// (get) Token: 0x06009AB9 RID: 39609 RVA: 0x002A46E4 File Offset: 0x002A28E4
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

		// Token: 0x17001FA3 RID: 8099
		// (get) Token: 0x06009ABA RID: 39610 RVA: 0x002A4720 File Offset: 0x002A2920
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

		// Token: 0x06009ABB RID: 39611 RVA: 0x002A4757 File Offset: 0x002A2957
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06009ABC RID: 39612 RVA: 0x002A4766 File Offset: 0x002A2966
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001FA4 RID: 8100
		// (get) Token: 0x06009ABD RID: 39613 RVA: 0x002A4780 File Offset: 0x002A2980
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

		// Token: 0x06009ABE RID: 39614 RVA: 0x002A47B7 File Offset: 0x002A29B7
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06009ABF RID: 39615 RVA: 0x002A47C6 File Offset: 0x002A29C6
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0400549A RID: 21658
		private Table __p;
	}
}
