using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011B7 RID: 4535
	public struct DicIntInt : IFlatbufferObject
	{
		// Token: 0x17003EC0 RID: 16064
		// (get) Token: 0x0600E9FD RID: 59901 RVA: 0x0034742C File Offset: 0x0034562C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E9FE RID: 59902 RVA: 0x00347439 File Offset: 0x00345639
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E9FF RID: 59903 RVA: 0x00347440 File Offset: 0x00345640
		public static DicIntInt GetRootAsDicIntInt(ByteBuffer _bb)
		{
			return DicIntInt.GetRootAsDicIntInt(_bb, default(DicIntInt));
		}

		// Token: 0x0600EA00 RID: 59904 RVA: 0x0034745C File Offset: 0x0034565C
		public static DicIntInt GetRootAsDicIntInt(ByteBuffer _bb, DicIntInt obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EA01 RID: 59905 RVA: 0x00347479 File Offset: 0x00345679
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EA02 RID: 59906 RVA: 0x00347488 File Offset: 0x00345688
		public DicIntInt __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003EC1 RID: 16065
		// (get) Token: 0x0600EA03 RID: 59907 RVA: 0x00347498 File Offset: 0x00345698
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

		// Token: 0x17003EC2 RID: 16066
		// (get) Token: 0x0600EA04 RID: 59908 RVA: 0x003474D4 File Offset: 0x003456D4
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

		// Token: 0x04005308 RID: 21256
		private Table __p;
	}
}
