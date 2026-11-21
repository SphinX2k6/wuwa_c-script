using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012ED RID: 4845
	public struct DicIntInt : IFlatbufferObject
	{
		// Token: 0x17004225 RID: 16933
		// (get) Token: 0x0600F76E RID: 63342 RVA: 0x003720B8 File Offset: 0x003702B8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F76F RID: 63343 RVA: 0x003720C5 File Offset: 0x003702C5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F770 RID: 63344 RVA: 0x003720CC File Offset: 0x003702CC
		public static DicIntInt GetRootAsDicIntInt(ByteBuffer _bb)
		{
			return DicIntInt.GetRootAsDicIntInt(_bb, default(DicIntInt));
		}

		// Token: 0x0600F771 RID: 63345 RVA: 0x003720E8 File Offset: 0x003702E8
		public static DicIntInt GetRootAsDicIntInt(ByteBuffer _bb, DicIntInt obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F772 RID: 63346 RVA: 0x00372105 File Offset: 0x00370305
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F773 RID: 63347 RVA: 0x00372114 File Offset: 0x00370314
		public DicIntInt __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17004226 RID: 16934
		// (get) Token: 0x0600F774 RID: 63348 RVA: 0x00372124 File Offset: 0x00370324
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

		// Token: 0x17004227 RID: 16935
		// (get) Token: 0x0600F775 RID: 63349 RVA: 0x00372160 File Offset: 0x00370360
		public int Value
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

		// Token: 0x0400594B RID: 22859
		private Table __p;
	}
}
