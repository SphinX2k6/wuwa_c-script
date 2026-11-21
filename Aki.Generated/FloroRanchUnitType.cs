using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DA2 RID: 3490
	public struct FloroRanchUnitType : IFlatbufferObject
	{
		// Token: 0x170013DE RID: 5086
		// (get) Token: 0x06007B2B RID: 31531 RVA: 0x0025E2B8 File Offset: 0x0025C4B8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007B2C RID: 31532 RVA: 0x0025E2C5 File Offset: 0x0025C4C5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007B2D RID: 31533 RVA: 0x0025E2CC File Offset: 0x0025C4CC
		public static FloroRanchUnitType GetRootAsFloroRanchUnitType(ByteBuffer _bb)
		{
			return FloroRanchUnitType.GetRootAsFloroRanchUnitType(_bb, default(FloroRanchUnitType));
		}

		// Token: 0x06007B2E RID: 31534 RVA: 0x0025E2E8 File Offset: 0x0025C4E8
		public static FloroRanchUnitType GetRootAsFloroRanchUnitType(ByteBuffer _bb, FloroRanchUnitType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007B2F RID: 31535 RVA: 0x0025E305 File Offset: 0x0025C505
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007B30 RID: 31536 RVA: 0x0025E314 File Offset: 0x0025C514
		public FloroRanchUnitType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170013DF RID: 5087
		// (get) Token: 0x06007B31 RID: 31537 RVA: 0x0025E324 File Offset: 0x0025C524
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

		// Token: 0x04005312 RID: 21266
		private Table __p;
	}
}
