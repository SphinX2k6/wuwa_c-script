using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200107F RID: 4223
	public struct RealmBetweenArea : IFlatbufferObject
	{
		// Token: 0x17002D7F RID: 11647
		// (get) Token: 0x0600BF64 RID: 48996 RVA: 0x002F4272 File Offset: 0x002F2472
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BF65 RID: 48997 RVA: 0x002F427F File Offset: 0x002F247F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BF66 RID: 48998 RVA: 0x002F4288 File Offset: 0x002F2488
		public static RealmBetweenArea GetRootAsRealmBetweenArea(ByteBuffer _bb)
		{
			return RealmBetweenArea.GetRootAsRealmBetweenArea(_bb, default(RealmBetweenArea));
		}

		// Token: 0x0600BF67 RID: 48999 RVA: 0x002F42A4 File Offset: 0x002F24A4
		public static RealmBetweenArea GetRootAsRealmBetweenArea(ByteBuffer _bb, RealmBetweenArea obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BF68 RID: 49000 RVA: 0x002F42C1 File Offset: 0x002F24C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BF69 RID: 49001 RVA: 0x002F42D0 File Offset: 0x002F24D0
		public RealmBetweenArea __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002D80 RID: 11648
		// (get) Token: 0x0600BF6A RID: 49002 RVA: 0x002F42E0 File Offset: 0x002F24E0
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

		// Token: 0x17002D81 RID: 11649
		// (get) Token: 0x0600BF6B RID: 49003 RVA: 0x002F431C File Offset: 0x002F251C
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

		// Token: 0x17002D82 RID: 11650
		// (get) Token: 0x0600BF6C RID: 49004 RVA: 0x002F4358 File Offset: 0x002F2558
		public int UnLockCondition
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

		// Token: 0x17002D83 RID: 11651
		// (get) Token: 0x0600BF6D RID: 49005 RVA: 0x002F4394 File Offset: 0x002F2594
		public int UnlockAccessId
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

		// Token: 0x17002D84 RID: 11652
		// (get) Token: 0x0600BF6E RID: 49006 RVA: 0x002F43D4 File Offset: 0x002F25D4
		public int Sort
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

		// Token: 0x0400564F RID: 22095
		private Table __p;
	}
}
