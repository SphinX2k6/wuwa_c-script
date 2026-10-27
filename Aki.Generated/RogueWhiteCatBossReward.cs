using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001034 RID: 4148
	public struct RogueWhiteCatBossReward : IFlatbufferObject
	{
		// Token: 0x170031D8 RID: 12760
		// (get) Token: 0x0600C706 RID: 50950 RVA: 0x002F70DC File Offset: 0x002F52DC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C707 RID: 50951 RVA: 0x002F70E9 File Offset: 0x002F52E9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C708 RID: 50952 RVA: 0x002F70F0 File Offset: 0x002F52F0
		public static RogueWhiteCatBossReward GetRootAsRogueWhiteCatBossReward(ByteBuffer _bb)
		{
			return RogueWhiteCatBossReward.GetRootAsRogueWhiteCatBossReward(_bb, default(RogueWhiteCatBossReward));
		}

		// Token: 0x0600C709 RID: 50953 RVA: 0x002F710C File Offset: 0x002F530C
		public static RogueWhiteCatBossReward GetRootAsRogueWhiteCatBossReward(ByteBuffer _bb, RogueWhiteCatBossReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C70A RID: 50954 RVA: 0x002F7129 File Offset: 0x002F5329
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C70B RID: 50955 RVA: 0x002F7138 File Offset: 0x002F5338
		public RogueWhiteCatBossReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170031D9 RID: 12761
		// (get) Token: 0x0600C70C RID: 50956 RVA: 0x002F7148 File Offset: 0x002F5348
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

		// Token: 0x170031DA RID: 12762
		// (get) Token: 0x0600C70D RID: 50957 RVA: 0x002F7184 File Offset: 0x002F5384
		public int InstanceType
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

		// Token: 0x170031DB RID: 12763
		// (get) Token: 0x0600C70E RID: 50958 RVA: 0x002F71C0 File Offset: 0x002F53C0
		public string Title
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

		// Token: 0x0600C70F RID: 50959 RVA: 0x002F71F7 File Offset: 0x002F53F7
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600C710 RID: 50960 RVA: 0x002F7206 File Offset: 0x002F5406
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170031DC RID: 12764
		// (get) Token: 0x0600C711 RID: 50961 RVA: 0x002F7220 File Offset: 0x002F5420
		public int DropId
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

		// Token: 0x04005131 RID: 20785
		private Table __p;
	}
}
