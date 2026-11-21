using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EC4 RID: 3780
	public struct LordGym : IFlatbufferObject
	{
		// Token: 0x17001DDF RID: 7647
		// (get) Token: 0x060095E2 RID: 38370 RVA: 0x00299BD8 File Offset: 0x00297DD8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060095E3 RID: 38371 RVA: 0x00299BE5 File Offset: 0x00297DE5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060095E4 RID: 38372 RVA: 0x00299BEC File Offset: 0x00297DEC
		public static LordGym GetRootAsLordGym(ByteBuffer _bb)
		{
			return LordGym.GetRootAsLordGym(_bb, default(LordGym));
		}

		// Token: 0x060095E5 RID: 38373 RVA: 0x00299C08 File Offset: 0x00297E08
		public static LordGym GetRootAsLordGym(ByteBuffer _bb, LordGym obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060095E6 RID: 38374 RVA: 0x00299C25 File Offset: 0x00297E25
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060095E7 RID: 38375 RVA: 0x00299C34 File Offset: 0x00297E34
		public LordGym __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001DE0 RID: 7648
		// (get) Token: 0x060095E8 RID: 38376 RVA: 0x00299C44 File Offset: 0x00297E44
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

		// Token: 0x17001DE1 RID: 7649
		// (get) Token: 0x060095E9 RID: 38377 RVA: 0x00299C80 File Offset: 0x00297E80
		public int Difficulty
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001DE2 RID: 7650
		// (get) Token: 0x060095EA RID: 38378 RVA: 0x00299CBC File Offset: 0x00297EBC
		public int Version
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001DE3 RID: 7651
		// (get) Token: 0x060095EB RID: 38379 RVA: 0x00299CF8 File Offset: 0x00297EF8
		public int RewardId
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

		// Token: 0x17001DE4 RID: 7652
		// (get) Token: 0x060095EC RID: 38380 RVA: 0x00299D38 File Offset: 0x00297F38
		public int PlayId
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

		// Token: 0x17001DE5 RID: 7653
		// (get) Token: 0x060095ED RID: 38381 RVA: 0x00299D78 File Offset: 0x00297F78
		public int GuidePlayId
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

		// Token: 0x17001DE6 RID: 7654
		// (get) Token: 0x060095EE RID: 38382 RVA: 0x00299DB8 File Offset: 0x00297FB8
		public string GymTitle
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

		// Token: 0x060095EF RID: 38383 RVA: 0x00299DF0 File Offset: 0x00297FF0
		public Span<byte> GetGymTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060095F0 RID: 38384 RVA: 0x00299E00 File Offset: 0x00298000
		public byte[] GetGymTitleArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17001DE7 RID: 7655
		// (get) Token: 0x060095F1 RID: 38385 RVA: 0x00299E18 File Offset: 0x00298018
		public string FirstGuideGymTitle
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

		// Token: 0x060095F2 RID: 38386 RVA: 0x00299E50 File Offset: 0x00298050
		public Span<byte> GetFirstGuideGymTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x060095F3 RID: 38387 RVA: 0x00299E60 File Offset: 0x00298060
		public byte[] GetFirstGuideGymTitleArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17001DE8 RID: 7656
		// (get) Token: 0x060095F4 RID: 38388 RVA: 0x00299E78 File Offset: 0x00298078
		public string NewGymTitle
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060095F5 RID: 38389 RVA: 0x00299EB0 File Offset: 0x002980B0
		public Span<byte> GetNewGymTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x060095F6 RID: 38390 RVA: 0x00299EC0 File Offset: 0x002980C0
		public byte[] GetNewGymTitleArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17001DE9 RID: 7657
		// (get) Token: 0x060095F7 RID: 38391 RVA: 0x00299ED8 File Offset: 0x002980D8
		public string IconPath
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

		// Token: 0x060095F8 RID: 38392 RVA: 0x00299F10 File Offset: 0x00298110
		public Span<byte> GetIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x060095F9 RID: 38393 RVA: 0x00299F20 File Offset: 0x00298120
		public byte[] GetIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17001DEA RID: 7658
		// (get) Token: 0x060095FA RID: 38394 RVA: 0x00299F38 File Offset: 0x00298138
		public string PlayDescription
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

		// Token: 0x060095FB RID: 38395 RVA: 0x00299F70 File Offset: 0x00298170
		public Span<byte> GetPlayDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x060095FC RID: 38396 RVA: 0x00299F80 File Offset: 0x00298180
		public byte[] GetPlayDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17001DEB RID: 7659
		// (get) Token: 0x060095FD RID: 38397 RVA: 0x00299F98 File Offset: 0x00298198
		public int HelpId
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060095FE RID: 38398 RVA: 0x00299FD8 File Offset: 0x002981D8
		public int MonsterList(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001DEC RID: 7660
		// (get) Token: 0x060095FF RID: 38399 RVA: 0x0029A018 File Offset: 0x00298218
		public int MonsterListLength
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06009600 RID: 38400 RVA: 0x0029A044 File Offset: 0x00298244
		public Span<int> GetMonsterListBytes()
		{
			return this.__p.__vector_as_span<int>(28, 4);
		}

		// Token: 0x06009601 RID: 38401 RVA: 0x0029A054 File Offset: 0x00298254
		public int[] GetMonsterListArray()
		{
			return this.__p.__vector_as_array<int>(28) ?? Array.Empty<int>();
		}

		// Token: 0x17001DED RID: 7661
		// (get) Token: 0x06009602 RID: 38402 RVA: 0x0029A06C File Offset: 0x0029826C
		public int MonsterLevel
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001DEE RID: 7662
		// (get) Token: 0x06009603 RID: 38403 RVA: 0x0029A0AC File Offset: 0x002982AC
		public int LockCon
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001DEF RID: 7663
		// (get) Token: 0x06009604 RID: 38404 RVA: 0x0029A0EC File Offset: 0x002982EC
		public string LockDescription
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009605 RID: 38405 RVA: 0x0029A124 File Offset: 0x00298324
		public Span<byte> GetLockDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x06009606 RID: 38406 RVA: 0x0029A134 File Offset: 0x00298334
		public byte[] GetLockDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x17001DF0 RID: 7664
		// (get) Token: 0x06009607 RID: 38407 RVA: 0x0029A14C File Offset: 0x0029834C
		public int FilterType
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001DF1 RID: 7665
		// (get) Token: 0x06009608 RID: 38408 RVA: 0x0029A18C File Offset: 0x0029838C
		public bool IsNew
		{
			get
			{
				int num = this.__p.__offset(38);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001DF2 RID: 7666
		// (get) Token: 0x06009609 RID: 38409 RVA: 0x0029A1CC File Offset: 0x002983CC
		public bool IsDebug
		{
			get
			{
				int num = this.__p.__offset(40);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600960A RID: 38410 RVA: 0x0029A20C File Offset: 0x0029840C
		[NullableContext(1)]
		public int[] MonsterList()
		{
			return this.GetMonsterListArray();
		}

		// Token: 0x0600960B RID: 38411 RVA: 0x0029A214 File Offset: 0x00298414
		[NullableContext(1)]
		public IEnumerable<int> MonsterListIter()
		{
			LordGym.<MonsterListIter>d__62 <MonsterListIter>d__ = new LordGym.<MonsterListIter>d__62(-2);
			<MonsterListIter>d__.<>3__<>4__this = this;
			return <MonsterListIter>d__;
		}

		// Token: 0x04005460 RID: 21600
		private Table __p;
	}
}
