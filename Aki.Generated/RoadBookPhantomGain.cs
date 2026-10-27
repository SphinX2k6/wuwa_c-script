using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FD3 RID: 4051
	public struct RoadBookPhantomGain : IFlatbufferObject
	{
		// Token: 0x17002EC4 RID: 11972
		// (get) Token: 0x0600BDD5 RID: 48597 RVA: 0x002E23D8 File Offset: 0x002E05D8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BDD6 RID: 48598 RVA: 0x002E23E5 File Offset: 0x002E05E5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BDD7 RID: 48599 RVA: 0x002E23EC File Offset: 0x002E05EC
		public static RoadBookPhantomGain GetRootAsRoadBookPhantomGain(ByteBuffer _bb)
		{
			return RoadBookPhantomGain.GetRootAsRoadBookPhantomGain(_bb, default(RoadBookPhantomGain));
		}

		// Token: 0x0600BDD8 RID: 48600 RVA: 0x002E2408 File Offset: 0x002E0608
		public static RoadBookPhantomGain GetRootAsRoadBookPhantomGain(ByteBuffer _bb, RoadBookPhantomGain obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BDD9 RID: 48601 RVA: 0x002E2425 File Offset: 0x002E0625
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BDDA RID: 48602 RVA: 0x002E2434 File Offset: 0x002E0634
		public RoadBookPhantomGain __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002EC5 RID: 11973
		// (get) Token: 0x0600BDDB RID: 48603 RVA: 0x002E2444 File Offset: 0x002E0644
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

		// Token: 0x17002EC6 RID: 11974
		// (get) Token: 0x0600BDDC RID: 48604 RVA: 0x002E2480 File Offset: 0x002E0680
		public int MonsterInfoId
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

		// Token: 0x17002EC7 RID: 11975
		// (get) Token: 0x0600BDDD RID: 48605 RVA: 0x002E24BC File Offset: 0x002E06BC
		public int ActivityId
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

		// Token: 0x17002EC8 RID: 11976
		// (get) Token: 0x0600BDDE RID: 48606 RVA: 0x002E24F8 File Offset: 0x002E06F8
		public int UnLockReward
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

		// Token: 0x17002EC9 RID: 11977
		// (get) Token: 0x0600BDDF RID: 48607 RVA: 0x002E2538 File Offset: 0x002E0738
		public int Sort
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

		// Token: 0x17002ECA RID: 11978
		// (get) Token: 0x0600BDE0 RID: 48608 RVA: 0x002E2578 File Offset: 0x002E0778
		public string Name
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

		// Token: 0x0600BDE1 RID: 48609 RVA: 0x002E25B0 File Offset: 0x002E07B0
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600BDE2 RID: 48610 RVA: 0x002E25C0 File Offset: 0x002E07C0
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002ECB RID: 11979
		// (get) Token: 0x0600BDE3 RID: 48611 RVA: 0x002E25D8 File Offset: 0x002E07D8
		public string TexPhantom
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BDE4 RID: 48612 RVA: 0x002E2610 File Offset: 0x002E0810
		public Span<byte> GetTexPhantomBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600BDE5 RID: 48613 RVA: 0x002E2620 File Offset: 0x002E0820
		public byte[] GetTexPhantomArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x040050AF RID: 20655
		private Table __p;
	}
}
