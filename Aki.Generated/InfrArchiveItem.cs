using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E45 RID: 3653
	public struct InfrArchiveItem : IFlatbufferObject
	{
		// Token: 0x17001935 RID: 6453
		// (get) Token: 0x0600891F RID: 35103 RVA: 0x0027C715 File Offset: 0x0027A915
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008920 RID: 35104 RVA: 0x0027C722 File Offset: 0x0027A922
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008921 RID: 35105 RVA: 0x0027C72C File Offset: 0x0027A92C
		public static InfrArchiveItem GetRootAsInfrArchiveItem(ByteBuffer _bb)
		{
			return InfrArchiveItem.GetRootAsInfrArchiveItem(_bb, default(InfrArchiveItem));
		}

		// Token: 0x06008922 RID: 35106 RVA: 0x0027C748 File Offset: 0x0027A948
		public static InfrArchiveItem GetRootAsInfrArchiveItem(ByteBuffer _bb, InfrArchiveItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008923 RID: 35107 RVA: 0x0027C765 File Offset: 0x0027A965
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008924 RID: 35108 RVA: 0x0027C774 File Offset: 0x0027A974
		public InfrArchiveItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001936 RID: 6454
		// (get) Token: 0x06008925 RID: 35109 RVA: 0x0027C784 File Offset: 0x0027A984
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

		// Token: 0x17001937 RID: 6455
		// (get) Token: 0x06008926 RID: 35110 RVA: 0x0027C7C0 File Offset: 0x0027A9C0
		public int ItemId
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

		// Token: 0x17001938 RID: 6456
		// (get) Token: 0x06008927 RID: 35111 RVA: 0x0027C7FC File Offset: 0x0027A9FC
		public int AccessPath
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

		// Token: 0x17001939 RID: 6457
		// (get) Token: 0x06008928 RID: 35112 RVA: 0x0027C838 File Offset: 0x0027AA38
		public int InfoDisplayId
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

		// Token: 0x1700193A RID: 6458
		// (get) Token: 0x06008929 RID: 35113 RVA: 0x0027C878 File Offset: 0x0027AA78
		public int EffectId
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

		// Token: 0x040053C4 RID: 21444
		private Table __p;
	}
}
