using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200116C RID: 4460
	public struct TrapDefenseReward : IFlatbufferObject
	{
		// Token: 0x17003C70 RID: 15472
		// (get) Token: 0x0600E46A RID: 58474 RVA: 0x0033A688 File Offset: 0x00338888
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E46B RID: 58475 RVA: 0x0033A695 File Offset: 0x00338895
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E46C RID: 58476 RVA: 0x0033A69C File Offset: 0x0033889C
		public static TrapDefenseReward GetRootAsTrapDefenseReward(ByteBuffer _bb)
		{
			return TrapDefenseReward.GetRootAsTrapDefenseReward(_bb, default(TrapDefenseReward));
		}

		// Token: 0x0600E46D RID: 58477 RVA: 0x0033A6B8 File Offset: 0x003388B8
		public static TrapDefenseReward GetRootAsTrapDefenseReward(ByteBuffer _bb, TrapDefenseReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E46E RID: 58478 RVA: 0x0033A6D5 File Offset: 0x003388D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E46F RID: 58479 RVA: 0x0033A6E4 File Offset: 0x003388E4
		public TrapDefenseReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003C71 RID: 15473
		// (get) Token: 0x0600E470 RID: 58480 RVA: 0x0033A6F4 File Offset: 0x003388F4
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

		// Token: 0x17003C72 RID: 15474
		// (get) Token: 0x0600E471 RID: 58481 RVA: 0x0033A730 File Offset: 0x00338930
		public int ActivityId
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

		// Token: 0x17003C73 RID: 15475
		// (get) Token: 0x0600E472 RID: 58482 RVA: 0x0033A76C File Offset: 0x0033896C
		public int Type
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003C74 RID: 15476
		// (get) Token: 0x0600E473 RID: 58483 RVA: 0x0033A7A8 File Offset: 0x003389A8
		public bool IsPermanent
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003C75 RID: 15477
		// (get) Token: 0x0600E474 RID: 58484 RVA: 0x0033A7E8 File Offset: 0x003389E8
		public int RewardId
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

		// Token: 0x17003C76 RID: 15478
		// (get) Token: 0x0600E475 RID: 58485 RVA: 0x0033A828 File Offset: 0x00338A28
		public string Desc
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

		// Token: 0x0600E476 RID: 58486 RVA: 0x0033A860 File Offset: 0x00338A60
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600E477 RID: 58487 RVA: 0x0033A870 File Offset: 0x00338A70
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x040052B2 RID: 21170
		private Table __p;
	}
}
