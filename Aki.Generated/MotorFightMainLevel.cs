using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F2D RID: 3885
	public struct MotorFightMainLevel : IFlatbufferObject
	{
		// Token: 0x1700214D RID: 8525
		// (get) Token: 0x06009EE3 RID: 40675 RVA: 0x002AD6F4 File Offset: 0x002AB8F4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009EE4 RID: 40676 RVA: 0x002AD701 File Offset: 0x002AB901
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009EE5 RID: 40677 RVA: 0x002AD708 File Offset: 0x002AB908
		public static MotorFightMainLevel GetRootAsMotorFightMainLevel(ByteBuffer _bb)
		{
			return MotorFightMainLevel.GetRootAsMotorFightMainLevel(_bb, default(MotorFightMainLevel));
		}

		// Token: 0x06009EE6 RID: 40678 RVA: 0x002AD724 File Offset: 0x002AB924
		public static MotorFightMainLevel GetRootAsMotorFightMainLevel(ByteBuffer _bb, MotorFightMainLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009EE7 RID: 40679 RVA: 0x002AD741 File Offset: 0x002AB941
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009EE8 RID: 40680 RVA: 0x002AD750 File Offset: 0x002AB950
		public MotorFightMainLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700214E RID: 8526
		// (get) Token: 0x06009EE9 RID: 40681 RVA: 0x002AD760 File Offset: 0x002AB960
		public int LevelId
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

		// Token: 0x1700214F RID: 8527
		// (get) Token: 0x06009EEA RID: 40682 RVA: 0x002AD79C File Offset: 0x002AB99C
		public int InstId
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

		// Token: 0x17002150 RID: 8528
		// (get) Token: 0x06009EEB RID: 40683 RVA: 0x002AD7D8 File Offset: 0x002AB9D8
		public int PreLevelId
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

		// Token: 0x17002151 RID: 8529
		// (get) Token: 0x06009EEC RID: 40684 RVA: 0x002AD814 File Offset: 0x002ABA14
		public int LevelType
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

		// Token: 0x06009EED RID: 40685 RVA: 0x002AD854 File Offset: 0x002ABA54
		public int SubLevels(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002152 RID: 8530
		// (get) Token: 0x06009EEE RID: 40686 RVA: 0x002AD894 File Offset: 0x002ABA94
		public int SubLevelsLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06009EEF RID: 40687 RVA: 0x002AD8C0 File Offset: 0x002ABAC0
		public Span<int> GetSubLevelsBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x06009EF0 RID: 40688 RVA: 0x002AD8D0 File Offset: 0x002ABAD0
		public int[] GetSubLevelsArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x17002153 RID: 8531
		// (get) Token: 0x06009EF1 RID: 40689 RVA: 0x002AD8E8 File Offset: 0x002ABAE8
		public int PlayerHp
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

		// Token: 0x17002154 RID: 8532
		// (get) Token: 0x06009EF2 RID: 40690 RVA: 0x002AD928 File Offset: 0x002ABB28
		public float BaseWorldSpeed
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 100f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002155 RID: 8533
		// (get) Token: 0x06009EF3 RID: 40691 RVA: 0x002AD96C File Offset: 0x002ABB6C
		public float SceneSegmentLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 10000f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009EF4 RID: 40692 RVA: 0x002AD9B0 File Offset: 0x002ABBB0
		public int Effects(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002156 RID: 8534
		// (get) Token: 0x06009EF5 RID: 40693 RVA: 0x002AD9F0 File Offset: 0x002ABBF0
		public int EffectsLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06009EF6 RID: 40694 RVA: 0x002ADA1C File Offset: 0x002ABC1C
		public Span<int> GetEffectsBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x06009EF7 RID: 40695 RVA: 0x002ADA2C File Offset: 0x002ABC2C
		public int[] GetEffectsArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x17002157 RID: 8535
		// (get) Token: 0x06009EF8 RID: 40696 RVA: 0x002ADA44 File Offset: 0x002ABC44
		public int BigScore
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 20;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002158 RID: 8536
		// (get) Token: 0x06009EF9 RID: 40697 RVA: 0x002ADA84 File Offset: 0x002ABC84
		public int SkillEnable
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002159 RID: 8537
		// (get) Token: 0x06009EFA RID: 40698 RVA: 0x002ADAC4 File Offset: 0x002ABCC4
		public string NormalMusic
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

		// Token: 0x06009EFB RID: 40699 RVA: 0x002ADAFC File Offset: 0x002ABCFC
		public Span<byte> GetNormalMusicBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06009EFC RID: 40700 RVA: 0x002ADB0C File Offset: 0x002ABD0C
		public byte[] GetNormalMusicArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x1700215A RID: 8538
		// (get) Token: 0x06009EFD RID: 40701 RVA: 0x002ADB24 File Offset: 0x002ABD24
		public string BossMusic
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009EFE RID: 40702 RVA: 0x002ADB5C File Offset: 0x002ABD5C
		public Span<byte> GetBossMusicBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06009EFF RID: 40703 RVA: 0x002ADB6C File Offset: 0x002ABD6C
		public byte[] GetBossMusicArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x1700215B RID: 8539
		// (get) Token: 0x06009F00 RID: 40704 RVA: 0x002ADB84 File Offset: 0x002ABD84
		public string StopMusic
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009F01 RID: 40705 RVA: 0x002ADBBC File Offset: 0x002ABDBC
		public Span<byte> GetStopMusicBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x06009F02 RID: 40706 RVA: 0x002ADBCC File Offset: 0x002ABDCC
		public byte[] GetStopMusicArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x06009F03 RID: 40707 RVA: 0x002ADBE4 File Offset: 0x002ABDE4
		[NullableContext(1)]
		public int[] Effects()
		{
			return this.GetEffectsArray();
		}

		// Token: 0x06009F04 RID: 40708 RVA: 0x002ADBEC File Offset: 0x002ABDEC
		[NullableContext(1)]
		public IEnumerable<int> EffectsIter()
		{
			MotorFightMainLevel.<EffectsIter>d__49 <EffectsIter>d__ = new MotorFightMainLevel.<EffectsIter>d__49(-2);
			<EffectsIter>d__.<>3__<>4__this = this;
			return <EffectsIter>d__;
		}

		// Token: 0x06009F05 RID: 40709 RVA: 0x002ADC01 File Offset: 0x002ABE01
		[NullableContext(1)]
		public int[] SubLevels()
		{
			return this.GetSubLevelsArray();
		}

		// Token: 0x06009F06 RID: 40710 RVA: 0x002ADC09 File Offset: 0x002ABE09
		[NullableContext(1)]
		public IEnumerable<int> SubLevelsIter()
		{
			MotorFightMainLevel.<SubLevelsIter>d__51 <SubLevelsIter>d__ = new MotorFightMainLevel.<SubLevelsIter>d__51(-2);
			<SubLevelsIter>d__.<>3__<>4__this = this;
			return <SubLevelsIter>d__;
		}

		// Token: 0x040054D5 RID: 21717
		private Table __p;
	}
}
