using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C8F RID: 3215
	public struct FlagArea : IFlatbufferObject
	{
		// Token: 0x170011EE RID: 4590
		// (get) Token: 0x060070D2 RID: 28882 RVA: 0x00234C72 File Offset: 0x00232E72
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060070D3 RID: 28883 RVA: 0x00234C7F File Offset: 0x00232E7F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060070D4 RID: 28884 RVA: 0x00234C88 File Offset: 0x00232E88
		public static FlagArea GetRootAsFlagArea(ByteBuffer _bb)
		{
			return FlagArea.GetRootAsFlagArea(_bb, default(FlagArea));
		}

		// Token: 0x060070D5 RID: 28885 RVA: 0x00234CA4 File Offset: 0x00232EA4
		public static FlagArea GetRootAsFlagArea(ByteBuffer _bb, FlagArea obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060070D6 RID: 28886 RVA: 0x00234CC1 File Offset: 0x00232EC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060070D7 RID: 28887 RVA: 0x00234CD0 File Offset: 0x00232ED0
		public FlagArea __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170011EF RID: 4591
		// (get) Token: 0x060070D8 RID: 28888 RVA: 0x00234CE0 File Offset: 0x00232EE0
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

		// Token: 0x170011F0 RID: 4592
		// (get) Token: 0x060070D9 RID: 28889 RVA: 0x00234D1C File Offset: 0x00232F1C
		public int FlagEntityId
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

		// Token: 0x170011F1 RID: 4593
		// (get) Token: 0x060070DA RID: 28890 RVA: 0x00234D58 File Offset: 0x00232F58
		public int FlagAreaId
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

		// Token: 0x170011F2 RID: 4594
		// (get) Token: 0x060070DB RID: 28891 RVA: 0x00234D94 File Offset: 0x00232F94
		public int MapId
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

		// Token: 0x170011F3 RID: 4595
		// (get) Token: 0x060070DC RID: 28892 RVA: 0x00234DD4 File Offset: 0x00232FD4
		public int FlagType
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

		// Token: 0x170011F4 RID: 4596
		// (get) Token: 0x060070DD RID: 28893 RVA: 0x00234E14 File Offset: 0x00233014
		public int MarkId
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

		// Token: 0x060070DE RID: 28894 RVA: 0x00234E54 File Offset: 0x00233054
		public int TreasureBoxEntitys(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170011F5 RID: 4597
		// (get) Token: 0x060070DF RID: 28895 RVA: 0x00234E94 File Offset: 0x00233094
		public int TreasureBoxEntitysLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060070E0 RID: 28896 RVA: 0x00234EC0 File Offset: 0x002330C0
		public Span<int> GetTreasureBoxEntitysBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x060070E1 RID: 28897 RVA: 0x00234ED0 File Offset: 0x002330D0
		public int[] GetTreasureBoxEntitysArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x170011F6 RID: 4598
		// (get) Token: 0x060070E2 RID: 28898 RVA: 0x00234EE8 File Offset: 0x002330E8
		public string FlagName
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

		// Token: 0x060070E3 RID: 28899 RVA: 0x00234F20 File Offset: 0x00233120
		public Span<byte> GetFlagNameBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x060070E4 RID: 28900 RVA: 0x00234F30 File Offset: 0x00233130
		public byte[] GetFlagNameArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x060070E5 RID: 28901 RVA: 0x00234F48 File Offset: 0x00233148
		public int FlagPlotList(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170011F7 RID: 4599
		// (get) Token: 0x060070E6 RID: 28902 RVA: 0x00234F88 File Offset: 0x00233188
		public int FlagPlotListLength
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

		// Token: 0x060070E7 RID: 28903 RVA: 0x00234FB4 File Offset: 0x002331B4
		public Span<int> GetFlagPlotListBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x060070E8 RID: 28904 RVA: 0x00234FC4 File Offset: 0x002331C4
		public int[] GetFlagPlotListArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x170011F8 RID: 4600
		// (get) Token: 0x060070E9 RID: 28905 RVA: 0x00234FDC File Offset: 0x002331DC
		public int FlagPosPlotId
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170011F9 RID: 4601
		// (get) Token: 0x060070EA RID: 28906 RVA: 0x0023501C File Offset: 0x0023321C
		public int MaxMonsterLv
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170011FA RID: 4602
		// (get) Token: 0x060070EB RID: 28907 RVA: 0x0023505C File Offset: 0x0023325C
		public string MonsterIconPath
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

		// Token: 0x060070EC RID: 28908 RVA: 0x00235094 File Offset: 0x00233294
		public Span<byte> GetMonsterIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x060070ED RID: 28909 RVA: 0x002350A4 File Offset: 0x002332A4
		public byte[] GetMonsterIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x170011FB RID: 4603
		// (get) Token: 0x060070EE RID: 28910 RVA: 0x002350BC File Offset: 0x002332BC
		public string MonsterDesc
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

		// Token: 0x060070EF RID: 28911 RVA: 0x002350F4 File Offset: 0x002332F4
		public Span<byte> GetMonsterDescBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x060070F0 RID: 28912 RVA: 0x00235104 File Offset: 0x00233304
		public byte[] GetMonsterDescArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x170011FC RID: 4604
		// (get) Token: 0x060070F1 RID: 28913 RVA: 0x0023511C File Offset: 0x0023331C
		public int BoxRewardId
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

		// Token: 0x170011FD RID: 4605
		// (get) Token: 0x060070F2 RID: 28914 RVA: 0x0023515C File Offset: 0x0023335C
		public string Index
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

		// Token: 0x060070F3 RID: 28915 RVA: 0x00235194 File Offset: 0x00233394
		public Span<byte> GetIndexBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x060070F4 RID: 28916 RVA: 0x002351A4 File Offset: 0x002333A4
		public byte[] GetIndexArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x060070F5 RID: 28917 RVA: 0x002351BC File Offset: 0x002333BC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用FlagPlotListIter()或GetFlagPlotListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] FlagPlotList()
		{
			FlagArea flagArea = this;
			return flagArea.GetFlagPlotListArray() ?? Array.Empty<int>();
		}

		// Token: 0x060070F6 RID: 28918 RVA: 0x002351E0 File Offset: 0x002333E0
		[NullableContext(1)]
		public readonly IEnumerable<int> FlagPlotListIter()
		{
			FlagArea.<FlagPlotListIter>d__53 <FlagPlotListIter>d__ = new FlagArea.<FlagPlotListIter>d__53(-2);
			<FlagPlotListIter>d__.<>3__<>4__this = this;
			return <FlagPlotListIter>d__;
		}

		// Token: 0x060070F7 RID: 28919 RVA: 0x002351F8 File Offset: 0x002333F8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TreasureBoxEntitysIter()或GetTreasureBoxEntitysBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] TreasureBoxEntitys()
		{
			FlagArea flagArea = this;
			return flagArea.GetTreasureBoxEntitysArray() ?? Array.Empty<int>();
		}

		// Token: 0x060070F8 RID: 28920 RVA: 0x0023521C File Offset: 0x0023341C
		[NullableContext(1)]
		public readonly IEnumerable<int> TreasureBoxEntitysIter()
		{
			FlagArea.<TreasureBoxEntitysIter>d__55 <TreasureBoxEntitysIter>d__ = new FlagArea.<TreasureBoxEntitysIter>d__55(-2);
			<TreasureBoxEntitysIter>d__.<>3__<>4__this = this;
			return <TreasureBoxEntitysIter>d__;
		}

		// Token: 0x04004CE6 RID: 19686
		private Table __p;
	}
}
