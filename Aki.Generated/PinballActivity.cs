using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001004 RID: 4100
	public struct PinballActivity : IFlatbufferObject
	{
		// Token: 0x17002921 RID: 10529
		// (get) Token: 0x0600B3D3 RID: 46035 RVA: 0x002DB80D File Offset: 0x002D9A0D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B3D4 RID: 46036 RVA: 0x002DB81A File Offset: 0x002D9A1A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B3D5 RID: 46037 RVA: 0x002DB824 File Offset: 0x002D9A24
		public static PinballActivity GetRootAsPinballActivity(ByteBuffer _bb)
		{
			return PinballActivity.GetRootAsPinballActivity(_bb, default(PinballActivity));
		}

		// Token: 0x0600B3D6 RID: 46038 RVA: 0x002DB840 File Offset: 0x002D9A40
		public static PinballActivity GetRootAsPinballActivity(ByteBuffer _bb, PinballActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B3D7 RID: 46039 RVA: 0x002DB85D File Offset: 0x002D9A5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B3D8 RID: 46040 RVA: 0x002DB86C File Offset: 0x002D9A6C
		public PinballActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002922 RID: 10530
		// (get) Token: 0x0600B3D9 RID: 46041 RVA: 0x002DB87C File Offset: 0x002D9A7C
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

		// Token: 0x17002923 RID: 10531
		// (get) Token: 0x0600B3DA RID: 46042 RVA: 0x002DB8B8 File Offset: 0x002D9AB8
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

		// Token: 0x17002924 RID: 10532
		// (get) Token: 0x0600B3DB RID: 46043 RVA: 0x002DB8F4 File Offset: 0x002D9AF4
		public int ShopId
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

		// Token: 0x17002925 RID: 10533
		// (get) Token: 0x0600B3DC RID: 46044 RVA: 0x002DB930 File Offset: 0x002D9B30
		public int TitleTipId
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

		// Token: 0x17002926 RID: 10534
		// (get) Token: 0x0600B3DD RID: 46045 RVA: 0x002DB970 File Offset: 0x002D9B70
		public int RecommendTaskId
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

		// Token: 0x17002927 RID: 10535
		// (get) Token: 0x0600B3DE RID: 46046 RVA: 0x002DB9B0 File Offset: 0x002D9BB0
		public int DailyLevelFuncId
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

		// Token: 0x17002928 RID: 10536
		// (get) Token: 0x0600B3DF RID: 46047 RVA: 0x002DB9F0 File Offset: 0x002D9BF0
		public int RoleFuncId
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

		// Token: 0x17002929 RID: 10537
		// (get) Token: 0x0600B3E0 RID: 46048 RVA: 0x002DBA30 File Offset: 0x002D9C30
		public int ShopFuncId
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

		// Token: 0x1700292A RID: 10538
		// (get) Token: 0x0600B3E1 RID: 46049 RVA: 0x002DBA70 File Offset: 0x002D9C70
		public int DefaultDailyRandomId
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

		// Token: 0x1700292B RID: 10539
		// (get) Token: 0x0600B3E2 RID: 46050 RVA: 0x002DBAB0 File Offset: 0x002D9CB0
		public int ExpItemId
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

		// Token: 0x1700292C RID: 10540
		// (get) Token: 0x0600B3E3 RID: 46051 RVA: 0x002DBAF0 File Offset: 0x002D9CF0
		public int WeaponFragmentId
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

		// Token: 0x0600B3E4 RID: 46052 RVA: 0x002DBB30 File Offset: 0x002D9D30
		public int MainAttrShowList(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700292D RID: 10541
		// (get) Token: 0x0600B3E5 RID: 46053 RVA: 0x002DBB70 File Offset: 0x002D9D70
		public int MainAttrShowListLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600B3E6 RID: 46054 RVA: 0x002DBB9C File Offset: 0x002D9D9C
		public Span<int> GetMainAttrShowListBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x0600B3E7 RID: 46055 RVA: 0x002DBBAC File Offset: 0x002D9DAC
		public int[] GetMainAttrShowListArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x0600B3E8 RID: 46056 RVA: 0x002DBBC4 File Offset: 0x002D9DC4
		public int AttrShowList(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700292E RID: 10542
		// (get) Token: 0x0600B3E9 RID: 46057 RVA: 0x002DBC04 File Offset: 0x002D9E04
		public int AttrShowListLength
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

		// Token: 0x0600B3EA RID: 46058 RVA: 0x002DBC30 File Offset: 0x002D9E30
		public Span<int> GetAttrShowListBytes()
		{
			return this.__p.__vector_as_span<int>(28, 4);
		}

		// Token: 0x0600B3EB RID: 46059 RVA: 0x002DBC40 File Offset: 0x002D9E40
		public int[] GetAttrShowListArray()
		{
			return this.__p.__vector_as_array<int>(28) ?? Array.Empty<int>();
		}

		// Token: 0x0600B3EC RID: 46060 RVA: 0x002DBC58 File Offset: 0x002D9E58
		public int BattleAttrShowList(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700292F RID: 10543
		// (get) Token: 0x0600B3ED RID: 46061 RVA: 0x002DBC98 File Offset: 0x002D9E98
		public int BattleAttrShowListLength
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600B3EE RID: 46062 RVA: 0x002DBCC4 File Offset: 0x002D9EC4
		public Span<int> GetBattleAttrShowListBytes()
		{
			return this.__p.__vector_as_span<int>(30, 4);
		}

		// Token: 0x0600B3EF RID: 46063 RVA: 0x002DBCD4 File Offset: 0x002D9ED4
		public int[] GetBattleAttrShowListArray()
		{
			return this.__p.__vector_as_array<int>(30) ?? Array.Empty<int>();
		}

		// Token: 0x17002930 RID: 10544
		// (get) Token: 0x0600B3F0 RID: 46064 RVA: 0x002DBCEC File Offset: 0x002D9EEC
		public int ForceKickBallTime
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

		// Token: 0x0600B3F1 RID: 46065 RVA: 0x002DBD29 File Offset: 0x002D9F29
		[NullableContext(1)]
		public int[] AttrShowList()
		{
			return this.GetAttrShowListArray();
		}

		// Token: 0x0600B3F2 RID: 46066 RVA: 0x002DBD31 File Offset: 0x002D9F31
		[NullableContext(1)]
		public IEnumerable<int> AttrShowListIter()
		{
			PinballActivity.<AttrShowListIter>d__48 <AttrShowListIter>d__ = new PinballActivity.<AttrShowListIter>d__48(-2);
			<AttrShowListIter>d__.<>3__<>4__this = this;
			return <AttrShowListIter>d__;
		}

		// Token: 0x0600B3F3 RID: 46067 RVA: 0x002DBD46 File Offset: 0x002D9F46
		[NullableContext(1)]
		public int[] BattleAttrShowList()
		{
			return this.GetBattleAttrShowListArray();
		}

		// Token: 0x0600B3F4 RID: 46068 RVA: 0x002DBD4E File Offset: 0x002D9F4E
		[NullableContext(1)]
		public IEnumerable<int> BattleAttrShowListIter()
		{
			PinballActivity.<BattleAttrShowListIter>d__50 <BattleAttrShowListIter>d__ = new PinballActivity.<BattleAttrShowListIter>d__50(-2);
			<BattleAttrShowListIter>d__.<>3__<>4__this = this;
			return <BattleAttrShowListIter>d__;
		}

		// Token: 0x0600B3F5 RID: 46069 RVA: 0x002DBD63 File Offset: 0x002D9F63
		[NullableContext(1)]
		public int[] MainAttrShowList()
		{
			return this.GetMainAttrShowListArray();
		}

		// Token: 0x0600B3F6 RID: 46070 RVA: 0x002DBD6B File Offset: 0x002D9F6B
		[NullableContext(1)]
		public IEnumerable<int> MainAttrShowListIter()
		{
			PinballActivity.<MainAttrShowListIter>d__52 <MainAttrShowListIter>d__ = new PinballActivity.<MainAttrShowListIter>d__52(-2);
			<MainAttrShowListIter>d__.<>3__<>4__this = this;
			return <MainAttrShowListIter>d__;
		}

		// Token: 0x040055CD RID: 21965
		private Table __p;
	}
}
