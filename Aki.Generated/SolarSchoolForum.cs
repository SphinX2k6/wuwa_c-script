using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011E7 RID: 4583
	public struct SolarSchoolForum : IFlatbufferObject
	{
		// Token: 0x17003983 RID: 14723
		// (get) Token: 0x0600E145 RID: 57669 RVA: 0x003409D1 File Offset: 0x0033EBD1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E146 RID: 57670 RVA: 0x003409DE File Offset: 0x0033EBDE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E147 RID: 57671 RVA: 0x003409E8 File Offset: 0x0033EBE8
		public static SolarSchoolForum GetRootAsSolarSchoolForum(ByteBuffer _bb)
		{
			return SolarSchoolForum.GetRootAsSolarSchoolForum(_bb, default(SolarSchoolForum));
		}

		// Token: 0x0600E148 RID: 57672 RVA: 0x00340A04 File Offset: 0x0033EC04
		public static SolarSchoolForum GetRootAsSolarSchoolForum(ByteBuffer _bb, SolarSchoolForum obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E149 RID: 57673 RVA: 0x00340A21 File Offset: 0x0033EC21
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E14A RID: 57674 RVA: 0x00340A30 File Offset: 0x0033EC30
		public SolarSchoolForum __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003984 RID: 14724
		// (get) Token: 0x0600E14B RID: 57675 RVA: 0x00340A40 File Offset: 0x0033EC40
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

		// Token: 0x17003985 RID: 14725
		// (get) Token: 0x0600E14C RID: 57676 RVA: 0x00340A7C File Offset: 0x0033EC7C
		public string Title
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

		// Token: 0x0600E14D RID: 57677 RVA: 0x00340AB3 File Offset: 0x0033ECB3
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600E14E RID: 57678 RVA: 0x00340AC2 File Offset: 0x0033ECC2
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0600E14F RID: 57679 RVA: 0x00340ADC File Offset: 0x0033ECDC
		public int PostList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003986 RID: 14726
		// (get) Token: 0x0600E150 RID: 57680 RVA: 0x00340B1C File Offset: 0x0033ED1C
		public int PostListLength
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

		// Token: 0x0600E151 RID: 57681 RVA: 0x00340B47 File Offset: 0x0033ED47
		public Span<int> GetPostListBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600E152 RID: 57682 RVA: 0x00340B56 File Offset: 0x0033ED56
		public int[] GetPostListArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17003987 RID: 14727
		// (get) Token: 0x0600E153 RID: 57683 RVA: 0x00340B70 File Offset: 0x0033ED70
		public int LikeReward
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

		// Token: 0x0600E154 RID: 57684 RVA: 0x00340BAD File Offset: 0x0033EDAD
		[NullableContext(1)]
		public int[] PostList()
		{
			return this.GetPostListArray();
		}

		// Token: 0x0600E155 RID: 57685 RVA: 0x00340BB5 File Offset: 0x0033EDB5
		[NullableContext(1)]
		public IEnumerable<int> PostListIter()
		{
			SolarSchoolForum.<PostListIter>d__22 <PostListIter>d__ = new SolarSchoolForum.<PostListIter>d__22(-2);
			<PostListIter>d__.<>3__<>4__this = this;
			return <PostListIter>d__;
		}

		// Token: 0x04005824 RID: 22564
		private Table __p;
	}
}
