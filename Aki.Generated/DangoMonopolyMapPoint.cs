using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CBC RID: 3260
	public struct DangoMonopolyMapPoint : IFlatbufferObject
	{
		// Token: 0x17000C3B RID: 3131
		// (get) Token: 0x0600665E RID: 26206 RVA: 0x0022F29A File Offset: 0x0022D49A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600665F RID: 26207 RVA: 0x0022F2A7 File Offset: 0x0022D4A7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006660 RID: 26208 RVA: 0x0022F2B0 File Offset: 0x0022D4B0
		public static DangoMonopolyMapPoint GetRootAsDangoMonopolyMapPoint(ByteBuffer _bb)
		{
			return DangoMonopolyMapPoint.GetRootAsDangoMonopolyMapPoint(_bb, default(DangoMonopolyMapPoint));
		}

		// Token: 0x06006661 RID: 26209 RVA: 0x0022F2CC File Offset: 0x0022D4CC
		public static DangoMonopolyMapPoint GetRootAsDangoMonopolyMapPoint(ByteBuffer _bb, DangoMonopolyMapPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006662 RID: 26210 RVA: 0x0022F2E9 File Offset: 0x0022D4E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006663 RID: 26211 RVA: 0x0022F2F8 File Offset: 0x0022D4F8
		public DangoMonopolyMapPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000C3C RID: 3132
		// (get) Token: 0x06006664 RID: 26212 RVA: 0x0022F308 File Offset: 0x0022D508
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

		// Token: 0x17000C3D RID: 3133
		// (get) Token: 0x06006665 RID: 26213 RVA: 0x0022F344 File Offset: 0x0022D544
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

		// Token: 0x17000C3E RID: 3134
		// (get) Token: 0x06006666 RID: 26214 RVA: 0x0022F380 File Offset: 0x0022D580
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

		// Token: 0x17000C3F RID: 3135
		// (get) Token: 0x06006667 RID: 26215 RVA: 0x0022F3BC File Offset: 0x0022D5BC
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

		// Token: 0x040051E9 RID: 20969
		private Table __p;
	}
}
