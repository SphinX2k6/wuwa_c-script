using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CAC RID: 3244
	public struct DangoBrawlOpponent : IFlatbufferObject
	{
		// Token: 0x17000B90 RID: 2960
		// (get) Token: 0x06006482 RID: 25730 RVA: 0x0022B25C File Offset: 0x0022945C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006483 RID: 25731 RVA: 0x0022B269 File Offset: 0x00229469
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006484 RID: 25732 RVA: 0x0022B270 File Offset: 0x00229470
		public static DangoBrawlOpponent GetRootAsDangoBrawlOpponent(ByteBuffer _bb)
		{
			return DangoBrawlOpponent.GetRootAsDangoBrawlOpponent(_bb, default(DangoBrawlOpponent));
		}

		// Token: 0x06006485 RID: 25733 RVA: 0x0022B28C File Offset: 0x0022948C
		public static DangoBrawlOpponent GetRootAsDangoBrawlOpponent(ByteBuffer _bb, DangoBrawlOpponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006486 RID: 25734 RVA: 0x0022B2A9 File Offset: 0x002294A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006487 RID: 25735 RVA: 0x0022B2B8 File Offset: 0x002294B8
		public DangoBrawlOpponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000B91 RID: 2961
		// (get) Token: 0x06006488 RID: 25736 RVA: 0x0022B2C8 File Offset: 0x002294C8
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

		// Token: 0x17000B92 RID: 2962
		// (get) Token: 0x06006489 RID: 25737 RVA: 0x0022B304 File Offset: 0x00229504
		public string Name
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600648A RID: 25738 RVA: 0x0022B33B File Offset: 0x0022953B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600648B RID: 25739 RVA: 0x0022B34A File Offset: 0x0022954A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B93 RID: 2963
		// (get) Token: 0x0600648C RID: 25740 RVA: 0x0022B364 File Offset: 0x00229564
		public int OccupationId
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

		// Token: 0x17000B94 RID: 2964
		// (get) Token: 0x0600648D RID: 25741 RVA: 0x0022B3A0 File Offset: 0x002295A0
		public int WobblePlateId
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

		// Token: 0x17000B95 RID: 2965
		// (get) Token: 0x0600648E RID: 25742 RVA: 0x0022B3E0 File Offset: 0x002295E0
		public string RoleIcon
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

		// Token: 0x0600648F RID: 25743 RVA: 0x0022B418 File Offset: 0x00229618
		public Span<byte> GetRoleIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06006490 RID: 25744 RVA: 0x0022B428 File Offset: 0x00229628
		public byte[] GetRoleIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B96 RID: 2966
		// (get) Token: 0x06006491 RID: 25745 RVA: 0x0022B440 File Offset: 0x00229640
		public string RoleBuffIcon
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

		// Token: 0x06006492 RID: 25746 RVA: 0x0022B478 File Offset: 0x00229678
		public Span<byte> GetRoleBuffIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06006493 RID: 25747 RVA: 0x0022B488 File Offset: 0x00229688
		public byte[] GetRoleBuffIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B97 RID: 2967
		// (get) Token: 0x06006494 RID: 25748 RVA: 0x0022B4A0 File Offset: 0x002296A0
		public string SpineAtlasPath
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

		// Token: 0x06006495 RID: 25749 RVA: 0x0022B4D8 File Offset: 0x002296D8
		public Span<byte> GetSpineAtlasPathBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06006496 RID: 25750 RVA: 0x0022B4E8 File Offset: 0x002296E8
		public byte[] GetSpineAtlasPathArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B98 RID: 2968
		// (get) Token: 0x06006497 RID: 25751 RVA: 0x0022B500 File Offset: 0x00229700
		public string SpineSkeletonDataPath
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

		// Token: 0x06006498 RID: 25752 RVA: 0x0022B538 File Offset: 0x00229738
		public Span<byte> GetSpineSkeletonDataPathBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06006499 RID: 25753 RVA: 0x0022B548 File Offset: 0x00229748
		public byte[] GetSpineSkeletonDataPathArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B99 RID: 2969
		// (get) Token: 0x0600649A RID: 25754 RVA: 0x0022B560 File Offset: 0x00229760
		public string BlueprintPath
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

		// Token: 0x0600649B RID: 25755 RVA: 0x0022B598 File Offset: 0x00229798
		public Span<byte> GetBlueprintPathBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600649C RID: 25756 RVA: 0x0022B5A8 File Offset: 0x002297A8
		public byte[] GetBlueprintPathArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B9A RID: 2970
		// (get) Token: 0x0600649D RID: 25757 RVA: 0x0022B5C0 File Offset: 0x002297C0
		public string ABpPath
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

		// Token: 0x0600649E RID: 25758 RVA: 0x0022B5F8 File Offset: 0x002297F8
		public Span<byte> GetABpPathBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600649F RID: 25759 RVA: 0x0022B608 File Offset: 0x00229808
		public byte[] GetABpPathArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B9B RID: 2971
		// (get) Token: 0x060064A0 RID: 25760 RVA: 0x0022B620 File Offset: 0x00229820
		public string MontageIdle
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

		// Token: 0x060064A1 RID: 25761 RVA: 0x0022B658 File Offset: 0x00229858
		public Span<byte> GetMontageIdleBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x060064A2 RID: 25762 RVA: 0x0022B668 File Offset: 0x00229868
		public byte[] GetMontageIdleArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B9C RID: 2972
		// (get) Token: 0x060064A3 RID: 25763 RVA: 0x0022B680 File Offset: 0x00229880
		public string MontageAttack
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

		// Token: 0x060064A4 RID: 25764 RVA: 0x0022B6B8 File Offset: 0x002298B8
		public Span<byte> GetMontageAttackBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x060064A5 RID: 25765 RVA: 0x0022B6C8 File Offset: 0x002298C8
		public byte[] GetMontageAttackArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B9D RID: 2973
		// (get) Token: 0x060064A6 RID: 25766 RVA: 0x0022B6E0 File Offset: 0x002298E0
		public string MontageAttackLoop
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

		// Token: 0x060064A7 RID: 25767 RVA: 0x0022B718 File Offset: 0x00229918
		public Span<byte> GetMontageAttackLoopBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x060064A8 RID: 25768 RVA: 0x0022B728 File Offset: 0x00229928
		public byte[] GetMontageAttackLoopArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B9E RID: 2974
		// (get) Token: 0x060064A9 RID: 25769 RVA: 0x0022B740 File Offset: 0x00229940
		public string MontageAttackEnd
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

		// Token: 0x060064AA RID: 25770 RVA: 0x0022B778 File Offset: 0x00229978
		public Span<byte> GetMontageAttackEndBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x060064AB RID: 25771 RVA: 0x0022B788 File Offset: 0x00229988
		public byte[] GetMontageAttackEndArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B9F RID: 2975
		// (get) Token: 0x060064AC RID: 25772 RVA: 0x0022B7A0 File Offset: 0x002299A0
		public string MontageSuccess
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060064AD RID: 25773 RVA: 0x0022B7D8 File Offset: 0x002299D8
		public Span<byte> GetMontageSuccessBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x060064AE RID: 25774 RVA: 0x0022B7E8 File Offset: 0x002299E8
		public byte[] GetMontageSuccessArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x17000BA0 RID: 2976
		// (get) Token: 0x060064AF RID: 25775 RVA: 0x0022B800 File Offset: 0x00229A00
		public string MontageFail
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

		// Token: 0x060064B0 RID: 25776 RVA: 0x0022B838 File Offset: 0x00229A38
		public Span<byte> GetMontageFailBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x060064B1 RID: 25777 RVA: 0x0022B848 File Offset: 0x00229A48
		public byte[] GetMontageFailArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x060064B2 RID: 25778 RVA: 0x0022B860 File Offset: 0x00229A60
		public int TrashTalkIdList(int j)
		{
			int num = this.__p.__offset(36);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000BA1 RID: 2977
		// (get) Token: 0x060064B3 RID: 25779 RVA: 0x0022B8A0 File Offset: 0x00229AA0
		public int TrashTalkIdListLength
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060064B4 RID: 25780 RVA: 0x0022B8CC File Offset: 0x00229ACC
		public Span<int> GetTrashTalkIdListBytes()
		{
			return this.__p.__vector_as_span<int>(36, 4);
		}

		// Token: 0x060064B5 RID: 25781 RVA: 0x0022B8DC File Offset: 0x00229ADC
		public int[] GetTrashTalkIdListArray()
		{
			return this.__p.__vector_as_array<int>(36) ?? Array.Empty<int>();
		}

		// Token: 0x17000BA2 RID: 2978
		// (get) Token: 0x060064B6 RID: 25782 RVA: 0x0022B8F4 File Offset: 0x00229AF4
		public string AudioAttackStart
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060064B7 RID: 25783 RVA: 0x0022B92C File Offset: 0x00229B2C
		public Span<byte> GetAudioAttackStartBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x060064B8 RID: 25784 RVA: 0x0022B93C File Offset: 0x00229B3C
		public byte[] GetAudioAttackStartArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x17000BA3 RID: 2979
		// (get) Token: 0x060064B9 RID: 25785 RVA: 0x0022B954 File Offset: 0x00229B54
		public string AudioRoundWin
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060064BA RID: 25786 RVA: 0x0022B98C File Offset: 0x00229B8C
		public Span<byte> GetAudioRoundWinBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x060064BB RID: 25787 RVA: 0x0022B99C File Offset: 0x00229B9C
		public byte[] GetAudioRoundWinArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x17000BA4 RID: 2980
		// (get) Token: 0x060064BC RID: 25788 RVA: 0x0022B9B4 File Offset: 0x00229BB4
		public string HitDAPath
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060064BD RID: 25789 RVA: 0x0022B9EC File Offset: 0x00229BEC
		public Span<byte> GetHitDAPathBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x060064BE RID: 25790 RVA: 0x0022B9FC File Offset: 0x00229BFC
		public byte[] GetHitDAPathArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x060064BF RID: 25791 RVA: 0x0022BA14 File Offset: 0x00229C14
		[NullableContext(1)]
		public int[] TrashTalkIdList()
		{
			return this.GetTrashTalkIdListArray();
		}

		// Token: 0x060064C0 RID: 25792 RVA: 0x0022BA1C File Offset: 0x00229C1C
		[NullableContext(1)]
		public IEnumerable<int> TrashTalkIdListIter()
		{
			DangoBrawlOpponent.<TrashTalkIdListIter>d__84 <TrashTalkIdListIter>d__ = new DangoBrawlOpponent.<TrashTalkIdListIter>d__84(-2);
			<TrashTalkIdListIter>d__.<>3__<>4__this = this;
			return <TrashTalkIdListIter>d__;
		}

		// Token: 0x040051D6 RID: 20950
		private Table __p;
	}
}
