using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BF6 RID: 3062
	public struct AvoidBlockLevel : IFlatbufferObject
	{
		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06004FC6 RID: 20422 RVA: 0x001FB555 File Offset: 0x001F9755
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004FC7 RID: 20423 RVA: 0x001FB562 File Offset: 0x001F9762
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004FC8 RID: 20424 RVA: 0x001FB56C File Offset: 0x001F976C
		public static AvoidBlockLevel GetRootAsAvoidBlockLevel(ByteBuffer _bb)
		{
			return AvoidBlockLevel.GetRootAsAvoidBlockLevel(_bb, default(AvoidBlockLevel));
		}

		// Token: 0x06004FC9 RID: 20425 RVA: 0x001FB588 File Offset: 0x001F9788
		public static AvoidBlockLevel GetRootAsAvoidBlockLevel(ByteBuffer _bb, AvoidBlockLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004FCA RID: 20426 RVA: 0x001FB5A5 File Offset: 0x001F97A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004FCB RID: 20427 RVA: 0x001FB5B4 File Offset: 0x001F97B4
		public AvoidBlockLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06004FCC RID: 20428 RVA: 0x001FB5C4 File Offset: 0x001F97C4
		public int InstId
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

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06004FCD RID: 20429 RVA: 0x001FB600 File Offset: 0x001F9800
		public int RewardGroupId
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

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06004FCE RID: 20430 RVA: 0x001FB63C File Offset: 0x001F983C
		public string MainTitleText
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

		// Token: 0x06004FCF RID: 20431 RVA: 0x001FB673 File Offset: 0x001F9873
		public Span<byte> GetMainTitleTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004FD0 RID: 20432 RVA: 0x001FB682 File Offset: 0x001F9882
		public byte[] GetMainTitleTextArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06004FD1 RID: 20433 RVA: 0x001FB69C File Offset: 0x001F989C
		public string AchieveText
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

		// Token: 0x06004FD2 RID: 20434 RVA: 0x001FB6D4 File Offset: 0x001F98D4
		public Span<byte> GetAchieveTextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06004FD3 RID: 20435 RVA: 0x001FB6E4 File Offset: 0x001F98E4
		public byte[] GetAchieveTextArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06004FD4 RID: 20436 RVA: 0x001FB6FC File Offset: 0x001F98FC
		public string RewardTitleText
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004FD5 RID: 20437 RVA: 0x001FB734 File Offset: 0x001F9934
		public Span<byte> GetRewardTitleTextBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06004FD6 RID: 20438 RVA: 0x001FB744 File Offset: 0x001F9944
		public byte[] GetRewardTitleTextArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x040050DE RID: 20702
		private Table __p;
	}
}
