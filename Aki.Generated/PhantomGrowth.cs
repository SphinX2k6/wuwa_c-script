using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EEA RID: 3818
	public struct PhantomGrowth : IFlatbufferObject
	{
		// Token: 0x170026DB RID: 9947
		// (get) Token: 0x0600A8CE RID: 43214 RVA: 0x002B3A4C File Offset: 0x002B1C4C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A8CF RID: 43215 RVA: 0x002B3A59 File Offset: 0x002B1C59
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A8D0 RID: 43216 RVA: 0x002B3A60 File Offset: 0x002B1C60
		public static PhantomGrowth GetRootAsPhantomGrowth(ByteBuffer _bb)
		{
			return PhantomGrowth.GetRootAsPhantomGrowth(_bb, default(PhantomGrowth));
		}

		// Token: 0x0600A8D1 RID: 43217 RVA: 0x002B3A7C File Offset: 0x002B1C7C
		public static PhantomGrowth GetRootAsPhantomGrowth(ByteBuffer _bb, PhantomGrowth obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A8D2 RID: 43218 RVA: 0x002B3A99 File Offset: 0x002B1C99
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A8D3 RID: 43219 RVA: 0x002B3AA8 File Offset: 0x002B1CA8
		public PhantomGrowth __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170026DC RID: 9948
		// (get) Token: 0x0600A8D4 RID: 43220 RVA: 0x002B3AB8 File Offset: 0x002B1CB8
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

		// Token: 0x170026DD RID: 9949
		// (get) Token: 0x0600A8D5 RID: 43221 RVA: 0x002B3AF4 File Offset: 0x002B1CF4
		public int GrowthId
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

		// Token: 0x170026DE RID: 9950
		// (get) Token: 0x0600A8D6 RID: 43222 RVA: 0x002B3B30 File Offset: 0x002B1D30
		public int Level
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

		// Token: 0x170026DF RID: 9951
		// (get) Token: 0x0600A8D7 RID: 43223 RVA: 0x002B3B6C File Offset: 0x002B1D6C
		public int Value
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

		// Token: 0x04004FAC RID: 20396
		private Table __p;
	}
}
