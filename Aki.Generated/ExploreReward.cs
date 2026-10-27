using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C4F RID: 3151
	public struct ExploreReward : IFlatbufferObject
	{
		// Token: 0x17000FD7 RID: 4055
		// (get) Token: 0x06006B70 RID: 27504 RVA: 0x002284A1 File Offset: 0x002266A1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006B71 RID: 27505 RVA: 0x002284AE File Offset: 0x002266AE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006B72 RID: 27506 RVA: 0x002284B8 File Offset: 0x002266B8
		public static ExploreReward GetRootAsExploreReward(ByteBuffer _bb)
		{
			return ExploreReward.GetRootAsExploreReward(_bb, default(ExploreReward));
		}

		// Token: 0x06006B73 RID: 27507 RVA: 0x002284D4 File Offset: 0x002266D4
		public static ExploreReward GetRootAsExploreReward(ByteBuffer _bb, ExploreReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006B74 RID: 27508 RVA: 0x002284F1 File Offset: 0x002266F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006B75 RID: 27509 RVA: 0x00228500 File Offset: 0x00226700
		public ExploreReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000FD8 RID: 4056
		// (get) Token: 0x06006B76 RID: 27510 RVA: 0x00228510 File Offset: 0x00226710
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

		// Token: 0x17000FD9 RID: 4057
		// (get) Token: 0x06006B77 RID: 27511 RVA: 0x0022854C File Offset: 0x0022674C
		public int Country
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

		// Token: 0x17000FDA RID: 4058
		// (get) Token: 0x06006B78 RID: 27512 RVA: 0x00228588 File Offset: 0x00226788
		public int ExploreLevel
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

		// Token: 0x17000FDB RID: 4059
		// (get) Token: 0x06006B79 RID: 27513 RVA: 0x002285C4 File Offset: 0x002267C4
		public int NeedScore
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

		// Token: 0x17000FDC RID: 4060
		// (get) Token: 0x06006B7A RID: 27514 RVA: 0x00228604 File Offset: 0x00226804
		public int Drop
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

		// Token: 0x17000FDD RID: 4061
		// (get) Token: 0x06006B7B RID: 27515 RVA: 0x00228644 File Offset: 0x00226844
		public int ShowItem
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

		// Token: 0x17000FDE RID: 4062
		// (get) Token: 0x06006B7C RID: 27516 RVA: 0x00228684 File Offset: 0x00226884
		public string ScoreName
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

		// Token: 0x06006B7D RID: 27517 RVA: 0x002286BC File Offset: 0x002268BC
		public Span<byte> GetScoreNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06006B7E RID: 27518 RVA: 0x002286CC File Offset: 0x002268CC
		public byte[] GetScoreNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17000FDF RID: 4063
		// (get) Token: 0x06006B7F RID: 27519 RVA: 0x002286E4 File Offset: 0x002268E4
		public string ScoreTexturePath
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

		// Token: 0x06006B80 RID: 27520 RVA: 0x0022871C File Offset: 0x0022691C
		public Span<byte> GetScoreTexturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06006B81 RID: 27521 RVA: 0x0022872C File Offset: 0x0022692C
		public byte[] GetScoreTexturePathArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17000FE0 RID: 4064
		// (get) Token: 0x06006B82 RID: 27522 RVA: 0x00228744 File Offset: 0x00226944
		public bool Show
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000FE1 RID: 4065
		// (get) Token: 0x06006B83 RID: 27523 RVA: 0x00228784 File Offset: 0x00226984
		public string Pic
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006B84 RID: 27524 RVA: 0x002287BC File Offset: 0x002269BC
		public Span<byte> GetPicBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06006B85 RID: 27525 RVA: 0x002287CC File Offset: 0x002269CC
		public byte[] GetPicArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17000FE2 RID: 4066
		// (get) Token: 0x06006B86 RID: 27526 RVA: 0x002287E4 File Offset: 0x002269E4
		public string RewardName
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006B87 RID: 27527 RVA: 0x0022881C File Offset: 0x00226A1C
		public Span<byte> GetRewardNameBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06006B88 RID: 27528 RVA: 0x0022882C File Offset: 0x00226A2C
		public byte[] GetRewardNameArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17000FE3 RID: 4067
		// (get) Token: 0x06006B89 RID: 27529 RVA: 0x00228844 File Offset: 0x00226A44
		public string Reward
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006B8A RID: 27530 RVA: 0x0022887C File Offset: 0x00226A7C
		public Span<byte> GetRewardBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06006B8B RID: 27531 RVA: 0x0022888C File Offset: 0x00226A8C
		public byte[] GetRewardArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17000FE4 RID: 4068
		// (get) Token: 0x06006B8C RID: 27532 RVA: 0x002288A4 File Offset: 0x00226AA4
		public int Help
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004C96 RID: 19606
		private Table __p;
	}
}
