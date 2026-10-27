using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AEC RID: 2796
	public struct AiFlee : IFlatbufferObject
	{
		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06004698 RID: 18072 RVA: 0x001D2E14 File Offset: 0x001D1014
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004699 RID: 18073 RVA: 0x001D2E21 File Offset: 0x001D1021
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600469A RID: 18074 RVA: 0x001D2E28 File Offset: 0x001D1028
		public static AiFlee GetRootAsAiFlee(ByteBuffer _bb)
		{
			return AiFlee.GetRootAsAiFlee(_bb, default(AiFlee));
		}

		// Token: 0x0600469B RID: 18075 RVA: 0x001D2E44 File Offset: 0x001D1044
		public static AiFlee GetRootAsAiFlee(ByteBuffer _bb, AiFlee obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600469C RID: 18076 RVA: 0x001D2E61 File Offset: 0x001D1061
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600469D RID: 18077 RVA: 0x001D2E70 File Offset: 0x001D1070
		public AiFlee __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x0600469E RID: 18078 RVA: 0x001D2E80 File Offset: 0x001D1080
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

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x0600469F RID: 18079 RVA: 0x001D2EBC File Offset: 0x001D10BC
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

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x060046A0 RID: 18080 RVA: 0x001D2F1C File Offset: 0x001D111C
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

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x060046A1 RID: 18081 RVA: 0x001D2F7C File Offset: 0x001D117C
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

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x060046A2 RID: 18082 RVA: 0x001D2FC0 File Offset: 0x001D11C0
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

		// Token: 0x04004ACD RID: 19149
		private Table __p;
	}
}
