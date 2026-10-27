using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CFB RID: 3323
	public struct GiantItem : IFlatbufferObject
	{
		// Token: 0x1700158C RID: 5516
		// (get) Token: 0x06007A66 RID: 31334 RVA: 0x0024AFA8 File Offset: 0x002491A8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007A67 RID: 31335 RVA: 0x0024AFB5 File Offset: 0x002491B5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007A68 RID: 31336 RVA: 0x0024AFBC File Offset: 0x002491BC
		public static GiantItem GetRootAsGiantItem(ByteBuffer _bb)
		{
			return GiantItem.GetRootAsGiantItem(_bb, default(GiantItem));
		}

		// Token: 0x06007A69 RID: 31337 RVA: 0x0024AFD8 File Offset: 0x002491D8
		public static GiantItem GetRootAsGiantItem(ByteBuffer _bb, GiantItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007A6A RID: 31338 RVA: 0x0024AFF5 File Offset: 0x002491F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007A6B RID: 31339 RVA: 0x0024B004 File Offset: 0x00249204
		public GiantItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700158D RID: 5517
		// (get) Token: 0x06007A6C RID: 31340 RVA: 0x0024B014 File Offset: 0x00249214
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

		// Token: 0x1700158E RID: 5518
		// (get) Token: 0x06007A6D RID: 31341 RVA: 0x0024B050 File Offset: 0x00249250
		public int AddStableValue
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

		// Token: 0x1700158F RID: 5519
		// (get) Token: 0x06007A6E RID: 31342 RVA: 0x0024B08C File Offset: 0x0024928C
		public int Quality
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

		// Token: 0x17001590 RID: 5520
		// (get) Token: 0x06007A6F RID: 31343 RVA: 0x0024B0C8 File Offset: 0x002492C8
		public int UnlockCondition
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

		// Token: 0x17001591 RID: 5521
		// (get) Token: 0x06007A70 RID: 31344 RVA: 0x0024B108 File Offset: 0x00249308
		public int GiantEcoType
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

		// Token: 0x04004D6E RID: 19822
		private Table __p;
	}
}
