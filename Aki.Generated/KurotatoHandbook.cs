using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DA0 RID: 3488
	public struct KurotatoHandbook : IFlatbufferObject
	{
		// Token: 0x17001B79 RID: 7033
		// (get) Token: 0x060089A5 RID: 35237 RVA: 0x0026E220 File Offset: 0x0026C420
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060089A6 RID: 35238 RVA: 0x0026E22D File Offset: 0x0026C42D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060089A7 RID: 35239 RVA: 0x0026E234 File Offset: 0x0026C434
		public static KurotatoHandbook GetRootAsKurotatoHandbook(ByteBuffer _bb)
		{
			return KurotatoHandbook.GetRootAsKurotatoHandbook(_bb, default(KurotatoHandbook));
		}

		// Token: 0x060089A8 RID: 35240 RVA: 0x0026E250 File Offset: 0x0026C450
		public static KurotatoHandbook GetRootAsKurotatoHandbook(ByteBuffer _bb, KurotatoHandbook obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060089A9 RID: 35241 RVA: 0x0026E26D File Offset: 0x0026C46D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060089AA RID: 35242 RVA: 0x0026E27C File Offset: 0x0026C47C
		public KurotatoHandbook __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001B7A RID: 7034
		// (get) Token: 0x060089AB RID: 35243 RVA: 0x0026E28C File Offset: 0x0026C48C
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

		// Token: 0x17001B7B RID: 7035
		// (get) Token: 0x060089AC RID: 35244 RVA: 0x0026E2C8 File Offset: 0x0026C4C8
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

		// Token: 0x17001B7C RID: 7036
		// (get) Token: 0x060089AD RID: 35245 RVA: 0x0026E304 File Offset: 0x0026C504
		public int Type
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

		// Token: 0x17001B7D RID: 7037
		// (get) Token: 0x060089AE RID: 35246 RVA: 0x0026E340 File Offset: 0x0026C540
		public int Index
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

		// Token: 0x04004E31 RID: 20017
		private Table __p;
	}
}
