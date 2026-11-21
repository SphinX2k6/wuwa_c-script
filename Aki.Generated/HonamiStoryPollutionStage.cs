using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E2D RID: 3629
	public struct HonamiStoryPollutionStage : IFlatbufferObject
	{
		// Token: 0x17001879 RID: 6265
		// (get) Token: 0x06008709 RID: 34569 RVA: 0x00278101 File Offset: 0x00276301
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600870A RID: 34570 RVA: 0x0027810E File Offset: 0x0027630E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600870B RID: 34571 RVA: 0x00278118 File Offset: 0x00276318
		public static HonamiStoryPollutionStage GetRootAsHonamiStoryPollutionStage(ByteBuffer _bb)
		{
			return HonamiStoryPollutionStage.GetRootAsHonamiStoryPollutionStage(_bb, default(HonamiStoryPollutionStage));
		}

		// Token: 0x0600870C RID: 34572 RVA: 0x00278134 File Offset: 0x00276334
		public static HonamiStoryPollutionStage GetRootAsHonamiStoryPollutionStage(ByteBuffer _bb, HonamiStoryPollutionStage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600870D RID: 34573 RVA: 0x00278151 File Offset: 0x00276351
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600870E RID: 34574 RVA: 0x00278160 File Offset: 0x00276360
		public HonamiStoryPollutionStage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700187A RID: 6266
		// (get) Token: 0x0600870F RID: 34575 RVA: 0x00278170 File Offset: 0x00276370
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

		// Token: 0x1700187B RID: 6267
		// (get) Token: 0x06008710 RID: 34576 RVA: 0x002781AC File Offset: 0x002763AC
		public int WarningLevel
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

		// Token: 0x1700187C RID: 6268
		// (get) Token: 0x06008711 RID: 34577 RVA: 0x002781E8 File Offset: 0x002763E8
		public int DangerLevel
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

		// Token: 0x040053A9 RID: 21417
		private Table __p;
	}
}
