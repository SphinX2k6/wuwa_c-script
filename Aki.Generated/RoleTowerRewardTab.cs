using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001153 RID: 4435
	public struct RoleTowerRewardTab : IFlatbufferObject
	{
		// Token: 0x17003445 RID: 13381
		// (get) Token: 0x0600D296 RID: 53910 RVA: 0x0031EF5A File Offset: 0x0031D15A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D297 RID: 53911 RVA: 0x0031EF67 File Offset: 0x0031D167
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D298 RID: 53912 RVA: 0x0031EF70 File Offset: 0x0031D170
		public static RoleTowerRewardTab GetRootAsRoleTowerRewardTab(ByteBuffer _bb)
		{
			return RoleTowerRewardTab.GetRootAsRoleTowerRewardTab(_bb, default(RoleTowerRewardTab));
		}

		// Token: 0x0600D299 RID: 53913 RVA: 0x0031EF8C File Offset: 0x0031D18C
		public static RoleTowerRewardTab GetRootAsRoleTowerRewardTab(ByteBuffer _bb, RoleTowerRewardTab obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D29A RID: 53914 RVA: 0x0031EFA9 File Offset: 0x0031D1A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D29B RID: 53915 RVA: 0x0031EFB8 File Offset: 0x0031D1B8
		public RoleTowerRewardTab __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003446 RID: 13382
		// (get) Token: 0x0600D29C RID: 53916 RVA: 0x0031EFC8 File Offset: 0x0031D1C8
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

		// Token: 0x17003447 RID: 13383
		// (get) Token: 0x0600D29D RID: 53917 RVA: 0x0031F004 File Offset: 0x0031D204
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

		// Token: 0x17003448 RID: 13384
		// (get) Token: 0x0600D29E RID: 53918 RVA: 0x0031F040 File Offset: 0x0031D240
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

		// Token: 0x0600D29F RID: 53919 RVA: 0x0031F077 File Offset: 0x0031D277
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600D2A0 RID: 53920 RVA: 0x0031F086 File Offset: 0x0031D286
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0400575A RID: 22362
		private Table __p;
	}
}
