using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FD3 RID: 4051
	public struct PhantomLevel : IFlatbufferObject
	{
		// Token: 0x1700277A RID: 10106
		// (get) Token: 0x0600AF96 RID: 44950 RVA: 0x002D20A4 File Offset: 0x002D02A4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AF97 RID: 44951 RVA: 0x002D20B1 File Offset: 0x002D02B1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AF98 RID: 44952 RVA: 0x002D20B8 File Offset: 0x002D02B8
		public static PhantomLevel GetRootAsPhantomLevel(ByteBuffer _bb)
		{
			return PhantomLevel.GetRootAsPhantomLevel(_bb, default(PhantomLevel));
		}

		// Token: 0x0600AF99 RID: 44953 RVA: 0x002D20D4 File Offset: 0x002D02D4
		public static PhantomLevel GetRootAsPhantomLevel(ByteBuffer _bb, PhantomLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AF9A RID: 44954 RVA: 0x002D20F1 File Offset: 0x002D02F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AF9B RID: 44955 RVA: 0x002D2100 File Offset: 0x002D0300
		public PhantomLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700277B RID: 10107
		// (get) Token: 0x0600AF9C RID: 44956 RVA: 0x002D2110 File Offset: 0x002D0310
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

		// Token: 0x1700277C RID: 10108
		// (get) Token: 0x0600AF9D RID: 44957 RVA: 0x002D214C File Offset: 0x002D034C
		public int GroupId
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

		// Token: 0x1700277D RID: 10109
		// (get) Token: 0x0600AF9E RID: 44958 RVA: 0x002D2188 File Offset: 0x002D0388
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

		// Token: 0x1700277E RID: 10110
		// (get) Token: 0x0600AF9F RID: 44959 RVA: 0x002D21C4 File Offset: 0x002D03C4
		public int Exp
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

		// Token: 0x04005595 RID: 21909
		private Table __p;
	}
}
