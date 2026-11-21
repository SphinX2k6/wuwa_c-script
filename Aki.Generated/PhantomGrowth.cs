using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FCF RID: 4047
	public struct PhantomGrowth : IFlatbufferObject
	{
		// Token: 0x17002741 RID: 10049
		// (get) Token: 0x0600AEEF RID: 44783 RVA: 0x002D0A78 File Offset: 0x002CEC78
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AEF0 RID: 44784 RVA: 0x002D0A85 File Offset: 0x002CEC85
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AEF1 RID: 44785 RVA: 0x002D0A8C File Offset: 0x002CEC8C
		public static PhantomGrowth GetRootAsPhantomGrowth(ByteBuffer _bb)
		{
			return PhantomGrowth.GetRootAsPhantomGrowth(_bb, default(PhantomGrowth));
		}

		// Token: 0x0600AEF2 RID: 44786 RVA: 0x002D0AA8 File Offset: 0x002CECA8
		public static PhantomGrowth GetRootAsPhantomGrowth(ByteBuffer _bb, PhantomGrowth obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AEF3 RID: 44787 RVA: 0x002D0AC5 File Offset: 0x002CECC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AEF4 RID: 44788 RVA: 0x002D0AD4 File Offset: 0x002CECD4
		public PhantomGrowth __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002742 RID: 10050
		// (get) Token: 0x0600AEF5 RID: 44789 RVA: 0x002D0AE4 File Offset: 0x002CECE4
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

		// Token: 0x17002743 RID: 10051
		// (get) Token: 0x0600AEF6 RID: 44790 RVA: 0x002D0B20 File Offset: 0x002CED20
		public int GrowthId
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

		// Token: 0x17002744 RID: 10052
		// (get) Token: 0x0600AEF7 RID: 44791 RVA: 0x002D0B5C File Offset: 0x002CED5C
		public int Level
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

		// Token: 0x17002745 RID: 10053
		// (get) Token: 0x0600AEF8 RID: 44792 RVA: 0x002D0B98 File Offset: 0x002CED98
		public int Value
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

		// Token: 0x04005591 RID: 21905
		private Table __p;
	}
}
