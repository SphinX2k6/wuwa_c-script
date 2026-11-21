using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012F0 RID: 4848
	public struct DicIntLong54 : IFlatbufferObject
	{
		// Token: 0x1700422E RID: 16942
		// (get) Token: 0x0600F786 RID: 63366 RVA: 0x003723A9 File Offset: 0x003705A9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F787 RID: 63367 RVA: 0x003723B6 File Offset: 0x003705B6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F788 RID: 63368 RVA: 0x003723C0 File Offset: 0x003705C0
		public static DicIntLong54 GetRootAsDicIntLong54(ByteBuffer _bb)
		{
			return DicIntLong54.GetRootAsDicIntLong54(_bb, default(DicIntLong54));
		}

		// Token: 0x0600F789 RID: 63369 RVA: 0x003723DC File Offset: 0x003705DC
		public static DicIntLong54 GetRootAsDicIntLong54(ByteBuffer _bb, DicIntLong54 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F78A RID: 63370 RVA: 0x003723F9 File Offset: 0x003705F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F78B RID: 63371 RVA: 0x00372408 File Offset: 0x00370608
		public DicIntLong54 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700422F RID: 16943
		// (get) Token: 0x0600F78C RID: 63372 RVA: 0x00372418 File Offset: 0x00370618
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

		// Token: 0x17004230 RID: 16944
		// (get) Token: 0x0600F78D RID: 63373 RVA: 0x00372454 File Offset: 0x00370654
		public long Value
		{
			get
			{
				int num = this.__p.__offset(6);
				return (long)((num != 0) ? this.__p.bb.GetDouble(num + this.__p.bb_pos) : 0.0);
			}
		}

		// Token: 0x0400594E RID: 22862
		private Table __p;
	}
}
