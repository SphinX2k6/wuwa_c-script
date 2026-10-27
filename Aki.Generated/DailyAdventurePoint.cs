using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BB1 RID: 2993
	public struct DailyAdventurePoint : IFlatbufferObject
	{
		// Token: 0x170009FD RID: 2557
		// (get) Token: 0x06005AEE RID: 23278 RVA: 0x00203095 File Offset: 0x00201295
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005AEF RID: 23279 RVA: 0x002030A2 File Offset: 0x002012A2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005AF0 RID: 23280 RVA: 0x002030AC File Offset: 0x002012AC
		public static DailyAdventurePoint GetRootAsDailyAdventurePoint(ByteBuffer _bb)
		{
			return DailyAdventurePoint.GetRootAsDailyAdventurePoint(_bb, default(DailyAdventurePoint));
		}

		// Token: 0x06005AF1 RID: 23281 RVA: 0x002030C8 File Offset: 0x002012C8
		public static DailyAdventurePoint GetRootAsDailyAdventurePoint(ByteBuffer _bb, DailyAdventurePoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005AF2 RID: 23282 RVA: 0x002030E5 File Offset: 0x002012E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005AF3 RID: 23283 RVA: 0x002030F4 File Offset: 0x002012F4
		public DailyAdventurePoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170009FE RID: 2558
		// (get) Token: 0x06005AF4 RID: 23284 RVA: 0x00203104 File Offset: 0x00201304
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

		// Token: 0x170009FF RID: 2559
		// (get) Token: 0x06005AF5 RID: 23285 RVA: 0x00203140 File Offset: 0x00201340
		public int NeedPt
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

		// Token: 0x17000A00 RID: 2560
		// (get) Token: 0x06005AF6 RID: 23286 RVA: 0x0020317C File Offset: 0x0020137C
		public int Drop
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

		// Token: 0x04004BD4 RID: 19412
		private Table __p;
	}
}
