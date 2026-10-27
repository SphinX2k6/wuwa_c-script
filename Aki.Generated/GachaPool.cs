using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CE0 RID: 3296
	public struct GachaPool : IFlatbufferObject
	{
		// Token: 0x170014A8 RID: 5288
		// (get) Token: 0x0600781D RID: 30749 RVA: 0x00245E08 File Offset: 0x00244008
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600781E RID: 30750 RVA: 0x00245E15 File Offset: 0x00244015
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600781F RID: 30751 RVA: 0x00245E1C File Offset: 0x0024401C
		public static GachaPool GetRootAsGachaPool(ByteBuffer _bb)
		{
			return GachaPool.GetRootAsGachaPool(_bb, default(GachaPool));
		}

		// Token: 0x06007820 RID: 30752 RVA: 0x00245E38 File Offset: 0x00244038
		public static GachaPool GetRootAsGachaPool(ByteBuffer _bb, GachaPool obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007821 RID: 30753 RVA: 0x00245E55 File Offset: 0x00244055
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007822 RID: 30754 RVA: 0x00245E64 File Offset: 0x00244064
		public GachaPool __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170014A9 RID: 5289
		// (get) Token: 0x06007823 RID: 30755 RVA: 0x00245E74 File Offset: 0x00244074
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

		// Token: 0x170014AA RID: 5290
		// (get) Token: 0x06007824 RID: 30756 RVA: 0x00245EB0 File Offset: 0x002440B0
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

		// Token: 0x170014AB RID: 5291
		// (get) Token: 0x06007825 RID: 30757 RVA: 0x00245EEC File Offset: 0x002440EC
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

		// Token: 0x04004D51 RID: 19793
		private Table __p;
	}
}
