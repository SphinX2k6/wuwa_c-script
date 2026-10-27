using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010EE RID: 4334
	public struct SpringFestivalUnlock : IFlatbufferObject
	{
		// Token: 0x17003849 RID: 14409
		// (get) Token: 0x0600D912 RID: 55570 RVA: 0x00320A8C File Offset: 0x0031EC8C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D913 RID: 55571 RVA: 0x00320A99 File Offset: 0x0031EC99
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D914 RID: 55572 RVA: 0x00320AA0 File Offset: 0x0031ECA0
		public static SpringFestivalUnlock GetRootAsSpringFestivalUnlock(ByteBuffer _bb)
		{
			return SpringFestivalUnlock.GetRootAsSpringFestivalUnlock(_bb, default(SpringFestivalUnlock));
		}

		// Token: 0x0600D915 RID: 55573 RVA: 0x00320ABC File Offset: 0x0031ECBC
		public static SpringFestivalUnlock GetRootAsSpringFestivalUnlock(ByteBuffer _bb, SpringFestivalUnlock obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D916 RID: 55574 RVA: 0x00320AD9 File Offset: 0x0031ECD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D917 RID: 55575 RVA: 0x00320AE8 File Offset: 0x0031ECE8
		public SpringFestivalUnlock __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700384A RID: 14410
		// (get) Token: 0x0600D918 RID: 55576 RVA: 0x00320AF8 File Offset: 0x0031ECF8
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

		// Token: 0x1700384B RID: 14411
		// (get) Token: 0x0600D919 RID: 55577 RVA: 0x00320B34 File Offset: 0x0031ED34
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

		// Token: 0x1700384C RID: 14412
		// (get) Token: 0x0600D91A RID: 55578 RVA: 0x00320B70 File Offset: 0x0031ED70
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

		// Token: 0x1700384D RID: 14413
		// (get) Token: 0x0600D91B RID: 55579 RVA: 0x00320BAC File Offset: 0x0031EDAC
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

		// Token: 0x04005222 RID: 21026
		private Table __p;
	}
}
