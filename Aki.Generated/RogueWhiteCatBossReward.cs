using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200111C RID: 4380
	public struct RogueWhiteCatBossReward : IFlatbufferObject
	{
		// Token: 0x17003253 RID: 12883
		// (get) Token: 0x0600CD50 RID: 52560 RVA: 0x00312F50 File Offset: 0x00311150
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CD51 RID: 52561 RVA: 0x00312F5D File Offset: 0x0031115D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CD52 RID: 52562 RVA: 0x00312F64 File Offset: 0x00311164
		public static RogueWhiteCatBossReward GetRootAsRogueWhiteCatBossReward(ByteBuffer _bb)
		{
			return RogueWhiteCatBossReward.GetRootAsRogueWhiteCatBossReward(_bb, default(RogueWhiteCatBossReward));
		}

		// Token: 0x0600CD53 RID: 52563 RVA: 0x00312F80 File Offset: 0x00311180
		public static RogueWhiteCatBossReward GetRootAsRogueWhiteCatBossReward(ByteBuffer _bb, RogueWhiteCatBossReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CD54 RID: 52564 RVA: 0x00312F9D File Offset: 0x0031119D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CD55 RID: 52565 RVA: 0x00312FAC File Offset: 0x003111AC
		public RogueWhiteCatBossReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003254 RID: 12884
		// (get) Token: 0x0600CD56 RID: 52566 RVA: 0x00312FBC File Offset: 0x003111BC
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

		// Token: 0x17003255 RID: 12885
		// (get) Token: 0x0600CD57 RID: 52567 RVA: 0x00312FF8 File Offset: 0x003111F8
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

		// Token: 0x17003256 RID: 12886
		// (get) Token: 0x0600CD58 RID: 52568 RVA: 0x00313034 File Offset: 0x00311234
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

		// Token: 0x0600CD59 RID: 52569 RVA: 0x0031306B File Offset: 0x0031126B
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600CD5A RID: 52570 RVA: 0x0031307A File Offset: 0x0031127A
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003257 RID: 12887
		// (get) Token: 0x0600CD5B RID: 52571 RVA: 0x00313094 File Offset: 0x00311294
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

		// Token: 0x04005719 RID: 22297
		private Table __p;
	}
}
