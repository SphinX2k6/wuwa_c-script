using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E82 RID: 3714
	public struct KurotatoExp : IFlatbufferObject
	{
		// Token: 0x17001BBF RID: 7103
		// (get) Token: 0x06008F88 RID: 36744 RVA: 0x0028C3F5 File Offset: 0x0028A5F5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008F89 RID: 36745 RVA: 0x0028C402 File Offset: 0x0028A602
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008F8A RID: 36746 RVA: 0x0028C40C File Offset: 0x0028A60C
		public static KurotatoExp GetRootAsKurotatoExp(ByteBuffer _bb)
		{
			return KurotatoExp.GetRootAsKurotatoExp(_bb, default(KurotatoExp));
		}

		// Token: 0x06008F8B RID: 36747 RVA: 0x0028C428 File Offset: 0x0028A628
		public static KurotatoExp GetRootAsKurotatoExp(ByteBuffer _bb, KurotatoExp obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008F8C RID: 36748 RVA: 0x0028C445 File Offset: 0x0028A645
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008F8D RID: 36749 RVA: 0x0028C454 File Offset: 0x0028A654
		public KurotatoExp __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001BC0 RID: 7104
		// (get) Token: 0x06008F8E RID: 36750 RVA: 0x0028C464 File Offset: 0x0028A664
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

		// Token: 0x17001BC1 RID: 7105
		// (get) Token: 0x06008F8F RID: 36751 RVA: 0x0028C4A0 File Offset: 0x0028A6A0
		public int RoleLevel
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

		// Token: 0x17001BC2 RID: 7106
		// (get) Token: 0x06008F90 RID: 36752 RVA: 0x0028C4DC File Offset: 0x0028A6DC
		public int ActivityId
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

		// Token: 0x17001BC3 RID: 7107
		// (get) Token: 0x06008F91 RID: 36753 RVA: 0x0028C518 File Offset: 0x0028A718
		public int LevelExp
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001BC4 RID: 7108
		// (get) Token: 0x06008F92 RID: 36754 RVA: 0x0028C558 File Offset: 0x0028A758
		public int Type
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04005412 RID: 21522
		private Table __p;
	}
}
