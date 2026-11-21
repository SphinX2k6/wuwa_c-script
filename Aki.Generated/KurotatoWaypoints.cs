using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E9D RID: 3741
	public struct KurotatoWaypoints : IFlatbufferObject
	{
		// Token: 0x17001CB0 RID: 7344
		// (get) Token: 0x06009233 RID: 37427 RVA: 0x00291F72 File Offset: 0x00290172
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009234 RID: 37428 RVA: 0x00291F7F File Offset: 0x0029017F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009235 RID: 37429 RVA: 0x00291F88 File Offset: 0x00290188
		public static KurotatoWaypoints GetRootAsKurotatoWaypoints(ByteBuffer _bb)
		{
			return KurotatoWaypoints.GetRootAsKurotatoWaypoints(_bb, default(KurotatoWaypoints));
		}

		// Token: 0x06009236 RID: 37430 RVA: 0x00291FA4 File Offset: 0x002901A4
		public static KurotatoWaypoints GetRootAsKurotatoWaypoints(ByteBuffer _bb, KurotatoWaypoints obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009237 RID: 37431 RVA: 0x00291FC1 File Offset: 0x002901C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009238 RID: 37432 RVA: 0x00291FD0 File Offset: 0x002901D0
		public KurotatoWaypoints __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001CB1 RID: 7345
		// (get) Token: 0x06009239 RID: 37433 RVA: 0x00291FE0 File Offset: 0x002901E0
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

		// Token: 0x0600923A RID: 37434 RVA: 0x0029201C File Offset: 0x0029021C
		public int WaypointsEntityId(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001CB2 RID: 7346
		// (get) Token: 0x0600923B RID: 37435 RVA: 0x0029205C File Offset: 0x0029025C
		public int WaypointsEntityIdLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600923C RID: 37436 RVA: 0x00292087 File Offset: 0x00290287
		public Span<int> GetWaypointsEntityIdBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600923D RID: 37437 RVA: 0x00292096 File Offset: 0x00290296
		public int[] GetWaypointsEntityIdArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x0600923E RID: 37438 RVA: 0x002920AD File Offset: 0x002902AD
		[NullableContext(1)]
		public int[] WaypointsEntityId()
		{
			return this.GetWaypointsEntityIdArray();
		}

		// Token: 0x0600923F RID: 37439 RVA: 0x002920B5 File Offset: 0x002902B5
		[NullableContext(1)]
		public IEnumerable<int> WaypointsEntityIdIter()
		{
			KurotatoWaypoints.<WaypointsEntityIdIter>d__16 <WaypointsEntityIdIter>d__ = new KurotatoWaypoints.<WaypointsEntityIdIter>d__16(-2);
			<WaypointsEntityIdIter>d__.<>3__<>4__this = this;
			return <WaypointsEntityIdIter>d__;
		}

		// Token: 0x04005431 RID: 21553
		private Table __p;
	}
}
