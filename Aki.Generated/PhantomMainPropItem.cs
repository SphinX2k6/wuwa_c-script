using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FD5 RID: 4053
	public struct PhantomMainPropItem : IFlatbufferObject
	{
		// Token: 0x17002783 RID: 10115
		// (get) Token: 0x0600AFAE RID: 44974 RVA: 0x002D2396 File Offset: 0x002D0596
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AFAF RID: 44975 RVA: 0x002D23A3 File Offset: 0x002D05A3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AFB0 RID: 44976 RVA: 0x002D23AC File Offset: 0x002D05AC
		public static PhantomMainPropItem GetRootAsPhantomMainPropItem(ByteBuffer _bb)
		{
			return PhantomMainPropItem.GetRootAsPhantomMainPropItem(_bb, default(PhantomMainPropItem));
		}

		// Token: 0x0600AFB1 RID: 44977 RVA: 0x002D23C8 File Offset: 0x002D05C8
		public static PhantomMainPropItem GetRootAsPhantomMainPropItem(ByteBuffer _bb, PhantomMainPropItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AFB2 RID: 44978 RVA: 0x002D23E5 File Offset: 0x002D05E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AFB3 RID: 44979 RVA: 0x002D23F4 File Offset: 0x002D05F4
		public PhantomMainPropItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002784 RID: 10116
		// (get) Token: 0x0600AFB4 RID: 44980 RVA: 0x002D2404 File Offset: 0x002D0604
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

		// Token: 0x17002785 RID: 10117
		// (get) Token: 0x0600AFB5 RID: 44981 RVA: 0x002D2440 File Offset: 0x002D0640
		public int PropId
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

		// Token: 0x17002786 RID: 10118
		// (get) Token: 0x0600AFB6 RID: 44982 RVA: 0x002D247C File Offset: 0x002D067C
		public int AddType
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

		// Token: 0x17002787 RID: 10119
		// (get) Token: 0x0600AFB7 RID: 44983 RVA: 0x002D24B8 File Offset: 0x002D06B8
		public int StandardProperty
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

		// Token: 0x17002788 RID: 10120
		// (get) Token: 0x0600AFB8 RID: 44984 RVA: 0x002D24F8 File Offset: 0x002D06F8
		public int GrowthId
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

		// Token: 0x04005597 RID: 21911
		private Table __p;
	}
}
