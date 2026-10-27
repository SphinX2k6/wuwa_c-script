using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D60 RID: 3424
	public struct InfrArchiveItem : IFlatbufferObject
	{
		// Token: 0x170018D2 RID: 6354
		// (get) Token: 0x06008305 RID: 33541 RVA: 0x0025E065 File Offset: 0x0025C265
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008306 RID: 33542 RVA: 0x0025E072 File Offset: 0x0025C272
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008307 RID: 33543 RVA: 0x0025E07C File Offset: 0x0025C27C
		public static InfrArchiveItem GetRootAsInfrArchiveItem(ByteBuffer _bb)
		{
			return InfrArchiveItem.GetRootAsInfrArchiveItem(_bb, default(InfrArchiveItem));
		}

		// Token: 0x06008308 RID: 33544 RVA: 0x0025E098 File Offset: 0x0025C298
		public static InfrArchiveItem GetRootAsInfrArchiveItem(ByteBuffer _bb, InfrArchiveItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008309 RID: 33545 RVA: 0x0025E0B5 File Offset: 0x0025C2B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600830A RID: 33546 RVA: 0x0025E0C4 File Offset: 0x0025C2C4
		public InfrArchiveItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170018D3 RID: 6355
		// (get) Token: 0x0600830B RID: 33547 RVA: 0x0025E0D4 File Offset: 0x0025C2D4
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

		// Token: 0x170018D4 RID: 6356
		// (get) Token: 0x0600830C RID: 33548 RVA: 0x0025E110 File Offset: 0x0025C310
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

		// Token: 0x170018D5 RID: 6357
		// (get) Token: 0x0600830D RID: 33549 RVA: 0x0025E14C File Offset: 0x0025C34C
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

		// Token: 0x170018D6 RID: 6358
		// (get) Token: 0x0600830E RID: 33550 RVA: 0x0025E188 File Offset: 0x0025C388
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

		// Token: 0x170018D7 RID: 6359
		// (get) Token: 0x0600830F RID: 33551 RVA: 0x0025E1C8 File Offset: 0x0025C3C8
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

		// Token: 0x04004DDF RID: 19935
		private Table __p;
	}
}
