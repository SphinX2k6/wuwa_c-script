using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D48 RID: 3400
	public struct HonamiStoryPollutionStage : IFlatbufferObject
	{
		// Token: 0x17001816 RID: 6166
		// (get) Token: 0x060080EF RID: 33007 RVA: 0x00259905 File Offset: 0x00257B05
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060080F0 RID: 33008 RVA: 0x00259912 File Offset: 0x00257B12
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060080F1 RID: 33009 RVA: 0x0025991C File Offset: 0x00257B1C
		public static HonamiStoryPollutionStage GetRootAsHonamiStoryPollutionStage(ByteBuffer _bb)
		{
			return HonamiStoryPollutionStage.GetRootAsHonamiStoryPollutionStage(_bb, default(HonamiStoryPollutionStage));
		}

		// Token: 0x060080F2 RID: 33010 RVA: 0x00259938 File Offset: 0x00257B38
		public static HonamiStoryPollutionStage GetRootAsHonamiStoryPollutionStage(ByteBuffer _bb, HonamiStoryPollutionStage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060080F3 RID: 33011 RVA: 0x00259955 File Offset: 0x00257B55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060080F4 RID: 33012 RVA: 0x00259964 File Offset: 0x00257B64
		public HonamiStoryPollutionStage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001817 RID: 6167
		// (get) Token: 0x060080F5 RID: 33013 RVA: 0x00259974 File Offset: 0x00257B74
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

		// Token: 0x17001818 RID: 6168
		// (get) Token: 0x060080F6 RID: 33014 RVA: 0x002599B0 File Offset: 0x00257BB0
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

		// Token: 0x17001819 RID: 6169
		// (get) Token: 0x060080F7 RID: 33015 RVA: 0x002599EC File Offset: 0x00257BEC
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

		// Token: 0x04004DC4 RID: 19908
		private Table __p;
	}
}
