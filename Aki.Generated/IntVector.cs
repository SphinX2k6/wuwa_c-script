using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011CF RID: 4559
	public struct IntVector : IFlatbufferObject
	{
		// Token: 0x17003EF3 RID: 16115
		// (get) Token: 0x0600EAA9 RID: 60073 RVA: 0x003487C0 File Offset: 0x003469C0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EAAA RID: 60074 RVA: 0x003487CD File Offset: 0x003469CD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EAAB RID: 60075 RVA: 0x003487D4 File Offset: 0x003469D4
		public static IntVector GetRootAsIntVector(ByteBuffer _bb)
		{
			return IntVector.GetRootAsIntVector(_bb, default(IntVector));
		}

		// Token: 0x0600EAAC RID: 60076 RVA: 0x003487F0 File Offset: 0x003469F0
		public static IntVector GetRootAsIntVector(ByteBuffer _bb, IntVector obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EAAD RID: 60077 RVA: 0x0034880D File Offset: 0x00346A0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EAAE RID: 60078 RVA: 0x0034881C File Offset: 0x00346A1C
		public IntVector __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003EF4 RID: 16116
		// (get) Token: 0x0600EAAF RID: 60079 RVA: 0x0034882C File Offset: 0x00346A2C
		public int X
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

		// Token: 0x17003EF5 RID: 16117
		// (get) Token: 0x0600EAB0 RID: 60080 RVA: 0x00348868 File Offset: 0x00346A68
		public int Y
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

		// Token: 0x17003EF6 RID: 16118
		// (get) Token: 0x0600EAB1 RID: 60081 RVA: 0x003488A4 File Offset: 0x00346AA4
		public int Z
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

		// Token: 0x0400533D RID: 21309
		private Table __p;
	}
}
