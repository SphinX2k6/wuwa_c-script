using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C99 RID: 3225
	public struct FlagChallengeTask : IFlatbufferObject
	{
		// Token: 0x17001240 RID: 4672
		// (get) Token: 0x06007197 RID: 29079 RVA: 0x0023680C File Offset: 0x00234A0C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007198 RID: 29080 RVA: 0x00236819 File Offset: 0x00234A19
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007199 RID: 29081 RVA: 0x00236820 File Offset: 0x00234A20
		public static FlagChallengeTask GetRootAsFlagChallengeTask(ByteBuffer _bb)
		{
			return FlagChallengeTask.GetRootAsFlagChallengeTask(_bb, default(FlagChallengeTask));
		}

		// Token: 0x0600719A RID: 29082 RVA: 0x0023683C File Offset: 0x00234A3C
		public static FlagChallengeTask GetRootAsFlagChallengeTask(ByteBuffer _bb, FlagChallengeTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600719B RID: 29083 RVA: 0x00236859 File Offset: 0x00234A59
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600719C RID: 29084 RVA: 0x00236868 File Offset: 0x00234A68
		public FlagChallengeTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001241 RID: 4673
		// (get) Token: 0x0600719D RID: 29085 RVA: 0x00236878 File Offset: 0x00234A78
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

		// Token: 0x17001242 RID: 4674
		// (get) Token: 0x0600719E RID: 29086 RVA: 0x002368B4 File Offset: 0x00234AB4
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

		// Token: 0x17001243 RID: 4675
		// (get) Token: 0x0600719F RID: 29087 RVA: 0x002368F0 File Offset: 0x00234AF0
		public int DropId
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

		// Token: 0x17001244 RID: 4676
		// (get) Token: 0x060071A0 RID: 29088 RVA: 0x0023692C File Offset: 0x00234B2C
		public string RewardName
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

		// Token: 0x060071A1 RID: 29089 RVA: 0x00236964 File Offset: 0x00234B64
		public Span<byte> GetRewardNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060071A2 RID: 29090 RVA: 0x00236974 File Offset: 0x00234B74
		public byte[] GetRewardNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04004CF0 RID: 19696
		private Table __p;
	}
}
