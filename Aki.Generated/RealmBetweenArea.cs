using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F98 RID: 3992
	public struct RealmBetweenArea : IFlatbufferObject
	{
		// Token: 0x17002D07 RID: 11527
		// (get) Token: 0x0600B927 RID: 47399 RVA: 0x002D7A5A File Offset: 0x002D5C5A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B928 RID: 47400 RVA: 0x002D7A67 File Offset: 0x002D5C67
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B929 RID: 47401 RVA: 0x002D7A70 File Offset: 0x002D5C70
		public static RealmBetweenArea GetRootAsRealmBetweenArea(ByteBuffer _bb)
		{
			return RealmBetweenArea.GetRootAsRealmBetweenArea(_bb, default(RealmBetweenArea));
		}

		// Token: 0x0600B92A RID: 47402 RVA: 0x002D7A8C File Offset: 0x002D5C8C
		public static RealmBetweenArea GetRootAsRealmBetweenArea(ByteBuffer _bb, RealmBetweenArea obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B92B RID: 47403 RVA: 0x002D7AA9 File Offset: 0x002D5CA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B92C RID: 47404 RVA: 0x002D7AB8 File Offset: 0x002D5CB8
		public RealmBetweenArea __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002D08 RID: 11528
		// (get) Token: 0x0600B92D RID: 47405 RVA: 0x002D7AC8 File Offset: 0x002D5CC8
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

		// Token: 0x17002D09 RID: 11529
		// (get) Token: 0x0600B92E RID: 47406 RVA: 0x002D7B04 File Offset: 0x002D5D04
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

		// Token: 0x17002D0A RID: 11530
		// (get) Token: 0x0600B92F RID: 47407 RVA: 0x002D7B40 File Offset: 0x002D5D40
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

		// Token: 0x17002D0B RID: 11531
		// (get) Token: 0x0600B930 RID: 47408 RVA: 0x002D7B7C File Offset: 0x002D5D7C
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

		// Token: 0x17002D0C RID: 11532
		// (get) Token: 0x0600B931 RID: 47409 RVA: 0x002D7BBC File Offset: 0x002D5DBC
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

		// Token: 0x04005068 RID: 20584
		private Table __p;
	}
}
