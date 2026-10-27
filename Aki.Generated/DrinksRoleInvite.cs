using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C08 RID: 3080
	public struct DrinksRoleInvite : IFlatbufferObject
	{
		// Token: 0x17000D7C RID: 3452
		// (get) Token: 0x060064C3 RID: 25795 RVA: 0x002197C9 File Offset: 0x002179C9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060064C4 RID: 25796 RVA: 0x002197D6 File Offset: 0x002179D6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060064C5 RID: 25797 RVA: 0x002197E0 File Offset: 0x002179E0
		public static DrinksRoleInvite GetRootAsDrinksRoleInvite(ByteBuffer _bb)
		{
			return DrinksRoleInvite.GetRootAsDrinksRoleInvite(_bb, default(DrinksRoleInvite));
		}

		// Token: 0x060064C6 RID: 25798 RVA: 0x002197FC File Offset: 0x002179FC
		public static DrinksRoleInvite GetRootAsDrinksRoleInvite(ByteBuffer _bb, DrinksRoleInvite obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060064C7 RID: 25799 RVA: 0x00219819 File Offset: 0x00217A19
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060064C8 RID: 25800 RVA: 0x00219828 File Offset: 0x00217A28
		public DrinksRoleInvite __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000D7D RID: 3453
		// (get) Token: 0x060064C9 RID: 25801 RVA: 0x00219838 File Offset: 0x00217A38
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

		// Token: 0x17000D7E RID: 3454
		// (get) Token: 0x060064CA RID: 25802 RVA: 0x00219874 File Offset: 0x00217A74
		public int RoleId
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

		// Token: 0x17000D7F RID: 3455
		// (get) Token: 0x060064CB RID: 25803 RVA: 0x002198B0 File Offset: 0x00217AB0
		public int EntityId
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

		// Token: 0x17000D80 RID: 3456
		// (get) Token: 0x060064CC RID: 25804 RVA: 0x002198EC File Offset: 0x00217AEC
		public int UnlockLevelConfigId
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

		// Token: 0x17000D81 RID: 3457
		// (get) Token: 0x060064CD RID: 25805 RVA: 0x0021992C File Offset: 0x00217B2C
		public string LockTxt
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

		// Token: 0x060064CE RID: 25806 RVA: 0x00219964 File Offset: 0x00217B64
		public Span<byte> GetLockTxtBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060064CF RID: 25807 RVA: 0x00219974 File Offset: 0x00217B74
		public byte[] GetLockTxtArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000D82 RID: 3458
		// (get) Token: 0x060064D0 RID: 25808 RVA: 0x0021998C File Offset: 0x00217B8C
		public int FirstAward
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

		// Token: 0x17000D83 RID: 3459
		// (get) Token: 0x060064D1 RID: 25809 RVA: 0x002199CC File Offset: 0x00217BCC
		public int DrinksFavor
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

		// Token: 0x060064D2 RID: 25810 RVA: 0x00219A0C File Offset: 0x00217C0C
		public int DrinksFavorBatching(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000D84 RID: 3460
		// (get) Token: 0x060064D3 RID: 25811 RVA: 0x00219A4C File Offset: 0x00217C4C
		public int DrinksFavorBatchingLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060064D4 RID: 25812 RVA: 0x00219A78 File Offset: 0x00217C78
		public Span<int> GetDrinksFavorBatchingBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x060064D5 RID: 25813 RVA: 0x00219A88 File Offset: 0x00217C88
		public int[] GetDrinksFavorBatchingArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x17000D85 RID: 3461
		// (get) Token: 0x060064D6 RID: 25814 RVA: 0x00219AA0 File Offset: 0x00217CA0
		public int DrinksFavorOrnament
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

		// Token: 0x17000D86 RID: 3462
		// (get) Token: 0x060064D7 RID: 25815 RVA: 0x00219AE0 File Offset: 0x00217CE0
		public string DrinksLock
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

		// Token: 0x060064D8 RID: 25816 RVA: 0x00219B18 File Offset: 0x00217D18
		public Span<byte> GetDrinksLockBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x060064D9 RID: 25817 RVA: 0x00219B28 File Offset: 0x00217D28
		public byte[] GetDrinksLockArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17000D87 RID: 3463
		// (get) Token: 0x060064DA RID: 25818 RVA: 0x00219B40 File Offset: 0x00217D40
		public string DrinksUnlock
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

		// Token: 0x060064DB RID: 25819 RVA: 0x00219B78 File Offset: 0x00217D78
		public Span<byte> GetDrinksUnlockBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x060064DC RID: 25820 RVA: 0x00219B88 File Offset: 0x00217D88
		public byte[] GetDrinksUnlockArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17000D88 RID: 3464
		// (get) Token: 0x060064DD RID: 25821 RVA: 0x00219BA0 File Offset: 0x00217DA0
		public int CameraId
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

		// Token: 0x17000D89 RID: 3465
		// (get) Token: 0x060064DE RID: 25822 RVA: 0x00219BE0 File Offset: 0x00217DE0
		public string DrinkSequence
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

		// Token: 0x060064DF RID: 25823 RVA: 0x00219C18 File Offset: 0x00217E18
		public Span<byte> GetDrinkSequenceBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x060064E0 RID: 25824 RVA: 0x00219C28 File Offset: 0x00217E28
		public byte[] GetDrinkSequenceArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17000D8A RID: 3466
		// (get) Token: 0x060064E1 RID: 25825 RVA: 0x00219C40 File Offset: 0x00217E40
		public string AfterTalk
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

		// Token: 0x060064E2 RID: 25826 RVA: 0x00219C78 File Offset: 0x00217E78
		public Span<byte> GetAfterTalkBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x060064E3 RID: 25827 RVA: 0x00219C88 File Offset: 0x00217E88
		public byte[] GetAfterTalkArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x060064E4 RID: 25828 RVA: 0x00219CA0 File Offset: 0x00217EA0
		public int AfterTalkStateId(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000D8B RID: 3467
		// (get) Token: 0x060064E5 RID: 25829 RVA: 0x00219CE0 File Offset: 0x00217EE0
		public int AfterTalkStateIdLength
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060064E6 RID: 25830 RVA: 0x00219D0C File Offset: 0x00217F0C
		public Span<int> GetAfterTalkStateIdBytes()
		{
			return this.__p.__vector_as_span<int>(32, 4);
		}

		// Token: 0x060064E7 RID: 25831 RVA: 0x00219D1C File Offset: 0x00217F1C
		public int[] GetAfterTalkStateIdArray()
		{
			return this.__p.__vector_as_array<int>(32) ?? Array.Empty<int>();
		}

		// Token: 0x17000D8C RID: 3468
		// (get) Token: 0x060064E8 RID: 25832 RVA: 0x00219D34 File Offset: 0x00217F34
		public string CupMesh
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

		// Token: 0x060064E9 RID: 25833 RVA: 0x00219D6C File Offset: 0x00217F6C
		public Span<byte> GetCupMeshBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x060064EA RID: 25834 RVA: 0x00219D7C File Offset: 0x00217F7C
		public byte[] GetCupMeshArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x17000D8D RID: 3469
		// (get) Token: 0x060064EB RID: 25835 RVA: 0x00219D94 File Offset: 0x00217F94
		public int CupZOffset
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000D8E RID: 3470
		// (get) Token: 0x060064EC RID: 25836 RVA: 0x00219DD4 File Offset: 0x00217FD4
		public string OrnamentCamera
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

		// Token: 0x060064ED RID: 25837 RVA: 0x00219E0C File Offset: 0x0021800C
		public Span<byte> GetOrnamentCameraBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x060064EE RID: 25838 RVA: 0x00219E1C File Offset: 0x0021801C
		public byte[] GetOrnamentCameraArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x060064EF RID: 25839 RVA: 0x00219E34 File Offset: 0x00218034
		public int FlowRotation(int j)
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000D8F RID: 3471
		// (get) Token: 0x060064F0 RID: 25840 RVA: 0x00219E74 File Offset: 0x00218074
		public int FlowRotationLength
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060064F1 RID: 25841 RVA: 0x00219EA0 File Offset: 0x002180A0
		public Span<int> GetFlowRotationBytes()
		{
			return this.__p.__vector_as_span<int>(40, 4);
		}

		// Token: 0x060064F2 RID: 25842 RVA: 0x00219EB0 File Offset: 0x002180B0
		public int[] GetFlowRotationArray()
		{
			return this.__p.__vector_as_array<int>(40) ?? Array.Empty<int>();
		}

		// Token: 0x060064F3 RID: 25843 RVA: 0x00219EC8 File Offset: 0x002180C8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AfterTalkStateIdIter()或GetAfterTalkStateIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] AfterTalkStateId()
		{
			DrinksRoleInvite drinksRoleInvite = this;
			return drinksRoleInvite.GetAfterTalkStateIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x060064F4 RID: 25844 RVA: 0x00219EEC File Offset: 0x002180EC
		[NullableContext(1)]
		public readonly IEnumerable<int> AfterTalkStateIdIter()
		{
			DrinksRoleInvite.<AfterTalkStateIdIter>d__70 <AfterTalkStateIdIter>d__ = new DrinksRoleInvite.<AfterTalkStateIdIter>d__70(-2);
			<AfterTalkStateIdIter>d__.<>3__<>4__this = this;
			return <AfterTalkStateIdIter>d__;
		}

		// Token: 0x060064F5 RID: 25845 RVA: 0x00219F04 File Offset: 0x00218104
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DrinksFavorBatchingIter()或GetDrinksFavorBatchingBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] DrinksFavorBatching()
		{
			DrinksRoleInvite drinksRoleInvite = this;
			return drinksRoleInvite.GetDrinksFavorBatchingArray() ?? Array.Empty<int>();
		}

		// Token: 0x060064F6 RID: 25846 RVA: 0x00219F28 File Offset: 0x00218128
		[NullableContext(1)]
		public readonly IEnumerable<int> DrinksFavorBatchingIter()
		{
			DrinksRoleInvite.<DrinksFavorBatchingIter>d__72 <DrinksFavorBatchingIter>d__ = new DrinksRoleInvite.<DrinksFavorBatchingIter>d__72(-2);
			<DrinksFavorBatchingIter>d__.<>3__<>4__this = this;
			return <DrinksFavorBatchingIter>d__;
		}

		// Token: 0x060064F7 RID: 25847 RVA: 0x00219F40 File Offset: 0x00218140
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用FlowRotationIter()或GetFlowRotationBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] FlowRotation()
		{
			DrinksRoleInvite drinksRoleInvite = this;
			return drinksRoleInvite.GetFlowRotationArray() ?? Array.Empty<int>();
		}

		// Token: 0x060064F8 RID: 25848 RVA: 0x00219F64 File Offset: 0x00218164
		[NullableContext(1)]
		public readonly IEnumerable<int> FlowRotationIter()
		{
			DrinksRoleInvite.<FlowRotationIter>d__74 <FlowRotationIter>d__ = new DrinksRoleInvite.<FlowRotationIter>d__74(-2);
			<FlowRotationIter>d__.<>3__<>4__this = this;
			return <FlowRotationIter>d__;
		}

		// Token: 0x04004C44 RID: 19524
		private Table __p;
	}
}
