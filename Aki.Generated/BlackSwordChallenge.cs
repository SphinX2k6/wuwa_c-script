using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C19 RID: 3097
	public struct BlackSwordChallenge : IFlatbufferObject
	{
		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06005371 RID: 21361 RVA: 0x00204BFD File Offset: 0x00202DFD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005372 RID: 21362 RVA: 0x00204C0A File Offset: 0x00202E0A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005373 RID: 21363 RVA: 0x00204C14 File Offset: 0x00202E14
		public static BlackSwordChallenge GetRootAsBlackSwordChallenge(ByteBuffer _bb)
		{
			return BlackSwordChallenge.GetRootAsBlackSwordChallenge(_bb, default(BlackSwordChallenge));
		}

		// Token: 0x06005374 RID: 21364 RVA: 0x00204C30 File Offset: 0x00202E30
		public static BlackSwordChallenge GetRootAsBlackSwordChallenge(ByteBuffer _bb, BlackSwordChallenge obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005375 RID: 21365 RVA: 0x00204C4D File Offset: 0x00202E4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005376 RID: 21366 RVA: 0x00204C5C File Offset: 0x00202E5C
		public BlackSwordChallenge __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06005377 RID: 21367 RVA: 0x00204C6C File Offset: 0x00202E6C
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

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06005378 RID: 21368 RVA: 0x00204CA8 File Offset: 0x00202EA8
		public int RelativeDungeonId
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

		// Token: 0x06005379 RID: 21369 RVA: 0x00204CE4 File Offset: 0x00202EE4
		public int GroupId(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x0600537A RID: 21370 RVA: 0x00204D24 File Offset: 0x00202F24
		public int GroupIdLength
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

		// Token: 0x0600537B RID: 21371 RVA: 0x00204D4F File Offset: 0x00202F4F
		public Span<int> GetGroupIdBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600537C RID: 21372 RVA: 0x00204D5E File Offset: 0x00202F5E
		public int[] GetGroupIdArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x0600537D RID: 21373 RVA: 0x00204D78 File Offset: 0x00202F78
		public string Title
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600537E RID: 21374 RVA: 0x00204DB0 File Offset: 0x00202FB0
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600537F RID: 21375 RVA: 0x00204DC0 File Offset: 0x00202FC0
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x06005380 RID: 21376 RVA: 0x00204DD8 File Offset: 0x00202FD8
		public string Icon
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

		// Token: 0x06005381 RID: 21377 RVA: 0x00204E10 File Offset: 0x00203010
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06005382 RID: 21378 RVA: 0x00204E20 File Offset: 0x00203020
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x06005383 RID: 21379 RVA: 0x00204E38 File Offset: 0x00203038
		[NullableContext(1)]
		public int[] GroupId()
		{
			return this.GetGroupIdArray();
		}

		// Token: 0x06005384 RID: 21380 RVA: 0x00204E40 File Offset: 0x00203040
		[NullableContext(1)]
		public IEnumerable<int> GroupIdIter()
		{
			BlackSwordChallenge.<GroupIdIter>d__26 <GroupIdIter>d__ = new BlackSwordChallenge.<GroupIdIter>d__26(-2);
			<GroupIdIter>d__.<>3__<>4__this = this;
			return <GroupIdIter>d__;
		}

		// Token: 0x04005114 RID: 20756
		private Table __p;
	}
}
