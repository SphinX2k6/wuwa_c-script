using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010D5 RID: 4309
	public struct SoarChallenge : IFlatbufferObject
	{
		// Token: 0x17003781 RID: 14209
		// (get) Token: 0x0600D71A RID: 55066 RVA: 0x0031C43C File Offset: 0x0031A63C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D71B RID: 55067 RVA: 0x0031C449 File Offset: 0x0031A649
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D71C RID: 55068 RVA: 0x0031C450 File Offset: 0x0031A650
		public static SoarChallenge GetRootAsSoarChallenge(ByteBuffer _bb)
		{
			return SoarChallenge.GetRootAsSoarChallenge(_bb, default(SoarChallenge));
		}

		// Token: 0x0600D71D RID: 55069 RVA: 0x0031C46C File Offset: 0x0031A66C
		public static SoarChallenge GetRootAsSoarChallenge(ByteBuffer _bb, SoarChallenge obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D71E RID: 55070 RVA: 0x0031C489 File Offset: 0x0031A689
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D71F RID: 55071 RVA: 0x0031C498 File Offset: 0x0031A698
		public SoarChallenge __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003782 RID: 14210
		// (get) Token: 0x0600D720 RID: 55072 RVA: 0x0031C4A8 File Offset: 0x0031A6A8
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

		// Token: 0x17003783 RID: 14211
		// (get) Token: 0x0600D721 RID: 55073 RVA: 0x0031C4E4 File Offset: 0x0031A6E4
		public int LevelPlayId
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

		// Token: 0x17003784 RID: 14212
		// (get) Token: 0x0600D722 RID: 55074 RVA: 0x0031C520 File Offset: 0x0031A720
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

		// Token: 0x0600D723 RID: 55075 RVA: 0x0031C557 File Offset: 0x0031A757
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600D724 RID: 55076 RVA: 0x0031C566 File Offset: 0x0031A766
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003785 RID: 14213
		// (get) Token: 0x0600D725 RID: 55077 RVA: 0x0031C580 File Offset: 0x0031A780
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

		// Token: 0x17003786 RID: 14214
		// (get) Token: 0x0600D726 RID: 55078 RVA: 0x0031C5C0 File Offset: 0x0031A7C0
		public int Reward
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

		// Token: 0x17003787 RID: 14215
		// (get) Token: 0x0600D727 RID: 55079 RVA: 0x0031C600 File Offset: 0x0031A800
		public string ScoreText
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

		// Token: 0x0600D728 RID: 55080 RVA: 0x0031C638 File Offset: 0x0031A838
		public Span<byte> GetScoreTextBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600D729 RID: 55081 RVA: 0x0031C648 File Offset: 0x0031A848
		public byte[] GetScoreTextArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17003788 RID: 14216
		// (get) Token: 0x0600D72A RID: 55082 RVA: 0x0031C660 File Offset: 0x0031A860
		public int JumpId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003789 RID: 14217
		// (get) Token: 0x0600D72B RID: 55083 RVA: 0x0031C6A0 File Offset: 0x0031A8A0
		public int UnlockTravelLevel
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700378A RID: 14218
		// (get) Token: 0x0600D72C RID: 55084 RVA: 0x0031C6E0 File Offset: 0x0031A8E0
		public int UnlockQuestId
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700378B RID: 14219
		// (get) Token: 0x0600D72D RID: 55085 RVA: 0x0031C720 File Offset: 0x0031A920
		public string LockTips
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

		// Token: 0x0600D72E RID: 55086 RVA: 0x0031C758 File Offset: 0x0031A958
		public Span<byte> GetLockTipsBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600D72F RID: 55087 RVA: 0x0031C768 File Offset: 0x0031A968
		public byte[] GetLockTipsArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x04005208 RID: 21000
		private Table __p;
	}
}
