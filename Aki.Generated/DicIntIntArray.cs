using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012EE RID: 4846
	public struct DicIntIntArray : IFlatbufferObject
	{
		// Token: 0x17004228 RID: 16936
		// (get) Token: 0x0600F776 RID: 63350 RVA: 0x0037219C File Offset: 0x0037039C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F777 RID: 63351 RVA: 0x003721A9 File Offset: 0x003703A9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F778 RID: 63352 RVA: 0x003721B0 File Offset: 0x003703B0
		public static DicIntIntArray GetRootAsDicIntIntArray(ByteBuffer _bb)
		{
			return DicIntIntArray.GetRootAsDicIntIntArray(_bb, default(DicIntIntArray));
		}

		// Token: 0x0600F779 RID: 63353 RVA: 0x003721CC File Offset: 0x003703CC
		public static DicIntIntArray GetRootAsDicIntIntArray(ByteBuffer _bb, DicIntIntArray obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F77A RID: 63354 RVA: 0x003721E9 File Offset: 0x003703E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F77B RID: 63355 RVA: 0x003721F8 File Offset: 0x003703F8
		public DicIntIntArray __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17004229 RID: 16937
		// (get) Token: 0x0600F77C RID: 63356 RVA: 0x00372208 File Offset: 0x00370408
		public int Key
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

		// Token: 0x1700422A RID: 16938
		// (get) Token: 0x0600F77D RID: 63357 RVA: 0x00372244 File Offset: 0x00370444
		public IntArray? Value
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IntArray?(default(IntArray).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0400594C RID: 22860
		private Table __p;
	}
}
