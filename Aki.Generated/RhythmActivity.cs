using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010A7 RID: 4263
	public struct RhythmActivity : IFlatbufferObject
	{
		// Token: 0x17002E93 RID: 11923
		// (get) Token: 0x0600C266 RID: 49766 RVA: 0x002FAD60 File Offset: 0x002F8F60
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C267 RID: 49767 RVA: 0x002FAD6D File Offset: 0x002F8F6D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C268 RID: 49768 RVA: 0x002FAD74 File Offset: 0x002F8F74
		public static RhythmActivity GetRootAsRhythmActivity(ByteBuffer _bb)
		{
			return RhythmActivity.GetRootAsRhythmActivity(_bb, default(RhythmActivity));
		}

		// Token: 0x0600C269 RID: 49769 RVA: 0x002FAD90 File Offset: 0x002F8F90
		public static RhythmActivity GetRootAsRhythmActivity(ByteBuffer _bb, RhythmActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C26A RID: 49770 RVA: 0x002FADAD File Offset: 0x002F8FAD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C26B RID: 49771 RVA: 0x002FADBC File Offset: 0x002F8FBC
		public RhythmActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002E94 RID: 11924
		// (get) Token: 0x0600C26C RID: 49772 RVA: 0x002FADCC File Offset: 0x002F8FCC
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

		// Token: 0x17002E95 RID: 11925
		// (get) Token: 0x0600C26D RID: 49773 RVA: 0x002FAE08 File Offset: 0x002F9008
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

		// Token: 0x0600C26E RID: 49774 RVA: 0x002FAE44 File Offset: 0x002F9044
		public int Combo(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002E96 RID: 11926
		// (get) Token: 0x0600C26F RID: 49775 RVA: 0x002FAE84 File Offset: 0x002F9084
		public int ComboLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600C270 RID: 49776 RVA: 0x002FAEAF File Offset: 0x002F90AF
		public Span<int> GetComboBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600C271 RID: 49777 RVA: 0x002FAEBE File Offset: 0x002F90BE
		public int[] GetComboArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17002E97 RID: 11927
		// (get) Token: 0x0600C272 RID: 49778 RVA: 0x002FAED8 File Offset: 0x002F90D8
		public int FeverLimit
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

		// Token: 0x17002E98 RID: 11928
		// (get) Token: 0x0600C273 RID: 49779 RVA: 0x002FAF18 File Offset: 0x002F9118
		public int FeverCost
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

		// Token: 0x17002E99 RID: 11929
		// (get) Token: 0x0600C274 RID: 49780 RVA: 0x002FAF58 File Offset: 0x002F9158
		public int NoteScore
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

		// Token: 0x0600C275 RID: 49781 RVA: 0x002FAF98 File Offset: 0x002F9198
		public int SettleRatio(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002E9A RID: 11930
		// (get) Token: 0x0600C276 RID: 49782 RVA: 0x002FAFD8 File Offset: 0x002F91D8
		public int SettleRatioLength
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

		// Token: 0x0600C277 RID: 49783 RVA: 0x002FB004 File Offset: 0x002F9204
		public Span<int> GetSettleRatioBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0600C278 RID: 49784 RVA: 0x002FB014 File Offset: 0x002F9214
		public int[] GetSettleRatioArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x17002E9B RID: 11931
		// (get) Token: 0x0600C279 RID: 49785 RVA: 0x002FB02C File Offset: 0x002F922C
		public int RecommendQuestId
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

		// Token: 0x17002E9C RID: 11932
		// (get) Token: 0x0600C27A RID: 49786 RVA: 0x002FB06C File Offset: 0x002F926C
		public string RecommendQuestTips
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

		// Token: 0x0600C27B RID: 49787 RVA: 0x002FB0A4 File Offset: 0x002F92A4
		public Span<byte> GetRecommendQuestTipsBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600C27C RID: 49788 RVA: 0x002FB0B4 File Offset: 0x002F92B4
		public byte[] GetRecommendQuestTipsArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x0600C27D RID: 49789 RVA: 0x002FB0CC File Offset: 0x002F92CC
		[NullableContext(1)]
		public int[] Combo()
		{
			return this.GetComboArray();
		}

		// Token: 0x0600C27E RID: 49790 RVA: 0x002FB0D4 File Offset: 0x002F92D4
		[NullableContext(1)]
		public IEnumerable<int> ComboIter()
		{
			RhythmActivity.<ComboIter>d__35 <ComboIter>d__ = new RhythmActivity.<ComboIter>d__35(-2);
			<ComboIter>d__.<>3__<>4__this = this;
			return <ComboIter>d__;
		}

		// Token: 0x0600C27F RID: 49791 RVA: 0x002FB0E9 File Offset: 0x002F92E9
		[NullableContext(1)]
		public int[] SettleRatio()
		{
			return this.GetSettleRatioArray();
		}

		// Token: 0x0600C280 RID: 49792 RVA: 0x002FB0F1 File Offset: 0x002F92F1
		[NullableContext(1)]
		public IEnumerable<int> SettleRatioIter()
		{
			RhythmActivity.<SettleRatioIter>d__37 <SettleRatioIter>d__ = new RhythmActivity.<SettleRatioIter>d__37(-2);
			<SettleRatioIter>d__.<>3__<>4__this = this;
			return <SettleRatioIter>d__;
		}

		// Token: 0x04005681 RID: 22145
		private Table __p;
	}
}
