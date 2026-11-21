using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010F4 RID: 4340
	public struct RogueResMoodRule : IFlatbufferObject
	{
		// Token: 0x17003114 RID: 12564
		// (get) Token: 0x0600C9B5 RID: 51637 RVA: 0x0030AC22 File Offset: 0x00308E22
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C9B6 RID: 51638 RVA: 0x0030AC2F File Offset: 0x00308E2F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C9B7 RID: 51639 RVA: 0x0030AC38 File Offset: 0x00308E38
		public static RogueResMoodRule GetRootAsRogueResMoodRule(ByteBuffer _bb)
		{
			return RogueResMoodRule.GetRootAsRogueResMoodRule(_bb, default(RogueResMoodRule));
		}

		// Token: 0x0600C9B8 RID: 51640 RVA: 0x0030AC54 File Offset: 0x00308E54
		public static RogueResMoodRule GetRootAsRogueResMoodRule(ByteBuffer _bb, RogueResMoodRule obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C9B9 RID: 51641 RVA: 0x0030AC71 File Offset: 0x00308E71
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C9BA RID: 51642 RVA: 0x0030AC80 File Offset: 0x00308E80
		public RogueResMoodRule __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003115 RID: 12565
		// (get) Token: 0x0600C9BB RID: 51643 RVA: 0x0030AC90 File Offset: 0x00308E90
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

		// Token: 0x17003116 RID: 12566
		// (get) Token: 0x0600C9BC RID: 51644 RVA: 0x0030ACCC File Offset: 0x00308ECC
		public int Type
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

		// Token: 0x17003117 RID: 12567
		// (get) Token: 0x0600C9BD RID: 51645 RVA: 0x0030AD08 File Offset: 0x00308F08
		public string FloatTips
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

		// Token: 0x0600C9BE RID: 51646 RVA: 0x0030AD3F File Offset: 0x00308F3F
		public Span<byte> GetFloatTipsBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600C9BF RID: 51647 RVA: 0x0030AD4E File Offset: 0x00308F4E
		public byte[] GetFloatTipsArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003118 RID: 12568
		// (get) Token: 0x0600C9C0 RID: 51648 RVA: 0x0030AD68 File Offset: 0x00308F68
		public string MapMusicStateSwitch
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

		// Token: 0x0600C9C1 RID: 51649 RVA: 0x0030ADA0 File Offset: 0x00308FA0
		public Span<byte> GetMapMusicStateSwitchBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600C9C2 RID: 51650 RVA: 0x0030ADB0 File Offset: 0x00308FB0
		public byte[] GetMapMusicStateSwitchArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x040056E1 RID: 22241
		private Table __p;
	}
}
