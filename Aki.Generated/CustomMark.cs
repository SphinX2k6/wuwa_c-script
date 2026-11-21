using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C8F RID: 3215
	public struct CustomMark : IFlatbufferObject
	{
		// Token: 0x17000A25 RID: 2597
		// (get) Token: 0x06006073 RID: 24691 RVA: 0x00222284 File Offset: 0x00220484
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006074 RID: 24692 RVA: 0x00222291 File Offset: 0x00220491
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006075 RID: 24693 RVA: 0x00222298 File Offset: 0x00220498
		public static CustomMark GetRootAsCustomMark(ByteBuffer _bb)
		{
			return CustomMark.GetRootAsCustomMark(_bb, default(CustomMark));
		}

		// Token: 0x06006076 RID: 24694 RVA: 0x002222B4 File Offset: 0x002204B4
		public static CustomMark GetRootAsCustomMark(ByteBuffer _bb, CustomMark obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006077 RID: 24695 RVA: 0x002222D1 File Offset: 0x002204D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006078 RID: 24696 RVA: 0x002222E0 File Offset: 0x002204E0
		public CustomMark __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000A26 RID: 2598
		// (get) Token: 0x06006079 RID: 24697 RVA: 0x002222F0 File Offset: 0x002204F0
		public int MarkId
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

		// Token: 0x17000A27 RID: 2599
		// (get) Token: 0x0600607A RID: 24698 RVA: 0x0022232C File Offset: 0x0022052C
		public string MarkPic
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

		// Token: 0x0600607B RID: 24699 RVA: 0x00222363 File Offset: 0x00220563
		public Span<byte> GetMarkPicBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600607C RID: 24700 RVA: 0x00222372 File Offset: 0x00220572
		public byte[] GetMarkPicArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0600607D RID: 24701 RVA: 0x0022238C File Offset: 0x0022058C
		public int ShowRange(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A28 RID: 2600
		// (get) Token: 0x0600607E RID: 24702 RVA: 0x002223CC File Offset: 0x002205CC
		public int ShowRangeLength
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

		// Token: 0x0600607F RID: 24703 RVA: 0x002223F7 File Offset: 0x002205F7
		public Span<int> GetShowRangeBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06006080 RID: 24704 RVA: 0x00222406 File Offset: 0x00220606
		public int[] GetShowRangeArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17000A29 RID: 2601
		// (get) Token: 0x06006081 RID: 24705 RVA: 0x00222420 File Offset: 0x00220620
		public int ShowPriority
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

		// Token: 0x17000A2A RID: 2602
		// (get) Token: 0x06006082 RID: 24706 RVA: 0x00222460 File Offset: 0x00220660
		public float Scale
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000A2B RID: 2603
		// (get) Token: 0x06006083 RID: 24707 RVA: 0x002224A4 File Offset: 0x002206A4
		public int TrackHudEnable
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

		// Token: 0x17000A2C RID: 2604
		// (get) Token: 0x06006084 RID: 24708 RVA: 0x002224E4 File Offset: 0x002206E4
		public float TrackAutoCancelDistance
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return -1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006085 RID: 24709 RVA: 0x00222525 File Offset: 0x00220725
		[NullableContext(1)]
		public int[] ShowRange()
		{
			return this.GetShowRangeArray();
		}

		// Token: 0x06006086 RID: 24710 RVA: 0x0022252D File Offset: 0x0022072D
		[NullableContext(1)]
		public IEnumerable<int> ShowRangeIter()
		{
			CustomMark.<ShowRangeIter>d__28 <ShowRangeIter>d__ = new CustomMark.<ShowRangeIter>d__28(-2);
			<ShowRangeIter>d__.<>3__<>4__this = this;
			return <ShowRangeIter>d__;
		}

		// Token: 0x040051B2 RID: 20914
		private Table __p;
	}
}
