using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EAA RID: 3754
	public struct LifePointActivity : IFlatbufferObject
	{
		// Token: 0x17001D30 RID: 7472
		// (get) Token: 0x060093DC RID: 37852 RVA: 0x00295606 File Offset: 0x00293806
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060093DD RID: 37853 RVA: 0x00295613 File Offset: 0x00293813
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060093DE RID: 37854 RVA: 0x0029561C File Offset: 0x0029381C
		public static LifePointActivity GetRootAsLifePointActivity(ByteBuffer _bb)
		{
			return LifePointActivity.GetRootAsLifePointActivity(_bb, default(LifePointActivity));
		}

		// Token: 0x060093DF RID: 37855 RVA: 0x00295638 File Offset: 0x00293838
		public static LifePointActivity GetRootAsLifePointActivity(ByteBuffer _bb, LifePointActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060093E0 RID: 37856 RVA: 0x00295655 File Offset: 0x00293855
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060093E1 RID: 37857 RVA: 0x00295664 File Offset: 0x00293864
		public LifePointActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001D31 RID: 7473
		// (get) Token: 0x060093E2 RID: 37858 RVA: 0x00295674 File Offset: 0x00293874
		public int ActivityId
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

		// Token: 0x17001D32 RID: 7474
		// (get) Token: 0x060093E3 RID: 37859 RVA: 0x002956B0 File Offset: 0x002938B0
		public int MarkId
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

		// Token: 0x04005440 RID: 21568
		private Table __p;
	}
}
