using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DE0 RID: 3552
	public struct GiantItem : IFlatbufferObject
	{
		// Token: 0x170015ED RID: 5613
		// (get) Token: 0x0600807E RID: 32894 RVA: 0x00269B18 File Offset: 0x00267D18
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600807F RID: 32895 RVA: 0x00269B25 File Offset: 0x00267D25
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008080 RID: 32896 RVA: 0x00269B2C File Offset: 0x00267D2C
		public static GiantItem GetRootAsGiantItem(ByteBuffer _bb)
		{
			return GiantItem.GetRootAsGiantItem(_bb, default(GiantItem));
		}

		// Token: 0x06008081 RID: 32897 RVA: 0x00269B48 File Offset: 0x00267D48
		public static GiantItem GetRootAsGiantItem(ByteBuffer _bb, GiantItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008082 RID: 32898 RVA: 0x00269B65 File Offset: 0x00267D65
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008083 RID: 32899 RVA: 0x00269B74 File Offset: 0x00267D74
		public GiantItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170015EE RID: 5614
		// (get) Token: 0x06008084 RID: 32900 RVA: 0x00269B84 File Offset: 0x00267D84
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

		// Token: 0x170015EF RID: 5615
		// (get) Token: 0x06008085 RID: 32901 RVA: 0x00269BC0 File Offset: 0x00267DC0
		public int AddStableValue
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

		// Token: 0x170015F0 RID: 5616
		// (get) Token: 0x06008086 RID: 32902 RVA: 0x00269BFC File Offset: 0x00267DFC
		public int Quality
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

		// Token: 0x170015F1 RID: 5617
		// (get) Token: 0x06008087 RID: 32903 RVA: 0x00269C38 File Offset: 0x00267E38
		public int UnlockCondition
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

		// Token: 0x170015F2 RID: 5618
		// (get) Token: 0x06008088 RID: 32904 RVA: 0x00269C78 File Offset: 0x00267E78
		public int GiantEcoType
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04005353 RID: 21331
		private Table __p;
	}
}
