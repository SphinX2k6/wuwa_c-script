using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D0F RID: 3343
	public struct GuessJokerAiConfig : IFlatbufferObject
	{
		// Token: 0x17001615 RID: 5653
		// (get) Token: 0x06007BE3 RID: 31715 RVA: 0x0024E3B1 File Offset: 0x0024C5B1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007BE4 RID: 31716 RVA: 0x0024E3BE File Offset: 0x0024C5BE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007BE5 RID: 31717 RVA: 0x0024E3C8 File Offset: 0x0024C5C8
		public static GuessJokerAiConfig GetRootAsGuessJokerAiConfig(ByteBuffer _bb)
		{
			return GuessJokerAiConfig.GetRootAsGuessJokerAiConfig(_bb, default(GuessJokerAiConfig));
		}

		// Token: 0x06007BE6 RID: 31718 RVA: 0x0024E3E4 File Offset: 0x0024C5E4
		public static GuessJokerAiConfig GetRootAsGuessJokerAiConfig(ByteBuffer _bb, GuessJokerAiConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007BE7 RID: 31719 RVA: 0x0024E401 File Offset: 0x0024C601
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007BE8 RID: 31720 RVA: 0x0024E410 File Offset: 0x0024C610
		public GuessJokerAiConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001616 RID: 5654
		// (get) Token: 0x06007BE9 RID: 31721 RVA: 0x0024E420 File Offset: 0x0024C620
		public int RoleId
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

		// Token: 0x17001617 RID: 5655
		// (get) Token: 0x06007BEA RID: 31722 RVA: 0x0024E45C File Offset: 0x0024C65C
		public int NpcId
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

		// Token: 0x17001618 RID: 5656
		// (get) Token: 0x06007BEB RID: 31723 RVA: 0x0024E498 File Offset: 0x0024C698
		public int ChairId
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

		// Token: 0x17001619 RID: 5657
		// (get) Token: 0x06007BEC RID: 31724 RVA: 0x0024E4D4 File Offset: 0x0024C6D4
		public int GamePlayCameraId
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

		// Token: 0x1700161A RID: 5658
		// (get) Token: 0x06007BED RID: 31725 RVA: 0x0024E514 File Offset: 0x0024C714
		public int SelectRoleCameraId
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

		// Token: 0x1700161B RID: 5659
		// (get) Token: 0x06007BEE RID: 31726 RVA: 0x0024E554 File Offset: 0x0024C754
		public int SettleCameraId
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700161C RID: 5660
		// (get) Token: 0x06007BEF RID: 31727 RVA: 0x0024E594 File Offset: 0x0024C794
		public string UseSkillText
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

		// Token: 0x06007BF0 RID: 31728 RVA: 0x0024E5CC File Offset: 0x0024C7CC
		public Span<byte> GetUseSkillTextBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06007BF1 RID: 31729 RVA: 0x0024E5DC File Offset: 0x0024C7DC
		public byte[] GetUseSkillTextArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700161D RID: 5661
		// (get) Token: 0x06007BF2 RID: 31730 RVA: 0x0024E5F4 File Offset: 0x0024C7F4
		public string GiveUpSkillText
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007BF3 RID: 31731 RVA: 0x0024E62C File Offset: 0x0024C82C
		public Span<byte> GetGiveUpSkillTextBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06007BF4 RID: 31732 RVA: 0x0024E63C File Offset: 0x0024C83C
		public byte[] GetGiveUpSkillTextArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x04004D85 RID: 19845
		private Table __p;
	}
}
