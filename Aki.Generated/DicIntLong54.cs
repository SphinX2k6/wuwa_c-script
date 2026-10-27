using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011BA RID: 4538
	public struct DicIntLong54 : IFlatbufferObject
	{
		// Token: 0x17003EC9 RID: 16073
		// (get) Token: 0x0600EA15 RID: 59925 RVA: 0x0034771D File Offset: 0x0034591D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EA16 RID: 59926 RVA: 0x0034772A File Offset: 0x0034592A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EA17 RID: 59927 RVA: 0x00347734 File Offset: 0x00345934
		public static DicIntLong54 GetRootAsDicIntLong54(ByteBuffer _bb)
		{
			return DicIntLong54.GetRootAsDicIntLong54(_bb, default(DicIntLong54));
		}

		// Token: 0x0600EA18 RID: 59928 RVA: 0x00347750 File Offset: 0x00345950
		public static DicIntLong54 GetRootAsDicIntLong54(ByteBuffer _bb, DicIntLong54 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EA19 RID: 59929 RVA: 0x0034776D File Offset: 0x0034596D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EA1A RID: 59930 RVA: 0x0034777C File Offset: 0x0034597C
		public DicIntLong54 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003ECA RID: 16074
		// (get) Token: 0x0600EA1B RID: 59931 RVA: 0x0034778C File Offset: 0x0034598C
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

		// Token: 0x17003ECB RID: 16075
		// (get) Token: 0x0600EA1C RID: 59932 RVA: 0x003477C8 File Offset: 0x003459C8
		public long Value
		{
			get
			{
				int num = this.__p.__offset(6);
				return (long)((num != 0) ? this.__p.bb.GetDouble(num + this.__p.bb_pos) : 0.0);
			}
		}

		// Token: 0x0400530B RID: 21259
		private Table __p;
	}
}
