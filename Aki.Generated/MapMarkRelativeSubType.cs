using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DF0 RID: 3568
	public struct MapMarkRelativeSubType : IFlatbufferObject
	{
		// Token: 0x17001E28 RID: 7720
		// (get) Token: 0x0600916C RID: 37228 RVA: 0x0027F569 File Offset: 0x0027D769
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600916D RID: 37229 RVA: 0x0027F576 File Offset: 0x0027D776
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600916E RID: 37230 RVA: 0x0027F580 File Offset: 0x0027D780
		public static MapMarkRelativeSubType GetRootAsMapMarkRelativeSubType(ByteBuffer _bb)
		{
			return MapMarkRelativeSubType.GetRootAsMapMarkRelativeSubType(_bb, default(MapMarkRelativeSubType));
		}

		// Token: 0x0600916F RID: 37231 RVA: 0x0027F59C File Offset: 0x0027D79C
		public static MapMarkRelativeSubType GetRootAsMapMarkRelativeSubType(ByteBuffer _bb, MapMarkRelativeSubType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009170 RID: 37232 RVA: 0x0027F5B9 File Offset: 0x0027D7B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009171 RID: 37233 RVA: 0x0027F5C8 File Offset: 0x0027D7C8
		public MapMarkRelativeSubType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001E29 RID: 7721
		// (get) Token: 0x06009172 RID: 37234 RVA: 0x0027F5D8 File Offset: 0x0027D7D8
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

		// Token: 0x17001E2A RID: 7722
		// (get) Token: 0x06009173 RID: 37235 RVA: 0x0027F614 File Offset: 0x0027D814
		public int FunctionId
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

		// Token: 0x17001E2B RID: 7723
		// (get) Token: 0x06009174 RID: 37236 RVA: 0x0027F650 File Offset: 0x0027D850
		public IntVector? Position
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IntVector?(default(IntVector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17001E2C RID: 7724
		// (get) Token: 0x06009175 RID: 37237 RVA: 0x0027F6B0 File Offset: 0x0027D8B0
		public float Scale
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004E8D RID: 20109
		private Table __p;
	}
}
