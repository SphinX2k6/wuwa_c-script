using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E24 RID: 3620
	public struct HonamiStoryMarkWhiteList : IFlatbufferObject
	{
		// Token: 0x17001841 RID: 6209
		// (get) Token: 0x06008680 RID: 34432 RVA: 0x00276E90 File Offset: 0x00275090
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008681 RID: 34433 RVA: 0x00276E9D File Offset: 0x0027509D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008682 RID: 34434 RVA: 0x00276EA4 File Offset: 0x002750A4
		public static HonamiStoryMarkWhiteList GetRootAsHonamiStoryMarkWhiteList(ByteBuffer _bb)
		{
			return HonamiStoryMarkWhiteList.GetRootAsHonamiStoryMarkWhiteList(_bb, default(HonamiStoryMarkWhiteList));
		}

		// Token: 0x06008683 RID: 34435 RVA: 0x00276EC0 File Offset: 0x002750C0
		public static HonamiStoryMarkWhiteList GetRootAsHonamiStoryMarkWhiteList(ByteBuffer _bb, HonamiStoryMarkWhiteList obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008684 RID: 34436 RVA: 0x00276EDD File Offset: 0x002750DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008685 RID: 34437 RVA: 0x00276EEC File Offset: 0x002750EC
		public HonamiStoryMarkWhiteList __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001842 RID: 6210
		// (get) Token: 0x06008686 RID: 34438 RVA: 0x00276EFC File Offset: 0x002750FC
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

		// Token: 0x17001843 RID: 6211
		// (get) Token: 0x06008687 RID: 34439 RVA: 0x00276F38 File Offset: 0x00275138
		public int AreaId
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

		// Token: 0x17001844 RID: 6212
		// (get) Token: 0x06008688 RID: 34440 RVA: 0x00276F74 File Offset: 0x00275174
		public int MultiMapId
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

		// Token: 0x0400539F RID: 21407
		private Table __p;
	}
}
