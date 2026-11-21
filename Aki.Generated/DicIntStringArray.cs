using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012F2 RID: 4850
	public struct DicIntStringArray : IFlatbufferObject
	{
		// Token: 0x17004234 RID: 16948
		// (get) Token: 0x0600F798 RID: 63384 RVA: 0x003725A1 File Offset: 0x003707A1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F799 RID: 63385 RVA: 0x003725AE File Offset: 0x003707AE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F79A RID: 63386 RVA: 0x003725B8 File Offset: 0x003707B8
		public static DicIntStringArray GetRootAsDicIntStringArray(ByteBuffer _bb)
		{
			return DicIntStringArray.GetRootAsDicIntStringArray(_bb, default(DicIntStringArray));
		}

		// Token: 0x0600F79B RID: 63387 RVA: 0x003725D4 File Offset: 0x003707D4
		public static DicIntStringArray GetRootAsDicIntStringArray(ByteBuffer _bb, DicIntStringArray obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F79C RID: 63388 RVA: 0x003725F1 File Offset: 0x003707F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F79D RID: 63389 RVA: 0x00372600 File Offset: 0x00370800
		public DicIntStringArray __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17004235 RID: 16949
		// (get) Token: 0x0600F79E RID: 63390 RVA: 0x00372610 File Offset: 0x00370810
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

		// Token: 0x17004236 RID: 16950
		// (get) Token: 0x0600F79F RID: 63391 RVA: 0x0037264C File Offset: 0x0037084C
		public StringArray? Value
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new StringArray?(default(StringArray).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x04005950 RID: 22864
		private Table __p;
	}
}
