using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FB0 RID: 4016
	public struct RegressPayGift : IFlatbufferObject
	{
		// Token: 0x17002DB3 RID: 11699
		// (get) Token: 0x0600BB0F RID: 47887 RVA: 0x002DC204 File Offset: 0x002DA404
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BB10 RID: 47888 RVA: 0x002DC211 File Offset: 0x002DA411
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BB11 RID: 47889 RVA: 0x002DC218 File Offset: 0x002DA418
		public static RegressPayGift GetRootAsRegressPayGift(ByteBuffer _bb)
		{
			return RegressPayGift.GetRootAsRegressPayGift(_bb, default(RegressPayGift));
		}

		// Token: 0x0600BB12 RID: 47890 RVA: 0x002DC234 File Offset: 0x002DA434
		public static RegressPayGift GetRootAsRegressPayGift(ByteBuffer _bb, RegressPayGift obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BB13 RID: 47891 RVA: 0x002DC251 File Offset: 0x002DA451
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BB14 RID: 47892 RVA: 0x002DC260 File Offset: 0x002DA460
		public RegressPayGift __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002DB4 RID: 11700
		// (get) Token: 0x0600BB15 RID: 47893 RVA: 0x002DC270 File Offset: 0x002DA470
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

		// Token: 0x17002DB5 RID: 11701
		// (get) Token: 0x0600BB16 RID: 47894 RVA: 0x002DC2AC File Offset: 0x002DA4AC
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

		// Token: 0x04005089 RID: 20617
		private Table __p;
	}
}
