using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BC6 RID: 3014
	public struct AiFlee : IFlatbufferObject
	{
		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06004BDF RID: 19423 RVA: 0x001F27F4 File Offset: 0x001F09F4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004BE0 RID: 19424 RVA: 0x001F2801 File Offset: 0x001F0A01
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004BE1 RID: 19425 RVA: 0x001F2808 File Offset: 0x001F0A08
		public static AiFlee GetRootAsAiFlee(ByteBuffer _bb)
		{
			return AiFlee.GetRootAsAiFlee(_bb, default(AiFlee));
		}

		// Token: 0x06004BE2 RID: 19426 RVA: 0x001F2824 File Offset: 0x001F0A24
		public static AiFlee GetRootAsAiFlee(ByteBuffer _bb, AiFlee obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004BE3 RID: 19427 RVA: 0x001F2841 File Offset: 0x001F0A41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004BE4 RID: 19428 RVA: 0x001F2850 File Offset: 0x001F0A50
		public AiFlee __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06004BE5 RID: 19429 RVA: 0x001F2860 File Offset: 0x001F0A60
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

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06004BE6 RID: 19430 RVA: 0x001F289C File Offset: 0x001F0A9C
		public FloatRange? FleeDistance
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new FloatRange?(default(FloatRange).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06004BE7 RID: 19431 RVA: 0x001F28FC File Offset: 0x001F0AFC
		public FloatRange? FleeAngle
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new FloatRange?(default(FloatRange).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06004BE8 RID: 19432 RVA: 0x001F295C File Offset: 0x001F0B5C
		public float FleeHeight
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06004BE9 RID: 19433 RVA: 0x001F29A0 File Offset: 0x001F0BA0
		public float TimeMilliseconds
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 1000f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040050A7 RID: 20647
		private Table __p;
	}
}
