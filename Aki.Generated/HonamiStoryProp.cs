using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E2E RID: 3630
	public struct HonamiStoryProp : IFlatbufferObject
	{
		// Token: 0x1700187D RID: 6269
		// (get) Token: 0x06008712 RID: 34578 RVA: 0x00278224 File Offset: 0x00276424
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008713 RID: 34579 RVA: 0x00278231 File Offset: 0x00276431
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008714 RID: 34580 RVA: 0x00278238 File Offset: 0x00276438
		public static HonamiStoryProp GetRootAsHonamiStoryProp(ByteBuffer _bb)
		{
			return HonamiStoryProp.GetRootAsHonamiStoryProp(_bb, default(HonamiStoryProp));
		}

		// Token: 0x06008715 RID: 34581 RVA: 0x00278254 File Offset: 0x00276454
		public static HonamiStoryProp GetRootAsHonamiStoryProp(ByteBuffer _bb, HonamiStoryProp obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008716 RID: 34582 RVA: 0x00278271 File Offset: 0x00276471
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008717 RID: 34583 RVA: 0x00278280 File Offset: 0x00276480
		public HonamiStoryProp __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700187E RID: 6270
		// (get) Token: 0x06008718 RID: 34584 RVA: 0x00278290 File Offset: 0x00276490
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

		// Token: 0x1700187F RID: 6271
		// (get) Token: 0x06008719 RID: 34585 RVA: 0x002782CC File Offset: 0x002764CC
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

		// Token: 0x17001880 RID: 6272
		// (get) Token: 0x0600871A RID: 34586 RVA: 0x00278308 File Offset: 0x00276508
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

		// Token: 0x17001881 RID: 6273
		// (get) Token: 0x0600871B RID: 34587 RVA: 0x00278344 File Offset: 0x00276544
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

		// Token: 0x17001882 RID: 6274
		// (get) Token: 0x0600871C RID: 34588 RVA: 0x00278384 File Offset: 0x00276584
		public bool ShowPercent
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x040053AA RID: 21418
		private Table __p;
	}
}
