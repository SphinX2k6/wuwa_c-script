using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DC4 RID: 3524
	public struct GachaPool : IFlatbufferObject
	{
		// Token: 0x17001505 RID: 5381
		// (get) Token: 0x06007E28 RID: 32296 RVA: 0x00264984 File Offset: 0x00262B84
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007E29 RID: 32297 RVA: 0x00264991 File Offset: 0x00262B91
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007E2A RID: 32298 RVA: 0x00264998 File Offset: 0x00262B98
		public static GachaPool GetRootAsGachaPool(ByteBuffer _bb)
		{
			return GachaPool.GetRootAsGachaPool(_bb, default(GachaPool));
		}

		// Token: 0x06007E2B RID: 32299 RVA: 0x002649B4 File Offset: 0x00262BB4
		public static GachaPool GetRootAsGachaPool(ByteBuffer _bb, GachaPool obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007E2C RID: 32300 RVA: 0x002649D1 File Offset: 0x00262BD1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007E2D RID: 32301 RVA: 0x002649E0 File Offset: 0x00262BE0
		public GachaPool __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001506 RID: 5382
		// (get) Token: 0x06007E2E RID: 32302 RVA: 0x002649F0 File Offset: 0x00262BF0
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

		// Token: 0x17001507 RID: 5383
		// (get) Token: 0x06007E2F RID: 32303 RVA: 0x00264A2C File Offset: 0x00262C2C
		public int GachaId
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

		// Token: 0x17001508 RID: 5384
		// (get) Token: 0x06007E30 RID: 32304 RVA: 0x00264A68 File Offset: 0x00262C68
		public int Sort
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 10;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04005335 RID: 21301
		private Table __p;
	}
}
