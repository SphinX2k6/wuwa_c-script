using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D49 RID: 3401
	public struct HonamiStoryProp : IFlatbufferObject
	{
		// Token: 0x1700181A RID: 6170
		// (get) Token: 0x060080F8 RID: 33016 RVA: 0x00259A28 File Offset: 0x00257C28
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060080F9 RID: 33017 RVA: 0x00259A35 File Offset: 0x00257C35
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060080FA RID: 33018 RVA: 0x00259A3C File Offset: 0x00257C3C
		public static HonamiStoryProp GetRootAsHonamiStoryProp(ByteBuffer _bb)
		{
			return HonamiStoryProp.GetRootAsHonamiStoryProp(_bb, default(HonamiStoryProp));
		}

		// Token: 0x060080FB RID: 33019 RVA: 0x00259A58 File Offset: 0x00257C58
		public static HonamiStoryProp GetRootAsHonamiStoryProp(ByteBuffer _bb, HonamiStoryProp obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060080FC RID: 33020 RVA: 0x00259A75 File Offset: 0x00257C75
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060080FD RID: 33021 RVA: 0x00259A84 File Offset: 0x00257C84
		public HonamiStoryProp __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700181B RID: 6171
		// (get) Token: 0x060080FE RID: 33022 RVA: 0x00259A94 File Offset: 0x00257C94
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

		// Token: 0x1700181C RID: 6172
		// (get) Token: 0x060080FF RID: 33023 RVA: 0x00259AD0 File Offset: 0x00257CD0
		public int PropId
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

		// Token: 0x1700181D RID: 6173
		// (get) Token: 0x06008100 RID: 33024 RVA: 0x00259B0C File Offset: 0x00257D0C
		public int AddType
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

		// Token: 0x1700181E RID: 6174
		// (get) Token: 0x06008101 RID: 33025 RVA: 0x00259B48 File Offset: 0x00257D48
		public int StandardProperty
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

		// Token: 0x1700181F RID: 6175
		// (get) Token: 0x06008102 RID: 33026 RVA: 0x00259B88 File Offset: 0x00257D88
		public bool ShowPercent
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x04004DC5 RID: 19909
		private Table __p;
	}
}
