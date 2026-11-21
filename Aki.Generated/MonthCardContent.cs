using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F05 RID: 3845
	public struct MonthCardContent : IFlatbufferObject
	{
		// Token: 0x17002013 RID: 8211
		// (get) Token: 0x06009BD7 RID: 39895 RVA: 0x002A6C2C File Offset: 0x002A4E2C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009BD8 RID: 39896 RVA: 0x002A6C39 File Offset: 0x002A4E39
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009BD9 RID: 39897 RVA: 0x002A6C40 File Offset: 0x002A4E40
		public static MonthCardContent GetRootAsMonthCardContent(ByteBuffer _bb)
		{
			return MonthCardContent.GetRootAsMonthCardContent(_bb, default(MonthCardContent));
		}

		// Token: 0x06009BDA RID: 39898 RVA: 0x002A6C5C File Offset: 0x002A4E5C
		public static MonthCardContent GetRootAsMonthCardContent(ByteBuffer _bb, MonthCardContent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009BDB RID: 39899 RVA: 0x002A6C79 File Offset: 0x002A4E79
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009BDC RID: 39900 RVA: 0x002A6C88 File Offset: 0x002A4E88
		public MonthCardContent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002014 RID: 8212
		// (get) Token: 0x06009BDD RID: 39901 RVA: 0x002A6C98 File Offset: 0x002A4E98
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

		// Token: 0x17002015 RID: 8213
		// (get) Token: 0x06009BDE RID: 39902 RVA: 0x002A6CD4 File Offset: 0x002A4ED4
		public int Days
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

		// Token: 0x17002016 RID: 8214
		// (get) Token: 0x06009BDF RID: 39903 RVA: 0x002A6D10 File Offset: 0x002A4F10
		public int ItemId
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

		// Token: 0x17002017 RID: 8215
		// (get) Token: 0x06009BE0 RID: 39904 RVA: 0x002A6D4C File Offset: 0x002A4F4C
		public int Count
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

		// Token: 0x040054AA RID: 21674
		private Table __p;
	}
}
