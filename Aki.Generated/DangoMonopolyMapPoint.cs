using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BDA RID: 3034
	public struct DangoMonopolyMapPoint : IFlatbufferObject
	{
		// Token: 0x17000BF5 RID: 3061
		// (get) Token: 0x06006085 RID: 24709 RVA: 0x0020FC35 File Offset: 0x0020DE35
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006086 RID: 24710 RVA: 0x0020FC42 File Offset: 0x0020DE42
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006087 RID: 24711 RVA: 0x0020FC4C File Offset: 0x0020DE4C
		public static DangoMonopolyMapPoint GetRootAsDangoMonopolyMapPoint(ByteBuffer _bb)
		{
			return DangoMonopolyMapPoint.GetRootAsDangoMonopolyMapPoint(_bb, default(DangoMonopolyMapPoint));
		}

		// Token: 0x06006088 RID: 24712 RVA: 0x0020FC68 File Offset: 0x0020DE68
		public static DangoMonopolyMapPoint GetRootAsDangoMonopolyMapPoint(ByteBuffer _bb, DangoMonopolyMapPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006089 RID: 24713 RVA: 0x0020FC85 File Offset: 0x0020DE85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600608A RID: 24714 RVA: 0x0020FC94 File Offset: 0x0020DE94
		public DangoMonopolyMapPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000BF6 RID: 3062
		// (get) Token: 0x0600608B RID: 24715 RVA: 0x0020FCA4 File Offset: 0x0020DEA4
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

		// Token: 0x17000BF7 RID: 3063
		// (get) Token: 0x0600608C RID: 24716 RVA: 0x0020FCE0 File Offset: 0x0020DEE0
		public int SeasonId
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

		// Token: 0x17000BF8 RID: 3064
		// (get) Token: 0x0600608D RID: 24717 RVA: 0x0020FD1C File Offset: 0x0020DF1C
		public int SortId
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

		// Token: 0x17000BF9 RID: 3065
		// (get) Token: 0x0600608E RID: 24718 RVA: 0x0020FD58 File Offset: 0x0020DF58
		public int EntityId
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

		// Token: 0x04004C07 RID: 19463
		private Table __p;
	}
}
