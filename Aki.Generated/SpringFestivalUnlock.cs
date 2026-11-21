using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001224 RID: 4644
	public struct SpringFestivalUnlock : IFlatbufferObject
	{
		// Token: 0x17003B9F RID: 15263
		// (get) Token: 0x0600E65D RID: 58973 RVA: 0x0034C010 File Offset: 0x0034A210
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E65E RID: 58974 RVA: 0x0034C01D File Offset: 0x0034A21D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E65F RID: 58975 RVA: 0x0034C024 File Offset: 0x0034A224
		public static SpringFestivalUnlock GetRootAsSpringFestivalUnlock(ByteBuffer _bb)
		{
			return SpringFestivalUnlock.GetRootAsSpringFestivalUnlock(_bb, default(SpringFestivalUnlock));
		}

		// Token: 0x0600E660 RID: 58976 RVA: 0x0034C040 File Offset: 0x0034A240
		public static SpringFestivalUnlock GetRootAsSpringFestivalUnlock(ByteBuffer _bb, SpringFestivalUnlock obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E661 RID: 58977 RVA: 0x0034C05D File Offset: 0x0034A25D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E662 RID: 58978 RVA: 0x0034C06C File Offset: 0x0034A26C
		public SpringFestivalUnlock __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003BA0 RID: 15264
		// (get) Token: 0x0600E663 RID: 58979 RVA: 0x0034C07C File Offset: 0x0034A27C
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

		// Token: 0x17003BA1 RID: 15265
		// (get) Token: 0x0600E664 RID: 58980 RVA: 0x0034C0B8 File Offset: 0x0034A2B8
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

		// Token: 0x17003BA2 RID: 15266
		// (get) Token: 0x0600E665 RID: 58981 RVA: 0x0034C0F4 File Offset: 0x0034A2F4
		public int ConditionGroup
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

		// Token: 0x17003BA3 RID: 15267
		// (get) Token: 0x0600E666 RID: 58982 RVA: 0x0034C130 File Offset: 0x0034A330
		public int OpenDay
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

		// Token: 0x04005865 RID: 22629
		private Table __p;
	}
}
